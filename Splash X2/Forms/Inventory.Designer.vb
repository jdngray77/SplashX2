<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicSlot1 = New System.Windows.Forms.PictureBox()
        Me.PicSlot2 = New System.Windows.Forms.PictureBox()
        Me.PicSlot3 = New System.Windows.Forms.PictureBox()
        Me.lblSlot1 = New System.Windows.Forms.Label()
        Me.lblSlot2 = New System.Windows.Forms.Label()
        Me.lblSlot3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PicSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSlot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("MicrogrammaDMedExt", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(254, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory"
        '
        'PicSlot1
        '
        Me.PicSlot1.BackColor = System.Drawing.Color.Black
        Me.PicSlot1.Image = CType(resources.GetObject("PicSlot1.Image"), System.Drawing.Image)
        Me.PicSlot1.Location = New System.Drawing.Point(157, 179)
        Me.PicSlot1.Name = "PicSlot1"
        Me.PicSlot1.Size = New System.Drawing.Size(64, 64)
        Me.PicSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSlot1.TabIndex = 2
        Me.PicSlot1.TabStop = False
        '
        'PicSlot2
        '
        Me.PicSlot2.BackColor = System.Drawing.Color.Black
        Me.PicSlot2.Image = CType(resources.GetObject("PicSlot2.Image"), System.Drawing.Image)
        Me.PicSlot2.Location = New System.Drawing.Point(286, 179)
        Me.PicSlot2.Name = "PicSlot2"
        Me.PicSlot2.Size = New System.Drawing.Size(64, 64)
        Me.PicSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSlot2.TabIndex = 3
        Me.PicSlot2.TabStop = False
        '
        'PicSlot3
        '
        Me.PicSlot3.BackColor = System.Drawing.Color.Black
        Me.PicSlot3.Image = CType(resources.GetObject("PicSlot3.Image"), System.Drawing.Image)
        Me.PicSlot3.Location = New System.Drawing.Point(409, 179)
        Me.PicSlot3.Name = "PicSlot3"
        Me.PicSlot3.Size = New System.Drawing.Size(64, 64)
        Me.PicSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicSlot3.TabIndex = 4
        Me.PicSlot3.TabStop = False
        '
        'lblSlot1
        '
        Me.lblSlot1.AutoSize = True
        Me.lblSlot1.BackColor = System.Drawing.Color.Black
        Me.lblSlot1.ForeColor = System.Drawing.Color.White
        Me.lblSlot1.Location = New System.Drawing.Point(154, 246)
        Me.lblSlot1.Name = "lblSlot1"
        Me.lblSlot1.Size = New System.Drawing.Size(36, 13)
        Me.lblSlot1.TabIndex = 5
        Me.lblSlot1.Text = "Empty"
        '
        'lblSlot2
        '
        Me.lblSlot2.AutoSize = True
        Me.lblSlot2.BackColor = System.Drawing.Color.Black
        Me.lblSlot2.ForeColor = System.Drawing.Color.White
        Me.lblSlot2.Location = New System.Drawing.Point(283, 246)
        Me.lblSlot2.Name = "lblSlot2"
        Me.lblSlot2.Size = New System.Drawing.Size(36, 13)
        Me.lblSlot2.TabIndex = 6
        Me.lblSlot2.Text = "Empty"
        '
        'lblSlot3
        '
        Me.lblSlot3.AutoSize = True
        Me.lblSlot3.BackColor = System.Drawing.Color.Black
        Me.lblSlot3.ForeColor = System.Drawing.Color.White
        Me.lblSlot3.Location = New System.Drawing.Point(406, 246)
        Me.lblSlot3.Name = "lblSlot3"
        Me.lblSlot3.Size = New System.Drawing.Size(36, 13)
        Me.lblSlot3.TabIndex = 7
        Me.lblSlot3.Text = "Empty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(265, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "4 / E: Close    5: Crafting"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Splash_X2.My.Resources.Resources.nullBlack
        Me.PictureBox1.Location = New System.Drawing.Point(109, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(417, 240)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(633, 459)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSlot3)
        Me.Controls.Add(Me.lblSlot2)
        Me.Controls.Add(Me.lblSlot1)
        Me.Controls.Add(Me.PicSlot3)
        Me.Controls.Add(Me.PicSlot2)
        Me.Controls.Add(Me.PicSlot1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.TopMost = True
        CType(Me.PicSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSlot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PicSlot1 As PictureBox
    Friend WithEvents PicSlot2 As PictureBox
    Friend WithEvents PicSlot3 As PictureBox
    Friend WithEvents lblSlot1 As Label
    Friend WithEvents lblSlot2 As Label
    Friend WithEvents lblSlot3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
