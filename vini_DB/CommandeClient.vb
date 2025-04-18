Imports System.IO
'===================================================================================================================================
'Projet : Vinicom
'Auteur : Marc Collin 
'Cr�ation : 23/06/04
'===================================================================================================================================
' Classe : Commande Client   
' Description : Commande Client
'               H�rite de Commande
'===================================================================================================================================
'Membres de Classes
'==================
'Public
'Protected
'Private
'Membres d'instances
'==================
'Public
'   toString()      : Rend 'objet sous forme de chaine
'   Equals()        : Test l'�quivalence d'instance
'Protected
'Private
'===================================================================================================================================
'Historique :
'============
'15/09/05 : Ajout des factures de transport
'1/10/05 : Ajout des qteColis, Poids et Palettes
'
'===================================================================================================================================Public MustInherit Class Persist
Public Class CommandeClient
    Inherits Commande
#Region "Membres Priv�s"
    '=================== MEMBRES PRIVES ====================================
    Private m_typeCommande As vncTypeCommande       'Type de Commande
    Private m_typeTransport As vncTypeTransport      'Type de Transport
    Private m_colSousCommande As ColEvent                       'Collection de sous-commandes
    Private m_bcolSousCommandeLoaded As Boolean
    'Ajout Logistique
    Private m_bFactTransport As Boolean
    Private m_idFactTransport As Long
    'Ajout du nom et raison Sociale de livraison
    Private m_RaisonSocialeLivraison As String
    Private m_NomLivraison As String
    Protected m_bUpdatePrecommande As Boolean = True     'Mise � jour des pr�commandes (par defaut = vrai)
    Protected m_IDPrestashop As Long
    Protected m_NamePrestashop As String
    Private m_Date_EDI As DateTime
    Public Property Date_EDI() As DateTime
        Get
            Return m_Date_EDI
        End Get
        Set(ByVal value As DateTime)
            m_Date_EDI = value
        End Set
    End Property
