Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports vini_DB
Public Class frmStatProduitFournisseur
    Inherits frmStatistiques

#Region " Code g�n�r� par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent()

    End Sub

    'La m�thode substitu�e Dispose du formulaire pour nettoyer la liste des composants.
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

    'REMARQUE�: la proc�dure suivante est requise par le Concepteur Windows Form
    'Elle peut �tre modifi�e en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'�diteur de code.
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbAfficher As System.Windows.Forms.Button
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtdeb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbcodeFourn As System.Windows.Forms.TextBox
    Friend WithEvents cbxOrigine As System.Windows.Forms.ComboBox
    Friend WithEvents laFiltreDossier As System.Windows.Forms.Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbDossierProduit As RadioButton
    Friend WithEvents rbOrigineCommande As RadioButton
    Friend WithEvents ckAfficheDetail As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbcodeFourn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAfficher = New System.Windows.Forms.Button()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtdeb = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckAfficheDetail = New System.Windows.Forms.CheckBox()
        Me.cbxOrigine = New System.Windows.Forms.ComboBox()
        Me.laFiltreDossier = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbDossierProduit = New System.Windows.Forms.RadioButton()
        Me.rbOrigineCommande = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'tbcodeFourn
        '
        Me.tbcodeFourn.Location = New System.Drawing.Point(552, 8)
        Me.tbcodeFourn.Name = "tbcodeFourn"
        Me.tbcodeFourn.Size = New System.Drawing.Size(100, 20)
        Me.tbcodeFourn.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(446, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Code Fournisseur"
        '
        'cbAfficher
        '
        Me.cbAfficher.Location = New System.Drawing.Point(864, 8)
        Me.cbAfficher.Name = "cbAfficher"
        Me.cbAfficher.Size = New System.Drawing.Size(120, 23)
        Me.cbAfficher.TabIndex = 14
        Me.cbAfficher.Text = "Afficher"
        '
        'dtFin
        '
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(336, 8)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(104, 20)
        Me.dtFin.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(248, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date de Fin"
        '
        'dtdeb
        '
        Me.dtdeb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdeb.Location = New System.Drawing.Point(104, 8)
        Me.dtdeb.Name = "dtdeb"
        Me.dtdeb.Size = New System.Drawing.Size(136, 20)
        Me.dtdeb.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date de D�but"
        '
        'ckAfficheDetail
        '
        Me.ckAfficheDetail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckAfficheDetail.Location = New System.Drawing.Point(672, 8)
        Me.ckAfficheDetail.Name = "ckAfficheDetail"
        Me.ckAfficheDetail.Size = New System.Drawing.Size(104, 24)
        Me.ckAfficheDetail.TabIndex = 15
        Me.ckAfficheDetail.Text = "Detail Produit"
        '
        'cbxOrigine
        '
        Me.cbxOrigine.FormattingEnabled = True
        Me.cbxOrigine.Items.AddRange(New Object() {"VINICOM", "HOBIVIN"})
        Me.cbxOrigine.Location = New System.Drawing.Point(552, 38)
        Me.cbxOrigine.Name = "cbxOrigine"
        Me.cbxOrigine.Size = New System.Drawing.Size(136, 21)
        Me.cbxOrigine.TabIndex = 16
        Me.cbxOrigine.Text = "VINICOM"
        '
        'laFiltreDossier
        '
        Me.laFiltreDossier.AutoSize = True
        Me.laFiltreDossier.Location = New System.Drawing.Point(446, 41)
        Me.laFiltreDossier.Name = "laFiltreDossier"
        Me.laFiltreDossier.Size = New System.Drawing.Size(83, 13)
        Me.laFiltreDossier.TabIndex = 17
        Me.laFiltreDossier.Text = "Dossier produit :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fitr� par"
        '
        'rbDossierProduit
        '
        Me.rbDossierProduit.AutoSize = True
        Me.rbDossierProduit.Checked = True
        Me.rbDossierProduit.Location = New System.Drawing.Point(104, 40)
        Me.rbDossierProduit.Name = "rbDossierProduit"
        Me.rbDossierProduit.Size = New System.Drawing.Size(96, 17)
        Me.rbDossierProduit.TabIndex = 19
        Me.rbDossierProduit.TabStop = True
        Me.rbDossierProduit.Text = "Dossier Produit"
        Me.rbDossierProduit.UseVisualStyleBackColor = True
        '
        'rbOrigineCommande
        '
        Me.rbOrigineCommande.AutoSize = True
        Me.rbOrigineCommande.Location = New System.Drawing.Point(207, 40)
        Me.rbOrigineCommande.Name = "rbOrigineCommande"
        Me.rbOrigineCommande.Size = New System.Drawing.Size(139, 17)
        Me.rbOrigineCommande.TabIndex = 20
        Me.rbOrigineCommande.TabStop = True
        Me.rbOrigineCommande.Text = "Origine de la commande"
        Me.rbOrigineCommande.UseVisualStyleBackColor = True
        '
        'frmStatProduitFournisseur
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 678)
        Me.Controls.Add(Me.rbOrigineCommande)
        Me.Controls.Add(Me.rbDossierProduit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.laFiltreDossier)
        Me.Controls.Add(Me.cbxOrigine)
        Me.Controls.Add(Me.ckAfficheDetail)
        Me.Controls.Add(Me.tbcodeFourn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbAfficher)
        Me.Controls.Add(Me.dtFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtdeb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStatProduitFournisseur"
        Me.Text = "Statistiques fournisseur"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dtdeb, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.dtFin, 0)
        Me.Controls.SetChildIndex(Me.cbAfficher, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.tbcodeFourn, 0)
        Me.Controls.SetChildIndex(Me.ckAfficheDetail, 0)
        Me.Controls.SetChildIndex(Me.cbxOrigine, 0)
        Me.Controls.SetChildIndex(Me.laFiltreDossier, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.rbDossierProduit, 0)
        Me.Controls.SetChildIndex(Me.rbOrigineCommande, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "M�thodes priv�es"
    Private Sub initFenetre()
        dtFin.Value = Now()
        dtdeb.Value = CDate("01/01/" & Year(Now()))
        cbxOrigine.Items.Clear()
        cbxOrigine.Items.Add(Dossier.VINICOM)
        cbxOrigine.Items.Add(Dossier.HOBIVIN)
    End Sub
#End Region


    Private Sub cbAfficher_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAfficher.Click

        Dim objReport As ReportDocument
        Dim anneeN_1 As Integer
        Dim str As String

        objReport = New ReportDocument
        objReport.Load(PATHTOREPORTS & "crStatProduitFournisseur.rpt")


        objReport.SetParameterValue("ddeb", Me.dtdeb.Value.ToShortDateString())
        objReport.SetParameterValue("dfin", Me.dtFin.Value.ToShortDateString())

        anneeN_1 = Year(DateAdd(DateInterval.Year, -1, dtdeb.Value))
        objReport.SetParameterValue("N-1", anneeN_1)

        str = tbcodeFourn.Text
        str = Replace(str, "%", "*")
        objReport.SetParameterValue("codefourn", Trim(str))

        objReport.SetParameterValue("bAfficheProduit", ckAfficheDetail.Checked)
        objReport.SetParameterValue("Origine", cbxOrigine.Text)
        objReport.SetParameterValue("bFiltreOrigineCommande", rbOrigineCommande.Checked)

        Persist.setReportConnection(objReport)
        Try

            CrystalReportViewer1.ReportSource = objReport
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmStatFournisseur_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initFenetre()
    End Sub

    Public Overrides Function getResume() As String
        Return "Statistique Fournisseur"
    End Function

    Private Sub rbDossierProduit_CheckedChanged(sender As Object, e As EventArgs) Handles rbDossierProduit.CheckedChanged
        If rbDossierProduit.Checked Then
            laFiltreDossier.Text = "Dossier produit"
        Else
            laFiltreDossier.Text = "Origine Commande"
        End If
    End Sub
End Class