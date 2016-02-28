<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectToServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectToServer))
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnConnectToDB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.chkWinAuth = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(77, 93)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(176, 20)
        Me.txtUserName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(77, 120)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(176, 20)
        Me.txtPassword.TabIndex = 2
        '
        'btnConnectToDB
        '
        Me.btnConnectToDB.Location = New System.Drawing.Point(101, 163)
        Me.btnConnectToDB.Name = "btnConnectToDB"
        Me.btnConnectToDB.Size = New System.Drawing.Size(75, 23)
        Me.btnConnectToDB.TabIndex = 3
        Me.btnConnectToDB.Text = "Connect"
        Me.btnConnectToDB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(56, 29)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(197, 20)
        Me.txtServer.TabIndex = 0
        '
        'chkWinAuth
        '
        Me.chkWinAuth.AutoSize = True
        Me.chkWinAuth.Checked = True
        Me.chkWinAuth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWinAuth.Location = New System.Drawing.Point(13, 67)
        Me.chkWinAuth.Name = "chkWinAuth"
        Me.chkWinAuth.Size = New System.Drawing.Size(141, 17)
        Me.chkWinAuth.TabIndex = 7
        Me.chkWinAuth.Text = "Windows Authentication"
        Me.chkWinAuth.UseVisualStyleBackColor = True
        '
        'frmConnectToDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(270, 201)
        Me.Controls.Add(Me.chkWinAuth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConnectToDB)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnectToDatabase"
        Me.Text = "Connect to Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserName As Windows.Forms.TextBox
    Friend WithEvents txtPassword As Windows.Forms.TextBox
    Friend WithEvents btnConnectToDB As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtServer As Windows.Forms.TextBox
    Friend WithEvents chkWinAuth As Windows.Forms.CheckBox
End Class
