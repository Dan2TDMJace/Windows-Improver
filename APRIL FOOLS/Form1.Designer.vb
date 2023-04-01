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
        Me.f = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f.Location = New System.Drawing.Point(39, 87)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(714, 20)
        Me.f.TabIndex = 1
        Me.f.Text = "Improve Windows with the click of a button. Speed up your PC, clean up clutter, a" &
    "nd decrease errors."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(91, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(611, 242)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Improve Windows"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.f)
        Me.Name = "Form1"
        Me.Text = "Windows Improver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents f As Label
    Friend WithEvents Button1 As Button
End Class
