﻿Imports vini_DB
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Net.Mail
'Imports FAXCOMLib

Public Class frmSaisieCommandeClient
    Inherits frmSaisieCommande

    Private m_objSCMDCourante As SousCommande
    Private m_oFactHBV As FactHBV
    Protected Shadows Function getCommandeCourante() As CommandeClient
        Return CType(getElementCourant(), CommandeClient)
    End Function

#Region " Code généré par le Concepteur Windows Form "

    Friend WithEvents btnCtrlStock As System.Windows.Forms.Button


    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    '<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    '    Me.btnCtrlStock = New System.Windows.Forms.Button()
    '    '        Me.tpClient.SuspendLayout()
    '    Me.tpLignes.SuspendLayout()
    '    '       Me.tpCommentaires.SuspendLayout()
    '    Me.SSTabCommandeClient.SuspendLayout()
    '    Me.SuspendLayout()
    '    '
    '    'tpLignes
    '    '
    '    Me.tpLignes.Controls.Add(Me.btnCtrlStock)
    '    '        Me.tpLignes.Controls.SetChildIndex(Me.cbAjouterLigne, 0)
    '    '       Me.tpLignes.Controls.SetChildIndex(Me.tbTotalHT, 0)
    '    '      Me.tpLignes.Controls.SetChildIndex(Me.cbModifierLigne, 0)
    '    '     Me.tpLignes.Controls.SetChildIndex(Me.cbSupprimerLigne, 0)
    '    '    Me.tpLignes.Controls.SetChildIndex(Me.tbTotalTTC, 0)
    '    Me.tpLignes.Controls.SetChildIndex(Me.btnCtrlStock, 0)
    '    '
    '    'btnCtrlStock
    '    '
    '    Me.btnCtrlStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    '    Me.btnCtrlStock.Location = New System.Drawing.Point(632, 524)
    '    Me.btnCtrlStock.Name = "btnCtrlStock"
    '    Me.btnCtrlStock.Size = New System.Drawing.Size(105, 23)
    '    Me.btnCtrlStock.TabIndex = 70
    '    Me.btnCtrlStock.Text = "Contrôle du stock"
    '    Me.btnCtrlStock.UseVisualStyleBackColor = True
    '    '
    '    'frmCommandeClient
    '    '
    '    'Me.ClientSize = New System.Drawing.Size(1016, 659)
    '    Me.Name = "frmCommandeClient"
    '    Me.Text = "Saisie Commande Client"
    '    'Me.tpClient.ResumeLayout(False)
    '    'Me.tpClient.PerformLayout()
    '    Me.tpLignes.ResumeLayout(False)
    '    Me.tpLignes.PerformLayout()
    '    'Me.tpCommentaires.ResumeLayout(False)
    '    Me.SSTabCommandeClient.ResumeLayout(False)
    '    'CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
    '    Me.ResumeLayout(False)

    'End Sub

#End Region

