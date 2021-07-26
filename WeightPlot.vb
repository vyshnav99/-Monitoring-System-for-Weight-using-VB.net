Public Class WeightPlot
  Private Plot As Drawing.Graphics
  Private PlotGrid As Drawing.Rectangle
  Private Wmin As Single, Wmax As Single
  Public Sub New(ByVal P As Windows.Forms.Panel)
    P.BackgroundImage = New Drawing.Bitmap(P.ClientSize.Width, P.ClientSize.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)
    Plot = Drawing.Graphics.FromImage(P.BackgroundImage)
    Plot.Clear(P.BackColor)
    PlotGrid = New Drawing.Rectangle(CInt(0.1 * P.ClientSize.Width), CInt(0.05 * P.ClientSize.Height), CInt(0.85 * P.ClientSize.Width), CInt(0.9 * P.ClientSize.Height))
    Plot.FillRectangle(Brushes.LightYellow, PlotGrid)
  End Sub
  Public Sub Draw(ByVal N As Integer, ByVal W() As Single)
    'Constructs a  line chart - pairs of (x,y) coordinates
    'N - number of points to plot
    'W - array of weight points (lower index is 1, upper index is N)
    Dim I As Integer
    'find minimums and maximums
    Wmin = 1000.0 : Wmax = -1000.0
    For I = 1 To N
      If W(I) > -1000.0 Then
        If W(I) < Wmin Then Wmin = W(I)
      End If
      If W(I) > -1000.0 Then
        If W(I) > Wmax Then Wmax = W(I)
      End If
    Next I
    Dim Start As Single, Interval As Single, NIntervals As Integer
    Call PlotIntervals(5.5, Wmin, Wmax, Start, Interval, NIntervals)
    Call DrawGrid(Start, Interval, NIntervals)
    'plot weight data
    Call PlotData(N, W, Color.Blue)
  End Sub
  Private Sub PlotData(ByVal N As Integer, ByVal T() As Single, ByVal C As Color)
    Dim I As Integer
    Dim MyPen As Pen = New Pen(C)
    'find first point
    Dim PreviousI As Integer
    For I = 1 To N - 1
      'plot if there is a point
      If T(I) > -1000.0 Then
        PreviousI = I
        Exit For
      End If
    Next I
    Dim IStart As Integer = PreviousI + 1
    For I = IStart To N
      'if there is a point, connect to previous points
      If T(I) > -1000.0 Then
        Plot.DrawLine(MyPen, CInt(PlotGrid.X + (PreviousI - 1) * PlotGrid.Width / (N - 1)), YuToYc(PlotGrid, T(PreviousI), Wmin, Wmax), CInt(PlotGrid.X + (I - 1) * PlotGrid.Width / (N - 1)), YuToYc(PlotGrid, T(I), Wmin, Wmax))
        PreviousI = I
      End If
    Next I
  End Sub
  Private Sub DrawGrid(ByVal Start As Single, ByVal Interval As Single, ByVal NumberIntervals As Integer)
    'draw grid and axis labels
    Plot.DrawRectangle(Pens.Black, PlotGrid)
    Dim I As Integer, Y As Integer
    Dim MyFont As Font = New Font("Arial", 8)
    Dim MySize As SizeF
    Dim S As String
    Wmin = Start : Wmax = Start + NumberIntervals * Interval
    For I = 0 To NumberIntervals
      Y = YuToYc(PlotGrid, Start + I * Interval, Wmin, Wmax)
      Plot.DrawLine(Pens.Black, PlotGrid.X, Y, PlotGrid.X + PlotGrid.Width, Y)
      S = Format(Start + I * Interval, "0")
      MySize = Plot.MeasureString(S, MyFont)
      Plot.DrawString(S, MyFont, Brushes.Black, PlotGrid.X - MySize.Width, CInt(Y - 0.5 * MySize.Height))
    Next
  End Sub
  Private Function YuToYc(ByVal r As Drawing.Rectangle, ByVal Yu As Single, ByVal Ymin As Single, ByVal Ymax As Single) As Integer
    Return (CInt(r.Y + r.Height - r.Height * ((Yu - Ymin) / (Ymax - Ymin))))
  End Function
  Private Sub PlotIntervals(ByVal N As Single, ByVal Min As Single, ByVal Max As Single, ByRef Low As Single, ByRef Delta As Single, ByRef NIntervals As Integer)
    'this is very old basic code to find 'nice' plot intervals
    'i've been using this since 1984!!
    Dim Eps As Single = 0.025
    If Min = Max Then Min = CSng(0.9 * Max)
    Dim A As Single = Math.Abs(Min)
    If Math.Abs(Min) < Math.Abs(Max) Then A = Math.Abs(Max)
    Dim Scale As Single = CSng(10 ^ Int(Math.Log(A) / Math.Log(10) / 10.0))
    Dim MaxA As Single, MinA As Single
    Dim MaxP As Single, MinP As Single
    Dim D As Single, F As Single, J As Single
    Dim E As Integer, V As Integer, G As Integer, H As Integer
    Do
      Scale *= 10
      MinA = Min / Scale : MaxA = Max / Scale
      D = (MaxA - MinA) / N : J = D * Eps
      E = CInt((Math.Log(D) / Math.Log(10) - 0.5))
      F = CSng(D / 10 ^ E) : V = 10
      If F < Math.Sqrt(50) Then V = 5
      If F < Math.Sqrt(10) Then V = 2
      If F < Math.Sqrt(2) Then V = 1
      Delta = CSng(V * 10 ^ E)
      G = CInt(MinA / Delta - 0.5)
      If Math.Abs(G + 1 - MinA / Delta) < J Then G += 1
      MinP = Delta * G
      H = CInt(MaxA / Delta - 0.5) + 1
      If Math.Abs(MaxA / Delta + 1 - H) < J Then H -= 1
      MaxP = Delta * H
      NIntervals = H - G
    Loop Until Math.Abs(MaxP) < 10 And Math.Abs(MinP) < 10
    Low = MinP * Scale : Delta *= Scale
  End Sub
End Class
