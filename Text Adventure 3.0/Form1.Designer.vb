<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MitchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Items.AddRange(New Object() {"Type START to begin"})
        Me.lstDisplay.Location = New System.Drawing.Point(13, 39)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(802, 342)
        Me.lstDisplay.TabIndex = 0
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 390)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(803, 20)
        Me.txtInput.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.CreditsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.HighScoreToolStripMenuItem, Me.BackgroundColorToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HighScoreToolStripMenuItem
        '
        Me.HighScoreToolStripMenuItem.Name = "HighScoreToolStripMenuItem"
        Me.HighScoreToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.HighScoreToolStripMenuItem.Text = "High Score"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MitchToolStripMenuItem, Me.XanToolStripMenuItem, Me.JackToolStripMenuItem, Me.GraemeToolStripMenuItem})
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'MitchToolStripMenuItem
        '
        Me.MitchToolStripMenuItem.Name = "MitchToolStripMenuItem"
        Me.MitchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MitchToolStripMenuItem.Text = "Mitch"
        '
        'XanToolStripMenuItem
        '
        Me.XanToolStripMenuItem.Name = "XanToolStripMenuItem"
        Me.XanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.XanToolStripMenuItem.Text = "Xan"
        '
        'JackToolStripMenuItem
        '
        Me.JackToolStripMenuItem.Name = "JackToolStripMenuItem"
        Me.JackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JackToolStripMenuItem.Text = "Jack"
        '
        'GraemeToolStripMenuItem
        '
        Me.GraemeToolStripMenuItem.Name = "GraemeToolStripMenuItem"
        Me.GraemeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GraemeToolStripMenuItem.Text = "Graeme"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 422)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Nightmare"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MitchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraemeToolStripMenuItem As ToolStripMenuItem
End Class
