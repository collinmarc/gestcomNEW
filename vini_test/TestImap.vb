﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports vini_DB
Imports vini_DB.ImapVB
Imports System.Xml
Imports System.Net.Mail
Imports System.Text.RegularExpressions

''' <summary>
''' Classe de test à reactiver 
''' </summary>
''' 
<TestClass()> Public Class TestImap
    Inherits test_Base
    Private Sub CleanImap()
        Dim oImap As New Imap()
        oImap.Login("imap.googlemail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        Dim oMsg As System.Net.Mail.MailMessage
        'Création du Folder MSGTRAITE
        oImap.SelectFolder("INBOX")
        For nmsg As Integer = 1 To oImap.nNbreMsgTotal
            '    oImap.DeleteMessage2(nmsg)
        Next

    End Sub
    <TestInitialize()> Public Overrides Sub TestInitialize()
        MyBase.TestInitialize()
        'CleanImap()
    End Sub

    <TestMethod()> Public Sub TestLogin()

        Dim oImap As New Imap()
        oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        Assert.IsTrue(oImap.isConnected)
        Assert.IsTrue(oImap.isLogged)
        oImap.LogOut()
        Assert.IsFalse(oImap.isLogged)
        '        Assert.IsFalse(oImap.isConnected)
        oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintestADEL@gmail.com", "tphhgv3..", True)
        Assert.IsFalse(oImap.isLogged)

    End Sub

    <TestMethod()> Public Sub TestMoveMessages()

        Dim oImap As New Imap()
        oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        Dim strResult As String
        'Après chque move on recommence la selection depuis le début
        'Je suppose qu'il y a des pblm d'index
        Dim bMsgTraite As Boolean = True
        While bMsgTraite
            bMsgTraite = False
            oImap.SelectFolder("INBOX")
            For nmsg As Integer = 1 To oImap.nNbreMsgTotal
                strResult = oImap.GetSubject(nmsg)
                If strResult.StartsWith("[Test]") Then
                    oImap.MoveMessage(nmsg, "MSGTRAITES")
                    bMsgTraite = True
                    Exit For
                End If
            Next
        End While

        oImap.LogOut()

    End Sub
    <TestMethod()> Public Sub TestDeleteMsg()

        Dim oImap As New Imap()
        oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        oImap.SelectFolder("MSGTRAITES")
        Dim nMessage As Integer
        Dim nMessageSupprime As Integer
        nMessage = oImap.nNbreMsgTotal

        Dim strResult As String
        For nmsg As Integer = 1 To nMessage
            strResult = oImap.GetSubject(nmsg)
            If strResult.StartsWith("[ADEL]") Then
                nMessageSupprime += 1
                oImap.DeleteMessage2(nmsg)
            End If
        Next

        oImap.SelectFolder("MSGTRAITES")
        Assert.AreEqual(nMessage - nMessageSupprime, oImap.nNbreMsgTotal)


        oImap.LogOut()


    End Sub
    <TestMethod()> Public Sub TestReadMessages()

        Dim oImap As New Imap()
        Dim bReturn As Boolean
        bReturn = oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        Assert.IsTrue(bReturn, "Login NOK")
        Dim oMsg As System.Net.Mail.MailMessage
        'Après chque move on recommence la selection depuis le début
        'Je suppose qu'il y a des pblm d'index
        Dim bMsgTraite As Boolean = True
        While bMsgTraite
            bMsgTraite = False
            oImap.SelectFolder("INBOX")
            For nmsg As Integer = 1 To oImap.nNbreMsgTotal
                oMsg = oImap.getMessage(nmsg)

            Next
        End While

        oImap.LogOut()

    End Sub
    <TestMethod()> Public Sub TestCREATEFOLDER()

        Dim oImap As New Imap()
        Dim sResult As String
        oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        oImap.ListFolder()
        sResult = oImap.deleteFolder("TEST")
        sResult = oImap.createFolder("TEST")
        Assert.AreEqual("OK", sResult)
        sResult = oImap.createFolder("TEST")
        Assert.AreEqual("ALREADYEXISTS", sResult)
        sResult = oImap.deleteFolder("TEST")
        sResult = oImap.deleteFolder("TEST")
        Assert.AreEqual("NONEXISTENT", sResult)
        oImap.LogOut()

    End Sub
    <TestMethod()> Public Sub TestTrtMessagePrestashop()

        Dim oImap As New Imap()
        Dim nMessageINBoxAvant As Integer
        Dim nMessageTraiteAvant As Integer
        Dim nMessageINBoxApres As Integer
        Dim nMessageTraiteApres As Integer
        Dim nmsgTraite1 As Integer
        Dim nmsgTraite2 As Integer
        oImap.Login("imap.googlemail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        Dim oMsg As System.Net.Mail.MailMessage
        'Création du Folder MSGTRAITE
        oImap.createFolder("MSGTRAITES")
        oImap.SelectFolder("INBOX")
        nMessageINBoxAvant = oImap.nNbreMsgTotal
        oImap.SelectFolder("MSGTRAITES")
        nMessageTraiteAvant = oImap.nNbreMsgTotal
        oImap.SelectFolder("INBOX")
        For nmsg As Integer = 1 To oImap.nNbreMsgTotal
            oMsg = oImap.getMessage(nmsg)
            Console.WriteLine("===>TRT msage " & nmsg)
            If Not String.IsNullOrEmpty(oMsg.Body) Then
                'Création de la Commande ViniCom
                nmsgTraite1 = nmsgTraite1 + 1
                Console.WriteLine("===>DEPLACEMMENT msage " & nmsg)
                oImap.MoveMessage(nmsg, "MSGTRAITES")
            End If
        Next
        oImap.SelectFolder("INBOX")
        Dim lstFlags As List(Of String)
        For nmsg As Integer = oImap.nNbreMsgTotal To 1 Step -1
            If oImap.isAnswered(nmsg) Then
                nmsgTraite2 = nmsgTraite2 + 1
                oImap.DeleteMessage2(nmsg)

            End If
        Next
        oImap.SelectFolder("INBOX")
        nMessageINBoxApres = oImap.nNbreMsgTotal
        oImap.SelectFolder("MSGTRAITES")
        nMessageTraiteApres = oImap.nNbreMsgTotal

        oImap.LogOut()


        Assert.AreEqual(nmsgTraite1, nmsgTraite2, "Nombre de message traité dans chaque phase")
        Assert.AreEqual(nMessageINBoxAvant - nmsgTraite1, nMessageINBoxApres, "INBOX")
        Assert.AreEqual(nMessageTraiteAvant + nmsgTraite1, nMessageTraiteApres, "MSGTRAITE")

    End Sub

    <TestMethod(), Ignore()> Public Sub TestSendMailCmd()
        Dim mail As MailMessage = New MailMessage("marc@marccollin.com", "marccollintest@gmail.com")

        mail.Subject = "TEST"
        mail.IsBodyHtml = False
        mail.Body = mail.Body & "[?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?]"
        mail.Body = mail.Body & "[cmd id=""36"" name=""ESZARIWUG""]"
        mail.Body = mail.Body & "[customer id=""2""]"
        mail.Body = mail.Body & "[livraison]"
        mail.Body = mail.Body & "[company]MCII[/company]"
        mail.Body = mail.Body & "[name]MCII[/name]"
        mail.Body = mail.Body & "[firstname]MCII[/firstname]"
        mail.Body = mail.Body & "[adress1]23, la mettrie[/adress1]"
        mail.Body = mail.Body & "[adress2][/adress2]"
        mail.Body = mail.Body & "[postalcode]35250[/postalcode]"
        mail.Body = mail.Body & "[city]Chasné sur illet[/city]"
        mail.Body = mail.Body & "[/livraison]"
        mail.Body = mail.Body & "[/customer]"
        mail.Body = mail.Body & "[lignes]"
        mail.Body = mail.Body & "[ligne]"
        mail.Body = mail.Body & "[reference]demo_1[/reference]"
        mail.Body = mail.Body & "[quantite]1[/quantite]"
        mail.Body = mail.Body & "[/ligne][ligne]"
        mail.Body = mail.Body & "[reference]demo_3[/reference]"
        mail.Body = mail.Body & "[quantite]1[/quantite]"
        mail.Body = mail.Body & "[/ligne]"
        mail.Body = mail.Body & "[/lignes]"
        mail.Body = mail.Body & "[/cmd]"
        mail.Body = mail.Body & "[/xml]"""



        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = "smtp.googlemail.com"
        smtp.Port = 587
        smtp.Credentials = New System.Net.NetworkCredential("marccollin.com@gmail.com", "tphhgv3..")
        smtp.EnableSsl = True
        smtp.Send(mail)

        smtp = New SmtpClient()
        'Connection avec PHPNET
        smtp.Host = "smtpauth.phpnet.org"
        smtp.Port = 8025
        'smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("marc@marccollin.com", "tphhgv3..")
        smtp.Send(mail)

    End Sub
    <TestMethod()> Public Sub TestCleanDB()

        Dim oProduit As Produit
        oProduit = Produit.createandloadbyKey("demo_3")
        If oProduit IsNot Nothing Then
            oProduit.delete()
        End If
        oProduit = Produit.createandloadbyKey("demo_1")
        If oProduit IsNot Nothing Then
            oProduit.delete()
        End If

        'Création du client
        Dim oClient As Client

        oClient = Client.createandload("CLTTST")
        If oClient IsNot Nothing Then
            oClient.delete()
        End If
        Dim obj As Fournisseur
        obj = Fournisseur.createandload("TST")
        If obj IsNot Nothing Then
            obj.delete()
        End If

    End Sub
    <TestMethod()> Public Sub TestCkeckMailCmd()


        'Création du client
        Dim oClient As New Client()
        oClient.code = "CLTTST"
        oClient.idPrestashop = 2
        Assert.IsTrue(oClient.save())
        'On Créé le produit
        Dim obj As Fournisseur
        obj = New Fournisseur("TST", "nom")
        Assert.IsTrue(obj.Save)
        Dim oProduit As New Produit("demo_3", obj, 2010)
        Assert.IsTrue(oProduit.save())
        oProduit = New Produit("demo_1", obj, 2010)
        Assert.IsTrue(oProduit.save())


        EnvoiMailCmd()

        Dim oImportPrestashop As New ImportPrestashop(My.Settings.ImapHost, My.Settings.ImapUser, My.Settings.ImapPassword, My.Settings.ImapPort, My.Settings.ImapSSL)


        Dim oImap As New Imap()
        oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        Dim oMsg As System.Net.Mail.MailMessage
        'Création du Folder MSGTRAITE
        oImap.SelectFolder("INBOX")
        For nmsg As Integer = 1 To oImap.nNbreMsgTotal
            oMsg = oImap.getMessage(nmsg)
            If Not String.IsNullOrEmpty(oMsg.Body) Then
                'Traitement d'un Message 
                Assert.IsNotNull(oImportPrestashop.createCMDCLT(oMsg))
                'Création de la Commande ViniCom
                oImap.MoveMessage(nmsg, "MSGTRAITES")
            End If
        Next
        oImap.SelectFolder("INBOX")
        Dim lstFlags As List(Of String)
        For nmsg As Integer = oImap.nNbreMsgTotal To 1 Step -1
            If oImap.isAnswered(nmsg) Then
                oImap.DeleteMessage2(nmsg)
            End If
        Next

        oImap.LogOut()

        obj.bDeleted = True
        obj.Save()
        oProduit.bDeleted = True
        oProduit.save()

    End Sub
    ''' <summary>
    ''' Ce test lit un mail provenant du système vinicom
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub TestCkeckMailVinicom()



        '/ Ce message a été extrait du serveur de mail de vinicom

        Dim oMsg As System.Net.Mail.MailMessage
        Dim strBody As String = "[?xml version=3D""1.0"" encoding=3D""utf-8"" standalone=3D""yes""?]"
        strBody = strBody + "[cmdprestashop]"
        strBody = strBody + "[id]82[/id]"
        strBody = strBody + "[name]YMJAASSWI[/name]"
        strBody = strBody + "[customer_id]178[/customer_id]"
        strBody = strBody + "[livraison_company]CAVE DES CINQ CHEMINS[/livraison_company]"
        strBody = strBody + "[livraison_name]CAVE DES CINQ CHEMINS[/livraison_name]"
        strBody = strBody + "[livraison_firstname]CAVE DES CINQ CHEMINS[/livraison_firstname]"
        strBody = strBody + "[livraison_adress1]La Bouich=C3=A8re[/livraison_adress1]"
        strBody = strBody + "[livraison_adress2][/livraison_adress2]"
        strBody = strBody + "[livraison_postalcode]53390[/livraison_postalcode]"
        strBody = strBody + "[livraison_city]SAINT ERBLON[/livraison_city]"
        strBody = strBody + "[lignes]"
        strBody = strBody + "[ligneprestashop]"
        strBody = strBody + "[reference]084001[/reference]"
        strBody = strBody + "[quantite]12[/quantite]"
        strBody = strBody + "[prixunitaire]19.25[/prixunitaire]"
        strBody = strBody + "[/ligneprestashop][ligneprestashop]"
        strBody = strBody + "[reference]084002[/reference]"
        strBody = strBody + "[quantite]12[/quantite]"
        strBody = strBody + "[prixunitaire]11.2[/prixunitaire]"
        strBody = strBody + "[/ligneprestashop][ligneprestashop]"
        strBody = strBody + "[reference]002007[/reference]"
        strBody = strBody + "[quantite]12[/quantite]"
        strBody = strBody + "[prixunitaire]12.04[/prixunitaire]"
        strBody = strBody + "[/ligneprestashop][ligneprestashop]"
        strBody = strBody + "[reference]002017[/reference]"
        strBody = strBody + "[quantite]24[/quantite]"
        strBody = strBody + "[prixunitaire]12.34[/prixunitaire]"
        strBody = strBody + "[/ligneprestashop][ligneprestashop]"
        strBody = strBody + "[reference]174005[/reference]"
        strBody = strBody + "[quantite]24[/quantite]"
        strBody = strBody + "[prixunitaire]2.2[/prixunitaire]"
        strBody = strBody + "[/ligneprestashop][ligneprestashop]"
        strBody = strBody + "[reference]174007[/reference]"
        strBody = strBody + "[quantite]24[/quantite]"
        strBody = strBody + "[prixunitaire]2.3[/prixunitaire]"
        strBody = strBody + "[/ligneprestashop][ligneprestashop]"
        strBody = strBody + "[reference]174006[/reference]"
        strBody = strBody + "[quantite]24[/quantite]"
        strBody = strBody + "[prixunitaire]2.2[/prixunitaire]"
        strBody = strBody + "[/ligneprestashop]"
        strBody = strBody + "[/lignes]"
        strBody = strBody + "[/cmdprestashop]"
        '        strBody = strBody + "[/xml]"
        Dim oCmd As cmdprestashop
        oCmd = cmdprestashop.readXML(strBody)
        Assert.AreEqual("La Bouichère", oCmd.livraison_adress1)

    End Sub
    ''' <summary>
    ''' Ce test lit un mail provenant du système vinicom
    ''' </summary>
    ''' <remarks></remarks>
    '<TestMethod(), Ignore()> Public Sub TestCkeckMailVinicom2()

    '    'Ignoré car la Connexion à Vinicom.fr NOK

    '    Dim oImportPrestashop As New ImportPrestashop(My.Settings.ImapHost, My.Settings.ImapUser, My.Settings.ImapPassword, My.Settings.ImapPort, My.Settings.ImapSSL)


    '    Dim oImap As New Imap()
    '    oImap.Login("imap.vinicom.fr", Convert.ToUInt16(143), "cmdprestashop", "vinicom35760", False)
    '    Dim oMsg As System.Net.Mail.MailMessage
    '    'Création du Folder MSGTRAITE
    '    oImap.SelectFolder("INBOX")
    '    For nmsg As Integer = 1 To oImap.nNbreMsgTotal
    '        oMsg = oImap.getMessage(nmsg)
    '        If Not String.IsNullOrEmpty(oMsg.Body) Then
    '            'Traitement d'un Message 
    '            Assert.IsNotNull(oImportPrestashop.createCMDCLT(oMsg, False))
    '            'Création de la Commande ViniCom
    '            oImap.MoveMessage(nmsg, "MSGTRAITES")
    '        End If
    '    Next
    '    oImap.SelectFolder("INBOX")
    '    Dim lstFlags As List(Of String)
    '    For nmsg As Integer = oImap.nNbreMsgTotal To 1 Step -1
    '        If oImap.isAnswered(nmsg) Then
    '            oImap.DeleteMessage2(nmsg)
    '        End If
    '    Next

    '    oImap.LogOut()


    'End Sub
    <TestMethod()> Public Sub TestQuotePrintCity()

        'Création du client
        Dim oClient As New Client()
        oClient.code = "CLTTST"
        oClient.idPrestashop = 2
        Assert.IsTrue(oClient.save())
        'On Créé le produit
        Dim obj As Fournisseur
        obj = New Fournisseur("TST", "nom")
        Assert.IsTrue(obj.Save)
        Dim oProduit As New Produit("demo_3", obj, 2010)
        Assert.IsTrue(oProduit.save())
        oProduit = New Produit("demo_1", obj, 2010)
        Assert.IsTrue(oProduit.save())


        EnvoiMailCmd()

        Dim oImportPrestashop As New ImportPrestashop(My.Settings.ImapHost, My.Settings.ImapUser, My.Settings.ImapPassword, My.Settings.ImapPort, My.Settings.ImapSSL)


        Dim oImap As New Imap()
        oImap.Login("imap.gmail.com", Convert.ToUInt16(993), "marccollintest@gmail.com", "tphhgv3..", True)
        Dim oMsg As System.Net.Mail.MailMessage
        'Création du Folder MSGTRAITE
        oImap.SelectFolder("INBOX")
        For nmsg As Integer = 1 To oImap.nNbreMsgTotal
            oMsg = oImap.getMessage(nmsg)
            If Not String.IsNullOrEmpty(oMsg.Body) Then
                'Traitement d'un Message
                Dim oCmd As CommandeClient
                oCmd = oImportPrestashop.createCMDCLT(oMsg)
                Assert.IsNotNull(oCmd)
                Assert.AreEqual("Chasné sur illet", oCmd.caracteristiqueTiers.AdresseLivraisonVille)
                'Création de la Commande ViniCom
                oImap.MoveMessage(nmsg, "MSGTRAITES")
            End If
        Next
        oImap.SelectFolder("INBOX")
        Dim lstFlags As List(Of String)
        For nmsg As Integer = oImap.nNbreMsgTotal To 1 Step -1
            If oImap.isAnswered(nmsg) Then
                oImap.DeleteMessage2(nmsg)
            End If
        Next

        oImap.LogOut()

        obj.bDeleted = True
        obj.Save()
        oProduit.bDeleted = True
        oProduit.save()

    End Sub
    <TestMethod()> Public Sub TestDecode()
        Dim oImap As New Imap()
        Assert.AreEqual("La Bouichère", oImap.DecodequotedprintableString("La Bouich=C3=A8re", "utf-8"))
        Assert.AreEqual("Chasné sur illet", oImap.DecodequotedprintableString("Chasn=C3=A9 sur illet", "utf-8"))
        Assert.AreEqual("é è", oImap.DecodequotedprintableString("=C3=A9 =C3=A8", "utf-8"))
        Assert.AreEqual("é = è", oImap.DecodequotedprintableString("=C3=A9 =3D =C3=A8", "utf-8"))
        Dim strIn As String = "Une nouvelle commande a =C3=A9t=C3=A9 pass=C3=A9e sur VINICOM par ce client=" & vbCrLf
        strIn = strIn & " : pr=C3=A9nom DELAUNAY (contact@cavedes5chemins.com)=20"
        Dim strOut As String = "Une nouvelle commande a été passée sur VINICOM par ce client : prénom DELAUNAY (contact@cavedes5chemins.com) "
        Assert.AreEqual(strOut, oImap.DecodequotedprintableString(strIn, "utf-8"))

        strIn = "<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>=" & vbCrLf
        strIn = strIn & "<livraison_adress1>La Bouich=C3=A8re</livraison_adr=" & vbCrLf
        strIn = strIn & "ess1>"
        strOut = "<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?><livraison_adress1>La Bouichère</livraison_adress1>"
        Dim strDecoded As String = oImap.DecodequotedprintableString(strIn, "utf-8")
        For I As Integer = 0 To strOut.Length - 1
            Console.WriteLine(strOut.Substring(I, 1) & "->" & strDecoded.Substring(I, 1))
        Next I
        Assert.AreEqual(strOut, strDecoded)


    End Sub




    <TestMethod()> Public Sub TestInitImportPrestashop()
        Dim oImport As New ImportPrestashop(My.Settings.ImapHost, My.Settings.ImapUser, My.Settings.ImapPassword, My.Settings.ImapPort, My.Settings.ImapSSL)
        Assert.AreEqual("imap.google.com", oImport.HostName)
        Assert.AreEqual("marccollintest@gmail.com", oImport.UserName)
        Assert.AreEqual("tphhgv3..", oImport.Password)
        Assert.AreEqual(993, oImport.Port)
        Assert.AreEqual(True, oImport.bSSL)
    End Sub
    ''' <summary>
    ''' Test de l'import Prestashop avec envoi de mail automatique
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub TestImportPrestashopCmd()
        TestCleanDB()
        Dim oParam As Param = Param.colModeReglement(1)

        'Création du client
        Dim oClient As New Client()
        oClient.code = "CLTTST"
        oClient.idPrestashop = 2
        oClient.idModeReglement = oParam.id
        Assert.IsTrue(oClient.save())
        'On Créé le produit
        Dim obj As Fournisseur
        obj = New Fournisseur("TST", "nom")
        Assert.IsTrue(obj.Save)
        Dim oProduit As New Produit("demo_3", obj, 2010)
        Assert.IsTrue(oProduit.save())
        oProduit = New Produit("demo_1", obj, 2010)
        Assert.IsTrue(oProduit.save())


        EnvoiMailCmd()
        Dim olst As List(Of CommandeClient)
        Dim oCmdCLT As CommandeClient
        Dim oImportPrestashop As New ImportPrestashop("imap.gmail.com", "marccollintest@gmail.com", "tphhgv3..", Convert.ToUInt16(993), True)
        oImportPrestashop.MSGFolderName = "MSGTRAITES"
        olst = oImportPrestashop.Import()
        Assert.AreEqual(1, olst.Count)

        oCmdCLT = olst(0)

        Assert.AreEqual(37L, oCmdCLT.IDPrestashop)
        Assert.AreEqual("TESTIMPORT", oCmdCLT.NamePrestashop)
        Assert.AreEqual(oClient.code, oCmdCLT.TiersCode)
        Assert.AreEqual("MCII", oCmdCLT.RaisonSocialeLivraison)
        Assert.AreEqual("MCII MCII", oCmdCLT.NomLivraison)
        Assert.AreEqual("MCII MCII", oCmdCLT.caracteristiqueTiers.AdresseLivraisonNom)
        Assert.AreEqual("23, la mettrie", oCmdCLT.caracteristiqueTiers.AdresseLivraisonRue1)
        Assert.AreEqual("", oCmdCLT.caracteristiqueTiers.AdresseLivraisonRue2)
        Assert.AreEqual("35250", oCmdCLT.caracteristiqueTiers.AdresseLivraisonCP)
        Assert.AreEqual("Chasné sur illet", oCmdCLT.caracteristiqueTiers.AdresseLivraisonVille)
        ' Vérification de transfert du mode de reglement
        Assert.AreEqual(oParam.id, oCmdCLT.caracteristiqueTiers.idModeReglement)

        Assert.AreEqual(2, oCmdCLT.colLignes.Count, "Nombre de lignes")
        Dim nLigne As Integer = 0
        Dim oLgCmd As LgCommande
        oLgCmd = oCmdCLT.colLignes(1)
        Assert.AreEqual("demo_1", oLgCmd.ProduitCode)
        Assert.AreEqual(CDec(1), oLgCmd.qteCommande)
        Assert.AreEqual(CDec(5.5), oLgCmd.prixU)
        oLgCmd = oCmdCLT.colLignes(2)
        Assert.AreEqual("demo_3", oLgCmd.ProduitCode)
        Assert.AreEqual(CDec(1), oLgCmd.qteCommande)
        Assert.AreEqual(CDec(5.5), oLgCmd.prixU)

        'Envoi de 2 Commandes
        EnvoiMailCmd()
        EnvoiMailCmd()

        olst = oImportPrestashop.Import()
        Assert.AreEqual(2, olst.Count)

        'Après traitement la boite de réception est vide

        olst = oImportPrestashop.Import()
        Assert.AreEqual(0, olst.Count)




    End Sub
    ''' <summary>
    ''' Test de L'origine de l'import Prestashop (HOBIVIN ou VINICOM)
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub TestImportPrestashopCmdOrigine()
        TestCleanDB()
        Dim oParam As Param = Param.colModeReglement(1)

        'Création du client
        Dim oClient As New Client()
        oClient.code = "CLTTST"
        oClient.idPrestashop = 2
        oClient.idModeReglement = oParam.id
        Assert.IsTrue(oClient.save())
        'On Créé le produit
        Dim obj As Fournisseur
        obj = New Fournisseur("TST", "nom")
        Assert.IsTrue(obj.Save)
        Dim oProduit As New Produit("demo_3", obj, 2010)
        Assert.IsTrue(oProduit.save())
        oProduit = New Produit("demo_1", obj, 2010)
        Assert.IsTrue(oProduit.save())


        EnvoiMailCmd(Dossier.HOBIVIN)
        Dim olst As List(Of CommandeClient)
        Dim oCmdCLT As CommandeClient
        Dim oImportPrestashop As New ImportPrestashop("imap.gmail.com", "marccollintest@gmail.com", "tphhgv3..", Convert.ToUInt16(993), True)
        oImportPrestashop.MSGFolderName = "MSGTRAITES"
        olst = oImportPrestashop.Import()
        Assert.AreEqual(1, olst.Count)

        oCmdCLT = olst(0)

        Assert.AreEqual(Dossier.HOBIVIN, oCmdCLT.Origine)

        'Envoi de 2 Commandes
        EnvoiMailCmd(Dossier.VINICOM)
        EnvoiMailCmd()

        olst = oImportPrestashop.Import()
        Assert.AreEqual(2, olst.Count)
        For Each oCmd As CommandeClient In olst
            Assert.AreEqual(Dossier.VINICOM, oCmd.Origine)
        Next


    End Sub
    <TestMethod()> Public Sub testReadWriteXMLFile()
        Dim ocmd As New cmdprestashop()
        ocmd.id = 2
        ocmd.origine = Dossier.VINICOM
        ocmd.name = "aqwzsx"
        ocmd.livraison_company = "MCII"
        ocmd.livraison_name = "Collin"
        ocmd.livraison_firstname = "MCII"
        ocmd.livraison_adress1 = "23, la mettrie"
        ocmd.livraison_adress2 = "Ad2"
        ocmd.livraison_postalcode = "35250"
        ocmd.livraison_city = "Chasné sur illet"
        ocmd.livraison_company = "MCII"
        ocmd.lignes.Add(New ligneprestashop("demo_1", 10, 5.5))
        ocmd.lignes.Add(New ligneprestashop("demo_2", 15, 7.5))

        cmdprestashop.FTO_writeXml(ocmd, "./cmd.xml")

        Assert.IsTrue(System.IO.File.Exists("./cmd.xml"))

        Dim strIn As String = System.IO.File.ReadAllText("./cmd.xml")

        ocmd = cmdprestashop.readXML(strIn)
        Assert.AreEqual(ocmd.id, "2")
        Assert.AreEqual(ocmd.name, "aqwzsx")
        Assert.AreEqual(ocmd.origine, Dossier.VINICOM)
        Assert.AreEqual(ocmd.livraison_company, "MCII")
        Assert.AreEqual(ocmd.livraison_name, "Collin")
        Assert.AreEqual(ocmd.livraison_firstname, "MCII")
        Assert.AreEqual(ocmd.livraison_adress1, "23, la mettrie")
        Assert.AreEqual(ocmd.livraison_adress2, "Ad2")
        Assert.AreEqual(ocmd.livraison_postalcode, "35250")
        Assert.AreEqual(ocmd.livraison_city, "Chasné sur illet")
        Assert.AreEqual(ocmd.livraison_company, "MCII")
        Assert.AreEqual(ocmd.lignes.Count, 2)
        Assert.AreEqual(ocmd.lignes(0).reference, "demo_1")
        Assert.AreEqual(ocmd.lignes(0).quantite, 10)
        Assert.AreEqual(ocmd.lignes(1).reference, "demo_2")
        Assert.AreEqual(ocmd.lignes(1).quantite, 15)

    End Sub
    ''' <summary>
    ''' Test Lecture d'un Flux XML avec un &
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub testReadXMLFileavecAmp()
        Dim ocmd As cmdprestashop
        Assert.IsTrue(System.IO.File.Exists("./CmdPrestashopTest.xml"))

        Dim strIn As String = System.IO.File.ReadAllText("./CmdPrestashopTest.xml")

        ocmd = cmdprestashop.readXML(strIn)
        Assert.AreEqual(ocmd.id, "288")
        Assert.AreEqual(ocmd.name, "JFMZPIJJQ")
        Assert.AreEqual(ocmd.origine, Dossier.HOBIVIN)
        Assert.AreEqual(ocmd.livraison_company, "LE RIALTO")
        Assert.AreEqual(ocmd.livraison_adress1, "40 AVENUE E. . M. PINAULT")
        Assert.AreEqual(ocmd.lignes.Count, 3)
        Assert.AreEqual(ocmd.lignes(0).reference, "051000")
        Assert.AreEqual(ocmd.lignes(0).quantite, 12)
        Assert.AreEqual(ocmd.lignes(1).reference, "174003")
        Assert.AreEqual(ocmd.lignes(1).quantite, 12)
        Assert.AreEqual(ocmd.lignes(2).reference, "178001H")
        Assert.AreEqual(ocmd.lignes(2).quantite, 12)

    End Sub

    ''' <summary>
    ''' Chargement de la commande prestashop à partir d'une chaine
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub testReadWriteXMLString()
        Dim ocmd As New cmdprestashop()
        ocmd.id = 2
        ocmd.name = "aqwzsx"
        ocmd.livraison_company = "MCII"
        ocmd.livraison_name = "Collin"
        ocmd.livraison_firstname = "MCII"
        ocmd.livraison_adress1 = "23, la mettrie"
        ocmd.livraison_adress2 = "Ad2"
        ocmd.livraison_postalcode = "35250"
        ocmd.livraison_city = "Chasné sur illet"
        ocmd.livraison_company = "MCII"
        ocmd.lignes.Add(New ligneprestashop("demo_1", 10, 5.5))
        ocmd.lignes.Add(New ligneprestashop("demo_2", 15, 7.5))

        cmdprestashop.FTO_writeXml(ocmd, "./cmd.xml")
        Assert.IsTrue(System.IO.File.Exists("./cmd.xml"))
        Dim oDoc As New XmlDocument()
        oDoc.Load("./cmd.xml")
        Dim sw As New System.IO.StringWriter()
        Dim ost As New XmlTextWriter(sw)
        oDoc.WriteTo(ost)

        Dim xmlString As String = sw.ToString()

        ocmd = cmdprestashop.readXML(xmlString)
        Assert.AreEqual(ocmd.id, "2")
        Assert.AreEqual(ocmd.name, "aqwzsx")
        Assert.AreEqual(ocmd.livraison_company, "MCII")
        Assert.AreEqual(ocmd.livraison_name, "Collin")
        Assert.AreEqual(ocmd.livraison_firstname, "MCII")
        Assert.AreEqual(ocmd.livraison_adress1, "23, la mettrie")
        Assert.AreEqual(ocmd.livraison_adress2, "Ad2")
        Assert.AreEqual(ocmd.livraison_postalcode, "35250")
        Assert.AreEqual(ocmd.livraison_city, "Chasné sur illet")
        Assert.AreEqual(ocmd.livraison_company, "MCII")
        Assert.AreEqual(ocmd.lignes.Count, 2)
        Assert.AreEqual(ocmd.lignes(0).reference, "demo_1")
        Assert.AreEqual(ocmd.lignes(0).quantite, 10)
        Assert.AreEqual(ocmd.lignes(1).reference, "demo_2")
        Assert.AreEqual(ocmd.lignes(1).quantite, 15)

    End Sub

    Private Sub EnvoiMailCmd2()
        Dim mail As MailMessage = New MailMessage("marccollin.com@gmail.com", "marccollintest@gmail.com")
        mail.Subject = "TEST"
        mail.IsBodyHtml = False
        '        mail.BodyEncoding = System.Text.ASCIIEncoding.UTF8
        Dim strBody As String = ""
        strBody = ""
        strBody = strBody & "[?xml version =3D""1.0"" encoding=3D""utf-8"" standalone=3D""yes"" ?]" & vbCrLf
        strBody = strBody & "[cmdprestashop]" & vbCrLf
        strBody = strBody & "[id]36[/id]" & vbCrLf
        strBody = strBody & "[name]ESZARIWUG[/name]" & vbCrLf
        strBody = strBody & "[origine]VINICOM[/origine]" & vbCrLf
        strBody = strBody & "[customer_id]2[/customer_id]" & vbCrLf
        strBody = strBody & "[livraison_company]MCII[/livraison_company]" & vbCrLf
        strBody = strBody & "[livraison_name]MCII[/livraison_name]" & vbCrLf
        strBody = strBody & "[livraison_firstname]MCII[/livraison_firstname]" & vbCrLf
        strBody = strBody & "[livraison_adress1]23, la mettrie[/livraison_adress1]" & vbCrLf
        strBody = strBody & "[livraison_adress2][/livraison_adress2]" & vbCrLf
        strBody = strBody & "[livraison_postalcode]35250[/livraison_postalcode]" & vbCrLf
        strBody = strBody & "[livraison_city]Chasn=C3=A9 sur illet[/livrai=" & vbCrLf
        strBody = strBody & "son_city][lignes]" & vbCrLf
        strBody = strBody & "[ligneprestashop]" & vbCrLf
        strBody = strBody & "[reference]demo_1[/reference]" & vbCrLf
        strBody = strBody & "[quantite]1[/quantite]" & vbCrLf
        strBody = strBody & "[prixunitaire]5.5[/prixunitaire]" & vbCrLf
        strBody = strBody & "[/ligneprestashop]" & vbCrLf
        strBody = strBody & "[ligneprestashop]" & vbCrLf
        strBody = strBody & "[reference]demo_3[/reference]" & vbCrLf
        strBody = strBody & "[quantite]1[/quantite]" & vbCrLf
        strBody = strBody & "[prixunitaire]5.5[/prixunitaire]" & vbCrLf
        strBody = strBody & "[/ligneprestashop]" & vbCrLf
        strBody = strBody & "[/lignes]" & vbCrLf
        strBody = strBody & "[/cmdprestashop]" & vbCrLf
        strBody = strBody & "[/xml]" & vbCrLf

        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(strBody, Encoding.GetEncoding("UTF-8"), "text/plain")
        plainView.TransferEncoding = Net.Mime.TransferEncoding.SevenBit
        mail.AlternateViews.Add(plainView)
        mail.BodyEncoding = Encoding.GetEncoding("UTF-8")
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = "smtp.googlemail.com"
        smtp.Port = 587
        smtp.Credentials = New System.Net.NetworkCredential("marccollin.com@gmail.com", "tphhgv3.")
        smtp.EnableSsl = True

        smtp.Send(mail)
        'Puse pour attendre la diffusiondu message
        System.Threading.Thread.Sleep(5000)

    End Sub

    Private Sub EnvoiMailCmd(Optional pOrigin As String = "VINICOM")
        Dim mail As MailMessage = New MailMessage("marccollin.com@gmail.com", "marccollintest@gmail.com")
        mail.Subject = "TEST"
        mail.IsBodyHtml = False
        '        mail.BodyEncoding = System.Text.ASCIIEncoding.UTF8
        Dim strBody As String = ""
        strBody = ""
        strBody = strBody & "[?xml version=""1.0"" encoding=""utf-8"" standalone=""yes"" ?]" & vbCrLf
        strBody = strBody & "[cmdprestashop]" & vbCrLf
        strBody = strBody & "[id]37[/id]" & vbCrLf
        strBody = strBody & "[name]TESTIMPORT[/name]" & vbCrLf
        strBody = strBody & "[origine]" & pOrigin & "[/origine]" & vbCrLf
        strBody = strBody & "[customer_id]2[/customer_id]" & vbCrLf
        strBody = strBody & "[livraison_company]MCII[/livraison_company]" & vbCrLf
        strBody = strBody & "[livraison_name]MCII[/livraison_name]" & vbCrLf
        strBody = strBody & "[livraison_firstname]MCII[/livraison_firstname]" & vbCrLf
        strBody = strBody & "[livraison_adress1]23, la mettrie[/livraison_adress1]" & vbCrLf
        strBody = strBody & "[livraison_adress2][/livraison_adress2]" & vbCrLf
        strBody = strBody & "[livraison_postalcode]35250[/livraison_postalcode]" & vbCrLf
        strBody = strBody & "[livraison_city]Chasn=C3=A9 sur illet[/livrai=" & vbCrLf
        strBody = strBody & "son_city][lignes]" & vbCrLf
        strBody = strBody & "[ligneprestashop]" & vbCrLf
        strBody = strBody & "[reference]demo_1[/reference]" & vbCrLf
        strBody = strBody & "[quantite]1[/quantite]" & vbCrLf
        strBody = strBody & "[prixunitaire]5.5[/prixunitaire]" & vbCrLf
        strBody = strBody & "[/ligneprestashop]" & vbCrLf
        strBody = strBody & "[ligneprestashop]" & vbCrLf
        strBody = strBody & "[reference]demo_3[/reference]" & vbCrLf
        strBody = strBody & "[quantite]1[/quantite]" & vbCrLf
        strBody = strBody & "[prixunitaire]5.5[/prixunitaire]" & vbCrLf
        strBody = strBody & "[/ligneprestashop]" & vbCrLf
        strBody = strBody & "[/lignes]" & vbCrLf
        strBody = strBody & "[/cmdprestashop]" & vbCrLf
        strBody = strBody & "[/xml]" & vbCrLf

        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(strBody, Encoding.GetEncoding("UTF-8"), "text/plain")
        plainView.TransferEncoding = Net.Mime.TransferEncoding.SevenBit
        mail.AlternateViews.Add(plainView)
        mail.BodyEncoding = Encoding.GetEncoding("UTF-8")
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.Host = "smtp.googlemail.com"
        smtp.Port = 587
        smtp.Credentials = New System.Net.NetworkCredential("marccollin.com@gmail.com", "tphhgv3..")
        smtp.EnableSsl = True

        smtp.Send(mail)
        'Puse pour attendre la diffusiondu message
        System.Threading.Thread.Sleep(5000)

    End Sub

    ''' <summary>
    ''' Test de l'import Prestashop d'une commande saisie sur prestashop et envoyé sur marccollintest.com
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), Ignore()> Public Sub TestImportPrestashopCmd2()
        TestCleanDB()
        Dim oParam As Param = Param.colModeReglement(1)

        'Création du client
        Dim oClient As New Client()
        oClient.code = "CLTTST"
        oClient.idPrestashop = 311
        oClient.idModeReglement = oParam.id
        Assert.IsTrue(oClient.save())
        'On Créé le produit
        Dim obj As Fournisseur
        obj = New Fournisseur("TST", "nom")
        Assert.IsTrue(obj.Save)
        Dim oProduit As New Produit("019003", obj, 2010)
        ' Assert.IsTrue(oProduit.save())


        Dim olst As List(Of CommandeClient)
        Dim oCmdCLT As CommandeClient
        Dim oImportPrestashop As New ImportPrestashop("imap.gmail.com", "marccollintest@gmail.com", "tphhgv3..", Convert.ToUInt16(993), True)
        oImportPrestashop.MSGFolderName = "MSGTRAITES"
        olst = oImportPrestashop.Import()
        Assert.AreEqual(1, olst.Count)

        oCmdCLT = olst(0)

        Assert.AreEqual(311L, oCmdCLT.IDPrestashop)
        Assert.AreEqual("TESTIMPORT", oCmdCLT.NamePrestashop)
        Assert.AreEqual(oClient.code, oCmdCLT.TiersCode)
        Assert.AreEqual("MCII", oCmdCLT.RaisonSocialeLivraison)
        Assert.AreEqual("MCII MCII", oCmdCLT.NomLivraison)
        Assert.AreEqual("MCII MCII", oCmdCLT.caracteristiqueTiers.AdresseLivraisonNom)
        Assert.AreEqual("23, la mettrie", oCmdCLT.caracteristiqueTiers.AdresseLivraisonRue1)
        Assert.AreEqual("", oCmdCLT.caracteristiqueTiers.AdresseLivraisonRue2)
        Assert.AreEqual("35250", oCmdCLT.caracteristiqueTiers.AdresseLivraisonCP)
        Assert.AreEqual("Chasné sur illet", oCmdCLT.caracteristiqueTiers.AdresseLivraisonVille)
        ' Vérification de transfert du mode de reglement
        Assert.AreEqual(oParam.id, oCmdCLT.caracteristiqueTiers.idModeReglement)

        Assert.AreEqual(1, oCmdCLT.colLignes.Count, "Nombre de lignes")
        Dim nLigne As Integer = 0
        Dim oLgCmd As LgCommande
        oLgCmd = oCmdCLT.colLignes(1)
        Assert.AreEqual("019003", oLgCmd.ProduitCode)
        Assert.AreEqual(CDec(1), oLgCmd.qteCommande)
        Assert.AreEqual(CDec(5.5), oLgCmd.prixU)
        oLgCmd = oCmdCLT.colLignes(2)
        Assert.AreEqual("demo_3", oLgCmd.ProduitCode)
        Assert.AreEqual(CDec(1), oLgCmd.qteCommande)
        Assert.AreEqual(CDec(5.5), oLgCmd.prixU)

        'Envoi de 2 Commandes
        EnvoiMailCmd()
        EnvoiMailCmd()

        olst = oImportPrestashop.Import()
        Assert.AreEqual(2, olst.Count)

        'Après traitement la boite de réception est vide

        olst = oImportPrestashop.Import()
        Assert.AreEqual(0, olst.Count)




    End Sub
    <TestMethod()> Public Sub TestConvertToXml()
        Dim str As String

        str = "[?xml version=3D""1.0"" encoding=3D""utf-8""
standalone=3D""yes""?]
[cmdprestashop]
        [id]1698[/id]
