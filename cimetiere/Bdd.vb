Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Runtime.CompilerServices

Module Bdd

    Private Pks As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
        {"beneficiaires", "ben_id"},
        {"concessionnaires", "csnr_id"},
        {"concessions", "con_id"},
        {"defunts", "def_id"},
        {"emplacements", "empl_id"},
        {"personnes_contact", "pc_id"},
        {"t_commentaire", "com_id"},
        {"t_histoire", "h_id"},
        {"t_loc_ville", "locville_id"},
        {"t_login", "id"},
        {"t_pays", "Pays_id"}
    }

    Private Const ConnStr As String = "Server=" & ConfigLocale.BddHost & ";User Id=" & ConfigLocale.BddUser & "; Password=" & ConfigLocale.BddPass & "; Database=" & ConfigLocale.BddNom & "; Pooling=false"
    Private Connexion As New MySqlConnection With {.ConnectionString = ConnStr}

    Public Function Query(sql As String) As DataTable
        Using Req As New MySqlCommand With {
               .Connection = Connexion,
               .CommandText = sql,
               .CommandType = CommandType.Text},
              Adapt = New MySqlDataAdapter With {.SelectCommand = Req},
              dset = New DataSet
            Adapt.Fill(dset)
            Return dset.Tables(0)
        End Using
    End Function

    Public Function NonQuery(sql As String) As Integer
        Using Req As New MySqlCommand(sql, Connexion)
            Req.CommandType = CommandType.Text
            Connexion.Open()
            Try
                Return Req.ExecuteNonQuery()
            Finally
                Connexion.Close()
            End Try
        End Using
    End Function

    ' considère que la première colonne est la PK
    ' renvoie le nombre de ligne concernées (1 ou 0 du coup)
    Public Function Update(nomtable As String, row As DataRow)
        Dim sql = "UPDATE " & nomtable & " SET "
        Dim cmd = New MySqlCommand With {.Connection = Connexion, .CommandType = CommandType.Text}

        Dim tvide = GetTableVide(nomtable)

        Dim pasprem = False
        For i = 1 To tvide.Columns.Count - 1
            If pasprem Then sql &= ", " Else pasprem = True
            Dim nomcol = tvide.Columns(i).Caption
            sql &= nomcol & " = @" & nomcol
            cmd.Parameters.AddWithValue("@" & nomcol, (row(i)))
        Next

        sql &= " WHERE " & tvide.Columns(0).Caption & " = @" & tvide.Columns(0).Caption
        cmd.Parameters.AddWithValue("@" & tvide.Columns(0).Caption, row(0))
        cmd.CommandText = sql

        Connexion.Open()

        Try
            Return cmd.ExecuteNonQuery()
        Finally
            Connexion.Close()
        End Try
    End Function

    Public Function GetTable(nomtable As String) As DataTable
        Return Query("SELECT * FROM " & nomtable)
    End Function

    Public Function GetRow(nomtable As String, colcritere As String, valeurcherchee As Object) As DataRow
        Dim res = Query("SELECT * FROM " & nomtable & " WHERE " & colcritere & "  = """ & Convert.ToString(valeurcherchee) & """")
        If res.Rows.Count > 0 Then Return res.Rows(0) Else Return Nothing
    End Function

    ' variante de GetRow, récupère la pk dans Me.Pks pour qu'on ne doive pas la préciser
    Public Function GetRow(nomtable As String, id As Integer) As DataRow
        If Not Bdd.Pks.ContainsKey(nomtable) Then
            Throw New ArgumentException
        Else
            Dim nompk = Bdd.Pks(nomtable)
            Return GetRow(nomtable, nompk, id)
        End If
    End Function



    ''' <summary>
    ''' Renvoie l'id de la ligne insérée. Ignore la première colonne (qui est supposée être la PK), sauf si PasAutoId est true
    ''' </summary>
    ''' <param name="nomtable"></param>
    ''' <param name="row"></param>
    ''' <param name="PasAutoId"></param>
    ''' <returns></returns>
    Public Function Insert(nomtable As String, row As DataRow, Optional PasAutoId As Boolean = False) As Integer

        Dim sqlchamps = "("
        Dim sqlvalues = "("
        Dim cmd = New MySqlCommand With {.Connection = Connexion, .CommandType = CommandType.Text}

        Dim tvide = GetTableVide(nomtable)

        Dim pasprem = False
        For i = If(PasAutoId, 0, 1) To tvide.Columns.Count - 1
            If pasprem Then
                sqlchamps &= ", "
                sqlvalues &= ", "
            Else
                pasprem = True
            End If
            Dim nomcol = tvide.Columns(i).Caption
            sqlchamps &= nomcol
            sqlvalues &= "@" & nomcol
            cmd.Parameters.AddWithValue("@" & nomcol, (row(i)))
        Next

        sqlchamps &= ")"
        sqlvalues &= ")"

        cmd.CommandText = "INSERT INTO " & nomtable & sqlchamps & " VALUES " & sqlvalues

        Connexion.Open()

        Dim reader As MySqlDataReader = Nothing

        Try
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand With {.Connection = Connexion, .CommandText = "SELECT LAST_INSERT_ID() FROM " & nomtable}
            reader = cmd.ExecuteReader
            reader.Read()
            Return reader.GetInt32(0)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then reader.Close()
            cmd.Dispose()
            Connexion.Close()
        End Try
    End Function

    ' renvoie l'id de la première ligne insérée (last_insert_id de sql)
    ' en toute logique, les ids des lignes insérées ensuite se suivent (autoincrement de 1)
    ' ce n'est peut-être pas 100% fiable mais ça devrait suffire
    Public Function Insert(nomtable As String, table As DataTable, Optional PasAutoId As Boolean = False) As Integer
        Dim tvide = GetTableVide(nomtable)
        Dim Skip = If(PasAutoId, 0, 1)

        ' donne quelque chose comme "(col1, col2, col3)"
        Dim champs = "(" & String.Join(", ", (From c As DataColumn In tvide.Columns Skip Skip Select c.Caption)) & ")"


        Dim valeursparams As New List(Of Object)
        For Each r As DataRow In table.Rows
            For Each c In (From osef In r.ItemArray Skip Skip)
                valeursparams.Add(c)
            Next
        Next

        Dim cptrparams = 0
        ' truc du genre (param0, param1, param2), (param3, param4, param5)
        Dim params = String.Join(", ", From r As DataRow In table.Rows Select "(" & String.Join(", ", From c In r.ItemArray Skip Skip Select "@param" & Inc(cptrparams)) & ")")


        Dim requete = "INSERT INTO " & nomtable & champs & " VALUES " & params

        Dim cmd = New MySqlCommand With {.Connection = Connexion, .CommandType = CommandType.Text}

        For cptrparams = 0 To valeursparams.Count - 1
            cmd.Parameters.AddWithValue("@param" & cptrparams, valeursparams(cptrparams))
        Next

        cmd.CommandText = requete

        Connexion.Open()
        Dim reader As MySqlDataReader = Nothing
        Try
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand With {.Connection = Connexion, .CommandText = "SELECT LAST_INSERT_ID() FROM " & nomtable}
            reader = cmd.ExecuteReader
            reader.Read()
            Return reader.GetInt32(0)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then reader.Close()
            cmd.Dispose()
            Connexion.Close()

        End Try

    End Function
    Private Function Inc(ByRef i As Integer)
        i += 1
        Return i - 1
    End Function

    ' récupère une table vide, juste pour avoir la structure
    ' garde une version des tables en cache, pour ne pas refaire la requête
    Function GetTableVide(nomtable As String) As DataTable
        Static Cache As Dictionary(Of String, DataTable)
        If Cache Is Nothing Then Cache = New Dictionary(Of String, DataTable)
        Dim Dt As DataTable
        If Not Cache.ContainsKey(nomtable) Then
            Dt = Query("SELECT * FROM " & nomtable & " WHERE FALSE")
            Cache.Add(nomtable, Dt)
        Else
            Dt = Cache(nomtable)
        End If
        Return Dt.Clone
    End Function

    Function GetRowVide(nomtable As String) As DataRow
        Return GetTableVide(nomtable).NewRow
    End Function

    ' il n'y a pas de table demandeur en bdd, mais un "type" de row dmdr peut quand même être utilisé pour transmettre des données à des fonctions
    ' où demandeur a
    'dmdr_nom_complet
    'dmdr_tel
    'dmdr_adresse
    'dmdr_nomville
    'dmdr_cp(Int?)
    'dmdr_nompays
    Function GetRowDmdrVide() As DataRow
        Dim tdm = New DataTable()
        tdm.Columns.AddRange({New DataColumn("dmdr_nomcomplet"), New DataColumn("dmdr_tel"), New DataColumn("dmdr_adresse"), New DataColumn("dmdr_nomville"), New DataColumn("dmdr_cp"), New DataColumn("dmdr_nompays")})
        Dim Demandeur = tdm.NewRow
        Demandeur("dmdr_nomcomplet") = ""
        Demandeur("dmdr_tel") = ""
        Demandeur("dmdr_adresse") = ""
        Demandeur("dmdr_nomville") = ""
        Demandeur("dmdr_nompays") = ""
        Return Demandeur
    End Function

    ' met à jour une même colonne dans plusieurs enregistrements, avec la même valeur pour toutes
    ' ne sert actuellement qu'à enlever ou mettre des défunts dans un emplacement
    Function UpdateChampPlusieurs(nomtable As String, nompk As String, ids As List(Of Object), nomchamp As String, nouvellevaleur As Object) As Integer
        If ids.Count = 0 Then Return 0
        Dim sql As String = ""
        Dim UneCmd As String

        Using Req As New MySqlCommand With {.CommandType = CommandType.Text, .Connection = Connexion}

            UneCmd = "UPDATE " & nomtable & " SET " & nomchamp & " = @lavaleur WHERE " & nompk & " IN (" & MySqlHelper.EscapeString(Join(ids.ToArray, ", ")) & ")"
            sql &= UneCmd
            Req.Parameters.AddWithValue("@lavaleur", nouvellevaleur)

            Req.CommandText = sql
            Connexion.Open()
            Try
                Return Req.ExecuteNonQuery()
            Finally
                Connexion.Close()
            End Try
        End Using
    End Function

    Function Login(user As String, pass As String) As Boolean
        Dim resultat = Query("SELECT * FROM t_login WHERE username = """ & MySqlHelper.EscapeString(user) & """ AND password = """ & MySqlHelper.EscapeString(pass) & """")
        Return resultat.Rows.Count > 0
    End Function


    Function GetValeurSql(sql As String, colonne As String) As String
        Dim myCommand As New MySqlCommand(sql, Connexion)
        Dim myData As MySqlDataReader = Nothing
        Connexion.Open()
        Try
            myData = myCommand.ExecuteReader()
            myData.Read()
            Dim str = myData.GetString(colonne)
            Return str
        Finally
            If myData IsNot Nothing Then
                If Not myData.IsClosed Then myData.Close()
                myData.Dispose()
            End If
            myCommand.Dispose()
            Connexion.Close()
        End Try
    End Function

    Public Function InsertSignalCsnAband(IdEmpl? As Integer, Com As String, Optional Photo As Image = Nothing) As Integer
        Connexion.Open()
        Dim reader As MySqlDataReader = Nothing
        Dim cmd As MySqlCommand = Nothing
        Try
            cmd = New MySqlCommand("INSERT INTO notifications (notif_emplacement,notif_commentaire,notif_photo,notif_masquer_fossoy,notif_masquer_servicepop)" &
              " VALUES (@empl,@com,@photo,@masqfos,@masqsp)", Connexion)

            Dim p As New MySqlParameter("@photo", Nothing)     ' https://support.microsoft.com/en-us/help/316887/how-to-read-and-write-a-file-to-and-from-a-blob-column-by-using-ado-ne, https://stackoverflow.com/a/3719471, https://www.aspsnippets.com/Articles/Read-and-Write-BLOB-Data-to-SQL-Server-database-using-C-and-VBNet.aspx
            p.IsNullable = True
            p.MySqlDbType = MySqlDbType.Blob
            p.Direction = ParameterDirection.Input
            If Photo IsNot Nothing Then
                Dim ImgBin = ImageToJpgToBytes(Photo)
                p.Value = ImgBin
                p.Size = ImgBin.Length
            Else
                p.Value = DBNull.Value
            End If
            cmd.Parameters.Add(p)
            cmd.Parameters.AddWithValue("@empl", IdEmpl)
            cmd.Parameters.AddWithValue("@com", Com)
            cmd.Parameters.AddWithValue("@masqfos", 0)
            cmd.Parameters.AddWithValue("@masqsp", 0)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand With {.Connection = Connexion, .CommandText = "SELECT LAST_INSERT_ID() FROM notifications"}
            reader = cmd.ExecuteReader
            reader.Read()
            Return reader.GetInt32(0)
        Finally
            If reader IsNot Nothing AndAlso Not reader.IsClosed Then reader.Close()
            If cmd IsNot Nothing Then cmd.Dispose()
            Connexion.Close()
        End Try




    End Function

    Private Function ImageToJpgToBytes(img As Image) As Byte()
        'Dim NomficTmp = IO.Path.GetTempFileName & Guid.NewGuid().ToString() + ".jpg"
        'img.Save(NomficTmp, Imaging.ImageFormat.Jpeg)       ' y a peut-être un moyen sans passer par un fichier
        Dim MS As New MemoryStream
        img.Save(MS, Imaging.ImageFormat.Jpeg)
        Dim ContenuFic As Byte() = MS.ToArray
        ' https://stackoverflow.com/a/29440623

        ' (https://www.aspsnippets.com/Articles/Read-and-Write-BLOB-Data-to-SQL-Server-database-using-C-and-VBNet.aspx)
        'Dim FS = New FileStream(NomficTmp, FileMode.Open, FileAccess.Read)
        'Dim BR = New BinaryReader(FS)
        'Dim ContenuFic As Byte() = BR.ReadBytes(Convert.ToInt32(FS.Length))
        'BR.Close()
        'FS.Close()
        Return ContenuFic

    End Function


End Module