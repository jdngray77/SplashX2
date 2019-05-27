<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crafting
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
        Me.ItemList = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.DisplayItemNext = New System.Windows.Forms.PictureBox()
        Me.Req1 = New System.Windows.Forms.PictureBox()
        Me.DisplayItemCurrent = New System.Windows.Forms.PictureBox()
        Me.txtReq2 = New System.Windows.Forms.Label()
        Me.txtReq1 = New System.Windows.Forms.Label()
        Me.Req2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReq3 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Req3 = New System.Windows.Forms.PictureBox()
        Me.DisplayItemPrev = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DisplayItemNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Req1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayItemCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Req2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Req3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayItemPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemList
        '
        Me.ItemList.FormattingEnabled = True
        Me.ItemList.Location = New System.Drawing.Point(311, 35)
        Me.ItemList.Name = "ItemList"
        Me.ItemList.Size = New System.Drawing.Size(121, 21)
        Me.ItemList.TabIndex = 6
        Me.ItemList.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(131, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(166, 35)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Item Name"
        '
        'DisplayItemNext
        '
        Me.DisplayItemNext.Location = New System.Drawing.Point(33, 179)
        Me.DisplayItemNext.Name = "DisplayItemNext"
        Me.DisplayItemNext.Size = New System.Drawing.Size(60, 60)
        Me.DisplayItemNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DisplayItemNext.TabIndex = 4
        Me.DisplayItemNext.TabStop = False
        '
        'Req1
        '
        Me.Req1.Location = New System.Drawing.Point(137, 101)
        Me.Req1.Name = "Req1"
        Me.Req1.Size = New System.Drawing.Size(32, 32)
        Me.Req1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Req1.TabIndex = 7
        Me.Req1.TabStop = False
        '
        'DisplayItemCurrent
        '
        Me.DisplayItemCurrent.Location = New System.Drawing.Point(12, 85)
        Me.DisplayItemCurrent.Name = "DisplayItemCurrent"
        Me.DisplayItemCurrent.Size = New System.Drawing.Size(100, 88)
        Me.DisplayItemCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DisplayItemCurrent.TabIndex = 2
        Me.DisplayItemCurrent.TabStop = False
        '
        'txtReq2
        '
        Me.txtReq2.AutoSize = True
        Me.txtReq2.Location = New System.Drawing.Point(134, 187)
        Me.txtReq2.Name = "txtReq2"
        Me.txtReq2.Size = New System.Drawing.Size(41, 13)
        Me.txtReq2.TabIndex = 8
        Me.txtReq2.Text = "6X Iron"
        '
        'txtReq1
        '
        Me.txtReq1.AutoSize = True
        Me.txtReq1.Location = New System.Drawing.Point(134, 136)
        Me.txtReq1.Name = "txtReq1"
        Me.txtReq1.Size = New System.Drawing.Size(82, 13)
        Me.txtReq1.TabIndex = 1
        Me.txtReq1.Text = "4X Wood Plank"
        '
        'Req2
        '
        Me.Req2.Location = New System.Drawing.Point(137, 152)
        Me.Req2.Name = "Req2"
        Me.Req2.Size = New System.Drawing.Size(32, 32)
        Me.Req2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Req2.TabIndex = 9
        Me.Req2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Requirements:"
        '
        'txtReq3
        '
        Me.txtReq3.AutoSize = True
        Me.txtReq3.Location = New System.Drawing.Point(134, 238)
        Me.txtReq3.Name = "txtReq3"
        Me.txtReq3.Size = New System.Drawing.Size(51, 13)
        Me.txtReq3.TabIndex = 10
        Me.txtReq3.Text = "2X Stone"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(134, 46)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(35, 13)
        Me.lblDesc.TabIndex = 0
        Me.lblDesc.Text = "Desc."
        '
        'Req3
        '
        Me.Req3.Location = New System.Drawing.Point(137, 203)
        Me.Req3.Name = "Req3"
        Me.Req3.Size = New System.Drawing.Size(32, 32)
        Me.Req3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Req3.TabIndex = 11
        Me.Req3.TabStop = False
        '
        'DisplayItemPrev
        '
        Me.DisplayItemPrev.Location = New System.Drawing.Point(33, 19)
        Me.DisplayItemPrev.Name = "DisplayItemPrev"
        Me.DisplayItemPrev.Size = New System.Drawing.Size(60, 60)
        Me.DisplayItemPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DisplayItemPrev.TabIndex = 3
        Me.DisplayItemPrev.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DisplayItemPrev)
        Me.Panel1.Controls.Add(Me.Req3)
        Me.Panel1.Controls.Add(Me.lblDesc)
        Me.Panel1.Controls.Add(Me.txtReq3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Req2)
        Me.Panel1.Controls.Add(Me.txtReq1)
        Me.Panel1.Controls.Add(Me.txtReq2)
        Me.Panel1.Controls.Add(Me.DisplayItemCurrent)
        Me.Panel1.Controls.Add(Me.Req1)
        Me.Panel1.Controls.Add(Me.DisplayItemNext)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(114, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 268)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "1: Craft 3: Exit"
        '
        'Crafting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(539, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ItemList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crafting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crafting"
        Me.TopMost = True
        CType(Me.DisplayItemNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Req1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayItemCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Req2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Req3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayItemPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemList As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents DisplayItemNext As PictureBox
    Friend WithEvents Req1 As PictureBox
    Friend WithEvents DisplayItemCurrent As PictureBox
    Friend WithEvents txtReq2 As Label
    Friend WithEvents txtReq1 As Label
    Friend WithEvents Req2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReq3 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents Req3 As PictureBox
    Friend WithEvents DisplayItemPrev As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
