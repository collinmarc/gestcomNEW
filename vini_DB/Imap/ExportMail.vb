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
    ''' <summary>
    ''' Envoi d'un mail 
    ''' Si pModePrestashop = true, le Body est envoyé en mode TextBody, et un Message est envoyé en mode HTMLBody
    ''' </summary>
    ''' <param name="pHost"></param>
    ''' <param name="pPort"></param>
    ''' <param name="bSSL"></param>
    ''' <param name="puser"></param>
    ''' <param name="pPwd"></param>
    ''' <param name="pDestinataire"></param>
    ''' <param name="pSubject"></param>
    ''' <param name="pBody"></param>
    ''' <param name="pFileName"></param>
    ''' <param name="pModePrestashop"></param>
    ''' <returns></returns>
    Public Shared Function SendMail(pHost As String, pPort As Integer, bSSL As Boolean, puser As String, pPwd As String, pExpediteur As String, pDestinataire As String, pSubject As String, pBody As String, pFileName As String, Optional pModePrestashop As Boolean = False) As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = False
            Using oMailClient As New SmtpClient()
                oMailClient.Connect(pHost, pPort, bSSL)
                oMailClient.Authenticate(puser, pPwd)
                Dim oMailMessage As New MimeMessage()
                oMailMessage.From.Add(New MailboxAddress(pExpediteur, pExpediteur))
                oMailMessage.To.Add(New MailboxAddress(pDestinataire, pDestinataire))
                oMailMessage.Cc.Add(New MailboxAddress(pExpediteur, pExpediteur))
                oMailMessage.Subject = pSubject

                Dim builder As New BodyBuilder()
                If pModePrestashop Then
                    builder.TextBody = pBody
                    builder.HtmlBody = "le contenu de la commande est en mode texte"
                Else
                    builder.TextBody = pBody
                    builder.Attachments.Add(pFileName)
                End If
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
