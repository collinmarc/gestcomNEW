Imports System.Xml.Serialization
Imports System.Collections
Imports System.IO
Imports System.Collections.Generic
Imports System.Text
Imports System.Text.RegularExpressions
<Serializable()>
<XmlType(TypeName:="commande")>
Public Class cmdwoo

#Region "Shared Properties"

    Private Shared m_Hostname As String
    Private Shared m_Port As Integer
    Private Shared m_username As String
    Private Shared m_password As String
    Private Shared m_bSSL As Boolean
    Private Shared m_nSec As Integer
    Private Shared m_dossierCMDaTraiter As String

    Public Shared Property HostName As String
        Get
            Return m_Hostname
        End Get
        Set(value As String)
            m_Hostname = value
        End Set
    End Property
    Public Shared Property UserName As String
        Get
            Return m_username
        End Get
        Set(value As String)
            m_username = value
        End Set
    End Property
    Public Shared Property Password As String
        Get
            Return m_password
        End Get
        Set(value As String)
            m_password = value
        End Set
    End Property
    Public Shared Property dossierCMDatraiter As String
        Get
            Return m_dossierCMDaTraiter
        End Get
        Set(value As String)
            m_dossierCMDaTraiter = value
        End Set
    End Property
    Public Shared Property bSSL As Boolean
        Get
            Return m_bSSL
        End Get
        Set(value As Boolean)
            m_bSSL = value
        End Set
    End Property
    Public Shared Property Port As Integer
        Get
            Return m_Port
        End Get
        Set(value As Integer)
            m_Port = value
        End Set
    End Property
    Private Shared m_dossiercmdtraitees As String
    Public Shared Property dossiercmdtraitees() As String
        Get
            Return m_dossiercmdtraitees
        End Get
        Set(ByVal value As String)
            m_dossiercmdtraitees = value
        End Set
    End Property
    Private Shared m_ListeCommandes As List(Of CommandeClient)
    Public Shared Property ListeCommandes() As List(Of CommandeClient)
        Get
            Return m_ListeCommandes
        End Get
        Set(ByVal value As List(Of CommandeClient))
            m_ListeCommandes = value
        End Set
    End Property