#Region "Méthodes Vinicom"
    Protected Overrides Function creerElement() As Boolean
        Debug.Assert(Not isfrmUpdated(), "La fenetre n'est pas libre")
        Dim bReturn As Boolean
        bReturn = setElementCourant2(New CommandeClient(New Client("", "")))

        Return bReturn
    End Function
    Public Overrides Function setElementCourant2(ByVal pElement As Persist) As Boolean
        Debug.Assert(pElement.GetType().Name.Equals("CommandeClient"))
        Dim bReturn As Boolean
        bReturn = MyBase.setElementCourant2(pElement)
        Return bReturn
    End Function 'SetElement
    Public Overrides Function AfficheElement() As Boolean


        Debug.Assert(Not getCommandeCourante() Is Nothing)
        Debug.Assert(Not getCommandeCourante.oTiers Is Nothing)

        debAffiche()
        MyBase.AfficheElement()

        'Type de Commande
        If getCommandeCourante.typeCommande = vncEnums.vncTypeCommande.vncCmdClientDirecte Then
            rbTypeCmdDirecte.Checked = True
        Else
            rbTypeCmdPlateforme.Checked = True
        End If

        'Type de Transport
        If getCommandeCourante.typeTransport = vncEnums.vncTypeTransport.vncTrpFranco Then
            rb_TypeTrp_Franco.Checked = True
        End If
        If getCommandeCourante.typeTransport = vncEnums.vncTypeTransport.vncTrpDepart Then
            rb_TypeTRP_Depart.Checked = True
        End If
        If getCommandeCourante.typeTransport = vncEnums.vncTypeTransport.vncTrpAvance Then
            rb_TypeTRP_Avance.Checked = True
        End If

        ckTransport.Checked = getCommandeCourante.bFactTransport

        'Informations de transport
        tbMailPLTF.Text = Param.getConstante("CST_PLTFRM_EMAIL")
        '        If getCommandeCourante.bFactTransport Then
        Dim objFactTRP As FactTRP
        If getCommandeCourante.idFactTransport <> 0 Then
            objFactTRP = FactTRP.createandload(getCommandeCourante.idFactTransport)
            liFactTRP.Text = objFactTRP.code & " " & objFactTRP.periode
            liFactTRP.Tag = getCommandeCourante.idFactTransport
            liFactTRP.Enabled = True
        Else
            liFactTRP.Text = ""
            liFactTRP.Enabled = False
        End If

        If getCommandeCourante().Date_EDI <> Nothing Then
            lblDateTransmissionEDI.Text = "Transmise le " + getCommandeCourante().Date_EDI.ToShortDateString()
        Else
            lblDateTransmissionEDI.Text = ""

        End If
        'Informations PrestaShop
        '        li()
        If String.IsNullOrEmpty(getCommandeCourante.NamePrestashop) Then
            Me.liPrestashop.Text = ""
            Me.liPrestashop.Enabled = False
        Else
            Me.liPrestashop.Text = getCommandeCourante.IDPrestashop & "/" & getCommandeCourante.NamePrestashop
            Me.liPrestashop.Enabled = True
        End If
        Me.cbxOrigine.Text = getCommandeCourante.Origine


        '       grpInfFactureTRP.Enabled = True
        '      Else
        '     grpInfFactureTRP.Enabled = False
        '    End If
        afficheListeSousCommande()

        finAffiche()
        Me.Cursor = Cursors.Default
        Return True
    End Function 'AfficheElement
    Protected Overrides Sub EnableControls(ByVal bEnabled As Boolean)
        MyBase.EnableControls(bEnabled)
        Try
            'Sur une commande en cours de saisie, il faut pouvoir changer le code client
            If m_action = vncEnums.vncfrmAction.FRMLOAD And getCommandeCourante.etat.codeEtat = vncEtatCommande.vncEnCoursSaisie Then
                tbCodeClient.Enabled = True
                cbRechercheclient.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Overrides Function MAJElement() As Boolean
        Dim bReturn As Boolean
        bReturn = MyBase.MAJElement()
        If bReturn Then
            'Type de Commande
            If rbTypeCmdDirecte.Checked = True Then
                getCommandeCourante.typeCommande = vncEnums.vncTypeCommande.vncCmdClientDirecte
            Else
                getCommandeCourante.typeCommande = vncEnums.vncTypeCommande.vncCmdClientPlateforme
            End If

            'Type de Transport
            If rb_TypeTrp_Franco.Checked = True Then
                getCommandeCourante.typeTransport = vncEnums.vncTypeTransport.vncTrpFranco
            End If
            If rb_TypeTRP_Depart.Checked = True Then
                getCommandeCourante.typeTransport = vncEnums.vncTypeTransport.vncTrpDepart
            End If
            If rb_TypeTRP_Avance.Checked = True Then
                getCommandeCourante.typeTransport = vncEnums.vncTypeTransport.vncTrpAvance
            End If

            'Transport Facturé
            If ckTransport.Checked = True Then
                getCommandeCourante.bFactTransport = True
            Else
                getCommandeCourante.bFactTransport = False
            End If

            'Prstashop
            'getCommandeCourante.IDPrestashop = tbIdPrestashop.Text
            'getCommandeCourante.NamePrestashop = tbNamePrestashop.Text
            getCommandeCourante.Origine = Me.cbxOrigine.Text
        End If

        Return bReturn
    End Function
    Public Overrides Function getResume() As String 'Rend le caption de la fenêtre
        If getCommandeCourante() Is Nothing Then
            Return "Gestion des Commandes Client"
        Else
            Return "Commande Client : " & getCommandeCourante.shortResume
        End If
    End Function 'getResume
    ''' <summary>
    ''' Sauvegarde de l'élement courant (Commande)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function SauveElement() As Boolean
        Debug.Assert(Not getCommandeCourante() Is Nothing)
        Dim bReturn As Boolean
        bReturn = getCommandeCourante.save
        If bReturn Then
            tbCode.Text = getCommandeCourante.code
            tbCode.Enabled = True
            MyBase.getResume()
        End If

        If bReturn And m_oFactHBV IsNot Nothing Then
            'Sauvegarde de la facture Hobivin si necessaire
            If m_oFactHBV.id <> 0 Then
                bReturn = m_oFactHBV.Save()
            End If
        End If
        Debug.Assert(bReturn, "Erreur en sauvegarde")
        Return bReturn
    End Function

