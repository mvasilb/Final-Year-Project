Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs) Handles btnRunBIModel.Click
        Dim myForm As New frmMain
        myForm.Show()
    End Sub
End Class
