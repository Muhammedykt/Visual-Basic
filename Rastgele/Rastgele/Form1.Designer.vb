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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OndalikTBox = New System.Windows.Forms.TextBox()
        Me.TamTBox = New System.Windows.Forms.TextBox()
        Me.AralikTBox = New System.Windows.Forms.TextBox()
        Me.RastgeleBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Random float number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Random integer number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Integer in random range:"
        '
        'OndalikTBox
        '
        Me.OndalikTBox.Location = New System.Drawing.Point(244, 12)
        Me.OndalikTBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OndalikTBox.Name = "OndalikTBox"
        Me.OndalikTBox.Size = New System.Drawing.Size(114, 27)
        Me.OndalikTBox.TabIndex = 3
        '
        'TamTBox
        '
        Me.TamTBox.Location = New System.Drawing.Point(244, 50)
        Me.TamTBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TamTBox.Name = "TamTBox"
        Me.TamTBox.Size = New System.Drawing.Size(114, 27)
        Me.TamTBox.TabIndex = 4
        '
        'AralikTBox
        '
        Me.AralikTBox.Location = New System.Drawing.Point(244, 89)
        Me.AralikTBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AralikTBox.Name = "AralikTBox"
        Me.AralikTBox.Size = New System.Drawing.Size(114, 27)
        Me.AralikTBox.TabIndex = 5
        '
        'RastgeleBtn
        '
        Me.RastgeleBtn.Location = New System.Drawing.Point(27, 148)
        Me.RastgeleBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RastgeleBtn.Name = "RastgeleBtn"
        Me.RastgeleBtn.Size = New System.Drawing.Size(281, 60)
        Me.RastgeleBtn.TabIndex = 6
        Me.RastgeleBtn.Text = "Generate random number"
        Me.RastgeleBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 316)
        Me.Controls.Add(Me.RastgeleBtn)
        Me.Controls.Add(Me.AralikTBox)
        Me.Controls.Add(Me.TamTBox)
        Me.Controls.Add(Me.OndalikTBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OndalikTBox As TextBox
    Friend WithEvents TamTBox As TextBox
    Friend WithEvents AralikTBox As TextBox
    Friend WithEvents RastgeleBtn As Button
End Class
