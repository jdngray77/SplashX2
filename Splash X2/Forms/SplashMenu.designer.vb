<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashMenu))
        Me.MenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.Sel4 = New System.Windows.Forms.Label()
        Me.Sel3 = New System.Windows.Forms.Label()
        Me.Sel2 = New System.Windows.Forms.Label()
        Me.Sel1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Splashimg = New System.Windows.Forms.PictureBox()
        Me.Sel5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Splashimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTimer
        '
        Me.MenuTimer.Interval = 12000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(216, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Continue"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(216, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Game"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(216, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Options"
        Me.Label3.Visible = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Black
        Me.lbl6.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(216, 234)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(48, 15)
        Me.lbl6.TabIndex = 4
        Me.lbl6.Text = "About"
        Me.lbl6.Visible = False
        '
        'Sel4
        '
        Me.Sel4.AutoSize = True
        Me.Sel4.BackColor = System.Drawing.Color.Black
        Me.Sel4.ForeColor = System.Drawing.Color.Wheat
        Me.Sel4.Location = New System.Drawing.Point(200, 234)
        Me.Sel4.Name = "Sel4"
        Me.Sel4.Size = New System.Drawing.Size(10, 13)
        Me.Sel4.TabIndex = 5
        Me.Sel4.Text = " "
        Me.Sel4.Visible = False
        '
        'Sel3
        '
        Me.Sel3.AutoSize = True
        Me.Sel3.BackColor = System.Drawing.Color.Black
        Me.Sel3.ForeColor = System.Drawing.Color.Wheat
        Me.Sel3.Location = New System.Drawing.Point(200, 221)
        Me.Sel3.Name = "Sel3"
        Me.Sel3.Size = New System.Drawing.Size(10, 13)
        Me.Sel3.TabIndex = 6
        Me.Sel3.Text = " "
        Me.Sel3.Visible = False
        '
        'Sel2
        '
        Me.Sel2.AutoSize = True
        Me.Sel2.BackColor = System.Drawing.Color.Black
        Me.Sel2.ForeColor = System.Drawing.Color.Wheat
        Me.Sel2.Location = New System.Drawing.Point(200, 208)
        Me.Sel2.Name = "Sel2"
        Me.Sel2.Size = New System.Drawing.Size(10, 13)
        Me.Sel2.TabIndex = 7
        Me.Sel2.Text = " "
        Me.Sel2.Visible = False
        '
        'Sel1
        '
        Me.Sel1.AutoSize = True
        Me.Sel1.BackColor = System.Drawing.Color.Black
        Me.Sel1.ForeColor = System.Drawing.Color.Wheat
        Me.Sel1.Location = New System.Drawing.Point(200, 195)
        Me.Sel1.Name = "Sel1"
        Me.Sel1.Size = New System.Drawing.Size(10, 13)
        Me.Sel1.TabIndex = 8
        Me.Sel1.Text = " "
        Me.Sel1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(200, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "1: Select"
        Me.Label5.Visible = False
        '
        'Splashimg
        '
        Me.Splashimg.Image = Global.Splash_X2.My.Resources.Resources.LegalSplash
        Me.Splashimg.Location = New System.Drawing.Point(114, 90)
        Me.Splashimg.Name = "Splashimg"
        Me.Splashimg.Size = New System.Drawing.Size(370, 300)
        Me.Splashimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Splashimg.TabIndex = 0
        Me.Splashimg.TabStop = False
        '
        'Sel5
        '
        Me.Sel5.AutoSize = True
        Me.Sel5.BackColor = System.Drawing.Color.Black
        Me.Sel5.ForeColor = System.Drawing.Color.Wheat
        Me.Sel5.Location = New System.Drawing.Point(200, 247)
        Me.Sel5.Name = "Sel5"
        Me.Sel5.Size = New System.Drawing.Size(10, 13)
        Me.Sel5.TabIndex = 11
        Me.Sel5.Text = " "
        Me.Sel5.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("MicrogrammaDMedExt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(216, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Exit"
        Me.Label7.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(266, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 39)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "==========" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "| Click Here |" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "=========="
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(114, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(370, 300)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'SplashMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(593, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Sel5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Sel1)
        Me.Controls.Add(Me.Sel2)
        Me.Controls.Add(Me.Sel3)
        Me.Controls.Add(Me.Sel4)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Splashimg)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashMenu"
        Me.TopMost = True
        CType(Me.Splashimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splashimg As PictureBox
    Friend WithEvents MenuTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents Sel4 As Label
    Friend WithEvents Sel3 As Label
    Friend WithEvents Sel2 As Label
    Friend WithEvents Sel1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Sel5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
