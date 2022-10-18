Imports System.Diagnostics
Imports vini_DB
Imports System.Threading

Public Class vini_serviceWoo

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.ServiceName = "vini_serviceWoo"
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

        Trace.WriteLine("Starting...")
        Trace.WriteLine("FTP = (" & My.Settings.wooFTPHost & ":" & My.Settings.wooFTPUser & "," & My.Settings.wooFTPPwd & ")")
        Trace.WriteLine("dossier = (Local = [" & My.Settings.wooFTPRepLocal & "] ,Distant = [" & My.Settings.wooFTPUser & "," & My.Settings.wooFTPRepDistant & "])")
        Trace.WriteLine("Intervalle = " & My.Settings.wooIntervalleSecondes & " Secondes")
        Trace.WriteLine("Log = " & My.Settings.wooLog)

        Dim tcb As TimerCallback = AddressOf ImporterCommandes
        Timer1 = New Timer(tcb, Nothing, 1, My.Settings.wooIntervalleSecondes * 1000)
        LogImportWoo.Fichier = My.Settings.wooLog
        Trace.WriteLine("Started...")


    End Sub

    Protected Overrides Sub OnStop()
        ' Ajoutez ici le code pour effectuer les destructions nécessaires à l'arrêt de votre service.
        Trace.WriteLine("Stopping...")
        '...
        Trace.WriteLine("Stopped...")
    End Sub

    Private Sub ImporterCommandes()
        Try
            Dim pDossierLocal As String
            pDossierLocal = My.Settings.wooFTPRepLocal & Now.ToString("yyyyMMddHHmmss")
            Trace.WriteLine("Importercommande RepLocal = [" & pDossierLocal & "]")
            cmdwoo.SetFTP(My.Settings.wooFTPHost, My.Settings.wooFTPUser, My.Settings.wooFTPPwd, My.Settings.wooFTPRepDistant)

            cmdwoo.Import(pDossierLocal)

        Catch ex As Exception
            Trace.WriteLine(ex.Message)
        End Try

    End Sub

End Class
