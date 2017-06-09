Imports MySql.Data.MySqlClient
Public Class FormEditEmplacement

    Public LEmplacement As DataRow


    Private IdEmpl As Integer
    Private DefuntsInitiaux As DataTable
    ''Private ListeDéfuntsAjoutes As New List(Of Défunt)
    ''Private ListeDéfuntsRetirés As New List(Of Défunt)

    Public Sub New(Optional Id As Integer = -1)
        InitializeComponent()
        IdEmpl = Id
        DgvOccDest.AutoGenerateColumns = False
        DgvOccSrc.AutoGenerateColumns = False
    End Sub

    Private Sub FormEditEmplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ctx As New CimEntities
            If IdEmpl <> -1 Then
                Text = "Modifier un emplacement"
                LEmplacement = Bdd.GetRow("emplacements", "empl_id", IdEmpl)
                'LEmplacement = ctx.Emplacements.Single(Function(empl) empl.Id = IdEmpl)     ' doit renvoyer une erreur si l'emplacement n'existe pas

                TbRef.Text = LEmplacement("empl_reference")
                CbTypeEmpl.SelectedValue = LEmplacement("empl_type")
                TbintNbPlaces.Value = If(Not IsDBNull(LEmplacement("empl_nb_places")), LEmplacement("empl_nb_places"), Nothing)
                CbMonumClassé.Checked = LEmplacement("empl_monum_classe")
                If Not IsDBNull(LEmplacement("hist_id")) Then TbHistoire.Text = Bdd.GetRow("t_histoire", "h_id", LEmplacement("hist_id"))("h_histoire")

            Else
                Text = "Ajouter un emplacement"
                LEmplacement = Bdd.GetRowVide("emplacements")
                LEmplacement("empl_id") = -1
                TbRef.ReadOnly = False
            End If

            ' récupère les défunts et les sépare entre ceux qui sont dans l'emplacement et les autres
            Dim defs = Bdd.Query("SELECT def_id, def_numero_lh, CONCAT(def_nom,"" "",def_prenom) as def_nom, empl_reference, defunts.empl_id AS empl_id, def_date_deces, def_lieu_deces" &
                                " FROM defunts LEFT OUTER JOIN emplacements ON defunts.empl_id = emplacements.empl_id")
            Dim dtSrc = defs.Clone
            Dim dtDest = defs.Clone
            Dim RowArrayDefsDansEmpl = defs.Select("empl_id = " & LEmplacement("empl_id"))
            For Each row As DataRow In RowArrayDefsDansEmpl
                dtDest.ImportRow(row)
            Next
            DefuntsInitiaux = dtDest.Copy
            Dim RowArrayAutresDefs = defs.Select("empl_id <> " & LEmplacement("empl_id") & " or empl_id is null")     ' la comparaison avec l'id de l'empl n'est pas prise en compte si la fk est DBNull
            For Each row As DataRow In RowArrayAutresDefs
                dtSrc.ImportRow(row)
            Next


            DgvOccSrc.DataSource = dtSrc
            DgvOccDest.DataSource = dtDest

        End Using
    End Sub


    Private Sub BtAjouterOccupant_Click(sender As Object, e As EventArgs) Handles BtAjouterOccupant.Click
        If DgvOccSrc.SelectedRow IsNot Nothing Then
            Dim LOccupant As DataRow = CType(DgvOccSrc.SelectedRow.DataBoundItem, DataRowView).Row
            DgvOccDest.DataSource.ImportRow(LOccupant)
            DgvOccSrc.DataSource.Rows.Remove(LOccupant)
        End If
    End Sub

    Private Sub BtRetirerOccupant_Click(sender As Object, e As EventArgs) Handles BtRetirerOccupant.Click
        If DgvOccDest.SelectedRow IsNot Nothing Then
            Dim LOccupant As DataRow = CType(DgvOccDest.SelectedRow.DataBoundItem, DataRowView).Row
            DgvOccSrc.DataSource.ImportRow(LOccupant)
            DgvOccDest.DataSource.Rows.Remove(LOccupant)
        End If
    End Sub




    Private Sub AjusterTailleDgv(sender As Object, e As EventArgs) Handles MyBase.Layout
        DgvOccDest.Width = ClientSize.Width - DgvOccDest.Location.X - 5
        DgvOccSrc.Width = ClientSize.Width - DgvOccSrc.Location.X - 5
        DgvOccSrc.Height = ClientSize.Height - DgvOccSrc.Location.Y - 10


    End Sub


    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click

        If ToutEstCorrect() Then

            ' utiliser des transactions serait pas mal
            LEmplacement("empl_reference") = If(TbRef.Text.Trim <> "", TbRef.Text.Trim, DBNull.Value)
            LEmplacement("empl_type") = CType(CbTypeEmpl.SelectedValue, TTypeEmpl)
            LEmplacement("empl_nb_places") = If(TbintNbPlaces.Value IsNot Nothing, TbintNbPlaces.Value, DBNull.Value)
            LEmplacement("empl_monum_classe") = CbMonumClassé.Checked
            If LEmplacement("empl_id") = -1 Then
                LEmplacement("empl_id") = Bdd.Insert("emplacements", LEmplacement)
            Else
                Bdd.Update("emplacements", LEmplacement)
            End If

            Dim LHist As DataRow
            If IsDBNull(LEmplacement("hist_id")) Then
                LHist = Bdd.GetRowVide("t_histoire")
                LHist("h_histoire") = TbHistoire.Text
                LEmplacement("hist_id") = Bdd.Insert("t_histoire", LHist)
            Else
                LHist = Bdd.GetRow("t_histoire", "h_id", LEmplacement("hist_id"))
                LHist("h_histoire") = TbHistoire.Text
                Bdd.Update("t_histoire", LHist)
            End If
            Bdd.NonQuery("UPDATE emplacements SET hist_id = " & LEmplacement("hist_id") & " WHERE empl_id = " & LEmplacement("empl_id"))

            ' défunts ajoutés et retirés
            Dim IdsDefsDest = (From r In DgvOccDest.DataSource Select r("def_id")).ToList
            Dim IdsDefsInitiaux = (From r In DefuntsInitiaux Select r("def_id")).ToList

            Dim IdsDefsRetirés = (From i In IdsDefsInitiaux Where Not IdsDefsDest.Contains(i)).ToList
            Dim IdsDefsAjoutés = (From i In IdsDefsDest Where Not IdsDefsInitiaux.Contains(i)).ToList

            Bdd.UpdateChampPlusieurs("defunts", "def_id", IdsDefsRetirés, "empl_id", DBNull.Value)
            Bdd.UpdateChampPlusieurs("defunts", "def_id", IdsDefsAjoutés, "empl_id", LEmplacement("empl_id"))

            DialogResult = DialogResult.OK

        Else
            ToolTip1.Show("Un ou des champs sont incorrects.", BtEnregistrer)
        End If
    End Sub

    Private Sub BtNvDef_Click(sender As Object, e As EventArgs) Handles BtNvDef.Click
        Dim f As New FormEditDefunt()
        f.ShowDialog()
        If f.DialogResult = DialogResult.OK Then
            Dim IdNvDef = f.LeDefunt("def_id")
            Dim NvDef = Bdd.Query("SELECT def_id, def_numero_lh, CONCAT(def_nom,"" "",def_prenom) as def_nom, empl_reference, defunts.empl_id AS empl_id, def_date_deces, def_lieu_deces" &
                                " FROM defunts LEFT OUTER JOIN emplacements ON defunts.empl_id = emplacements.empl_id WHERE def_id = " & IdNvDef).Rows(0)
            DgvOccDest.DataSource.ImportRow(NvDef)
        End If
    End Sub

    Private Function ToutEstCorrect() As Boolean
        FaireValidation()
        Return ErrorProvider1.GetError(TbRef) = ""
    End Function

    Private Sub FaireValidation()
        TbRef_Validating(Nothing, Nothing)
    End Sub

    Private Sub TbRef_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TbRef.Validating
        Dim err As String = ""
        If TbRef.Text.Trim = "" Then
            err = "La référence doit être indiquée."
        Else
            Dim empl_deja = Bdd.Query("SELECT empl_id FROM emplacements WHERE empl_reference = """ & MySqlHelper.EscapeString(TbRef.Text.Trim) & """")
            If empl_deja.Rows.Count > 0 Then       ' la référence ne peut pas être déjà prise
                    If empl_deja.Rows(0)("empl_id") <> LEmplacement("empl_id") Then     ' sauf par cet emplacement bien sûr
                        err = "Un autre emplacement a déjà cette référence."
                    End If
                End If
            End If
            ErrorProvider1.SetError(TbRef, err)
    End Sub
End Class