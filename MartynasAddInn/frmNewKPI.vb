Public Class frmNewKPI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddKPI.Click
        frmMain.addKPIClicked = True
        Close()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class