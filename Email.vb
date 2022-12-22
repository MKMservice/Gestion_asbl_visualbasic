Imports System.Net.Mail

Public Class Email

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtemailenvoi.Text = "" Then
            ErrorProvider1.SetError(txtemailenvoi, "Saisi d'abord votre Email")
            If MsgBox("Desolé vous devez d'abord Saisir  votre Email", MsgBoxStyle.RetryCancel, "Gestion Association/Email") = MsgBoxResult.Retry Then
                GroupBox1.Enabled = True
                GroupBox2.Enabled = False
                Button1.Enabled = True
                txtemailenvoi.Focus()
                Exit Sub
            Else
                Exit Sub
            End If
        End If
        If Txtmotdepasse.Text = "" Then
            ErrorProvider1.SetError(Txtmotdepasse, "Saisi d'abord votre mot de passe")
            If MsgBox("Desolé vous devez d'abord Saisir  votre mot de passe", MsgBoxStyle.RetryCancel, "Gestion Association/Email") = MsgBoxResult.Retry Then
                GroupBox1.Enabled = True
                GroupBox2.Enabled = False
                Button1.Enabled = True
                Txtmotdepasse.Focus()
                Exit Sub
            End If

        End If

        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        Button1.Enabled = False
        Txtdestinataire.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim mail As New MailMessage
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            If Txtdestinataire.Text = "" Then
                ErrorProvider1.SetError(Txtdestinataire, "Saisi d'abord votre Email")
                If MsgBox("Desolé vous devez d'abord Saisir  votre Email", MsgBoxStyle.RetryCancel, "Gestion Association/Email") = MsgBoxResult.Retry Then
                    GroupBox1.Enabled = False
                    GroupBox2.Enabled = True
                    Button1.Enabled = False
                    Txtdestinataire.Focus()
                    Exit Sub
                Else
                    Exit Sub
                End If
            End If
            If txtobjet.Text = "" Then
                ErrorProvider1.SetError(txtobjet, "Saisi d'abord votre mot de passe")
                If MsgBox("Desolé vous devez d'abord Saisir  votre mot de passe", MsgBoxStyle.RetryCancel, "Gestion Association/Email") = MsgBoxResult.Retry Then
                    GroupBox1.Enabled = False
                    GroupBox2.Enabled = True
                    Button1.Enabled = False
                    txtobjet.Focus()
                    Exit Sub
                End If

            End If

            mail.From = New MailAddress(txtemailenvoi.Text)
            mail.To.Add(Txtdestinataire.Text)
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
End Class