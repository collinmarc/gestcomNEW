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
        'Parcours de fichiers t�l�charg�s
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
        Dim pDossierLocal As String
        Dim oCmd As New cmdwoo()
        Dim oLg As New ligneWOO("123", 10, 15.5)
        oCmd.lignes_commande.Add(oLg)
        oLg = New ligneWOO("456", 20, 25.5)
        oCmd.lignes_commande.Add(oLg)

        pDossierLocal = "./importinternet/vinicom.wine/" & Now.ToString("yyyyMMddHHmmss")

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

        'Cr�ation d'un client
        Dim oClt As New Client
        oClt.idPrestashop = 9915
        oClt.code = "CLT1"
        oClt.Origine = "VINICOM"
        oClt.AdresseLivraison.ville = "chasn� sur illet"
        Assert.IsTrue(oClt.save)
        'Cr�ation d'un Fournisseur
        Dim oFRN As New Fournisseur("FRN1", "Fournisseur1")
        oFRN.Save()
        'Cr�ation d'un produit
        Dim oPrd As New Produit("PRD1", oFRN, 2000)
        oPrd.save()


        'Cr�ation d'une commande WOO FICTIVE pour pouvoir l'exporter
        Dim oCmd As New cmdwoo()

        oCmd.entete.id = "999"
        oCmd.entete.num_cde_woocommerce = "132"
        oCmd.entete.origine = "VINICOM"
        oCmd.entete.customer_id = oClt.idPrestashop
        oCmd.entete.datecmd = Now.ToString("yyyyMMdd")
        oCmd.client.adresse_livraison.livraison_city = "Chasn� sur illet"
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

        'Ily a une Commande d'import�es
        Assert.AreEqual(1, cmdwoo.ListeCommandes.Count)
        'R�cup�ration de la commande import�e
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
        'Cr�ation d'un client
        Dim oClt As New Client
        oClt.idPrestashop = 9915
        oClt.code = "CLT1"
        oClt.Origine = "VINICOM"
        oClt.AdresseLivraison.ville = "chasn� sur illet"
        Assert.IsTrue(oClt.save)
        'Cr�ation d'un Fournisseur
        Dim oFRN As New Fournisseur("FRN1", "Fournisseur1")
        oFRN.Save()
        'Cr�ation d'un produit
        Dim oPrd As New Produit("PRD1", oFRN, 2000)
        oPrd.save()
        'Cr�ation d'une commande WOO FICTIVE pour pouvoir l'exporter
        Dim oCmd As New cmdwoo()

        oCmd.entete.id = "999"
        oCmd.entete.num_cde_woocommerce = "132"
        oCmd.entete.origine = "VINICOM"
        oCmd.entete.customer_id = oClt.idPrestashop
        oCmd.entete.datecmd = Now.ToString("yyyyMMdd")
        oCmd.client.adresse_livraison.livraison_city = "Chasn� sur illet"
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

        'On recommence l'import  apr�s 2 Seconde
        System.Threading.Thread.Sleep(2000)
        Assert.IsTrue(cmdwoo.Import(pDossierLocal, True))

        'On v�rifie que le Premier Item est bien le plus recent
        LogImportWoo.ReadXml()
        Assert.IsTrue(LogImportWoo.ListItems.ListItems.Count >= 2)
        Assert.IsTrue(LogImportWoo.ListItems.ListItems(0).DateImport > LogImportWoo.ListItems.ListItems(1).DateImport)

        'Purge des items avant le Dernier import
        LogImportWoo.PurgeAvant(DateLimite)
        Assert.AreEqual(2, LogImportWoo.ListItems.ListItems.Count)
        'LogImportWoo.writeXml()

    End Sub

End Class
