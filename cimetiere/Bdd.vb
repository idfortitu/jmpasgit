Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System
Imports System.Net
Imports System.IO
Imports System.Text

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

    Public Function GetRow(nomtable As String, nompk As String, id As Integer) As DataRow
        Dim res = Query("SELECT * FROM " & nomtable & " WHERE " & nompk & "  = " & id)
        If res.Rows.Count > 0 Then Return res.Rows(0) Else Return Nothing
    End Function


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
            Connexion.Close()
        End Try
    End Function

    ' récupère une table vide, juste pour avoir la structure
    Function GetTableVide(nomtable As String) As DataTable
        Return Query("SELECT * FROM " & nomtable & " WHERE FALSE")
    End Function

    Function GetRowVide(nomtable As String)
        Return GetTableVide(nomtable).NewRow
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


End Module