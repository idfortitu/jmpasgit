Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports cimetiere.EntitesTableAdapters
Imports cimetiere.Entites

Module Bdd
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

    Public Sub NonQuery(sql As String)

    End Sub

    Public Function GetTable(nomtable As String) As DataTable
        Return Query("SELECT * FROM " & nomtable)
    End Function


    Public Function GetLocVilles() As DataTable
        'Return

    End Function

    ' ne met pas la première colonne, en supposant que c'est l'id et qu'il sera généré automatiquement
    ' sauf si PasAutoId est true
    Public Function Insert(nomtable As String, row As DataRow, Optional PasAutoId As Boolean = False) As Integer

        Dim rowvide = Query("SELECT * FROM " & nomtable & " WHERE FALSE")   ' récupère une ligne vide, juste pour avoir la structure

        Dim sqlchamps = "("
        Dim sqlvalues = "("
        Dim cmd = New MySqlCommand With {.Connection = Connexion, .CommandType = CommandType.Text}

        Dim pasprem = False
        For i = If(PasAutoId, 0, 1) To rowvide.Columns.Count - 1
            If pasprem Then
                sqlchamps &= ", "
                sqlvalues &= ", "
            Else
                pasprem = True
            End If
            Dim nomcol = rowvide.Columns(i).Caption
            sqlchamps &= nomcol
            sqlvalues &= "@" & nomcol
            cmd.Parameters.AddWithValue("@" & nomcol, (row(i)))
        Next

        sqlchamps &= ")"
        sqlvalues &= ")"

        cmd.CommandText = "INSERT INTO " & nomtable & sqlchamps & " VALUES " & sqlvalues

        Connexion.Open()
        Try
            Return cmd.ExecuteNonQuery
        Finally
            Connexion.Close()
        End Try

<<<<<<< HEAD
        ' La requête
        SQL = "select * from t_login where username = '" & user & "' AND password = '" & pass & "'"
        myCommand.CommandText = SQL
        myAdapter.SelectCommand = myCommand
        myData = myCommand.ExecuteReader()
        myData.Read()
        Try
            Dim str = myData.GetString(0)
            myData.Close()
            conn.Close()
            Return str
        Catch ex As Exception
            myData.Close()
            conn.Close()
            Return 0
        End Try


=======
>>>>>>> origin/master
    End Function



    ' Fonctions : - plus forcément à jour
    ' GetTable(table as String) As DataTable        ' ex : GetTable("demandeurs")
    ' GetTableWithId(table as String, NomPk As String, Id As Integer) As DataTable      ' ex : GetTableWithId("emplacements","empl_id",4)
    ' Function GetFormInhumation(id As Integer) As DemandeInhumation
    ' Function GetFormNvConcession(id As Integer) As DemandeNvConcession
    ' Function GetFormNvConBenefs(IdForm) As Beneficiaire()
    ' PutFormInhumation(LeForm As DemandeInhumation) As Integer      ' ajoute un nouveau form en bdd (table forms inhum + éventuellement form nv con & fnvcon bénéficiaires                                                                     renvoie l'id inséré
    ' Function PutFormNvCon(LeForm As DemandeNvConcession) As Integer


    Function Login(user As String, pass As String)
        Dim sql = "select * from t_login where username = '" & user & "' AND password = '" & pass & "'"
        Connexion.Open()
        Try    ' doit fermer la connexion même si erreur
            Using MyCommand As New MySqlCommand With {.Connection = Connexion, .CommandText = sql},
                  MyData = MyCommand.ExecuteReader
                Try     ' doit fermer mydata même si erreur...
                    MyData.Read()
                    Return MyData.GetString(0)
                Finally
                    MyData.Close()
                End Try
            End Using
        Finally
            Connexion.Close()
        End Try
    End Function




    Function GetValeurSql(sql As String, colonne As String) As String
        'Connexion.ConnectionString = "Server=" & BddHost & ";User Id=" & BddUser & "; Password=" & BddPass & "; Database=" & BddNom & "; Pooling=false"
        Connexion.Open()
        Dim myCommand As New MySqlCommand
        'Dim myAdapter As New MySqlDataAdapter
        Dim myData As MySqlDataReader
        'Dim SQL As String
        'Dim objConn As New MySql.Data.MySqlClient.MySqlConnection
        myCommand.Connection = Connexion
        ' La requête
        'SQL = commande
        myCommand.CommandText = sql
        'myAdapter.SelectCommand = myCommand
        myData = myCommand.ExecuteReader()
        myData.Read()
        Dim str = myData.GetString(colonne)
        myData.Close()
        Connexion.Close()
        Return str

    End Function

    'Public Function InsertPers() As Boolean

    '    Dim conn As MySqlConnection = Connecter()
    '    Dim sqlCommand As New MySqlCommand
    '    Dim str_carSql As String

    '    Try
    '        str_carSql = "insert into personne (id, nom, prenom, naissance, mort, sepulture, enterement, expiration) values ('','heu','peutetre','25','34','65','98','20')"
    '        MsgBox(str_carSql)
    '        sqlCommand.Connection = conn
    '        sqlCommand.CommandText = str_carSql
    '        sqlCommand.ExecuteNonQuery()
    '        Return True

    '    Catch ex As Exception
    '        Return False
    '        MsgBox("Error occured: Could not insert record")
    '    End Try

    '    conn.Close()
    'End Function

End Module