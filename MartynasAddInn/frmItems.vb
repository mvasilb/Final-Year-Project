Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms

Public Class frmItems

    'Dim mainChild As frmMain
    Dim y As frmLocateExcelData
    Dim openDimension As String = frmMain.data
    'Dim y As frmLocateExcelData = New frmLocateExcelData

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim x As frmConnectToServer = New frmConnectToServer
        x.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbItems.SelectedIndexChanged

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        Dim membersToRemove As New HashSet(Of String)
        If Not frmMain.removeMembers.ContainsKey(openDimension) Then
            frmMain.removeMembers.Add(openDimension, membersToRemove)
        End If
        frmMain.removeMembers.Item(openDimension).Add(lbItems.Text)
        lbItems.Items.Remove(lbItems.Text)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Text = openDimension
        lbItems.Items.Clear()
        For Each item In frmMain.dimensions.Item(openDimension)
            lbItems.Items.Add(item.ToString)
        Next
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs)
        y = New frmLocateExcelData
        AddHandler y.FormClosed, AddressOf y_FormClosed
        frmMain.importFromExcelClicked = False
        y.Show()
        If False Then
            Dim activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
            'Dim rng As Excel.Range
            Dim FinalRow As Integer
            FinalRow = activeWorksheet.Cells(activeWorksheet.Rows.Count, 1).End(XlDirection.xlUp).Row
            Dim cellRange As Excel.Range
            Dim colRange As Excel.Range
            Dim rowRange As Excel.Range
            Dim colNo As Integer
            Dim rowNo As Integer
            Dim aaa As String
            cellRange = Globals.ThisAddIn.Application.Selection
            colRange = cellRange.Columns
            rowRange = cellRange.Rows
            aaa = cellRange.Address
            colNo = colRange.Count
            rowNo = rowRange.Count
            For Each cell In cellRange
                lbItems.Items.Add(cell.Value.ToString)
                frmMain.dimensions.Item(openDimension).Add(cell.Value.ToString)
            Next

            'lbItems.Items.Add(("col: " & colNo & "row: " & rowNo).ToString())
            'For i = 1 To FinalRow
            'rng = CType(activeWorksheet.Cells(i, "A"), Excel.Range)
            'rng.Select()
            'lbItems.Items.Add(rng.Value.ToString)
            'Next i
            'rng = CType(activeWorksheet.Cells(1, 1), Excel.Range)
            'lbItems.Items.Add(rng.Value.ToString)
        End If
    End Sub

    Private Sub y_FormClosed(sender As Object, e As FormClosedEventArgs)
        If frmMain.importFromExcelClicked Then
            Dim i As Integer
            If y.chkHeader.Checked = False Then
                For i = 1 To y.cellRange.Rows.Count
                    For Each cell In y.cellRange.Cells(i, 1)
                        lbItems.Items.Add(cell.Value.ToString)
                        'frmMain.dimensions.Item(frmMain.data).Add(cell.Value.ToString)
                    Next
                Next i
            End If
            If y.chkHeader.Checked Then
                For i = 2 To y.cellRange.Rows.Count
                    For Each cell In y.cellRange.Cells(i, 1)
                        lbItems.Items.Add(cell.Value.ToString)
                        'frmMain.dimensions.Item(frmMain.data).Add(cell.Value.ToString)
                    Next
                Next i
            End If
            'frmMain.dimensionCount.Item(frmMain.data) = vbCrLf & frmMain.data & ": " & frmMain.dimensions.Item(frmMain.data).Count()
        End If
    End Sub

End Class