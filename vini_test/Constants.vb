Imports System.Configuration
Imports vini_DB

Public Module VNC_Constants

    Public CONSTANTES_LOADED As Boolean = False
    Public Const SCROLLBARWIDTH As Short = 90
    Public Const ERR_APP As String = "ViniGestCom"
    Public Const ERR_DEBUG As Integer = 1
    Public Const DATE_DEFAUT As Date = #1/1/2000#
    Public TYPE_APP As Short = 0 ' 0 = Application Courtier (Vinicom) , 1 = Application Grossiste (Hobivin)
    Public GLOBALCONNECTION As String = "False"
    Public bTRACE As Boolean = False
    'Public DBDATASOURCE As String = String.Empty
    'Public DBPROVIDER As String = String.Empty


    Public FAX_STK_BSENDCOVERPAGE As Boolean
    Public FAX_STK_SUBJECT As String
    Public FAX_STK_PATH As String
    Public FAX_STK_NOTES As String

    Public FAX_PRECOMMANDE_BSENDCOVERPAGE As Boolean
    Public FAX_PRECOMMANDE_SUBJECT As String
    Public FAX_PRECOMMANDE_PATH As String
    Public FAX_PRECOMMANDE_NOTES As String

    Public FAX_DETAILCOMMANDE_PATH As String
    Public FAX_DETAILCOMMANDE_SUBJECT As String
    Public FAX_DETAILCOMMANDE_BSENDCOVERPAGE As Boolean
    Public FAX_DETAILCOMMANDE_NOTES As String

    Public FAX_BL_PATH As String
    Public FAX_BL_SUBJECT As String
    Public FAX_BL_BSENDCOVERPAGE As Boolean
    Public FAX_BL_NOTES As String

    Public FAX_SCMD_PATH As String
    Public FAX_SCMD_SUBJECT As String
    Public FAX_SCMD_BSENDCOVERPAGE As Boolean
    Public FAX_SCMD_NOTES As String

    Public FAX_BA_PATH As String
    Public FAX_BA_SUBJECT As String
    Public FAX_BA_BSENDCOVERPAGE As Boolean
    Public FAX_BA_NOTES As String

    Public FAX_BLBA_PATH As String
    Public FAX_BLBA_SUBJECT As String
    Public FAX_BLBA_BSENDCOVERPAGE As Boolean
    Public FAX_BLBA_NOTES As String

    Public FAX_JAL_PATH As String
    Public FAX_JAL_SUBJECT As String
    Public FAX_JAL_BSENDCOVERPAGE As Boolean
    Public FAX_JAL_NOTES As String

    Public FAX_JAA_PATH As String
    Public FAX_JAA_SUBJECT As String
    Public FAX_JAA_BSENDCOVERPAGE As Boolean
    Public FAX_JAA_NOTES As String

    Public PATHTOREPORTS As String

    Public FAX_NOM_INTERLOCUTEUR As String
    Public FAX_TEL_INTERLOCUTEUR As String

    Public Const COMMANDECLIENT_LISTEPRODUIT_PRECOMMANDE As Boolean = True ' la liste des produits lors de la saisie de commande    True => Precommande False=> Tous les produits
    Public GESTSCMD_STANDARDCOLOR As System.Drawing.Color = System.Drawing.Color.Empty
    Public GESTSCMD_EXTRACOLOR As System.Drawing.Color = System.Drawing.Color.Gray

    Public IMPORT_IDSCMD As Integer
    Public IMPORT_REFFACTFOURN As Integer
    Public IMPORT_DATEFACTFOURN As Integer
    Public IMPORT_TOTALHTFACTURE As Integer
    Public IMPORT_TOTALTTCFACTURE As Integer
    Public IMPORT_DIRECTORY As String
    Public EXPORTFTP_FILENAME As String
    Public IMPORTFTP_FILENAME As String

    Public Sub initConstantes()
        Try
            Try
                TYPE_APP = ConfigurationManager.AppSettings.GetValues("TYPE_APP")(0)
            Catch ex As Exception
                TYPE_APP = 0
            End Try

            PATHTOREPORTS = My.MySettings.Default.PathToReport
            'DBPROVIDER = My.MySettings.Default.dbProvider
            'DBDATASOURCE = My.MySettings.Default.dbDataSource
            '            Persist.ConnectionString = "Provider = " & DBPROVIDER & ";Data Source= " & Chr(34) & DBDATASOURCE & Chr(34)
            Persist.ConnectionString = My.Settings.ConnectionString
            Persist.setReportCnx(My.Settings.ReportCnxUser, My.Settings.ReportCnxPassword)
            Try
                GLOBALCONNECTION = My.MySettings.Default.dbGlobalConnection
            Catch
                GLOBALCONNECTION = "False"
            End Try

            bTRACE = My.MySettings.Default.bTrace

            IMPORT_IDSCMD = ConfigurationManager.AppSettings.GetValues("IMPORT_IDSCMD")(0)
            IMPORT_REFFACTFOURN = ConfigurationManager.AppSettings.GetValues("IMPORT_REFFACTFOURN")(0)
            IMPORT_DATEFACTFOURN = ConfigurationManager.AppSettings.GetValues("IMPORT_DATEFACTFOURN")(0)
            IMPORT_TOTALHTFACTURE = ConfigurationManager.AppSettings.GetValues("IMPORT_TOTALHTFACTURE")(0)
            IMPORT_TOTALTTCFACTURE = ConfigurationManager.AppSettings.GetValues("IMPORT_TOTALTTCFACTURE")(0)
            IMPORT_DIRECTORY = ConfigurationManager.AppSettings.GetValues("IMPORT_DIRECTORY")(0)
            EXPORTFTP_FILENAME = ConfigurationManager.AppSettings.GetValues("EXPORTFTP_FILENAME")(0)
            IMPORTFTP_FILENAME = ConfigurationManager.AppSettings.GetValues("IMPORTFTP_FILENAME")(0)
        Catch ex As Exception

        End Try
        CONSTANTES_LOADED = True
    End Sub






End Module
