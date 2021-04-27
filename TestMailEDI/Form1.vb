Imports MailKit.Net.Smtp
Imports MimeKit

Public Class Form1
    Private Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMail.Click


        Dim oMailMessage = New MimeMessage()
        oMailMessage.From.Add(New MailboxAddress(tbUser.Text, tbUser.Text))
        oMailMessage.To.Add(New MailboxAddress("marccollin3@gmail.com", "marccollin3@gmail.com"))
        oMailMessage.Subject = "TEST"
        Try
            Me.Cursor = Cursors.WaitCursor
            Using oMailClient As New SmtpClient()
                oMailClient.Connect("Mail.vinicom.fr", 465, True)
                oMailClient.Authenticate(tbUser.Text, tbPassword.Text)
                oMailClient.Send(oMailMessage)
                oMailClient.Disconnect(True)
            End Using
            MessageBox.Show("Message envoyé")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If ex.InnerException IsNot Nothing Then
                MessageBox.Show(ex.InnerException.Message)
            End If
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