#End Region
#Region "Methodes Redefinies"

    Protected Overrides Sub ActionLivrer()
        getCommandeCourante().changeEtat(vncActionEtatCommande.vncActionLivrer)
    End Sub
    Protected Overrides Sub ActionAnnLivrer()
        getCommandeCourante().changeEtat(vncActionEtatCommande.vncActionAnnLivrer)
    End Sub
    Protected Overrides Sub modifieruneLigneBL()
        ' On ne peut modifier une ligne d'une commande livrée
        If (getCommandeCourante().etat.codeEtat = vncEtatCommande.vncLivree And getCommandeCourante().etat.actionMvtStock = vncGenererSupprimer.vncGenerer) _
             Or getCommandeCourante().etat.codeEtat = vncEtatCommande.vncValidee Then
            MyBase.modifieruneLigneBL()

        Else
            MessageBox.Show(My.Resources.STR_LIGNE_NON_MODIFIABLE)
        End If
    End Sub
    Protected Overrides Function exporterWEBEDI() As Boolean
        Dim bReturn As Boolean
        Dim strFileName As String
        Dim strTempDir As String

        bReturn = True
        If getCommandeCourante().Date_EDI <> Nothing Then
            If MsgBox("Cette commande a déjà été transmise, voulez-vous la re-transmettre ?", vbYesNo, "Transmission EDI") = vbNo Then
                bReturn = False
            End If
        End If

        If bReturn Then
            Try
                strTempDir = Param.getConstante("CST_EDI_TEMP") + "/" + currentuser.code
                If Not My.Computer.FileSystem.DirectoryExists(strTempDir) Then
                    My.Computer.FileSystem.CreateDirectory(strTempDir)
                End If

                strFileName = strTempDir + "/" + getCommandeCourante.code + ".txt"

                If File.Exists(strFileName) Then
                    File.Delete(strFileName)
                End If
                Dim odlg As dlgExportWebEDI
                odlg = New dlgExportWebEDI()
                odlg.Setcommande(getCommandeCourante())
                If odlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    bReturn = getCommandeCourante.exporterWebEDI(strFileName, My.Settings.bCodeStatPlateforme)
                    If bReturn Then
                        If ExportMail.SendMail(Param.SMTP_HOST,
                                                Param.SMTP_PORT,
                                                Param.SMTP_SSL,
                                                Param.SMTP_USER,
                                                Param.SMTP_PWD,
                                                Param.SMTP_FROM,
                                                Me.tbMailPLTF.Text,
                                                "Commande Client N°" + getCommandeCourante.code + " " + getCommandeCourante.oTiers.nom,
                                                "",
                                                strFileName) Then

                            getCommandeCourante().Date_EDI = DateTime.Now
                            lblDateTransmissionEDI.Text = "Transmise le " + getCommandeCourante().Date_EDI.ToShortDateString()

                        Else
                            MsgBox("Erreur en envoi de Mail" + ExportMail.Message)
                        End If
                        My.Computer.FileSystem.DeleteFile(strFileName)
                    Else
                        MsgBox("Erreur en Export-Creation du fichier, Recommencer plus tard")
                    End If
                Else
                    bReturn = False
                End If
            Catch ex As Exception
                MsgBox("Erreur en Export-Creation du message, Recommencer plus tard" + ex.Message)
                bReturn = False
            End Try
        End If
        Return bReturn
    End Function
    Protected Overrides Function getbGestionMvtStock() As Boolean
        Debug.Assert(Not getCommandeCourante() Is Nothing, " CommandeCourante Is nothing")
        'Pas de gestion des Mvts de Stocks pour les commandes Directe
        If getCommandeCourante().typeCommande = vncEnums.vncTypeCommande.vncCmdClientDirecte Then
            Return False
        Else
            Return True
        End If
    End Function
    Protected Overrides Function getbGestionSousCommande() As Boolean
        Return True
    End Function

    Protected Overrides Function affichecrDetailCommande() As Boolean
        setcursorWait()
        'Affichage de l'état 'Détail de Commande'
        Dim objReport As ReportDocument

        objReport = New ReportDocument
        objReport.Load(PATHTOREPORTS & "crDetailCommandeClient.rpt")
        Persist.setReportConnection(objReport)
        setcrDetailCommandeClientParameters(objReport)
        crwDetailCommandeClient.ReportSource = objReport
        crwDetailCommandeClient.Zoom(1)
        restoreCursor()
        Return True
    End Function 'Affichage de l'état de détail de commande

    Protected Overrides Function faxerValidationCommande() As Boolean
        'Dim diskOpts As New CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim objFax As clsFax
        'Dim objReport As ReportDocument
        'Dim strFileName As String

        'setcursorWait()
        'If Not crwDetailCommandeClient.ReportSource Is Nothing Then

        '    objReport = crwDetailCommandeClient.ReportSource
        '    objReport.ExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.WordForWindows
        '    objReport.ExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
        '    strFileName = FAX_DETAILCOMMANDE_PATH & "DETCMD_" & getCommandeCourante.code & ".doc"
        '    diskOpts.DiskFileName = strFileName
        '    objReport.ExportOptions.DestinationOptions = diskOpts
        '    Try
        '        objReport.Export()
        '        objFax = New clsFax
        '        objFax.sendFax(FAX_NOM_INTERLOCUTEUR, FAX_TEL_INTERLOCUTEUR, FAX_DETAILCOMMANDE_SUBJECT, FAX_DETAILCOMMANDE_NOTES, FAX_DETAILCOMMANDE_BSENDCOVERPAGE, diskOpts.DiskFileName, tbNumFaxValidation.Text, getCommandeCourante.oTiers)
        '        objReport.Close()
        '        If System.IO.File.Exists(strFileName) Then
        '            System.IO.File.Delete(strFileName)
        '        End If
        '    Catch ex As Exception
        '        DisplayError("FaxerValidationCommande", "Erreur en Envoi de Fax" & ex.ToString)
        '    End Try
        'Else
        '    MsgBox("Vous devez d'abord visualiser la commande")
        'End If
        'restoreCursor()
        'Return True
    End Function 'Faxe la validation de commande
    Protected Overrides Function affichecrBL() As Boolean
        Dim strReportName As String
        setcursorWait()
        'Choix du rapport 'Bon de Livraison Plate-forme / Bon Livraison Transporteur"
        Dim objReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReportDocument
        strReportName = PATHTOREPORTS & "crBonLivraison.rpt"
        objReport.Load(strReportName)
        setcrBLParameters(objReport)
        Persist.setReportConnection(objReport)
        crwBL.ReportSource = objReport
        crwBL.Zoom(1)
        restoreCursor()
        Return True
    End Function 'Affichage du Bon de Livraison
    Protected Sub setcrBLParameters(ByVal objReport As ReportDocument)
        '===========================================================================
        'Function : setcrBLParameters
        'Description : Passe les paramétres à L'état BLBonAppo
        '===========================================================================
        'Passe les paramètres à l'état Crystal Report
        setcursorWait()
        objReport.SetParameterValue("IDCOMMANDE", getCommandeCourante.id)
        restoreCursor()
    End Sub 'Passe les paramètres à l'état Crystal Report
    Protected Overrides Function affichecrFactHBV() As Boolean
        Dim objReport As ReportDocument
        Dim strReportName As String
        'Si la facture n'a pas été générée, il faut la générer au préalable
        Dim oCmd As CommandeClient
        oCmd = getElementCourant()
        If m_oFactHBV Is Nothing Then
            'Rechargement de la facture si ça n'a pas déjà étét fait
            m_oFactHBV = FactHBV.createandloadFromCmd(oCmd.id)
        End If
        If m_oFactHBV.id = 0 Then
            If MsgBox("La facture n'a pas été générée, voulez-vous la générer maintenant ?", MsgBoxStyle.YesNo
                      ) = MsgBoxResult.Yes Then
                Cursor = Cursors.WaitCursor
                'QteFact = Qte Livrée
                For Each oLg As LgCommande In oCmd.colLignes
                    oLg.qteFact = oLg.qteLiv
                Next
                oCmd.save()
                m_oFactHBV = New FactHBV(oCmd)
                m_oFactHBV.Save()
                Cursor = Cursors.Default
            End If
        End If
        If (m_oFactHBV.id <> 0) Then
            m_oFactHBV.loadcolLignes()
            Cursor = Cursors.WaitCursor

            m_bsrcLgFactHBV.Clear()
            For Each oLg As LgFactHBV In m_oFactHBV.colLignes
                m_bsrcLgFactHBV.Add(oLg)
            Next

            objReport = New ReportDocument
            strReportName = PATHTOREPORTS & "crFactHobivin.rpt"
            objReport.Load(strReportName)
            objReport.SetParameterValue("IDCOMMANDE", m_oFactHBV.id)
            Persist.setReportConnection(objReport)
            '            objReport.ExportToDisk(ExportFormatType.PortableDocFormat, "FactHBV.pdf")
            '            System.Diagnostics.Process.Start("FactHBV.pdf")
            crwFact.ReportSource = objReport
            crwFact.Zoom(1)
            Cursor = Cursors.Default
        End If
        Return True
    End Function 'Affichage du Bon de Livraison
    Protected Overrides Function faxerBL(ByVal pnumfax As String, Optional ByVal poTiers As Tiers = Nothing) As Boolean
        'Dim diskOpts As New CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim objFax As clsFax
        'Dim objReport As ReportDocument
        'Dim strFileName As String

        'setcursorWait()
        'If Not crwBL.ReportSource Is Nothing Then

        '    objReport = crwBL.ReportSource
        '    objReport.ExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.WordForWindows
        '    objReport.ExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
        '    strFileName = FAX_BL_PATH & "BL_" & getCommandeCourante.code & ".doc"
        '    diskOpts.DiskFileName = strFileName
        '    objReport.ExportOptions.DestinationOptions = diskOpts
        '    Try
        '        objReport.Export()
        '        objFax = New clsFax
        '        objFax.sendFax(FAX_NOM_INTERLOCUTEUR, FAX_TEL_INTERLOCUTEUR, FAX_BL_SUBJECT, FAX_BL_NOTES, FAX_BL_BSENDCOVERPAGE, diskOpts.DiskFileName, pnumfax, poTiers)
        '        objReport.Close()
        '        If File.Exists(strFileName) Then
        '            File.Delete(strFileName)
        '        End If
        '    Catch ex As Exception
        '        DisplayError("FaxerBL", "Erreur en Envoi de Fax" & ex.ToString)
        '    End Try
        'Else
        '    MsgBox("Vous devez d'abord visualiser le Bon de Livraison")
        'End If
        'restoreCursor()
        Return True
    End Function 'FaxerBL
    '=======================================================================================
    'Fonction : visualiserSousCommande
    'Description : Affiche la boite de dialogue de visualisation de sous commande
    '=======================================================================================
    Protected Overrides Function visualiserSousCommande() As Boolean
        Dim bReturn As Boolean
        Dim odlg As dlgVisuBonFournisseur

        setcursorWait()
        Try
            If Not m_bsrcSousCommande.Current Is Nothing Then
                m_objSCMDCourante = m_bsrcSousCommande.Current
                sauvegardeElementCourant()
                odlg = New dlgVisuBonFournisseur
                odlg.setElement(m_objSCMDCourante)
                If odlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    setfrmUpdated()
                End If
                afficheListeSousCommande()
                bReturn = True
            End If
        Catch ex As Exception
            DisplayError("visualiserSousCommande", ex.Message)
            bReturn = False
        End Try
        Me.Cursor = Cursors.Default
        Return bReturn
    End Function 'visualiserSousCommande

    '========================================================================================
    'Fonction : faxerToutesLesSousCommandes
    'Description : Faxe toutes les sousCommandes qui ont un numéro de fax valide
    '========================================================================================
    'Protected Overrides Function faxerToutesLesSousCommandes() As Boolean
    '    Dim bReturn As Boolean
    '    Dim bToutOk As Boolean
    '    Try
    '        setcursorWait()
    '        sauvegardeElementCourant()
    '        bToutOk = True
    '        getCommandeCourante.faxerTout(FAX_SCMD_PATH, PATHTOREPORTS, FAX_NOM_INTERLOCUTEUR, FAX_TEL_INTERLOCUTEUR, FAX_SCMD_SUBJECT, FAX_SCMD_NOTES, FAX_SCMD_BSENDCOVERPAGE)
    '        'For Each objSCMD In getCommandeCourante.colSousCommandes
    '        '    If objSCMD.oFournisseur.AdresseFacturation.fax <> "" Then
    '        '        strFileName = FAX_SCMD_PATH & objSCMD.code & ".doc"
    '        '        If objSCMD.faxer(PATHTOREPORTS, FAX_NOM_INTERLOCUTEUR, FAX_TEL_INTERLOCUTEUR, FAX_SCMD_SUBJECT, FAX_SCMD_NOTES, FAX_SCMD_BSENDCOVERPAGE, strFileName, objSCMD.oFournisseur.AdresseFacturation.fax) Then
    '        '            objSCMD.changeEtat(vncEnums.vncActionEtatCommande.vncActionSCMDFaxer)
    '        '        Else
    '        '            bToutOk = False  ' Il y a au moins une erreur
    '        '        End If
    '        '    Else
    '        '        bToutOk = False  ' Il y a au moins une erreur
    '        '    End If
    '        'Next objSCMD
    '        If Not bToutOk Then
    '            MsgBox("Toutes les sous-Commandes n'ont pas été transmises, Vérifiez les numéros de fax et tentez une transmission unitaire")
    '        End If
    '        afficheListeSousCommande()
    '        restoreCursor()
    '        setfrmUpdated()
    '        bReturn = True
    '    Catch ex As Exception
    '        bReturn = False
    '        DisplayError("faxerToutesLesSousCommandes", ex.Message)
    '    End Try

    '    Return bReturn
    'End Function 'faxerToutesLesSousCommandes
    '==============================================================================================
    'Fonction initTPEclatement
    'Description : Initialisation de l'onglet Eclatement
    '==============================================================================================
    Protected Overrides Function initTPEclatement() As Boolean
        Dim bReturn As Boolean
        setcursorWait()
        Try
            Dim oClt As Client = Client.getIntermediairePourUneOrigine(getCommandeCourante().Origine)
            m_bsrcIntermédiaires.Clear()
            m_bsrcIntermédiaires.Add(oClt)
            cbxIntermédiaires.Enabled = True
            cbxIntermédiaires.Visible = True
            laIntermediaires.Visible = True

            If getCommandeCourante.etat.codeEtat = vncEnums.vncEtatCommande.vncEclatee Or getCommandeCourante.etat.codeEtat = vncEnums.vncEtatCommande.vncTransmiseQuadra Then
                getCommandeCourante.LoadColSousCommande()
                afficheListeSousCommande()
            Else
                If getCommandeCourante.etat.codeEtat = vncEnums.vncEtatCommande.vncLivree Then
                    cbEclatementCmde.Enabled = True
                    m_dgvSCMD.Enabled = True
                Else
                    cbEclatementCmde.Enabled = False
                    m_dgvSCMD.Enabled = False
                End If

            End If
            bReturn = True
        Catch ex As Exception
            bReturn = False
            DisplayError("InitTPEclatement", ex.Message)
        End Try
        Me.Cursor = Cursors.Default
        Return bReturn
    End Function 'initTPEclatement
    ''======================================================================
    ''Fonction : selectionneSousCommande
    ''Description : Selection d'une sous commande dans la liste et Affichage
    ''======================================================================
    'Protected Overrides Function selectionneSousCommande() As Boolean
    '    Debug.Assert(Not getCommandeCourante() Is Nothing)
    '    Debug.Assert(Not m_bsrcSousCommande Is Nothing)


    '    Dim bReturn As Boolean

    '    setcursorWait()
    '    Try
    '        'Pour savoir les sous-commandes ont été enregistrées, il suffit de regarder l'id de la première sous-commande
    '        If Not m_bsrcSousCommande.Current Is Nothing Then
    '            m_objSCMDCourante = m_bsrcSousCommande.Current
    '        End If

    '        m_objSCMDCourante.load()
    '        bReturn = True
    '    Catch ex As Exception
    '        Debug.Assert(False, "Impossible de sélectionner la sous-commande : ")
    '        bReturn = False
    '    End Try

    '    restoreCursor()
    '    Return bReturn
    'End Function 'selectionneSousCommande

    Protected Overrides Function AppliquerModifScmd() As Boolean
        If (Not m_bsrcSousCommande.Current Is Nothing) Then
            m_objSCMDCourante = m_bsrcSousCommande.Current
            m_objSCMDCourante.dateLivraison = dtSCMDDateLiv.Value
            m_objSCMDCourante.oTransporteur.AdresseLivraison.nom = tbSCMDTransporteurNom.Text
            m_objSCMDCourante.CommFacturation.comment = tbSCMDCommentaire.Text
        End If

    End Function


    '======================================================================
    'Fonction : EclatementCommande
    'Description : Eclatement de la commande Courante en sous_commande
    '======================================================================
    Protected Overrides Function eclatementCommande() As Boolean
        Debug.Assert(Not getCommandeCourante() Is Nothing)
        Dim bReturn As Boolean
        Dim oIntermediaire As Client = Nothing

        Me.Cursor = Cursors.WaitCursor
        If getCommandeCourante.etat.codeEtat <> vncEtatCommande.vncLivree Then
            MsgBox("La Commande n'est pas dans l'état requis")
            bReturn = False
        Else
            getCommandeCourante.LoadColSousCommande()
            'Eclatement de commande
            bReturn = getCommandeCourante.generationSousCommande()
            AfficheEtat()
            afficheListeSousCommande()
        End If
        Me.Cursor = Cursors.Default
        Return bReturn
    End Function 'EclatementCommande
    '======================================================================
    'Fonction : annulationEclatementCommande
    'Description : Annulation de l'eclatement de la commande Courante en sous_commande
    '======================================================================
    Protected Overrides Function annulationEclatementCommande() As Boolean
        Debug.Assert(Not getCommandeCourante() Is Nothing)
        Dim objSCMD As SousCommande
        Dim bReturn As Boolean
        Dim bSousFacturee As Boolean

        setcursorWait()
        If getCommandeCourante.etat.codeEtat <> vncEtatCommande.vncEclatee And getCommandeCourante.etat.codeEtat <> vncEtatCommande.vncTransmiseQuadra Then
            MsgBox("La Commande n'est pas dans l'état requis : Eclatée ou transmise")
            bReturn = False
        Else

            getCommandeCourante.LoadColSousCommande()
            Debug.Assert(getCommandeCourante.colSousCommandes.Count <> 0, "Pas de sous commandes")
            'Controle si les sous-commandes ont été facturées auquel cas il n'est pas possible de les supprimer
            bSousFacturee = False
            'vncSCMDGeneree = 10
            'vncSCMDtransmiseFax = 11
            'vncSCMDExporteeInt = 15
            'vncSCMDRapprochee = 12
            'vncSCMDRapprocheeInt = 16
            'vncSCMDProvisionnee = 13
            'vncSCMDFacturee = 14

            If getCommandeCourante.etat.codeEtat <> vncEtatCommande.vncEclatee Then
                For Each objSCMD In getCommandeCourante.colSousCommandes
                    If objSCMD.etat.codeEtat <> vncEnums.vncEtatCommande.vncSCMDGeneree Then
                        bSousFacturee = True
                        Exit For
                    End If
                Next
                If bSousFacturee Then
                    MsgBox("Au moins une sous-commande a été transmise, rapprochée ou facturée , il n'est plus possible d'annuler l'éclatement")
                    Me.Cursor = Cursors.Default
                    Return False
                End If
            End If
            getCommandeCourante.colSousCommandes.clear()
            getCommandeCourante.changeEtat(vncEnums.vncActionEtatCommande.vncActionAnnEclater)
            AfficheEtat()
            afficheListeSousCommande()
            bReturn = True
        End If
        Me.Cursor = Cursors.Default
        Return bReturn
    End Function 'annulationEclatementCommande
    '========================================================================
    'Fonction : AfficcheListeSousCommandes
    'Description : Affiche la liste des SousCommandes 
    '========================================================================
    Private Sub afficheListeSousCommande()
        Debug.Assert(Not getCommandeCourante() Is Nothing)
        Dim objSCMD As SousCommande

        setcursorWait()
        debAffiche()


        m_bsrcSousCommande.Clear()
        For Each objSCMD In getCommandeCourante.colSousCommandes
            m_bsrcSousCommande.Add(objSCMD)
        Next objSCMD


        finAffiche()
        restoreCursor()

    End Sub 'AfficheListeSousCommande
    Private Function faxerValidationCommandeClient() As Boolean
        'Dim diskOpts As New CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim objFax As clsFax
        'Dim objReport As ReportDocument

        'setcursorWait()
        'If Not crwDetailCommandeClient.ReportSource Is Nothing Then

        '    objReport = crwDetailCommandeClient.ReportSource
        '    objReport.ExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.WordForWindows
        '    objReport.ExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
        '    diskOpts.DiskFileName = FAX_DETAILCOMMANDE_PATH & "DETCMD_" & getCommandeCourante.code & ".doc"
        '    objReport.ExportOptions.DestinationOptions = diskOpts
        '    Try
        '        objReport.Export()
        '        objFax = New clsFax
        '        objFax.sendFax(FAX_NOM_INTERLOCUTEUR, FAX_TEL_INTERLOCUTEUR, FAX_DETAILCOMMANDE_SUBJECT, FAX_DETAILCOMMANDE_NOTES, FAX_DETAILCOMMANDE_BSENDCOVERPAGE, diskOpts.DiskFileName, tbNumFaxValidation.Text, getCommandeCourante.oTiers)
        '    Catch ex As Exception
        '        DisplayError("FaxerValidationCommande", "Erreur en Envoi de Fax" & ex.ToString)
        '    End Try
        'Else
        '    MsgBox("Vous devez d'abord visualiser la commande")
        'End If
        'restoreCursor()
        Return True

    End Function 'Faxe la validation de commande
    Protected Overrides Function setcrDetailCommandeClientParameters(ByVal objReport As ReportDocument) As Boolean
        'Passe les paramètres à l'état Crystal Report
        objReport.SetParameterValue("IDCommande", getCommandeCourante.id)
        Return True
    End Function 'Passe les paramètres à l'état Crystal Report
    'Private Sub setEnabled2(ByVal pbEnabled As Boolean)
    '    'Met à jour la Propriété Enabled des controles de la fentre
    '    setcursorWait()
    '    tbCode.Enabled = pbEnabled
    '    dtDateCommande.Enabled = pbEnabled
    '    rb_TypeTRP_Avance.Enabled = pbEnabled
    '    rb_TypeTRP_Depart.Enabled = pbEnabled
    '    rb_TypeTrp_Franco.Enabled = pbEnabled
    '    rbTypeCmdDirecte.Enabled = pbEnabled
    '    rbTypeCmdPlateforme.Enabled = pbEnabled
    '    tbCodeClient.Enabled = pbEnabled
    '    cbRechercheclient.Enabled = pbEnabled
    '    tbNomClient.Enabled = pbEnabled
    '    tbRaisonSociale.Enabled = pbEnabled
    '    tbAdrLiv_Nom.Enabled = pbEnabled
    '    tbAdrLiv_Rue1.Enabled = pbEnabled
    '    tbAdrLiv_Rue2.Enabled = pbEnabled
    '    tbAdrLiv_cp.Enabled = pbEnabled
    '    tbAdrLiv_Ville.Enabled = pbEnabled
    '    tbAdrLiv_Tel.Enabled = pbEnabled
    '    tbAdrLiv_Fax.Enabled = pbEnabled
    '    tbAdrLiv_Port.Enabled = pbEnabled
    '    tbAdrLiv_Email.Enabled = pbEnabled
    '    tbAdrFact_Nom.Enabled = pbEnabled
    '    tbAdrFact_Rue1.Enabled = pbEnabled
    '    tbAdrFact_Rue2.Enabled = pbEnabled
    '    tbAdrFact_cp.Enabled = pbEnabled
    '    tbAdrFact_Ville.Enabled = pbEnabled
    '    tbAdrFact_Tel.Enabled = pbEnabled
    '    tbAdrFact_Fax.Enabled = pbEnabled
    '    tbAdrFact_Port.Enabled = pbEnabled
    '    tbAdrFact_Email.Enabled = pbEnabled
    '    cboModeReglement.Enabled = pbEnabled
    '    tbBanque.Enabled = pbEnabled
    '    tbRib1.Enabled = pbEnabled
    '    tbRib2.Enabled = pbEnabled
    '    tbRib3.Enabled = pbEnabled
    '    tbRib4.Enabled = pbEnabled

    '    SSTabCommandeClient.Enabled = pbEnabled
    '    restoreCursor()

    'End Sub
    Private Sub initTPValidCMD()
        setcursorWait()
        tbNumFaxValidation.Text = tbAdrLiv_Fax.Text
        restoreCursor()
    End Sub
    Public Overrides Sub initTPBL()
        setcursorWait()
        debAffiche()
        crwBL.Enabled = False
        cbVisuBL.Enabled = False
        grpTransporteur.Enabled = True
        dtDateEnlev.Enabled = False
        dtDateLivraison.Enabled = False
        cbMailBLPLTFRM.Enabled = False
        'Choix du type de bon (uniquement pour les commandes avec transport)
        'If getCommandeCourante.bFactTransport Then
        ''grpBonTransport.Enabled = True
        'grpInfFactureTRP.Enabled = True
        'cbFaxerBLTransporteur.Enabled = True
        'Else
        '    'grpBonTransport.Enabled = False
        '    grpInfFactureTRP.Enabled = False
        '    cbFaxerBLTransporteur.Enabled = False
        'End If
        If getCommandeCourante.typeCommande = vncEnums.vncTypeCommande.vncCmdClientPlateforme Then
            crwBL.Enabled = True
            cbVisuBL.Enabled = True
            '           grpTransporteur.Enabled = False
            dtDateEnlev.Enabled = True
            dtDateLivraison.Enabled = True
            cbMailBLPLTFRM.Enabled = True
            tbMailPLTF.Text = Param.getConstante("CST_PLTFRM_EMAIL")
            tbMailPLTF.Enabled = True
        Else
            tbMailPLTF.Text = Param.getConstante("CST_PLTFRM_EMAIL")
            tbMailPLTF.Enabled = False
        End If

        If getCommandeCourante.typeCommande = vncEnums.vncTypeCommande.vncCmdClientDirecte And getCommandeCourante.typeTransport = vncEnums.vncTypeTransport.vncTrpDepart Then
            crwBL.Enabled = True
            cbVisuBL.Enabled = True
            '            grpTransporteur.Enabled = True
            dtDateEnlev.Enabled = True
            dtDateLivraison.Enabled = True
            cbMailBLPLTFRM.Enabled = True
            '            tbPiedPageBL.Text = tbCommentaireLivraison.Text
        End If
        finAffiche()
        restoreCursor()
    End Sub
    Protected Overrides Sub blToutOK()
        Debug.Assert(Not getCommandeCourante() Is Nothing)
        'Dim oLgCom As LgCommande
        'Dim bReturn As Boolean

        setcursorWait()
        getCommandeCourante.LivrerToutOK()
        If getCommandeCourante.estPartiellementLivree() Then
            ActionLivrer()
        End If
        AfficheEtat()
        affichecolLignes()
        setfrmUpdated()
        restoreCursor()
    End Sub 'BLToutOK
    'Fonction : AnnulerLivraison
    'Description : Annule la Livraison => changement d'état , suppression des mvt de stocks à la prochaine Sauvegarde
    Protected Overrides Sub annulerLivraison()
        Dim oLgCom As LgCommande
        Debug.Assert(Not getCommandeCourante() Is Nothing)

        setcursorWait()
        If getCommandeCourante.etat.codeEtat = vncEnums.vncEtatCommande.vncLivree Then
            For Each oLgCom In getCommandeCourante.colLignes
                oLgCom.qteLiv = 0
                'Calcul de la commission sur la Quantité Commandée
                oLgCom.CalculCommission(getCommandeCourante.Origine, CalculCommQte.CALCUL_COMMISSION_QTE_CMDE)
            Next oLgCom
            ActionAnnLivrer()
            AfficheEtat()
            affichecolLignes()
        End If
        frmSave()
        restoreCursor()
    End Sub

#End Region 'Méthodes Privées


    Private Sub frmCommandeClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Not DesignMode) Then
            debAffiche()
            m_TypeDonnees = vncEnums.vncTypeDonnee.COMMANDECLIENT
            grpFactTRP.Enabled = True
            grpFactTRP.Visible = True
            grpPrestashop.Visible = True
            grpPrestashop.Enabled = True

            finAffiche()
            If currentuser.role = vncEnums.userRole.ADMIN Or currentuser.role = vncEnums.userRole.COMPTABILITE Then
                laMtComm.Visible = True
                tbMtComm.Visible = True
            Else
                laMtComm.Visible = False
                tbMtComm.Visible = False
            End If
            SSTabCommandeClient.TabPages.RemoveByKey(tpFactHbv.Name)
        End If

    End Sub


    Private Sub btnCtrlStock_Click(sender As Object, e As EventArgs) Handles btnCtrlStock.Click
        setcursorWait()
        getCommandeCourante().controleStockDispo()
        m_bsrcLignesCommande.ResetBindings(False)
        restoreCursor()
    End Sub

    Private Sub cbAjouterLigne_Click(sender As Object, e As EventArgs) Handles cbAjouterLigne.Click

    End Sub
End Class
