Imports System.Data.OleDb
'==================================================================================================================
'importation de la base des données dans le programme
'==================================================================================================================
Public Class MEMBRE
    '==================================================================================================================
    'declaration des different object qui nous servira de la connexion et l'adptation avec la base de données ainsi et des commandes
    '==================================================================================================================
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
    Dim da As New OleDbDataAdapter("select*from MEMBRE", cn)
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub afficher()
        'demarer le timer 
        Timer1.Start()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(ds, "MEMBRE")
        bnd = BindingContext(ds.Tables("MEMBRE"))
        '==================================================================================================================
        'l'affichage des membres dans les textbox respectivement
        '==================================================================================================================
        Txtid.DataBindings.Add("text", ds.Tables("MEMBRE"), "id")
        Txtnom.DataBindings.Add("text", ds.Tables("MEMBRE"), "NOM")
        Txtpostnom.DataBindings.Add("text", ds.Tables("MEMBRE"), "POSTNOM")
        txtprenom.DataBindings.Add("text", ds.Tables("MEMBRE"), "PRENOM")
        Cmbsexe.DataBindings.Add("text", ds.Tables("MEMBRE"), "SEXE")
        Txtdate.DataBindings.Add("text", ds.Tables("MEMBRE"), "arriver")
        cmbnbvelos.DataBindings.Add("text", ds.Tables("MEMBRE"), "NBVELOS")
        txtnbpouss.DataBindings.Add("text", ds.Tables("MEMBRE"), "NBPOUSSEURS")
        Txtadresse.DataBindings.Add("text", ds.Tables("MEMBRE"), "ADRESSE")
        Txttele.DataBindings.Add("text", ds.Tables("MEMBRE"), "TELE")
        Txtidusers.DataBindings.Add("text", ds.Tables("MEMBRE"), "ADRESSE")
        Txtobserv.DataBindings.Add("text", ds.Tables("MEMBRE"), "OBSERVATION")
        '==================================================================================================================
        'chargement des donnés de la base de données dans datagridview pour leur affichage
        '==================================================================================================================
        DataGridView1.DataSource = ds.Tables("MEMBRE")
        '==================================================================================================================
        'comptage des nombres des lignes qui vaut les nombres des membres
        '==================================================================================================================
        Lbltotalmembre.Text = DataGridView1.RowCount - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2
        Txtrecherche6.Items.Clear()
        cmd.CommandText = "select*from MEMBRE"
        cmd.Connection = cn
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            Txtrecherche6.Items.Add(dr.GetValue(10))
        End While

    End Sub


    Private Sub MEMBRE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher()
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
        If Txtpostnom.Text = "" Then
            Txtpostnom.BackColor = Color.Red
            Txtpostnom.Focus()
            MsgBox("veuillez saisir le Postnom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtpostnom.BackColor = Color.White
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
        'tester si textebox sexe est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Cmbsexe.Text = "" Then
            Cmbsexe.BackColor = Color.Red
            Cmbsexe.Focus()
            MsgBox("veuillez selectionner le sexe!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Cmbsexe.BackColor = Color.White
        End If
        'tester si textebox nombres de velos est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If cmbnbvelos.Text = "" Then
            cmbnbvelos.BackColor = Color.Red
            cmbnbvelos.Focus()
            MsgBox("veuillez selectionner le sexe!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            cmbnbvelos.BackColor = Color.White
        End If
        'tester si textebox nombres de velos est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If cmbnbvelos.Text > 3 Then
            cmbnbvelos.BackColor = Color.Red
            cmbnbvelos.Focus()
            MsgBox("un membre ne peut pas avoir plus de trois velos!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            cmbnbvelos.BackColor = Color.White
        End If
        'tester si textebox l'adresse est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtadresse.Text = "" Then
            Txtadresse.BackColor = Color.Red
            Txtadresse.Focus()
            MsgBox("veuillez saisir l'adresse de la où il habite!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtadresse.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txttele.Text = "" Then
            Txttele.BackColor = Color.Red
            Txttele.Focus()
            MsgBox("veuillez saisir le numero telephonique meme de son proche!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txttele.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtobserv.Text = "" Then
            Txtobserv.BackColor = Color.Red
            Txtobserv.Focus()
            MsgBox("veuillez saisir sorte d'handicap!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtobserv.BackColor = Color.White
        End If

        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
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
            da.Update(ds, "MEMBRE")
            '==================================================================================================================
            'chargement des donnés de la base de données dans datagridview pour leur affichage
            '==================================================================================================================
            Lbltotalmembre.Text = DataGridView1.RowCount - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum1 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================

            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme pousseurs
            '==================================================================================================================
            Lblpousseur.Text = sum2
            '==================================================================================================================
            'message de confirmation
            '==================================================================================================================
            MsgBox("ajouter avec succès!")
        Else
            Exit Sub
            '==================================================================================================================
            'si l'utilisateur appuye sur non donc on quitte la procedure
            '==================================================================================================================
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '==================================================================================================================
        'procedure de libere les champs pour un autre membre 
        '=================================================================================================================
        bnd.AddNew()
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
        If Txtpostnom.Text = "" Then
            Txtpostnom.BackColor = Color.Red
            Txtpostnom.Focus()
            MsgBox("veuillez saisir le Postnom!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtpostnom.BackColor = Color.White
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
        'tester si textebox sexe est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Cmbsexe.Text = "" Then
            Cmbsexe.BackColor = Color.Red
            Cmbsexe.Focus()
            MsgBox("veuillez selectionner le sexe!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Cmbsexe.BackColor = Color.White
        End If
        'tester si textebox nombres de velos est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If cmbnbvelos.Text = "" Then
            cmbnbvelos.BackColor = Color.Red
            cmbnbvelos.Focus()
            MsgBox("veuillez selectionner le sexe!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            cmbnbvelos.BackColor = Color.White
        End If
        'tester si textebox nombres de velos est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If cmbnbvelos.Text > 3 Then
            cmbnbvelos.BackColor = Color.Red
            cmbnbvelos.Focus()
            MsgBox("un membre ne peut pas avoir plus de trois velos!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            cmbnbvelos.BackColor = Color.White
        End If
        'tester si textebox l'adresse est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtadresse.Text = "" Then
            Txtadresse.BackColor = Color.Red
            Txtadresse.Focus()
            MsgBox("veuillez saisir l'adresse de la où il habite!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtadresse.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txttele.Text = "" Then
            Txttele.BackColor = Color.Red
            Txttele.Focus()
            MsgBox("veuillez saisir le numero telephonique meme de son proche!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txttele.BackColor = Color.White
        End If
        'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtobserv.Text = "" Then
            Txtobserv.BackColor = Color.Red
            Txtobserv.Focus()
            MsgBox("veuillez saisir sorte d'handicap!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtobserv.BackColor = Color.White
        End If

        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim ajouter As New OleDbCommandBuilder(da)
        '===================================================================================================================
        'tester si l'utilisateur veut reellement ajouter un enregistrement dans la base de données
        '===================================================================================================================
        If MsgBox("Voudriez-vous modifier?", MsgBoxStyle.OkCancel, "Modification") = MsgBoxResult.Ok Then
            bnd.EndCurrentEdit()
            da.Update(ds, "MEMBRE")
            '==================================================================================================================
            'chargement des donnés de la base de données dans datagridview pour leur affichage
            '==================================================================================================================
            Lbltotalmembre.Text = DataGridView1.RowCount - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================

            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme pousseurs
            '==================================================================================================================

            Lblpousseur.Text = sum2
            '==================================================================================================================
            'message de confirmation
            '==================================================================================================================
            MsgBox("modifier avec succès!")
            '==================================================================================================================
            'procedure de vider les champs d'ajout
            '=================================================================================================================
            bnd.AddNew()
        Else
            '==================================================================================================================
            'si l'utilisateur appuye sur non donc on quitte la procedure
            '==================================================================================================================
            Exit Sub
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim Supprimer As New OleDbCommandBuilder(da)

        If MsgBox("Voudriez-vous supprimer?", MsgBoxStyle.OkCancel, "Suppression") = MsgBoxResult.Ok Then
            bnd.RemoveAt(bnd.Position)
            da.Update(ds, "MEMBRE")
            '==================================================================================================================
            'chargement des donnés de la base de données dans datagridview pour leur affichage
            '==================================================================================================================
            Lbltotalmembre.Text = DataGridView1.RowCount - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================

            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme pousseurs
            '==================================================================================================================

            Lblpousseur.Text = sum2
            '==================================================================================================================
            'message de confirmation
            '==================================================================================================================

            MsgBox("supprimer avec succès!")
        Else
            '==================================================================================================================
            'si l'utilisateur appuye sur non donc on quitte la procedure
            '==================================================================================================================
            Exit Sub
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '==================================================================================================================
        'procedure de quitter la gestion des membres
        '=================================================================================================================
        Me.Close()
        ACCEUIL.Show()
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
        bnd.Position = ds.Tables("membre").Rows.Count - 1
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Txtrecherche4.ValueChanged
        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from membre where arriver like '%" + Txtrecherche4.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Lbltotalmembre.Text = DataGridView1.RowCount - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme 
            '==================================================================================================================
            Lblpousseur.Text = sum2

        Catch ex As Exception
            MsgBox("Erreur", MsgBoxStyle.Critical, "EXCEPTION")
        End Try
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
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Txtrecherche1.Text = "Rechecher le nom" Then
            MsgBox("veuillez saisir le nom", MsgBoxStyle.Exclamation, "GESTION AHTK/RECHERCHE")
            Txtrecherche1.Text = ""
            Txtrecherche1.Focus()
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from membre where nom like '%" + Txtrecherche1.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Lbltotalmembre.Text = DataGridView1.RowCount - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme 
            '==================================================================================================================
            Lblpousseur.Text = sum2

        End If
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If D1.Text = "" Then
            MsgBox("Veuillez inserer la date de depart celle d'arriver", MsgBoxStyle.Exclamation, "Recherche de date")
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from membre where arriver  between #" & D1.Text & "# and #" & D2.Text & "#", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Lbltotalmembre.Text = DataGridView1.RowCount - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme 
            '==================================================================================================================
            Lblpousseur.Text = sum2
        End If

    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            If Txtrecherche2.Text = "Rechecher le prénom" Then
                MsgBox("veuillez saisir le prénom", MsgBoxStyle.Exclamation, "GESTION AHTK/RECHERCHE")
                Txtrecherche2.Focus()
            Else
                Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
                Dim cmd1 As New OleDbCommand("select*from membre where prenom like '%" + Txtrecherche2.Text + "%'", cn)
                Dim da As New OleDbDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd1
                dt.Clear()
                '==================================================================================================================
                'chargement de la table membre dans dataset
                '==================================================================================================================
                da.Fill(dt)
                DataGridView1.DataSource = dt
                Lbltotalmembre.Text = DataGridView1.RowCount - 1
                '==================================================================================================================
                ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
                '===================================================================================================================
                Dim sum1, sum2 As Decimal
                'utilisation de la boucle for pour bien compter le nombre de velos
                '==================================================================================================================
                For i = 0 To DataGridView1.Rows.Count - 1
                    sum1 += DataGridView1.Rows(i).Cells(6).Value
                Next
                '==================================================================================================================
                'l'affichage de la somme de velos
                '==================================================================================================================
                Lblvelos.Text = sum1
                '==================================================================================================================
                'dexieme boucle for pour les pousseurs
                '==================================================================================================================
                For i = 0 To DataGridView1.Rows.Count - 1

                    sum2 += DataGridView1.Rows(i).Cells(7).Value
                Next
                '==================================================================================================================
                'l'affichage de la somme 
                '==================================================================================================================
                Lblpousseur.Text = sum2
            End If
        Catch ex As Exception
            MsgBox("Erreur", MsgBoxStyle.Critical, "EXCEPTION")
        End Try
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from membre where sexe like '%" + Txtrecherche3.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Lbltotalmembre.Text = DataGridView1.RowCount - 1
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de velos
            '==================================================================================================================
            Lblvelos.Text = sum1
            '==================================================================================================================
            'dexieme boucle for pour les pousseurs
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1

                sum2 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme 
            '==================================================================================================================
            Lblpousseur.Text = sum2

        Catch ex As Exception
            MsgBox("Erreur", MsgBoxStyle.Critical, "EXCEPTION")
        End Try
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from membre where NBVELOS like '%" + Txtrecherche5.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Lbltotalmembre.Text = DataGridView1.RowCount - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from membre where OBSERVATION like '%" + Txtrecherche6.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Lbltotalmembre.Text = DataGridView1.RowCount - 1
        '==================================================================================================================
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1, sum2 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblvelos.Text = sum1
        '==================================================================================================================
        'dexieme boucle for pour les pousseurs
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1

            sum2 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme 
        '==================================================================================================================
        Lblpousseur.Text = sum2

    End Sub
    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        listemembre.Show()
        Me.Close()
        listemembre.MdiParent = ACCEUIL
    End Sub

    Private Sub Txtrecherche1_Enter(sender As Object, e As EventArgs) Handles Txtrecherche1.Enter
        If Txtrecherche1.Text = "Rechecher le nom" Then
            Txtrecherche1.Text = ""
            Txtrecherche1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche1_Leave(sender As Object, e As EventArgs) Handles Txtrecherche1.Leave
        If Txtrecherche1.Text = "" Then
            Txtrecherche1.Text = "Rechecher le nom"
            Txtrecherche1.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche2_Enter(sender As Object, e As EventArgs) Handles Txtrecherche2.Enter
        If Txtrecherche2.Text = "Rechecher le prénom" Then
            Txtrecherche2.Text = ""
            Txtrecherche2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche2_Leave(sender As Object, e As EventArgs) Handles Txtrecherche2.Leave
        If Txtrecherche2.Text = "" Then
            Txtrecherche2.Text = "Rechecher le prénom"
            Txtrecherche2.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche3_Enter(sender As Object, e As EventArgs) Handles Txtrecherche3.Enter
        If Txtrecherche3.Text = "Selectionner le sexe" Then
            Txtrecherche3.Text = ""
            Txtrecherche3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche3_Leave(sender As Object, e As EventArgs) Handles Txtrecherche3.Leave
        If Txtrecherche3.Text = "" Then
            Txtrecherche3.Text = "Selectionner le sexe"
            Txtrecherche3.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche5_Enter(sender As Object, e As EventArgs) Handles Txtrecherche5.Enter
        If Txtrecherche5.Text = "Selectionner Nbvelos" Then
            Txtrecherche5.Text = ""
            Txtrecherche5.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche5_Leave(sender As Object, e As EventArgs) Handles Txtrecherche5.Leave
        If Txtrecherche5.Text = "" Then
            Txtrecherche5.Text = "Selectionner Nbvelos"
            Txtrecherche5.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche6_Enter(sender As Object, e As EventArgs) Handles Txtrecherche6.Enter
        If Txtrecherche6.Text = "Selectionner handicap" Then
            Txtrecherche6.Text = ""
            Txtrecherche6.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche6_Leave(sender As Object, e As EventArgs) Handles Txtrecherche6.Leave
        If Txtrecherche6.Text = "" Then
            Txtrecherche6.Text = "Selectionner handicap"
            Txtrecherche6.ForeColor = Color.DimGray
        End If
    End Sub
End Class