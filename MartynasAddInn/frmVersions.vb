Imports Microsoft.Office.Interop.Excel

Public Class frmVersions

    Dim versionGlobal As Boolean = frmMain.versionGlobal(frmMain.kpi)

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Text = frmMain.kpi

        'If versionGlobal Then
        'If frmMain.GetchkActual Then
        'chkActual.Checked = True
        'End If
        'If f.GetchkActual = False Then
        'chkActual.Checked = False
        'End If
        'If f.chkBudget.Checked Then
        'chkBudget.Checked = True
        'End If
        'If f.chkBudget.Checked = False Then
        'chkBudget.Checked = False
        'End If
        'If f.chkForecast.Checked Then
        'chkForecast.Checked = True
        'End If
        'If f.chkForecast.Checked = False Then
        'chkForecast.Checked = False
        'End If
        'End If

        If versionGlobal = False Then
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub chkActual_CheckedChanged(sender As Object, e As EventArgs) Handles chkActual.CheckedChanged
        frmMain.versionGlobal(frmMain.kpi) = False
    End Sub
End Class