[name]HYVVVYQME[/name]
[origine]VINICOM[/origine]
[customer_id]87[/customer_id]
=09=09[livraison_company][/livraison_company]
=09=09[livraison_name]GAUTIER[/livraison_name]
=09=09[livraison_firstname]Christophe[/livraison_firstname]
=09=09[livraison_adress1].[/livraison_adress1]
=09=09[livraison_adress2][/livraison_adress2]
=09=09[livraison_postalcode][/livraison_postalcode]
=09=09[livraison_city].[/livraison_city]
[lignes]
        [ligneprestashop]
=09=09=09=09=09[reference]011001[/reference]
=09=09=09=09=09[quantite]12[/quantite]
=09=09=09=09=09[prixunitaire]4.54[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]040012[/reference]
=09=09=09=09=09[quantite]6[/quantite]
=09=09=09=09=09[prixunitaire]8.7[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]040015[/reference]
=09=09=09=09=09[quantite]12[/quantite]
=09=09=09=09=09[prixunitaire]5.6[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]059020[/reference]
=09=09=09=09=09[quantite]24[/quantite]
=09=09=09=09=09[prixunitaire]4.15[/prixunitaire]
=09=09
=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]174008[/reference]
=09=09=09=09=09[quantite]24[/quantite]
=09=09=09=09=09[prixunitaire]2.5[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]174024[/reference]
=09=09=09=09=09[quantite]24[/quantite]
=09=09=09=09=09[prixunitaire]3.5[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]178001H[/reference]
=09=09=09=09=09[quantite]36[/quantite]
=09=09=09=09=09[prixunitaire]2.77[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]178002H[/reference]
=09=09=09=09=09[quantite]12[/quantite]
=09=09=09=09=09[prixunitaire]2.83[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]235001H[/reference]
=09=09=09=09=09[quantite]12[/quantite]
=09=09=09=09=09[prixunitaire]3.87[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]257005H[/reference]
=09=09=09=09=09[quantite]24[/quantite]
=09=09=09=09=09[prixunitaire]4.48[/prixunitaire]
=09=09=09=09[/ligneprestashop][ligneprestashop]
=09=09=09=09=09[reference]292005[/reference]
=09=09=09=09=09[quantite]4[/quantite]
=09=09=09=09=09[prixunitaire]12.8[/prixunitaire
]
=09=09=09=09[/ligneprestashop]
[/lignes]
[/cmdprestashop]
[/xml]
"
        Dim ocmd As cmdprestashop = cmdprestashop.readXML(str)
        Assert.AreNotEqual("", ocmd.id)
    End Sub

End Class