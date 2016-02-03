<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewKPI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewKPI))
        Me.txtNewKPI = New System.Windows.Forms.TextBox()
        Me.btnAddKPI = New System.Windows.Forms.Button()
        Me.chkForecast = New System.Windows.Forms.CheckBox()
        Me.chkBudget = New System.Windows.Forms.CheckBox()
        Me.chkActual = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkGlobal = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtNewKPI
        '
        Me.txtNewKPI.Location = New System.Drawing.Point(42, 59)
        Me.txtNewKPI.Name = "txtNewKPI"
        Me.txtNewKPI.Size = New System.Drawing.Size(190, 20)
        Me.txtNewKPI.TabIndex = 0
        '
        'btnAddKPI
        '
        Me.btnAddKPI.Location = New System.Drawing.Point(86, 96)
        Me.btnAddKPI.Name = "btnAddKPI"
        Me.btnAddKPI.Size = New System.Drawing.Size(75, 23)
        Me.btnAddKPI.TabIndex = 1
        Me.btnAddKPI.Text = "Add"
        Me.btnAddKPI.UseVisualStyleBackColor = True
        '
        'chkForecast
        '
        Me.chkForecast.AutoSize = True
        Me.chkForecast.Location = New System.Drawing.Point(165, 36)
        Me.chkForecast.Name = "chkForecast"
        Me.chkForecast.Size = New System.Drawing.Size(67, 17)
        Me.chkForecast.TabIndex = 18
        Me.chkForecast.Text = "Forecast"
        Me.chkForecast.UseVisualStyleBackColor = True
        '
        'chkBudget
        '
        Me.chkBudget.AutoSize = True
        Me.chkBudget.Location = New System.Drawing.Point(86, 36)
        Me.chkBudget.Name = "chkBudget"
        Me.chkBudget.Size = New System.Drawing.Size(60, 17)
        Me.chkBudget.TabIndex = 17
        Me.chkBudget.Text = "Budget"
        Me.chkBudget.UseVisualStyleBackColor = True
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.Location = New System.Drawing.Point(12, 36)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(56, 17)
        Me.chkActual.TabIndex = 16
        Me.chkActual.Text = "Actual"
        Me.chkActual.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "KPI:"
        '
        'chkGlobal
        '
        Me.chkGlobal.AutoSize = True
        Me.chkGlobal.Checked = True
        Me.chkGlobal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGlobal.Location = New System.Drawing.Point(12, 13)
        Me.chkGlobal.Name = "chkGlobal"
        Me.chkGlobal.Size = New System.Drawing.Size(92, 17)
        Me.chkGlobal.TabIndex = 20
        Me.chkGlobal.Text = "Global Setting"
        Me.chkGlobal.UseVisualStyleBackColor = True
        '
        'frmNewKPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(252, 132)
        Me.Controls.Add(Me.chkGlobal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkForecast)
        Me.Controls.Add(Me.chkBudget)
        Me.Controls.Add(Me.chkActual)
        Me.Controls.Add(Me.btnAddKPI)
        Me.Controls.Add(Me.txtNewKPI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewKPI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create a new KPI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewKPI As Windows.Forms.TextBox
    Friend WithEvents btnAddKPI As Windows.Forms.Button
    Friend WithEvents chkForecast As Windows.Forms.CheckBox
    Friend WithEvents chkBudget As Windows.Forms.CheckBox
    Friend WithEvents chkActual As Windows.Forms.CheckBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents chkGlobal As Windows.Forms.CheckBox
End Class
