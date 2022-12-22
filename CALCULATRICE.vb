Public Class CALCULATRICE
    Dim fistnum As Decimal
    Dim secondnum As Decimal
    Dim operation As Integer
    Dim operator_selector As Boolean = False
    Dim watermark As String = "yes"
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            If Txtmontantreussi.Text = "" Then
                MsgBox("Veuillez saisir le montant reussi avant de calculer", MsgBoxStyle.Exclamation, "Gestion Association/calcul")
                ErrorProvider1.SetError(Txtmontantreussi, "Veuillez saisir le montant reussi avant de calculer")
            ElseIf Txtmontantreussi.Text = "Entré le montant" Then
                MsgBox("Veuillez saisir le montant reussi avant de calculer", MsgBoxStyle.Exclamation, "Gestion Association/calcul")
                ErrorProvider1.SetError(Txtmontantreussi, "Veuillez saisir le montant reussi avant de calculer")
            Else
                Txtcaisse.Text = Txtmontantreussi.Text * 45 / 100
                Txtahtk.Text = Txtmontantreussi.Text * 20 / 100
                Txturbain.Text = Txtmontantreussi.Text * 35 / 100
            End If

        Catch ex As Exception
            MsgBox("Veuillez saisir les chiffres pas des lettres", MsgBoxStyle.RetryCancel, "Gestion Association/calcul")
            Txtmontantreussi.Text = ""
            Txtmontantreussi.Focus()
        End Try
    End Sub

    Private Sub CALCULATRICE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()

    End Sub

    Private Sub Cmd1_Click(sender As Object, e As EventArgs) Handles Cmd1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text += "1"
        End If
    End Sub

    Private Sub Cmd2_Click(sender As Object, e As EventArgs) Handles Cmd2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text += "2"
        End If
    End Sub

    Private Sub Cmd3_Click(sender As Object, e As EventArgs) Handles Cmd3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text += "3"
        End If
    End Sub

    Private Sub Cmd4_Click(sender As Object, e As EventArgs) Handles Cmd4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text += "4"
        End If

    End Sub

    Private Sub Cmd5_Click(sender As Object, e As EventArgs) Handles Cmd5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text += "5"
        End If

    End Sub

    Private Sub Cmd6_Click(sender As Object, e As EventArgs) Handles Cmd6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text += "6"
        End If

    End Sub

    Private Sub Cmd7_Click(sender As Object, e As EventArgs) Handles Cmd7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text += "7"
        End If

    End Sub

    Private Sub Cmd8_Click(sender As Object, e As EventArgs) Handles Cmd8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text += "8"
        End If

    End Sub

    Private Sub Cmd9_Click(sender As Object, e As EventArgs) Handles Cmd9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text += "9"
        End If

    End Sub

    Private Sub Cmd0_Click(sender As Object, e As EventArgs) Handles Cmd0.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            fistnum = TextBox1.Text
            TextBox1.Text = ""
            operator_selector = True
            operation = 1
        Catch ex As Exception
            MsgBox("Saisie d'abord le nombre avant d'additionné", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        fistnum = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        operation = 2
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        fistnum = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        operation = 3
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        fistnum = TextBox1.Text
        TextBox1.Text = ""
        operator_selector = True
        operation = 4
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If operator_selector = True Then
            secondnum = TextBox1.Text
            If operation = 1 Then
                TextBox1.Text = fistnum + secondnum
            ElseIf operation = 2 Then
                TextBox1.Text = fistnum - secondnum
            ElseIf operation = 3 Then
                TextBox1.Text = fistnum * secondnum
            Else
                If secondnum = 0 Then
                    TextBox1.Text = "Error"
                Else
                    TextBox1.Text = fistnum / secondnum
                End If
            End If
            operator_selector = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Tauxdujour1.Text = "" Then
                MsgBox("Veuillez saisir le taux du jour!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                Tauxdujour1.Focus()
                ErrorProvider1.SetError(Tauxdujour1, "Veuillez saisir le taux du jour!")

            ElseIf Tauxdujour1.Text = "Entré le taux" Then
                MsgBox("Veuillez saisir le taux du jour!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                Tauxdujour1.Focus()
                ErrorProvider1.SetError(Tauxdujour1, "Veuillez saisir le taux du jour!")

            ElseIf mntfrancs1.Text = "" Then
                MsgBox("Veuillez saisir le montant que vous voulez convertir!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                mntfrancs1.Focus()
                ErrorProvider1.SetError(mntfrancs1, "Veuillez saisir le montant que vous voulez convertir!")

            ElseIf mntfrancs1.Text = "Entré le montant" Then
                MsgBox("Veuillez saisir le montant que vous voulez convertir!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                mntfrancs1.Focus()
                ErrorProvider1.SetError(mntfrancs1, "Veuillez saisir le montant que vous voulez convertir!")

            Else
                mntdollars.Text = mntfrancs1.Text * 100 / Tauxdujour1.Text
            End If

        Catch ex As Exception
            MsgBox("Veuillez saisir les chiffres pas des lettres", MsgBoxStyle.RetryCancel, "Gestion Association/calcul")
            mntfrancs1.Text = ""
            mntfrancs1.Focus()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tauxdujour1.Text = ""
        mntfrancs1.Text = ""
        mntdollars.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            If Tauxdujour2.Text = "" Then
                MsgBox("Veuillez saisir le taux du jour!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                Tauxdujour2.Focus()
                ErrorProvider1.SetError(Tauxdujour2, "Veuillez saisir le taux du jour!")

            ElseIf Tauxdujour2.Text = "Entré le taux" Then
                MsgBox("Veuillez saisir le taux du jour!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                Tauxdujour2.Focus()
                ErrorProvider1.SetError(Tauxdujour2, "Veuillez saisir le taux du jour!")

            ElseIf mntdollars2.Text = "" Then
                MsgBox("Veuillez saisir le montant que vous voulez convertir!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                mntfrancs2.Focus()
                ErrorProvider1.SetError(mntdollars2, "Veuillez saisir le montant que vous voulez convertir!")

            ElseIf mntdollars2.Text = "Entré le montant" Then
                MsgBox("Veuillez saisir le taux du jour!", MsgBoxStyle.Exclamation, "Gestion association/echange devise")
                mntdollars2.Focus()
                ErrorProvider1.SetError(mntdollars2, "Veuillez saisir le taux du jour!")

            Else
                mntfrancs2.Text = mntdollars2.Text * Tauxdujour2.Text / 100
            End If

        Catch ex As Exception
            MsgBox("Veuillez saisir les chiffres pas des lettres", MsgBoxStyle.RetryCancel, "Gestion Association/calcul")
            Tauxdujour2.Text = ""
            Tauxdujour2.Focus()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tauxdujour2.Text = ""
        mntfrancs2.Text = ""
        mntdollars2.Text = ""
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

    Private Sub Txtmontantreussi_Enter(sender As Object, e As EventArgs) Handles Txtmontantreussi.Enter
        If Txtmontantreussi.Text = "Entré le montant" Then
            Txtmontantreussi.Text = ""
            Txtmontantreussi.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txtmontantreussi_Leave(sender As Object, e As EventArgs) Handles Txtmontantreussi.Leave
        If Txtmontantreussi.Text = "" Then
            Txtmontantreussi.Text = "Entré le montant"
            Txtmontantreussi.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Tauxdujour1_Enter(sender As Object, e As EventArgs) Handles Tauxdujour1.Enter
        If Tauxdujour1.Text = "Entré le taux" Then
            Tauxdujour1.Text = ""
            Tauxdujour1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Tauxdujour1_Leave(sender As Object, e As EventArgs) Handles Tauxdujour1.Leave
        If Tauxdujour1.Text = "" Then
            Tauxdujour1.Text = "Entré le taux"
            Tauxdujour1.ForeColor = Color.Silver
        End If

    End Sub

    Private Sub mntfrancs1_Enter(sender As Object, e As EventArgs) Handles mntfrancs1.Enter
        If mntfrancs1.Text = "Entré le montant" Then
            mntfrancs1.Text = ""
            mntfrancs1.ForeColor = Color.Black
        End If

    End Sub

    Private Sub mntfrancs1_Leave(sender As Object, e As EventArgs) Handles mntfrancs1.Leave
        If mntfrancs1.Text = "" Then
            mntfrancs1.Text = "Entré le montant"
            mntfrancs1.ForeColor = Color.Silver
        End If


    End Sub

    Private Sub Tauxdujour2_Enter(sender As Object, e As EventArgs) Handles Tauxdujour2.Enter
        If Tauxdujour2.Text = "Entré le taux" Then
            Tauxdujour2.Text = ""
            Tauxdujour2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Tauxdujour2_Leave(sender As Object, e As EventArgs) Handles Tauxdujour2.Leave
        If Tauxdujour2.Text = "" Then
            Tauxdujour2.Text = "Entré le taux"
            Tauxdujour2.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub mntdollars2_Enter(sender As Object, e As EventArgs) Handles mntdollars2.Enter
        If mntdollars2.Text = "Entré le montant" Then
            mntdollars2.Text = ""
            mntdollars2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub mntdollars2_Leave(sender As Object, e As EventArgs) Handles mntdollars2.Leave
        If mntdollars2.Text = "" Then
            mntdollars2.Text = "Entré le montant"
            mntdollars2.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Txtahtk.Text = ""
        Txtmontantreussi.Text = ""
        Txtcaisse.Text = ""
        Txturbain.Text = ""
    End Sub
End Class