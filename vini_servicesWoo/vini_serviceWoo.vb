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
        Trace.WriteLine("FTP = (" & My.Settings.wooFTPHost & ":" & My.Settings.wooFTPUser & "," & My.Settings.wooFTPPwd & ")/" & My.Settings.wooFTPRepDistant)
        Trace.WriteLine("RepLocal = " & My.Settings.wooFTPRepLocal)
        Trace.WriteLine("FTP2 = (" & My.Settings.wooFTPHost2 & ":" & My.Settings.wooFTPUser2 & "," & My.Settings.wooFTPPwd2 & ")/" & My.Settings.wooFTPRepDistant2)
        Trace.WriteLine("RepLocal2 = " & My.Settings.wooFTPRepLocal2)
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

            cmdwoo.SetFTP(My.Settings.wooFTPHost, My.Settings.wooFTPUser, My.Settings.wooFTPPwd, My.Settings.wooFTPRepDistant)
            cmdwoo.dossiercmdtraitees = My.Settings.wooFTPComdTraitees
            Trace.WriteLine("Import1 vers " & pDossierLocal)

            cmdwoo.Import(pDossierLocal)

            If Not String.IsNullOrEmpty(My.Settings.wooFTPHost2) Then
                cmdwoo.SetFTP(My.Settings.wooFTPHost2, My.Settings.wooFTPUser2, My.Settings.wooFTPPwd2, My.Settings.wooFTPRepDistant2)
                cmdwoo.dossiercmdtraitees = My.Settings.wooFTPComdTraitees2
                pDossierLocal = My.Settings.wooFTPRepLocal2 & Now.ToString("yyyyMMddHHmmss")

                Trace.WriteLine("Import2 vers " & pDossierLocal)
                cmdwoo.Import(pDossierLocal)
            End If

        Catch ex As Exception
            Trace.WriteLine(ex.Message)
        End Try

    End Sub

End Class
