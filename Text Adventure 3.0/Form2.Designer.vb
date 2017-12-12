<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnBlueViolet = New System.Windows.Forms.Button()
        Me.btnCyan = New System.Windows.Forms.Button()
        Me.btnLimeGreen = New System.Windows.Forms.Button()
        Me.btnCornFlowerBlue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(13, 13)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(151, 23)
        Me.btnDefault.TabIndex = 0
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnBlueViolet
        '
        Me.btnBlueViolet.Location = New System.Drawing.Point(13, 43)
        Me.btnBlueViolet.Name = "btnBlueViolet"
        Me.btnBlueViolet.Size = New System.Drawing.Size(151, 23)
        Me.btnBlueViolet.TabIndex = 1
        Me.btnBlueViolet.Text = "Purple"
        Me.btnBlueViolet.UseVisualStyleBackColor = True
        '
        'btnCyan
        '
        Me.btnCyan.Location = New System.Drawing.Point(13, 73)
        Me.btnCyan.Name = "btnCyan"
        Me.btnCyan.Size = New System.Drawing.Size(151, 23)
        Me.btnCyan.TabIndex = 2
        Me.btnCyan.Text = "Cyan"
        Me.btnCyan.UseVisualStyleBackColor = True
        '
        'btnLimeGreen
        '
        Me.btnLimeGreen.Location = New System.Drawing.Point(13, 103)
        Me.btnLimeGreen.Name = "btnLimeGreen"
        Me.btnLimeGreen.Size = New System.Drawing.Size(151, 23)
        Me.btnLimeGreen.TabIndex = 3
        Me.btnLimeGreen.Text = "Green"
        Me.btnLimeGreen.UseVisualStyleBackColor = True
        '
        'btnCornFlowerBlue
        '
        Me.btnCornFlowerBlue.Location = New System.Drawing.Point(13, 133)
        Me.btnCornFlowerBlue.Name = "btnCornFlowerBlue"
        Me.btnCornFlowerBlue.Size = New System.Drawing.Size(151, 23)
        Me.btnCornFlowerBlue.TabIndex = 4
        Me.btnCornFlowerBlue.Text = "Blue"
        Me.btnCornFlowerBlue.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 167)
        Me.Controls.Add(Me.btnCornFlowerBlue)
        Me.Controls.Add(Me.btnLimeGreen)
        Me.Controls.Add(Me.btnCyan)
        Me.Controls.Add(Me.btnBlueViolet)
        Me.Controls.Add(Me.btnDefault)
        Me.Name = "Form2"
        Me.Text = "Color"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDefault As Button
    Friend WithEvents btnBlueViolet As Button
    Friend WithEvents btnCyan As Button
    Friend WithEvents btnLimeGreen As Button
    Friend WithEvents btnCornFlowerBlue As Button
End Class
