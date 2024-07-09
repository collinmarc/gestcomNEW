'Test de la classe ftpwininet
Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports vini_DB

<TestClass()> Public Class test_WooFTP
    Inherits test_Base
    <TestMethod()> Public Sub importCMDWoo()
        Dim pDossierLocal As String
        Dim oFTP As New clsFTPVinicom("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")
        oFTP.uploadFile("DATATEST/4638_20220923010646.xml")

        pDossierLocal = "./importinternet/vinicom.wine/" & Now.ToString("yyyyMMddHHmmss")

        'on fait l'import juste pour parcourir les fichier du FTP
        cmdwoo.SetFTP("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")

        Assert.IsTrue(cmdwoo.Import(pDossierLocal))

        ''-- =================
        ''-- Chargement d'un fichier 
        ''=======================
        'Parcours de fichiers téléchargés
        Dim tabFiles As String() = System.IO.Directory.GetFiles(pDossierLocal, "*.xml")
        For Each strFile As String In tabFiles
            Dim oFileInfo As New System.IO.FileInfo(strFile)
            Dim oCmd As cmdwoo
            oCmd = cmdwoo.readXML(oFileInfo.FullName)
            Assert.IsNotNull(oCmd)
            Assert.IsNotNull(oCmd.entete.customer_id)
            Assert.AreEqual("nouvoitou", oCmd.client.adresse_livraison.livraison_city)
            Assert.AreEqual(2, oCmd.lignes_commande.Count())
            Assert.AreEqual("028008", oCmd.lignes_commande(0).reference)
            Assert.AreEqual("028009", oCmd.lignes_commande(1).reference)
        Next

    End Sub
    <TestMethod()> Public Sub ExportCMDWoo()
        Dim oCmd As New cmdwoo()
        Dim oLg As New ligneWOO("123", 10, 15.5)
        oCmd.lignes_commande.Add(oLg)
        oLg = New ligneWOO("456", 20, 25.5)
        oCmd.lignes_commande.Add(oLg)


        cmdwoo.FTO_writeXml(oCmd, "cmdwoo.xml")

        Assert.IsTrue(IO.File.Exists("cmdwoo.xml"))
    End Sub
    <TestMethod()> Public Sub importCMDimport()
        Dim pDossierLocal As String
        Dim oFTP As New clsFTPVinicom("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")
        oFTP.uploadFile("DATATEST/4638_20220923010646.xml")

        pDossierLocal = "./importinternet/vinicom.wine/" & Now.ToString("yyyyMMddHHmmss")

        cmdwoo.SetFTP("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")
        Assert.IsTrue(cmdwoo.Import(pDossierLocal))
    End Sub

    <TestMethod()> Public Sub creationImportationCommande()

        'Création d'un client
        Dim oClt As New Client
        oClt.idPrestashop = 9915
        oClt.code = "CLT1"
        oClt.Origine = "VINICOM"
        oClt.AdresseLivraison.ville = "chasné sur illet"
        Assert.IsTrue(oClt.save)
        'Création d'un Fournisseur
        Dim oFRN As New Fournisseur("FRN1", "Fournisseur1")
        oFRN.Save()
        'Création d'un produit
        Dim oPrd As New Produit("PRD1", oFRN, 2000)
        oPrd.save()


        'Création d'une commande WOO FICTIVE pour pouvoir l'exporter
        Dim oCmd As New cmdwoo()

        oCmd.entete.id = "999"
        oCmd.entete.num_cde_woocommerce = "132"
        oCmd.entete.origine = "VINICOM"
        oCmd.entete.customer_id = oClt.idPrestashop
        oCmd.entete.datecmd = Now.ToString("yyyyMMdd")
        oCmd.client.adresse_livraison.livraison_city = "Chasné sur illet"
        oCmd.lignes_commande.Add(New ligneWOO("PRD1", 36, 132.5))
        oCmd.lignes_commande.Add(New ligneWOO("PRD1", 136, 232.5))
        'Export de la commande
        cmdwoo.FTO_writeXml(oCmd, "./cmdWoo.xml")
        'Transfert sur le site FTP
        Dim oFTP As New clsFTPVinicom("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")
        oFTP.uploadFile("./cmdwoo.xml")

        ''===============================
        '' IMPORT DE LA COMMANDE
        '================================
        Dim pDossierLocal As String
        pDossierLocal = "./importinternet/vinicom.wine/" & Now.ToString("yyyyMMddHHmmss")

        cmdwoo.SetFTP("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")

        Assert.IsTrue(cmdwoo.Import(pDossierLocal))

        'Ily a une Commande d'importées
        Assert.AreEqual(1, cmdwoo.ListeCommandes.Count)
        'Récupération de la commande importée
        Dim oCmdC As CommandeClient
        oCmdC = cmdwoo.ListeCommandes(0)

        Assert.IsFalse(String.IsNullOrEmpty(oCmdC.code))
        Assert.AreEqual(132L, oCmdC.IDPrestashop)

        Assert.AreEqual(oClt.idPrestashop, oCmdC.oTiers.idPrestashop)
        Assert.AreEqual(oClt.AdresseLivraisonVille, oCmdC.oTiers.AdresseLivraisonVille)

        Assert.AreEqual(2, oCmdC.colLignes.Count())
        Dim oLgC As LgCommande
        oLgC = oCmdC.colLignes(1)
        Assert.AreEqual(oPrd.code, oLgC.oProduit.code)
        Assert.AreEqual(36D, oLgC.qteCommande)
        Assert.AreEqual(132.5D, oLgC.prixU)

        oLgC = oCmdC.colLignes(2)
        Assert.AreEqual(oPrd.code, oLgC.oProduit.code)
        Assert.AreEqual(136D, oLgC.qteCommande)
        Assert.AreEqual(232.5D, oLgC.prixU)
    End Sub
    <TestMethod()> Public Sub TriLogImport()

        '============================
        ' CREATION DU CONTEXTE
        '===========================
        'Création d'un client
        Dim oClt As New Client
        oClt.idPrestashop = 9915
        oClt.code = "CLT1"
        oClt.Origine = "VINICOM"
        oClt.AdresseLivraison.ville = "chasné sur illet"
        Assert.IsTrue(oClt.save)
        'Création d'un Fournisseur
        Dim oFRN As New Fournisseur("FRN1", "Fournisseur1")
        oFRN.Save()
        'Création d'un produit
        Dim oPrd As New Produit("PRD1", oFRN, 2000)
        oPrd.save()
        'Création d'une commande WOO FICTIVE pour pouvoir l'exporter
        Dim oCmd As New cmdwoo()

        oCmd.entete.id = "999"
        oCmd.entete.num_cde_woocommerce = "132"
        oCmd.entete.origine = "VINICOM"
        oCmd.entete.customer_id = oClt.idPrestashop
        oCmd.entete.datecmd = Now.ToString("yyyyMMdd")
        oCmd.client.adresse_livraison.livraison_city = "Chasné sur illet"
        oCmd.lignes_commande.Add(New ligneWOO("PRD1", 36, 132.5))
        oCmd.lignes_commande.Add(New ligneWOO("PRD1", 136, 232.5))
        'Export de la commande
        cmdwoo.FTO_writeXml(oCmd, "./cmdWoo.xml")
        'Transfert sur le site FTP
        Dim oFTP As New clsFTPVinicom("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")
        oFTP.uploadFile("./cmdwoo.xml")

        ''===============================
        '' IMPORT 1 DE LA COMMANDE
        '================================
        Dim pDossierLocal As String
        pDossierLocal = "./importinternet/vinicom.wine/" & Now.ToString("yyyyMMddHHmmss")

        cmdwoo.SetFTP("ftp.cluster002.hosting.ovh.net", "vinicomwgs-gestcom", "EdcRfv11", "TEST/Orders")
        'Import dans supprimer le fichier d'origine
        Assert.IsTrue(cmdwoo.Import(pDossierLocal, False))

        System.Threading.Thread.Sleep(1000)
        Dim DateLimite As Date = Now()

        'On recommence l'import  après 2 Seconde
        System.Threading.Thread.Sleep(2000)
        Assert.IsTrue(cmdwoo.Import(pDossierLocal, True))

        'On vérifie que le Premier Item est bien le plus recent
        LogImportWoo.ReadXml()
        Assert.IsTrue(LogImportWoo.ListItems.ListItems.Count >= 2)
        Assert.IsTrue(LogImportWoo.ListItems.ListItems(0).DateImport > LogImportWoo.ListItems.ListItems(1).DateImport)

        'Purge des items avant le Dernier import
        LogImportWoo.PurgeAvant(DateLimite)
        Assert.AreEqual(2, LogImportWoo.ListItems.ListItems.Count)
        'LogImportWoo.writeXml()

    End Sub
    <TestMethod()> Public Sub creationCommande()

        'Création d'un client
        Dim oClt As New Client
        oClt.idPrestashop = 9915
        oClt.code = "CLT1"
        oClt.Origine = "VINICOM"
        oClt.AdresseLivraison.ville = "chasné sur illet"
        Assert.IsTrue(oClt.save)
        'Création d'un Fournisseur
        Dim oFRN As New Fournisseur("FRN1", "Fournisseur1")
        Assert.IsTrue(oFRN.Save())
        'Création d'un produit
        Dim oPrd As New Produit("PRD1M21", oFRN, 2021)
        oPrd.codeStat = "PRD1"
        Assert.IsTrue(oPrd.save())
        oPrd.loadcolmvtStock()
        oPrd.ajouteLigneMvtStock(CDate("2021-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock Initial", 10)
        Assert.IsTrue(oPrd.save())
        'Création d'un produit
        oPrd = New Produit("PRD1M22", oFRN, 2022)
        oPrd.codeStat = "PRD1"
        Assert.IsTrue(oPrd.save())
        oPrd.loadcolmvtStock()
        oPrd.ajouteLigneMvtStock(CDate("2022-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock Initial", 15)
        Assert.IsTrue(oPrd.save())

        'Création d'un produit
        oPrd = New Produit("PRD2M23", oFRN, 2023)
        oPrd.codeStat = "PRD2"
        Assert.IsTrue(oPrd.save())
        oPrd.loadcolmvtStock()
        oPrd.ajouteLigneMvtStock(CDate("2023-01-01"), vncTypeMvt.vncMvtInventaire, 0, "Stock Initial", 15)
        Assert.IsTrue(oPrd.save())

        'Création d'une commande WOO FICTIVE pour pouvoir l'exporter
        Dim oCmdWoo As New cmdwoo()

        oCmdWoo.entete.id = "999"
        oCmdWoo.entete.num_cde_woocommerce = "132"
        oCmdWoo.entete.origine = "VINICOM"
        oCmdWoo.entete.customer_id = oClt.idPrestashop
        oCmdWoo.entete.datecmd = Now.ToString("yyyyMMdd")
        oCmdWoo.client.adresse_livraison.livraison_city = "Chasné sur illet"
        oCmdWoo.lignes_commande.Add(New ligneWOO("PRD1", 36, 132.5))
        oCmdWoo.lignes_commande.Add(New ligneWOO("PRD1", 136, 232.5))
        oCmdWoo.lignes_commande.Add(New ligneWOO("PRD2", 236, 332.5))

        Dim oCmdClient As CommandeClient
        oCmdClient = oCmdWoo.createCommandeClient()

        Assert.IsFalse(String.IsNullOrEmpty(oCmdClient.code))
        Assert.AreEqual(132L, oCmdClient.IDPrestashop)

        Assert.AreEqual(oClt.idPrestashop, oCmdClient.oTiers.idPrestashop)
        Assert.AreEqual(oClt.AdresseLivraisonVille, oCmdClient.oTiers.AdresseLivraisonVille)

        Assert.AreEqual(3, oCmdClient.colLignes.Count())
        Dim oLgC As LgCommande
        oLgC = oCmdClient.colLignes(1)
        Assert.AreEqual("PRD1M21", oLgC.oProduit.code)
        Assert.AreEqual(36D, oLgC.qteCommande)
        Assert.AreEqual(132.5D, oLgC.prixU)

        oLgC = oCmdClient.colLignes(2)
        Assert.AreEqual("PRD1M21", oLgC.oProduit.code)
        Assert.AreEqual(136D, oLgC.qteCommande)
        Assert.AreEqual(232.5D, oLgC.prixU)

        oLgC = oCmdClient.colLignes(3)
        Assert.AreEqual("PRD2M23", oLgC.oProduit.code)
        Assert.AreEqual(236D, oLgC.qteCommande)
        Assert.AreEqual(332.5D, oLgC.prixU)
    End Sub

    <TestMethod(), Ignore()> Public Sub RechercheProduitcodestat()
        While Persist.shared_isConnected()
            Persist.shared_disconnect()
        End While
        Persist.ConnectionString = "Provider=SQLOLEDB.1;Data Source=BUREAU-DELL\SQLEXPRESS;Initial Catalog=vnc5;Persist Security Info=True;User ID=vinicom;Password=vinicom"
        Dim oCmdWoo As cmdwoo
        oCmdWoo = cmdwoo.readXML("importinternet\vinicom.wine\20240612143541\202588_20240612123517.xml")
        Assert.IsNotNull(oCmdWoo)
        Assert.IsTrue(oCmdWoo.check())
        Dim oCmd As CommandeClient
        oCmd = oCmdWoo.createCommandeClient()
        Assert.IsNotNull(oCmd)


        While Persist.shared_isConnected()
            Persist.shared_disconnect()
        End While
        Persist.ConnectionString = "Provider=SQLOLEDB.1;Data Source=BUREAU-DELL\SQLEXPRESS;Initial Catalog=vnc5TU;Persist Security Info=True;User ID=vinicom;Password=vinicom"
        Persist.shared_connect()

    End Sub
    'Test de la recopie dans le dossier traitées des commandes traitées
    <TestMethod()> Public Sub importCMDWooTraitées()
        Dim pDossierLocal As String
        Dim oFTP As New clsFTPVinicom("51.91.66.95", "ftpproducteur@producteur.vinicom.fr", "DPx!C}IU~yn!!?jhe{", "TEST")
        oFTP.uploadFile("DATATEST/TESTCMDWOO.xml")

        pDossierLocal = "./importinternet/vinicom.wine/" & Now.ToString("yyyyMMddHHmmss")

        'on fait l'import juste pour parcourir les fichier du FTP
        cmdwoo.SetFTP("51.91.66.95", "ftpproducteur@producteur.vinicom.fr", "DPx!C}IU~yn!!?jhe{", "orders")

        Assert.IsTrue(cmdwoo.Import(pDossierLocal))



    End Sub


End Class

