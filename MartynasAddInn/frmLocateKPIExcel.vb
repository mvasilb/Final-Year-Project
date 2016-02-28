Public Class frmLocateKPIExcel

    Dim WithEvents activeWorksheet As Excel.Worksheet = CType(Globals.ThisAddIn.Application.ActiveSheet, Excel.Worksheet)
    Public cellRange As Excel.Range

    Private Sub frmLocateKPIExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        cellRange = Globals.ThisAddIn.Application.Selection
        TextBox1.Text = cellRange.Address
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub activeWorksheet_SelectionChange(ByVal Target As Excel.Range) Handles activeWorksheet.SelectionChange
        cellRange = Globals.ThisAddIn.Application.Selection
        TextBox1.Text = cellRange.Address
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        frmMain.importKPIFromExcelClicked = True
        Me.Close()
    End Sub

End Class