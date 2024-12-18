Imports System.Collections.Generic
Imports System.Linq
''' <summary>
''' Classe mouvement de Stock
''' </summary>
''' <remarks></remarks>
Public Class mvtStock
    Inherits Persist

    Private m_idProduit As Integer              'Produit 
    Private m_date As Date                      'Date du mouvement
    Private m_TypeMvt As vncTypeMvt             'Type de Mouvement
    Private m_idReference As Integer            'id de la r�f�rence
    Private m_libelle As String                 'Libell� du mouvement
    Private m_qte As Decimal                       'Quantite 
    Private m_oCommentaire As Commentaire       'Commentaire
    Private m_bControle As Boolean              ' mvt controle
    Private m_Etat As EtatMvtStock              ' Etat du Mvt de Stock
    Private m_idFactColisage As Integer              ' Id de la facture de colisage

#Region "Accesseurs"
    Public Sub New(ByVal pdateMvt As Date, ByVal pidProduit As Integer, ByVal ptype As vncTypeMvt, ByVal pqte As Decimal, ByVal plib As String)
        m_typedonnee = vncEnums.vncTypeDonnee.MVTSTK
        m_idProduit = pidProduit
        m_date = pdateMvt.ToShortDateString
        m_TypeMvt = ptype
        m_idReference = 0
        m_libelle = plib
        m_qte = pqte
        m_oCommentaire = New Commentaire
        m_bControle = False
        m_Etat = EtatMvtStock.createEtat(vncEtatMVTSTK.vncMVTSTK_nFact)
        m_idFactColisage = 0
        bTraitee = False
        majBooleenAlaFinDuNew()
    End Sub 'New
    Friend Sub New()
        m_typedonnee = vncEnums.vncTypeDonnee.MVTSTK
        m_idProduit = 0
        m_date = DATE_DEFAUT
        m_TypeMvt = vncEnums.vncTypeMvt.vncmvtRegul
        m_idReference = 0
        m_libelle = ""
        m_qte = 0
        m_oCommentaire = New Commentaire
        m_bControle = False
        m_Etat = EtatMvtStock.createEtat(vncEtatMVTSTK.vncMVTSTK_nFact)
        m_idFactColisage = 0
        bTraitee = False
    End Sub 'New

    Public Property idProduit() As Integer
        Get
            Return m_idProduit
        End Get
        Set(ByVal Value As Integer)
            If Not m_idProduit.Equals(Value) Then
                m_idProduit = Value
                RaiseUpdated()
            End If
        End Set
    End Property
    Public Property datemvt() As Date
        Get
            Return m_date
        End Get
        Set(ByVal Value As Date)
            If m_date.ToShortDateString <> Value.ToShortDateString Then
                m_date = Value.ToShortDateString
                RaiseUpdated()
            End If
        End Set
    End Property
    Public Property typeMvt() As vncTypeMvt
        Get
            Return m_TypeMvt
        End Get
        Set(ByVal Value As vncTypeMvt)
            If Value <> m_TypeMvt Then
                RaiseUpdated()
                m_TypeMvt = Value
            End If
        End Set
    End Property
    Public Property typeMvtSTR() As String
        Get
            Return typeMvt
        End Get
        Set(ByVal Value As String)
            If Not m_TypeMvt.Equals(Value) Then
                Try
                    typeMvt = Value
                    RaiseUpdated()
                Catch
                End Try

            End If
        End Set
    End Property
    Public Property idReference() As Integer
        Get
            Return m_idReference
        End Get
        Set(ByVal Value As Integer)
            If Value <> m_idReference Then
                RaiseUpdated()
                m_idReference = Value
            End If
        End Set
    End Property
    Public Property libelle() As String
        Get
            Return m_libelle
        End Get
        Set(ByVal Value As String)
            If Value <> m_libelle Then
                RaiseUpdated()
                m_libelle = Value
            End If
        End Set
    End Property
    Public Property qte() As Decimal
        Get
            Return m_qte
        End Get
        Set(ByVal Value As Decimal)
            If Value <> m_qte Then
                RaiseUpdated()
                m_qte = Value
            End If
        End Set
    End Property
    Public Property Commentaire() As String
        Get
            Return m_oCommentaire.comment
        End Get
        Set(ByVal Value As String)
            If Not (Value.Equals(m_oCommentaire.comment)) Then
                RaiseUpdated()
                m_oCommentaire.comment = Value
            End If
        End Set
    End Property

    Public Property Etat() As EtatMvtStock
        Get
            Return m_Etat
        End Get
        Set(ByVal value As EtatMvtStock)
            If Not (value.Equals(m_Etat)) Then
                RaiseUpdated()
                m_Etat = value
            End If

        End Set
    End Property

    Public Property idFactColisage() As Integer
        Get
            Return m_idFactColisage
        End Get
        Set(ByVal value As Integer)
            If Not (value.Equals(m_idFactColisage)) Then
                RaiseUpdated()
                m_idFactColisage = value
            End If
        End Set
    End Property
    'Propri�t� non sauvegard�e
    Private m_bTraitee As Boolean
    Public Property bTraitee() As Boolean
        Get
            Return m_bTraitee
        End Get
        Set(ByVal value As Boolean)
            m_bTraitee = value
        End Set
    End Property

    Public ReadOnly Property key() As String
        'on veut trier les mvts de stocks dans l'odre desc des date et des type de Mvts
        ' Donc on fait une cl� sur une diff�rence avec le 3eme mill�naire
        ' et la diff�rence 99-
        Get
            Dim nDate As Long
            nDate = 30000101 - ((m_date.Year * 10000) + (m_date.Month * 100) + m_date.Day)
            Return Format(nDate, "0000000000") & "_" & (99 - m_TypeMvt)
        End Get
    End Property

    Public Property bControle() As Boolean
        Get
            Return m_bControle
        End Get
        Set(ByVal Value As Boolean)
            m_bControle = Value
        End Set
    End Property

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
        bReturn = loadMVTSTK()
        Return bReturn
    End Function 'DBLoad
    Public Overrides Function save() As Boolean
        Dim bReturn As Boolean
        shared_connect()
        bReturn = MyBase.Save()
        shared_disconnect()
        Return bReturn
    End Function
    '=======================================================================
    'Fonction : delete()
    'Description : Suppression de l'objet dans la base de l'objet
    'D�tails    :  
    'Retour : Vrai si l'op�ration s'est bien d�roul�e
    '=======================================================================
    Friend Overrides Function delete() As Boolean
        Debug.Assert(id <> 0, "idCommande <> 0")
        Dim bReturn As Boolean
        bReturn = deleteMVTSTK()
        Return bReturn

    End Function ' delete
    '=======================================================================
    'Fonction : checkFordelete
    'description : Controle si l'�l�ment est supprimable
    '                table commandesClients
    '=======================================================================
    Public Overrides Function checkForDelete() As Boolean
        Dim bReturn As Boolean
        Try
            bReturn = True
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
        Debug.Assert(m_idProduit <> 0, "Le Produit n'est pas Renseign�")
        Debug.Assert(id = 0, "idmvt = 0")

        Dim bReturn As Boolean
        bReturn = insertMVTSTK()
        Return bReturn
    End Function 'insert
    '=======================================================================
    'Fonction : Update()
    'Description : Mise � jour de l'objet
    'D�tails    :  
    'Retour : Vrai di l'op�ration s'est bien d�roul�e
    '=======================================================================
    Friend Overrides Function update() As Boolean
        Debug.Assert(m_idProduit <> 0, "Le Produit n'est pas Renseign�")
        Debug.Assert(id <> 0, "id <> 0")
        Dim bReturn As Boolean
        bReturn = updateMVTSTK()
        Return bReturn

    End Function 'Update

    Public Shared Function getListeColisage(ByVal pidProduit As Integer, ByVal pidFactColisage As Integer) As List(Of mvtStock)
        '=======================================================================
        'Fonction : getListe()
        'Description : Rend une liste des mvt de stocks pour un facture de colisage
        'D�tails    :  Si ID Commande est renseign� alors on ajoute un filtre sur le type de Mvt = "2"
        '               Si ID BA est renseign� alors on ajoute un filtre sur le type de Mvt = "3"
        '               Sinon on retourne tous les mvts de stocks
        'Retour : collection des mouvements de stock
        '=======================================================================
        Dim colReturn As New List(Of mvtStock)

        Persist.shared_connect()
        colReturn = Persist.ListeMVTSTK_FACTCOL(pidProduit, pidFactColisage)
        Persist.shared_disconnect()
        Return colReturn
    End Function 'getListeColisage
    Public Shared Function getListe(ByVal pidProduit As Integer, Optional ByVal pidCmd As Integer = -1, Optional ByVal pidBA As Integer = -1) As ColEventSorted
        '=======================================================================
        'Fonction : getListe()
        'Description : Rend une liste des mvt de stocks
        'D�tails    :  Si ID Commande est renseign� alors on ajoute un filtre sur le type de Mvt = "2"
        '               Si ID BA est renseign� alors on ajoute un filtre sur le type de Mvt = "3"
        '               Sinon on retourne tous les mvts de stocks
        'Retour : collection des mouvements de stock
        '=======================================================================
        Dim colReturn As ColEventSorted

        Persist.shared_connect()
        If pidCmd <> -1 Then
            colReturn = Persist.ListeMVTSTK(pidProduit, vncEnums.vncTypeMvt.vncMvtCommandeClient, pidCmd)
        Else
            If pidBA <> -1 Then
                colReturn = Persist.ListeMVTSTK(pidProduit, vncEnums.vncTypeMvt.vncmvtBonAppro, pidBA)
            Else
                colReturn = Persist.ListeMVTSTK(pidProduit)
            End If
        End If
        Persist.shared_disconnect()
        Return colReturn
    End Function 'getListe
    ''' <summary>
    ''' Chargement de la liste des Mvt de stocks depuis le dernier inventaire
    ''' </summary>
    ''' <param name="pidProduit">ID du produit</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getListeDepuisDernMvtInventaire(ByVal pidProduit As Integer) As List(Of mvtStock)
        Dim colReturn As New List(Of mvtStock)

        Persist.shared_connect()
        colReturn = Persist.ListeMVTSTKDepuisDernMvtInventaire(pidProduit)
        Persist.shared_disconnect()
        Return colReturn
    End Function 'getListe

    Public Shared Function getListe2(ByVal pDateDebut As Date, ByVal pDateFin As Date, Optional ByVal pFournisseur As Fournisseur = Nothing, Optional ByVal pEtat As vncEtatMVTSTK = vncEtatMVTSTK.vncMVTSTK_Tous, Optional pdossier As String = "", Optional pbFiltreProduit As Boolean = True) As Collection
        '=======================================================================
        'Fonction : getListe()
        'Description : Rend une liste des mvt de stocks pour les produits en Stock avec un filtre �ventuel sur l'ID du fournisseur
        '           les stocks sont class� par ordre chronologique !!!
        'Retour : collection des mouvements de stock
        '=======================================================================
        Dim colReturn As Collection

        Persist.shared_connect()
        colReturn = Persist.ListeMVTSTK2(pDateDebut, pDateFin, pFournisseur, pbFiltreProduit, pEtat, pdossier)
        Persist.shared_disconnect()
        Return colReturn
    End Function 'getListe
    ''' <summary>
    ''' Rend la lmiste des Mouvements de stock non facture pour un Dossier
    ''' </summary>
    ''' <param name="pDossier"></param>
    ''' <param name="pDateDebut"></param>
    ''' <param name="pDateFin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getListeDossierNonFacture(pDossier As String, ByVal pDateDebut As Date, ByVal pDateFin As Date, pbFiltreProduit As Boolean) As Collection

        Dim colReturn As Collection

        Persist.shared_connect()
        colReturn = Persist.ListeMVTSTKDossier(pDossier, pDateDebut, pDateFin, vncEtatMVTSTK.vncMVTSTK_nFact, pbFiltreProduit)
        Persist.shared_disconnect()
        Return colReturn
    End Function 'getListeDossierNonFacture
    Public Shared Function getListeDossierFacture(pDossier As String, ByVal pDateDebut As Date, ByVal pDateFin As Date, pbFiltreProduit As Boolean) As Collection

        Dim colReturn As Collection

        Persist.shared_connect()
        colReturn = Persist.ListeMVTSTKDossier(pDossier, pDateDebut, pDateFin, vncEtatMVTSTK.vncMVTSTK_Fact, pbFiltreProduit)
        Persist.shared_disconnect()
        Return colReturn
    End Function 'getListeDossierFacture
    ''' <summary>
    ''' Regroupe les mouvements de stocks d'un produit d'une commande 
    ''' exemple : Mvt1 qte=22, mvt2 qte=2 pour le m�me produit, la m�me commande
    '''              => mvt1 qte = 24, mvt2 qte = 0
    ''' </summary>
    ''' <param name="pcolMvt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function regroupMvtStockmemecommande(pcolMvt As ColEventSorted) As List(Of mvtStock)

        Dim oReturn As New List(Of mvtStock)
        For Each omvt As mvtStock In pcolMvt
            oReturn.Add(omvt)
        Next

        For Each omvt As mvtStock In oReturn
            If Not omvt.bTraitee Then
                If omvt.typeMvt = vncTypeMvt.vncMvtCommandeClient Then
                    'R�cup�ration des Mvt de stock du m�me produit, m�me commande
                    Dim olstmvt2 As Object = From omvt2 In oReturn
                                                             Where omvt2.typeMvt = vncTypeMvt.vncMvtCommandeClient _
                                                             And omvt2.idProduit = omvt.idProduit _
                                                             And omvt2.idReference = omvt.idReference _
                                                             And omvt2.bTraitee = False
                                                             Select omvt2
                    For Each omvt2 As mvtStock In olstmvt2
                        If Not omvt.Equals(omvt2) Then
                            omvt.qte = omvt.qte + omvt2.qte
                            omvt2.qte = 0
                            omvt2.bTraitee = True
                        End If
                    Next


                End If
            End If
        Next omvt

        Return oReturn
    End Function

