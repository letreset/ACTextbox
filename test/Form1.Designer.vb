<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.acomp = New ACompTextBox.ACompTextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "getval"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 20)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "setval"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 70)
        Me.Label1.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(150, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 20)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "disable"
        '
        'acomp
        '
        Me.acomp.Location = New System.Drawing.Point(21, 21)
        Me.acomp.Name = "acomp"
        Me.acomp.Size = New System.Drawing.Size(201, 23)
        Me.acomp.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(150, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 20)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "enable"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.acomp)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents acomp As ACompTextBox.ACompTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
