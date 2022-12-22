Imports System.Data.OleDb
Imports System.IO

Public Class FICHE_ADHESION
    '==================================================================================================================
    'declaration des different object qui nous servira de la connexion et l'adptation avec la base de données ainsi et des commandes
    '==================================================================================================================
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
    Dim da As New OleDbDataAdapter("select*from FICHE", cn)
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub HISTORIQUE_DE_COTISATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()
        '==================================================================================================================
        'chargement de la table membre dans dataset Id_jeton
        '==================================================================================================================
        da.Fill(ds, "FICHE")
        bnd = BindingContext(ds.Tables("FICHE"))
        '==================================================================================================================
        'l'affichage des membres dans les textbox respectivement
        '==================================================================================================================
        TxtId.DataBindings.Add("text", ds.Tables("FICHE"), "Id")
        Txtnom.DataBindings.Add("text", ds.Tables("FICHE"), "nom")
        txtprenom.DataBindings.Add("text", ds.Tables("FICHE"), "prenom")
        Txtpere.DataBindings.Add("text", ds.Tables("FICHE"), "PERE")
        Txtmere.DataBindings.Add("text", ds.Tables("FICHE"), "MERE")
        Cmbsexe.DataBindings.Add("text", ds.Tables("FICHE"), "SEXE")
        Txtdatenaiss.DataBindings.Add("text", ds.Tables("FICHE"), "LIEU_DATE_NAISS")
        TxtProvince.DataBindings.Add("text", ds.Tables("FICHE"), "PROVINCE")
        Txtnation.DataBindings.Add("text", ds.Tables("FICHE"), "NATIONALITE")
        Txttele1.DataBindings.Add("text", ds.Tables("FICHE"), "TELEPHONE")
        Txtetat.DataBindings.Add("text", ds.Tables("FICHE"), "ETAT_CIVIL")
        Txtnbenfant.DataBindings.Add("text", ds.Tables("FICHE"), "NB_ENFANT")
        Txtproche.DataBindings.Add("text", ds.Tables("FICHE"), "NOM_PROCHE")
        Txttele2.DataBindings.Add("text", ds.Tables("FICHE"), "TELE_PROCHE")
        Txtdateadhesion.DataBindings.Add("text", ds.Tables("FICHE"), "DATE_ADHESION")
        cmbnbvelos.DataBindings.Add("text", ds.Tables("FICHE"), "NBVELOS")
        txtnbpouss.DataBindings.Add("text", ds.Tables("FICHE"), "NBPOUSSEURS")
        Txtobserv.DataBindings.Add("text", ds.Tables("FICHE"), "OBSERVATION")

        DataGridView1.DataSource = ds.Tables("FICHE")
        Lblmontant.Text = DataGridView1.Rows.Count - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(15).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(16).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2

        'Txtrecherche2.Items.Clear()
        ' cmd.CommandText = "select*from FICHE"
        ' cmd.Connection = cn
        '  cn.Open()
        ' dr = cmd.ExecuteReader
        ' While dr.Read
        'Txtrecherche2.Items.Add(dr.GetString(5))
        '   End While
        ' dr.Close()
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' la procedure de forcer l'utilisateur de remplir le champs obligatoire
        '============================================================================
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtnom.Text = "" Then
            Txtnom.BackColor = Color.Red
            Txtnom.Focus()
            MsgBox("veuillez saisir le nom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtnom.BackColor = Color.White
        End If

        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtpere.Text = "" Then
            Txtpere.BackColor = Color.Red
            Txtpere.Focus()
            MsgBox("veuillez saisir le Postnom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtpere.BackColor = Color.White
        End If
        'tester si textebox txtprenom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtprenom.Text = "" Then
            txtprenom.BackColor = Color.Red
            txtprenom.Focus()
            MsgBox("veuillez saisir le Prénom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtprenom.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If TxtProvince.Text = "" Then
            TxtProvince.BackColor = Color.Red
            TxtProvince.Focus()
            MsgBox("veuillez saisir le montant cotisé par le membre!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            TxtProvince.BackColor = Color.White
        End If
        Dim sw As Integer
        sw = 0
        For s = 0 To Me.DataGridView1.RowCount - 2
            If Txtnom.Text = Me.DataGridView1.Item(1, 0).Value Then
                sw = 1
            End If
        Next
        If sw = 0 Then
            Dim newligne As DataRow
            newligne = ds.Tables("FICHE").NewRow
            On Error Resume Next
            newligne(0) = UCase(TxtId.Text)
            newligne(1) = UCase(Txtnom.Text)
            newligne(2) = UCase(txtprenom.Text)
            newligne(3) = UCase(Txtpere.Text)
            newligne(4) = UCase(Txtmere.Text)
            newligne(5) = UCase(Cmbsexe.Text)
            newligne(6) = UCase(Txtdatenaiss.Text)
            newligne(7) = UCase(TxtProvince.Text)
            newligne(8) = UCase(Txtnation.Text)
            newligne(9) = UCase(Txttele1.Text)
            newligne(10) = UCase(Txtetat.Text)
            newligne(11) = UCase(Txtnbenfant.Text)
            newligne(12) = UCase(Txtproche.Text)
            newligne(13) = UCase(Txttele2.Text)
            newligne(14) = UCase(Txtdateadhesion.Text)
            newligne(15) = UCase(cmbnbvelos.Text)
            newligne(16) = UCase(txtnbpouss.Text)
            newligne(17) = UCase(Txtobserv.Text)
            newligne(18) = covertToData(PictureBox1.Image)
            ds.Tables("FICHE").Rows.Add(newligne)
            Dim cmdbuild As OleDb.OleDbCommandBuilder
            cmdbuild = New OleDb.OleDbCommandBuilder(da)
            da.InsertCommand = cmdbuild.GetInsertCommand
            da.Update(ds, "FICHE")
            MsgBox("ajout avecx succes", MsgBoxStyle.Information)
            cn.Close()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '==================================================================================================================
        'procedure de libere les champs pour un autre membre 
        '=================================================================================================================
        bnd.AddNew()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '==================================================================================================================
        'procedure de quitter la gestion des membres
        '=================================================================================================================
        Me.Close()
        ACCEUIL.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim Supprimer As New OleDbCommandBuilder(da)

        If MsgBox("Voudriez-vous supprimer?", MsgBoxStyle.OkCancel, "Suppression") = MsgBoxResult.Ok Then
            bnd.RemoveAt(bnd.Position)
            da.Update(ds, "FICHE")
            Lblmontant.Text = DataGridView1.Rows.Count - 1
            MsgBox("Supprimer avec succès")
        End If
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '==================================================================================================================
        'la procedure d'aller à la ligne zero de notre datagridview
        '==================================================================================================================
        bnd.Position = 0
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '==================================================================================================================
        'la procedure de se deplacer un par un
        '==================================================================================================================
        bnd.Position -= 1
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '==================================================================================================================
        'la procedure de se deplacer un par un
        '==================================================================================================================
        bnd.Position += 1
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '==================================================================================================================
        'la procedure d'aller à la fin de notre liste des mebres dans datagriview
        '==================================================================================================================
        bnd.Position = ds.Tables("FICHE").Rows.Count - 1
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' la procedure de forcer l'utilisateur de remplir le champs obligatoire
        '============================================================================
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtnom.Text = "" Then
            Txtnom.BackColor = Color.Red
            Txtnom.Focus()
            MsgBox("veuillez saisir le nom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtnom.BackColor = Color.White
        End If

        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtpere.Text = "" Then
            Txtpere.BackColor = Color.Red
            Txtpere.Focus()
            MsgBox("veuillez saisir le Postnom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtpere.BackColor = Color.White
        End If
        'tester si textebox txtprenom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtprenom.Text = "" Then
            txtprenom.BackColor = Color.Red
            txtprenom.Focus()
            MsgBox("veuillez saisir le Prénom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtprenom.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If TxtProvince.Text = "" Then
            TxtProvince.BackColor = Color.Red
            TxtProvince.Focus()
            MsgBox("veuillez saisir le montant cotisé par le membre!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            TxtProvince.BackColor = Color.White
        End If
        If MsgBox("reference existe deja", MsgBoxStyle.Critical + vbYesNo, "verification") = MsgBoxResult.No Then
            Exit Sub
        Else
            Dim ligneencours As Integer
            ligneencours = DataGridView1.CurrentRow.Index
            Dim cle As String
            cle = DataGridView1.Item(0, ligneencours).Value
            Dim matable As DataTable
            matable = ds.Tables("FICHE")
            Dim laligne As DataRow()
            laligne = matable.Select("Id=" & cle)
            laligne(0).Item(0) = UCase(TxtId.Text)
            laligne(0).Item(1) = UCase(Txtnom.Text)
            laligne(0).Item(2) = UCase(txtprenom.Text)
            laligne(0).Item(3) = UCase(Txtpere.Text)
            laligne(0).Item(4) = UCase(Txtmere.Text)
            laligne(0).Item(5) = UCase(Cmbsexe.Text)
            laligne(0).Item(6) = UCase(Txtdatenaiss.Text)
            laligne(0).Item(7) = UCase(TxtProvince.Text)
            laligne(0).Item(8) = UCase(Txtnation.Text)
            laligne(0).Item(9) = UCase(Txttele1.Text)
            laligne(0).Item(10) = UCase(Txtetat.Text)
            laligne(0).Item(11) = UCase(Txtnbenfant.Text)
            laligne(0).Item(12) = UCase(Txtproche.Text)
            On Error Resume Next
            laligne(0).Item(13) = UCase(Txttele2.Text)
            laligne(0).Item(14) = UCase(Txtdateadhesion.Text)
            laligne(0).Item(15) = UCase(cmbnbvelos.Text)
            laligne(0).Item(16) = UCase(txtnbpouss.Text)
            laligne(0).Item(17) = UCase(Txtobserv.Text)
            laligne(0).Item(18) = covertToData(PictureBox1.Image)
            Dim cmdbuild As OleDb.OleDbCommandBuilder
            cmdbuild = New OleDb.OleDbCommandBuilder(da)
            da.InsertCommand = cmdbuild.GetInsertCommand
            da.Update(ds, "FICHE")
            MsgBox("Modifier avecx succes", MsgBoxStyle.Information)
            cn.Close()
        End If
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    End Sub
    '1 pour convertir l'image system drawing en bytes
    Public Function covertToData(ByVal myImage As Image) As Byte()
        Dim ms As New MemoryStream()
        On Error Resume Next
        myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim mybytes(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(mybytes, 0, ms.Length)
        Return mybytes
    End Function
    'pour convertir bytes en imge system drawing
    Public Function covertToImage(ByVal data() As Byte) As Image
        Dim stream As New MemoryStream(data)
        Return Image.FromStream(stream)
    End Function
    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            OpenFileDialog1.Filter = "JPEG files(*.jpg)|*.jpg|Image files(*.bmp)|*.bmp|allfiles(*.*|*.*"

            With Me.OpenFileDialog1
                .FilterIndex = 1
                OpenFileDialog1.CheckFileExists = True
                OpenFileDialog1.CheckPathExists = True
                OpenFileDialog1.ValidateNames = True
                OpenFileDialog1.DereferenceLinks = True
                OpenFileDialog1.RestoreDirectory = True
                .Title = "choisir une image"
                .ShowDialog()
                If Len(.FileName) > 0 Then
                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                    Dim var As String
                    var = TxtId.Text
                    PictureBox1.Image.Save(Application.StartupPath & "\photos\" & var & ".jpg")
                End If
            End With
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)
    End Sub

    Private Sub civil1_CheckedChanged_1(sender As Object, e As EventArgs) Handles civil1.CheckedChanged
        If civil1.Checked Then
            Txtetat.Text = "CELIBATAIRE"
        End If
    End Sub

    Private Sub civil2_CheckedChanged_1(sender As Object, e As EventArgs) Handles civil2.CheckedChanged
        If civil2.Checked Then
            Txtetat.Text = "MARIE"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from fiche where nom like '%" + Txtrecherche1.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        '==================================================================================================================
        'chargement des donnés de la base de données dans datagridview pour leur affichage
        DataGridView1.DataSource = dt

        Lblmontant.Text = DataGridView1.Rows.Count - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(15).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(16).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2

        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub Txtrecherche2_Enter(sender As Object, e As EventArgs) Handles Txtrecherche2.Enter
        If Txtrecherche2.Text = "selectioner" Then
            Txtrecherche2.Text = ""
            Txtrecherche2.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Txtrecherche2.SelectedIndexChanged
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from fiche where SEXE like '%" + Txtrecherche2.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        DataGridView1.DataSource = dt
        '==================================================================================================================
        Lblmontant.Text = DataGridView1.Rows.Count - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(15).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(16).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from fiche where PRENOM like '%" + Txtrecherche3.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        '==================================================================================================================
        'chargement des donnés de la base de données dans datagridview pour leur affichage
        DataGridView1.DataSource = dt

        Lblmontant.Text = DataGridView1.Rows.Count - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(15).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(16).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs) Handles ComboBox2.Enter
        If ComboBox2.Text = "Selectionner" Then
            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from fiche where NBVELOS like '%" + ComboBox2.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        DataGridView1.DataSource = dt
        '==================================================================================================================
        Lblmontant.Text = DataGridView1.Rows.Count - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(15).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(16).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        If ComboBox1.Text = "selectionner" Then
            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from fiche where PROVINCE like '%" + ComboBox1.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            '==================================================================================================================
            Lblmontant.Text = DataGridView1.Rows.Count - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(15).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(16).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme 
            '==================================================================================================================
            Lblpousseur.Text = sum2
            PictureBox1.Image = covertToImage(Me.DataGridView1.Item(18, DataGridView1.CurrentRow.Index).Value)


        Catch ex As Exception
            MsgBox("erreur", MsgBoxStyle.AbortRetryIgnore)

        End Try
    End Sub

    Private Sub Txtrecherche4_ValueChanged(sender As Object, e As EventArgs) Handles Txtrecherche4.ValueChanged
        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from fiche where DATE_ADHESION like '%" + Txtrecherche4.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            '==================================================================================================================
            Lblmontant.Text = DataGridView1.Rows.Count - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(15).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(16).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme 
            '==================================================================================================================
            Lblpousseur.Text = sum2



        Catch ex As Exception
            MsgBox("erreur")
        End Try


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            ComboBox1.Text = ""
            Txtrecherche1.Text = ""
            Txtrecherche2.Text = ""
            Txtrecherche3.Text = ""
            ComboBox2.Text = ""
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from fiche where PROVINCE like '%" + ComboBox1.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            '==================================================================================================================
            Lblmontant.Text = DataGridView1.Rows.Count - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(15).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(16).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme 
            '==================================================================================================================
            Lblpousseur.Text = sum2


        Catch ex As Exception
            MsgBox("erreur")

        End Try
    End Sub

    Private Sub Txtrecherche1_Enter(sender As Object, e As EventArgs) Handles Txtrecherche1.Enter
        If Txtrecherche1.Text = "Chercher le nom" Then
            Txtrecherche1.Text = ""
            Txtrecherche1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche1_Leave(sender As Object, e As EventArgs) Handles Txtrecherche1.Leave
        If Txtrecherche1.Text = "" Then
            Txtrecherche1.Text = "Chercher le nom"
            Txtrecherche1.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche3_Enter(sender As Object, e As EventArgs) Handles Txtrecherche3.Enter
        If Txtrecherche3.Text = "Chercher le prénom" Then
            Txtrecherche3.Text = ""
            Txtrecherche3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche3_Leave(sender As Object, e As EventArgs) Handles Txtrecherche3.Leave
        If Txtrecherche3.Text = "" Then
            Txtrecherche3.Text = "Chercher le prénom"
            Txtrecherche3.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche2_Leave(sender As Object, e As EventArgs) Handles Txtrecherche2.Leave
        If Txtrecherche2.Text = "" Then
            Txtrecherche2.Text = "selectioner"
            Txtrecherche2.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub ComboBox2_Leave(sender As Object, e As EventArgs) Handles ComboBox2.Leave
        If ComboBox2.Text = "" Then
            ComboBox2.Text = "Selectionner"
            ComboBox2.ForeColor = Color.DimGray
        End If

    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles ComboBox1.Leave
        If ComboBox1.Text = "" Then
            ComboBox1.Text = "selectionner"
            ComboBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Fiche_d_adhesion.Show()
        Fiche_d_adhesion.MdiParent = ACCEUIL
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        listemembre.Show()
        Me.Close()
        listemembre.MdiParent = ACCEUIL
    End Sub
End Class