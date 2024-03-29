
Option Explicit On
Imports System.Collections.Generic
Imports CrystalDecisions.CrystalReports.Engine
'===================================================================================================================================
'Projet : Vinicom
'Auteur : Marc Collin 
'Cr�ation : 23/06/04
'===================================================================================================================================
' Classe : Fournisseur
' Description : Contient les informations du fournisseur
'===================================================================================================================================
'Membres de Classes
'==================
'Public
'   getListe    : Rend la Liste des Fournisseurs
'Protected
'Private
'Membres d'instances
'==================
'Public
'   idRegion : Identifiant de la r�gion Vinicole
'   libRegion : (ReadOnly) Libell� de la r�gion Vinicole
'   load(id) : Chargement de l'objet en base
'               Rend True si le chargement est OK
'   insert(id) : insertio de l'objet en base
'               Rend True si l'insertion  est OK
'   update(id) : MAJ de l'objet en base
'               Rend True si la MAJ est OK
'   delete(id) : Suppression de l'objet en base
'               Rend True si le DELETE est OK
'Protected
'Private
'===================================================================================================================================
'Historique :
'============
'
'===================================================================================================================================
Public Class Fournisseur
    Inherits Tiers
    Private m_idRegion As Integer
    Private m_libRegion As String
    Private m_bExportInternet As Integer
    Private m_bIntermediaire As Boolean
    Private m_dossier As String
    Private m_nEspFrn As Boolean
    Public Property EspFrn() As Boolean
        Get
            Return m_nEspFrn
        End Get
        Set(ByVal value As Boolean)
            m_nEspFrn = value
        End Set
    End Property
    Private _bArchive As Boolean
    Public Property bArchive() As Boolean
        Get
            Return _bArchive
        End Get
        Set(ByVal value As Boolean)
            If value <> bArchive Then
                _bArchive = value
                RaiseUpdated()
            End If
        End Set
    End Property
    '=======================================================================
    '                           METHODE DE CLASSE                          |  
    'Fonction : getListe 
    'Description : Liste des Fournisseurs
    'Retour : Rend une collection de fournisseurs
    '=======================================================================
    Public Shared Function getListe(Optional ByVal strCode As String = "", Optional ByVal strNom As String = "", Optional ByVal strRs As String = "", Optional pbTous As Boolean = False) As List(Of Fournisseur)
        Dim colReturn As List(Of Fournisseur)
        shared_connect()
        colReturn = ListeFRN(strCode, strNom, strRs, pbTous)
        shared_disconnect()
        Return colReturn
    End Function
    'Identifiant de la r�gion
    Public Property idRegion() As Integer
        Get
            Return m_idRegion
        End Get
        Set(ByVal Value As Integer)
            RaiseUpdated()
            m_idRegion = Value
        End Set
    End Property
    'Libell� de la r�gion vinicole
    Public Property libregion() As String
        Get
            Return m_libRegion
        End Get
        Set(ByVal Value As String)
            m_libRegion = Value
        End Set

    End Property
    Public Property bIntermdiaire As Boolean
        Get
            Return m_bIntermediaire
        End Get
        Set(ByVal value As Boolean)
            m_bIntermediaire = value
            If m_bIntermediaire Then
                Dossier = ""
            End If
        End Set
    End Property
    Public Property Dossier() As String
        Get
            Return m_dossier
        End Get
        Set(ByVal value As String)
            m_dossier = value
        End Set
    End Property

    'Export des bons  � facture sur internet
    Public Property bExportInternet() As Integer
        Get
            Return m_bExportInternet
        End Get
        Set(ByVal Value As Integer)
            RaiseUpdated()
            m_bExportInternet = Value
        End Set

    End Property
    Public Shared Function createandload(ByVal pid As Integer) As Fournisseur
        '=======================================================================
        ' Contructeur pour chargement
        '=======================================================================
        Dim objFourn As Fournisseur
        Dim bReturn As Boolean
        objFourn = New Fournisseur
        Try
            If pid <> 0 Then
                bReturn = objFourn.load(pid)
                If Not bReturn Then
                    setError("Fournisseur.createAndLoad", getErreur())
                End If

            End If
        Catch ex As Exception
            setError("Fournisseur.createAndLoad", ex.ToString)
        End Try
        Debug.Assert(objFourn.id = pid, "Fournisseur " & pid & " non charg�e")
        Return objFourn
    End Function 'Createanload
    ''' <summary>
    ''' Constructeur pour Chargement par la cl�
    ''' </summary>
    ''' <param name="pCode"> Code Fournisseur</param>
    ''' <returns>Objet Fournisseur ou null</returns>
    ''' <remarks></remarks>
    Public Shared Function createandload(ByVal pCode As String) As Fournisseur
        Dim objFourn As Fournisseur
        Dim bReturn As Boolean
        Dim nId As Integer
        objFourn = New Fournisseur
        Try
            If Not String.IsNullOrEmpty(pCode) Then
                nId = Fournisseur.getFRNIDByKey(pCode)
                If nId <> -1 Then
                    bReturn = objFourn.load(nId)
                    If Not bReturn Then
                        setError("Fournisseur.createAndLoad", getErreur())
                        objFourn = Nothing
                    End If
                Else
                    setError("Fournisseur.createAndLoad", "No ID for " & pCode)
                    objFourn = Nothing
                End If
            End If
        Catch ex As Exception
            setError("Fournisseur.createAndLoad", ex.ToString)
            objFourn = Nothing
        End Try
        Return objFourn
    End Function 'Createanload

    '=======================================================================
    'Fonction : Load
    'Description : Chargement de l'objet en base
    'D�tails    : Appelle LoadFRN (de Persist) 
    'Retour : Rend Vrai si le chargement s'est correctement effectu�
    '=======================================================================
    Protected Overrides Function DBLoad(Optional ByVal pid As Integer = 0) As Boolean
        Dim bReturn As Boolean
        shared_connect()
        If pid <> 0 Then
            m_id = pid
        End If
        bReturn = loadFRN()
        shared_disconnect()
        'Mise � jour des indicateurs
        If bReturn Then
            m_bNew = False
            setUpdatedFalse()
            m_bDeleted = False
        End If
        Return bReturn
    End Function
    '=======================================================================
    'Fonction : LoadLight
    'Description : Chargement de l'objet en base
    'D�tails    : Appelle LoadFRN (de Persist) 
    'Retour : Rend Vrai si le chargement s'est correctement effectu�
    '=======================================================================
    Friend Overrides Function LoadLight() As Boolean
        Debug.Assert(m_id <> 0, "L'id doit �tre initialis�")

        Dim bReturn As Boolean
        shared_connect()
        bReturn = loadFRNLight()
        shared_disconnect()
        'Mise � jour des indicateurs
        If bReturn Then
            m_bNew = False
            setUpdatedFalse()
            m_bDeleted = False
        End If
        Return bReturn
    End Function
    '=======================================================================
    'Fonction : delete
    'Description : suppression de l'objet en base
    'D�tails    : Appelle deleteFRN (de Persist) 
    'Retour : Rend Vrai si le DELETE s'est correctement effectu�
    '=======================================================================
    Friend Overrides Function delete() As Boolean
        Dim bReturn As Boolean
        shared_connect()
        TauxComm.deleteTauxComms(m_id)
        bReturn = deleteFRN()
        shared_disconnect()
        Return bReturn
    End Function
    '=======================================================================
    'Fonction : checkFordelete
    'description : Controle si l'�l�ment est supprimable
    '                table commandesClients
    '=======================================================================
    Public Overrides Function checkForDelete() As Boolean
        Dim bReturn As Boolean
        Try
            '    shared_connect()
            bReturn = True
            If existeProduitFournisseur() Then
                bReturn = False
            End If
            If bReturn And existeBonApproFournisseur() Then
                bReturn = False
            End If
            '   shared_disconnect()
        Catch ex As Exception
            bReturn = False
        End Try
        Return bReturn
    End Function 'checkForDelete
    '=======================================================================
    'Fonction : Insert
    'Description : Insert de l'objet en base
    'D�tails    : Appelle InsertFRN (de Persist) 
    'Retour : Rend Vrai si l'INSERT s'est correctement effectu�
    '=======================================================================
    Friend Overrides Function insert() As Boolean
        Dim bReturn As Boolean
        '    shared_connect()
        bReturn = insertFRN()
        '   shared_disconnect()
        Return bReturn
    End Function
    '=======================================================================
    'Fonction : update
    'Description : Update de l'objet en base
    'D�tails    : Appelle UpdateFRN (de Persist) 
    'Retour : Rend Vrai si l'UPDATE s'est correctement effectu�
    '=======================================================================
    Friend Overrides Function update() As Boolean
        Dim bReturn As Boolean
        '  shared_connect()
        bReturn = updateFRN()
        ' shared_disconnect()
        Return bReturn
    End Function

    '=======================================================================
    'Fonction : Equals
    'Description : Comparaison d'objet
    'D�tails    : Compare chaque membre de l'objet 
    'Retour : Rend Vrai si l'objet pass� en param�tre est �quivalent
    '=======================================================================
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim objFrn As Fournisseur
        Dim bReturn As Boolean
        Try
            bReturn = True
            objFrn = CType(obj, Fournisseur)

            bReturn = MyBase.Equals(obj)
            bReturn = bReturn And (objFrn.idRegion.Equals(Me.idRegion))
            bReturn = bReturn And (objFrn.bExportInternet.Equals(Me.bExportInternet))
            bReturn = bReturn And (objFrn.bIntermdiaire.Equals(Me.bIntermdiaire))
            bReturn = bReturn And (objFrn.Dossier.Equals(Me.Dossier))

            Return bReturn
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    '=======================================================================
    'Fonction : new
    'Description : Cr�ation de l'objet
    'D�tails    : 
    'Retour : 
    '=======================================================================

    Public Sub New(ByVal pcode As String, ByVal pnom As String)
        MyBase.New(pcode, pnom)
        m_typedonnee = vncEnums.vncTypeDonnee.FOURNISSEUR
        m_idRegion = Param.regiondefaut.id
        m_libRegion = Param.regiondefaut.valeur
        m_bExportInternet = 1
        m_dossier = ""
        bArchive = False
    End Sub
    Public Sub New()
        MyBase.New("", "")
        m_typedonnee = vncEnums.vncTypeDonnee.FOURNISSEUR
        m_idRegion = Param.regiondefaut.id
        m_libRegion = Param.regiondefaut.valeur
        m_bExportInternet = 1
        bArchive = False
    End Sub

    '=======================================================================
    'Fonction : toString
    'Description : Rend L'objet sous forme de chaine
    'Retour : une Chaine
    '=======================================================================
    Public Overrides Function toString() As String
        Return "FRN : [" & MyBase.toString() & "]" & idRegion & "," & libregion
    End Function

    Public Sub FTO_createTxCommStandard(pTypeClient As String)
        Try

            Dim oTx As New TauxComm(Me.id, pTypeClient, Param.getConstante("CST_TX_COMMISSION"))
            oTx.save()
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Renvoie le Fournuisseur qui a �t� identifi� comme interm�diaire pour un Dossier
    ''' </summary>
    ''' <param name="pDossier">Dossier de reference</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getIntermediairePourUnDossier(pDossier As String) As Fournisseur
        Dim oReturn As Fournisseur = Nothing
        Try
            Dim idTypeClient As Integer
            For Each oParam As Param In Param.colTypeClient
                If oParam.code.ToUpper() = "INT" Then
                    idTypeClient = oParam.id
                End If
            Next

            Dim strSQL As String
            strSQL = "SELECT FRN_ID FROM Fournisseur where FRN_BINTERMEDIAIRE = 1 and FRN_DOSSIER = '" & pDossier & "'"
            Dim strResultat As String = Persist.executeSQLQuery(strSQL)

            If Not String.IsNullOrEmpty(strResultat) Then
                oReturn = Fournisseur.createandload(CInt(strResultat))
            End If

        Catch ex As Exception
            oReturn = Nothing
        End Try
        Return oReturn
    End Function

    Private Function genererReportMvtArticles(ByVal strPathtoReport As String, pDatefin As DateTime) As ReportDocument
        Dim bReturn As Boolean
        Dim oReport As ReportDocument = Nothing

        Try
            bReturn = True
            oReport = New ReportDocument
            oReport.Load(strPathtoReport & "crMouvementArticle.rpt")
            Persist.setReportConnection(oReport)
            oReport.Refresh()
            oReport.SetParameterValue("codeFourn", Me.code)
            oReport.SetParameterValue("dFin", pDatefin.ToShortDateString())
            Persist.setReportConnection(oReport)

        Catch ex As Exception
            bReturn = False
            oReport = Nothing
            setError("Fournisseur.genererReportmvtArticles", ex.ToString())
        End Try
        Return oReport
    End Function 'genererReportMvtArticles
    Public Function genererPDF(ByVal strPathToReport As String, ByVal strPDFFileName As String, pDateFin As DateTime) As Boolean
        Debug.Assert(Trim(strPathToReport) <> "", "PathToReport non initialis�")
        Debug.Assert(Trim(strPDFFileName) <> "", "strPDFFileName non initialis�")
        Dim bReturn As Boolean
        Dim diskOpts As New CrystalDecisions.Shared.DiskFileDestinationOptions
        Try
            Using oReport As ReportDocument = genererReportMvtArticles(strPathToReport, pDateFin)
                If Not oReport Is Nothing Then
                    oReport.ExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                    oReport.ExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                    diskOpts.DiskFileName = strPDFFileName
                    oReport.ExportOptions.DestinationOptions = diskOpts
                    oReport.Export()
                    oReport.Close()
                    bReturn = True
                Else
                    bReturn = False
                End If

            End Using
        Catch ex As Exception
            setError("Fournisseur.genererPDF", ex.ToString)
            bReturn = False
        End Try
        Return bReturn
    End Function 'genererPDF

End Class
