Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports vini_DB

<TestClass()> Public Class TestPrestashop
    Inherits test_Base

    <TestMethod()> Public Sub testGetClientPrestashop()
        Dim oClient As Client
        Dim nIdPSP As Long = 978
        Client.executeSQLQuery("DELETE FROM CLIENT WHERE CLT_IDPRESTASHOP = " & nIdPSP)
        oClient = Client.createandloadPrestashop(nIdPSP, Dossier.VINICOM)
        Assert.IsNull(oClient)

        oClient = New Client("TESTIMAP", "Client de test")
        oClient.idPrestashop = nIdPSP
        oClient.Origine = Dossier.VINICOM
        Assert.IsTrue(oClient.save())

        oClient = Client.createandloadPrestashop(nIdPSP, Dossier.HOBIVIN)
        Assert.IsNull(oClient)

        oClient = Client.createandloadPrestashop(nIdPSP, Dossier.VINICOM)
        Assert.IsNotNull(oClient)
        Assert.AreEqual(nIdPSP, oClient.idPrestashop)

        oClient.Origine = Dossier.HOBIVIN
        Assert.IsTrue(oClient.save())

        oClient = Client.createandloadPrestashop(nIdPSP, Dossier.VINICOM)
        Assert.IsNull(oClient)

        oClient = Client.createandloadPrestashop(nIdPSP, Dossier.HOBIVIN)
        Assert.IsNotNull(oClient)
        Assert.AreEqual(nIdPSP, oClient.idPrestashop)



    End Sub

    <TestMethod()> Public Sub testCmdPrestashopCheckClient()
        Dim oClient As New Client()
        oClient.idPrestashop = 99
        oClient.Origine = Dossier.VINICOM
        Assert.IsTrue(oClient.save())


        Dim oCmd As New cmdprestashop()
        oCmd.id = 1
        oCmd.name = "aqwzsx"
        oCmd.customer_id = 99
        oCmd.origine = Dossier.VINICOM
        Assert.IsTrue(oCmd.check)

        oCmd.customer_id = 98
        Assert.IsFalse(oCmd.check())

    End Sub

    <TestMethod()> Public Sub testCmdPrestashopCheckProduit()
        Dim oClient As New Client()
        oClient.idPrestashop = 99
        oClient.Origine = Dossier.VINICOM

        Assert.IsTrue(oClient.save())


        Dim oCmd As New cmdprestashop()
        oCmd.id = 1
        oCmd.name = "aqwzsx"
        oCmd.customer_id = 99
        oCmd.origine = Dossier.VINICOM
        Assert.IsTrue(oCmd.check)
        oCmd.AddLigne("PRD1", 10, 6.5)
        Assert.IsFalse(oCmd.check)

        'On Créé le produit
        Dim obj As Fournisseur
        obj = New Fournisseur("TST", "nom")
        Assert.IsTrue(obj.Save)
        Dim oProduit As New Produit("PRD1", obj, 2010)
        Assert.IsTrue(oProduit.save())

        'Reteste de la commande
        Assert.IsTrue(oCmd.check)
        'Ajout d'un nouvelle ligne 
        oCmd.AddLigne("PRD2", 5, 0)
        Assert.IsFalse(oCmd.check)

    End Sub

    <TestMethod(), Ignore()> Public Sub testCmdPrestashopCreateCommand()
        'Création du client
        Dim oClient As New Client()
        oClient.code = "CLTTST"
        oClient.idPrestashop = Now().Hour() & Now.Minute & Now().Second()
        oClient.Origine = Dossier.VINICOM


        Assert.IsTrue(oClient.save())
        'On Créé le produit
        Dim objFRN As Fournisseur
        objFRN = New Fournisseur("TST", "nom")
        Assert.IsTrue(objFRN.Save)
        Dim oProduit As New Produit("PRD1", objFRN, 2010)
        Assert.IsTrue(oProduit.save())
        oProduit = New Produit("PRD2", objFRN, 2010)
        Assert.IsTrue(oProduit.save())

        'Création de la Commande D'import Prestashop (simulation de la lecture du XML)
        Dim oCmd As New cmdprestashop()
        oCmd.customer_id = oClient.idPrestashop
        oCmd.id = 1
        oCmd.name = "ZSXEDC"
        oCmd.origine = Dossier.VINICOM
        oCmd.company = "MyCompany"
        oCmd.livraison_company = "TEST MCII"
        oCmd.livraison_name = "Marc Collin"
        oCmd.AddLigne("PRD1", 10, 5.5)
        oCmd.AddLigne("PRD2", 20, 7.5)

        'Normalement la Commande est OK
        Assert.IsTrue(oCmd.check, "La commande est OK")
        Dim oCmdClt As CommandeClient

        oCmdClt = oCmd.createCommandeClient()
        Assert.IsNotNull(oCmdClt)
        Assert.IsTrue(oCmdClt.save())

        Assert.AreEqual(CLng(oCmd.id), oCmdClt.IDPrestashop)
        Assert.AreEqual(oCmd.name, oCmdClt.NamePrestashop)
        Assert.AreEqual(oClient.code, oCmdClt.TiersCode)
        Assert.AreEqual(oCmd.livraison_company, oCmdClt.caracteristiqueTiers.rs)
        Assert.AreEqual(oCmd.company, oCmdClt.caracteristiqueTiers.nom)
        Assert.AreEqual(oCmd.livraison_company, oCmdClt.RaisonSocialeLivraison)
        Assert.AreEqual(oCmd.livraison_name & " " & oCmd.livraison_firstname, oCmdClt.NomLivraison)
        Assert.AreEqual(oCmd.livraison_name & " " & oCmd.livraison_firstname, oCmdClt.caracteristiqueTiers.AdresseLivraisonNom)
        Assert.AreEqual(oCmd.livraison_adress1, oCmdClt.caracteristiqueTiers.AdresseLivraisonRue1)
        Assert.AreEqual(oCmd.livraison_adress2, oCmdClt.caracteristiqueTiers.AdresseLivraisonRue2)
        Assert.AreEqual(oCmd.livraison_postalcode, oCmdClt.caracteristiqueTiers.AdresseLivraisonCP)
        Assert.AreEqual(oCmd.livraison_city, oCmdClt.caracteristiqueTiers.AdresseLivraisonVille)
        Assert.AreEqual(oCmd.livraison_name & " " & oCmd.livraison_firstname, oCmdClt.caracteristiqueTiers.AdresseLivraisonNom)
        Assert.AreEqual(oCmd.livraison_adress1, oCmdClt.caracteristiqueTiers.AdresseFacturation.rue1)
        Assert.AreEqual(oCmd.livraison_adress2, oCmdClt.caracteristiqueTiers.AdresseFacturation.rue2)
        Assert.AreEqual(oCmd.livraison_postalcode, oCmdClt.caracteristiqueTiers.AdresseFacturation.cp)
        Assert.AreEqual(oCmd.livraison_city, oCmdClt.caracteristiqueTiers.AdresseFacturation.ville)

        Assert.AreEqual(oCmd.lignes.Count, oCmdClt.colLignes.Count, "Nombre de lignes")
        Dim nLigne As Integer = 0
        Dim oLgCmd As LgCommande
        For Each oLg As ligneprestashop In oCmd.lignes
            nLigne = nLigne + 1
            oLgCmd = oCmdClt.colLignes(nLigne)
            Assert.AreEqual(oLg.reference, oLgCmd.ProduitCode)
            Assert.AreEqual(CDec(oLg.quantite), oLgCmd.qteCommande)
            Assert.AreEqual(oLg.prixunitaire, oLgCmd.prixU)

        Next

        oProduit.bDeleted = True
        oProduit.save()
        objFRN.bDeleted = True
        objFRN.Save()
        oClient.bDeleted = True
        oClient.save()






    End Sub

End Class