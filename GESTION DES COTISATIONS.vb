Imports System.Data.OleDb
Public Class GESTION_DES_COTISATIONS
    '==================================================================================================================
    'declaration des different object qui nous servira de la connexion et l'adptation avec la base de données ainsi et des commandes
    '==================================================================================================================
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
    Dim da As New OleDbDataAdapter("select*from COTISATION", cn)
    Dim ds As New DataSet
    Dim bnd As BindingManagerBase
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub GESTION_DES_COTISATIONS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()
        '==================================================================================================================
        'chargement de la table membre dans dataset
        '==================================================================================================================
        da.Fill(ds, "COTISATION")
        bnd = BindingContext(ds.Tables("COTISATION"))
        '==================================================================================================================
        'l'affichage des membres dans les textbox respectivement
        '==================================================================================================================
        Txtid_ordre.DataBindings.Add("text", ds.Tables("COTISATION"), "Id")
        Txtdate.DataBindings.Add("text", ds.Tables("COTISATION"), "cotise")
        Txtnom.DataBindings.Add("text", ds.Tables("COTISATION"), "nom")
        Txtpostnom.DataBindings.Add("text", ds.Tables("COTISATION"), "postnom")
        txtprenom.DataBindings.Add("text", ds.Tables("COTISATION"), "prenom")
        txtnmontant.DataBindings.Add("text", ds.Tables("COTISATION"), "montant")
        'chargement des donnés de la base de données dans datagridview pour leur affichage
        '==================================================================================================================
        DataGridView1.DataSource = ds.Tables("COTISATION")
        Txtnom.Items.Clear()
        cmd.CommandText = "select*from FICHE"
        cmd.Connection = cn
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            Txtnom.Items.Add(dr.GetValue(1))
        End While
        dr.Close()

        Dim sum1 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            On Error Resume Next
            sum1 += DataGridView1.Rows(i).Cells(5).Value
        Next
        '==================================================================================================================
        'l'affichage de la somme de velos
        '==================================================================================================================
        Lblmontant.Text = sum1
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
            If MsgBox("Desolé la personne ne pas encore adheré voulez vous l'ajouté?", MsgBoxStyle.YesNoCancel, "Ajout") = MsgBoxResult.Yes Then
                Me.Close()
                FICHE_ADHESION.Show()
                FICHE_ADHESION.MdiParent = ACCEUIL
                Exit Sub
            Else
                'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
                Txtpostnom.BackColor = Color.White
            End If
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
        If txtnmontant.Text = "" Then
            txtnmontant.BackColor = Color.Red
            txtnmontant.Focus()
            MsgBox("veuillez saisir le montant cotisé par le membre!", MsgBoxStyle.Exclamation, "Ajout")
            Exit Sub
        Else
            'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
            txtnmontant.BackColor = Color.White
        End If
        '===================================================================================================================
        'declaration de l'adaptateur
        '===================================================================================================================
        Dim ajouter As New OleDbCommandBuilder(da)
        '===================================================================================================================
        'tester si l'utilisateur veut reellement ajouter un enregistrement dans la base de données
        '===================================================================================================================
        If MsgBox("Voudriez-vous ajoutez un nouveau membre?", MsgBoxStyle.OkCancel, "Ajout") = MsgBoxResult.Ok Then
            Dim sw As Integer
            sw = 0
            For s = 0 To Me.DataGridView1.RowCount - 2
                If Txtdate.Text = Me.DataGridView1.Item(1, 0).Value Then
                    sw = 1
                End If
            Next
            If sw = 0 Then
                Dim newligne As DataRow
                newligne = ds.Tables("COTISATION").NewRow
                On Error Resume Next
                newligne(0) = UCase(Txtid_ordre.Text)
                newligne(1) = UCase(Txtdate.Text)
                newligne(2) = UCase(Txtnom.Text)
                newligne(3) = UCase(Txtpostnom.Text)
                newligne(4) = UCase(txtprenom.Text)
                newligne(5) = UCase(txtnmontant.Text)
                ds.Tables("COTISATION").Rows.Add(newligne)
                Dim cmdbuild As OleDb.OleDbCommandBuilder
                cmdbuild = New OleDb.OleDbCommandBuilder(da)
                da.InsertCommand = cmdbuild.GetInsertCommand
                da.Update(ds, "COTISATION")

                Dim sum1 As Decimal
                'utilisation de la boucle for pour bien compter le nombre de velos
                '==================================================================================================================
                For i = 0 To DataGridView1.Rows.Count - 1

                    sum1 += DataGridView1.Rows(i).Cells(5).Value
                Next
                '==================================================================================================================
                'l'affichage de la somme velos
                '==================================================================================================================
                Lblmontant.Text = sum1
                '==================================================================================================================
                '==================================================================================================================
                'message de confirmation
                '==================================================================================================================
                MsgBox("ajout avec succes", MsgBoxStyle.Information)
                '==================================================================================================================
                'procedure de vider les champs d'ajout
                '=================================================================================================================

                cn.Close()
            End If
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Blue
            Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA"
        ElseIf Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Red
            Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
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
            'tester si textebox telephone est vide ou pas s il est vide la couleur de fond change en rouge et nous ramene toujours sur lui
            If txtnmontant.Text = "" Then
                txtnmontant.BackColor = Color.Red
                txtnmontant.Focus()
                MsgBox("veuillez saisir le montant cotisé par le membre!", MsgBoxStyle.Exclamation, "Ajout")
                Exit Sub
            Else
                'si il ne pas vide on nous remet notre couleur d'orige qui est la couleur blanche
                txtnmontant.BackColor = Color.White
            End If

            '===================================================================================================================
            'declaration de l'adaptateur
            '===================================================================================================================
            Dim ajouter As New OleDbCommandBuilder(da)
            '===================================================================================================================
            'tester si l'utilisateur veut reellement ajouter un enregistrement dans la base de données
            '===================================================================================================================
            If MsgBox("Voudriez-vous modifier de ce membre?", MsgBoxStyle.OkCancel, "Ajout") = MsgBoxResult.Ok Then
                's'il confirment nous passons directemrnt dans la procedure enregistremnent don nous avons utilisé update
                bnd.EndCurrentEdit()
                '=================================================================================================================
                'donner la precision sur quelle table nous voulons ajouter l'enregistrement
                '===================================================================================================================
                da.Update(ds, "COTISATION")
                '==================================================================================================================
                ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
                '===================================================================================================================
                Dim sum1 As Decimal
                'utilisation de la boucle for pour bien compter le nombre de velos
                '==================================================================================================================
                For i = 0 To DataGridView1.Rows.Count - 1

                    sum1 += DataGridView1.Rows(i).Cells(5).Value
                Next
                '==================================================================================================================
                'l'affichage de la somme velos
                '==================================================================================================================
                Lblmontant.Text = sum1
                '==================================================================================================================
                '==================================================================================================================
                'message de confirmation
                '==================================================================================================================
                MsgBox("Modifier avec succès!")
            Else
                Exit Sub
                '==================================================================================================================
                'si l'utilisateur appuye sur non donc on quitte la procedure
                '==================================================================================================================
            End If

        Catch ex As Exception
            MsgBox("veuillez selectionner bien la date", MsgBoxStyle.RetryCancel, "GESTION ASSOCIATION/AKOUT")
        End Try
       
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
            da.Update(ds, "COTISATION")
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(5).Value
            Next
            '==================================================================================================================
            'l'affichage de la somme velos
            '==================================================================================================================
            Lblmontant.Text = sum1
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
        bnd.Position = ds.Tables("COTISATION").Rows.Count - 1
    End Sub

    Private Sub Txtrecherche4_ValueChanged(sender As Object, e As EventArgs) Handles Txtrecherche4.ValueChanged
        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from cotisation where Cotise like '%" + Txtrecherche4.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
            '===================================================================================================================
            Dim sum1 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(5).Value
            Next
            Txtrecherche.Text = sum1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Txtrecherche1.Text = "rehercher le nom" Then
            MsgBox("Veuillez saisir le nom", MsgBoxStyle.Exclamation, "GESTION ASSOCIATION/RECHERCHE")
            Txtrecherche1.Focus()
        End If
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from cotisation where nom like '%" + Txtrecherche1.Text + "%'", cn)
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
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(5).Value
        Next
        Txtrecherche.Text = sum1

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Txtrecherche2.Text = "rehercher le prénom" Then
            MsgBox("Veuillez saisir le prénom", MsgBoxStyle.Exclamation, "GESTION ASSOCIATION/RECHERCHE")
            Txtrecherche2.Focus()
        End If
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from cotisation where prenom like '%" + Txtrecherche2.Text + "%'", cn)
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
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(5).Value
        Next
        Txtrecherche.Text = sum1


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If D1.Text = "" Then
            MsgBox("Veuillez inserer la date de depart celle d'arriver", MsgBoxStyle.Exclamation, "Recherche de date")
        Else
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select*from cotisation where cotise  between #" & D1.Text & "# and #" & D2.Text & "#", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd1
            dt.Clear()
            '==================================================================================================================
            'chargement de la table membre dans dataset
            '==================================================================================================================
            da.Fill(dt)
            DataGridView1.DataSource = dt
            '===================================================================================================================
            Dim sum1 As Decimal
            'utilisation de la boucle for pour bien compter le nombre de velos
            '==================================================================================================================
            For i = 0 To DataGridView1.Rows.Count - 1
                sum1 += DataGridView1.Rows(i).Cells(5).Value
            Next
            Lblmontant.Text = sum1
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
        releve_de_la_cotisation.Show()
        releve_de_la_cotisation.MdiParent = ACCEUIL
    End Sub

    Private Sub Txtrecherche1_Enter(sender As Object, e As EventArgs) Handles Txtrecherche1.Enter
        If Txtrecherche1.Text = "rehercher le nom" Then
            Txtrecherche1.Text = ""
            Txtrecherche1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche1_Leave(sender As Object, e As EventArgs) Handles Txtrecherche1.Leave
        If Txtrecherche1.Text = "" Then
            Txtrecherche1.Text = "rehercher le nom"
            Txtrecherche1.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Txtrecherche2_Enter(sender As Object, e As EventArgs) Handles Txtrecherche2.Enter
        If Txtrecherche2.Text = "rehercher le prénom" Then
            Txtrecherche2.Text = ""
            Txtrecherche2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtrecherche2_Leave(sender As Object, e As EventArgs) Handles Txtrecherche2.Leave
        If Txtrecherche2.Text = "" Then
            Txtrecherche2.Text = "rehercher le prénom"
            Txtrecherche2.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Txtrecherche1.Text = ""
        Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
        Dim cmd1 As New OleDbCommand("select*from cotisation where nom like '%" + Txtrecherche1.Text + "%'", cn)
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
        ' declaration de la variable qui ddoit nous faciliter de faire la somme des velos et celle des pousseurs
        '===================================================================================================================
        Dim sum1 As Decimal
        'utilisation de la boucle for pour bien compter le nombre de velos
        '==================================================================================================================
        For i = 0 To DataGridView1.Rows.Count - 1
            sum1 += DataGridView1.Rows(i).Cells(5).Value
        Next
        Lblmontant.Text = sum1
        Txtrecherche.Text = ""
    End Sub

    Private Sub Txtnom_Enter(sender As Object, e As EventArgs) Handles Txtnom.Enter
        If Txtnom.Text = "selectionner le nom" Then
            Txtnom.Text = ""
        End If

    End Sub

    Private Sub Txtnom_Leave(sender As Object, e As EventArgs) Handles Txtnom.Leave
        If Txtnom.Text = "" Then
            Txtnom.Text = "selectionner le nom"
        End If
    End Sub
    Private Sub Txtnom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Txtnom.SelectedIndexChanged
        Try
            Dim dr As OleDbDataReader
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\GESTION ASSOCIATION.mdb")
            Dim cmd1 As New OleDbCommand("select NOM,PRENOM,PERE  from FICHE where NOM like '%" + Txtnom.Text + "%'", cn)
            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            cn.Open()
            cmd1.ExecuteNonQuery()
            dr = cmd1.ExecuteReader
            If dr.Read Then
                txtprenom.Text = dr("PRENOM")
                Txtpostnom.Text = dr("PERE")
            Else
            End If

        Catch ex As Exception
            MsgBox("erreur")
        End Try
    End Sub

End Class