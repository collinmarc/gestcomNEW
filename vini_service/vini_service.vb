Imports System.Diagnostics
Imports vini_DB
Imports System.Threading

Public Class vini_service

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.ServiceName = "vini_service"
        Me.CanShutdown = True
        Me.CanStop = True
    End Sub
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Ajoutez ici le code pour démarrer votre service. Cette méthode doit
        ' démarrer votre service.
        If Not EventLog.SourceExists(Me.ServiceName) Then
            EventLog.CreateEventSource(Me.ServiceName, Me.ServiceName)
        End If
        Trace.Listeners.Clear()
        Trace.Listeners.Add(New EventLogTraceListener(Me.ServiceName))

        Persist.ConnectionString = My.Settings.MyCS
        If Persist.shared_connect() Then
            Dim ImapHost As String = Param.getConstante("CST_IMAP_HOST")
            Dim ImapPort As String = Param.getConstante("CST_IMAP_PORT")
            Dim ImapUser As String = Param.getConstante("CST_IMAP_USER")
            Dim ImapPwd As String = Param.getConstante("CST_IMAP_PWD")
            Dim ImapFolder As String = Param.getConstante("CST_IMAP_MSGFOLDER")
            Dim ImapNsec As Integer = CInt(Param.getConstante("CST_IMAP_NSEC"))

            Trace.WriteLine("Starting...")
            Trace.WriteLine("Imap = (" & ImapHost & ":" & ImapPort & "," & ImapUser & "," & ImapPwd & ")")
            Trace.WriteLine("dossier imap des messages traités = " & ImapFolder)
            Trace.WriteLine("Intervalle = " & ImapNsec & " Secondes")
            'Arement d'un timer qui démarera dans 1 secondes
            Dim tcb As TimerCallback = AddressOf ImporterCommandes
            Timer1 = New Timer(tcb, Nothing, 1, ImapNsec * 1000)
            Trace.WriteLine("Started...")

        End If


    End Sub

    Protected Overrides Sub OnStop()
        ' Ajoutez ici le code pour effectuer les destructions nécessaires à l'arrêt de votre service.
        Trace.WriteLine("Stopping...")
        '...
        Trace.WriteLine("Stopped...")
    End Sub

    Private Sub ImporterCommandes()
        Try
            Dim olst As List(Of CommandeClient)
            Persist.ConnectionString = My.Settings.MyCS
            If Persist.shared_connect() Then
                Dim ImapHost As String = Param.getConstante("CST_IMAP_HOST")
                Dim ImapPort As String = Param.getConstante("CST_IMAP_PORT")
                Dim ImapUser As String = Param.getConstante("CST_IMAP_USER")
                Dim ImapPwd As String = Param.getConstante("CST_IMAP_PWD")
                Dim ImapFolder As String = Param.getConstante("CST_IMAP_MSGFOLDER")
                Dim oImport As New ImportPrestashop(ImapHost, ImapUser, ImapPwd, ImapPort, True)
                oImport.MSGFolderName = ImapFolder
                olst = oImport.Import(True)
                If olst.Count > 0 Then
                    Trace.WriteLine("" & olst.Count.ToString() & " commandes importées")
                End If
            Else
                Trace.WriteLine("Erreur en Connection à la base de données" & Persist.ConnectionString)
            End If

        Catch ex As Exception
            Trace.WriteLine(ex.Message)
        End Try

    End Sub

End Class
