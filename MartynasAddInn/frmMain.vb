Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmMain

    Public Shared kpi As String
    Public Shared data As String
    Dim general = New List(Of String) From {"Product Revenue", "Services Revenue", "Total Income", "Direct Costs", "Indirect Costs", "Total Costs", "Profit"}
    Dim business_plan = New List(Of String) From {"Test1", "Test2", "Test3"}
    'Dim MyDimensions As List(Of Dimensions)
    Public Shared dimensions As New Dictionary(Of String, List(Of String))
    Public Shared measures As New Dictionary(Of String, List(Of String))
    Public Shared y As frmItems
    Public Shared x As frmVersions
    Public Shared z As frmNewKPI
    Public Shared versionGlobal As New Dictionary(Of String, Boolean)
    Public Shared localVersions As New Dictionary(Of String, Boolean())
    Dim KPIValues As List(Of String)
    Public Shared ImportedKPIs As New Dictionary(Of String, List(Of String))
    Dim versionArray As Boolean() = New Boolean(2) {}
    'Dim toCartesian()() As String
    Public Shared aaa As String
    Dim bbb As Boolean = False
    Dim excelForm As frmLocateExcelData
    Dim excelKPIForm As frmLocateKPIExcel
    Dim mergeForm As frmMerge
    Dim sheetForm As frmSelectSheet
    Dim csvForm As frmCSV
    Dim connectToServerForm As frmConnectToServer
    Dim selectTableForm As New frmSelectTable
    Public Shared importFromExcelClicked As Boolean
    Public Shared importKPIFromExcelClicked As Boolean
    Public Shared addKPIClicked As Boolean
    Dim finalArraySize As Integer
    Public Shared rowMetaDataList As New List(Of Boolean)
    Public Shared metaDataList As New List(Of List(Of Boolean))
    'Public Shared membersToRemove As New HashSet(Of String)
    Public Shared removeMembers As New Dictionary(Of String, HashSet(Of String))
    Dim noOfRows As Integer = 0
    Dim lastCol As String = "A1"
    Public Shared sources As New Dictionary(Of String, List(Of String))
    Public Shared sourceData As New Dictionary(Of String, List(Of Dictionary(Of String, Integer)))
    Dim dataColumns As List(Of Dictionary(Of String, Integer))
    Dim KPIColumns As Dictionary(Of String, Integer)
    Dim dimColumns As Dictionary(Of String, Integer)
    Public Shared lastSource As Integer = 0
    Dim source1Key As String
    Dim source2Key As String
    Dim mergedTable As DataTable
    Dim removeColumns As New List(Of String)
    Public Shared removeRows As New List(Of String)
    Public Shared fileName As String
    Public Shared filePath As String
    Public Shared selectedSheet As String
    Public Shared selectedServer As String
    Public Shared selectedDatabase As String
    Public Shared selectedTable
    Dim table As DataTable
    Public Shared tables As New Dictionary(Of String, DataTable)
    Dim sourcesabc As Integer = 0
    Public Shared mergeAccepted As Boolean = False
    Public Shared addSource As Boolean = False
    Dim SQL As New SQLControl

    Private Property number As Integer = 1

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNextTab.Click
        Dim CountTab As Integer = 1
        TabControl1.SelectTab(CountTab)
    End Sub

    Private Function FindSheet(ByVal workbook As Excel.Workbook,
    ByVal sheet_name As String) As Excel.Worksheet
        For Each sheet As Excel.Worksheet In workbook.Sheets
            If (sheet.Name = sheet_name) Then Return sheet
        Next sheet

        Return Nothing
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        ' Get the Excel application object.
        Dim writting As New frmWriting
        writting.Show()
        Dim excel_app As New Excel.Application

        'Dim xlWorkBook, xlWorkBook2 As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim xlSourceRange As Excel.Range
        Dim currentCol As Integer = 1

        ' Make Excel visible (optional).
        'excel_app.Visible = True
        excel_app.ScreenUpdating = False

        ' Open the workbook.
        Dim workbook As Excel.Workbook =
        excel_app.Workbooks.Open("D:\test.xlsx")


        'xlWorkBook = excel_app.Workbooks.Open("C:\Users\Martynas\Desktop\APPCHALLENGEREDAGUOJAMAS.xlsx")
        'xlWorkSheet = xlWorkBook.Sheets("Sheet1")
        'xlSourceRange = xlWorkSheet.Range("A1")

        ' See if the worksheet already exists.
        Dim sheet_name As String =
        DateTime.Now.ToString("MM-dd-yy")

        Dim sheet As Excel.Worksheet = FindSheet(workbook,
        sheet_name)
        If (sheet Is Nothing) Then
            ' Add the worksheet at the end.
            sheet = DirectCast(workbook.Sheets.Add(
            After:=workbook.Sheets(workbook.Sheets.Count),
            Count:=1,
            Type:=Excel.XlSheetType.xlWorksheet),
                Excel.Worksheet)
            sheet.Name = sheet_name
        End If

        ' Add some data to individual cells.
        'sheet.Cells(1, 1) = "A"
        'sheet.Cells(1, 2) = "B"
        'sheet.Cells(1, 3) = "C"

        ' Make that range of cells bold and red.
        'Dim header_range As Excel.Range = sheet.Range("A1",
        '"C1")
        'header_range.Font.Bold = True
        'header_range.Font.Color =
        'System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
        'header_range.Interior.Color =
        'System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Pink)


        '''''''''''''''''''''*************SSSSSEEEEEEEENNNNNNNAAAASSSSSSSSSSSSS**********

        'For Each excelSource As ListViewItem In lvDataSources.Items
        '    xlWorkBook = excel_app.Workbooks.Open(excelSource.SubItems(2).Text)
        '    xlWorkSheet = xlWorkBook.Sheets(excelSource.SubItems(3).Text)

        '    Dim rowCounter As Integer = 150 'xlWorkSheet.UsedRange.Rows.Count
        '    For Each dimension2 In sourceData.Item(excelSource.Text).Item(1)
        '        For i = 1 To rowCounter
        '            Dim value_range As Excel.Range = sheet.Cells(i, currentCol)
        '            value_range.Value2 = xlWorkSheet.Cells(i, dimension2.Value)
        '        Next
        '        currentCol += 1
        '    Next

        '    For Each kpi2 In sourceData.Item(excelSource.Text).Item(0)
        '        For i = 1 To rowCounter
        '            Dim value_range As Excel.Range = sheet.Cells(i, currentCol)
        '            value_range.Value2 = xlWorkSheet.Cells(i, kpi2.Value)
        '        Next
        '        currentCol += 1
        '    Next

        'Next

        '''''''''''''''''''''''''''************NNNAAAAAUUUUJJJJAAAASSSS****************


        For Each dimension In removeMembers
            For Each member In dimension.Value
                Dim rows() As DataRow = mergedTable.Select(dimension.Key & " = '" & member & "'")
                For Each row As DataRow In rows
                    mergedTable.Rows.Remove(row)
                Next
            Next
        Next

        For Each col In removeColumns
            mergedTable.Columns.Remove(col)
        Next

        For j As Integer = 0 To mergedTable.Columns.Count - 1
            sheet.Cells(1, j + 1) = mergedTable.Columns(j).ToString
        Next
        For i As Integer = 1 To mergedTable.Rows.Count
            For j As Integer = 0 To mergedTable.Columns.Count - 1
                sheet.Cells(i + 1, j + 1) = mergedTable.Rows(i - 1)(j).ToString
            Next
        Next
        sheet.Columns.AutoFit()


        'For i = 1 To 100
        '    Dim abcd As String = "A" & i
        '    Dim value_range As Excel.Range = sheet.Range(abcd)
        '    value_range.Value2 = xlWorkSheet.Range(abcd)
        'Next


        'Dim value_range As Excel.Range = sheet.Range("A1")
        'xlSourceRange.Copy(value_range)
        'value_range.Value2 = xlSourceRange
        'value_range.Value2 = activeWorksheet2.Range("A1", "D10")

        ' Save the changes and close the workbook.
        workbook.Close(SaveChanges:=True)

        ' Close the Excel server.
        excel_app.Quit()

        writting.Close()
        Close()

        If False Then

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



            If False Then '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

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

            End If

            Dim kk As Integer
            Dim tempCol As Integer
            tempCol = col
            col = row
            row = tempCol

            If False Then ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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
            End If


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



            row = 1
            col = 1
            For Each metaRow In metaDataList
                For Each metaCol In metaRow
                    If metaCol = True Then
                        Dim xRng As Excel.Range = CType(activeWorksheet.Cells(row, metaRow.IndexOf(metaCol)), Excel.Range)
                        Dim val As Object = xRng.Value()
                        Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, col)
                        newFirstRow.Value2 = val
                        row += 1
                    End If
                Next
            Next




            'Dim newFirstRow As Excel.Range = activeWorksheet.Cells(1, 1)
            'newFirstRow.Value2 = "This text was added by using code"
            'Excel.Worksheets(1).Range("A1").Value = "Hello"
            'Dim wb As New Excel.Workbook
            'Dim sheet As Excel.Worksheet = wb.Sheets(1)
            'sheet.Range("A1").EntireRow.Insert(Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
            'sheet.Range("A1").Value = "ADD-IN EXPRESS, LTD"
            Close()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnPreviousTab.Click
        Dim CountTab As Integer = 0
        TabControl1.SelectTab(CountTab)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Dim CountTab As Integer = 1
        TabControl1.SelectTab(CountTab)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For Each item As String In general
        'ListBox1.Items.Add(item)
        'Next
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

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'addDimension(txtDataName.Text)
        End If
    End Sub

    Private Sub lbDimensions_DoubleClick(sender As Object, e As System.EventArgs) Handles lbDimensions.DoubleClick
        data = lbDimensions.FocusedItem.Text
        y = New frmItems
        AddHandler y.FormClosed, AddressOf y_FormClosed
        y.Show()
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

    Private Sub btnRemoveDimClick(sender As Object, e As EventArgs) Handles btnRemoveDim.Click
        'dimensions.Remove(lbDimensions.FocusedItem.Text)
        'dimColumns.Remove(lbDimensions.FocusedItem.Text)
        removeColumns.Add(lbDimensions.FocusedItem.Text)
        lbDimensions.FocusedItem.Remove()
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

    Private Sub btnExcel_Click(sender As Object, e As EventArgs)
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
            ' Dim lastRow As Integer
            Dim stopReading As Boolean
            'Dim y As Integer

            For i = 1 To excelForm.cellRange.Columns.Count
                stopReading = False
                Dim lvi As New ListViewItem
                Dim items As New List(Of String)
                For Each cell In excelForm.cellRange.Cells(1, i)
                    headerCell = cell.Value.ToString
                Next
                lvi.Text = headerCell
                dimensions.Add(headerCell, items)
                'lastRow = excelForm.cellRange.Range(i & excelForm.cellRange.Rows.Count).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row
                'lastRow = excelForm.cellRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row
                For j = 2 To excelForm.cellRange.Rows.Count
                    For Each cell In excelForm.cellRange.Cells(j, i)
                        If String.IsNullOrEmpty(cell.Value) Then
                            stopReading = True
                            Exit For
                        End If
                        If dimensions.Item(headerCell).Contains(cell.Value.ToString) Then
                            Exit For
                        End If
                        dimensions.Item(headerCell).Add(cell.Value.ToString)
                    Next
                    If stopReading Then
                        Exit For
                    End If
                Next j
                lvi.SubItems.Add(dimensions.Item(headerCell).Count())
                lbDimensions.Items.Add(lvi)
            Next i

            For Each metaRow In metaDataList
                Dim colIndex = (excelForm.cellRange.Column) - 1
                metaRow.Item(colIndex) = True
            Next
        End If

    End Sub

    Private Sub btnImportKPI_Click(sender As Object, e As EventArgs)
        excelKPIForm = New frmLocateKPIExcel
        AddHandler excelKPIForm.FormClosed, AddressOf excelKPIForm_FormClosed
        importKPIFromExcelClicked = False
        excelKPIForm.Show()
    End Sub

    Private Sub excelKPIForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        ' If importFromExcelClicked Then
        Dim headerCell As String = "error"
        Dim i As Integer
        Dim stopReading As Boolean
        noOfRows = excelKPIForm.cellRange.Rows.Count

        For i = 1 To excelKPIForm.cellRange.Columns.Count
            Dim lvi As New ListViewItem
            Dim items As New List(Of String)
            For Each cell In excelKPIForm.cellRange.Cells(1, i)
                headerCell = cell.Value.ToString
                'lvi.Text = headerCell
                'lvi.SubItems.Add("6")
                'lbDimensions.Items.Add(lvi)
                'If excelKPIForm.cellRange.Range(2, i).NumberFormat = "@" Then
                'lvi.Text = headerCell
                'lvi.SubItems.Add("6")
                'lbDimensions.Items.Add(lvi)
                'End If
            Next

            For Each cell In excelKPIForm.cellRange.Cells(2, i)
                If Not cell.NumberFormat = "General" Then
                    lvi.Text = headerCell
                    lvi.SubItems.Add("Global")
                    cmbSelectedKPI.Items.Add(lvi)
                Else
                    dimensions.Add(headerCell, items)
                    lvi.Text = headerCell
                    For j = 2 To excelKPIForm.cellRange.Rows.Count
                        For Each cell2 In excelKPIForm.cellRange.Cells(j, i)
                            If String.IsNullOrEmpty(cell2.Value) Then
                                stopReading = True
                                Exit For
                            End If
                            If dimensions.Item(headerCell).Contains(cell2.Value.ToString) Then
                                Exit For
                            End If
                            dimensions.Item(headerCell).Add(cell2.Value.ToString)
                        Next
                        If stopReading Then
                            lastCol = excelKPIForm.cellRange.Cells(1, i).Address(False, False)  '
                            Exit For
                        End If
                    Next j
                    lvi.SubItems.Add(dimensions.Item(headerCell).Count())
                    lbDimensions.Items.Add(lvi)

                End If

            Next

            'If excelKPIForm.cellRange.Range(2, i).getRangeStyle() = "General" Then
            '    lvi.Text = headerCell
            '    lvi.SubItems.Add("6")
            '    cmbSelectedKPI.Items.Add(lvi)
            'End If


        Next

        'End If
    End Sub

    'Private Sub excelKPIForm_FormClosed(sender As Object, e As FormClosedEventArgs)
    '    If importKPIFromExcelClicked Then

    '        Dim headerCell As String = "error"
    '        Dim i As Integer
    '        Dim realRowCount As Integer

    '        Dim stopReading As Boolean

    '        For i = 1 To excelKPIForm.cellRange.Columns.Count
    '            stopReading = False
    '            realRowCount = 0
    '            Dim lvi As New ListViewItem
    '            Dim items As New List(Of String)
    '            For Each cell In excelKPIForm.cellRange.Cells(1, i)
    '                headerCell = cell.Value.ToString
    '            Next

    '            Dim KPIValues As New List(Of String)
    '            ImportedKPIs.Add(headerCell, KPIValues)
    '            lvi.Text = headerCell
    '            lvi.SubItems.Add("Global")
    '            cmbSelectedKPI.Items.Add(lvi)

    '            For j = 2 To excelKPIForm.cellRange.Rows.Count
    '                For Each cell In excelKPIForm.cellRange.Cells(j, i)
    '                    If String.IsNullOrEmpty(cell.Value) Then
    '                        stopReading = True
    '                        Exit For
    '                    End If
    '                    ImportedKPIs.Item(headerCell).Add(cell.Value.ToString)
    '                    realRowCount += 1
    '                Next
    '                If stopReading Then
    '                    Exit For
    '                End If
    '            Next j
    '        Next i

    '        Dim i2 As Integer
    '        Dim j2 As Integer
    '        Dim col_min As Integer
    '        Dim col_max As Integer
    '        Dim activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
    '        col_min = activeWorksheet.UsedRange.Column
    '        col_max = col_min + activeWorksheet.UsedRange.Columns.Count - 1


    '        For i2 = 0 To excelKPIForm.cellRange.Rows.Count
    '            rowMetaDataList.Clear()
    '            For j2 = 0 To col_max
    '                If Not j2 = 5 Then 'excelKPIForm.cellRange.Column - 1 Then
    '                    rowMetaDataList.Add(False)
    '                End If
    '                If j2 = 5 Then 'excelKPIForm.cellRange.Column - 1 Then
    '                    rowMetaDataList.Add(True)
    '                End If
    '            Next
    '            metaDataList.Add(rowMetaDataList)
    '        Next

    '    End If
    'End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs)
        Dim activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
        Dim col As Integer = 1
        Dim row As Integer = 1
        Dim finalResult()() As String = New String(100)() {}
        Dim count As Integer = dimensions.Keys.Count

        For Each KPIList As KeyValuePair(Of String, List(Of String)) In ImportedKPIs
            Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, col)
            newFirstRow.Value2 = KPIList.Key
            row += 1
            For Each item As String In ImportedKPIs.Item(KPIList.Key)
                Dim newFirstCol As Excel.Range = activeWorksheet.Cells(row, col)
                newFirstCol.Value2 = item.ToString
                row += 1
            Next
            col += 1
            row = 1
        Next

    End Sub

    Private Sub btnImport2_Click(sender As Object, e As EventArgs)
        excelKPIForm = New frmLocateKPIExcel
        AddHandler excelKPIForm.FormClosed, AddressOf excelKPIForm2_FormClosed
        importKPIFromExcelClicked = False
        excelKPIForm.Show()
    End Sub

    Private Sub excelKPIForm2_FormClosed(sender As Object, e As FormClosedEventArgs)
        ' If importFromExcelClicked Then
        Dim headerCell As String = "error"
        Dim i As Integer
        Dim stopReading As Boolean
        noOfRows = excelKPIForm.cellRange.Rows.Count

        For i = 1 To excelKPIForm.cellRange.Columns.Count
            Dim lvi As New ListViewItem
            Dim items As New List(Of String)
            For Each cell In excelKPIForm.cellRange.Cells(1, i)
                headerCell = cell.Value.ToString
                'lvi.Text = headerCell
                'lvi.SubItems.Add("6")
                'lbDimensions.Items.Add(lvi)
                'If excelKPIForm.cellRange.Range(2, i).NumberFormat = "@" Then
                'lvi.Text = headerCell
                'lvi.SubItems.Add("6")
                'lbDimensions.Items.Add(lvi)
                'End If
            Next

            For Each cell In excelKPIForm.cellRange.Cells(2, i)
                If Not cell.NumberFormat = "General" Then
                    lvi.Text = headerCell
                    lvi.SubItems.Add("Global")
                    cmbSelectedKPI.Items.Add(lvi)
                Else
                    dimensions.Add(headerCell, items)
                    lvi.Text = headerCell
                    For j = 2 To excelKPIForm.cellRange.Rows.Count
                        For Each cell2 In excelKPIForm.cellRange.Cells(j, i)
                            If String.IsNullOrEmpty(cell2.Value) Then
                                stopReading = True
                                Exit For
                            End If
                            If dimensions.Item(headerCell).Contains(cell2.Value.ToString) Then
                                Exit For
                            End If
                            dimensions.Item(headerCell).Add(cell2.Value.ToString)
                        Next
                        If stopReading Then
                            lastCol = excelKPIForm.cellRange.Cells(1, i).Address(False, False)  '
                            Exit For
                        End If
                    Next j
                    lvi.SubItems.Add(dimensions.Item(headerCell).Count())
                    lbDimensions.Items.Add(lvi)

                End If

            Next

            'If excelKPIForm.cellRange.Range(2, i).getRangeStyle() = "General" Then
            '    lvi.Text = headerCell
            '    lvi.SubItems.Add("6")
            '    cmbSelectedKPI.Items.Add(lvi)
            'End If


        Next

    End Sub

    Private Sub btnExcelTable_Click(sender As Object, e As EventArgs)
        excelForm = New frmLocateExcelData
        AddHandler excelForm.FormClosed, AddressOf excelSourceForm_FormClosed
        importFromExcelClicked = False
        excelForm.Show()
    End Sub

    Private Sub excelSourceForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        ' If importFromExcelClicked Then
        Dim headerCell As String = "error"
        Dim i As Integer
        Dim stopReading As Boolean
        Dim lvItem = New ListViewItem(excelForm.txtboxName.Text)
        lvItem.SubItems.Add("Excel")
        lvItem.SubItems.Add(excelForm.wbPath)
        lvItem.SubItems.Add(excelForm.wsName)
        lvDataSources.Items.Add(lvItem)
        Dim params As New List(Of String)
        sources.Add(excelForm.txtboxName.Text, params)
        sources.Item(excelForm.txtboxName.Text).Add(excelForm.wbPath)
        sources.Item(excelForm.txtboxName.Text).Add(excelForm.wsName)
        Dim dataColumns As New List(Of Dictionary(Of String, Integer))
        Dim KPIColumns As New Dictionary(Of String, Integer)
        Dim dimColumns As New Dictionary(Of String, Integer)
        dataColumns.Add(KPIColumns)
        dataColumns.Add(dimColumns)
        sourceData.Add(excelForm.txtboxName.Text, dataColumns)

        noOfRows = excelForm.cellRange.Rows.Count

        For i = 1 To excelForm.cellRange.Columns.Count
            Dim lvi As New ListViewItem
            Dim items As New List(Of String)
            For Each cell In excelForm.cellRange.Cells(1, i)
                headerCell = cell.Value.ToString
                'lvi.Text = headerCell
                'lvi.SubItems.Add("6")
                'lbDimensions.Items.Add(lvi)
                'If excelKPIForm.cellRange.Range(2, i).NumberFormat = "@" Then
                'lvi.Text = headerCell
                'lvi.SubItems.Add("6")
                'lbDimensions.Items.Add(lvi)
                'End If
            Next

            For Each cell In excelForm.cellRange.Cells(2, i)
                If Not cell.NumberFormat = "General" Then
                    sourceData.Item(excelForm.txtboxName.Text).Item(0).Add(headerCell, i)
                    lvi.Text = headerCell
                    lvi.SubItems.Add("Global")
                    cmbSelectedKPI.Items.Add(lvi)
                Else
                    If Not dimColumns.ContainsKey(headerCell) Then
                        sourceData.Item(excelForm.txtboxName.Text).Item(1).Add(headerCell, i)
                        'dimColumns.Add(headerCell, i)
                        dimensions.Add(headerCell, items)
                        lvi.Text = headerCell
                        For j = 2 To excelForm.cellRange.Rows.Count
                            For Each cell2 In excelForm.cellRange.Cells(j, i)
                                If String.IsNullOrEmpty(cell2.Value) Then
                                    stopReading = True
                                    Exit For
                                End If
                                If dimensions.Item(headerCell).Contains(cell2.Value.ToString) Then
                                    Exit For
                                End If
                                dimensions.Item(headerCell).Add(cell2.Value.ToString)
                            Next
                            If stopReading Then
                                lastCol = excelForm.cellRange.Cells(1, i).Address(False, False)  '
                                Exit For
                            End If
                        Next j
                        lvi.SubItems.Add(dimensions.Item(headerCell).Count())
                        lbDimensions.Items.Add(lvi)
                    Else

                    End If

                End If

            Next

            'If excelKPIForm.cellRange.Range(2, i).getRangeStyle() = "General" Then
            '    lvi.Text = headerCell
            '    lvi.SubItems.Add("6")
            '    cmbSelectedKPI.Items.Add(lvi)
            'End If


        Next
        If sources.Count > 1 Then
            lastSource = sources.Count - 1
            mergeForm = New frmMerge
            AddHandler mergeForm.FormClosed, AddressOf mergeForm_FormClosed
            mergeForm.Show()
        End If


    End Sub

    Private Sub mergeForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        If mergeAccepted Then
            'Dim colsA() As String = sourceData.Item(mergeForm.cmbSource1.SelectedItem).Item(1).Keys.ToArray
            'Dim colsB() As String = sourceData.Item(mergeForm.cmbSource2.SelectedItem).Item(1).Keys.ToArray
            source1Key = mergeForm.dgvSource1.SelectedColumns(0).HeaderText
            source2Key = mergeForm.dgvSource2.SelectedColumns(0).HeaderText
            Dim tblA As New System.Data.DataTable
            Dim tblB As New System.Data.DataTable
            tblA = tables.Item(mergeForm.cmbSource1.SelectedItem)
            tblB = tables.Item(mergeForm.cmbSource2.SelectedItem)
            Dim colsA1 As New List(Of String)
            Dim colsB1 As New List(Of String)
            Dim colsA() As String
            Dim colsB() As String

            For Each column As DataColumn In tblA.Columns
                colsA1.Add(column.ColumnName)
            Next

            For Each column As DataColumn In tblB.Columns
                colsB1.Add(column.ColumnName)
            Next

            colsA = colsA1.ToArray
            colsB = colsB1.ToArray

            'Dim colsA() As String = tblA.Columns.

            'Try
            '    Dim MyConnection As System.Data.OleDb.OleDbConnection
            '    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            '    MyConnection = New System.Data.OleDb.OleDbConnection _
            '    ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & sources.Item(mergeForm.cmbSource1.SelectedItem).Item(0) & "'; Extended Properties=Excel 8.0;")
            '    MyCommand = New System.Data.OleDb.OleDbDataAdapter _
            '        ("select * from [Sheet1$]", MyConnection)
            '    MyCommand.TableMappings.Add("Table", "TestTable")
            '    tblA = New System.Data.DataTable
            '    MyCommand.Fill(tblA)
            '    MyConnection.Close()
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try

            'Try
            '    Dim MyConnection As System.Data.OleDb.OleDbConnection
            '    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            '    MyConnection = New System.Data.OleDb.OleDbConnection _
            '    ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & sources.Item(mergeForm.cmbSource2.SelectedItem).Item(0) & "'; Extended Properties=Excel 8.0;")
            '    MyCommand = New System.Data.OleDb.OleDbDataAdapter _
            '        ("select * from [Sheet1$]", MyConnection)
            '    MyCommand.TableMappings.Add("Table", "TestTable")
            '    tblB = New System.Data.DataTable
            '    MyCommand.Fill(tblB)
            '    MyConnection.Close()
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try

            mergedTable = MergeData(tblA, tblB, colsA, colsB, source1Key, source2Key)
            tables.Item(mergeForm.cmbSource1.SelectedItem) = mergedTable
            mergeAccepted = False
        End If

    End Sub

    Private Function MergeData(ByVal tblA As DataTable, ByVal tblB As DataTable,
                              ByVal colsA() As String, ByVal colsB() As String,
                              ByVal source1Key As String, ByVal source2Key As String) As DataTable

        Dim tbl As DataTable
        Dim col As DataColumn
        Dim sColumnName As String
        Dim row As DataRow
        Dim newRow As DataRow
        Dim dv As DataView

        tbl = New DataTable
        dv = tblB.DefaultView

        For Each sColumnName In colsA
            col = tblA.Columns(sColumnName)
            tbl.Columns.Add(New DataColumn(col.ColumnName, col.DataType))
        Next
        For Each sColumnName In colsB
            col = tblB.Columns(sColumnName)
            If Not colsA.Contains(sColumnName) Then
                tbl.Columns.Add(New DataColumn(col.ColumnName, col.DataType))
            End If
            'tbl.Columns.Add(New DataColumn(col.ColumnName, col.DataType))
        Next

        For Each row In tblA.Rows
            newRow = tbl.NewRow
            For Each sColumnName In colsA
                newRow(sColumnName) = row(sColumnName)
            Next

            dv.RowFilter = (source2Key & " = " & row(source1Key).ToString)
            If dv.Count = 1 Then
                For Each sColumnName In colsB
                    newRow(sColumnName) = dv(0).Item(sColumnName)
                Next
            End If
            tbl.Rows.Add(newRow)
        Next

        Return tbl

    End Function

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        'Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Excel 2007+ Files |*.xlsx"
        fd.FilterIndex = 1
        fd.RestoreDirectory = False

        If fd.ShowDialog() = DialogResult.OK Then
            'strFileName = fd.FileName
            fileName = fd.FileName

            sheetForm = New frmSelectSheet
            AddHandler sheetForm.FormClosed, AddressOf sheetForm_FormClosed
            sheetForm.Show()


        End If
    End Sub

    Private Sub sheetForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        If addSource Then
            Dim lvItem = New ListViewItem(sheetForm.txtSourceName.Text)
            lvItem.SubItems.Add("Excel")
            lvItem.SubItems.Add(fileName)
            lvItem.SubItems.Add(selectedSheet)
            lvDataSources.Items.Add(lvItem)
            Dim params As New List(Of String)
            sources.Add(sheetForm.txtSourceName.Text, params)
            sources.Item(sheetForm.txtSourceName.Text).Add(fileName)
            sources.Item(sheetForm.txtSourceName.Text).Add(selectedSheet)
            Dim colName As String

            Try
                Dim MyConnection As System.Data.OleDb.OleDbConnection
                Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
                MyConnection = New System.Data.OleDb.OleDbConnection _
                ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & fileName & "'; Extended Properties=Excel 8.0;")
                MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                    ("select * from [" & selectedSheet & "$]", MyConnection)
                MyCommand.TableMappings.Add("Table", "TestTable")
                table = New System.Data.DataTable
                MyCommand.Fill(table)
                MyConnection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            sourcesabc += 1

            For j As Integer = 0 To table.Columns.Count - 1
                colName = table.Columns(j).ColumnName
                If Not table.Columns(j).DataType.Name.ToString = "String" Then
                    If Not measures.ContainsKey(colName) Then
                        Dim lvi As New ListViewItem
                        lvi.Text = colName
                        Dim items As New List(Of String)
                        measures.Add(colName, items)
                        For i As Integer = 0 To table.Rows.Count - 1
                            If measures.Item(colName).Contains(table.Rows(i)(j).ToString()) Then
                                Continue For
                            End If
                            measures.Item(colName).Add(table.Rows(i)(j).ToString())
                        Next
                        lvi.SubItems.Add(measures.Item(colName).Count())
                        cmbSelectedKPI.Items.Add(lvi)
                    End If
                Else
                    If Not dimensions.ContainsKey(colName) Then
                        Dim lvi As New ListViewItem
                        lvi.Text = colName
                        Dim items As New List(Of String)
                        dimensions.Add(colName, items)
                        For i As Integer = 0 To table.Rows.Count - 1
                            If dimensions.Item(colName).Contains(table.Rows(i)(j).ToString()) Then
                                Continue For
                            End If
                            dimensions.Item(colName).Add(table.Rows(i)(j).ToString())
                        Next
                        lvi.SubItems.Add(dimensions.Item(colName).Count())
                        lbDimensions.Items.Add(lvi)
                    End If
                End If
            Next

            tables.Add(sheetForm.txtSourceName.Text, table)

            If sources.Count > 1 Then
                lastSource = sources.Count - 1
                mergeForm = New frmMerge
                AddHandler mergeForm.FormClosed, AddressOf mergeForm_FormClosed
                mergeForm.Show()
            End If
            addSource = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        'Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "CSV Files |*.csv"
        fd.FilterIndex = 1
        fd.RestoreDirectory = False

        If fd.ShowDialog() = DialogResult.OK Then
            'strFileName = fd.FileName
            fileName = IO.Path.GetFileName(fd.FileName)
            filePath = IO.Path.GetDirectoryName(fd.FileName)

            csvForm = New frmCSV
            AddHandler csvForm.FormClosed, AddressOf csvForm_FormClosed
            csvForm.Show()


        End If
    End Sub

    Private Sub csvForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        If addSource Then
            Dim lvItem = New ListViewItem(csvForm.txtSourceName.Text)
            lvItem.SubItems.Add("CSV")
            lvItem.SubItems.Add(filePath & fileName)
            lvItem.SubItems.Add("-")
            lvDataSources.Items.Add(lvItem)
            Dim params As New List(Of String)
            sources.Add(csvForm.txtSourceName.Text, params)
            sources.Item(csvForm.txtSourceName.Text).Add(fileName)
            sources.Item(csvForm.txtSourceName.Text).Add(selectedSheet)
            Dim colName As String

            Try
                Dim MyConnection As System.Data.OleDb.OleDbConnection
                MyConnection = New System.Data.OleDb.OleDbConnection _
                ("provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & filePath & "'; Extended Properties=""text;HDR=Yes;FMT=Delimited"";")
                table = New System.Data.DataTable
                Using MyCommand As New OleDbDataAdapter("Select * From [" & fileName & "]", MyConnection)
                    MyCommand.Fill(table)
                End Using

                MyConnection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            For j As Integer = 0 To table.Columns.Count - 1
                colName = table.Columns(j).ColumnName
                If Not table.Columns(j).DataType.Name.ToString = "String" Then
                    If Not measures.ContainsKey(colName) Then
                        Dim lvi As New ListViewItem
                        lvi.Text = colName
                        Dim items As New List(Of String)
                        measures.Add(colName, items)
                        For i As Integer = 0 To table.Rows.Count - 1
                            If measures.Item(colName).Contains(table.Rows(i)(j).ToString()) Then
                                Continue For
                            End If
                            measures.Item(colName).Add(table.Rows(i)(j).ToString())
                        Next
                        lvi.SubItems.Add(measures.Item(colName).Count())
                        cmbSelectedKPI.Items.Add(lvi)
                    End If
                Else
                    If Not dimensions.ContainsKey(colName) Then
                        Dim lvi As New ListViewItem
                        lvi.Text = colName
                        Dim items As New List(Of String)
                        dimensions.Add(colName, items)
                        For i As Integer = 0 To table.Rows.Count - 1
                            If dimensions.Item(colName).Contains(table.Rows(i)(j).ToString()) Then
                                Continue For
                            End If
                            dimensions.Item(colName).Add(table.Rows(i)(j).ToString())
                        Next
                        lvi.SubItems.Add(dimensions.Item(colName).Count())
                        lbDimensions.Items.Add(lvi)
                    End If
                End If

            Next

            tables.Add(csvForm.txtSourceName.Text, table)

            If sources.Count > 1 Then
                lastSource = sources.Count - 1
                mergeForm = New frmMerge
                AddHandler mergeForm.FormClosed, AddressOf mergeForm_FormClosed
                mergeForm.Show()
            End If

            addSource = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveFile As New SaveFileDialog
        saveFile.Filter = "Excel 2007+ File|*.xlsx"
        saveFile.Title = "Save an Excel File"
        saveFile.ShowDialog()
        If saveFile.FileName <> "" Then
            saveExcelFile(saveFile.FileName)
        End If
    End Sub

    Public Sub saveExcelFile(ByVal FileName As String)

        Dim writting As New frmWriting
        writting.Show()
        Dim excel_app As New Excel.Application

        Dim currentCol As Integer = 1

        ' Make Excel visible (optional).
        'excel_app.Visible = True
        excel_app.ScreenUpdating = False

        ' Open the workbook.
        Dim workbook As Excel.Workbook =
        excel_app.Workbooks.Add

        ' See if the worksheet already exists.
        Dim sheet_name As String =
        DateTime.Now.ToString("MM-dd-yy")

        Dim sheet As Excel.Worksheet = FindSheet(workbook,
        sheet_name)
        If (sheet Is Nothing) Then
            ' Add the worksheet at the end.
            sheet = DirectCast(workbook.Sheets.Add(
            After:=workbook.Sheets(workbook.Sheets.Count),
            Count:=1,
            Type:=Excel.XlSheetType.xlWorksheet),
                Excel.Worksheet)
            sheet.Name = sheet_name
        End If

        For Each dimension In removeMembers
            For Each member In dimension.Value
                Dim rows() As DataRow = mergedTable.Select(dimension.Key & " = '" & member & "'")
                For Each row As DataRow In rows
                    mergedTable.Rows.Remove(row)
                Next
            Next
        Next

        For Each col In removeColumns
            mergedTable.Columns.Remove(col)
        Next

        For j As Integer = 0 To mergedTable.Columns.Count - 1
            sheet.Cells(1, j + 1) = mergedTable.Columns(j).ToString
        Next
        For i As Integer = 1 To mergedTable.Rows.Count
            For j As Integer = 0 To mergedTable.Columns.Count - 1
                sheet.Cells(i + 1, j + 1) = mergedTable.Rows(i - 1)(j).ToString
            Next
        Next
        sheet.Columns.AutoFit()

        workbook.SaveAs(FileName)
        workbook.Close(SaveChanges:=True)

        ' Close the Excel server.
        excel_app.Quit()

        writting.Close()
        Close()

    End Sub

    Private Sub btnRemoveMeasure_Click(sender As Object, e As EventArgs) Handles btnRemoveMeasure.Click
        removeColumns.Add(cmbSelectedKPI.FocusedItem.Text)
        cmbSelectedKPI.FocusedItem.Remove()
    End Sub

    Private Sub btnAddKPI_Click(sender As Object, e As EventArgs) Handles btnAddKPI.Click
        dimensions.Add(cmbSelectedKPI.FocusedItem.Text, measures.Item(cmbSelectedKPI.FocusedItem.Text))
        measures.Remove(cmbSelectedKPI.FocusedItem.Text)
        Dim lvi As New ListViewItem
        lvi.Text = cmbSelectedKPI.FocusedItem.Text
        lvi.SubItems.Add(dimensions.Item(cmbSelectedKPI.FocusedItem.Text).Count)
        lbDimensions.Items.Add(lvi)
        cmbSelectedKPI.FocusedItem.Remove()
    End Sub

    Private Sub btnRemoveKPI_Click(sender As Object, e As EventArgs) Handles btnRemoveKPI.Click
        measures.Add(lbDimensions.FocusedItem.Text, dimensions.Item(lbDimensions.FocusedItem.Text))
        dimensions.Remove(lbDimensions.FocusedItem.Text)
        Dim lvi As New ListViewItem
        lvi.Text = lbDimensions.FocusedItem.Text
        lvi.SubItems.Add(measures.Item(lbDimensions.FocusedItem.Text).Count)
        cmbSelectedKPI.Items.Add(lvi)
        lbDimensions.FocusedItem.Remove()
    End Sub

    Private Sub TabSources_Click(sender As Object, e As EventArgs) Handles TabSources.Click

    End Sub

    Private Sub btnDatabaseTable_Click(sender As Object, e As EventArgs) Handles btnDatabaseTable.Click
        connectToServerForm = New frmConnectToServer
        AddHandler connectToServerForm.FormClosed, AddressOf connectToServerForm_FormClosed
        connectToServerForm.Show()
    End Sub

    Private Sub connectToServerForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        selectedServer = connectToServerForm.txtServer.Text
        selectTableForm = New frmSelectTable
        AddHandler selectTableForm.FormClosed, AddressOf selectTableForm_FormClosed
        selectTableForm.Show()
    End Sub

    Private Sub selectTableForm_FormClosed(sender As Object, e As FormClosedEventArgs)

        If addSource Then
            Dim lvItem = New ListViewItem(selectTableForm.txtSourceName.Text)
            lvItem.SubItems.Add("DB Table")
            lvItem.SubItems.Add(selectedServer & "/" & selectedDatabase)
            lvItem.SubItems.Add(selectedTable)
            lvDataSources.Items.Add(lvItem)
            Dim params As New List(Of String)
            sources.Add(selectTableForm.txtSourceName.Text, params)
            sources.Item(selectTableForm.txtSourceName.Text).Add(selectedDatabase)
            sources.Item(selectTableForm.txtSourceName.Text).Add(selectedTable)
            Dim colName As String

            If SQL.HasConnection Then
                SQL.getDataSet("USE " & selectedDatabase & " SELECT * FROM " & selectedTable)
                If SQL.SQLDataSet.Tables.Count > 0 Then
                    table = SQL.SQLDataSet.Tables(0)
                End If
            End If

            For j As Integer = 0 To table.Columns.Count - 1
                colName = table.Columns(j).ColumnName
                If Not table.Columns(j).DataType.Name.ToString = "String" Then
                    If Not measures.ContainsKey(colName) Then
                        Dim lvi As New ListViewItem
                        lvi.Text = colName
                        Dim items As New List(Of String)
                        measures.Add(colName, items)
                        For i As Integer = 0 To table.Rows.Count - 1
                            If measures.Item(colName).Contains(table.Rows(i)(j).ToString()) Then
                                Continue For
                            End If
                            measures.Item(colName).Add(table.Rows(i)(j).ToString())
                        Next
                        lvi.SubItems.Add(measures.Item(colName).Count())
                        cmbSelectedKPI.Items.Add(lvi)
                    End If
                Else
                    If Not dimensions.ContainsKey(colName) Then
                        Dim lvi As New ListViewItem
                        lvi.Text = colName
                        Dim items As New List(Of String)
                        dimensions.Add(colName, items)
                        For i As Integer = 0 To table.Rows.Count - 1
                            If dimensions.Item(colName).Contains(table.Rows(i)(j).ToString()) Then
                                Continue For
                            End If
                            dimensions.Item(colName).Add(table.Rows(i)(j).ToString())
                        Next
                        lvi.SubItems.Add(dimensions.Item(colName).Count())
                        lbDimensions.Items.Add(lvi)
                    End If
                End If

            Next

            tables.Add(selectTableForm.txtSourceName.Text, table)

            If sources.Count > 1 Then
                lastSource = sources.Count - 1
                mergeForm = New frmMerge
                AddHandler mergeForm.FormClosed, AddressOf mergeForm_FormClosed
                mergeForm.Show()
            End If

            addSource = False
        End If

    End Sub

End Class
