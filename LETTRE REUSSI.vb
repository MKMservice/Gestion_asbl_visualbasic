Imports System.IO
Imports System.Data.OleDb

Public Class LETTRE_REUSSI
    '==================================================================================================================
    'declaration des different object qui nous servira de la connexion et l'adptation avec la base de données ainsi et des commandes
    '==================================================================================================================
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
    Dim da As New OleDbDataAdapter("select*from COURRIEL", cn)
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim ouvrir As New OpenFileDialog
        Try
            ouvrir.Filter = "JPEG files(*.jpg)|*.jpg|Image files(*.bmp)|*.bmp|allfiles(*.*|*.*"

            With ouvrir
                .FilterIndex = 1
                ouvrir.CheckFileExists = True
                ouvrir.CheckPathExists = True
                ouvrir.ValidateNames = True
                ouvrir.DereferenceLinks = True
                ouvrir.RestoreDirectory = True
                .Title = "choisir une image"
                .ShowDialog()
                If Len(.FileName) > 0 Then
                    PictureBox1.Image = Image.FromFile(ouvrir.FileName)
                    Dim var As String
                    PictureBox1.Image.Save(Application.StartupPath & "\photos\" & var & ".jpg")
                End If
            End With
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LETTRE_REUSSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(ds, "COURRIEL")
        bnd = BindingContext(ds.Tables("COURRIEL"))
        '==================================================================================================================
        'l'affichage des membres dans les textbox respectivement
        '==================================================================================================================

        Txtref.DataBindings.Add("text", ds.Tables("COURRIEL"), "Reference")
        Txtdate.DataBindings.Add("text", ds.Tables("COURRIEL"), "Dateenvoi")
        Txtcopie.DataBindings.Add("text", ds.Tables("COURRIEL"), "Copie")
        Txtobjet.DataBindings.Add("text", ds.Tables("COURRIEL"), "Objet")
        txtdestination.DataBindings.Add("text", ds.Tables("COURRIEL"), "destination")
        DataGridView1.DataSource = ds.Tables("COURRIEL")
        On Error Resume Next
        PictureBox1.Image = covertToImage(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '==================================================================================================================
        'procedure de libere les champs pour un autre membre 
        '=================================================================================================================
        bnd.AddNew()
        PictureBox1.Image = Nothing
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
        Dim sw As Integer
        sw = 0
        If sw = 0 Then
            Dim newligne As DataRow
            newligne = ds.Tables("COURRIEL").NewRow
            On Error Resume Next
            newligne(1) = UCase(Txtref.Text)
            newligne(2) = UCase(Txtdate.Text)
            newligne(3) = UCase(Txtcopie.Text)
            newligne(4) = UCase(Txtobjet.Text)
            newligne(5) = UCase(txtdestination.Text)
            newligne(6) = covertToData(PictureBox1.Image)
            ds.Tables("COURRIEL").Rows.Add(newligne)
            Dim cmdbuild As OleDb.OleDbCommandBuilder
            cmdbuild = New OleDb.OleDbCommandBuilder(da)
            da.InsertCommand = cmdbuild.GetInsertCommand
            da.Update(ds, "COURRIEL")
            MsgBox("ajout avecx succes", MsgBoxStyle.Information)
            cn.Close()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '==================================================================================================================
        'la procedure d'aller à la ligne zero de notre datagridview
        '==================================================================================================================
        bnd.Position = 0
        On Error Resume Next
        PictureBox1.Image = covertToImage(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '==================================================================================================================
        'la procedure de se deplacer un par un
        '==================================================================================================================
        bnd.Position -= 1
        On Error Resume Next
        PictureBox1.Image = covertToImage(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '==================================================================================================================
        'la procedure de se deplacer un par un
        '==================================================================================================================
        bnd.Position += 1
        On Error Resume Next
        PictureBox1.Image = covertToImage(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '==================================================================================================================
        'la procedure d'aller à la fin de notre liste des mebres dans datagriview
        '==================================================================================================================
        bnd.Position = ds.Tables("COURRIEL").Rows.Count - 1
        On Error Resume Next
        PictureBox1.Image = covertToImage(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)

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
            matable = ds.Tables("COURRIEL")
            Dim laligne As DataRow()
            laligne = matable.Select("N°=" & cle)
            laligne(0).Item(1) = UCase(Txtref.Text)
            laligne(0).Item(2) = UCase(Txtdate.Text)
            laligne(0).Item(3) = UCase(Txtcopie.Text)
            laligne(0).Item(4) = UCase(Txtobjet.Text)
            laligne(0).Item(5) = UCase(txtdestination.Text)
            laligne(0).Item(6) = covertToData(PictureBox1.Image)
            Dim cmdbuild As OleDb.OleDbCommandBuilder
            cmdbuild = New OleDb.OleDbCommandBuilder(da)
            da.InsertCommand = cmdbuild.GetInsertCommand
            da.Update(ds, "COURRIEL")
            MsgBox("Modifier avecx succes", MsgBoxStyle.Information)
            cn.Close()
        End If
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim Supprimer As New OleDbCommandBuilder(da)

        If MsgBox("Voudriez-vous supprimer?", MsgBoxStyle.OkCancel, "Suppression") = MsgBoxResult.Ok Then
            bnd.RemoveAt(bnd.Position)
            da.Update(ds, "COURRIEL")
            Lblmontant.Text = DataGridView1.Rows.Count - 1
            MsgBox("Supprimer avec succès")
        End If
        On Error Resume Next
        PictureBox1.Image = covertToImage(Me.DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)

    End Sub
End Class