Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Public Class frmMain

    Public Shared kpi As String
    Public Shared data As String
    Dim general = New List(Of String) From {"Product Revenue", "Services Revenue", "Total Income", "Direct Costs", "Indirect Costs", "Total Costs", "Profit"}
    Dim business_plan = New List(Of String) From {"Test1", "Test2", "Test3"}
    'Dim MyDimensions As List(Of Dimensions)
    Public Shared dimensions As New Dictionary(Of String, List(Of String))
    Public Shared y As frmItems
    Public Shared x As frmVersions
    Public Shared z As frmNewKPI
    Public Shared versionGlobal As New Dictionary(Of String, Boolean)
    Public Shared localVersions As New Dictionary(Of String, Boolean())
    Dim versionArray As Boolean() = New Boolean(2) {}
    'Dim toCartesian()() As String
    Public Shared aaa As String
    Dim bbb As Boolean = False
    Dim excelForm As frmLocateExcelData
    Public Shared importFromExcelClicked As Boolean
    Public Shared addKPIClicked As Boolean
    Dim finalArraySize As Integer

    Private Property number As Integer = 1

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function


    Public ReadOnly Property GetchkActual() As Boolean
        Get
            Return chkActual.Checked
        End Get
    End Property

    Public ReadOnly Property GetchkBudget()
        Get
            Return chkBudget.Checked
        End Get
    End Property

    Public ReadOnly Property GetchkForecast()
        Get
            Return chkForecast.Checked
        End Get
    End Property

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNextTab.Click
        Dim CountTab As Integer = 1
        TabControl1.SelectTab(CountTab)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        Dim toCartesian()() As String = New String(dimensions.Keys.Count)() {}
        Dim i As Integer
        finalArraySize = 0
        For i = 0 To dimensions.Keys.Count - 1
            toCartesian(i) = dimensions.Values(i).ToArray
            finalArraySize += 1
            'toCartesian(i) = {"aaa", "bbb", "ccc"}
        Next


        Dim activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
        'Dim firstRow As Excel.Range = activeWorksheet.Range("A1")
        'firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
        Dim col As Integer = 1
        Dim row As Integer = 1
        Dim finalResult()() As String = New String(100)() {}
        Dim count As Integer = dimensions.Keys.Count
        Dim finalArr As String()() = New String(count)() {}
        Dim tempas As String()
        'Dim route As IEnumerable(Of String)

        If False Then
            For Each dyma As List(Of String) In dimensions.Values
                tempas = dyma.ToArray
                finalArr(i) = New String() {"aaa", "bbb"}
                i += 1
            Next

        End If

        finalArraySize -= 1
        finalResult = CartesianProduct(toCartesian)





        For Each dimen As String() In finalResult
            For Each dimen2 As String In dimen
                Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, col)
                newFirstRow.Value2 = dimen2
                col += 1
            Next
            Dim newFirstCol As Excel.Range = activeWorksheet.Cells(row, col)
            'newFirstCol.Value2 = dimen
            col = 1
            row += 1
            'Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, 1)
            'newFirstRow.Value2 = dimen
            'row += 1
        Next

        Dim kk As Integer
        Dim tempCol As Integer
        tempCol = col
        col = row
        row = tempCol


        For Each finalKPI In versionGlobal
            For kk = 0 To 100
                Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, col)
                newFirstRow.Value2 = GetRandom(10000, 15000)
                row += 1
            Next
            Dim newFirstCol As Excel.Range = activeWorksheet.Cells(row, col)
            'newFirstCol.Value2 = GetRandom(10000, 15000)
            row = 1
            col += 1
        Next

        If False Then
            For Each ite In finalResult
                Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, 1)
                newFirstRow.Value2 = ite
                row += 1
            Next
        End If


        If False Then

            For Each itemList As KeyValuePair(Of String, List(Of String)) In dimensions
                Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, col)
                newFirstRow.Value2 = itemList.Key
                row += 1
                For Each item As String In dimensions.Item(itemList.Key)
                    Dim newFirstCol As Excel.Range = activeWorksheet.Cells(row, col)
                    newFirstCol.Value2 = item.ToString
                    row += 1
                Next
                col += 1
                row = 1
            Next

        End If


        If False Then
            For Each item As String In cmbSelectedKPI.Items
                Dim newFirstRow As Excel.Range = activeWorksheet.Cells(1, col)
                newFirstRow.Value2 = item.ToString
                col += 1
            Next
        End If

        'Dim newFirstRow As Excel.Range = activeWorksheet.Cells(1, 1)
        'newFirstRow.Value2 = "This text was added by using code"
        'Excel.Worksheets(1).Range("A1").Value = "Hello"
        'Dim wb As New Excel.Workbook
        'Dim sheet As Excel.Worksheet = wb.Sheets(1)
        'sheet.Range("A1").EntireRow.Insert(Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
        'sheet.Range("A1").Value = "ADD-IN EXPRESS, LTD"
        Close()
    End Sub

    Private Sub add_subject_Click(sender As Object, e As EventArgs)
        Dim tb As New TextBox
        tb.Name = "TextBox" + number.ToString
        tb.Location = New Point(number * 40, 10)
        Controls.Add(tb)
        number = number + 1
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddKPI.Click
        versionGlobal.Add(cmbKPIList.Text, True)
        Dim lvi As New ListViewItem
        lvi.Text = cmbKPIList.Text
        If versionGlobal(cmbKPIList.Text) Then
            lvi.SubItems.Add("Global")
        End If
        If versionGlobal(cmbKPIList.Text) = False Then
            lvi.SubItems.Add("Local")
        End If
        cmbSelectedKPI.Items.Add(lvi)
        cmbKPIList.Items.Remove(cmbKPIList.Text)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles cmbKPIList.DoubleClick
        versionGlobal.Add(cmbKPIList.Text, True)
        Dim lvi As New ListViewItem
        lvi.Text = cmbKPIList.Text
        If versionGlobal(cmbKPIList.Text) Then
            lvi.SubItems.Add("Global")
        End If
        If versionGlobal(cmbKPIList.Text) = False Then
            lvi.SubItems.Add("Local")
        End If
        cmbSelectedKPI.Items.Add(lvi)
        cmbKPIList.Items.Remove(cmbKPIList.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemoveKPI.Click
        cmbKPIList.Items.Add(cmbSelectedKPI.FocusedItem.Text)
        versionGlobal.Remove(cmbKPIList.Text)
        cmbSelectedKPI.FocusedItem.Remove()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnPreviousTab.Click
        Dim CountTab As Integer = 0
        TabControl1.SelectTab(CountTab)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Dim CountTab As Integer = 1
        TabControl1.SelectTab(CountTab)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKPIGroup.SelectedIndexChanged
        'For Each item As String In ListBox1.Items
        'ListBox1.Items.Remove(item)
        'Next
        cmbKPIList.Items.Clear()

        If (cmbKPIGroup.SelectedItem = "General") Then
            For Each item As String In general
                cmbKPIList.Items.Add(item)
            Next
        End If
        If (cmbKPIGroup.SelectedItem = "Business Plan") Then
            For Each item As String In business_plan
                cmbKPIList.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For Each item As String In general
        'ListBox1.Items.Add(item)
        'Next
        Me.TopMost = True
        cmbKPIGroup.Items.Add("General")
        cmbKPIGroup.Items.Add("Business Plan")
        cmbKPIGroup.SelectedIndex = 0
        'cmbDataType.SelectedIndex = 0
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Dim activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
        'Dim firstRow As Excel.Range = activeWorksheet.Range("A1")
        'firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
        Dim col As Integer = 1
        For Each item As String In cmbSelectedKPI.Items
            Dim newFirstRow As Excel.Range = activeWorksheet.Cells(1, col)
            newFirstRow.Value2 = item.ToString
            col += 1
        Next
        'Dim newFirstRow As Excel.Range = activeWorksheet.Cells(1, 1)
        'newFirstRow.Value2 = "This text was added by using code"
        'Excel.Worksheets(1).Range("A1").Value = "Hello"
        'Dim wb As New Excel.Workbook
        'Dim sheet As Excel.Worksheet = wb.Sheets(1)
        'sheet.Range("A1").EntireRow.Insert(Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
        'sheet.Range("A1").Value = "ADD-IN EXPRESS, LTD"
        Close()
    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As System.EventArgs) Handles cmbSelectedKPI.DoubleClick
        kpi = cmbSelectedKPI.FocusedItem.Text
        x = New frmVersions
        AddHandler x.FormClosed, AddressOf x_FormClosed
        x.chkGlobal.Checked = versionGlobal(kpi)
        If versionGlobal(kpi) Then
            x.chkActual.Checked = chkActual.Checked
            x.chkBudget.Checked = chkBudget.Checked
            x.chkForecast.Checked = chkForecast.Checked
        End If
        If versionGlobal(kpi) = False Then
            If localVersions.ContainsKey(kpi) Then
                x.chkActual.Checked = localVersions.Item(kpi)(0)
                x.chkBudget.Checked = localVersions.Item(kpi)(1)
                x.chkForecast.Checked = localVersions.Item(kpi)(2)
            End If
        End If
        x.Show()
    End Sub

    Private Sub x_FormClosed(sender As Object, e As FormClosedEventArgs)
        If x.chkGlobal.Checked = False Then
            versionGlobal.Item(kpi) = False
            If localVersions.ContainsKey(kpi) = False Then
                localVersions.Add(kpi, versionArray)
            End If
            localVersions.Item(kpi)(0) = x.chkActual.Checked
            localVersions.Item(kpi)(1) = x.chkBudget.Checked
            localVersions.Item(kpi)(2) = x.chkForecast.Checked
            cmbSelectedKPI.Items(cmbSelectedKPI.FocusedItem.Index).SubItems(1).Text = "Local"
        End If

        If x.chkGlobal.Checked Then
            versionGlobal.Item(kpi) = True
            If localVersions.ContainsKey(kpi) Then
                localVersions.Remove(kpi)
            End If
            cmbSelectedKPI.Items(cmbSelectedKPI.FocusedItem.Index).SubItems(1).Text = "Global"
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub addDimension(ByVal newDimension As String)
        'Dim Dimension1 As Dimensions = New Dimensions(txtDataName.Text)
        'MyDimensions.Add(Dimension1)
        'MyDimensions.Add(New Dimensions(txtDataName.Text))
        Dim lvi As New ListViewItem
        Dim items As New List(Of String)
        dimensions.Add(newDimension, items)
        'frmMain.dimensions.Item(txtDataName.Text).Add("aaa")
        'frmMain.dimensions.Item(txtDataName.Text).Add("BBB")
        'dimensionCount.Add(txtDataName.Text, dimensions.Item(txtDataName.Text).Count())
        'updateCounter()
        'Label7.Text = ""
        'For Each line In dimensionCount
        'Label7.Text &= line.Value
        'Next
        'Label7.Text &= vbCrLf & txtDataName.Text & ": " & dimensions.Item(txtDataName.Text).Count()

        lvi.Text = newDimension
        lvi.SubItems.Add(dimensions.Item(newDimension).Count())
        lbDimensions.Items.Add(lvi)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles txtDataName.KeyDown
        If e.KeyCode = Keys.Enter Then
            addDimension(txtDataName.Text)
        End If
    End Sub

    Private Sub lbDimensions_DoubleClick(sender As Object, e As System.EventArgs) Handles lbDimensions.DoubleClick
        data = lbDimensions.FocusedItem.Text
        y = New frmItems
        AddHandler y.FormClosed, AddressOf y_FormClosed
        y.Show()
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKPIList.SelectedIndexChanged

    End Sub

    Private Sub btnAddDimClick(sender As Object, e As EventArgs) Handles btnAddDim.Click
        addDimension(txtDataName.Text)
    End Sub

    Private Sub btnRemoveDimClick(sender As Object, e As EventArgs) Handles btnRemoveDim.Click
        dimensions.Remove(lbDimensions.Text)
        lbDimensions.FocusedItem.Remove()
    End Sub

    Private Sub btnCreateNewKPIClick(sender As Object, e As EventArgs) Handles btnCreateNewKPI.Click
        addKPIClicked = False
        z = New frmNewKPI
        AddHandler z.FormClosed, AddressOf z_FormClosed
        z.chkActual.Checked = chkActual.Checked
        z.chkBudget.Checked = chkBudget.Checked
        z.chkForecast.Checked = chkForecast.Checked
        z.Show()
    End Sub

    Private Sub z_FormClosed(sender As Object, e As FormClosedEventArgs)

        If addKPIClicked = True Then
            Dim lvi As New ListViewItem
            If z.chkGlobal.Checked = False Then
                versionGlobal.Add(z.txtNewKPI.Text, False)
                If localVersions.ContainsKey(z.txtNewKPI.Text) = False Then
                    localVersions.Add(z.txtNewKPI.Text, versionArray)
                End If
                localVersions.Item(z.txtNewKPI.Text)(0) = z.chkActual.Checked
                localVersions.Item(z.txtNewKPI.Text)(1) = z.chkBudget.Checked
                localVersions.Item(z.txtNewKPI.Text)(2) = z.chkForecast.Checked
            End If

            If z.chkGlobal.Checked Then
                versionGlobal.Add(z.txtNewKPI.Text, True)
                If localVersions.ContainsKey(z.txtNewKPI.Text) Then
                    localVersions.Remove(z.txtNewKPI.Text)
                End If
            End If

            lvi.Text = z.txtNewKPI.Text
            If versionGlobal(z.txtNewKPI.Text) Then
                lvi.SubItems.Add("Global")
            End If
            If versionGlobal(z.txtNewKPI.Text) = False Then
                lvi.SubItems.Add("Local")
            End If
            cmbSelectedKPI.Items.Add(lvi)
        End If


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Shared Sub chkActual_CheckedChanged(sender As Object, e As EventArgs) Handles chkActual.CheckedChanged

    End Sub

    Private Sub y_FormClosed(sender As Object, e As FormClosedEventArgs)
        'Dim y As frmItems = New frmItems
        dimensions.Item(data).Clear()
        For Each item In y.lbItems.Items
            dimensions.Item(data).Add(item.ToString)
        Next
        'dimensionCount.Item(data) = vbCrLf & data & ": " & dimensions.Item(data).Count()
        'updateCounter()
        lbDimensions.Items(lbDimensions.FocusedItem.Index).SubItems(1).Text = dimensions.Item(data).Count()

    End Sub

    Private Function CartesianProduct(ByVal sequences As String()()) As String()()
        Dim i As Integer
        Dim sequence() As String
        ' base case: 
        Dim result As IEnumerable(Of String()) = {New String() {}}
        For i = 0 To finalArraySize
            sequence = sequences(i)
            Dim s = sequence
            ' don't close over the loop variable 
            ' recursive case: use SelectMany to build the new product out of the old one 
            result = From seq In result
                     From item In s
                     Select seq.Concat({item}).ToArray()
        Next i

        Return result.ToArray()

    End Function


    Private Sub ListBox1_DrawItem(sender As System.Object, e As System.Windows.Forms.DrawItemEventArgs)
        e.DrawBackground()

        'If cmbSelectedKPI.Items(e.Index).ToString() = "Profit" Then
        If versionGlobal(aaa) Then
            e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
            Console.ReadLine()
        End If
        If versionGlobal(aaa) = False Then
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds)
        End If
        e.Graphics.DrawString(cmbSelectedKPI.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
        e.DrawFocusRectangle()

        If bbb Then
            For Each item In versionGlobal
                If versionGlobal(item.Key) Then
                    cmbKPIList.Items.Add("TRUE")
                    e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
                    'e.Graphics.DrawString(cmbSelectedKPI.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
                    e.DrawFocusRectangle()
                End If
                If versionGlobal(item.Key) = False Then
                    cmbKPIList.Items.Add("FALSE")
                    e.Graphics.FillRectangle(Brushes.Red, e.Bounds)
                    'e.Graphics.DrawString(cmbSelectedKPI.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
                    e.DrawFocusRectangle()
                End If
                'e.Graphics.DrawString(cmbSelectedKPI.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
                'e.DrawFocusRectangle()
            Next
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        bbb = True
        cmbSelectedKPI.Refresh()
    End Sub

    Private Sub cmbSelectedKPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectedKPI.SelectedIndexChanged

    End Sub

    Private Sub btnDatabase_Click(sender As Object, e As EventArgs) Handles btnDatabase.Click

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        excelForm = New frmLocateExcelData
        AddHandler excelForm.FormClosed, AddressOf excelForm_FormClosed
        importFromExcelClicked = False
        excelForm.Show()

    End Sub

    Private Sub excelForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        'Dim lvi As New ListViewItem
        'Dim items As New List(Of String)
        If importFromExcelClicked Then
            Dim headerCell As String = "error"
            Dim i As Integer
            'Dim y As Integer

            For i = 1 To excelForm.cellRange.Columns.Count
                Dim lvi As New ListViewItem
                Dim items As New List(Of String)
                For Each cell In excelForm.cellRange.Cells(1, i)
                    headerCell = cell.Value.ToString
                Next
                lvi.Text = headerCell
                dimensions.Add(headerCell, items)

                For j = 2 To excelForm.cellRange.Rows.Count
                    For Each cell In excelForm.cellRange.Cells(j, i)
                        dimensions.Item(headerCell).Add(cell.Value.ToString)
                    Next
                Next j
                lvi.SubItems.Add(dimensions.Item(headerCell).Count())
                lbDimensions.Items.Add(lvi)
            Next i
        End If

    End Sub
End Class
