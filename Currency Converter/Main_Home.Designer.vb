<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.tlprbDenominations = New System.Windows.Forms.TableLayoutPanel()
        Me.rbDenominationsYes = New System.Windows.Forms.RadioButton()
        Me.rbDenominationsNo = New System.Windows.Forms.RadioButton()
        Me.lblDenominations = New System.Windows.Forms.Label()
        Me.lblInputAmount = New System.Windows.Forms.Label()
        Me.txtInputAmount = New System.Windows.Forms.TextBox()
        Me.lbConversion = New System.Windows.Forms.Label()
        Me.rbDollarPound = New System.Windows.Forms.RadioButton()
        Me.rbPoundDollar = New System.Windows.Forms.RadioButton()
        Me.rbPoundEuro = New System.Windows.Forms.RadioButton()
        Me.rbEuroPound = New System.Windows.Forms.RadioButton()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.txtStreetName = New System.Windows.Forms.TextBox()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtNIN = New System.Windows.Forms.TextBox()
        Me.lblNIN = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lbluserSecondName = New System.Windows.Forms.Label()
        Me.txtuserSurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.txtuserFirstName = New System.Windows.Forms.TextBox()
        Me.menuHome = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.txtLoss = New System.Windows.Forms.TextBox()
        Me.lblLoss = New System.Windows.Forms.Label()
        Me.txtOutputAfterCommission = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOuputBeforeCommission = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpInput.SuspendLayout()
        Me.tlprbDenominations.SuspendLayout()
        Me.menuHome.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnConvert)
        Me.grpInput.Controls.Add(Me.tlprbDenominations)
        Me.grpInput.Controls.Add(Me.lblDenominations)
        Me.grpInput.Controls.Add(Me.lblInputAmount)
        Me.grpInput.Controls.Add(Me.txtInputAmount)
        Me.grpInput.Controls.Add(Me.lbConversion)
        Me.grpInput.Controls.Add(Me.rbDollarPound)
        Me.grpInput.Controls.Add(Me.rbPoundDollar)
        Me.grpInput.Controls.Add(Me.rbPoundEuro)
        Me.grpInput.Controls.Add(Me.rbEuroPound)
        Me.grpInput.Controls.Add(Me.txtTownCity)
        Me.grpInput.Controls.Add(Me.lblTown)
        Me.grpInput.Controls.Add(Me.lblStreetName)
        Me.grpInput.Controls.Add(Me.txtStreetName)
        Me.grpInput.Controls.Add(Me.txtHouseNumber)
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.lblPostcode)
        Me.grpInput.Controls.Add(Me.txtPostcode)
        Me.grpInput.Controls.Add(Me.txtNIN)
        Me.grpInput.Controls.Add(Me.lblNIN)
        Me.grpInput.Controls.Add(Me.dtpDOB)
        Me.grpInput.Controls.Add(Me.lblDOB)
        Me.grpInput.Controls.Add(Me.lbluserSecondName)
        Me.grpInput.Controls.Add(Me.txtuserSurname)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Controls.Add(Me.lblTitle)
        Me.grpInput.Controls.Add(Me.cmbTitle)
        Me.grpInput.Controls.Add(Me.txtuserFirstName)
        Me.grpInput.Location = New System.Drawing.Point(12, 27)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(405, 384)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input Values"
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(324, 355)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 17
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'tlprbDenominations
        '
        Me.tlprbDenominations.ColumnCount = 2
        Me.tlprbDenominations.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlprbDenominations.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.tlprbDenominations.Controls.Add(Me.rbDenominationsYes, 0, 0)
        Me.tlprbDenominations.Controls.Add(Me.rbDenominationsNo, 1, 0)
        Me.tlprbDenominations.Location = New System.Drawing.Point(255, 295)
        Me.tlprbDenominations.Name = "tlprbDenominations"
        Me.tlprbDenominations.RowCount = 1
        Me.tlprbDenominations.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlprbDenominations.Size = New System.Drawing.Size(111, 28)
        Me.tlprbDenominations.TabIndex = 26
        '
        'rbDenominationsYes
        '
        Me.rbDenominationsYes.AutoSize = True
        Me.rbDenominationsYes.Location = New System.Drawing.Point(3, 3)
        Me.rbDenominationsYes.Name = "rbDenominationsYes"
        Me.rbDenominationsYes.Size = New System.Drawing.Size(43, 17)
        Me.rbDenominationsYes.TabIndex = 15
        Me.rbDenominationsYes.TabStop = True
        Me.rbDenominationsYes.Text = "Yes"
        Me.rbDenominationsYes.UseVisualStyleBackColor = True
        '
        'rbDenominationsNo
        '
        Me.rbDenominationsNo.AutoSize = True
        Me.rbDenominationsNo.Location = New System.Drawing.Point(60, 3)
        Me.rbDenominationsNo.Name = "rbDenominationsNo"
        Me.rbDenominationsNo.Size = New System.Drawing.Size(39, 17)
        Me.rbDenominationsNo.TabIndex = 16
        Me.rbDenominationsNo.TabStop = True
        Me.rbDenominationsNo.Text = "No"
        Me.rbDenominationsNo.UseVisualStyleBackColor = True
        '
        'lblDenominations
        '
        Me.lblDenominations.AutoSize = True
        Me.lblDenominations.Location = New System.Drawing.Point(6, 301)
        Me.lblDenominations.Name = "lblDenominations"
        Me.lblDenominations.Size = New System.Drawing.Size(243, 13)
        Me.lblDenominations.TabIndex = 25
        Me.lblDenominations.Text = "Would you like the money in small denominations?"
        '
        'lblInputAmount
        '
        Me.lblInputAmount.AutoSize = True
        Me.lblInputAmount.Location = New System.Drawing.Point(25, 272)
        Me.lblInputAmount.Name = "lblInputAmount"
        Me.lblInputAmount.Size = New System.Drawing.Size(198, 13)
        Me.lblInputAmount.TabIndex = 24
        Me.lblInputAmount.Text = "What amount would you like to convert?"
        '
        'txtInputAmount
        '
        Me.txtInputAmount.Location = New System.Drawing.Point(229, 269)
        Me.txtInputAmount.Name = "txtInputAmount"
        Me.txtInputAmount.Size = New System.Drawing.Size(160, 20)
        Me.txtInputAmount.TabIndex = 14
        '
        'lbConversion
        '
        Me.lbConversion.AutoSize = True
        Me.lbConversion.Location = New System.Drawing.Point(25, 197)
        Me.lbConversion.Name = "lbConversion"
        Me.lbConversion.Size = New System.Drawing.Size(172, 13)
        Me.lbConversion.TabIndex = 22
        Me.lbConversion.Text = "What would you like to convert to?"
        '
        'rbDollarPound
        '
        Me.rbDollarPound.AutoSize = True
        Me.rbDollarPound.Location = New System.Drawing.Point(164, 247)
        Me.rbDollarPound.Name = "rbDollarPound"
        Me.rbDollarPound.Size = New System.Drawing.Size(98, 17)
        Me.rbDollarPound.TabIndex = 13
        Me.rbDollarPound.TabStop = True
        Me.rbDollarPound.Text = "Dollar to Pound"
        Me.rbDollarPound.UseVisualStyleBackColor = True
        '
        'rbPoundDollar
        '
        Me.rbPoundDollar.AutoSize = True
        Me.rbPoundDollar.Location = New System.Drawing.Point(58, 247)
        Me.rbPoundDollar.Name = "rbPoundDollar"
        Me.rbPoundDollar.Size = New System.Drawing.Size(98, 17)
        Me.rbPoundDollar.TabIndex = 12
        Me.rbPoundDollar.TabStop = True
        Me.rbPoundDollar.Text = "Pound to Dollar"
        Me.rbPoundDollar.UseVisualStyleBackColor = True
        '
        'rbPoundEuro
        '
        Me.rbPoundEuro.AutoSize = True
        Me.rbPoundEuro.Location = New System.Drawing.Point(58, 224)
        Me.rbPoundEuro.Name = "rbPoundEuro"
        Me.rbPoundEuro.Size = New System.Drawing.Size(93, 17)
        Me.rbPoundEuro.TabIndex = 10
        Me.rbPoundEuro.TabStop = True
        Me.rbPoundEuro.Text = "Pound to Euro"
        Me.rbPoundEuro.UseVisualStyleBackColor = True
        '
        'rbEuroPound
        '
        Me.rbEuroPound.AutoSize = True
        Me.rbEuroPound.Location = New System.Drawing.Point(164, 224)
        Me.rbEuroPound.Name = "rbEuroPound"
        Me.rbEuroPound.Size = New System.Drawing.Size(93, 17)
        Me.rbEuroPound.TabIndex = 11
        Me.rbEuroPound.TabStop = True
        Me.rbEuroPound.Text = "Euro to Pound"
        Me.rbEuroPound.UseVisualStyleBackColor = True
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(90, 163)
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(299, 20)
        Me.txtTownCity.TabIndex = 9
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(25, 166)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(59, 13)
        Me.lblTown.TabIndex = 17
        Me.lblTown.Text = "Town/City:"
        '
        'lblStreetName
        '
        Me.lblStreetName.AutoSize = True
        Me.lblStreetName.Location = New System.Drawing.Point(16, 140)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(69, 13)
        Me.lblStreetName.TabIndex = 16
        Me.lblStreetName.Text = "Street Name:"
        '
        'txtStreetName
        '
        Me.txtStreetName.Location = New System.Drawing.Point(90, 137)
        Me.txtStreetName.Name = "txtStreetName"
        Me.txtStreetName.Size = New System.Drawing.Size(299, 20)
        Me.txtStreetName.TabIndex = 8
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Location = New System.Drawing.Point(90, 111)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(106, 20)
        Me.txtHouseNumber.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "House Number:"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Location = New System.Drawing.Point(202, 114)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(55, 13)
        Me.lblPostcode.TabIndex = 13
        Me.lblPostcode.Text = "Postcode:"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(263, 111)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(126, 20)
        Me.txtPostcode.TabIndex = 7
        '
        'txtNIN
        '
        Me.txtNIN.Location = New System.Drawing.Point(283, 85)
        Me.txtNIN.Name = "txtNIN"
        Me.txtNIN.Size = New System.Drawing.Size(106, 20)
        Me.txtNIN.TabIndex = 5
        '
        'lblNIN
        '
        Me.lblNIN.AutoSize = True
        Me.lblNIN.Location = New System.Drawing.Point(243, 88)
        Me.lblNIN.Name = "lblNIN"
        Me.lblNIN.Size = New System.Drawing.Size(35, 13)
        Me.lblNIN.TabIndex = 10
        Me.lblNIN.Text = "N.I.N:"
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(91, 85)
        Me.dtpDOB.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(146, 20)
        Me.dtpDOB.TabIndex = 4
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(14, 88)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(71, 13)
        Me.lblDOB.TabIndex = 8
        Me.lblDOB.Text = "Date Of Birth:"
        '
        'lbluserSecondName
        '
        Me.lbluserSecondName.AutoSize = True
        Me.lbluserSecondName.Location = New System.Drawing.Point(33, 62)
        Me.lbluserSecondName.Name = "lbluserSecondName"
        Me.lbluserSecondName.Size = New System.Drawing.Size(52, 13)
        Me.lbluserSecondName.TabIndex = 7
        Me.lbluserSecondName.Text = "Surname:"
        '
        'txtuserSurname
        '
        Me.txtuserSurname.Location = New System.Drawing.Point(91, 59)
        Me.txtuserSurname.Name = "txtuserSurname"
        Me.txtuserSurname.Size = New System.Drawing.Size(298, 20)
        Me.txtuserSurname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Forename:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(55, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title:"
        '
        'cmbTitle
        '
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Sir", "Master", "Dr"})
        Me.cmbTitle.Location = New System.Drawing.Point(91, 31)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(123, 21)
        Me.cmbTitle.TabIndex = 1
        '
        'txtuserFirstName
        '
        Me.txtuserFirstName.Location = New System.Drawing.Point(283, 31)
        Me.txtuserFirstName.Name = "txtuserFirstName"
        Me.txtuserFirstName.Size = New System.Drawing.Size(106, 20)
        Me.txtuserFirstName.TabIndex = 2
        '
        'menuHome
        '
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(808, 24)
        Me.menuHome.TabIndex = 1
        Me.menuHome.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.btnSave)
        Me.grpOutput.Controls.Add(Me.txtLoss)
        Me.grpOutput.Controls.Add(Me.lblLoss)
        Me.grpOutput.Controls.Add(Me.txtOutputAfterCommission)
        Me.grpOutput.Controls.Add(Me.Label5)
        Me.grpOutput.Controls.Add(Me.txtOuputBeforeCommission)
        Me.grpOutput.Controls.Add(Me.Label1)
        Me.grpOutput.Controls.Add(Me.btnReset)
        Me.grpOutput.Location = New System.Drawing.Point(423, 28)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(373, 384)
        Me.grpOutput.TabIndex = 1
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output Values"
        '
        'txtLoss
        '
        Me.txtLoss.Location = New System.Drawing.Point(154, 77)
        Me.txtLoss.Name = "txtLoss"
        Me.txtLoss.ReadOnly = True
        Me.txtLoss.Size = New System.Drawing.Size(100, 20)
        Me.txtLoss.TabIndex = 22
        '
        'lblLoss
        '
        Me.lblLoss.AutoSize = True
        Me.lblLoss.Location = New System.Drawing.Point(6, 80)
        Me.lblLoss.Name = "lblLoss"
        Me.lblLoss.Size = New System.Drawing.Size(142, 13)
        Me.lblLoss.TabIndex = 21
        Me.lblLoss.Text = "Total Loss After Commission:"
        '
        'txtOutputAfterCommission
        '
        Me.txtOutputAfterCommission.Location = New System.Drawing.Point(154, 51)
        Me.txtOutputAfterCommission.Name = "txtOutputAfterCommission"
        Me.txtOutputAfterCommission.ReadOnly = True
        Me.txtOutputAfterCommission.Size = New System.Drawing.Size(100, 20)
        Me.txtOutputAfterCommission.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total After Commission:"
        '
        'txtOuputBeforeCommission
        '
        Me.txtOuputBeforeCommission.Location = New System.Drawing.Point(154, 26)
        Me.txtOuputBeforeCommission.Name = "txtOuputBeforeCommission"
        Me.txtOuputBeforeCommission.ReadOnly = True
        Me.txtOuputBeforeCommission.Size = New System.Drawing.Size(100, 20)
        Me.txtOuputBeforeCommission.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Before Commission:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(292, 355)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(207, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save Results"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Main_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(808, 424)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.menuHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menuHome
        Me.MaximizeBox = False
        Me.Name = "Main_Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bureau de Change"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.tlprbDenominations.ResumeLayout(False)
        Me.tlprbDenominations.PerformLayout()
        Me.menuHome.ResumeLayout(False)
        Me.menuHome.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents menuHome As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtuserFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbluserSecondName As System.Windows.Forms.Label
    Friend WithEvents txtuserSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNIN As System.Windows.Forms.TextBox
    Friend WithEvents lblNIN As System.Windows.Forms.Label
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHouseNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblStreetName As System.Windows.Forms.Label
    Friend WithEvents txtStreetName As System.Windows.Forms.TextBox
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents txtTownCity As System.Windows.Forms.TextBox
    Friend WithEvents rbPoundEuro As System.Windows.Forms.RadioButton
    Friend WithEvents rbEuroPound As System.Windows.Forms.RadioButton
    Friend WithEvents rbPoundDollar As System.Windows.Forms.RadioButton
    Friend WithEvents rbDollarPound As System.Windows.Forms.RadioButton
    Friend WithEvents lbConversion As System.Windows.Forms.Label
    Friend WithEvents lblInputAmount As System.Windows.Forms.Label
    Friend WithEvents txtInputAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblDenominations As System.Windows.Forms.Label
    Friend WithEvents txtOuputBeforeCommission As System.Windows.Forms.TextBox
    Friend WithEvents txtOutputAfterCommission As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbDenominationsYes As System.Windows.Forms.RadioButton
    Friend WithEvents rbDenominationsNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents tlprbDenominations As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblLoss As System.Windows.Forms.Label
    Friend WithEvents txtLoss As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
