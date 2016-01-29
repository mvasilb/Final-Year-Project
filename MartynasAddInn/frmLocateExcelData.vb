﻿Public Class frmLocateExcelData

    Dim WithEvents activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
    Public cellRange As Excel.Range
    Dim colRange As Excel.Range
    Dim rowRange As Excel.Range


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub frmLocateExcelData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cellRange = Globals.ThisAddIn.Application.Selection
        colRange = cellRange.Columns
        rowRange = cellRange.Rows
        TextBox1.Text = cellRange.Address
    End Sub

    Private Sub activeWorksheet_SelectionChange(ByVal Target As Excel.Range) Handles activeWorksheet.SelectionChange
        cellRange = Globals.ThisAddIn.Application.Selection
        TextBox1.Text = cellRange.Address
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        For Each cell In cellRange
            'frmMain.dimensions.Item(frmMain.data).Add(cell.Value.ToString)
        Next
        'frmMain.dimensionCount.Item(frmMain.data) = vbCrLf & frmMain.data & ": " & frmMain.dimensions.Item(frmMain.data).Count()
        Me.Close()
    End Sub
End Class