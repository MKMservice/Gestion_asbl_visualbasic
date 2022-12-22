Imports System.Data.OleDb
Public Class CONNEXION
    'delaration des variables generale qui doit nous accompagener tout au long de notre codage
    Public cn As OleDbConnection
    Public Cmd As OleDbCommand
    Public R As OleDbDataReader
    Public T As DataTable
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Private Sub FORM1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ouvertutr de la connexion à la base de données et son chemin
        cn = New OleDbConnection
        cn.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        cn.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'nous declarons un variable compteur
        Static i As Integer = 0
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtnom.Text = "" Then
            Txtnom.BackColor = Color.Red
            Txtnom.Focus()
            txtmegs.Text = "veuillez inserer le nom!"
            Exit Sub
        End If
        'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
        Txtnom.BackColor = Color.White
        'tester si textebox postnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtprenom.Text = "" Then
            Txtprenom.BackColor = Color.Red
            Txtprenom.Focus()
            txtmegs.Text = "veuillez inserer le prenom!"

            Exit Sub
        End If
        'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
        Txtprenom.BackColor = Color.White
        'tester si textebox mot de passe est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtpass.Text = "" Then
            Txtpass.BackColor = Color.Red
            Txtpass.Focus()
            txtmegs.Text = "veuillez inserer le mot de passe!"
            Exit Sub
        End If
        'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
        Txtpass.BackColor = Color.White
        'on cree maintenat une commande de chargement de la base et son table user dans le champ nom prenom postnom
        Cmd = cn.CreateCommand
        Cmd.CommandText = "select *from TRAVAILLEUR where nom='" & Txtnom.Text & "'  and prenom='" & Txtprenom.Text & "' and confirmation='" & Txtpass.Text & "'"
        R = Cmd.ExecuteReader
        txtmegs.Text = ""
        If R.Read = True Then
            'on affiche le profil d'utilisateur connecter
            Dim da As New OleDbDataAdapter("select *from TRAVAILLEUR where nom='" & Txtnom.Text & "'  and prenom='" & Txtprenom.Text & "' and confirmation='" & Txtpass.Text & "'", cn)
            da.Fill(ds, "TRAVAILLEUR")
            bnd = BindingContext(ds.Tables("TRAVAILLEUR"))
            txtmegs.DataBindings.Add("text", ds.Tables("TRAVAILLEUR"), "configuration")
            Timer1.Enabled = True
        Else
            MsgBox("Compte incorrect")
            'nous comptons les nombres de tantative incorrect pour fermer à la troixième
            i = i + 1
            MsgBox("Après 3 tantative incorrect on bloque")
            If i = 3 Then
                Me.Close()
            End If
        End If
        R.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Pr.Increment(2)
        Pr.Maximum = 100
        Pr.Minimum = 0
        lbllongin.Text = Pr.Value & "%"
        If Pr.Value = 100 Then
            'on fait a ce que apres l ecoulement de temps determiner sur timer qu on affiche la page d'acceuil
            If txtmegs.Text <> "administrateur" Then
                ACCEUIL.Menuadmin.Enabled = False
                FICHE_ADHESION.Button2.Enabled = False
                FICHE_ADHESION.Button3.Enabled = False
                GESTION_DES_COTISATIONS.Button3.Enabled = False
                GESTION_DES_COTISATIONS.Button2.Enabled = False
                GESTION_DES_COTISATIONS.Button14.Enabled = False
                GESTION_DES_COTISATIONS.Lblmontant.Visible = False
                GESTION_DES_COTISATIONS.Label11.Visible = False
                GESTION_DE_LA_CAISSE.Button3.Enabled = False
                GESTION_DE_LA_CAISSE.Button2.Enabled = False
                GESTION_DE_LA_CAISSE.Button13.Enabled = False
                GESTION_DE_LA_CAISSE.Panel1.Visible = False

            Else
            End If
            cn.Close()
            ACCEUIL.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Txtpass.UseSystemPasswordChar = True Then
            Txtpass.UseSystemPasswordChar = False
        ElseIf Txtpass.UseSystemPasswordChar = False Then
            Txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Pr_Click(sender As Object, e As EventArgs) Handles Pr.Click
    End Sub
End Class
