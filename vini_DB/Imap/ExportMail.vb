Imports MailKit.Net.Smtp
Imports MimeKit

Public Class ExportMail
    Inherits racine

    Public Overrides ReadOnly Property shortResume As String
        Get
            Throw New NotImplementedException()
        End Get
    End Property
    Private Shared _Message As String = ""
    Public Shared Property Message() As String
        Get
            Return _Message
        End Get
        Set(ByVal value As String)
            _Message = value
        End Set
    End Property

    Public Shared Function SendMail(pHost As String, pPort As Integer, bSSL As Boolean, puser As String, pPwd As String, pDestinataire As String, pSubject As String, pBody As String, pFileName As String) As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = False
            Using oMailClient As New SmtpClient()
                oMailClient.Connect(pHost, pPort, bSSL)
                oMailClient.Authenticate(puser, pPwd)
                Dim oMailMessage As New MimeMessage()
                oMailMessage.From.Add(New MailboxAddress(puser, puser))
                oMailMessage.To.Add(New MailboxAddress(pDestinataire, pDestinataire))
                oMailMessage.Subject = pSubject
                Dim builder As New BodyBuilder()
                builder.TextBody = pBody


                builder.Attachments.Add(pFileName)
                oMailMessage.Body = builder.ToMessageBody()

                oMailClient.Send(oMailMessage)
                oMailClient.Disconnect(True)
                bReturn = True
            End Using
        Catch ex As Exception
            Message = ex.Message

            If ex.InnerException IsNot Nothing Then
                Message = Message + ", " + ex.InnerException.Message
            End If
            setError("ExportMail.SendMail ERR" + Message)
            bReturn = False
        Finally
        End Try

        Return bReturn
    End Function

    Public Overrides Function toString() As String
        Return "ExportMail"
    End Function
End Class
