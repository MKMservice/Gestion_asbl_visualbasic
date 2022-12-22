Imports System.Data.OleDb

Public Class GESTION_DE_LETTRE
    '==================================================================================================================
    'declaration des different object qui nous servira de la connexion et l'adptation avec la base de données ainsi et des commandes
    '==================================================================================================================
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
    Dim da As New OleDbDataAdapter("select*from lettre", cn)
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub GESTION_DE_LETTRE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Filter = "document" & "(*.doc,*doxt,*.dotm)|*.doc;..*dotx;*DOTM"
        'demarer le timer 
        Timer1.Start()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(ds, "lettre")
        bnd = BindingContext(ds.Tables("lettre"))
        '==================================================================================================================
        'l'affichage des membres dans les textbox respectivement
        '==================================================================================================================

        Txtref.DataBindings.Add("text", ds.Tables("lettre"), "Reference")
        Txtdate.DataBindings.Add("text", ds.Tables("lettre"), "Dateenvoi")
        Txtcopie.DataBindings.Add("text", ds.Tables("lettre"), "Copie")
        Txtobjet.DataBindings.Add("text", ds.Tables("lettre"), "Objet")
        txtdestination.DataBindings.Add("text", ds.Tables("lettre"), "destination")
        txtlettre.DataBindings.Add("text", ds.Tables("lettre"), "lettre")
        'chargement des donnés de la base de données dans datagridview pour leur affichage
        '==================================================================================================================
        DataGridView1.DataSource = ds.Tables("lettre")
        Lblmontant.Text = bnd.Position & "/" & ds.Tables("lettre".ToArray).Rows.Count


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Red
            Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA"
        ElseIf Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Black
            Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '==================================================================================================================
        'procedure de libere les champs pour un autre membre 
        '=================================================================================================================
        bnd.AddNew()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' la procedure de forcer l'utilisateur de remplir le champs obligatoire
        '============================================================================
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtref.Text = "" Then
            Txtref.BackColor = Color.Red
            Txtref.Focus()
            MsgBox("veuillez saisir le nom!", MsgBoxStyle.RetryCancel, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtref.BackColor = Color.White
        End If

        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtcopie.Text = "" Then
            Txtcopie.BackColor = Color.Red
            Txtcopie.Focus()
            MsgBox("veuillez saisir le Postnom!", MsgBoxStyle.RetryCancel, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtcopie.BackColor = Color.White
        End If
        'tester si textebox txtprenom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtobjet.Text = "" Then
            Txtobjet.BackColor = Color.Red
            Txtobjet.Focus()
            MsgBox("veuillez saisir le Prénom!", MsgBoxStyle.RetryCancel, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtobjet.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtdestination.Text = "" Then
            txtdestination.BackColor = Color.Red
            txtdestination.Focus()
            MsgBox("veuillez saisir le montant cotisé par le membre!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtdestination.BackColor = Color.White
        End If
        Dim ajouter As New OleDbCommandBuilder(da)
        '===================================================================================================================
        'tester si l'utilisateur veut reellement ajouter un enregistrement dans la base de données
        '===================================================================================================================
        If MsgBox("Voudriez-vous ajoutez un nouveau membre?", MsgBoxStyle.OkCancel, "Ajout") = MsgBoxResult.Ok Then
            's'il confirment nous passons directemrnt dans la procedure enregistremnent don nous avons utilisé update
            bnd.EndCurrentEdit()
            '=================================================================================================================
            'donner la precision sur quelle table nous voulons ajouter l'enregistrement
            '===================================================================================================================
            da.Update(ds, "lettre")
            '==================================================================================================================
            'chargement des donnés de la base de données dans datagridview pour leur affichage
            '==================================================================================================================
        End If
        ' Dim sw As Integer
        '  sw = 0
        ' If sw = 0 Then
        'Dim newligne As DataRow
        'newligne = ds.Tables("LETTRE").NewRow
        'On Error Resume Next
        ' newligne(1) = UCase(Txtref.Text)
        ' newligne(2) = UCase(Txtdate.Text)
        ' newligne(3) = UCase(Txtcopie.Text)
        ' newligne(4) = UCase(Txtobjet.Text)
        ' newligne(5) = UCase(txtdestination.Text)
        ' newligne(6) = UCase(txtlettre.Text)
        '  ds.Tables("LETTRE").Rows.Add(newligne)
        '  Dim cmdbuild As OleDb.OleDbCommandBuilder
        '  cmdbuild = New OleDb.OleDbCommandBuilder(da)
        '   da.InsertCommand = cmdbuild.GetInsertCommand
        '   da.Update(ds, "LETTRE")
        '   MsgBox("ajout avecx succes", MsgBoxStyle.Information)
        '  cn.Close()
        '  End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '==================================================================================================================
        'la procedure d'aller à la ligne zero de notre datagridview
        '==================================================================================================================
        bnd.Position = 0

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '==================================================================================================================
        'la procedure de se deplacer un par un
        '==================================================================================================================
        bnd.Position -= 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '==================================================================================================================
        'la procedure de se deplacer un par un
        '==================================================================================================================
        bnd.Position += 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub




    

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If OpenFileDialog1.ShowDialog = 1 Then
            txtlettre.LoadFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If SaveFileDialog1.ShowDialog = 1 Then
            txtlettre.SaveFile(SaveFileDialog1.FileName)
        End If

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        If MsgBox("cliquer sur oui pour avoir l'aperçu, et sur non pour ne pas l'avoir.", MsgBoxStyle.YesNo, "Impression") = MsgBoxResult.Yes Then
            PrintPreviewDialog1.ShowDialog()
        Else
            If PrintDialog1.ShowDialog = 1 Then
                PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Me.Close()
        ACCEUIL.Show()

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        txtlettre.Copy()

    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        txtlettre.Cut()

    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        txtlettre.Paste()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        txtlettre.Undo()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        txtlettre.Redo()

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        If FontDialog1.ShowDialog = 1 Then
            txtlettre.SelectionFont = FontDialog1.Font
        End If

    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        If ColorDialog1.ShowDialog = 1 Then
            txtlettre.SelectionColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        If ColorDialog1.ShowDialog = 1 Then
            txtlettre.BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub boutonedition_Click(sender As Object, e As EventArgs) Handles boutonedition.Click
        boutonedition.ForeColor = Color.Red
        menuedition.Visible = True
        Menupolice.Visible = False
        Menufichier.Visible = False
        boutonfichier.ForeColor = Color.Black
        boutonpolice.ForeColor = Color.Black

    End Sub

    Private Sub boutonpolice_Click(sender As Object, e As EventArgs) Handles boutonpolice.Click
        boutonpolice.ForeColor = Color.Red
        Menupolice.Visible = True
        Menufichier.Visible = False
        menuedition.Visible = False
        boutonfichier.ForeColor = Color.Black
        boutonedition.ForeColor = Color.Black
    End Sub

    Private Sub boutonfichier_Click(sender As Object, e As EventArgs) Handles boutonfichier.Click
        boutonfichier.ForeColor = Color.Red
        Menufichier.Visible = True
        Menupolice.Visible = False
        menuedition.Visible = False
        boutonpolice.ForeColor = Color.Black
        boutonedition.ForeColor = Color.Black

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim Supprimer As New OleDbCommandBuilder(da)

        If MsgBox("Voudriez-vous supprimer?", MsgBoxStyle.OkCancel, "Suppression") = MsgBoxResult.Ok Then
            bnd.RemoveAt(bnd.Position)
            da.Update(ds, "LETTRE")
            MsgBox("Supprimer avec succès")
        End If

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        '==================================================================================================================
        'la procedure d'aller à la fin de notre liste des mebres dans datagriview
        '==================================================================================================================
        bnd.Position = ds.Tables("LETTRE").Rows.Count - 1
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        DOCUMENTATION.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' la procedure de forcer l'utilisateur de remplir le champs obligatoire
        '============================================================================
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtref.Text = "" Then
            Txtref.BackColor = Color.Red
            Txtref.Focus()
            MsgBox("veuillez saisir le nom!", MsgBoxStyle.RetryCancel, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtref.BackColor = Color.White
        End If

        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtcopie.Text = "" Then
            Txtcopie.BackColor = Color.Red
            Txtcopie.Focus()
            MsgBox("veuillez saisir le Postnom!", MsgBoxStyle.RetryCancel, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtcopie.BackColor = Color.White
        End If
        'tester si textebox txtprenom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtobjet.Text = "" Then
            Txtobjet.BackColor = Color.Red
            Txtobjet.Focus()
            MsgBox("veuillez saisir le Prénom!", MsgBoxStyle.RetryCancel, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtobjet.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtdestination.Text = "" Then
            txtdestination.BackColor = Color.Red
            txtdestination.Focus()
            MsgBox("veuillez saisir le montant cotisé par le membre!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtdestination.BackColor = Color.White
        End If
        If MsgBox("reference existe deja", MsgBoxStyle.Critical + vbYesNo, "verification") = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim ligneencours As Integer
            ligneencours = DataGridView1.CurrentRow.Index
            Dim cle As String
            cle = DataGridView1.Item(0, ligneencours).Value
            Dim matable As DataTable
            matable = ds.Tables("LETTRE")
            Dim laligne As DataRow()
            laligne = matable.Select("Id=" & cle)
            laligne(0).Item(1) = UCase(Txtref.Text)
            laligne(0).Item(2) = UCase(Txtdate.Text)
            laligne(0).Item(3) = UCase(Txtcopie.Text)
            laligne(0).Item(4) = UCase(Txtobjet.Text)
            laligne(0).Item(5) = UCase(txtdestination.Text)
            laligne(0).Item(6) = UCase(txtlettre.Text)
            Dim cmdbuild As OleDb.OleDbCommandBuilder
            cmdbuild = New OleDb.OleDbCommandBuilder(da)
            da.InsertCommand = cmdbuild.GetInsertCommand
            da.Update(ds, "LETTRE")
            MsgBox("Modifier avecx succes", MsgBoxStyle.Information)
            cn.Close()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
        Impression_de_lettre.Show()
        Impression_de_lettre.MdiParent = ACCEUIL
    End Sub
End Class