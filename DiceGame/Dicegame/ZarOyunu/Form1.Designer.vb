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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Zar1PBox = New System.Windows.Forms.PictureBox()
        Me.Zar2PBox = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ZarAtmaLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ZarlarList = New System.Windows.Forms.ImageList(Me.components)
        Me.OynaBtn = New System.Windows.Forms.Button()
        CType(Me.Zar1PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zar2PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Zar1PBox
        '
        Me.Zar1PBox.InitialImage = Global.ZarOyunu.My.Resources.Resources.zar1
        Me.Zar1PBox.Location = New System.Drawing.Point(42, 16)
        Me.Zar1PBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Zar1PBox.Name = "Zar1PBox"
        Me.Zar1PBox.Size = New System.Drawing.Size(86, 100)
        Me.Zar1PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Zar1PBox.TabIndex = 0
        Me.Zar1PBox.TabStop = False
        '
        'Zar2PBox
        '
        Me.Zar2PBox.Location = New System.Drawing.Point(200, 16)
        Me.Zar2PBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Zar2PBox.Name = "Zar2PBox"
        Me.Zar2PBox.Size = New System.Drawing.Size(86, 100)
        Me.Zar2PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Zar2PBox.TabIndex = 1
        Me.Zar2PBox.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ZarAtmaLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 205)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(336, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 20)
        Me.ToolStripStatusLabel1.Text = "Zar Atma Sayısı: "
        '
        'ZarAtmaLbl
        '
        Me.ZarAtmaLbl.Name = "ZarAtmaLbl"
        Me.ZarAtmaLbl.Size = New System.Drawing.Size(17, 20)
        Me.ZarAtmaLbl.Text = "0"
        '
        'ZarlarList
        '
        Me.ZarlarList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ZarlarList.ImageStream = CType(resources.GetObject("ZarlarList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ZarlarList.TransparentColor = System.Drawing.Color.Transparent
        Me.ZarlarList.Images.SetKeyName(0, "1.png")
        Me.ZarlarList.Images.SetKeyName(1, "2.png")
        Me.ZarlarList.Images.SetKeyName(2, "3.png")
        Me.ZarlarList.Images.SetKeyName(3, "4.png")
        Me.ZarlarList.Images.SetKeyName(4, "5.png")
        Me.ZarlarList.Images.SetKeyName(5, "6.png")
        '
        'OynaBtn
        '
        Me.OynaBtn.Image = CType(resources.GetObject("OynaBtn.Image"), System.Drawing.Image)
        Me.OynaBtn.Location = New System.Drawing.Point(42, 123)
        Me.OynaBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OynaBtn.Name = "OynaBtn"
        Me.OynaBtn.Size = New System.Drawing.Size(243, 68)
        Me.OynaBtn.TabIndex = 3
        Me.OynaBtn.Text = "Oyna"
        Me.OynaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.OynaBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 231)
        Me.Controls.Add(Me.OynaBtn)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Zar2PBox)
        Me.Controls.Add(Me.Zar1PBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Zar Oyunu"
        CType(Me.Zar1PBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zar2PBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Zar1PBox As PictureBox
    Friend WithEvents Zar2PBox As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ZarAtmaLbl As ToolStripStatusLabel
    Friend WithEvents ZarlarList As ImageList
    Friend WithEvents OynaBtn As Button
End Class
