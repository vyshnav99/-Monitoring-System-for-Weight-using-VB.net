<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeight
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeight))
    Me.tabWeight = New System.Windows.Forms.TabControl
    Me.tabPageData = New System.Windows.Forms.TabPage
    Me.pnlNew = New System.Windows.Forms.Panel
    Me.btnExitData = New System.Windows.Forms.Button
    Me.cboYear = New System.Windows.Forms.ComboBox
    Me.btnOpen = New System.Windows.Forms.Button
    Me.btnNew = New System.Windows.Forms.Button
    Me.calDate = New System.Windows.Forms.MonthCalendar
    Me.grdWeight = New System.Windows.Forms.DataGridView
    Me.tabPageWeight = New System.Windows.Forms.TabPage
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.rdoDecember = New System.Windows.Forms.RadioButton
    Me.rdoNovember = New System.Windows.Forms.RadioButton
    Me.rdoOctober = New System.Windows.Forms.RadioButton
    Me.rdoSeptember = New System.Windows.Forms.RadioButton
    Me.rdoAugust = New System.Windows.Forms.RadioButton
    Me.rdoJuly = New System.Windows.Forms.RadioButton
    Me.rdoJune = New System.Windows.Forms.RadioButton
    Me.rdoMay = New System.Windows.Forms.RadioButton
    Me.rdoApril = New System.Windows.Forms.RadioButton
    Me.rdoMarch = New System.Windows.Forms.RadioButton
    Me.rdoFebruary = New System.Windows.Forms.RadioButton
    Me.btnPrint = New System.Windows.Forms.Button
    Me.lblTrend = New System.Windows.Forms.Label
    Me.Label16 = New System.Windows.Forms.Label
    Me.lblLow = New System.Windows.Forms.Label
    Me.rdoJanuary = New System.Windows.Forms.RadioButton
    Me.Label12 = New System.Windows.Forms.Label
    Me.lblAve = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.lblHigh = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.pnlWeightPlot = New System.Windows.Forms.Panel
    Me.tabPageBMI = New System.Windows.Forms.TabPage
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.rdoKilos = New System.Windows.Forms.RadioButton
    Me.rdoPounds = New System.Windows.Forms.RadioButton
    Me.nudHeight = New System.Windows.Forms.NumericUpDown
    Me.nudWeight = New System.Windows.Forms.NumericUpDown
    Me.lblHeightHeading = New System.Windows.Forms.Label
    Me.lblWeightHeading = New System.Windows.Forms.Label
    Me.lblLine = New System.Windows.Forms.Label
    Me.lblBMI = New System.Windows.Forms.Label
    Me.lblBMITitle = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.lblHealthy = New System.Windows.Forms.Label
    Me.lblUnder = New System.Windows.Forms.Label
    Me.lblOver = New System.Windows.Forms.Label
    Me.lblOverRisk = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
    Me.dlgSave = New System.Windows.Forms.SaveFileDialog
    Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog
    Me.tabWeight.SuspendLayout()
    Me.tabPageData.SuspendLayout()
    Me.pnlNew.SuspendLayout()
    CType(Me.grdWeight, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tabPageWeight.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.tabPageBMI.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'tabWeight
    '
    Me.tabWeight.Controls.Add(Me.tabPageData)
    Me.tabWeight.Controls.Add(Me.tabPageWeight)
    Me.tabWeight.Controls.Add(Me.tabPageBMI)
    Me.tabWeight.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tabWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tabWeight.Location = New System.Drawing.Point(0, 0)
    Me.tabWeight.Name = "tabWeight"
    Me.tabWeight.SelectedIndex = 0
    Me.tabWeight.Size = New System.Drawing.Size(562, 387)
    Me.tabWeight.TabIndex = 0
    '
    'tabPageData
    '
    Me.tabPageData.Controls.Add(Me.pnlNew)
    Me.tabPageData.Controls.Add(Me.calDate)
    Me.tabPageData.Controls.Add(Me.grdWeight)
    Me.tabPageData.Location = New System.Drawing.Point(4, 25)
    Me.tabPageData.Name = "tabPageData"
    Me.tabPageData.Padding = New System.Windows.Forms.Padding(3)
    Me.tabPageData.Size = New System.Drawing.Size(554, 358)
    Me.tabPageData.TabIndex = 0
    Me.tabPageData.Text = "Record Weight Data"
    Me.tabPageData.UseVisualStyleBackColor = True
    '
    'pnlNew
    '
    Me.pnlNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.pnlNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlNew.Controls.Add(Me.btnExitData)
    Me.pnlNew.Controls.Add(Me.cboYear)
    Me.pnlNew.Controls.Add(Me.btnOpen)
    Me.pnlNew.Controls.Add(Me.btnNew)
    Me.pnlNew.Location = New System.Drawing.Point(289, 179)
    Me.pnlNew.Name = "pnlNew"
    Me.pnlNew.Size = New System.Drawing.Size(210, 91)
    Me.pnlNew.TabIndex = 2
    '
    'btnExitData
    '
    Me.btnExitData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExitData.Location = New System.Drawing.Point(15, 63)
    Me.btnExitData.Name = "btnExitData"
    Me.btnExitData.Size = New System.Drawing.Size(75, 23)
    Me.btnExitData.TabIndex = 4
    Me.btnExitData.Text = "Exit"
    Me.btnExitData.UseVisualStyleBackColor = True
    '
    'cboYear
    '
    Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboYear.FormattingEnabled = True
    Me.cboYear.Location = New System.Drawing.Point(96, 10)
    Me.cboYear.Name = "cboYear"
    Me.cboYear.Size = New System.Drawing.Size(99, 21)
    Me.cboYear.TabIndex = 1
    '
    'btnOpen
    '
    Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOpen.Location = New System.Drawing.Point(15, 37)
    Me.btnOpen.Name = "btnOpen"
    Me.btnOpen.Size = New System.Drawing.Size(75, 23)
    Me.btnOpen.TabIndex = 1
    Me.btnOpen.Text = "Open File"
    Me.btnOpen.UseVisualStyleBackColor = True
    '
    'btnNew
    '
    Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNew.Location = New System.Drawing.Point(15, 8)
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Size = New System.Drawing.Size(75, 23)
    Me.btnNew.TabIndex = 0
    Me.btnNew.Text = "New File"
    Me.btnNew.UseVisualStyleBackColor = True
    '
    'calDate
    '
    Me.calDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.calDate.Location = New System.Drawing.Point(26, 164)
    Me.calDate.MaxSelectionCount = 1
    Me.calDate.Name = "calDate"
    Me.calDate.TabIndex = 1
    '
    'grdWeight
    '
    Me.grdWeight.AllowUserToAddRows = False
    Me.grdWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.grdWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.grdWeight.Location = New System.Drawing.Point(1, 1)
    Me.grdWeight.Name = "grdWeight"
    Me.grdWeight.Size = New System.Drawing.Size(552, 160)
    Me.grdWeight.TabIndex = 0
    '
    'tabPageWeight
    '
    Me.tabPageWeight.Controls.Add(Me.Panel1)
    Me.tabPageWeight.Controls.Add(Me.pnlWeightPlot)
    Me.tabPageWeight.Location = New System.Drawing.Point(4, 25)
    Me.tabPageWeight.Name = "tabPageWeight"
    Me.tabPageWeight.Padding = New System.Windows.Forms.Padding(3)
    Me.tabPageWeight.Size = New System.Drawing.Size(554, 358)
    Me.tabPageWeight.TabIndex = 1
    Me.tabPageWeight.Text = "View Weight Data"
    Me.tabPageWeight.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Blue
    Me.Panel1.Controls.Add(Me.rdoDecember)
    Me.Panel1.Controls.Add(Me.rdoNovember)
    Me.Panel1.Controls.Add(Me.rdoOctober)
    Me.Panel1.Controls.Add(Me.rdoSeptember)
    Me.Panel1.Controls.Add(Me.rdoAugust)
    Me.Panel1.Controls.Add(Me.rdoJuly)
    Me.Panel1.Controls.Add(Me.rdoJune)
    Me.Panel1.Controls.Add(Me.rdoMay)
    Me.Panel1.Controls.Add(Me.rdoApril)
    Me.Panel1.Controls.Add(Me.rdoMarch)
    Me.Panel1.Controls.Add(Me.rdoFebruary)
    Me.Panel1.Controls.Add(Me.btnPrint)
    Me.Panel1.Controls.Add(Me.lblTrend)
    Me.Panel1.Controls.Add(Me.Label16)
    Me.Panel1.Controls.Add(Me.lblLow)
    Me.Panel1.Controls.Add(Me.rdoJanuary)
    Me.Panel1.Controls.Add(Me.Label12)
    Me.Panel1.Controls.Add(Me.lblAve)
    Me.Panel1.Controls.Add(Me.Label8)
    Me.Panel1.Controls.Add(Me.lblHigh)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Location = New System.Drawing.Point(338, 15)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(208, 337)
    Me.Panel1.TabIndex = 1
    '
    'rdoDecember
    '
    Me.rdoDecember.AutoSize = True
    Me.rdoDecember.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoDecember.ForeColor = System.Drawing.Color.Yellow
    Me.rdoDecember.Location = New System.Drawing.Point(100, 281)
    Me.rdoDecember.Name = "rdoDecember"
    Me.rdoDecember.Size = New System.Drawing.Size(86, 20)
    Me.rdoDecember.TabIndex = 28
    Me.rdoDecember.Text = "December"
    Me.rdoDecember.UseVisualStyleBackColor = True
    '
    'rdoNovember
    '
    Me.rdoNovember.AutoSize = True
    Me.rdoNovember.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoNovember.ForeColor = System.Drawing.Color.Yellow
    Me.rdoNovember.Location = New System.Drawing.Point(100, 255)
    Me.rdoNovember.Name = "rdoNovember"
    Me.rdoNovember.Size = New System.Drawing.Size(85, 20)
    Me.rdoNovember.TabIndex = 27
    Me.rdoNovember.Text = "November"
    Me.rdoNovember.UseVisualStyleBackColor = True
    '
    'rdoOctober
    '
    Me.rdoOctober.AutoSize = True
    Me.rdoOctober.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoOctober.ForeColor = System.Drawing.Color.Yellow
    Me.rdoOctober.Location = New System.Drawing.Point(100, 229)
    Me.rdoOctober.Name = "rdoOctober"
    Me.rdoOctober.Size = New System.Drawing.Size(73, 20)
    Me.rdoOctober.TabIndex = 26
    Me.rdoOctober.Text = "October"
    Me.rdoOctober.UseVisualStyleBackColor = True
    '
    'rdoSeptember
    '
    Me.rdoSeptember.AutoSize = True
    Me.rdoSeptember.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoSeptember.ForeColor = System.Drawing.Color.Yellow
    Me.rdoSeptember.Location = New System.Drawing.Point(100, 203)
    Me.rdoSeptember.Name = "rdoSeptember"
    Me.rdoSeptember.Size = New System.Drawing.Size(90, 20)
    Me.rdoSeptember.TabIndex = 25
    Me.rdoSeptember.Text = "September"
    Me.rdoSeptember.UseVisualStyleBackColor = True
    '
    'rdoAugust
    '
    Me.rdoAugust.AutoSize = True
    Me.rdoAugust.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoAugust.ForeColor = System.Drawing.Color.Yellow
    Me.rdoAugust.Location = New System.Drawing.Point(100, 177)
    Me.rdoAugust.Name = "rdoAugust"
    Me.rdoAugust.Size = New System.Drawing.Size(67, 20)
    Me.rdoAugust.TabIndex = 24
    Me.rdoAugust.Text = "August"
    Me.rdoAugust.UseVisualStyleBackColor = True
    '
    'rdoJuly
    '
    Me.rdoJuly.AutoSize = True
    Me.rdoJuly.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoJuly.ForeColor = System.Drawing.Color.Yellow
    Me.rdoJuly.Location = New System.Drawing.Point(100, 151)
    Me.rdoJuly.Name = "rdoJuly"
    Me.rdoJuly.Size = New System.Drawing.Size(49, 20)
    Me.rdoJuly.TabIndex = 23
    Me.rdoJuly.Text = "July"
    Me.rdoJuly.UseVisualStyleBackColor = True
    '
    'rdoJune
    '
    Me.rdoJune.AutoSize = True
    Me.rdoJune.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoJune.ForeColor = System.Drawing.Color.Yellow
    Me.rdoJune.Location = New System.Drawing.Point(23, 281)
    Me.rdoJune.Name = "rdoJune"
    Me.rdoJune.Size = New System.Drawing.Size(54, 20)
    Me.rdoJune.TabIndex = 22
    Me.rdoJune.Text = "June"
    Me.rdoJune.UseVisualStyleBackColor = True
    '
    'rdoMay
    '
    Me.rdoMay.AutoSize = True
    Me.rdoMay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoMay.ForeColor = System.Drawing.Color.Yellow
    Me.rdoMay.Location = New System.Drawing.Point(23, 255)
    Me.rdoMay.Name = "rdoMay"
    Me.rdoMay.Size = New System.Drawing.Size(49, 20)
    Me.rdoMay.TabIndex = 21
    Me.rdoMay.Text = "May"
    Me.rdoMay.UseVisualStyleBackColor = True
    '
    'rdoApril
    '
    Me.rdoApril.AutoSize = True
    Me.rdoApril.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoApril.ForeColor = System.Drawing.Color.Yellow
    Me.rdoApril.Location = New System.Drawing.Point(23, 229)
    Me.rdoApril.Name = "rdoApril"
    Me.rdoApril.Size = New System.Drawing.Size(52, 20)
    Me.rdoApril.TabIndex = 20
    Me.rdoApril.Text = "April"
    Me.rdoApril.UseVisualStyleBackColor = True
    '
    'rdoMarch
    '
    Me.rdoMarch.AutoSize = True
    Me.rdoMarch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoMarch.ForeColor = System.Drawing.Color.Yellow
    Me.rdoMarch.Location = New System.Drawing.Point(23, 203)
    Me.rdoMarch.Name = "rdoMarch"
    Me.rdoMarch.Size = New System.Drawing.Size(61, 20)
    Me.rdoMarch.TabIndex = 19
    Me.rdoMarch.Text = "March"
    Me.rdoMarch.UseVisualStyleBackColor = True
    '
    'rdoFebruary
    '
    Me.rdoFebruary.AutoSize = True
    Me.rdoFebruary.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoFebruary.ForeColor = System.Drawing.Color.Yellow
    Me.rdoFebruary.Location = New System.Drawing.Point(23, 177)
    Me.rdoFebruary.Name = "rdoFebruary"
    Me.rdoFebruary.Size = New System.Drawing.Size(77, 20)
    Me.rdoFebruary.TabIndex = 18
    Me.rdoFebruary.Text = "February"
    Me.rdoFebruary.UseVisualStyleBackColor = True
    '
    'btnPrint
    '
    Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPrint.Location = New System.Drawing.Point(66, 307)
    Me.btnPrint.Name = "btnPrint"
    Me.btnPrint.Size = New System.Drawing.Size(75, 23)
    Me.btnPrint.TabIndex = 17
    Me.btnPrint.Text = "Print Data"
    Me.btnPrint.UseVisualStyleBackColor = True
    '
    'lblTrend
    '
    Me.lblTrend.BackColor = System.Drawing.Color.White
    Me.lblTrend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblTrend.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTrend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblTrend.Location = New System.Drawing.Point(66, 122)
    Me.lblTrend.Name = "lblTrend"
    Me.lblTrend.Size = New System.Drawing.Size(119, 26)
    Me.lblTrend.TabIndex = 16
    Me.lblTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.ForeColor = System.Drawing.Color.White
    Me.Label16.Location = New System.Drawing.Point(20, 127)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(40, 16)
    Me.Label16.TabIndex = 15
    Me.Label16.Text = "Trend"
    '
    'lblLow
    '
    Me.lblLow.BackColor = System.Drawing.Color.White
    Me.lblLow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblLow.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblLow.Location = New System.Drawing.Point(88, 91)
    Me.lblLow.Name = "lblLow"
    Me.lblLow.Size = New System.Drawing.Size(62, 26)
    Me.lblLow.TabIndex = 12
    Me.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'rdoJanuary
    '
    Me.rdoJanuary.AutoSize = True
    Me.rdoJanuary.Checked = True
    Me.rdoJanuary.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoJanuary.ForeColor = System.Drawing.Color.Yellow
    Me.rdoJanuary.Location = New System.Drawing.Point(23, 151)
    Me.rdoJanuary.Name = "rdoJanuary"
    Me.rdoJanuary.Size = New System.Drawing.Size(71, 20)
    Me.rdoJanuary.TabIndex = 0
    Me.rdoJanuary.TabStop = True
    Me.rdoJanuary.Text = "January"
    Me.rdoJanuary.UseVisualStyleBackColor = True
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.ForeColor = System.Drawing.Color.White
    Me.Label12.Location = New System.Drawing.Point(48, 96)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(31, 16)
    Me.Label12.TabIndex = 11
    Me.Label12.Text = "Low"
    '
    'lblAve
    '
    Me.lblAve.BackColor = System.Drawing.Color.White
    Me.lblAve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblAve.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblAve.Location = New System.Drawing.Point(88, 61)
    Me.lblAve.Name = "lblAve"
    Me.lblAve.Size = New System.Drawing.Size(62, 26)
    Me.lblAve.TabIndex = 8
    Me.lblAve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.ForeColor = System.Drawing.Color.White
    Me.Label8.Location = New System.Drawing.Point(48, 66)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(29, 16)
    Me.Label8.TabIndex = 7
    Me.Label8.Text = "Ave"
    '
    'lblHigh
    '
    Me.lblHigh.BackColor = System.Drawing.Color.White
    Me.lblHigh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblHigh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHigh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.lblHigh.Location = New System.Drawing.Point(88, 31)
    Me.lblHigh.Name = "lblHigh"
    Me.lblHigh.Size = New System.Drawing.Size(62, 26)
    Me.lblHigh.TabIndex = 4
    Me.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.White
    Me.Label4.Location = New System.Drawing.Point(43, 36)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(34, 16)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "High"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.Yellow
    Me.Label1.Location = New System.Drawing.Point(32, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(118, 16)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Weight Summary"
    '
    'pnlWeightPlot
    '
    Me.pnlWeightPlot.BackColor = System.Drawing.Color.White
    Me.pnlWeightPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlWeightPlot.Location = New System.Drawing.Point(8, 15)
    Me.pnlWeightPlot.Name = "pnlWeightPlot"
    Me.pnlWeightPlot.Size = New System.Drawing.Size(324, 337)
    Me.pnlWeightPlot.TabIndex = 0
    '
    'tabPageBMI
    '
    Me.tabPageBMI.Controls.Add(Me.GroupBox1)
    Me.tabPageBMI.Controls.Add(Me.nudHeight)
    Me.tabPageBMI.Controls.Add(Me.nudWeight)
    Me.tabPageBMI.Controls.Add(Me.lblHeightHeading)
    Me.tabPageBMI.Controls.Add(Me.lblWeightHeading)
    Me.tabPageBMI.Controls.Add(Me.lblLine)
    Me.tabPageBMI.Controls.Add(Me.lblBMI)
    Me.tabPageBMI.Controls.Add(Me.lblBMITitle)
    Me.tabPageBMI.Controls.Add(Me.Label7)
    Me.tabPageBMI.Controls.Add(Me.Label6)
    Me.tabPageBMI.Controls.Add(Me.Label5)
    Me.tabPageBMI.Controls.Add(Me.Label3)
    Me.tabPageBMI.Controls.Add(Me.lblHealthy)
    Me.tabPageBMI.Controls.Add(Me.lblUnder)
    Me.tabPageBMI.Controls.Add(Me.lblOver)
    Me.tabPageBMI.Controls.Add(Me.lblOverRisk)
    Me.tabPageBMI.Controls.Add(Me.Label2)
    Me.tabPageBMI.Location = New System.Drawing.Point(4, 25)
    Me.tabPageBMI.Name = "tabPageBMI"
    Me.tabPageBMI.Size = New System.Drawing.Size(554, 358)
    Me.tabPageBMI.TabIndex = 2
    Me.tabPageBMI.Text = "Body Mass Index (BMI)"
    Me.tabPageBMI.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.GroupBox1.Controls.Add(Me.rdoKilos)
    Me.GroupBox1.Controls.Add(Me.rdoPounds)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.ForeColor = System.Drawing.Color.Black
    Me.GroupBox1.Location = New System.Drawing.Point(19, 207)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(198, 78)
    Me.GroupBox1.TabIndex = 17
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Units"
    '
    'rdoKilos
    '
    Me.rdoKilos.AutoSize = True
    Me.rdoKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoKilos.Location = New System.Drawing.Point(19, 43)
    Me.rdoKilos.Name = "rdoKilos"
    Me.rdoKilos.Size = New System.Drawing.Size(161, 20)
    Me.rdoKilos.TabIndex = 1
    Me.rdoKilos.Text = "Kilograms/Centimeters"
    Me.rdoKilos.UseVisualStyleBackColor = True
    '
    'rdoPounds
    '
    Me.rdoPounds.AutoSize = True
    Me.rdoPounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rdoPounds.Location = New System.Drawing.Point(19, 21)
    Me.rdoPounds.Name = "rdoPounds"
    Me.rdoPounds.Size = New System.Drawing.Size(115, 20)
    Me.rdoPounds.TabIndex = 0
    Me.rdoPounds.Text = "Pounds/Inches"
    Me.rdoPounds.UseVisualStyleBackColor = True
    '
    'nudHeight
    '
    Me.nudHeight.Location = New System.Drawing.Point(57, 139)
    Me.nudHeight.Name = "nudHeight"
    Me.nudHeight.Size = New System.Drawing.Size(120, 22)
    Me.nudHeight.TabIndex = 16
    Me.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'nudWeight
    '
    Me.nudWeight.Location = New System.Drawing.Point(57, 80)
    Me.nudWeight.Name = "nudWeight"
    Me.nudWeight.Size = New System.Drawing.Size(120, 22)
    Me.nudWeight.TabIndex = 15
    Me.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblHeightHeading
    '
    Me.lblHeightHeading.AutoSize = True
    Me.lblHeightHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHeightHeading.Location = New System.Drawing.Point(56, 120)
    Me.lblHeightHeading.Name = "lblHeightHeading"
    Me.lblHeightHeading.Size = New System.Drawing.Size(112, 16)
    Me.lblHeightHeading.TabIndex = 14
    Me.lblHeightHeading.Text = "Height (inches)"
    '
    'lblWeightHeading
    '
    Me.lblWeightHeading.AutoSize = True
    Me.lblWeightHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblWeightHeading.Location = New System.Drawing.Point(56, 61)
    Me.lblWeightHeading.Name = "lblWeightHeading"
    Me.lblWeightHeading.Size = New System.Drawing.Size(121, 16)
    Me.lblWeightHeading.TabIndex = 13
    Me.lblWeightHeading.Text = "Weight (pounds)"
    '
    'lblLine
    '
    Me.lblLine.BackColor = System.Drawing.Color.Black
    Me.lblLine.Location = New System.Drawing.Point(305, 159)
    Me.lblLine.Name = "lblLine"
    Me.lblLine.Size = New System.Drawing.Size(31, 3)
    Me.lblLine.TabIndex = 12
    Me.lblLine.Text = "Label9"
    '
    'lblBMI
    '
    Me.lblBMI.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBMI.Location = New System.Drawing.Point(241, 150)
    Me.lblBMI.Name = "lblBMI"
    Me.lblBMI.Size = New System.Drawing.Size(65, 33)
    Me.lblBMI.TabIndex = 11
    Me.lblBMI.Text = "25.0"
    Me.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblBMITitle
    '
    Me.lblBMITitle.AutoSize = True
    Me.lblBMITitle.Location = New System.Drawing.Point(238, 134)
    Me.lblBMITitle.Name = "lblBMITitle"
    Me.lblBMITitle.Size = New System.Drawing.Size(65, 16)
    Me.lblBMITitle.TabIndex = 10
    Me.lblBMITitle.Text = "Your BMI:"
    '
    'Label7
    '
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(512, 329)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(30, 22)
    Me.Label7.TabIndex = 9
    Me.Label7.Text = "18"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(512, 279)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(30, 22)
    Me.Label6.TabIndex = 8
    Me.Label6.Text = "20"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(512, 155)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(30, 22)
    Me.Label5.TabIndex = 7
    Me.Label5.Text = "25"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(512, 104)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(30, 22)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "27"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblHealthy
    '
    Me.lblHealthy.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.lblHealthy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblHealthy.Location = New System.Drawing.Point(336, 166)
    Me.lblHealthy.Name = "lblHealthy"
    Me.lblHealthy.Size = New System.Drawing.Size(176, 125)
    Me.lblHealthy.TabIndex = 5
    Me.lblHealthy.Text = "Healthy"
    Me.lblHealthy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblUnder
    '
    Me.lblUnder.BackColor = System.Drawing.Color.White
    Me.lblUnder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblUnder.Location = New System.Drawing.Point(336, 291)
    Me.lblUnder.Name = "lblUnder"
    Me.lblUnder.Size = New System.Drawing.Size(176, 50)
    Me.lblUnder.TabIndex = 4
    Me.lblUnder.Text = "Underweight"
    Me.lblUnder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblOver
    '
    Me.lblOver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.lblOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblOver.Location = New System.Drawing.Point(336, 116)
    Me.lblOver.Name = "lblOver"
    Me.lblOver.Size = New System.Drawing.Size(176, 50)
    Me.lblOver.TabIndex = 3
    Me.lblOver.Text = "Overweight"
    Me.lblOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblOverRisk
    '
    Me.lblOverRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.lblOverRisk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblOverRisk.Location = New System.Drawing.Point(336, 41)
    Me.lblOverRisk.Name = "lblOverRisk"
    Me.lblOverRisk.Size = New System.Drawing.Size(176, 75)
    Me.lblOverRisk.TabIndex = 2
    Me.lblOverRisk.Text = "Overweight, at risk for heart and other disease"
    Me.lblOverRisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(512, 32)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(30, 22)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "30"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'dlgOpen
    '
    Me.dlgOpen.DefaultExt = "mdb"
    Me.dlgOpen.Filter = "Access Files (*.mdb)|*.mdb"
    '
    'dlgSave
    '
    Me.dlgSave.DefaultExt = "mdb"
    Me.dlgSave.Filter = "Access Files (*.mdb)|*.mdb"
    Me.dlgSave.OverwritePrompt = False
    '
    'dlgPreview
    '
    Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
    Me.dlgPreview.Enabled = True
    Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
    Me.dlgPreview.Name = "dlgPreview"
    Me.dlgPreview.Visible = False
    '
    'frmWeight
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(562, 387)
    Me.Controls.Add(Me.tabWeight)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmWeight"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Weight Monitor"
    Me.tabWeight.ResumeLayout(False)
    Me.tabPageData.ResumeLayout(False)
    Me.pnlNew.ResumeLayout(False)
    CType(Me.grdWeight, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tabPageWeight.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.tabPageBMI.ResumeLayout(False)
    Me.tabPageBMI.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudWeight, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tabWeight As System.Windows.Forms.TabControl
  Friend WithEvents tabPageData As System.Windows.Forms.TabPage
  Friend WithEvents tabPageWeight As System.Windows.Forms.TabPage
  Friend WithEvents tabPageBMI As System.Windows.Forms.TabPage
  Friend WithEvents calDate As System.Windows.Forms.MonthCalendar
  Friend WithEvents grdWeight As System.Windows.Forms.DataGridView
  Friend WithEvents pnlNew As System.Windows.Forms.Panel
  Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
  Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
  Friend WithEvents btnExitData As System.Windows.Forms.Button
  Friend WithEvents btnOpen As System.Windows.Forms.Button
  Friend WithEvents cboYear As System.Windows.Forms.ComboBox
  Friend WithEvents btnNew As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pnlWeightPlot As System.Windows.Forms.Panel
  Friend WithEvents lblTrend As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents lblLow As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents lblAve As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lblHigh As System.Windows.Forms.Label
  Friend WithEvents rdoJanuary As System.Windows.Forms.RadioButton
  Friend WithEvents btnPrint As System.Windows.Forms.Button
  Friend WithEvents dlgPreview As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents rdoJune As System.Windows.Forms.RadioButton
  Friend WithEvents rdoMay As System.Windows.Forms.RadioButton
  Friend WithEvents rdoApril As System.Windows.Forms.RadioButton
  Friend WithEvents rdoMarch As System.Windows.Forms.RadioButton
  Friend WithEvents rdoFebruary As System.Windows.Forms.RadioButton
  Friend WithEvents rdoDecember As System.Windows.Forms.RadioButton
  Friend WithEvents rdoNovember As System.Windows.Forms.RadioButton
  Friend WithEvents rdoOctober As System.Windows.Forms.RadioButton
  Friend WithEvents rdoSeptember As System.Windows.Forms.RadioButton
  Friend WithEvents rdoAugust As System.Windows.Forms.RadioButton
  Friend WithEvents rdoJuly As System.Windows.Forms.RadioButton
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblHealthy As System.Windows.Forms.Label
  Friend WithEvents lblUnder As System.Windows.Forms.Label
  Friend WithEvents lblOver As System.Windows.Forms.Label
  Friend WithEvents lblOverRisk As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents lblLine As System.Windows.Forms.Label
  Friend WithEvents lblBMI As System.Windows.Forms.Label
  Friend WithEvents lblBMITitle As System.Windows.Forms.Label
  Friend WithEvents nudHeight As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudWeight As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblHeightHeading As System.Windows.Forms.Label
  Friend WithEvents lblWeightHeading As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents rdoKilos As System.Windows.Forms.RadioButton
  Friend WithEvents rdoPounds As System.Windows.Forms.RadioButton

End Class