#End Region

    '=======================================================================
    'Fonction : shortResume()
    'Description : Rend l'objet sous forme de String
    'D�tails    :  
    'Retour : une Chaine
    '=======================================================================
    Public Overrides ReadOnly Property shortResume() As String
        Get
            Return m_date.ToShortDateString & "|" & m_qte & "|" & m_libelle
        End Get
    End Property

    '=======================================================================
    'Fonction : ToString()
    'Description : Rend l'objet sous forme de String
    'D�tails    :  
    'Retour : une Chaine
    '=======================================================================
    Public Overrides Function toString() As String
        Return "MVT =(" & m_TypeMvt & "," & m_idProduit & "," & m_date & "," & m_qte & "," & m_libelle & ")"
    End Function

    '=======================================================================
    'Fonction : Equals()
    'Description : Teste l'�quivalence entre 2 objets
    'D�tails    :  
    'Retour : Vari si l'objet pass� en param�tre est equivalent � 
    '=======================================================================
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim bReturn As Boolean
        Dim objMvt As mvtStock
        Try

            bReturn = obj.GetType.Name.Equals(Me.GetType().Name)
            objMvt = obj
            bReturn = MyBase.Equals(obj)
            bReturn = bReturn And (m_idProduit.Equals(objMvt.idProduit))
            bReturn = bReturn And (m_date.ToShortDateString.Equals(objMvt.datemvt.ToShortDateString))
            bReturn = bReturn And (m_TypeMvt.Equals(objMvt.typeMvt))
            bReturn = bReturn And (m_idReference.Equals(objMvt.idReference))
            bReturn = bReturn And (m_libelle.Equals(objMvt.libelle))
            bReturn = bReturn And (m_qte.Equals(objMvt.qte))
            bReturn = bReturn And (m_oCommentaire.comment.Equals(objMvt.Commentaire))
            bReturn = bReturn And (m_Etat.Equals(objMvt.Etat))
            bReturn = bReturn And (m_idFactColisage.Equals(objMvt.idFactColisage))

        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function 'Equals

    Public Sub changeEtat(ByVal pEtat As vncActionFactColisage)
        m_Etat = m_Etat.changeEtat(pEtat)
    End Sub

    Private m_oProduit As Produit = Nothing
    Public ReadOnly Property CodeProduit() As String
        Get
            If m_oProduit Is Nothing Then
                m_oProduit = Produit.createandload(idProduit)
            End If
            Return m_oProduit.code
        End Get
    End Property
    Public ReadOnly Property NomProduit() As String
        Get
            If m_oProduit Is Nothing Then
                m_oProduit = Produit.createandload(idProduit)
            End If
            Return m_oProduit.nom
        End Get
    End Property


End Class
