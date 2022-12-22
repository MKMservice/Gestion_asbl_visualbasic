Imports System.Data.OleDb
Public Class USERS
    '==================================================================================================================
    'declaration des different object qui nous servira de la connexion et l'adptation avec la base de données ainsi et des commandes
    '==================================================================================================================
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
    Dim da As New OleDbDataAdapter("select*from TRAVAILLEUR", cn)
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub USERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(ds, "TRAVAILLEUR")
        bnd = BindingContext(ds.Tables("TRAVAILLEUR"))
        '==================================================================================================================
        'l'affichage des membres dans les textbox respectivement
        '==================================================================================================================
        Txtusers.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "Id_travailleur")
        Txtnom.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "NOM")
        txtprenom.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "PRENOM")
        txtmotdepasse.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "CONFIRMATION")
        Txtprofil.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "configuration")
        Txttele.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "TELE")
        Txtnote.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "observation")

        'chargement des donnés de la base de données dans datagridview pour leur affichage
        '==================================================================================================================
        DataGridView1.DataSource = ds.Tables("TRAVAILLEUR")
        Lblmontant.Text = DataGridView1.RowCount - 1
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '==================================================================================================================
        'la procedure d'aller à la fin de notre liste des mebres dans datagriview
        '==================================================================================================================
        bnd.Position = ds.Tables("TRAVAILLEUR").Rows.Count - 1

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        ACCEUIL.Show()
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
        If Txtnom.Text = "" Then
            Txtnom.BackColor = Color.Red
            Txtnom.Focus()
            MsgBox("veuillez saisir le nom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtnom.BackColor = Color.White
        End If
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtprenom.Text = "" Then
            txtprenom.BackColor = Color.Red
            txtprenom.Focus()
            MsgBox("veuillez saisir le Prénom  !", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtprenom.BackColor = Color.White
        End If

        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtmotdepasse.Text = "" Then
            txtmotdepasse.BackColor = Color.Red
            txtmotdepasse.Focus()
            MsgBox("veuillez saisir le mot de passe !", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtmotdepasse.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtprofil.Text = "" Then
            Txtprofil.BackColor = Color.Red
            Txtprofil.Focus()
            MsgBox("veuillez saisir le profil d'utilisateur!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtprofil.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txttele.Text = "" Then
            Txttele.BackColor = Color.Red
            Txttele.Focus()
            MsgBox("veuillez saisir le télephonique de l'utilisateur", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txttele.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtnote.Text = "" Then
            Txtnote.BackColor = Color.Red
            Txtnote.Focus()
            MsgBox("veuillez saisir une note.Ex:secretaire,vendeur...!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtnote.BackColor = Color.White
        End If
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim aj As New OleDbCommandBuilder(da)
        If MsgBox("Voudriez-vous ajoutez un nouveau membre?", MsgBoxStyle.OkCancel, "Ajout") = MsgBoxResult.Ok Then
            bnd.EndCurrentEdit()
            da.Update(ds, "TRAVAILLEUR")
            MsgBox("ajouter avec succès!")
        Else
            Exit Sub
            '==================================================================================================================
            'si l'utilisateur appuye sur non donc on quitte la procedure
            '==================================================================================================================
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim Supprimer As New OleDbCommandBuilder(da)

        If MsgBox("Voudriez-vous supprimer?", MsgBoxStyle.OkCancel, "Suppression") = MsgBoxResult.Ok Then
            bnd.RemoveAt(bnd.Position)
            da.Update(ds, "TRAVAILLEUR")
            '==================================================================================================================
            '==================================================================================================================
            'message de confirmation
            '==================================================================================================================
            MsgBox("Supprimer avec succès!")
        Else
            '==================================================================================================================
            'si l'utilisateur appuye sur non donc on quitte la procedure
            '==================================================================================================================
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim aj As New OleDbCommandBuilder(da)
        bnd.EndCurrentEdit()
        da.Update(ds, "TRAVAILLEUR")
        MsgBox("bien ajouter!")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' creation d'une animation des changement des textes et leurs couleur apartir de demarage de timer dans la pocedure de demarage
        '================================================================================================================================
        If Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Blue
            Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA"
        ElseIf Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Red
            Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        End If
    End Sub
End Class