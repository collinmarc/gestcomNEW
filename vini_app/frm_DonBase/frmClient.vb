Imports vini_DB
Public Class frmClient
    Inherits frmTiers



#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        m_TypeDonnees = vncEnums.vncTypeDonnee.CLIENT
        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    'Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents cboTypeClient As System.Windows.Forms.ComboBox
    'Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbxCodeTarif As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label231 As System.Windows.Forms.Label
    Friend WithEvents laOrigine As System.Windows.Forms.Label
    Friend WithEvents cbxOrigine As System.Windows.Forms.ComboBox
    Friend WithEvents Label2311 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BIC As Label
    Friend WithEvents TextBox2 As TextBox
    ' Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ckArchive As CheckBox
    Friend WithEvents cbPrecommande As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboTypeClient = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbPrecommande = New System.Windows.Forms.Button()
        Me.Label231 = New System.Windows.Forms.Label()
        Me.cbxCodeTarif = New System.Windows.Forms.ComboBox()
        Me.laOrigine = New System.Windows.Forms.Label()
        Me.cbxOrigine = New System.Windows.Forms.ComboBox()
        Me.Label2311 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BIC = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ckArchive = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cboTypeClient
        '
        Me.cboTypeClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTypeClient.BackColor = System.Drawing.SystemColors.Window
        Me.cboTypeClient.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTypeClient.DisplayMember = "RQ_TypeClient.PAR_ID"
        Me.cboTypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTypeClient.Enabled = False
        Me.cboTypeClient.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTypeClient.Location = New System.Drawing.Point(784, 8)
        Me.cboTypeClient.Name = "cboTypeClient"
        Me.cboTypeClient.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTypeClient.Size = New System.Drawing.Size(176, 21)
        Me.cboTypeClient.TabIndex = 2
        Me.cboTypeClient.ValueMember = "RQ_TypeClient.PAR_ID"
        '
        'Label41
        '
        Me.Label41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.BackColor = System.Drawing.SystemColors.Control
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(672, 8)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(89, 17)
        Me.Label41.TabIndex = 16
        Me.Label41.Text = "Type de Client"
        '
        'cbPrecommande
        '
        Me.cbPrecommande.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPrecommande.CausesValidation = False
        Me.cbPrecommande.Enabled = False
        Me.cbPrecommande.Location = New System.Drawing.Point(784, 80)
        Me.cbPrecommande.Name = "cbPrecommande"
        Me.cbPrecommande.Size = New System.Drawing.Size(176, 24)
        Me.cbPrecommande.TabIndex = 70
        Me.cbPrecommande.Text = "Pré-&Commande"
        '
        'Label231
        '
        Me.Label231.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label231.AutoSize = True
        Me.Label231.Location = New System.Drawing.Point(781, 56)
        Me.Label231.Name = "Label231"
        Me.Label231.Size = New System.Drawing.Size(56, 13)
        Me.Label231.TabIndex = 71
        Me.Label231.Text = "Code Tarif"
        '
        'cbxCodeTarif
        '
        Me.cbxCodeTarif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxCodeTarif.FormattingEnabled = True
        Me.cbxCodeTarif.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbxCodeTarif.Location = New System.Drawing.Point(842, 53)
        Me.cbxCodeTarif.Name = "cbxCodeTarif"
        Me.cbxCodeTarif.Size = New System.Drawing.Size(117, 21)
        Me.cbxCodeTarif.TabIndex = 72
        '
        'laOrigine
        '
        Me.laOrigine.AutoSize = True
        Me.laOrigine.Location = New System.Drawing.Point(785, 38)
        Me.laOrigine.Name = "laOrigine"
        Me.laOrigine.Size = New System.Drawing.Size(40, 13)
        Me.laOrigine.TabIndex = 73
        Me.laOrigine.Text = "Origine"
        '
        'cbxOrigine
        '
        Me.cbxOrigine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxOrigine.FormattingEnabled = True
        Me.cbxOrigine.Items.AddRange(New Object() {"VINICOM", "HOBIVIN"})
        Me.cbxOrigine.Location = New System.Drawing.Point(839, 30)
        Me.cbxOrigine.Name = "cbxOrigine"
        Me.cbxOrigine.Size = New System.Drawing.Size(121, 21)
        Me.cbxOrigine.TabIndex = 74
        '
        'Label2311
        '
        Me.Label2311.AutoSize = True
        Me.Label2311.Location = New System.Drawing.Point(342, 432)
        Me.Label2311.Name = "Label2311"
        Me.Label2311.Size = New System.Drawing.Size(32, 13)
        Me.Label2311.TabIndex = 109
        Me.Label2311.Text = "IBAN"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(510, 432)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 110
        '
        'BIC
        '
        Me.BIC.AutoSize = True
        Me.BIC.Location = New System.Drawing.Point(342, 455)
        Me.BIC.Name = "BIC"
        Me.BIC.Size = New System.Drawing.Size(24, 13)
        Me.BIC.TabIndex = 111
        Me.BIC.Text = "BIC"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(510, 452)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 112
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(342, 435)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 109
        Me.Label24.Text = "IBAN"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(342, 458)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(24, 13)
        Me.Label26.TabIndex = 111
        Me.Label26.Text = "BIC"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(506, 434)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(350, 20)
        Me.TextBox3.TabIndex = 109
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(506, 456)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(350, 20)
        Me.TextBox4.TabIndex = 110
        '
        'ckArchive
        '
        Me.ckArchive.AutoSize = True
        Me.ckArchive.Location = New System.Drawing.Point(525, 10)
        Me.ckArchive.Name = "ckArchive"
        Me.ckArchive.Size = New System.Drawing.Size(62, 17)
        Me.ckArchive.TabIndex = 75
        Me.ckArchive.Text = "Archivé"
        Me.ckArchive.UseVisualStyleBackColor = True
        '
        'frmClient
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(968, 734)
        Me.Controls.Add(Me.ckArchive)
        Me.Controls.Add(Me.cbxOrigine)
        Me.Controls.Add(Me.laOrigine)
        Me.Controls.Add(Me.cbxCodeTarif)
        Me.Controls.Add(Me.Label231)
        Me.Controls.Add(Me.cbPrecommande)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.cboTypeClient)
        Me.Name = "frmClient"
        Me.Text = "Gestion des clients"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.tbCode, 0)
        Me.Controls.SetChildIndex(Me.tbRaisonSociale, 0)
        Me.Controls.SetChildIndex(Me.cboTypeClient, 0)
        Me.Controls.SetChildIndex(Me.Label41, 0)
        Me.Controls.SetChildIndex(Me.cbPrecommande, 0)
        Me.Controls.SetChildIndex(Me.Label231, 0)
        Me.Controls.SetChildIndex(Me.cbxCodeTarif, 0)
        Me.Controls.SetChildIndex(Me.laOrigine, 0)
        Me.Controls.SetChildIndex(Me.cbxOrigine, 0)
        Me.Controls.SetChildIndex(Me.ckArchive, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Protected Overrides Function creerElement() As Boolean
        Debug.Assert(Not isfrmUpdated(), "La fenetre n'est pas libre")

        setElementCourant2(New Client("", ""))

        Return True
    End Function

    Public Overrides Function getResume() As String 'Rend le caption de la fenêtre
        If getElementCourant() Is Nothing Then
            Return "Gestion des Clients"
        Else
            Return "Client : " & getElementCourant().shortResume
        End If
    End Function 'getResume

    Public Overrides Function AfficheElement() As Boolean
        Dim objclient As Client
        Dim objParam As Param
        Dim bReturn As Boolean
        Dim str As String

        Debug.Assert(getElementCourant.GetType().Name.Equals("Client"), "Objet de type Client requis")


        bReturn = MyBase.AfficheElement()
        If bReturn Then
            objclient = CType(getElementCourant(), Client)

            For Each objParam In cboTypeClient.Items
                If objParam.id = objclient.idTypeClient Then
                    cboTypeClient.SelectedItem = objParam
                    Exit For
                End If
            Next

            cbxOrigine.Text = objclient.Origine
            For Each str In cbxCodeTarif.Items
                If str.Equals(objclient.CodeTarif) Then
                    cbxCodeTarif.SelectedItem = str
                    Exit For
                End If
            Next

            tbIBAN.Text = objclient.IBAN
            tbBIC.Text = objclient.BIC
            ckArchive.Checked = objclient.bArchive
            If ckArchive.Checked Then
                Me.BackColor = Color.Orange
                EnableControls(False)
                ckArchive.Enabled = True
            End If
        End If
            Return bReturn
    End Function 'AfficheElementCourant

    Public Overrides Function MAJElement() As Boolean
        Dim bReturn As Boolean
        Dim objClient As Client
        bReturn = MyBase.MAJElement()
        If bReturn Then

            objClient = getElementCourant()
            Try
                objClient.idTypeClient = cboTypeClient.SelectedItem.id
                objClient.CodeTarif = cbxCodeTarif.SelectedItem
                objClient.Origine = cbxOrigine.Text
                objClient.IBAN = tbIBAN.Text
                objClient.BIC = tbBIC.Text
                objClient.bArchive = ckArchive.Checked

                bReturn = True
            Catch ex As Exception
                DisplayError("frmClientTab.MAJElement", ex.ToString())
                bReturn = False
            End Try
        End If
        Return bReturn
    End Function 'MAJElementCourant

    Private Sub cbPrecommande_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrecommande.Click
        Debug.Assert(Not getElementCourant() Is Nothing)
        Dim ofrmPreCommande As frmPrecommande
        Dim bOk As Boolean = True

        If isfrmUpdated() Then
            If MsgBox("L'élement courant a été modifié, souhaitez-vous l'enregister?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If frmSave() Then
                    bOk = True
                Else
                    bOk = False
                End If
            Else
                bOk = False
            End If
        End If

        If bOk Then
            ofrmPreCommande = New frmPrecommande
            'Le parent MDI en le même que celui de la fenêtre courante
            ofrmPreCommande.MdiParent = MdiParent
            'Affiche la fenêtre 
            'il faut afficher la fentre avant l'init afin de déclencher l'évènement Load => initFenetre
            ofrmPreCommande.Show()
            'L'élément courant est le client courant
            If ofrmPreCommande.setElementCourant2(getElementCourant()) Then
                ofrmPreCommande.AfficheElementCourant()
            End If
        End If
    End Sub

    Private Sub initFenetre()
        Dim objTypeClient As Param
        debAffiche()
        laModeReglmt.Text = "Commande"
        laModeRglmt1.Text = "Transport"
        LaModeReglmt2.Visible = False
        cboModeReglement2.Visible = False

        cboTypeClient.DisplayMember = "Valeur"
        cboTypeClient.ValueMember = "id"
        For Each objTypeClient In Param.colTypeClient
            cboTypeClient.Items.Add(objTypeClient)
        Next
        finAffiche()
    End Sub

    Private Sub frmClientTab_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
    End Sub

    Public Overrides Function ControleAvantSauvegarde() As Boolean
        Dim bReturn As Boolean
        bReturn = True
        If getElementCourant().bNew = True Then
            'controle de l'unicité du code
            If Client.getListe(tbCode.Text).Count > 0 Then
                DisplayError("Controleavantsauvegarde", "Le code Client doit être unique")
                bReturn = False
            End If
        End If
        bReturn = bReturn And MyBase.ControleAvantSauvegarde()
        Return bReturn

    End Function

    Private Sub cboTypeClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTypeClient.SelectedIndexChanged
        changeTypeClient()
    End Sub

    Public Function changeTypeClient() As Boolean
        Dim bReturn As Boolean
        Try
            'If cboTypeClient.Text = "Intermédiaire" Then
            '    laOrigine.Visible = True
            '    cbxOrigine.Visible = True
            'Else
            '    laOrigine.Visible = False
            '    cbxOrigine.Visible = False
            'End If
        Catch ex As Exception
            bReturn = False
        End Try
        Return bReturn
    End Function

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label2311.Click

    End Sub

    Private Sub ckArchive_CheckedChanged(sender As Object, e As EventArgs) Handles ckArchive.CheckedChanged
        If ckArchive.Checked Then
            Me.BackColor = Color.Orange
            EnableControls(False)
            ckArchive.Enabled = True
        Else
            Me.BackColor = SystemColors.Control
            EnableControls(True)
            ckArchive.Enabled = True
        End If
    End Sub
End Class
