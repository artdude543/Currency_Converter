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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.menuHome = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.rbDollarPound = New System.Windows.Forms.RadioButton()
        Me.lbConversion = New System.Windows.Forms.Label()
        Me.grpInput.SuspendLayout()
        Me.menuHome.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
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
        Me.grpInput.Controls.Add(Me.btnConvert)
        Me.grpInput.Location = New System.Drawing.Point(12, 27)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(401, 418)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input Values"
        '
        'rbPoundDollar
        '
        Me.rbPoundDollar.AutoSize = True
        Me.rbPoundDollar.Location = New System.Drawing.Point(58, 247)
        Me.rbPoundDollar.Name = "rbPoundDollar"
        Me.rbPoundDollar.Size = New System.Drawing.Size(98, 17)
        Me.rbPoundDollar.TabIndex = 20
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
        Me.rbPoundEuro.TabIndex = 19
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
        Me.rbEuroPound.TabIndex = 19
        Me.rbEuroPound.TabStop = True
        Me.rbEuroPound.Text = "Euro to Pound"
        Me.rbEuroPound.UseVisualStyleBackColor = True
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(90, 163)
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(299, 20)
        Me.txtTownCity.TabIndex = 18
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
        Me.txtStreetName.TabIndex = 15
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Location = New System.Drawing.Point(90, 111)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(106, 20)
        Me.txtHouseNumber.TabIndex = 7
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
        Me.txtPostcode.TabIndex = 6
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
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(232, 389)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'menuHome
        '
        Me.menuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuHome.Location = New System.Drawing.Point(0, 0)
        Me.menuHome.Name = "menuHome"
        Me.menuHome.Size = New System.Drawing.Size(896, 24)
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
        Me.grpOutput.Controls.Add(Me.Label1)
        Me.grpOutput.Controls.Add(Me.btnReset)
        Me.grpOutput.Location = New System.Drawing.Point(493, 27)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(350, 418)
        Me.grpOutput.TabIndex = 1
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output Values"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Before Commission"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(232, 389)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'rbDollarPound
        '
        Me.rbDollarPound.AutoSize = True
        Me.rbDollarPound.Location = New System.Drawing.Point(164, 247)
        Me.rbDollarPound.Name = "rbDollarPound"
        Me.rbDollarPound.Size = New System.Drawing.Size(98, 17)
        Me.rbDollarPound.TabIndex = 21
        Me.rbDollarPound.TabStop = True
        Me.rbDollarPound.Text = "Dollar to Pound"
        Me.rbDollarPound.UseVisualStyleBackColor = True
        '
        'lbConversion
        '
        Me.lbConversion.AutoSize = True
        Me.lbConversion.Location = New System.Drawing.Point(25, 197)
        Me.lbConversion.Name = "lbConversion"
        Me.lbConversion.Size = New System.Drawing.Size(160, 13)
        Me.lbConversion.TabIndex = 22
        Me.lbConversion.Text = "What would you like to convert?"
        '
        'Main_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 457)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.menuHome)
        Me.MainMenuStrip = Me.menuHome
        Me.Name = "Main_Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bureau de Change"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
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
    Friend WithEvents btnConvert As System.Windows.Forms.Button
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

End Class
