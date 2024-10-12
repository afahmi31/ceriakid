<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScanner
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.inputScanner = New MetroFramework.Controls.MetroTextBox()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.inputScanner)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(496, 189)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroLabel1.Location = New System.Drawing.Point(57, 62)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(372, 106)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'inputScanner
        '
        '
        '
        '
        Me.inputScanner.CustomButton.Image = Nothing
        Me.inputScanner.CustomButton.Location = New System.Drawing.Point(458, 2)
        Me.inputScanner.CustomButton.Name = ""
        Me.inputScanner.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.inputScanner.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.inputScanner.CustomButton.TabIndex = 1
        Me.inputScanner.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.inputScanner.CustomButton.UseSelectable = True
        Me.inputScanner.CustomButton.Visible = False
        Me.inputScanner.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.inputScanner.Lines = New String(-1) {}
        Me.inputScanner.Location = New System.Drawing.Point(3, 6)
        Me.inputScanner.MaxLength = 32767
        Me.inputScanner.Name = "inputScanner"
        Me.inputScanner.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.inputScanner.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.inputScanner.SelectedText = ""
        Me.inputScanner.SelectionLength = 0
        Me.inputScanner.SelectionStart = 0
        Me.inputScanner.ShortcutsEnabled = False
        Me.inputScanner.Size = New System.Drawing.Size(488, 32)
        Me.inputScanner.TabIndex = 0
        Me.inputScanner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.inputScanner.UseSelectable = True
        Me.inputScanner.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.inputScanner.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroProgressBar1.Location = New System.Drawing.Point(20, 255)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.MetroProgressBar1.Size = New System.Drawing.Size(496, 10)
        Me.MetroProgressBar1.TabIndex = 1
        Me.MetroProgressBar1.Visible = False
        '
        'FrmScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 285)
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.DoubleBuffered = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmScanner"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Ceria Kid - Scanner"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents inputScanner As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
