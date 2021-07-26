Imports ADOX
Imports System.Data
Imports System.Data.OleDb

Public Class frmWeight
  Dim WeightConnection As OleDbConnection
  Dim WeightCommand As OleDbCommand
  Dim WeightAdapter As OleDbDataAdapter
  Dim WeightTable As DataTable
  Dim PlotRange As Integer = 0
  Dim BMIHeight As Integer, BMIWeight As Integer, Metric As Boolean
  Dim MonthNames() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

  Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    Dim WeightDatabase As New Catalog
    Dim DatabaseTable As Table
    'close any open database
    Call CloseConnection()
    Try
      'get filename
      If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
        WeightDatabase.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + dlgSave.FileName)
        'create table
        DatabaseTable = New Table
        DatabaseTable.Name = "Weight"
        'add fields
        DatabaseTable.Columns.Append("WeightDate", DataTypeEnum.adDate)
        DatabaseTable.Columns.Append("Weight", DataTypeEnum.adSingle)
        DatabaseTable.Columns.Append("Comment", DataTypeEnum.adWChar, 50)
        DatabaseTable.Columns("Weight").Attributes = ColumnAttributesEnum.adColNullable
        DatabaseTable.Columns("Comment").Attributes = ColumnAttributesEnum.adColNullable
        'primary key
        DatabaseTable.Keys.Append("PK_Weight", KeyTypeEnum.adKeyPrimary, "WeightDate")
        DatabaseTable.Indexes.Append("WeightDate", "WeightDate")
        WeightDatabase.Tables.Append(DatabaseTable)
        'connect to database
        Call OpenConnection(dlgSave.FileName)
        'fill dates
        Dim TableDate As Date = New Date(CInt(cboYear.Text), 1, 1)
        Dim NDays As Integer = CInt(DateDiff(DateInterval.Day, TableDate, New Date(CInt(cboYear.Text) + 1, 1, 1)))
        Dim NewRow As DataRow
        Dim N As Integer
        For N = 0 To NDays - 1
          NewRow = WeightTable.NewRow
          NewRow.Item(0) = DateAdd(DateInterval.Day, N, TableDate)
          WeightTable.Rows.Add(NewRow)
        Next
        Call grdWeight_CellClick(Nothing, Nothing)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Error Creating Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      WeightDatabase = Nothing
    End Try
  End Sub
  Private Sub CloseConnection()
    Try
      If Not (WeightConnection Is Nothing) Then
        If WeightConnection.State = ConnectionState.Open Then
          Dim WeightAdapterCommand As New OleDbCommandBuilder(WeightAdapter)
          WeightAdapter.Update(WeightTable)
          WeightConnection.Close()
          WeightConnection.Dispose()
          WeightCommand.Dispose()
          WeightAdapter.Dispose()
          WeightTable.Dispose()
          WeightAdapterCommand.Dispose()
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Error Saving Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Private Sub OpenConnection(ByVal FName As String)
    Try
      WeightConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + FName)
      WeightConnection.Open()
      'establish  command object
      WeightCommand = New OleDbCommand("SELECT * FROM Weight ORDER BY WeightDate", WeightConnection)
      'establish  data adapter/data table
      WeightAdapter = New OleDbDataAdapter()
      WeightAdapter.SelectCommand = WeightCommand
      WeightTable = New DataTable()
      WeightAdapter.Fill(WeightTable)
      grdWeight.DataSource = WeightTable
      grdWeight.Columns(0).ReadOnly = True
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Error Opening Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
    Try
      'close connection if open
      Call CloseConnection()
      'get filename
      If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
        'connect to database
        Call OpenConnection(dlgOpen.FileName)
        Call grdWeight_CellClick(Nothing, Nothing)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub frmWeight_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'close connection
    Call CloseConnection()
  End Sub

  Private Sub frmWeight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim Y As Integer
    For Y = 1900 To 2100
      cboYear.Items.Add(Y.ToString)
    Next Y
    cboYear.Text = calDate.SelectionStart.Year.ToString
    tabWeight.SelectedTab = tabPageData
    grdWeight.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    grdWeight.AllowUserToAddRows = False
    rdoPounds.Checked = True
  End Sub

  Private Sub grdWeight_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdWeight.CellClick
    calDate.SelectionStart = CDate(grdWeight(0, grdWeight.CurrentCell.RowIndex).Value)
  End Sub


  Private Sub grdWeight_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles grdWeight.EditingControlShowing
    RemoveHandler grdWeight.EditingControl.KeyPress, AddressOf Me.grdWeight_KeyPress
    AddHandler grdWeight.EditingControl.KeyPress, AddressOf Me.grdWeight_KeyPress
  End Sub

  Private Sub grdWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    'numeric entries only in first column
    Dim CurrentColumn As Integer = grdWeight.CurrentCell.ColumnIndex
    If CurrentColumn = 1 Then
      Select Case e.KeyChar
        Case CChar("0") To CChar("9"), CChar("."), ControlChars.Back
          e.Handled = False
        Case Else
          e.Handled = True
      End Select
    End If
  End Sub

  Private Sub calDate_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calDate.DateChanged
    'match selected date to grid (if possible)
    If Not (WeightConnection Is Nothing) Then
      WeightTable.DefaultView.Sort = "WeightDate"
      Dim DateRow As Integer = WeightTable.DefaultView.Find(calDate.SelectionStart)
      If DateRow <> -1 Then
        grdWeight.CurrentCell = grdWeight(1, DateRow)
      End If
    End If
  End Sub
  Private Sub WeightData()
    'make sure there is a data table
    If (WeightConnection Is Nothing) Then
      Exit Sub
    End If
    Dim Temp As Single
    Dim X As Integer
    Dim XStart As Integer, XEnd As Integer, NDays As Integer, IsLeap As Integer
    Dim WH As Single, WL As Single
    Dim SumW As Single
    Dim NW As Integer
    Dim SX As Double, SX2 As Double
    Dim SXY As Double
    Dim A1 As Single
    Dim NoData As Boolean
    Dim Weight(366) As Single
    If WeightTable.Rows.Count = 365 Then
      IsLeap = 0
    Else
      IsLeap = 1
    End If
    Select Case PlotRange
      Case 0
        XStart = 1
        XEnd = 31
      Case 1
        XStart = 32
        XEnd = 59 + IsLeap
      Case 2
        XStart = 60 + IsLeap
        XEnd = 90 + IsLeap
      Case 3
        XStart = 91 + IsLeap
        XEnd = 120 + IsLeap
      Case 4
        XStart = 121 + IsLeap
        XEnd = 151 + IsLeap
      Case 5
        XStart = 152 + IsLeap
        XEnd = 181 + IsLeap
      Case 6
        XStart = 182 + IsLeap
        XEnd = 212 + IsLeap
      Case 7
        XStart = 213 + IsLeap
        XEnd = 243 + IsLeap
      Case 8
        XStart = 244 + IsLeap
        XEnd = 273 + IsLeap
      Case 9
        XStart = 274 + IsLeap
        XEnd = 304 + IsLeap
      Case 10
        XStart = 305 + IsLeap
        XEnd = 334 + IsLeap
      Case 11
        XStart = 335 + IsLeap
        XEnd = 365 + IsLeap
    End Select
    NDays = XEnd - XStart + 1
    'weight data
    WH = -1000 : WL = 1000
    SumW = 0 : NW = 0
    SX = 0 : SX2 = 0 : SXY = 0
    NoData = True
    For X = XStart To XEnd
      If Not (IsDBNull(WeightTable.Rows(X - 1).Item("Weight"))) Then
        Temp = CSng(WeightTable.Rows(X - 1).Item("Weight"))
        NoData = False
        Weight(X - XStart + 1) = Temp
        If Temp > WH Then WH = Temp
        If Temp < WL Then WL = Temp
        SumW += Temp
        NW += +1
        SX += X
        SX2 += X * X
        SXY += X * Temp
      Else
        Weight(X - XStart + 1) = -1000.0
      End If
    Next X
    If Not (NoData) Then
      lblHigh.Text = Format(WH, "0.0")
      lblLow.Text = Format(WL, "0.0")
      If NW > 1 Then
        A1 = CSng((NW * SXY - SX * SumW) / (NW * SX2 - SX ^ 2))
        If A1 >= 0 Then
          lblTrend.Text = "+" + Format(7 * A1, "0.0") + " Per Week"
        Else
          lblTrend.Text = Format(7 * A1, "0.0") + " Per Week"
        End If
      End If
      lblAve.Text = Format(SumW / NW, "0.0")
    Else
      lblHigh.Text = "---"
      lblLow.Text = "---"
      lblAve.Text = "---"
      lblTrend.Text = "---"
    End If
    Dim WeightPlot As New WeightPlot(pnlWeightPlot)
    If Not (NoData) Then
      WeightPlot.Draw(NDays, Weight)
    End If
  End Sub

  Private Sub rdoWeightPlot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoJanuary.CheckedChanged, rdoSeptember.CheckedChanged, rdoOctober.CheckedChanged, rdoNovember.CheckedChanged, rdoMay.CheckedChanged, rdoMarch.CheckedChanged, rdoJune.CheckedChanged, rdoJuly.CheckedChanged, rdoFebruary.CheckedChanged, rdoDecember.CheckedChanged, rdoAugust.CheckedChanged, rdoApril.CheckedChanged
    Dim WhichButton As RadioButton = CType(sender, RadioButton)
    Select Case WhichButton.Name
      Case "rdoJanuary"
        PlotRange = 0
      Case "rdoFebruary"
        PlotRange = 1
      Case "rdoMarch"
        PlotRange = 2
      Case "rdoApril"
        PlotRange = 3
      Case "rdoMay"
        PlotRange = 4
      Case "rdoJune"
        PlotRange = 5
      Case "rdoJuly"
        PlotRange = 6
      Case "rdoAugust"
        PlotRange = 7
      Case "rdoSeptember"
        PlotRange = 8
      Case "rdoOctober"
        PlotRange = 9
      Case "rdoNovember"
        PlotRange = 10
      Case "rdoDecember"
        PlotRange = 11
    End Select
    Call WeightData()
  End Sub

  Private Sub tabWeight_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabWeight.SelectedIndexChanged
    Select Case tabWeight.SelectedIndex
      Case 1
        Call WeightData()
      Case 2
        Call ComputeBMI()
    End Select
  End Sub


  Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitData.Click
    Me.Close()
  End Sub



  Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
    'make sure there is a data table
    If (WeightConnection Is Nothing) Then
      Exit Sub
    End If
    'Declare the document
    Dim RecordDocument As Drawing.Printing.PrintDocument
    'Create the document and name it
    RecordDocument = New Drawing.Printing.PrintDocument()
    RecordDocument.DocumentName = "Weight Data"
    'Add code handler based on button pressed
    AddHandler RecordDocument.PrintPage, AddressOf Me.PrintWeightReport
    'Preview document
    dlgPreview.Document = RecordDocument
    dlgPreview.ShowDialog()
    'Dispose of document when done printing
    RecordDocument.Dispose()
  End Sub
  Private Sub PrintWeightReport(ByVal sender As Object, ByVal e As Drawing.Printing.PrintPageEventArgs)
    Dim MyFont As Font = New Font("Courier New", 12, FontStyle.Regular)
    Dim Y As Integer = 125
    e.Graphics.DrawString("Weight Monitor", MyFont, Brushes.Black, e.MarginBounds.X, Y)
    Y += CInt(2 * MyFont.GetHeight(e.Graphics))
    MyFont = New Font("Courier New", 12, FontStyle.Regular Or FontStyle.Underline)
    e.Graphics.DrawString("Weight Summary for " + monthnames(PlotRange) + ":", MyFont, Brushes.Black, e.MarginBounds.X, Y)
    Y += CInt(2 * MyFont.GetHeight(e.Graphics))
    MyFont = New Font("Courier New", 12, FontStyle.Regular)
    e.Graphics.DrawString("  High  = " + lblHigh.Text, MyFont, Brushes.Black, 150, Y)
    Y += CInt(MyFont.GetHeight(e.Graphics))
    e.Graphics.DrawString("  Ave   = " + lblAve.Text, MyFont, Brushes.Black, 150, Y)
    Y += CInt(MyFont.GetHeight(e.Graphics))
    e.Graphics.DrawString("  Low   = " + lblLow.Text, MyFont, Brushes.Black, 150, Y)
    Y += CInt(MyFont.GetHeight(e.Graphics))
    e.Graphics.DrawString("  Trend = " + lblTrend.Text, MyFont, Brushes.Black, 150, Y)
    If Not (pnlWeightPlot.BackgroundImage Is Nothing) Then
      e.Graphics.DrawImage(pnlWeightPlot.BackgroundImage, 150, 300, 500, CInt(500 * pnlWeightPlot.ClientSize.Height / pnlWeightPlot.ClientSize.Height))
    End If
    e.HasMorePages = False
  End Sub
  Private Sub ComputeBMI()
    Dim BMI As Single, W As Single, H As Single
    If Metric Then
      W = nudWeight.Value
      H = nudHeight.Value / 100
    Else
      W = CSng(nudWeight.Value * 0.4536)
      H = CSng(nudHeight.Value * 2.54 / 100)
    End If
    If H <> 0 Then
      BMI = W / (H * H)
    Else
      BMI = 0
    End If
    lblBMI.Text = Format(BMI, "0.0")
    Select Case BMI
      Case Is > 27
        lblBMI.BackColor = lblOverRisk.backColor
      Case 25 To 27
        lblBMI.BackColor = lblOver.backColor
      Case 20 To 25
        lblBMI.BackColor = lblHealthy.BackColor
      Case Is < 20
        lblBMI.BackColor = lblUnder.BackColor
    End Select

    If BMI > 30 Then
      lblLine.Top = lblOverRisk.Top
    ElseIf BMI < 18 Then
      lblLine.Top = lblUnder.Top + lblUnder.Height
    Else
      lblLine.Top = CInt(lblOverRisk.Top + (30 - BMI) * (lblOverRisk.Height + lblOver.Height + lblHealthy.Height + lblUnder.Height) / 12)
    End If
    lblLine.Top -= 2
    lblBMI.Top = CInt(lblLine.Top - 0.5 * lblBMI.Height)
    lblBMITitle.Top = lblBMI.Top - lblBMITitle.Height
  End Sub

  Private Sub rdoUnits_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPounds.CheckedChanged, rdoKilos.CheckedChanged
    Dim WhichButton As RadioButton = CType(sender, RadioButton)
    nudWeight.Minimum = 1 : nudWeight.Maximum = 1000
    nudHeight.Minimum = 1 : nudHeight.Maximum = 1000
    Select Case WhichButton.Name
      Case "rdoPounds"
        Metric = False
        lblWeightHeading.Text = "Weight (pounds)"
        lblHeightHeading.Text = "Height (inches)"
        BMIWeight = 140
        BMIHeight = 66
        nudWeight.Minimum = 80 : nudWeight.Maximum = 300
        nudHeight.Minimum = 48 : nudHeight.Maximum = 84
      Case "rdoKilos"
        Metric = True
        lblWeightHeading.Text = "Weight (kilograms)"
        lblHeightHeading.Text = "Height (centimeters)"
        BMIWeight = 64
        BMIHeight = 168
        nudWeight.Minimum = 36 : nudWeight.Maximum = 136
        nudHeight.Minimum = 120 : nudHeight.Maximum = 215
    End Select
    nudWeight.Value = BMIWeight
    nudHeight.Value = BMIHeight
    ComputeBMI()
  End Sub

  Private Sub nudWeight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudWeight.ValueChanged
    Call ComputeBMI()
  End Sub

  Private Sub nudHeight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudHeight.ValueChanged
    Call ComputeBMI()
  End Sub
End Class
