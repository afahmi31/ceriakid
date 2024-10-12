<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x
    Inherits MetroFramework.Forms.MetroForm


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
        Me.inputEmail = New MetroFramework.Controls.MetroTextBox()
        Me.inputPassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.SuspendLayout()
        '
        'inputEmail
        '
        '
        '
        '
        Me.inputEmail.CustomButton.Image = Nothing
        Me.inputEmail.CustomButton.Location = New System.Drawing.Point(259, 1)
        Me.inputEmail.CustomButton.Name = ""
        Me.inputEmail.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.inputEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.inputEmail.CustomButton.TabIndex = 1
        Me.inputEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.inputEmail.CustomButton.UseSelectable = True
        Me.inputEmail.CustomButton.Visible = False
        Me.inputEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.inputEmail.Lines = New String(-1) {}
        Me.inputEmail.Location = New System.Drawing.Point(100, 101)
        Me.inputEmail.MaxLength = 32767
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.inputEmail.PromptText = "Email"
        Me.inputEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.inputEmail.SelectedText = ""
        Me.inputEmail.SelectionLength = 0
        Me.inputEmail.SelectionStart = 0
        Me.inputEmail.ShortcutsEnabled = False
        Me.inputEmail.Size = New System.Drawing.Size(283, 25)
        Me.inputEmail.Style = MetroFramework.MetroColorStyle.Blue
        Me.inputEmail.TabIndex = 0
        Me.inputEmail.UseSelectable = True
        Me.inputEmail.WaterMark = "Email"
        Me.inputEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.inputEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'inputPassword
        '
        '
        '
        '
        Me.inputPassword.CustomButton.BackColor = System.Drawing.Color.Silver
        Me.inputPassword.CustomButton.Image = Global.Ceria_Kid.My.Resources.Resources.AdminLTELogo
        Me.inputPassword.CustomButton.Location = New System.Drawing.Point(259, 1)
        Me.inputPassword.CustomButton.Name = ""
        Me.inputPassword.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.inputPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.inputPassword.CustomButton.TabIndex = 1
        Me.inputPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.inputPassword.CustomButton.UseSelectable = True
        Me.inputPassword.CustomButton.UseVisualStyleBackColor = True
        Me.inputPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.inputPassword.Lines = New String(-1) {}
        Me.inputPassword.Location = New System.Drawing.Point(99, 130)
        Me.inputPassword.MaxLength = 32767
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputPassword.PromptText = "Password"
        Me.inputPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.inputPassword.SelectedText = ""
        Me.inputPassword.SelectionLength = 0
        Me.inputPassword.SelectionStart = 0
        Me.inputPassword.ShortcutsEnabled = False
        Me.inputPassword.ShowButton = True
        Me.inputPassword.Size = New System.Drawing.Size(283, 25)
        Me.inputPassword.Style = MetroFramework.MetroColorStyle.Silver
        Me.inputPassword.TabIndex = 1
        Me.inputPassword.UseSelectable = True
        Me.inputPassword.WaterMark = "Password"
        Me.inputPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.inputPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.MetroButton1.Location = New System.Drawing.Point(307, 172)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroButton1.TabIndex = 2
        Me.MetroButton1.Text = "Sign In"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(54, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Sign in"
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroProgressBar1.Location = New System.Drawing.Point(20, 218)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.MetroProgressBar1.Size = New System.Drawing.Size(365, 10)
        Me.MetroProgressBar1.TabIndex = 4
        Me.MetroProgressBar1.Visible = False
        '
        'x
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 248)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.inputEmail)
        Me.DoubleBuffered = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "x"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Ceria Kid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents inputPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar

End Class