#End Region


    Public entete As EnteteWOO
    Public client As clientWOO
    Public lignes_commande As List(Of ligneWOO)
    <XmlIgnore()>
    Public bImport As Boolean = False
    <XmlIgnore()>
    Public motif As String
    <XmlIgnore()>
    Public NumCommandeGestCom As String


    Public Sub New()
        entete = New EnteteWOO
        client = New clientWOO()
        lignes_commande = New List(Of ligneWOO)
        motif = ""
        bImport = False
    End Sub

    ''' <summary>
    ''' Lecture d'une chaine XML et retour d'une Commande
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function readXML(pFileName As String) As cmdwoo
        Dim oReturn As New cmdwoo
        '        Dim strXMl As String = pXmlString
        Try
            'Dim oCmd As New cmdprestashop
            'strXMl = strXMl.Replace("[/xml]", "")
            'strXMl = strXMl.Replace("=3D", "=")
            'strXMl = strXMl.Replace("[", "<")
            'strXMl = strXMl.Replace("]", ">")
            'strXMl = strXMl.Replace("#", "=")
            'strXMl = strXMl.Replace("&", ".")
            'strXMl = strXMl.Replace("=09", "")
            'strXMl = strXMl.Replace(vbCrLf, "")
            'strXMl = strXMl.Replace("standalone", " standalone")
            ''strXMl = strXMl.Replace(vbCr, "")
            ''            strXMl = strXMl.Replace(vbLf, "")

            Dim objStreamReader As New StreamReader(pFileName)
            Dim x As New XmlSerializer(GetType(cmdwoo))
            oReturn = x.Deserialize(objStreamReader)
            ''Suppression des Space dans les codes Produits
            'For Each oLg As ligneprestashop In oReturn.lignes
            '    oLg.reference = Trim(oLg.reference)
            '    oLg.reference.Replace(" ", "")
            'Next
            objStreamReader.Close()
        Catch ex As Exception
            setError("cmdwoo.readXML: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                setError("cmdwoo.readXML: " & ex.InnerException.Message)
            End If
        End Try
        Return oReturn
    End Function

    Public Shared Function FTO_writeXml(pCmd As cmdwoo, pFilename As String) As Boolean
        Dim bReturn As Boolean
        Dim objStreamWriter As StreamWriter = Nothing

        Try
            Dim ns As New XmlSerializerNamespaces()
            ns.Add("", "")

            objStreamWriter = New StreamWriter(pFilename)
            Dim x As New XmlSerializer(pCmd.GetType)
            x.Serialize(objStreamWriter, pCmd, ns)
            objStreamWriter.Close()
            bReturn = True
        Catch ex As Exception
            Debug.Print("cmdwoo.WriteXML: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                Debug.Print("cmdwoo.WriteXML: " & ex.InnerException.Message)
            End If
            bReturn = False
            If objStreamWriter IsNot Nothing Then
                objStreamWriter.Close()
            End If


        End Try
        Return bReturn
    End Function
    ''' <summary>
    ''' Vérification de la Commande importée
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function check() As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = True
            If String.IsNullOrEmpty(entete.id) Then
                motif = "idCommande non renseigné"
                bReturn = False
            End If
            If bReturn Then
                If Not String.IsNullOrEmpty(entete.customer_id) Then
                    Dim oClient As Client
                    oClient = vini_DB.Client.createandloadPrestashop(entete.customer_id, entete.origine)
                    If oClient Is Nothing Then
                        motif = "Client inconnu (" + entete.customer_id + "), dossier (" & entete.origine & ")"
                        bReturn = False
                    Else

                    End If
                End If
            End If
            If bReturn Then
                Dim oProduit As Produit
                For Each oLg As ligneWOO In lignes_commande
                    oProduit = Produit.getProduitParCodestat(oLg.reference)
                    If oProduit Is Nothing Then
                        motif = "Produit inconnu (" + oLg.reference + "), dossier (" & entete.origine & ")"
                        bReturn = False
                    End If
                Next
            End If
        Catch ex As Exception
            motif = ex.Message
            bReturn = False
        End Try
        Return bReturn
    End Function

    Public Sub AddLigne(pRef As String, pQte As Integer, pPrix As Decimal)
        lignes_commande.Add(New ligneWOO(pRef, pQte, pPrix))
    End Sub
    Public Shared Sub SetFTP(pHost As String, pUser As String, pPassword As String, Optional pDossierDistant As String = "", Optional pPort As Integer = 21)
        HostName = pHost
        UserName = pUser
        Password = pPassword
        Port = pPort
        dossierCMDatraiter = pDossierDistant
    End Sub

    Public Shared Sub LoadLogImportWoo()
        ChargementLogs()
    End Sub

    Private Shared Sub ChargementLogs()
        If File.Exists(LogImportWoo.Fichier) Then
            LogImportWoo.ListItems.ListItems.Clear()
            LogImportWoo.ReadXml()
        End If
    End Sub

    ''' <summary>
    ''' Mécanisme d'import de commande depuis la boite mail de réception Prestashop
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Import(Optional pDossierLocal As String = "", Optional pSuppressionFichierDistant As Boolean = True) As Boolean
        Debug.Assert(Not String.IsNullOrEmpty(HostName), "Les param FTP doivent être initialisés")

        Dim bReturn As Boolean
        ListeCommandes = New List(Of CommandeClient)
        Dim tabFiles As String()
        Try
            'Chargement du Log de l'import
            LoadLogImportWoo()

            Dim oFTP As New clsFTPVinicom(HostName, UserName, Password, dossierCMDatraiter)
            If String.IsNullOrEmpty(pDossierLocal) Then
                pDossierLocal = "./importinternet/vinicom.wine/" & Now.ToString("yyyyMMddHHmmss")
            End If
            If Not System.IO.Directory.Exists("importinternet") Then
                System.IO.Directory.CreateDirectory("importinternet")
            End If
            If Not System.IO.Directory.Exists(pDossierLocal) Then
                System.IO.Directory.CreateDirectory(pDossierLocal)
            End If
            '=================================
            ' Transfert du contenu du répertoire
            '==================================
            bReturn = oFTP.downloadDirToDir(pDossierLocal, True)

            '================================
            ' Création des Commandes Client
            '================================
            tabFiles = System.IO.Directory.GetFiles(pDossierLocal, "*.xml")
            If tabFiles.Length = 0 Then
                Directory.Delete(pDossierLocal)
            End If
            For Each strFile As String In tabFiles
                Dim oCMDW As cmdwoo
                Dim oFileInfo As New System.IO.FileInfo(strFile)
                oCMDW = cmdwoo.readXML(oFileInfo.FullName)
                Dim oCmdC As CommandeClient
                Dim strCodeCommande As String = ""
                oCmdC = oCMDW.createCommandeClient()
                If oCMDW.bImport Then
                    ListeCommandes.Add(oCmdC)
                    strCodeCommande = oCmdC.code
                End If
                LogImportWoo.AjoutLigne(Now().ToString("yyyy/MM/dd HH:mm:ss"),
                                       strFile,
                                       oCMDW.entete.num_cde_woocommerce,
                                       oCMDW.entete.datecmd,
                                       oCMDW.bImport,
                                       strCodeCommande,
                                       oCMDW.motif
                                       )
            Next



            LogImportWoo.writeXml()


        Catch ex As Exception
            setError("ImportCommande", ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function

    ''' <summary>
    ''' Création d'une commande Client à partir d'une commande Woo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function createCommandeClient() As CommandeClient
        Dim oReturn As CommandeClient
        oReturn = Nothing
        Try
            Dim oClient As vini_DB.Client
            Dim oProduit As Produit
            Dim nLigne As Integer
            oClient = vini_DB.Client.createandloadPrestashop(entete.customer_id, entete.origine)
            If oClient IsNot Nothing Then
                oReturn = New CommandeClient(oClient)
                oReturn.IDPrestashop = entete.num_cde_woocommerce
                oReturn.Origine = entete.origine
                oReturn.dateCommande = New DateTime(Left(entete.datecmd, 4), Mid(entete.datecmd, 5, 2), Right(entete.datecmd, 2))
                oReturn.caracteristiqueTiers.nom = oClient.nom
                oReturn.caracteristiqueTiers.rs = client.adresse_livraison.livraison_company
                oReturn.RaisonSocialeLivraison = client.adresse_livraison.livraison_company
                oReturn.NomLivraison = oClient.nom & " " & client.adresse_livraison.livraison_firstname
                oReturn.caracteristiqueTiers.AdresseLivraison.nom = client.adresse_livraison.livraison_name & " " & client.adresse_livraison.livraison_firstname
                oReturn.caracteristiqueTiers.AdresseLivraison.rue1 = client.adresse_livraison.livraison_adress1
                oReturn.caracteristiqueTiers.AdresseLivraison.rue2 = client.adresse_livraison.livraison_adress2
                oReturn.caracteristiqueTiers.AdresseLivraison.cp = client.adresse_livraison.livraison_postalcode
                oReturn.caracteristiqueTiers.AdresseLivraison.ville = client.adresse_livraison.livraison_city

                oReturn.caracteristiqueTiers.AdresseFacturation.nom = oReturn.caracteristiqueTiers.AdresseLivraison.nom
                oReturn.caracteristiqueTiers.AdresseFacturation.rue1 = oReturn.caracteristiqueTiers.AdresseLivraison.rue1
                oReturn.caracteristiqueTiers.AdresseFacturation.rue2 = oReturn.caracteristiqueTiers.AdresseLivraison.rue2
                oReturn.caracteristiqueTiers.AdresseFacturation.cp = oReturn.caracteristiqueTiers.AdresseLivraison.cp
                oReturn.caracteristiqueTiers.AdresseFacturation.ville = oReturn.caracteristiqueTiers.AdresseLivraison.ville

                oReturn.caracteristiqueTiers.idModeReglement = oClient.idModeReglement
                oReturn.caracteristiqueTiers.idModeReglement1 = oClient.idModeReglement1
                oReturn.caracteristiqueTiers.idModeReglement2 = oClient.idModeReglement2
                oReturn.caracteristiqueTiers.idModeReglement3 = oClient.idModeReglement3
                oReturn.caracteristiqueTiers.rib1 = oClient.rib1
                oReturn.caracteristiqueTiers.rib2 = oClient.rib2
                oReturn.caracteristiqueTiers.rib3 = oClient.rib3
                oReturn.caracteristiqueTiers.rib4 = oClient.rib4
                nLigne = 10
                bImport = True
                For Each oLg As ligneWOO In lignes_commande
                    'Chargement du produit PAS DE TEST SUR LE CODE STAT
                    oProduit = Produit.createandloadbyKey(oLg.reference)
                    If oProduit IsNot Nothing Then
                        oReturn.AjouteLigne(nLigne, oProduit, oLg.quantite, oLg.prixunitaire)
                        nLigne = nLigne + 10
                    Else
                        oProduit = Produit.getProduitParCodestat(oLg.reference)
                        If oProduit IsNot Nothing Then
                            oReturn.AjouteLigne(nLigne, oProduit, oLg.quantite, oLg.prixunitaire)
                            nLigne = nLigne + 10
                        Else
                            bImport = False
                            motif = "Produit [" & oLg.reference & "] inconnu"
                            Exit For
                        End If
                    End If
                Next
            Else
                bImport = False
                motif = "Client [" & entete.customer_id & "] inconnu, dossier [" & entete.origine & "]"
            End If
        Catch ex As Exception
            bImport = False
            motif = ex.Message
            oReturn = Nothing
        End Try

        'Sauvegarde de la Commande 
        If bImport Then
            oReturn.save()
        End If

        Return oReturn
    End Function
    Protected Shared Sub setError(ByVal strSource As String, ByVal strMessage As String)
        '       m_ErreurSource = strSource
        '     m_ErreurMessage = strMessage
        '      If (m_ErreurMessage <> "") Then
        Trace.WriteLine(strSource & ":" & strMessage)
        '    End If
    End Sub
    Protected Shared Sub setError(ByVal strMessage As String)
        Try

            '   m_ErreurSource = ""
            '   m_ErreurMessage = strMessage
            '  If (m_ErreurMessage <> "") Then
            Trace.WriteLine(strMessage)
            'End If
        Catch ex As Exception
            '            If (m_ErreurMessage <> "") Then
            ' Trace.WriteLine("???:" & m_ErreurMessage)
            ' End If

        End Try
    End Sub

End Class
<Serializable()>
<XmlType(TypeName:="ligne")>
Public Class ligneWOO
    Public reference As String
    Public quantite As Integer
    Public prixunitaire As Decimal
    Public Sub New()

    End Sub
    Public Sub New(pRef As String, pQuantite As Integer, pPrix As Decimal)
        reference = pRef
        quantite = pQuantite
        prixunitaire = pPrix
    End Sub
End Class
<Serializable()>
Public Class EnteteWOO
    Public id As String
    Public name As String
    Public origine As String
    Public customer_id As String
    Public num_cde_woocommerce As String
    Public datecmd As String
End Class
<Serializable()>
Public Class clientWOO
    Public adresse_livraison As adresse_livraisonWOO
    Public Sub New()
        adresse_livraison = New adresse_livraisonWOO()
    End Sub
End Class
<Serializable()>
Public Class adresse_livraisonWOO
    Public livraison_company As String = ""
    Public livraison_name As String = ""
    Public livraison_firstname As String = ""
    Public livraison_adress1 As String = ""
    Public livraison_adress2 As String = ""
    Public livraison_postalcode As String = ""
    Public livraison_city As String = ""
End Class


