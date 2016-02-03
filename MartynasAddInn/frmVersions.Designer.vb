<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVersions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVersions))
        Me.chkActual = New System.Windows.Forms.CheckBox()
        Me.chkBudget = New System.Windows.Forms.CheckBox()
        Me.chkForecast = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkGlobal = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.Location = New System.Drawing.Point(12, 44)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(56, 17)
        Me.chkActual.TabIndex = 0
        Me.chkActual.Text = "Actual"
        Me.chkActual.UseVisualStyleBackColor = True
        '
        'chkBudget
        '
        Me.chkBudget.AutoSize = True
        Me.chkBudget.Location = New System.Drawing.Point(86, 44)
        Me.chkBudget.Name = "chkBudget"
        Me.chkBudget.Size = New System.Drawing.Size(60, 17)
        Me.chkBudget.TabIndex = 1
        Me.chkBudget.Text = "Budget"
        Me.chkBudget.UseVisualStyleBackColor = True
        '
        'chkForecast
        '
        Me.chkForecast.AutoSize = True
        Me.chkForecast.Location = New System.Drawing.Point(165, 44)
        Me.chkForecast.Name = "chkForecast"
        Me.chkForecast.Size = New System.Drawing.Size(67, 17)
        Me.chkForecast.TabIndex = 2
        Me.chkForecast.Text = "Forecast"
        Me.chkForecast.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkGlobal
        '
        Me.chkGlobal.AutoSize = True
        Me.chkGlobal.Location = New System.Drawing.Point(12, 12)
        Me.chkGlobal.Name = "chkGlobal"
        Me.chkGlobal.Size = New System.Drawing.Size(92, 17)
        Me.chkGlobal.TabIndex = 4
        Me.chkGlobal.Text = "Global Setting"
        Me.chkGlobal.UseVisualStyleBackColor = True
        '
        'frmVersions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(242, 117)
        Me.Controls.Add(Me.chkGlobal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkForecast)
        Me.Controls.Add(Me.chkBudget)
        Me.Controls.Add(Me.chkActual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVersions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkActual As Windows.Forms.CheckBox
    Friend WithEvents chkBudget As Windows.Forms.CheckBox
    Friend WithEvents chkForecast As Windows.Forms.CheckBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents chkGlobal As Windows.Forms.CheckBox
End Class
