<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbItems
        '
        Me.lbItems.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(26, 89)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(255, 147)
        Me.lbItems.TabIndex = 0
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(206, 58)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(26, 242)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(255, 23)
        Me.btnRemoveItem.TabIndex = 2
        Me.btnRemoveItem.Text = "Remove"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnDatabase
        '
        Me.btnDatabase.Location = New System.Drawing.Point(298, 97)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(62, 62)
        Me.btnDatabase.TabIndex = 3
        Me.btnDatabase.Text = "Import from DB"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(156, 283)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Done"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(26, 60)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(173, 20)
        Me.txtItem.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Item Name"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(298, 165)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(62, 62)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "Import from Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(378, 318)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnDatabase)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.lbItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbItems As Windows.Forms.ListBox
    Friend WithEvents btnAddItem As Windows.Forms.Button
    Friend WithEvents btnRemoveItem As Windows.Forms.Button
    Friend WithEvents btnDatabase As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents txtItem As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnExcel As Windows.Forms.Button
End Class