#End Region
#Region "Accesseurs"
    Public Sub New(ByVal poClient As Client)
        MyBase.New(poClient, New EtatCommandeEnCoursSaisie)
        m_typedonnee = vncEnums.vncTypeDonnee.COMMANDECLIENT
        m_typeCommande = vncEnums.vncTypeCommande.vncCmdClientPlateforme
        m_typeTransport = vncEnums.vncTypeTransport.vncTrpDepart
        m_colSousCommande = New ColEvent
        m_bcolSousCommandeLoaded = False
        m_bFactTransport = True
        m_idFactTransport = 0
        m_NomLivraison = ""
        m_RaisonSocialeLivraison = ""
        m_bUpdatePrecommande = True
        m_NamePrestashop = ""
        Origine = Dossier.VINICOM
        Date_EDI = Nothing
        Debug.Assert(Not m_oTransporteur Is Nothing)
        Debug.Assert(Not etat Is Nothing)
        majBooleenAlaFinDuNew()
    End Sub
    Public Shared Function createandload(ByVal pid As Integer) As CommandeClient
        '=======================================================================
        ' Contructeur pour chargement
        '=======================================================================
        Dim objCommandeClient As CommandeClient
        Dim bReturn As Boolean
        objCommandeClient = New CommandeClient(New Client("", ""))
        Try
            If pid <> 0 Then
                bReturn = objCommandeClient.load(pid)
                If Not bReturn Then
                    setError("CommandeClient.createAndLoad", getErreur())
                Else
                    objCommandeClient.oTiers.load(objCommandeClient.oTiers.id)
                End If

            End If
        Catch ex As Exception
            setError("CommandeClient.createAndLoad", ex.ToString)
        End Try
        Debug.Assert(objCommandeClient.id = pid, "Commande Client " & pid & " non charg�e")
        Return objCommandeClient
    End Function 'createandload

    Public Property typeCommande() As vncTypeCommande
        Get
            Debug.Assert(Not m_bResume, "Objet de type resum�")
            Return m_typeCommande
        End Get
        Set(ByVal Value As vncTypeCommande)
            If m_typeCommande <> Value Then
                m_typeCommande = Value
                RaiseUpdated()
            End If
        End Set
    End Property
    Public Property typeTransport() As vncTypeTransport
        Get
            Debug.Assert(Not m_bResume, "Objet de type resum�")
            Return m_typeTransport
        End Get
        Set(ByVal Value As vncTypeTransport)
            If m_typeTransport <> Value Then
                m_typeTransport = Value
                RaiseUpdated()
            End If
        End Set
    End Property
    Public ReadOnly Property colSousCommandes() As ColEvent
        Get
            Debug.Assert(Not m_bResume, "Objet de type resum�")
            Return m_colSousCommande
        End Get
    End Property

    Public Property bFactTransport() As Boolean
        Get
            Debug.Assert(Not m_bResume, "Objet de type resum�")
            Return m_bFactTransport
        End Get
        Set(ByVal Value As Boolean)
            If (Value <> m_bFactTransport) Then
                m_bFactTransport = Value
                RaiseUpdated()
            End If
        End Set
    End Property
    Public Property bUpdatePrecommande() As Boolean
        Get
            Return m_bUpdatePrecommande
        End Get
        Set(ByVal Value As Boolean)
            m_bUpdatePrecommande = Value
        End Set
    End Property
    Public Property idFactTransport() As Long

        Get
            Debug.Assert(Not m_bResume, "Objet de type resum�")
            Return m_idFactTransport
        End Get
        Set(ByVal Value As Long)
            If (Value <> m_idFactTransport) Then
                m_idFactTransport = Value
                RaiseUpdated()
            End If
        End Set
    End Property
    ''' <summary>
    ''' Raison Sociale de Livraison (#702)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RaisonSocialeLivraison As String
        Get
            Return m_RaisonSocialeLivraison
        End Get
        Set(value As String)
            If value <> m_RaisonSocialeLivraison Then
                m_RaisonSocialeLivraison = value
                RaiseUpdated()
            End If
        End Set
    End Property
    ''' <summary>
    ''' Nom de la personne pour la livraison (#702)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NomLivraison As String
        Get
            Return m_NomLivraison
        End Get
        Set(value As String)
            If value <> m_RaisonSocialeLivraison Then
                m_NomLivraison = value
                RaiseUpdated()
            End If
        End Set
    End Property
    Public Property IDPrestashop As Long
        Get
            Return m_IDPrestashop
        End Get
        Set(value As Long)
            If value <> m_IDPrestashop Then
                m_IDPrestashop = value
                RaiseUpdated()
            End If
        End Set
    End Property
    Public Property NamePrestashop As String
        Get
            Return m_NamePrestashop
        End Get
        Set(value As String)
            If value <> m_NamePrestashop Then
                m_NamePrestashop = value
                RaiseUpdated()
            End If
        End Set
    End Property
#End Region
#Region "M�thodes de Classe"
    ''' <summary>
    ''' Rend un liste de commande pour un Dossier Donn� (VINICOM par d�faut)
    ''' </summary>
    ''' <param name="strCode">Code Commande</param>
    ''' <param name="strNomClient">NomClient</param>
    ''' <param name="pEtat">Etat de la commande</param>
    ''' <param name="pOrigine">Dossier (VINICOM par defaut, "" = Tous)</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Shared Function getListe(ByVal strCode As String, ByVal strNomClient As String, ByVal pEtat As vncEtatCommande, pOrigine As String) As Collection
        Dim colReturn As Collection

        Persist.shared_connect()
        colReturn = ListeCMDCLT(strCode, strNomClient, pEtat, pOrigine)
        Persist.shared_disconnect()
        Return colReturn
    End Function
    Public Shared Function getListe(ByVal pddeb As Date, ByVal pdfin As Date, ByVal pNomClient As String, ByVal pEtat As vncEtatCommande, pOrigine As String) As Collection
        Dim colReturn As Collection

        shared_connect()
        colReturn = Persist.ListeCMDCLTEtat(pddeb, pdfin, pNomClient, pEtat, pOrigine)
        Debug.Assert(Not colReturn Is Nothing, "CommandeClient.getListe" & getErreur())
        shared_disconnect()
        Return colReturn

    End Function

    Public Shared Function getListe_TRP(ByVal pddeb As Date, ByVal pdfin As Date, Optional ByVal pNomClient As String = "", Optional ByVal pCodeClient As String = "") As Collection
        Dim colReturn As Collection

        shared_connect()
        colReturn = Persist.ListeCMDCLT_TRP(pddeb, pdfin, pNomClient, pCodeClient)
        Debug.Assert(Not colReturn Is Nothing, "FactCom.getListe" & getErreur())
        shared_disconnect()
        Return colReturn

    End Function

#End Region
#Region "Interface Persist"
    '=======================================================================
    'Fonction : DBLoad()
    'Description : Chargement de l'objet
    'D�tails    :  
    'Retour : Vrai di l'op�ration s'est bien d�roul�e
    '=======================================================================
    Protected Overrides Function DBLoad(Optional ByVal pid As Integer = 0) As Boolean
        Dim bReturn As Boolean
        If pid <> 0 Then
            m_id = pid
        End If

        Debug.Assert(id <> 0, "idCommande <> 0")
        bReturn = LoadCMDCLT()
        If bReturn Then
            'Chargement des caract�ristiques du client
            bReturn = oTiers.loadLight()
            'Debug.Assert(bReturn, Tiers.getErreur())
        End If
        If Commande.bChargerColLignes Then
            bReturn = loadcolLignes()
        End If
        m_colSousCommande.clear()
        m_bcolLgLoaded = bReturn
        Return bReturn
    End Function 'DBLoad
    Public Overrides Function save() As Boolean
        Dim bReturn As Boolean
        shared_connect()
        bReturn = MyBase.Save()
        If m_bcolLgLoaded Then
            bReturn = bReturn And savecolLignes()
        End If
        If m_id > 0 Then
            If m_bcolLgLoaded And bUpdatePrecommande Then
                bReturn = bReturn And updatePrecommande()
                Debug.Assert(bReturn, "Erreur en updatePrecommande" & getErreur())
            End If
            'MVTS STOCKS
            If getActionMvtStock() = vncEnums.vncGenererSupprimer.vncGenerer Then
                bReturn = bReturn And genereMvtStock()
                Debug.Assert(bReturn, "Erreur en generemvtStock" & getErreur())
            End If
            If getActionMvtStock() = vncEnums.vncGenererSupprimer.vncSupprimer Then
                bReturn = bReturn And supprimeMvtStock()
                Debug.Assert(bReturn, "Erreur en supprimeMvtStock" & getErreur())
            End If
            'Sous-Commandes
            Select Case getActionSousCommande()
                Case vncGenererSupprimer.vncGenerer
                    bReturn = bReturn And insertcolSCMD()
                    Debug.Assert(bReturn, "Erreur en insertcolSCMD" & getErreur())
                Case vncGenererSupprimer.vncSupprimer
                    bReturn = bReturn And deletecolSCMD()
                    Debug.Assert(bReturn, "Erreur en deletecolSCMD" & getErreur())
                Case vncGenererSupprimer.vncRien
                    bReturn = bReturn And updatecolSCMD()
                    Debug.Assert(bReturn, "Erreur en updatecolSCMD" & getErreur())
            End Select
        End If
        shared_disconnect()
        Return bReturn
    End Function ' Save
    Private Function updatePrecommande() As Boolean
        '=================================================================================
        'Fonction : updatePrecommande
        'Description : Mise � jour de la precommande du client avec le prix de la commande
        'D�tails    :  
        'Retour : Vrai si l'op�ration s'est bien d�roul�e
        '================================================================================
        Dim bReturn As Boolean
        Dim objClient As Client
        Dim oSW As New Stopwatch()

        Try
            objClient = oTiers
            oSW.Start()
            objClient.updatePrecommande(Me)
            oSW.Stop()
            oSW.Reset()
            oSW.Start()
            bReturn = objClient.save
            oSW.Stop()

        Catch ex As Exception
            bReturn = False
            setError("CommandeClient.updatePrecommande", ex.ToString)
        End Try
        Debug.Assert(bReturn, getErreur())
        Return bReturn
    End Function 'updatePrecommande
    Friend Overrides Function delete() As Boolean
        '=======================================================================
        'Fonction : delete()
        'Description : Suppression de l'objet dans la base de l'objet
        'D�tails    :  
        'Retour : Vrai si l'op�ration s'est bien d�roul�e
        '=======================================================================
        Debug.Assert(id <> 0, "idCommande <> 0")
        Dim bReturn As Boolean
        'On ne supprime plus automtiquement les mouvements de stocks
        '   La commande peut-�tre supprim�e sans modifier le stock
        '        etat.actionMvtStock = vncEnums.vncGenererSupprimer.vncSupprimer 'Il faut supprimer les mvts de stocks
        '       supprimeMvtStock()
        bReturn = deletecolLgCMD()
        If bReturn Then
            m_bcolLgLoaded = False
            m_colLignes.clear()
            bReturn = deletecolSCMD()
            'Les sous commandes sont Supprim�es par les factures de commissions
            If bReturn Then
                bReturn = deleteCMDCLT()
            End If
        End If
        Return bReturn

    End Function ' delete
    '=======================================================================
    'Fonction : checkFordelete
    'description : Controle si l'�l�ment est supprimable
    '                Existance de sous-commandes
    '=======================================================================
    Public Overrides Function checkForDelete() As Boolean
        Dim bReturn As Boolean
        Try
            shared_connect()
            bReturn = True
            If existeSousCommandeCommande() Then
                bReturn = False
            End If
            shared_disconnect()
        Catch ex As Exception
            bReturn = False
        End Try
        Return bReturn
    End Function 'checkForDelete

    '=======================================================================
    'Fonction : insert()
    'Description : insertion de l'objet dans la base de l'objet
    'D�tails    :  
    'Retour : Vrai di l'op�ration s'est bien d�roul�e
    '=======================================================================
    Friend Overrides Function insert() As Boolean
        Debug.Assert(Not oTiers Is Nothing, "Le Client n'est pas Renseign�")
        Debug.Assert(code.Equals(""), "Le Code doit �tre nul")
        Debug.Assert(oTiers.id <> 0, "Le Client n'est pas sauvegard�")
        Debug.Assert(id = 0, "idCommande = 0")

        Dim bReturn As Boolean
        If setNewcode() Then
            bReturn = insertCMDCLT()
        End If
        Return bReturn
    End Function 'insert
    '=======================================================================
    'Fonction : Update()
    'Description : Mise � jour de l'objet
    'D�tails    :  
    'Retour : Vrai di l'op�ration s'est bien d�roul�e
    '=======================================================================
    Friend Overrides Function update() As Boolean
        Debug.Assert(Not oTiers Is Nothing, "Le Client n'est pas Renseign�")
        Debug.Assert(code <> "", "Le Code ne doit pas �tre nul")
        Debug.Assert(oTiers.id <> 0, "Le Client n'est pas sauvegard�")
        Debug.Assert(id <> 0, "idCommande <> 0")
        Dim bReturn As Boolean
        bReturn = updateCMDCLT()
        Return bReturn

    End Function 'Update

    '======================================================================
    'Fonction : LoadcolSousCommande
    'Description : Chargement de la collection des sous-commandes
    '======================================================================
    Public Function LoadColSousCommande() As Boolean
        Debug.Assert(m_id <> 0, "La commande doit �tre sauvegard�e au Pr�alable")
        Dim bReturn As Boolean
        bReturn = False
        shared_connect()
        If m_bcolLgLoaded Then
            m_colSousCommande.clear()
        End If
        bReturn = LoadColSCMD()
        Debug.Assert(bReturn, racine.getErreur())
        m_bcolSousCommandeLoaded = bReturn ' Les Sous commandes sont charg�es
        shared_disconnect()
        Return bReturn
    End Function 'LoadColSousCommande
#End Region
#Region "M�thodes Overrides"
    Public Overrides Sub Exporter(ByVal pfileNAme As String)
        ' no export for Commandeclient
    End Sub

    Friend Overrides Function setNewcode() As Boolean
        Dim str As String
        Dim ncode As Integer
        Dim breturn As Boolean

        shared_connect()
        str = ""
        ncode = getNumeroCommandeClient()
        shared_disconnect()
        If ncode = -1 Then
            breturn = False
        Else
            code = str & CStr(ncode)
            breturn = True
        End If
        Return breturn
    End Function 'setnewCode
    Public Overrides Function changeEtat(ByVal p_action As vncActionEtatCommande) As Boolean
        '        etat = etat.changeEtat(p_action)
        '4/10/04 Les Commandes Directe ne g�n�rent pas de mvts de stocks

        Debug.Assert(p_action >= vncActionEtatCommande.vncActionMinCommande And p_action <= vncActionEtatCommande.vncActionMaxCommande)
        Dim bReturn As Boolean = False
        Try
            If p_action >= vncActionEtatCommande.vncActionMinCommande And p_action <= vncActionEtatCommande.vncActionMaxCommande Then
                MyBase.changeEtat(p_action)
                If typeCommande = vncEnums.vncTypeCommande.vncCmdClientDirecte Then
                    etat.actionMvtStock = vncEnums.vncGenererSupprimer.vncRien
                End If
                RaiseUpdated()
                bReturn = True
            Else
                setError("Commandeclient.changeEtat", "Code Action incorrect :" + p_action)
                bReturn = False
            End If

        Catch ex As Exception
            setError("CommandeClient.changeEtat", ex.ToString)
            bReturn = False
        End Try

        Return bReturn

    End Function 'ChangeEtat


    '=======================================================================
    'Fonction : ToString()
    'Description : Rend l'objet sous forme de String
    'D�tails    :  
    'Retour : une Chaine
    '=======================================================================
    Public Overrides Function toString() As String
        Return MyBase.toString()
    End Function
    '=======================================================================
    'Fonction : Equals()
    'Description : Teste l'�quivalence entre 2 objets
    'D�tails    :  
    'Retour : Vari si l'objet pass� en param�tre est equivalent � 
    '=======================================================================
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim bReturn As Boolean
        Dim objCommande As CommandeClient
        Try

            bReturn = MyBase.Equals(obj)
            objCommande = obj
            bReturn = bReturn And (typeCommande.Equals(objCommande.typeCommande))
            bReturn = bReturn And (typeTransport.Equals(objCommande.typeTransport))
            bReturn = bReturn And (m_bFactTransport.Equals(objCommande.bFactTransport))
            bReturn = bReturn And (m_idFactTransport.Equals(objCommande.idFactTransport))
            bReturn = bReturn And (m_NomLivraison.Equals(objCommande.NomLivraison))
            bReturn = bReturn And (m_RaisonSocialeLivraison.Equals(objCommande.RaisonSocialeLivraison))

        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn

    End Function 'Equals
#End Region
    ''Methode : EstEntierementLivree
    ''Description : rend Vrai si tous les lignes on �t� Livr�es
    'Public Function estEntierementLivree() As Boolean
    '    Dim olgCom As LgCommande
    '    Dim bReturn As Boolean

    '    bReturn = True
    '    For Each olgCom In colLignes
    '        bReturn = bReturn And olgCom.estLivree()
    '    Next

    '    Return bReturn

    'End Function 'estEntierementLivree

    ''=======================================================================
    ''Fonction : AjouteLigne()
    ''Description : Ajoute une ligne sur une commandeClient
    ''D�tails    :  
    ''Retour : une ligne de commande ou nothing si l'ajout �choue
    ''=======================================================================
    ''    Public Function AjouteLigne(ByVal p_strNum As String, ByVal p_oProduit As Produit, ByVal p_qteCmd As Decimal, ByVal p_prixU As Decimal, Optional ByVal p_bGratuit As Boolean = False, Optional ByVal p_prixHT As Decimal = -1, Optional ByVal p_prixTTC As Decimal = -1, Optional ByVal p_bCalculPrixCommande As Boolean = True) As LgCommande
    'Public Overloads Overrides Function AjouteLigne(ByVal pobjLgCMD As LgCommande, Optional ByVal p_bCalculPrix As Boolean = True) As LgCommande
    '    Debug.Assert(Not m_colLignes Is Nothing)
    '    Debug.Assert(Not pobjLgCMD Is Nothing)
    '    Dim oReturn As LgCommande

    '    Try
    '        If p_bCalculPrix Then
    '            pobjLgCMD.calculPrixTotal()
    '        End If
    '        m_colLignes.Add(pobjLgCMD, CStr(pobjLgCMD.num))
    '        If p_bCalculPrix Then
    '            calculPrixTotal()
    '        End If
    '        oReturn = pobjLgCMD
    '        m_bcolLgLoaded = True
    '    Catch ex As Exception
    '        setError("Commande.AjouteLigne", "Ajout de ligne impossible key = " & pobjLgCMD.num)
    '        oReturn = Nothing
    '    End Try
    '    '        Debug.Assert(m_ocolLignes.Count = n + 1, "Le nombre d'�lement dans la collection est incr�ment� de 1")
    '    Return oReturn
    'End Function 'AjouteLigne

    ''=======================================================================
    ''Fonction : AjouteLigne()
    ''Description : Cr�� une ligne de commande et l'ajoute � la collection via AjouteLigne
    ''D�tails    :   Appelle la Fonction AjoutLigne a
    ''Retour : une ligne de commande ou nothing si l'ajout �choue
    ''=======================================================================
    'Public Overloads Function AjouteLigne(ByVal p_strNum As String, ByVal p_oProduit As Produit, ByVal p_qteCmd As Decimal, ByVal p_prixU As Decimal, Optional ByVal p_bGratuit As Boolean = False, Optional ByVal p_prixHT As Decimal = -1, Optional ByVal p_prixTTC As Decimal = -1, Optional ByVal p_bCalculPrix As Boolean = True) As LgCommande
    '    Debug.Assert(Not m_colLignes Is Nothing)
    '    Debug.Assert(Not p_oProduit Is Nothing)

    '    Dim oLgCmd As LgCommande

    '    oLgCmd = New LgCommande(m_id)
    '    oLgCmd.num = p_strNum
    '    oLgCmd.idCmd = id
    '    oLgCmd.idSCmd = 0 ' La sous commande n'est pas connue
    '    oLgCmd.oProduit = p_oProduit
    '    oLgCmd.qteCommande = p_qteCmd
    '    oLgCmd.prixU = p_prixU
    '    oLgCmd.bGratuit = p_bGratuit
    '    oLgCmd.prixHT = p_prixHT
    '    oLgCmd.prixTTC = p_prixTTC

    '    oLgCmd = AjouteLigne(oLgCmd, p_bCalculPrix)
    '    Return oLgCmd
    'End Function 'AjouteLigne

    Public Function generationSousCommande() As Boolean
        '=======================================================================
        'Fonction : generationSousCommande
        'Description : Cr�ation des sousCommandes : 1 Souscommande = 1 Fournisseur 
        '=======================================================================
        Debug.Assert(Not m_colLignes Is Nothing, "m_colLignes is Nothing")
        Debug.Assert(Not m_colSousCommande Is Nothing, "m_colSouscommande is Nothing")
        Debug.Assert(m_colSousCommande.Count() = 0, "m_colSouscommande non vide")

        Dim bReturn As Boolean
        Dim objLGCMD As LgCommande
        Dim bFini As Boolean
        Dim idFRN As Integer
        Dim oFRN As Fournisseur
        Dim oSCMD As SousCommande
        Dim pIntermediaire As Client
        Dim strDossierProduit As String

        pIntermediaire = Client.getIntermediairePourUneOrigine(Me.Origine)

        'On vide la collection des sousCommande par securit�
        m_colSousCommande.clear()
        oSCMD = Nothing
        bReturn = False
        bFini = False
        'Reinitialisation des lignes 
        For Each objLGCMD In m_colLignes
            objLGCMD.idSCmd = 0
            objLGCMD.bLigneEclatee = False
        Next
        'Tant que l'on a pas terminer on boucle sur la collection de lignes
        While Not bFini
            bFini = True
            idFRN = 0 'on reinitialise le fournisseur courrant avant de commencer la boucle
            strDossierProduit = ""
            For Each objLGCMD In m_colLignes
                'on ne traitre que les lignes qui ne sont pas d�j� �clat�es
                If Not objLGCMD.bLigneEclatee Then
                    bFini = False
                    If idFRN = 0 Then
                        'S'il n'y a pas de fournisseur courant on prend celui l� et le Dossier concern�
                        idFRN = objLGCMD.oProduit.idFournisseur
                        oFRN = Fournisseur.createandload(idFRN)
                        strDossierProduit = objLGCMD.oProduit.DossierProduit
                        ' et on cr�e la sous-commande avec ce fournisseur
                        oSCMD = New SousCommande(Me, oFRN)
                        oSCMD.setNewcode()
                        'Si le Produit est un Produit Vinicom et la Commande est HOBIVIN
                        'Alors on remplace le client par l'interm�daire
                        If Me.Origine = Dossier.HOBIVIN And objLGCMD.oProduit.DossierProduit = Dossier.VINICOM Then
                            If pIntermediaire IsNot Nothing Then
                                oSCMD.setTiers(pIntermediaire)
                            End If
                        End If
                        'on ajoute la sous-commande � la collection
                        Me.colSousCommandes.Add(oSCMD, oSCMD.code)
                    End If
                    If objLGCMD.oProduit.idFournisseur = idFRN And objLGCMD.oProduit.DossierProduit = strDossierProduit Then
                        'La Ligne correspond au fournisseur courant et au dossier courant
                        ' On l'ajoute � la sous-commande courante 
                        Dim LgSCMD As LgCommande = oSCMD.AjouteLigne(objLGCMD, True)
                        If Me.Origine = Dossier.HOBIVIN And LgSCMD.oProduit.DossierProduit = Dossier.VINICOM And pIntermediaire IsNot Nothing Then
                            '#857 : Modification du prix on prend le prix GESTCOM et non celui de la commande
                            LgSCMD.prixU = objLGCMD.oProduit.Tarif(pIntermediaire.CodeTarif)
                            LgSCMD.calculPrixTotal()
                            oSCMD.calculPrixTotal()
                        End If
                        'On la marque comme trait�e
                        objLGCMD.bLigneEclatee = True
                        objLGCMD.idSCmd = oSCMD.id ' 0 car la sous commande n'est pas encore sauvegard�e
                    End If
                End If
            Next
        End While
        'Calcul de la commission pour chaque Sous commande
        For Each oSCMD In m_colSousCommande
            oSCMD.calcCommisionstandard(CalculCommScmd.CALCUL_COMMISSION_HT_CALCULE)
        Next


        bReturn = bFini
        If bReturn Then
            changeEtat(vncEnums.vncActionEtatCommande.vncActionEclater)
        End If
        Return bReturn
    End Function 'generationSousCommande
    ''' <summary>
    ''' Annulation des sousCommandes 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function annulationSousCommande() As Boolean
        '=======================================================================
        'Fonction : generationSousCommande
        'Description : Cr�ation des sousCommandes : 1 Souscommande = 1 Fournisseur 
        '=======================================================================
        Debug.Assert(Not m_colLignes Is Nothing, "m_colLignes is Nothing")
        Debug.Assert(Not m_colSousCommande Is Nothing, "m_colSouscommande is Nothing")
        Debug.Assert(m_bcolSousCommandeLoaded, "Collection des sous-commandes non charg�e")

        Dim bReturn As Boolean
        Dim objLGCMD As LgCommande

        bReturn = False
        'Nettoyage de la collection des Sous-commandes
        colSousCommandes.clear()
        'Reinitialisation des lignes 
        For Each objLGCMD In m_colLignes
            objLGCMD.bLigneEclatee = False
            objLGCMD.idSCmd = 0
        Next
        bReturn = True
        'changement D'�tat de la commande
        If bReturn Then
            changeEtat(vncEnums.vncActionEtatCommande.vncActionAnnEclater)
        End If
        Return bReturn
    End Function 'annulationSousCommande
    ' <summary>mise � jour de la colection des sous-commandes</summary>
    Private Function updatecolSCMD() As Boolean
        '=======================================================================
        'Fonction : updatecolSCMD
        'Description : Mise � jour de la collection des sous-comandes
        '               Boucle sur les sous-commandes et sauvegarde de chacune
        '=======================================================================
        Dim bReturn As Boolean
        Dim objScmd As SousCommande
        Try
            For Each objScmd In colSousCommandes
                bReturn = objScmd.Save()
                Debug.Assert(bReturn, "Sauvegarde de Sous Commandes")
            Next objScmd
            'Le Travail sur les sous-commandes � �t� fait
            etat.actionSousCommande = vncEnums.vncGenererSupprimer.vncRien
            bReturn = True
        Catch ex As Exception
            bReturn = False
            setError("SaveSousCommande", ex.ToString)
        End Try
        Return bReturn
    End Function 'saveSousCommandes
    Private Function insertcolSCMD() As Boolean
        '=======================================================================
        'Fonction : insertcolSCMD
        'Description : insertion  des sous-commandes en base de donn�es
        '=======================================================================
        Dim bReturn As Boolean
        Dim objScmd As SousCommande
        Try
            For Each objScmd In colSousCommandes
                objScmd.bNew = True
                bReturn = objScmd.Save()
                Debug.Assert(bReturn, "insertcolSCMD" & SousCommande.getErreur())
            Next objScmd
            'Le Travail sur les sous-commandes � �t� fait
            etat.actionSousCommande = vncEnums.vncGenererSupprimer.vncRien
            bReturn = True
        Catch ex As Exception
            bReturn = False
            setError("insertcolSCMD", ex.ToString)
        End Try
        Return bReturn
    End Function 'insertSousCommandes
    Public Function deletecolSCMD() As Boolean
        '=======================================================================
        'Fonction : deletecolSCMD
        'Description : Suppression en base des sous-commandes
        '               Passage de chaque Sous-commande � bdeleted = True
        '=======================================================================
        Dim bReturn As Boolean
        Try
            'Il n'y a plus de sous commande dans la collection
            'Donc la suppression est plus bestiale : Suppression des tous les enregistrements Sous-commandes reli�s � une commande
            'Seules les sousCommandes n'ayant pas �t� affect�e � une facture de comm sont supprim�es
            bReturn = deleteCMDCLT_SCMD()
            Debug.Assert(bReturn, "deleteCMDCLT_SCMD" & getErreur())

            'Le Travail sur les sous-commandes � �t� fait
            etat.actionSousCommande = vncEnums.vncGenererSupprimer.vncRien
            m_bcolSousCommandeLoaded = False
            m_colSousCommande.clear()
            bReturn = True
        Catch ex As Exception
            bReturn = False
            setError("deletecolSCMD", ex.ToString)
        End Try
        Return bReturn
    End Function 'deletecolSCMD
    '=======================================================================
    'Function : GenereMvtStock
    'Description : G�n�ration des mouvement de Stock
    '                   Uniquement pour les commande Plateforme !!!
    '=======================================================================
    Public Overrides Function genereMvtStock() As Boolean
        Debug.Assert(Not m_colLignes Is Nothing)
        Debug.Assert(etat.actionMvtStock = vncEnums.vncGenererSupprimer.vncGenerer)


        Dim bReturn As Boolean
        Dim objLgCom As LgCommande
        Dim objProduit As Produit
        Dim objmvtStock As mvtStock
        Dim bcolADecharger As Boolean
        Dim strLib As String
        Dim qte As Decimal


        'Chargement de la collection des lignes si elle n'est pas charg�e
        bcolADecharger = False
        If Not m_bcolLgLoaded Then
            bReturn = loadcolLignes()
            bcolADecharger = True
            Debug.Assert(bReturn, getErreur())
        End If

        Try
            If m_typeCommande = vncEnums.vncTypeCommande.vncCmdClientPlateforme Then
                Dim TiersRS As String = oTiers.rs
                Dim oInter As Client = Client.getIntermediairePourUneOrigine(Origine)
                If oInter IsNot Nothing Then
                    TiersRS = oInter.rs
                End If
                'Pour chaque ligne de commande
                For Each objLgCom In m_colLignes
                    objProduit = objLgCom.oProduit
                    objProduit.load()
                    objProduit.loadcolmvtStock()

                    'Controle de la non-exitence d'une ligne de mvt de stock pour cette ligne de commande
                    'If existeMvtSocklib(strLib) Then
                    '    Debug.Assert(False, "Il y a d�ja un mvt de stock pour cette ligne")
                    '    bReturn = False
                    '    setError("CommandeClient.genereMvtStock()", "Il y a d�ja un mvt de stock pour cette ligne")
                    '    Return bReturn
                    '    Persist.shared_disconnect()
                    '    Exit Function
                    'End If
                    qte = objLgCom.qteLiv
                    'Recherche des lignes de commandes concernant le m�me produit
                    'dans ce cas on les cumuls et on la marque comme �tant Trait�e
                    For Each objLgCom2 As LgCommande In m_colLignes
                        If objLgCom2.id <> objLgCom.id And Not objLgCom2.bTraitee Then
                            If objLgCom2.oProduit.id = objLgCom.oProduit.id Then
                                qte = qte + objLgCom2.qteLiv
                                objLgCom2.bTraitee = True
                            End If
                        End If
                    Next
                    strLib = "CMD " & code & " - " & objLgCom.num & " " & TiersRS
                    'Sis la ligne � d�j� �t� trait�e, sa qte est �gale � 0
                    If objLgCom.bTraitee Then
                        qte = 0
                        strLib = strLib + "deja inclus"
                    End If
                    'Ajout de la ligne de stock avec recalcul du stock
                    objmvtStock = objProduit.ajouteLigneMvtStock(Me.dateLivraison, vncEnums.vncTypeMvt.vncMvtCommandeClient, id, strLib, qte * -1, strLib, True)
                    objmvtStock.save()
                    'Liberation des mouvement de stock produits pour lib�rer la m�moire
                    objProduit.releasecolmvtStock()
                    'Sauvegarde du produit car le stock a �t� recalcul�
                    objProduit.save()
                Next objLgCom
                etat.actionMvtStock = vncEnums.vncGenererSupprimer.vncRien
            End If

            'D�chargement de la collection si elle n'�tait pas charg�e � l'entr�e
            If bcolADecharger Then
                releasecolLignes()
            End If

            bReturn = True

        Catch ex As Exception
            bReturn = False
            setError("genereMvtStock", ex.ToString)
        End Try
        Return bReturn
    End Function 'genereMvtStock

    '=======================================================================
    'Function : SuppressionMvtStock
    'Description : Suppression des mouvements de Stock
    '=======================================================================
    Public Overrides Function supprimeMvtStock() As Boolean
        Debug.Assert(etat.actionMvtStock = vncEnums.vncGenererSupprimer.vncSupprimer)

        Dim bReturn As Boolean
        Dim objLgCom As LgCommande
        Dim objProduit As Produit
        Dim bcolADecharger As Boolean

        'Chargement de la collection des lignes si elle n'est pas charg�e
        bcolADecharger = False
        If Not m_bcolLgLoaded Then
            bReturn = loadcolLignes()
            bcolADecharger = True
            Debug.Assert(bReturn, getErreur())
        End If

        Try
            shared_connect()
            'Recalcul du stock de la commande
            If m_typeCommande = vncEnums.vncTypeCommande.vncCmdClientPlateforme Then
                'Suppression en bloc des lignes de Mvts de Stocks
                bReturn = deleteCMDCLT_MVTSTK()
                Debug.Assert(bReturn, "CommandeClient.supprimeMvtStock" & getErreur())
                'Pour chaque ligne de commande
                For Each objLgCom In m_colLignes
                    objProduit = objLgCom.oProduit
                    objProduit.releasecolmvtStock()
                    objProduit.loadcolmvtStock()
                    objProduit.recalculStock()
                    objProduit.releasecolmvtStock()
                    objProduit.save()
                Next objLgCom
                etat.actionMvtStock = vncEnums.vncGenererSupprimer.vncRien
                'D�chargement de la collection si elle n'�tait pas charg�e � l'entr�e
                If bcolADecharger Then
                    releasecolLignes()
                End If
            End If
            shared_disconnect()

        Catch ex As Exception
            bReturn = False
            setError("Commandeclient.supprimeMvtStock", ex.ToString)
        End Try

        Debug.Assert(bReturn, getErreur())
        Return bReturn
    End Function 'supprimeMvtStock

    Public Overrides Function calculPrixTotal() As Boolean
        '========================================================================
        ' CalculPrixTotal : Calcul du prix de lacommande, du poids et des qte de colis
        '       Utilise le fonction CalculPtixTotal de la classe Commande pour calculer les prixs
        '========================================================================
        Dim bReturn As Boolean
        Try
            bReturn = MyBase.calculPrixTotal()
            For Each oLg As LgCommande In m_colLignes

                'Calcul de la commssion pour Chaque Ligne
                If (Me.etat.codeEtat = vncEtatCommande.vncEnCoursSaisie Or Me.etat.codeEtat = vncEtatCommande.vncValidee) Then
                    oLg.CalculCommission(Origine,CalculCommQte.CALCUL_COMMISSION_QTE_CMDE)
                Else
                    oLg.CalculCommission(Origine, CalculCommQte.CALCUL_COMMISSION_QTE_LIVREE)
                End If
            Next oLg


            bReturn = CalcPoidsColis()
        Catch ex As Exception
            setError("CommandeClient.CalculPrixTotal", ex.ToString)
            bReturn = False
        End Try
        Debug.Assert(bReturn, getErreur())
        Return bReturn
    End Function 'calculPrixTotal


    Public Function purge() As Boolean
        '================================================================================
        ' Fonction : purge 
        ' Description : Supression de la Commmande Client
        '           La Commande est purgeable si tous ses sous-commandes ont �t� factur�es
        '================================================================================
        Dim bReturn As Boolean
        Dim objSCMD As SousCommande
        Dim bPurgeable As Boolean

        bReturn = True
        'Test sur l'�tat de la commande = Eclat�e
        bReturn = Me.etat.codeEtat = vncEnums.vncEtatCommande.vncEclatee
        If bReturn Then
            'Chargement des lignes de factures de comm (Sous-Commandes)
            If Not m_bcolSousCommandeLoaded Then
                bReturn = LoadColSousCommande()
            End If
            'Test si la commande est 'Purgeable'
            'CAD toutes les sous commandes doivent �tre factur�es
            bPurgeable = True
            For Each objSCMD In m_colSousCommande
                bPurgeable = bPurgeable And ( _
                        objSCMD.etat.codeEtat = vncEnums.vncEtatCommande.vncSCMDFacturee)
            Next objSCMD

            'Si elle est purgeable => Suppression de la commande et de ses lignes de commandes
            If bPurgeable Then
                'Pour chaque ligne de commande cr�ation d'une ligne de statistiques
                'For Each objLgCmd In m_colLignes
                'objlgStat = New LgStat(Me, objLgCmd)
                'objlgStat.Save()
                'Next
                Me.bDeleted = True
                bReturn = Me.save()
            End If
            bReturn = True
        End If

        Return bReturn
    End Function 'purge
    ''' <summary>
    ''' parcours de chaque ligne de commande pour v�rifier l'existence d'un mouvement de stock
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function controleMvtStock() As Collection
        Dim objLgCMD As LgCommande
        Dim colReturn As New Collection
        Dim strErreurLg As String
        Dim nidProduit As Integer
        Dim colMvtStock As ColEventSorted
        Dim strErreur As String
        Dim objMvtStock As mvtStock
        Dim strCodePrd As String
        Dim Qtecmd As Decimal
        Dim QteStk As Decimal

        colMvtStock = Nothing
        strCodePrd = ""
        objLgCMD = Nothing
        If typeCommande = vncEnums.vncTypeCommande.vncCmdClientPlateforme Then
            'On ne controle que les commande plateforme

            strErreur = "Commande Num: " & code() & "(" & id & ")"
            strErreurLg = ""
            nidProduit = 0
            'chargement de la collection des lignes de produits
            'Elles sont tri�es par id produit
            If Not m_bcolLgLoaded Then
                loadcolLignes()
            End If
            For Each objLgCMD In colLignes
                objLgCMD.oProduit.DBLoad2()
                If objLgCMD.oProduit.bStock Then
                    strErreurLg = ""
                    If nidProduit <> objLgCMD.oProduit.id Then
                        If nidProduit <> 0 Then
                            'changement de produit
                            'chargement de la Liste des mouvements du produit pr�c�dent
                            colMvtStock = mvtStock.getListe(nidProduit, m_id)
                            'Cumul des Qte des mouvement de stocks
                            QteStk = 0
                            For Each objMvtStock In colMvtStock
                                QteStk = QteStk + (objMvtStock.qte * -1)
                            Next

                            'controle que la Qt en mvt de stock = qte Livr�e
                            If Qtecmd <> QteStk Then
                                strErreurLg = " ERR sur Qte attendu = " & Qtecmd & ", Stk =" & QteStk

                                colReturn.Add(strErreur & strErreurLg)
                                strErreurLg = ""
                            End If
                            Qtecmd = 0
                        End If
                        nidProduit = objLgCMD.oProduit.id
                    End If
                    Qtecmd = Qtecmd + objLgCMD.qteLiv
                End If
            Next objLgCMD

            If nidProduit <> 0 Then
                objLgCMD.oProduit.DBLoad2()
                If objLgCMD.oProduit.bStock Then
                    'Pour le dernier produit charg�
                    colMvtStock = mvtStock.getListe(nidProduit, m_id)
                    QteStk = 0
                    For Each objMvtStock In colMvtStock
                        QteStk = QteStk + (objMvtStock.qte * -1)
                    Next

                    If Qtecmd <> QteStk Then
                        strErreurLg = " ERR sur Qte attendu = " & Qtecmd & ", Stk =" & QteStk
                    End If

                    nidProduit = objLgCMD.oProduit.id
                    Qtecmd = 0
                End If
            End If


            'Suppression de la collection des lignes pour gagner de la place
            releasecolLignes()

        End If 'Commnande.type = plateforme
        Debug.Assert(Not colReturn Is Nothing)
        Return colReturn

    End Function ' controleMvtStock

    Public ReadOnly Property shortResumeTRP() As String
        Get
            Return code & "|" & oTiers.code & "|" & oTiers.rs & "|" & dateLivraison & "|" & Format(montantTransport, "C")
        End Get
    End Property


    '========================================================================
    'fonction : exporter
    'DEscription : Exporte la facture de transport dans un format WEBEDI
    'Retour : une chaine
    '=========================================================================
    Public Function exporterWebEDI(ByVal strFileName As String, Optional pbCodeStatPlateforme As Boolean = False) As Boolean

        Debug.Assert(bcolLignesLoaded, "Les lignes doivent �tre charg�es")

        'Dim nvcEntete As System.Collections.Specialized.NameValueCollection
        'Dim nvcLigne As System.Collections.Specialized.NameValueCollection
        Dim bReturn As Boolean
        Dim nFile As Integer
        Dim oLg As LgCommande
        Dim strResult As String
        Try
            nFile = FreeFile()
            FileOpen(nFile, strFileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
            For Each oLg In m_colLignes
                If Not oLg.bGratuit Then
                    'Cumul des qte command�es du m�me produit 
                    Dim nQteComm As Decimal = oLg.qteCommande
                    For Each oLgG As LgCommande In m_colLignes
                        If oLgG.bGratuit And oLgG.oProduit.id = oLg.oProduit.id Then
                            nQteComm = nQteComm + oLgG.qteCommande
                        End If
                    Next
                    'Le Calcul du nombre de colis a d�j� �t� fait

                    '1
                    strResult = Right("00000000" + Trim(Me.code), 8)
                    '9
                    strResult = strResult + Format(Now(), "ddMMyyyy")
                    '17
                    strResult = strResult + Format(Me.dateEnlevement, "ddMMyyyy")
                    '25
                    strResult = strResult + Format(Me.dateLivraison, "ddMMyyyy")
                    '33
                    strResult = strResult + Left(Me.oTiers.code + Space(8), 8)
                    '41
                    strResult = strResult + Left(Me.NomLivraison + Space(30), 30)
                    '71
                    strResult = strResult + Left(Me.RaisonSocialeLivraison + Space(30), 30)
                    '101
                    strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.rue1 + Space(30), 30)
                    '131
                    strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.rue2 + Space(30), 30)
                    '161
                    strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.cp + Space(5), 5)
                    '166
                    strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.ville + Space(26), 26)
                    '192
                    strResult = strResult + Left(Me.CommLivraison.comment + Space(100), 100)
                    '292
                    strResult = strResult + Format(oLg.num, "000")
                    '295
                    If pbCodeStatPlateforme And Not String.IsNullOrEmpty(Trim(oLg.oProduit.codeStat)) Then
                        strResult = strResult + Left(oLg.oProduit.codeStat + Space(15), 15)
                    Else
                        strResult = strResult + Left(oLg.oProduit.code + Space(15), 15)
                    End If
                    '310
                    strResult = strResult + Format(oLg.qteColis, "0000000")
                    '317
                    strResult = strResult + Format(nQteComm, "0000000")
                    '324
                    strResult = strResult + Left(Me.oTransporteur.nom + Space(50), 50)
                    '374
                    strResult = Replace(strResult, vbCrLf, "--")
                    strResult = Replace(strResult, vbCr, "-")
                    strResult = Replace(strResult, vbLf, "-")
                    strResult = Replace(strResult, vbNullChar, "-")
                    strResult = Replace(strResult, vbTab, "-")
                    strResult = Replace(strResult, vbBack, "-")
                    PrintLine(nFile, strResult)
                End If
            Next oLg
            'On REcparcours la Liste pour v�rifier qu'il n'y a pas de produit gratuits tout seul (Echantillons)
            For Each oLg In m_colLignes
                If oLg.bGratuit Then
                    'Y-a-t-il une ligne non gratuite ?
                    Dim bLignePayante As Boolean = False
                    For Each oLgG As LgCommande In m_colLignes
                        If Not oLgG.bGratuit And oLgG.oProduit.id = oLg.oProduit.id Then
                            bLignePayante = True
                        End If
                    Next
                    If Not bLignePayante Then
                        'Il n'y a pas de lignes payantes associ�es � la ligne gratuite
                        Dim nQteComm As Decimal = oLg.qteCommande

                        '1
                        strResult = Right("00000000" + Trim(Me.code), 8)
                        '9
                        strResult = strResult + Format(Now(), "ddMMyyyy")
                        '17
                        strResult = strResult + Format(Me.dateEnlevement, "ddMMyyyy")
                        '25
                        strResult = strResult + Format(Me.dateLivraison, "ddMMyyyy")
                        '33
                        strResult = strResult + Left(Me.oTiers.code + Space(8), 8)
                        '41
                        strResult = strResult + Left(Me.NomLivraison + Space(30), 30)
                        '71
                        strResult = strResult + Left(Me.RaisonSocialeLivraison + Space(30), 30)
                        '101
                        strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.rue1 + Space(30), 30)
                        '131
                        strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.rue2 + Space(30), 30)
                        '161
                        strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.cp + Space(5), 5)
                        '166
                        strResult = strResult + Left(Me.caracteristiqueTiers.AdresseLivraison.ville + Space(26), 26)
                        '192
                        strResult = strResult + Left(Me.CommLivraison.comment + Space(100), 100)
                        '292
                        strResult = strResult + Format(oLg.num, "000")
                        '295
                        If pbCodeStatPlateforme And Not String.IsNullOrEmpty(Trim(oLg.oProduit.codeStat)) Then
                            strResult = strResult + Left(oLg.oProduit.codeStat + Space(15), 15)
                        Else
                            strResult = strResult + Left(oLg.oProduit.code + Space(15), 15)

                        End If
                        '310
                        strResult = strResult + Format(oLg.qteColis, "0000000")
                        '317
                        strResult = strResult + Format(nQteComm, "0000000")
                        '324
                        strResult = strResult + Left(Me.oTransporteur.nom + Space(50), 50)
                        '374
                        strResult = Replace(strResult, vbCrLf, "--")
                        strResult = Replace(strResult, vbCr, "-")
                        strResult = Replace(strResult, vbLf, "-")
                        strResult = Replace(strResult, vbNullChar, "-")
                        strResult = Replace(strResult, vbTab, "-")
                        strResult = Replace(strResult, vbBack, "-")
                        PrintLine(nFile, strResult)
                    End If
                End If
            Next oLg
            FileClose(nFile)


            bReturn = True
        Catch ex As Exception
            bReturn = False
            setError("CommandeClient.exporterWebEDI ERR", ex.ToString())
        End Try
        Return bReturn
    End Function 'exporterWEBEDI

    'Exportation des sous commandes d'ue commande
    'Public Function faxerTout(ByVal pFAX_Path As String, ByVal pPathToReports As String, ByVal PFax_Nom_Interlocuteur As String, ByVal pFAX_Tel_Interlocuteur As String, ByVal pFAX_Subject As String, ByVal pFAX_Notes As String, ByVal pFAX_BSENDCOVERPAGE As Boolean) As Boolean
    '    Dim objSCMD As SousCommande
    '    Dim strFileName As String
    '    Dim bToutOK As Boolean
    '    For Each objSCMD In colSousCommandes
    '        objSCMD.oFournisseur.load()
    '        'on ne faxe pas automatiquement pour les fourisseurs internet
    '        If Not objSCMD.oFournisseur.bExportInternet Then
    '            If objSCMD.oFournisseur.AdresseFacturation.fax <> "" Then
    '                strFileName = pFAX_Path & objSCMD.code & ".doc"
    '                If objSCMD.faxer(pPathToReports, PFax_Nom_Interlocuteur, pFAX_Tel_Interlocuteur, pFAX_Subject, pFAX_Subject, pFAX_BSENDCOVERPAGE, strFileName, objSCMD.oFournisseur.AdresseFacturation.fax) Then
    '                    objSCMD.changeEtat(vncEnums.vncActionEtatCommande.vncActionSCMDFaxer)
    '                Else
    '                    bToutOK = False  ' Il y a au moins une erreur
    '                End If

    '                If File.Exists(strFileName) Then
    '                    File.Delete(strFileName)
    '                End If
    '            Else
    '                bToutOK = False  ' Il y a au moins une erreur
    '            End If
    '        End If
    '    Next objSCMD

    '    Return bToutOK

    'End Function 'faxerTout

    Public Overrides Function DuppliqueCaracteristiqueTiers() As Boolean
        Debug.Assert(Not oTiers Is Nothing)
        MyBase.DuppliqueCaracteristiqueTiers()
        NomLivraison = oTiers.AdresseLivraison.nom
        RaisonSocialeLivraison = oTiers.rs
        Return True
    End Function 'DuppliqueCaracteristiqueTiers
    ''' <summary>
    ''' Controle du stock disponible pour chaque ligne de commande
    ''' met � jour l'indicateur bStockDispo sur la ligne de commande
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function controleStockDispo() As Boolean
        Dim bReturn As Boolean
        Try
            For Each olg As LgCommande In colLignes
                olg.ControleStockdispo()
            Next
            bReturn = True
        Catch ex As Exception
            setError("CommandeClient.ControleStockdispo ERR : " & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function 'controleStockDispo

    ''' <summary>
    ''' Valider l'export quadra : Changement d'�tat de la Commande
    ''' Forcement une commande 'HOBIVIN'
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ValiderExportQuadra() As Boolean
        Debug.Assert(bcolLignesLoaded, "Les Lignes doivent �tre charg�es au pr�alable")
        Dim objLgCommande As LgCommande
        Dim bReturn As Boolean
        bReturn = False

        Try
            Me.changeEtat(vncEnums.vncActionEtatCommande.vncActionTransmettre)
            'Quantit� Factur�e = Quantit� Livr�e
            For Each objLgCommande In colLignes
                objLgCommande.qteFact = objLgCommande.qteLiv
            Next objLgCommande
            'Changement d'atat des SousCommandes pour les producteurs HOBIVIN
            If Me.colSousCommandes.Count = 0 Then
                Me.LoadColSCMD()
            End If
            For Each oScmd As SousCommande In Me.colSousCommandes
                oScmd.oFournisseur.load()
                If oScmd.oFournisseur.bExportInternet = vncTypeExportScmd.vncExportQuadra Then
                    oScmd.changeEtat(vncEnums.vncActionEtatCommande.vncActionSCMDExportInternet)
                    oScmd.changeEtat(vncEnums.vncActionEtatCommande.vncActionSCMDRapprocher)
                    oScmd.changeEtat(vncEnums.vncActionEtatCommande.vncActionSCMDFacturer)
                    oScmd.refFactFournisseur = "QUADRAFACT"
                    oScmd.bExportQuadra = True
                End If
            Next

            bReturn = True
        Catch ex As Exception
            setError("CommandeClient.ValiderExportQuadra ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn

    End Function

    Public Function LivrerToutOK() As Boolean
        Dim bReturn As Boolean
        Try

            Dim oLgCom As LgCommande
            For Each oLgCom In Me.colLignes
                If oLgCom.bResume Then
                    oLgCom.load()
                End If
                'La qte Livr�e est initialis�e avec la Qt en Commande
                oLgCom.qteLiv = oLgCom.qteCommande
                'Calcul de la commssion sur la Qte Livr�e
                oLgCom.CalculCommission(Me.Origine, CalculCommQte.CALCUL_COMMISSION_QTE_LIVREE)
            Next oLgCom
            'La Commande passe � Livr�
            Me.changeEtat(vncActionEtatCommande.vncActionLivrer)
            bReturn = True
        Catch ex As Exception
            setError("CommandeClient.LivrerToutOK ERR" & ex.Message)
            bReturn = False
        End Try

    End Function
End Class ' CommandeClient
