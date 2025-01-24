'Test de la classe dbConnection
Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports vini_DB



<TestClass()> Public Class T1060_Produit
    Inherits test_Base

    Private m_obj As Produit
    Private m_idPrd As Integer
    Private m_oFRN As Fournisseur
    Private m_idFRN As Integer

    <TestInitialize()> Public Overrides Sub TestInitialize()
        MyBase.TestInitialize()

        '            m_obj.shared_connect()
        m_oFRN = New Fournisseur("T1060PRD", "Test Produit")
        m_oFRN.Save()
        m_idFRN = m_oFRN.id
        m_obj = New Produit("", m_oFRN, 1990)
        m_obj.save()
        m_idPrd = m_obj.id
    End Sub
    <TestCleanup()> Public Overrides Sub TestCleanup()
        '           m_obj.shared_disconnect()

        m_obj = Produit.createandload(m_idPrd)
        If (Not m_obj Is Nothing) Then
            m_obj.bDeleted = True
            m_obj.save()
        End If
        m_oFRN = Fournisseur.createandload("T1060PRD")
        If (Not m_oFRN Is Nothing) Then

            m_oFRN.bDeleted = True
            m_oFRN.Save()
        End If

        MyBase.TestCleanup()
    End Sub
    <TestMethod()> Public Sub T10_Object()
        Dim objPRD As Produit

        'Test des Valeur par defaut
        Assert.AreEqual(m_obj.idConditionnement, Param.conditionnementdefaut.id)
        Assert.AreEqual(m_obj.idContenant, contenant.contenantDefaut.id)
        Assert.AreEqual(m_obj.idCouleur, Param.couleurdefaut.id)
        Assert.AreEqual(m_obj.idRegion, Param.regiondefaut.id)
        Assert.AreEqual(m_obj.idTVA, Param.TVAdefaut.id)
        m_obj.code = "CODE"
        m_obj.bDisponible = True
        m_obj.codeStat = "CODESTAT"
        m_obj.DateDernInventaire = Now()
        m_obj.millesime = 98
        m_obj.motcle = "MTCLE"
        m_obj.QteStock = 10
        m_obj.QteStockDernInventaire = 150
        m_obj.idCouleur = Param.colCouleur(Param.colCouleur.Count).id
        m_obj.Depot = "01"


        Assert.IsTrue(m_obj.Equals(m_obj), "Egal à Lui même")
        objPRD = New Produit("", m_oFRN, 1990)
        objPRD.code = "CODE"
        objPRD.bDisponible = True
        objPRD.codeStat = "CODESTAT"
        objPRD.DateDernInventaire = m_obj.DateDernInventaire
        objPRD.millesime = 98
        objPRD.motcle = "MTCLE"
        objPRD.QteStock = 10
        objPRD.QteStockDernInventaire = 150
        objPRD.idCouleur = Param.colCouleur(Param.colCouleur.Count).id


        ' Test non valide car l'obhet est sauvegardé dans le TestInitialize
        'Assert.IsTrue(m_obj.Equals(objPRD), "Egal à un semblable")

        objPRD.motcle = "MOTCLE2"
        Assert.IsFalse(m_obj.Equals(objPRD), "Egal à un Différent")
        Dim obj As Object
        Assert.IsFalse(m_obj.Equals(obj), "Egal autrecjhose")


    End Sub
    <TestMethod()> Public Sub T15_DB()
        Dim objPRD As Produit
        Dim objPRD2 As Produit
        Dim n As Integer

        'I - Création d'un Produit
        '=========================
        objPRD = New Produit("", New Fournisseur, 1990)
        Assert.AreEqual(CDec(0), objPRD.TarifA, "Tarif A")
        Assert.AreEqual(CDec(0), objPRD.TarifB, "Tarif B")
        Assert.AreEqual(CDec(0), objPRD.TarifC, "Tarif B")
        objPRD.code = "FTEST" & Now()
        objPRD.nom = "Produit de test'fklfdkl&é#'(-è_çà)=}}]@^\`|[{#~"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.bDisponible = False
        objPRD.bStock = False
        objPRD.codeStat = "CODESTAT"
        objPRD.DateDernInventaire = Now()
        objPRD.millesime = 98
        objPRD.motcle = "MOTCLE"
        objPRD.QteStock = 14
        objPRD.QteStockDernInventaire = 28
        objPRD.idCouleur = Param.colCouleur(Param.colCouleur.Count).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        Assert.AreEqual(CDec(11.5), objPRD.TarifA, " TarifA")
        Assert.AreEqual(CDec(12.5), objPRD.TarifB, " TarifB")
        Assert.AreEqual(CDec(13.5), objPRD.TarifC, "TarifC")
        objPRD.Depot = "01"


        'Test des indicateurs Avant le Save
        Assert.IsTrue(objPRD.bNew)
        Assert.IsTrue(objPRD.bUpdated)
        Assert.IsFalse(objPRD.bDeleted)
        'Save
        Assert.IsTrue(objPRD.save(), "Insert" & objPRD.getErreur)
        Assert.IsTrue((objPRD.id <> 0), "Id Apres le Save doit être différent de 0")
        'Test des indicateurs Après le Save
        Assert.IsFalse(objPRD.bNew, "bNew apres insert")
        Assert.IsFalse(objPRD.bUpdated, "bUpdated apres insert")
        Assert.IsFalse(objPRD.bDeleted, "bDeleted apres insert")

        'II - Rechargement d'un Produit
        '=========================
        n = objPRD.id
        objPRD2 = Produit.createandload(n)
        Assert.AreEqual(CDec(11.5), objPRD2.TarifA, "Load TarifA")
        Assert.AreEqual(CDec(12.5), objPRD2.TarifB, "Load TarifB")
        Assert.AreEqual(CDec(13.5), objPRD2.TarifC, "Load TarifC")
        Assert.AreEqual("01", objPRD2.Depot)
        Assert.IsTrue(objPRD.Equals(objPRD2))

        'III - Modification du Produit
        '=================================
        ' Modification du Produit
        objPRD2.nom = objPRD.nom & "2"
        objPRD2.bStock = True
        objPRD2.QteStock = 30
        objPRD2.idCouleur = Param.colCouleur(Param.colCouleur.Count - 1).id
        objPRD2.TarifA = 15.15
        objPRD2.TarifB = 16.16
        objPRD2.TarifC = 17.17
        objPRD2.Depot = "02"

        'Test des indicateurs Avant le Save
        Assert.IsFalse(objPRD2.bNew)
        Assert.IsTrue(objPRD2.bUpdated)
        Assert.IsFalse(objPRD2.bDeleted)
        'Save
        Assert.IsTrue(objPRD2.save(), "Update" & objPRD.getErreur)
        'Test des indicateurs Après le Save
        Assert.IsFalse(objPRD2.bNew, "bNew apres insert")
        Assert.IsFalse(objPRD2.bUpdated, "bUpdated apres insert")
        Assert.IsFalse(objPRD2.bDeleted, "bDeleted apres insert")

        'Rechargement de l'objet
        n = objPRD2.id
        objPRD = Produit.createandload(n)
        Assert.AreEqual(CDec(15.15), objPRD.TarifA, "Load TarifA")
        Assert.AreEqual(CDec(16.16), objPRD.TarifB, "Load TarifB")
        Assert.AreEqual(CDec(17.17), objPRD.TarifC, "Load TarifC")
        Assert.AreEqual("02", objPRD.Depot)
        Assert.IsTrue(objPRD.Equals(objPRD2))

        'IV - Suppression du Produit
        '=================================
        ' Modification du Produit
        objPRD.bDeleted = True
        Assert.IsTrue(objPRD.save(), "Delete" & objPRD.getErreur())
    End Sub
    <TestMethod()> Public Sub T51_ListeCriteres()
        Dim colPRD As Collection
        Dim oPRD As Produit
        Dim objPRD2 As Produit
        Dim objFRN As Fournisseur
        Dim objCLT As Client

        Persist.shared_connect()
        objFRN = New Fournisseur("FPRDT51" & Now(), "Mon Fournisseur")
        Assert.IsTrue(objFRN.Save())

        objPRD2 = New Produit("PRDT51", objFRN, 2004)
        objPRD2.nom = "MYPRODuct"
        objPRD2.motcle = "c'est"
        Assert.IsTrue(objPRD2.save())

        objCLT = New Client("CLPRDTT51" & Now(), "Monclient")
        Assert.IsTrue(objCLT.save())
        objCLT.ajouteLgPrecom(objPRD2, 10)
        Assert.IsTrue(objCLT.save())
        Persist.shared_disconnect()

        'I - Liste Simple
        '================
        Persist.shared_connect()
        colPRD = Produit.getListe(vncTypeProduit.vncTous, )
        Persist.shared_disconnect()
        Assert.IsTrue(colPRD.Count > 0, "Col.count > 0" & Persist.getErreur)
        For Each oPRD In colPRD
            Assert.IsTrue(oPRD.id <> 0, "ID <> 0")
            Assert.IsTrue(oPRD.bResume, "bResume = True")
            Persist.shared_connect()
            '               oPRD = Produit.createandload(oPRD.id)
        Next oPRD
        Persist.shared_disconnect()

        'II- Liste sur le code 
        '=============================
        'Console.Out.WriteLine("Liste sur le code")
        'a) Caractère générique
        Persist.shared_connect()
        colPRD = Produit.getListe(vncEnums.vncTypeProduit.vncTous, "PRD%")
        Assert.IsTrue(colPRD.Count > 0, "Col.count > 0")
        For Each oPRD In colPRD
            Assert.AreEqual(Left(oPRD.code, 3), "PRD", "Mauvais Code " & oPRD.code)
        Next oPRD
        'b) sans Caractère générique
        colPRD = Produit.getListe(vncEnums.vncTypeProduit.vncTous, "PRDT51")
        Assert.IsTrue(colPRD.Count > 0, "Col.count > 0" & Produit.getErreur)
        For Each oPRD In colPRD
            Assert.AreEqual(oPRD.code, "PRDT51", "Mauvais Code " & oPRD.code)
        Next oPRD
        Persist.shared_disconnect()

        'III- Liste sur le nom
        '=============================
        Persist.shared_connect()
        'Console.Out.WriteLine("Liste sur le nom")
        'a) Caractère générique
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , "MYPR%")
        Assert.IsTrue(colPRD.Count > 0, "Nom1:Col.count > 0" & Produit.getErreur)
        For Each oPRD In colPRD
            Assert.AreEqual(Left(oPRD.nom, 4), "MYPR")
        Next oPRD
        'b) sans Caractère générique
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , "MYPRODuct")
        Assert.IsTrue(colPRD.Count > 0, "Nom2:Col.count > 0")
        For Each oPRD In colPRD
            Assert.AreEqual(oPRD.nom, "MYPRODuct")
        Next oPRD
        Persist.shared_disconnect()

        'IV- Liste sur le Mot clé
        '=============================
        'Console.Out.WriteLine("Liste sur le motcle")
        'a) Caractère générique
        Persist.shared_connect()
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , "c'e%")
        Assert.IsTrue(colPRD.Count > 0, "MotClé1: Col.count > 0" & Produit.getErreur)
        For Each oPRD In colPRD
            objPRD2 = Produit.createandload(oPRD.id)
            Assert.AreEqual(Left(objPRD2.motcle, 3), "c'e")
        Next oPRD
        'b) sans Caractère générique
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , "c'est")
        Assert.IsTrue(colPRD.Count > 0, "Motclé2: Col.count > 0")
        For Each oPRD In colPRD
            objPRD2 = Produit.createandload(oPRD.id)
            Assert.AreEqual(objPRD2.motcle, "c'est")
        Next oPRD
        Persist.shared_disconnect()

        'V - Fournisseur
        '====================
        'Console.Out.WriteLine("Liste sur le Fourn")
        'a) Avec Résultat
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , , objFRN.id)
        Assert.IsTrue(colPRD.Count > 0, "Col.count > 0")
        For Each oPRD In colPRD
            objPRD2 = Produit.createandload(oPRD.id)
            Assert.AreEqual(objPRD2.idFournisseur, objFRN.id)
        Next oPRD
        'b) sans résultat
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , , 99999)
        Assert.IsTrue(colPRD.Count = 0, "Col.count = 0")

        'V - Client
        '====================
        'Console.Out.WriteLine("Liste sur le Client")
        'a) Avec Résultat
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , , , objCLT.id)
        'Assert.IsTrue(colPRD.Count > 0, "Col.count > 0")
        For Each oPRD In colPRD
            objPRD2 = Produit.createandload(oPRD.id)
            'Console.Out.WriteLine(oPRD.toString())
        Next oPRD
        'b) sans résultat
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , , , 334532)
        Assert.IsTrue(colPRD.Count = 0, "Col.count = 0")
        'VI - Critères Croisés
        '====================
        'a) Avec Résultat
        colPRD = Produit.getListe(vncTypeProduit.vncTous, "PRD%", "", "c'est%")
        'Assert.IsTrue(colPRD.Count > 0, "Col.count > 0")
        For Each oPRD In colPRD
            objPRD2 = Produit.createandload(oPRD.id)
            Assert.AreEqual(Left(oPRD.code, 3), "PRD")
            'Assert.AreEqual(Left(oPRD.libelle, 3) = "TEST", "Mauvais Nom " & oPRD.libelle)
            Assert.IsTrue(objPRD2.load(oPRD.id), "Load False id=" & oPRD.id)
            Assert.AreEqual(Left(objPRD2.motcle, 3), "c'e")
        Next oPRD

        'b) sans résultat
        colPRD = Produit.getListe(vncTypeProduit.vncTous, "AQWZSX%", "BIB%", "BERTI%")
        Assert.IsTrue(colPRD.Count = 0, "Col.count = 0")


        objCLT.bDeleted = True
        Assert.IsTrue(objCLT.save())

        objPRD2.bDeleted = True
        Assert.IsTrue(objPRD2.save())

        objFRN.bDeleted = True
        Assert.IsTrue(objFRN.Save())


    End Sub
    <TestMethod()> Public Sub T60_ListePrecommande()
        Dim objP1 As Produit
        Dim objP2 As Produit
        Dim objP3 As Produit
        Dim objP4 As Produit
        Dim objFRN As Fournisseur
        Dim objCLT As Client
        Dim colPRD As Collection


        objFRN = New Fournisseur("FRNTEST", "Fournisseur de Test")
        Assert.IsTrue(objFRN.Save())

        objP1 = New Produit("P1", objFRN, 2004)
        objP1.nom = "AAAAA"
        objP1.motcle = "CLE1"

        Assert.IsTrue(objP1.save())
        objP2 = New Produit("P2", objFRN, 2004)
        objP2.nom = "BBBB"
        objP2.motcle = "CLE1"
        Assert.IsTrue(objP2.save())
        objP3 = New Produit("P3", objFRN, 2004)
        objP3.nom = "CCCC"
        objP3.motcle = "CLE2"
        Assert.IsTrue(objP3.save())
        objP4 = New Produit("P4", objFRN, 2004)
        objP4.nom = "DDDD"
        Assert.IsTrue(objP4.save())

        objCLT = New Client("CLTEST", "Client Test")
        Assert.IsTrue(objCLT.save())

        'Ajout des produits dans la Precommande du client
        objCLT.ajouteLgPrecom(objP1)
        objCLT.ajouteLgPrecom(objP2)
        objCLT.ajouteLgPrecom(objP3)
        Assert.IsTrue(objCLT.save())

        'Recherche des produit de la preccommande
        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , , , objCLT.id)
        Assert.AreEqual(3, colPRD.Count, "getListe(id)")
        Assert.IsTrue(Not colPRD("P1") Is Nothing, "P1=")
        Assert.IsTrue(Not colPRD("P2") Is Nothing, "P2=")
        Assert.IsTrue(Not colPRD("P3") Is Nothing, "P3=")

        colPRD = Produit.getListe(vncTypeProduit.vncTous, "P%", , , , objCLT.id)
        Assert.AreEqual(3, colPRD.Count, "getListe(Code,,id)")
        Assert.IsTrue(Not colPRD("P1") Is Nothing, "P1=")
        Assert.IsTrue(Not colPRD("P2") Is Nothing, "P2=")
        Assert.IsTrue(Not colPRD("P3") Is Nothing, "P3=")

        colPRD = Produit.getListe(vncTypeProduit.vncTous, , "A%", , , objCLT.id)
        Assert.AreEqual(1, colPRD.Count, "getListe(,nom,,id)")
        Assert.IsTrue(Not colPRD("P1") Is Nothing, "P1=")

        colPRD = Produit.getListe(vncTypeProduit.vncTous, , , "CLE1", , objCLT.id)
        Assert.AreEqual(2, colPRD.Count, "getListe(,,motCle,,id)")
        Assert.IsTrue(Not colPRD("P1") Is Nothing, "P1=")
        Assert.IsTrue(Not colPRD("P2") Is Nothing, "P2=")

        colPRD = Produit.getListe(vncTypeProduit.vncTous, "P1%", , "CLE1", , objCLT.id)
        Assert.AreEqual(1, colPRD.Count, "getListe(,,motCle,,id)")
        Assert.IsTrue(Not colPRD("P1") Is Nothing, "P1=")

        colPRD = Produit.getListe(vncTypeProduit.vncTous, , "B%", "CLE1", , objCLT.id)
        Assert.AreEqual(1, colPRD.Count, "getListe(,,motCle,,id)")
        Assert.IsTrue(Not colPRD("P2") Is Nothing, "P2=")

        objCLT.bDeleted = True
        Assert.IsTrue(objCLT.save())

        objP1.bDeleted = True
        Assert.IsTrue(objP1.save)
        objP2.bDeleted = True
        Assert.IsTrue(objP2.save)
        objP3.bDeleted = True
        Assert.IsTrue(objP3.save)
        objP4.bDeleted = True
        Assert.IsTrue(objP4.save)

        objFRN.bDeleted = True
        Assert.IsTrue(objFRN.Save)

    End Sub
    'Test la sauvegarde des champs long
    <TestMethod()> Public Sub T60_Champslongs()

        Dim obj As Produit
        obj = New Produit("T60", m_oFRN, 1990)
        obj.nom = "TEST".PadRight(500, "x")

        Assert.IsTrue(obj.Save())
        obj.motcle = "TEST2".PadRight(500, "y")
        Assert.IsTrue(obj.Save())
        obj.load()
        Assert.AreEqual(50, obj.nom.Length)
        Assert.AreEqual(50, obj.motcle.Length)

        obj.bDeleted = True
        obj.Save()

    End Sub

    ''' <summary>
    ''' Test du champs dOssier
    ''' </summary>
    <TestMethod()> Public Sub T70_ChampsDossier()

        Dim obj As Produit
        Dim nid As Integer

        obj = New Produit("T60", m_oFRN, 1990)
        Assert.AreEqual(Dossier.VINICOM, obj.DossierProduit)
        obj.DossierProduit = Dossier.HOBIVIN
        Assert.IsTrue(obj.save())
        nid = obj.id
        obj = Produit.createandload(nid)

        Assert.AreEqual(Dossier.HOBIVIN, obj.DossierProduit)

        obj.DossierProduit = Dossier.VINICOM
        Assert.IsTrue(obj.save())
        obj = Produit.createandload(nid)

        Assert.AreEqual(Dossier.VINICOM, obj.DossierProduit)


        obj.bDeleted = True
        obj.save()

    End Sub
    <TestCategory("V5.9.3")>
    <TestMethod()>
    Public Sub T71_ProduitLoadCouleurContenant()

        Dim obj As Produit
        Dim nid As Integer

        obj = New Produit("T71", m_oFRN, 1990)
        Dim oParam As Param
        oParam = Param.colCouleur(1)
        Dim strLibCouleur As String
        obj.idCouleur = oParam.id
        strLibCouleur = oParam.valeur
        Dim oCont As contenant = contenant.colContenant(1)
        Dim strLibCont As String
        strLibCont = oCont.libelle
        obj.idContenant = oCont.id


        Assert.IsTrue(obj.save())

        nid = obj.id
        Dim oCol As Collection
        oCol = Produit.getListe(vncTypeProduit.vncTous, "T71")
        obj = oCol(1)

        Assert.AreEqual(strLibCouleur, obj.libCouleur)
        Assert.AreEqual(strLibCont, obj.libContenant)


        obj.bDeleted = True
        obj.save()

    End Sub

    ''' <summary>
    ''' Test LoadLight du champs dOssier
    ''' </summary>
    <TestCategory("5.9.7.4")>
    <TestMethod()> Public Sub T70_ChampsDossierLight()

        Dim obj As Produit
        Dim nid As Integer

        obj = New Produit("PRDTEST", m_oFRN, 1990)
        obj.DossierProduit = Dossier.HOBIVIN
        Assert.IsTrue(obj.save())
        nid = obj.id
        obj = New Produit()
        obj.DBLoad2(nid)
        Assert.AreEqual(Dossier.HOBIVIN, obj.DossierProduit)
        Assert.IsTrue(obj.save())

        obj = New Produit()
        obj = Produit.createandload(nid)
        Assert.AreEqual(Dossier.HOBIVIN, obj.DossierProduit)


        obj.bDeleted = True
        obj.save()

    End Sub
    ''' <summary>
    ''' Test la propriété Qtecolis
    ''' </summary>
    <TestCategory("5.9.7.4")>
    <TestMethod()> Public Sub T70_Qtecolis()

        Dim obj As Produit
        Dim objcond As Param

        'Création d'un conditionnement pour 6 blle
        If Not Param.colConditionnement.Contains("x6") Then
            objcond = New Param
            objcond.type = PAR_CONDITIONNEMENT
            objcond.code = "x6"
            objcond.valeur = 6
            objcond.defaut = True
            objcond.Save()
        End If
        Param.LoadcolParams()
        objcond = Param.conditionnementdefaut

        obj = New Produit("PRDTEST", m_oFRN, 1990)
        Assert.IsTrue(obj.save())

        Assert.AreEqual(0, obj.qteColis(0))
        Assert.AreEqual(1, obj.qteColis(5))
        Assert.AreEqual(1, obj.qteColis(6))
        Assert.AreEqual(2, obj.qteColis(7))
        Assert.AreEqual(2, obj.qteColis(12))

        Assert.AreEqual(-1, obj.qteColis(-5))
        Assert.AreEqual(-1, obj.qteColis(-6))
        Assert.AreEqual(-2, obj.qteColis(-7))
        Assert.AreEqual(-2, obj.qteColis(-12))

    End Sub
    <TestMethod()> Public Sub T15_TARIFD()
        Dim objPRD As Produit
        Dim objPRD2 As Produit
        Dim n As Integer

        'I - Création d'un Produit
        '=========================
        objPRD = New Produit("PRDTESTTARIFD", Fournisseur.getListe()(1), 1990)
        objPRD.idCouleur = Param.colCouleur(Param.colCouleur.Count).id


        Assert.AreEqual(CDec(0), objPRD.TarifD, "Tarif D")
        objPRD.TarifD = 14.5
        Assert.AreEqual(CDec(14.5), objPRD.TarifD, " TarifD")
        'Save
        Assert.IsTrue(objPRD.save(), "Insert" & objPRD.getErreur)

        'II - Rechargement d'un Produit
        '=========================
        n = objPRD.id
        objPRD2 = Produit.createandload(n)
        Assert.AreEqual(CDec(14.5), objPRD2.TarifD, "Load TarifD")
        Assert.IsTrue(objPRD.Equals(objPRD2))

        'III - Modification du Produit
        '=================================
        ' Modification du Produit
        objPRD2.TarifD = 18.17

        Assert.IsTrue(objPRD2.save(), "Update" & objPRD.getErreur)
        'Rechargement de l'objet
        n = objPRD2.id
        objPRD = Produit.createandload(n)
        Assert.AreEqual(CDec(18.17), objPRD.TarifD, "Load TarifD")
        Assert.IsTrue(objPRD.Equals(objPRD2))


        '
        objPRD.TarifA = 10.5
        objPRD.TarifB = 11.5
        objPRD.TarifC = 12.5
        objPRD.TarifD = 13.5


        Assert.AreEqual(13.5D, objPRD.Tarif("D"))


        'IV - Suppression du Produit
        '=================================
        ' Modification du Produit
        objPRD.bDeleted = True
        Assert.IsTrue(objPRD.save(), "Delete" & objPRD.getErreur())
    End Sub
    <TestCategory("6.1.0.0")>
    <TestMethod()> Public Sub TV61_BARCHIVE()
        Dim objPRD As Produit
        Dim objPRD2 As Produit
        Dim n As Integer
        Dim nIdFournisseur As Integer
        nIdFournisseur = Fournisseur.getListe()(1).id

        'I - Création d'un Produit
        '=========================
        objPRD = New Produit("", New Fournisseur, 1990)
        Assert.AreEqual(False, objPRD.bArchive)
        objPRD.code = "PTEST" & Now()
        objPRD.nom = "Produit de TEST ARCHIVE"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        objPRD.bArchive = True

        'Save
        Assert.IsTrue(objPRD.save(), "Insert")

        'II - Rechargement d'un Produit
        '=========================
        n = objPRD.id
        objPRD2 = Produit.createandload(n)
        Assert.IsTrue(objPRD2.bArchive, "Load bArchive")
        Assert.IsTrue(objPRD.Equals(objPRD2))

        'III - Modification du Produit
        '=================================
        ' Modification du Produit
        objPRD2.nom = objPRD.nom & "2"
        objPRD2.bArchive = False
        Assert.IsTrue(objPRD2.save(), "Update")

        'Rechargement de l'objet
        n = objPRD2.id
        objPRD = Produit.createandload(n)
        Assert.IsFalse(objPRD.bArchive)
        Assert.IsTrue(objPRD.Equals(objPRD2))


        Dim oColProduit As Collection = Produit.getListe(vncTypeProduit.vncTous, strCode:="PTEST%", idFournisseur:=nIdFournisseur, pTous:=False)
        Assert.AreEqual(1, oColProduit.Count)

        'Archivage du produit
        objPRD2.bArchive = True
        Assert.IsTrue(objPRD2.save(), "Update")
        'Rechargement de la liste normale
        oColProduit = Produit.getListe(vncTypeProduit.vncTous, strCode:="PTEST%", idFournisseur:=nIdFournisseur, pTous:=False)
        'Verif => il n'est pas dans la liste
        Assert.AreEqual(0, oColProduit.Count)

        'Rechargement de la liste Avec Tous les produits
        oColProduit = Produit.getListe(vncTypeProduit.vncTous, strCode:="PTEST%", idFournisseur:=nIdFournisseur, pTous:=True)
        Assert.AreEqual(1, oColProduit.Count)

        'IV - Suppression du Produit
        '=================================
        ' Modification du Produit
        objPRD.bDeleted = True
        Assert.IsTrue(objPRD.save(), "Delete" & objPRD.getErreur())
    End Sub

    <TestCategory("6.1.0.0")>
    <TestMethod()> Public Sub TV61_RACINE()
        Dim oPrd As New Produit()
        oPrd.code = "01123M98"
        Assert.AreEqual("01123", oPrd.RacineCode)
        Assert.IsTrue(oPrd.bMillesimeCode)
        Assert.AreEqual("M98", oPrd.MillesimeCode)
        oPrd.code = "01123MA1"
        Assert.AreEqual("01123MA1", oPrd.RacineCode)
        Assert.IsFalse(oPrd.bMillesimeCode)
        Assert.AreEqual("", oPrd.MillesimeCode)
        oPrd.code = "01123456"
        Assert.AreEqual("01123456", oPrd.RacineCode)
        Assert.IsFalse(oPrd.bMillesimeCode)
        Assert.AreEqual("", oPrd.MillesimeCode)

        oPrd.code = "01123M98"
        oPrd.MillesimeCode = "M99"
        'Modification Code
        Assert.AreEqual("01123M99", oPrd.code)
        oPrd.MillesimeCode = "21"
        'Pas de modif de code => Millésime non conforme
        Assert.AreEqual("01123M99", oPrd.code)
        oPrd.code = "0112398"
        oPrd.MillesimeCode = "M99"
        'Pas de modif de code => code non corforme
        Assert.AreEqual("0112398", oPrd.code)



    End Sub
    <TestCategory("6.1.0.0")>
    <TestMethod()> Public Sub TV61_IsCodeExistant()
        Dim objPRD As Produit
        Dim objPRD2 As Produit
        Dim n As Integer
        Dim nIdFournisseur As Integer
        nIdFournisseur = Fournisseur.getListe()(1).id

        'I - Création d'un Produit
        '=========================
        objPRD = New Produit("", New Fournisseur, 1990)
        Assert.AreEqual(False, objPRD.bArchive)
        objPRD.code = "PTEST" & Now()
        objPRD.nom = "Produit de TEST ARCHIVE"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        objPRD.bArchive = True

        'le code Produit n'existe pas pour un autre produit
        Assert.IsFalse(objPRD.isCodeExistant())

        'Save
        Assert.IsTrue(objPRD.save(), "Insert")

        'le code Produit n'existe pas pour un autre produit après le Save
        Assert.IsFalse(objPRD.isCodeExistant())

        objPRD2 = New Produit()
        objPRD.code = objPRD.code

        'le code Produit existe pour un autre produit 
        Assert.IsTrue(objPRD2.isCodeExistant())

    End Sub
    <TestCategory("6.1.0.0")>
    <TestMethod()> Public Sub TV61_LOADBYKEYSTAT()
        Dim objPRD As Produit
        Dim n As Integer
        Dim nIdFournisseur As Integer
        nIdFournisseur = Fournisseur.getListe()(1).id

        'I - Création d'un Produit
        '=========================
        objPRD = New Produit("", New Fournisseur, 1990)
        Assert.AreEqual(False, objPRD.bArchive)
        Dim strCode As String = "PTEST" & Now()
        objPRD.code = strCode
        Dim strCodestat As String = "PSTAT" & Now()
        objPRD.codeStat = strCodestat
        objPRD.nom = "Produit de TEST ARCHIVE"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"

        'Save
        Assert.IsTrue(objPRD.save(), "Insert")

        'On retrouve le produit si on charge par le code
        objPRD = Produit.createandloadbyKey(strCode)
        Assert.IsNotNull(objPRD)

        'On ne retrouve pas le produit si on charge par le codestat
        objPRD = Produit.createandloadbyKey(strCodestat)
        Assert.IsNull(objPRD)

        'On retrouve le produit si on charge par le codestat en lui demandant de vérifier le code stat
        objPRD = Produit.createandloadbyKey(strCodestat, True)
        Assert.IsNotNull(objPRD)


        objPRD.delete()

    End Sub
    ''' <summary>
    ''' Test la recherche de produit pas le code Stat
    ''' Le plus ancien avec un stock positif
    ''' </summary>
    <TestCategory("6.1.0.0")>
    <TestMethod()> Public Sub TV61_LOADBYKEYSTAT_WOO()
        Dim objPRD As Produit
        Dim n As Integer
        Dim nIdFournisseur As Integer
        Dim strCodestat As String = "PSTAT"
        nIdFournisseur = Fournisseur.getListe()(1).id

        'I - Création d'un Produit Millesime 21 Qte = 10
        objPRD = New Produit("TESTM21", New Fournisseur, 2021)
        objPRD.codeStat = strCodestat
        objPRD.nom = "Produit de TEST MILLESIME21"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        'Save
        Assert.IsTrue(objPRD.save(), "Insert")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock initial", 10)
        Assert.IsTrue(objPRD.save(), "Update")

        'I - Création d'un Produit Millesime 20 Qte = 0
        objPRD = New Produit("TESTM20", New Fournisseur, 2021)
        objPRD.codeStat = strCodestat
        objPRD.nom = "Produit de TEST MILLESIME20"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        'Save
        Assert.IsTrue(objPRD.save(), "Insert")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock initial", 0)
        Assert.IsTrue(objPRD.save(), "Update")

        'I - Création d'un Produit Millesime 22 Qte = 15
        objPRD = New Produit("TESTM22", New Fournisseur, 2022)
        objPRD.codeStat = strCodestat
        objPRD.nom = "Produit de TEST MILLESIME22"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        'Save
        Assert.IsTrue(objPRD.save(), "Insert")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock initial", 15)
        Assert.IsTrue(objPRD.save(), "Update")

        'On retrouve le produit si on charge par le code
        objPRD = Produit.getProduitParCodestat(strCodestat)
        Assert.IsNotNull(objPRD)
        Assert.AreEqual("TESTM21", objPRD.code)
        Assert.AreEqual(10D, objPRD.QteStock)

        'Si le TESTM21 Passe en stock à 0 => Alors c'est le M22 qui est sélectionné
        objPRD = Produit.createandloadbyKey("TESTM21")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-02"), vncTypeMvt.vncmvtRegul, 0, "Regul -10", -10)
        Assert.IsTrue(objPRD.save(), "Update")
        'On retrouve le produit si on charge par le code
        objPRD = Produit.getProduitParCodestat(strCodestat)
        Assert.IsNotNull(objPRD)
        Assert.AreEqual("TESTM22", objPRD.code)
        Assert.AreEqual(15D, objPRD.QteStock)



        'Sil n'y a qu'unseul produit pour le code Stat on le renvoie sans regarder le Stock
        'I - Création d'un Produit Millesime 22 Qte = 15
        objPRD = New Produit("TESTM23", New Fournisseur, 2023)
        objPRD.codeStat = "STAT2"
        objPRD.nom = "Produit de TEST MILLESIME23"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        'Save
        Assert.IsTrue(objPRD.save(), "Insert")
        objPRD.ajouteLigneMvtStock(CDate("2020-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock initial", 0)
        Assert.IsTrue(objPRD.save(), "Update")

        objPRD = Produit.getProduitParCodestat("STAT2")
        Assert.IsNotNull(objPRD)
        Assert.AreEqual("TESTM23", objPRD.code)
        Assert.AreEqual(0D, objPRD.QteStock)



    End Sub
    ''' <summary>
    ''' Test la recherche de produit pas le code Stat
    ''' Si tous les produits ont un stock inf à 0 on prends le plus récent
    ''' </summary>
    <TestCategory("6.1.0.0")>
    <TestMethod()> Public Sub TV61_LOADBYKEYSTAT_WOO2()
        Dim objPRD As Produit
        Dim n As Integer
        Dim nIdFournisseur As Integer
        Dim strCodestat As String = "PSTAT"
        nIdFournisseur = Fournisseur.getListe()(1).id

        'I - Création d'un Produit Millesime 21 Qte = -10
        objPRD = New Produit("TESTM21", New Fournisseur, 2021)
        objPRD.codeStat = strCodestat
        objPRD.nom = "Produit de TEST MILLESIME21"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        'Save
        Assert.IsTrue(objPRD.save(), "Insert")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock initial", -10)
        Assert.IsTrue(objPRD.save(), "Update")

        'I - Création d'un Produit Millesime 20 Qte = 0
        objPRD = New Produit("TESTM20", New Fournisseur, 2020)
        objPRD.codeStat = strCodestat
        objPRD.nom = "Produit de TEST MILLESIME20"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        'Save
        Assert.IsTrue(objPRD.save(), "Insert")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock initial", 0)
        Assert.IsTrue(objPRD.save(), "Update")

        'I - Création d'un Produit Millesime 22 Qte = -15
        objPRD = New Produit("TESTM22", New Fournisseur, 2022)
        objPRD.codeStat = strCodestat
        objPRD.nom = "Produit de TEST MILLESIME22"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        'Save
        Assert.IsTrue(objPRD.save(), "Insert")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock initial", -15)
        Assert.IsTrue(objPRD.save(), "Update")

        'On retrouve le produit le plus récent si on charge par le code Stat
        objPRD = Produit.getProduitParCodestat(strCodestat)
        Assert.IsNotNull(objPRD)
        Assert.AreEqual("TESTM22", objPRD.code)
        Assert.AreEqual(-15D, objPRD.QteStock)

        'Si le TESTM21 Passe en stock à 10 => Alors c'est le M22 qui est sélectionné
        objPRD = Produit.createandloadbyKey("TESTM21")
        objPRD.loadcolmvtStock()
        objPRD.ajouteLigneMvtStock(CDate("2020-01-02"), vncTypeMvt.vncmvtRegul, 0, "Regul +20", +20)
        Assert.IsTrue(objPRD.save(), "Update")
        'On retrouve le produit si on charge par le code
        objPRD = Produit.getProduitParCodestat(strCodestat)
        Assert.IsNotNull(objPRD)
        Assert.AreEqual("TESTM21", objPRD.code)
        Assert.AreEqual(10D, objPRD.QteStock)






    End Sub
    <TestMethod()> Public Sub TstFactColisageLight()
        Dim objPRD As Produit
        Dim objPRD2 As Produit
        Dim n As Integer
        Dim nIdFournisseur As Integer
        nIdFournisseur = Fournisseur.getListe()(1).id

        'I - Création d'un Produit
        '=========================
        objPRD = New Produit("", New Fournisseur, 1990)
        Assert.AreEqual(False, objPRD.bArchive)
        objPRD.code = "PTEST" & Now()
        objPRD.nom = "Produit de TEST ARCHIVE"
        objPRD.idFournisseur = Fournisseur.getListe()(1).id
        objPRD.TarifA = 11.5
        objPRD.TarifB = 12.5
        objPRD.TarifC = 13.5
        objPRD.Depot = "01"
        objPRD.bStock = True
        objPRD.bFactureColisage = True

        'Save
        Assert.IsTrue(objPRD.save(), "Insert")

        'II - Rechargement d'un Produit en mode Light
        '=========================
        Dim oPRD2 As New Produit()
        oPRD2.DBLoad2(objPRD.id)

        'III - Modification du Produit
        '=================================
        ' Modification du Produit
        oPRD2.nom = objPRD.nom & "2"
        Assert.IsTrue(oPRD2.save(), "Update")

        'Rechargement de l'objet
        objPRD = Produit.createandload(oPRD2.id)
        Assert.IsTrue(objPRD.bStock)
        Assert.IsTrue(objPRD.bFactureColisage)


        'IV - Suppression du Produit
        '=================================
        ' Modification du Produit
        objPRD.bDeleted = True
        Assert.IsTrue(objPRD.save(), "Delete" & objPRD.getErreur())

    End Sub
End Class



