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
        Me.components = New System.ComponentModel.Container()
        Me.SaatLbl = New System.Windows.Forms.Label()
        Me.SureTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SaatLbl
        '
        Me.SaatLbl.BackColor = System.Drawing.Color.Black
        Me.SaatLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaatLbl.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaatLbl.ForeColor = System.Drawing.Color.GreenYellow
        Me.SaatLbl.Location = New System.Drawing.Point(0, 0)
        Me.SaatLbl.Name = "SaatLbl"
        Me.SaatLbl.Size = New System.Drawing.Size(410, 149)
        Me.SaatLbl.TabIndex = 0
        Me.SaatLbl.Text = "00:00:00"
        Me.SaatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 149)
        Me.Controls.Add(Me.SaatLbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaatLbl As Label
    Friend WithEvents SureTimer As Timer
End Class
