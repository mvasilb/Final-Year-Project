Imports System.Drawing
Imports System.Windows.Forms

Public Class frmMain

    Public Shared kpi As String
    Public Shared data As String
    Dim general = New List(Of String) From {"Product Revenue", "Services Revenue", "Total Income", "Direct Costs", "Indirect Costs", "Total Costs", "Profit"}
    Dim business_plan = New List(Of String) From {"Test1", "Test2", "Test3"}
    'Dim MyDimensions As List(Of Dimensions)
    Public Shared dimensions As New Dictionary(Of String, List(Of String))
    Public Shared dimensionCount As New Dictionary(Of String, String)
    'Dim y As frmItems = New frmItems
    Public Shared y As frmItems

    Private Property number As Integer = 1


    Public Sub updateCounter()
        Label7.Text = "No of Items for each Data:"
        For Each line In dimensionCount
            Label7.Text &= line.Value
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNextTab.Click
        Dim CountTab As Integer = 1
        TabControl1.SelectTab(CountTab)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
        'Dim firstRow As Excel.Range = activeWorksheet.Range("A1")
        'firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
        Dim col As Integer = 1
        Dim row As Integer = 1
        Dim finalResult As String()()
        Dim count As Integer = dimensions.Keys.Count
        Dim finalArr As String()() = New String(count)() {}
        Dim tempas As String()
        Dim i As Integer = 0
        'Dim route As IEnumerable(Of String)


        For Each dyma As List(Of String) In dimensions.Values
            tempas = dyma.ToArray
            finalArr(i) = New String() {"aaa", "bbb"}
            i += 1
        Next

        finalResult = CartesianProduct(finalArr)


        If False Then

            For Each dimen As String() In finalResult
            For Each dimen2 As String In dimen
                Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, 1)
                newFirstRow.Value2 = dimen
                row += 1
            Next
            'Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, 1)
            'newFirstRow.Value2 = dimen
            'row += 1
        Next

        End If


        For Each ite In finalResult
            Dim newFirstRow As Excel.Range = activeWorksheet.Cells(row, 1)
            newFirstRow.Value2 = ite
            row += 1
        Next

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
        cmbSelectedKPI.Items.Add(cmbKPIList.Text)
        cmbKPIList.Items.Remove(cmbKPIList.Text)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles cmbKPIList.DoubleClick
        cmbSelectedKPI.Items.Add(cmbKPIList.Text)
        cmbKPIList.Items.Remove(cmbKPIList.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemoveKPI.Click
        cmbKPIList.Items.Add(cmbSelectedKPI.Text)
        cmbSelectedKPI.Items.Remove(cmbSelectedKPI.Text)
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
        kpi = cmbSelectedKPI.Text
        Dim x As frmVersions = New frmVersions
        x.Show()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectedKPI.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDataName.TextChanged

    End Sub

    Private Sub lbDimensions_DoubleClick(sender As Object, e As System.EventArgs) Handles lbDimensions.DoubleClick
        data = lbDimensions.Text
        y = New frmItems
        AddHandler y.FormClosed, AddressOf y_FormClosed
        y.Show()
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDimensions.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKPIList.SelectedIndexChanged

    End Sub

    Private Sub btnAddDimClick(sender As Object, e As EventArgs) Handles btnAddDim.Click
        'Dim Dimension1 As Dimensions = New Dimensions(txtDataName.Text)
        'MyDimensions.Add(Dimension1)
        'MyDimensions.Add(New Dimensions(txtDataName.Text))
        Dim items As New List(Of String)
        dimensions.Add(txtDataName.Text, items)
        lbDimensions.Items.Add(txtDataName.Text)
        'frmMain.dimensions.Item(txtDataName.Text).Add("aaa")
        'frmMain.dimensions.Item(txtDataName.Text).Add("BBB")
        dimensionCount.Add(txtDataName.Text, vbCrLf & txtDataName.Text & ": " & dimensions.Item(txtDataName.Text).Count())
        updateCounter()
        'Label7.Text = ""
        'For Each line In dimensionCount
        'Label7.Text &= line.Value
        'Next
        'Label7.Text &= vbCrLf & txtDataName.Text & ": " & dimensions.Item(txtDataName.Text).Count()
    End Sub

    Private Sub btnRemoveDimClick(sender As Object, e As EventArgs) Handles btnRemoveDim.Click
        dimensions.Remove(lbDimensions.Text)
        dimensionCount.Remove(lbDimensions.Text)
        lbDimensions.Items.Remove(lbDimensions.Text)
        updateCounter()
    End Sub

    Private Sub btnCreateNewKPIClick(sender As Object, e As EventArgs) Handles btnCreateNewKPI.Click
        Dim x As frmNewKPI = New frmNewKPI
        x.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub chkActual_CheckedChanged(sender As Object, e As EventArgs) Handles chkActual.CheckedChanged

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles refreshCount.Click
        updateCounter()
    End Sub

    Private Sub y_FormClosed(sender As Object, e As FormClosedEventArgs)
        'Dim y As frmItems = New frmItems
        dimensions.Item(data).Clear()
        For Each item In y.lbItems.Items
            dimensions.Item(data).Add(item.ToString)
        Next
        dimensionCount.Item(data) = vbCrLf & data & ": " & dimensions.Item(data).Count()
        updateCounter()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Function CartesianProduct(Of T)(ParamArray sequences As T()()) As T()()

        ' base case: 
        Dim result As IEnumerable(Of T()) = {New T() {}}
        For Each sequence In sequences
            Dim s = sequence
            ' don't close over the loop variable 
            ' recursive case: use SelectMany to build the new product out of the old one 
            result = From seq In result
                     From item In s
                     Select seq.Concat({item}).ToArray()
        Next

        Return result.ToArray()

    End Function

    Dim s1 As String() = New String() {"small", "med", "large", "XL"}
    Dim s2 As String() = New String() {"red", "green", "blue"}
    Dim s3 As String() = New String() {"Men", "Women"}
    Dim s4 As String() = New String() {"Mens", "Womens"}

    Dim ss As String()() = CartesianProduct(s1, s2, s3, s4)

End Class
