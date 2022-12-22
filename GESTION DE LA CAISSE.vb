Imports System.Data.OleDb
Public Class GESTION_DE_LA_CAISSE
    '==================================================================================================================
    'declaration des different object qui nous servira de la connexion et l'adptation avec la base de données ainsi et des commandes
    '==================================================================================================================
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
    Dim da As New OleDbDataAdapter("select*from CAISSE", cn)
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub GESTION_DE_LA_CAISSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(ds, "CAISSE")
        bnd = BindingContext(ds.Tables("CAISSE"))
        '==================================================================================================================
        'l'affichage des membres dans les textbox respectivement
        '==================================================================================================================
        Txtid_transaction.DataBindings.Add("text", ds.Tables("CAISSE"), "Id")
        Txtdate.DataBindings.Add("text", ds.Tables("CAISSE"), "deposer_le")
        Txtnomcassier.DataBindings.Add("text", ds.Tables("CAISSE"), "caissier")
        txtmontantentrant.DataBindings.Add("text", ds.Tables("CAISSE"), "montant_entrant")
        Txtsortie.DataBindings.Add("text", ds.Tables("CAISSE"), "montant_sorti")
        Txtahtk.DataBindings.Add("text", ds.Tables("CAISSE"), "droit_comité_ahtk")
        Txturbain.DataBindings.Add("text", ds.Tables("CAISSE"), "rapport_urbain")
        Txtretrait.DataBindings.Add("text", ds.Tables("CAISSE"), "reussi_par")
        Txtmotif.DataBindings.Add("text", ds.Tables("CAISSE"), "motif")
        Txtencaisse.DataBindings.Add("text", ds.Tables("CAISSE"), "montant_caisse")
        Txtenbanque.DataBindings.Add("text", ds.Tables("CAISSE"), "montant_banque")

        'chargement des donnés de la base de données dans datagridview pour leur affichage
        '==================================================================================================================
        DataGridView1.DataSource = ds.Tables("CAISSE")

        Dim sum1, sum2, sum3, sum4, sum5, sum6 As Decimal
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(3).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme  de l'argent reussi
        '==================================================================================================================
        Tentrant.Text = sum1
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum2 += DataGridView1.Rows(i).Cells(4).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
        '==================================================================================================================
        Tsortant.Text = sum2
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum3 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent  de la caisse
        '==================================================================================================================
        Lblahtk.Text = sum3
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum4 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Lblurbain.Text = sum4
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum5 += DataGridView1.Rows(i).Cells(9).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tcaisse.Text = sum5
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum6 += DataGridView1.Rows(i).Cells(10).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tbanque.Text = sum6

        Cmbcaisse.Items.Clear()
        cmd.CommandText = "select*from CAISSE"
        cmd.Connection = cn
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            Cmbcaisse.Items.Add(dr.GetValue(9))
        End While
        dr.Close()
        Cmbbanque.Items.Clear()
        cmd.CommandText = "select*from CAISSE"
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        While dr.Read
            Cmbbanque.Items.Add(dr.GetValue(10))
        End While
        dr.Close()
        Txtrecherche1.Items.Clear()
        cmd.CommandText = "select*from CAISSE"
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        While dr.Read
            Txtrecherche1.Items.Add(dr.GetValue(2))
        End While
        dr.Close()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Blue
            Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA"
        ElseIf Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Red
            Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        End If
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
        bnd.Position = ds.Tables("CAISSE").Rows.Count - 1

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
        If Txtdate.Text = "" Then
            Txtdate.BackColor = Color.Red
            Txtdate.Focus()
            MsgBox("veuillez saisir la date!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtdate.BackColor = Color.White
        End If
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtnomcassier.Text = "" Then
            Txtnomcassier.BackColor = Color.Red
            Txtnomcassier.Focus()
            MsgBox("veuillez saisir le nom du cassier!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtnomcassier.BackColor = Color.White
        End If
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtmontantentrant.Text = "" Then
            txtmontantentrant.BackColor = Color.Red
            txtmontantentrant.Focus()
            MsgBox("veuillez saisir le montant entrant!,si le montant est vide mettez 0!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtmontantentrant.BackColor = Color.White
        End If

        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtsortie.Text = "" Then
            Txtsortie.BackColor = Color.Red
            Txtsortie.Focus()
            MsgBox("veuillez saisir les montants sortant, si le montant est vide mettez 0!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtsortie.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtmotif.Text = "" Then
            Txtmotif.BackColor = Color.Red
            Txtmotif.Focus()
            MsgBox("veuillez saisir le motif de cette transaction!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtencaisse.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtencaisse.Text = "" Then
            Txtencaisse.BackColor = Color.Red
            Txtencaisse.Focus()
            MsgBox("veuillez saisir le montant en caisse!, si le montant est vide mettez 0", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtencaisse.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtenbanque.Text = "" Then
            Txtenbanque.BackColor = Color.Red
            Txtenbanque.Focus()
            MsgBox("veuillez saisir le montant en banque!, si le montant est vide mettez 0", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtenbanque.BackColor = Color.White
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
            Dim sw As Integer
            sw = 0
            For s = 0 To Me.DataGridView1.RowCount - 2
                If Txtdate.Text = Me.DataGridView1.Item(1, 0).Value Then
                    sw = 1
                End If
            Next
            If sw = 0 Then
                Dim newligne As DataRow
                newligne = ds.Tables("CAISSE").NewRow
                On Error Resume Next
                newligne(0) = UCase(Txtid_transaction.Text)
                newligne(1) = UCase(Txtdate.Text)
                newligne(2) = UCase(Txtnomcassier.Text)
                newligne(3) = UCase(txtmontantentrant.Text)
                newligne(4) = UCase(Txtsortie.Text)
                newligne(5) = UCase(Txtmotif.Text)
                newligne(6) = UCase(Txtahtk.Text)
                newligne(7) = UCase(Txturbain.Text)
                newligne(8) = UCase(Txtretrait.Text)
                newligne(9) = UCase(Txtencaisse.Text)
                newligne(10) = UCase(Txtenbanque.Text)
                ds.Tables("CAISSE").Rows.Add(newligne)
                Dim cmdbuild As OleDb.OleDbCommandBuilder
                cmdbuild = New OleDb.OleDbCommandBuilder(da)
                da.InsertCommand = cmdbuild.GetInsertCommand
                da.Update(ds, "CAISSE")
                '==================================================================================================================
                'message de confirmation
                '==================================================================================================================
                MsgBox("ajout avecx succes", MsgBoxStyle.Information)
                cn.Close()
            End If

            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2, sum3, sum4 As Decimal
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(3).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme  de l'argent reussi
            '==================================================================================================================
            Tentrant.Text = sum1
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum2 += DataGridView1.Rows(i).Cells(4).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
            '==================================================================================================================
            Tsortant.Text = sum2
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum3 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent  de la caisse
            '==================================================================================================================
            Tcaisse.Text = sum3
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum4 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent de la banque
            '==================================================================================================================
            Tbanque.Text = sum4
        Else
            '==================================================================================================================
            'si l'utilisateur appuye sur non donc on quitte la procedure
            '==================================================================================================================
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' la procedure de forcer l'utilisateur de remplir le champs obligatoire
        '============================================================================
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtdate.Text = "" Then
            Txtdate.BackColor = Color.Red
            Txtdate.Focus()
            MsgBox("veuillez saisir la date!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtdate.BackColor = Color.White
        End If
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtnomcassier.Text = "" Then
            Txtnomcassier.BackColor = Color.Red
            Txtnomcassier.Focus()
            MsgBox("veuillez saisir le nom du cassier!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtnomcassier.BackColor = Color.White
        End If
        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If txtmontantentrant.Text = "" Then
            txtmontantentrant.BackColor = Color.Red
            txtmontantentrant.Focus()
            MsgBox("veuillez saisir le montant entrant!,si le montant est vide mettez 0!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtmontantentrant.BackColor = Color.White
        End If

        'tester si textebox nom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtsortie.Text = "" Then
            Txtsortie.BackColor = Color.Red
            Txtsortie.Focus()
            MsgBox("veuillez saisir les montants sortant, si le montant est vide mettez 0!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtsortie.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtmotif.Text = "" Then
            Txtmotif.BackColor = Color.Red
            Txtmotif.Focus()
            MsgBox("veuillez saisir le motif de cette transaction!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtencaisse.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtencaisse.Text = "" Then
            Txtencaisse.BackColor = Color.Red
            Txtencaisse.Focus()
            MsgBox("veuillez saisir le montant en caisse!, si le montant est vide mettez 0", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtencaisse.BackColor = Color.White
        End If
        'tester si textebox Txtpostnom est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
        If Txtenbanque.Text = "" Then
            Txtenbanque.BackColor = Color.Red
            Txtenbanque.Focus()
            MsgBox("veuillez saisir le montant en banque!, si le montant est vide mettez 0", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            Txtenbanque.BackColor = Color.White
        End If
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim ajouter As New OleDbCommandBuilder(da)
        '===================================================================================================================
        'tester si l'utilisateur veut reellement ajouter un enregistrement dans la base de données
        '===================================================================================================================
        If MsgBox("Voudriez-vous modifier un enregistrement?", MsgBoxStyle.OkCancel, "Ajout") = MsgBoxResult.Ok Then
            's'il confirment nous passons directemrnt dans la procedure enregistremnent don nous avons utilisé update
            bnd.EndCurrentEdit()
            '=================================================================================================================
            'donner la precision sur quelle table nous voulons ajouter l'enregistrement
            '===================================================================================================================
            da.Update(ds, "CAISSE")
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2, sum3, sum4 As Decimal
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(3).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme  de l'argent reussi
            '==================================================================================================================
            Tentrant.Text = sum1
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum2 += DataGridView1.Rows(i).Cells(4).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
            '==================================================================================================================
            Tsortant.Text = sum2
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum3 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent  de la caisse
            '==================================================================================================================
            Tcaisse.Text = sum3
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum4 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent de la banque
            '==================================================================================================================
            Tbanque.Text = sum4
            '==================================================================================================================
            'message de confirmation
            '==================================================================================================================
            MsgBox("modifier avec succès!")
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
            da.Update(ds, "CAISSE")
            '==================================================================================================================
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1, sum2, sum3, sum4 As Decimal
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(3).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme  de l'argent reussi
            '==================================================================================================================
            Tentrant.Text = sum1
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum2 += DataGridView1.Rows(i).Cells(4).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
            '==================================================================================================================
            Tsortant.Text = sum2
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum3 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent  de la caisse
            '==================================================================================================================
            Tcaisse.Text = sum3
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum4 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent de la banque
            '==================================================================================================================
            Tbanque.Text = sum4
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

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
        ACCEUIL.Show()
    End Sub

    Private Sub Txtrecherche1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Txtrecherche4_ValueChanged(sender As Object, e As EventArgs) Handles Txtrecherche4.ValueChanged
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from CAISSE where Deposer_le like '%" + Txtrecherche4.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Dim sum1, sum2, sum3, sum4, sum5, sum6 As Decimal
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(3).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme  de l'argent reussi
        '==================================================================================================================
        Tentrant.Text = sum1
        Txtrechercheentrant.Text = sum1
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum2 += DataGridView1.Rows(i).Cells(4).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
        '==================================================================================================================
        Tsortant.Text = sum2
        Txtrecherchesortant.Text = sum2
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum3 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent  de la caisse
        '==================================================================================================================
        Lblahtk.Text = sum3
        Txtrechercheahtk.Text = sum3
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum4 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Lblurbain.Text = sum4
        Txtrechercheurbain.Text = sum4
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum5 += DataGridView1.Rows(i).Cells(9).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tcaisse.Text = sum5
        Txtrechercheencaisse.Text = sum5
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum6 += DataGridView1.Rows(i).Cells(10).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tbanque.Text = sum6
        Txtrecherchebanque.Text = sum6
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from CAISSE where caissier like '%" + Txtrecherche1.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Dim sum1, sum2, sum3, sum4, sum5, sum6 As Decimal
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(3).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme  de l'argent reussi
        '==================================================================================================================
        Tentrant.Text = sum1
        Txtrechercheentrant.Text = sum1
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum2 += DataGridView1.Rows(i).Cells(4).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
        '==================================================================================================================
        Tsortant.Text = sum2
        Txtrecherchesortant.Text = sum2
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum3 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent  de la caisse
        '==================================================================================================================
        Lblahtk.Text = sum3
        Txtrechercheahtk.Text = sum3
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum4 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Lblurbain.Text = sum4
        Txtrechercheurbain.Text = sum4
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum5 += DataGridView1.Rows(i).Cells(9).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tcaisse.Text = sum5
        Txtrechercheencaisse.Text = sum5
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum6 += DataGridView1.Rows(i).Cells(10).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tbanque.Text = sum6
        Txtrecherchebanque.Text = sum6
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If D1.Text = "" Then
            MsgBox("Veuillez inserer la date de depart celle d'arriver", MsgBoxStyle.Exclamation, "Recherche de date")
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from CAISSE where Deposer_le  between #" & D1.Text & "# and #" & D2.Text & "#", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            '=================================================================================
            Dim sum1, sum2, sum3, sum4 As Decimal
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(3).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme  de l'argent reussi
            '==================================================================================================================
            Tentrant.Text = sum1
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum2 += DataGridView1.Rows(i).Cells(4).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
            '==================================================================================================================
            Tsortant.Text = sum2
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum3 += DataGridView1.Rows(i).Cells(6).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent  de la caisse
            '==================================================================================================================
            Tcaisse.Text = sum3
            'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum4 += DataGridView1.Rows(i).Cells(7).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme de  l'argent de la banque
            '==================================================================================================================
            Tbanque.Text = sum4
        End If
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MARDOHEE MKM\Documents\Visual Studio 2012\Projects\GESTION ASSOCIATION\GESTION ASSOCIATION\bin\Debug\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from CAISSE where montant_caisse like '%" + Cmbcaisse.Text + "%'", cn)
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        da.SelectCommand = cmd1
        dt.Clear()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Dim sum1, sum2, sum3, sum4, sum5, sum6 As Decimal
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(3).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme  de l'argent reussi
        '==================================================================================================================
        Tentrant.Text = sum1
        Txtrechercheentrant.Text = sum1
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum2 += DataGridView1.Rows(i).Cells(4).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
        '==================================================================================================================
        Tsortant.Text = sum2
        Txtrecherchesortant.Text = sum2
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum3 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent  de la caisse
        '==================================================================================================================
        Lblahtk.Text = sum3
        Txtrechercheahtk.Text = sum3
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum4 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Lblurbain.Text = sum4
        Txtrechercheurbain.Text = sum4
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum5 += DataGridView1.Rows(i).Cells(9).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tcaisse.Text = sum5
        Txtrechercheencaisse.Text = sum5
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum6 += DataGridView1.Rows(i).Cells(10).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tbanque.Text = sum6
        Txtrecherchebanque.Text = sum6
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from CAISSE where montant_banque like '%" + Cmbbanque.Text + "%'", cn)
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
        Dim sum1, sum2, sum3, sum4, sum5, sum6 As Decimal
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(3).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme  de l'argent reussi
        '==================================================================================================================
        Tentrant.Text = sum1
        Txtrechercheentrant.Text = sum1
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum2 += DataGridView1.Rows(i).Cells(4).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent depenser ou sortie de la caisse
        '==================================================================================================================
        Tsortant.Text = sum2
        Txtrecherchesortant.Text = sum2
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum3 += DataGridView1.Rows(i).Cells(6).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent  de la caisse
        '==================================================================================================================
        Lblahtk.Text = sum3
        Txtrechercheahtk.Text = sum3
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum4 += DataGridView1.Rows(i).Cells(7).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Lblurbain.Text = sum4
        Txtrechercheurbain.Text = sum4
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum5 += DataGridView1.Rows(i).Cells(9).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tcaisse.Text = sum5
        Txtrechercheencaisse.Text = sum5
        'utilisation de la boucle for pour faire la somme de chaque l'argent reussi dans l'assocition ou depenser
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum6 += DataGridView1.Rows(i).Cells(10).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de  l'argent de la banque
        '==================================================================================================================
        Tbanque.Text = sum6
        Txtrecherchebanque.Text = sum6
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
        Impression_des_caisse.Show()
        Impression_des_caisse.MdiParent = ACCEUIL
    End Sub
End Class