Imports System.Net.Mail

Public Class AIDE

    Private Sub AIDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'demarer le timer 
        Timer1.Start()
        txtemailenvoi.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Red
            Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA"
            Label6.BackColor = Color.Red
        ElseIf Lblmessage.Text = "L'ASSOCIATION DES HANDICAPEES TRANSITAIRES DE KASUMBALESA" Then
            Lblmessage.ForeColor = Color.Black
            Lblmessage.Text = "LUTTE CONTRE LA MENDICITE DES HANDICAPEES DE KASUMBALESA"
            Label6.BackColor = Color.Lime
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RichTextBox2.Visible = False
        TxtAdmin.Visible = False
        Txtcalcul.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = False
        RichTextBox1.Visible = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        RichTextBox1.Visible = False
        TxtAdmin.Visible = False
        Txtcalcul.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = False
        RichTextBox2.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        Button1.Enabled = False
        Txtmessage.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim mail As New MailMessage
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            If txtemailenvoi.Text = "" Then
                ErrorProvider1.SetError(txtemailenvoi, "Saisi d'abord votre Email")
                MsgBox("Desolé vous devez d'abord Saisir  votre Email", MsgBoxStyle.Exclamation, "Gestion Association/Email")
                Me.Close()
                Exit Sub
            End If
            If Txtmotdepasse.Text = "" Then
                ErrorProvider1.SetError(txtemailenvoi, "Saisi d'abord votre Email")
                MsgBox("Desolé vous devez d'abord Saisir  votre mot de passe", MsgBoxStyle.Exclamation, "Gestion Association/Email")
                Me.Close()
                Exit Sub
            End If

            mail.From = New MailAddress(txtemailenvoi.Text)
            mail.To.Add("mardocheekanyinda6@gmail.com")
            mail.Subject = txtobjet.Text
            mail.Body = Txtmessage.Text
            SMTP.Port = "587"
            SMTP.Credentials = New System.Net.NetworkCredential(txtemailenvoi.Text, Txtmotdepasse.Text)
            SMTP.EnableSsl = True
            SMTP.Send(mail)
            MsgBox("bravo votre message est envoyer avec succes", MsgBoxStyle.Exclamation, "Gestion Association/Email")
        Catch ex As Exception
            MsgBox("votre message ne pas envoyer faute de manque de connexion!", MsgBoxStyle.Exclamation, "Gestion Association/Email")

        End Try

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        TxtAdmin.Visible = False
        Txtcaisse.Visible = False
        Txtcalcul.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = False
        Txtcotisation.Visible = True
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        TxtAdmin.Visible = False
        Txtcalcul.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = True
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        TxtAdmin.Visible = False
        Txtcalcul.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = False
        Txtfiche.Visible = True
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        TxtAdmin.Visible = False
        Txtcalcul.Visible = False
        Txtrecit.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = True

    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        TxtAdmin.Visible = False
        Txtcalcul.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = True
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        TxtAdmin.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = False
        Txtcalcul.Visible = True

    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        Txtcotisation.Visible = False
        Txtcaisse.Visible = False
        Txtfiche.Visible = False
        Txtrapport.Visible = False
        Txtrecit.Visible = False
        Txtcalcul.Visible = False
        TxtAdmin.Visible = True
    End Sub
End Class