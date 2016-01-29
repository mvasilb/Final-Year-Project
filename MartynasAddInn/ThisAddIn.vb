Public Class ThisAddIn
    Private Sub ThisAddIn_Startup() Handles Me.Startup
        'Dim activeWorksheet As Excel.Worksheet = CType(Application.ActiveSheet, Excel.Worksheet)
        'Dim firstRow As Excel.Range = activeWorksheet.Range("A1")
        'firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
        'Dim newFirstRow As Excel.Range = activeWorksheet.Range("A1")
        'newFirstRow.Value2 = "This text was added by using code"
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
