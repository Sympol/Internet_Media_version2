<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(1, 300)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Visible = False
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(177, 163)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(75, 22)
        Me.Button30.TabIndex = 30
        Me.Button30.Text = "Albayane"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(96, 163)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 22)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "Radio Espoir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(15, 163)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 22)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Radio JAM"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(177, 137)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 22)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Nostalgie CI"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(96, 137)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 22)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Frequence 2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 22)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Radio CI"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(120, 191)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(39, 23)
        Me.Button8.TabIndex = 41
        Me.Button8.Text = "Stop"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 361)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
