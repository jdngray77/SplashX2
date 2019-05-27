<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InitialiseMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplashMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapEditorModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapDesignerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavingExperimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCursor3 = New System.Windows.Forms.Label()
        Me.lblCursor2 = New System.Windows.Forms.Label()
        Me.lblCursor1 = New System.Windows.Forms.Label()
        Me.lblCursorTitle = New System.Windows.Forms.Label()
        Me.InfoBox = New System.Windows.Forms.GroupBox()
        Me.DisplayKey = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisplayPos = New System.Windows.Forms.Label()
        Me.PicCursor = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DisplayID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DisplayArea = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DisplayLevel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DisplayHealth = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bgplayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.EditorBreak = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Displaymsg3 = New System.Windows.Forms.Label()
        Me.Displaymsg2 = New System.Windows.Forms.Label()
        Me.Displaymsg1 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox56 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.InvDisplay3 = New System.Windows.Forms.PictureBox()
        Me.InvDisplay2 = New System.Windows.Forms.PictureBox()
        Me.InvDisplay1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.X1Y1 = New System.Windows.Forms.PictureBox()
        Me.X1Y2 = New System.Windows.Forms.PictureBox()
        Me.X1Y3 = New System.Windows.Forms.PictureBox()
        Me.X1Y4 = New System.Windows.Forms.PictureBox()
        Me.X1Y5 = New System.Windows.Forms.PictureBox()
        Me.X1Y6 = New System.Windows.Forms.PictureBox()
        Me.X1Y7 = New System.Windows.Forms.PictureBox()
        Me.X1Y8 = New System.Windows.Forms.PictureBox()
        Me.X1Y9 = New System.Windows.Forms.PictureBox()
        Me.X1Y10 = New System.Windows.Forms.PictureBox()
        Me.X2Y1 = New System.Windows.Forms.PictureBox()
        Me.X2Y2 = New System.Windows.Forms.PictureBox()
        Me.X2Y8 = New System.Windows.Forms.PictureBox()
        Me.X2Y3 = New System.Windows.Forms.PictureBox()
        Me.X2Y4 = New System.Windows.Forms.PictureBox()
        Me.X2Y5 = New System.Windows.Forms.PictureBox()
        Me.X2Y6 = New System.Windows.Forms.PictureBox()
        Me.X2Y7 = New System.Windows.Forms.PictureBox()
        Me.X2Y9 = New System.Windows.Forms.PictureBox()
        Me.X2Y10 = New System.Windows.Forms.PictureBox()
        Me.X3Y6 = New System.Windows.Forms.PictureBox()
        Me.X3Y1 = New System.Windows.Forms.PictureBox()
        Me.X3Y2 = New System.Windows.Forms.PictureBox()
        Me.X3Y3 = New System.Windows.Forms.PictureBox()
        Me.X3Y4 = New System.Windows.Forms.PictureBox()
        Me.X3Y5 = New System.Windows.Forms.PictureBox()
        Me.X3Y7 = New System.Windows.Forms.PictureBox()
        Me.X3Y8 = New System.Windows.Forms.PictureBox()
        Me.X3Y9 = New System.Windows.Forms.PictureBox()
        Me.X3Y10 = New System.Windows.Forms.PictureBox()
        Me.X4Y1 = New System.Windows.Forms.PictureBox()
        Me.X4Y2 = New System.Windows.Forms.PictureBox()
        Me.X4Y3 = New System.Windows.Forms.PictureBox()
        Me.X4Y4 = New System.Windows.Forms.PictureBox()
        Me.X4Y5 = New System.Windows.Forms.PictureBox()
        Me.X4Y6 = New System.Windows.Forms.PictureBox()
        Me.X4Y7 = New System.Windows.Forms.PictureBox()
        Me.X4Y8 = New System.Windows.Forms.PictureBox()
        Me.X4Y9 = New System.Windows.Forms.PictureBox()
        Me.X4Y10 = New System.Windows.Forms.PictureBox()
        Me.X5Y6 = New System.Windows.Forms.PictureBox()
        Me.X5Y1 = New System.Windows.Forms.PictureBox()
        Me.X5Y2 = New System.Windows.Forms.PictureBox()
        Me.X5Y3 = New System.Windows.Forms.PictureBox()
        Me.X5Y4 = New System.Windows.Forms.PictureBox()
        Me.X5Y5 = New System.Windows.Forms.PictureBox()
        Me.X5Y7 = New System.Windows.Forms.PictureBox()
        Me.X5Y8 = New System.Windows.Forms.PictureBox()
        Me.X5Y9 = New System.Windows.Forms.PictureBox()
        Me.X5Y10 = New System.Windows.Forms.PictureBox()
        Me.X6Y6 = New System.Windows.Forms.PictureBox()
        Me.X6Y1 = New System.Windows.Forms.PictureBox()
        Me.X6Y2 = New System.Windows.Forms.PictureBox()
        Me.X6Y3 = New System.Windows.Forms.PictureBox()
        Me.X6Y4 = New System.Windows.Forms.PictureBox()
        Me.X6Y5 = New System.Windows.Forms.PictureBox()
        Me.X6Y7 = New System.Windows.Forms.PictureBox()
        Me.X6Y8 = New System.Windows.Forms.PictureBox()
        Me.X6Y9 = New System.Windows.Forms.PictureBox()
        Me.X6Y10 = New System.Windows.Forms.PictureBox()
        Me.X7Y6 = New System.Windows.Forms.PictureBox()
        Me.X7Y1 = New System.Windows.Forms.PictureBox()
        Me.X7Y2 = New System.Windows.Forms.PictureBox()
        Me.X7Y3 = New System.Windows.Forms.PictureBox()
        Me.X7Y4 = New System.Windows.Forms.PictureBox()
        Me.X7Y5 = New System.Windows.Forms.PictureBox()
        Me.X7Y7 = New System.Windows.Forms.PictureBox()
        Me.X7Y8 = New System.Windows.Forms.PictureBox()
        Me.X7Y9 = New System.Windows.Forms.PictureBox()
        Me.X7Y10 = New System.Windows.Forms.PictureBox()
        Me.X8Y6 = New System.Windows.Forms.PictureBox()
        Me.X8Y1 = New System.Windows.Forms.PictureBox()
        Me.X8Y2 = New System.Windows.Forms.PictureBox()
        Me.X8Y3 = New System.Windows.Forms.PictureBox()
        Me.X8Y4 = New System.Windows.Forms.PictureBox()
        Me.X8Y5 = New System.Windows.Forms.PictureBox()
        Me.X8Y7 = New System.Windows.Forms.PictureBox()
        Me.X8Y8 = New System.Windows.Forms.PictureBox()
        Me.X8Y9 = New System.Windows.Forms.PictureBox()
        Me.X8Y10 = New System.Windows.Forms.PictureBox()
        Me.X9Y6 = New System.Windows.Forms.PictureBox()
        Me.X9Y1 = New System.Windows.Forms.PictureBox()
        Me.X9Y2 = New System.Windows.Forms.PictureBox()
        Me.X9Y3 = New System.Windows.Forms.PictureBox()
        Me.X9Y4 = New System.Windows.Forms.PictureBox()
        Me.X9Y5 = New System.Windows.Forms.PictureBox()
        Me.X9Y7 = New System.Windows.Forms.PictureBox()
        Me.X9Y8 = New System.Windows.Forms.PictureBox()
        Me.X9Y9 = New System.Windows.Forms.PictureBox()
        Me.X9Y10 = New System.Windows.Forms.PictureBox()
        Me.X10Y6 = New System.Windows.Forms.PictureBox()
        Me.X10Y1 = New System.Windows.Forms.PictureBox()
        Me.X10Y2 = New System.Windows.Forms.PictureBox()
        Me.X10Y3 = New System.Windows.Forms.PictureBox()
        Me.X10Y4 = New System.Windows.Forms.PictureBox()
        Me.X10Y5 = New System.Windows.Forms.PictureBox()
        Me.X10Y7 = New System.Windows.Forms.PictureBox()
        Me.X10Y8 = New System.Windows.Forms.PictureBox()
        Me.X10Y9 = New System.Windows.Forms.PictureBox()
        Me.X10Y10 = New System.Windows.Forms.PictureBox()
        Me.X1Y11 = New System.Windows.Forms.PictureBox()
        Me.X1Y12 = New System.Windows.Forms.PictureBox()
        Me.X1Y13 = New System.Windows.Forms.PictureBox()
        Me.X1Y14 = New System.Windows.Forms.PictureBox()
        Me.X1Y15 = New System.Windows.Forms.PictureBox()
        Me.X1Y16 = New System.Windows.Forms.PictureBox()
        Me.X1Y17 = New System.Windows.Forms.PictureBox()
        Me.X1Y18 = New System.Windows.Forms.PictureBox()
        Me.X1Y19 = New System.Windows.Forms.PictureBox()
        Me.X1Y20 = New System.Windows.Forms.PictureBox()
        Me.X2Y11 = New System.Windows.Forms.PictureBox()
        Me.X2Y12 = New System.Windows.Forms.PictureBox()
        Me.X2Y18 = New System.Windows.Forms.PictureBox()
        Me.X2Y13 = New System.Windows.Forms.PictureBox()
        Me.X2Y14 = New System.Windows.Forms.PictureBox()
        Me.X2Y15 = New System.Windows.Forms.PictureBox()
        Me.X2Y16 = New System.Windows.Forms.PictureBox()
        Me.X2Y17 = New System.Windows.Forms.PictureBox()
        Me.X2Y19 = New System.Windows.Forms.PictureBox()
        Me.X2Y20 = New System.Windows.Forms.PictureBox()
        Me.X3Y16 = New System.Windows.Forms.PictureBox()
        Me.X3Y11 = New System.Windows.Forms.PictureBox()
        Me.X3Y12 = New System.Windows.Forms.PictureBox()
        Me.X3Y13 = New System.Windows.Forms.PictureBox()
        Me.X3Y14 = New System.Windows.Forms.PictureBox()
        Me.X3Y15 = New System.Windows.Forms.PictureBox()
        Me.X3Y17 = New System.Windows.Forms.PictureBox()
        Me.X3Y18 = New System.Windows.Forms.PictureBox()
        Me.X3Y19 = New System.Windows.Forms.PictureBox()
        Me.X3Y20 = New System.Windows.Forms.PictureBox()
        Me.X4Y11 = New System.Windows.Forms.PictureBox()
        Me.X4Y12 = New System.Windows.Forms.PictureBox()
        Me.X4Y13 = New System.Windows.Forms.PictureBox()
        Me.X4Y14 = New System.Windows.Forms.PictureBox()
        Me.X4Y15 = New System.Windows.Forms.PictureBox()
        Me.X4Y16 = New System.Windows.Forms.PictureBox()
        Me.X4Y17 = New System.Windows.Forms.PictureBox()
        Me.X4Y18 = New System.Windows.Forms.PictureBox()
        Me.X4Y19 = New System.Windows.Forms.PictureBox()
        Me.X4Y20 = New System.Windows.Forms.PictureBox()
        Me.X5Y16 = New System.Windows.Forms.PictureBox()
        Me.X5Y11 = New System.Windows.Forms.PictureBox()
        Me.X5Y12 = New System.Windows.Forms.PictureBox()
        Me.X5Y13 = New System.Windows.Forms.PictureBox()
        Me.X5Y14 = New System.Windows.Forms.PictureBox()
        Me.X5Y15 = New System.Windows.Forms.PictureBox()
        Me.X5Y17 = New System.Windows.Forms.PictureBox()
        Me.X5Y18 = New System.Windows.Forms.PictureBox()
        Me.X5Y19 = New System.Windows.Forms.PictureBox()
        Me.X5Y20 = New System.Windows.Forms.PictureBox()
        Me.X6Y16 = New System.Windows.Forms.PictureBox()
        Me.X6Y11 = New System.Windows.Forms.PictureBox()
        Me.X6Y12 = New System.Windows.Forms.PictureBox()
        Me.X6Y13 = New System.Windows.Forms.PictureBox()
        Me.X6Y14 = New System.Windows.Forms.PictureBox()
        Me.X6Y15 = New System.Windows.Forms.PictureBox()
        Me.X6Y17 = New System.Windows.Forms.PictureBox()
        Me.X6Y18 = New System.Windows.Forms.PictureBox()
        Me.X6Y19 = New System.Windows.Forms.PictureBox()
        Me.X6Y20 = New System.Windows.Forms.PictureBox()
        Me.X7Y16 = New System.Windows.Forms.PictureBox()
        Me.X7Y11 = New System.Windows.Forms.PictureBox()
        Me.X7Y12 = New System.Windows.Forms.PictureBox()
        Me.X7Y13 = New System.Windows.Forms.PictureBox()
        Me.X7Y14 = New System.Windows.Forms.PictureBox()
        Me.X7Y15 = New System.Windows.Forms.PictureBox()
        Me.X7Y17 = New System.Windows.Forms.PictureBox()
        Me.X7Y18 = New System.Windows.Forms.PictureBox()
        Me.X7Y19 = New System.Windows.Forms.PictureBox()
        Me.X7Y20 = New System.Windows.Forms.PictureBox()
        Me.X8Y16 = New System.Windows.Forms.PictureBox()
        Me.X8Y11 = New System.Windows.Forms.PictureBox()
        Me.X8Y12 = New System.Windows.Forms.PictureBox()
        Me.X8Y13 = New System.Windows.Forms.PictureBox()
        Me.X8Y14 = New System.Windows.Forms.PictureBox()
        Me.X8Y15 = New System.Windows.Forms.PictureBox()
        Me.X8Y17 = New System.Windows.Forms.PictureBox()
        Me.X8Y18 = New System.Windows.Forms.PictureBox()
        Me.X8Y19 = New System.Windows.Forms.PictureBox()
        Me.X8Y20 = New System.Windows.Forms.PictureBox()
        Me.X9Y16 = New System.Windows.Forms.PictureBox()
        Me.X9Y11 = New System.Windows.Forms.PictureBox()
        Me.X9Y12 = New System.Windows.Forms.PictureBox()
        Me.X9Y13 = New System.Windows.Forms.PictureBox()
        Me.X9Y14 = New System.Windows.Forms.PictureBox()
        Me.X9Y15 = New System.Windows.Forms.PictureBox()
        Me.X9Y17 = New System.Windows.Forms.PictureBox()
        Me.X9Y18 = New System.Windows.Forms.PictureBox()
        Me.X9Y19 = New System.Windows.Forms.PictureBox()
        Me.X9Y20 = New System.Windows.Forms.PictureBox()
        Me.X10Y16 = New System.Windows.Forms.PictureBox()
        Me.X10Y11 = New System.Windows.Forms.PictureBox()
        Me.X10Y12 = New System.Windows.Forms.PictureBox()
        Me.X10Y13 = New System.Windows.Forms.PictureBox()
        Me.X10Y14 = New System.Windows.Forms.PictureBox()
        Me.X10Y15 = New System.Windows.Forms.PictureBox()
        Me.X10Y17 = New System.Windows.Forms.PictureBox()
        Me.X10Y18 = New System.Windows.Forms.PictureBox()
        Me.X10Y19 = New System.Windows.Forms.PictureBox()
        Me.X10Y20 = New System.Windows.Forms.PictureBox()
        Me.LineList = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.InfoBox.SuspendLayout()
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bgplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.InvDisplay3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvDisplay2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvDisplay1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X1Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X2Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X3Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X4Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X5Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X6Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X7Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X8Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X9Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X10Y20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1122, 24)
        Me.MenuStrip1.TabIndex = 245
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InitialiseMapToolStripMenuItem, Me.SavingExperimentToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.SaveGameToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'InitialiseMapToolStripMenuItem
        '
        Me.InitialiseMapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SplashMapToolStripMenuItem, Me.MapEditorModeToolStripMenuItem, Me.MapDesignerToolStripMenuItem})
        Me.InitialiseMapToolStripMenuItem.Name = "InitialiseMapToolStripMenuItem"
        Me.InitialiseMapToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.InitialiseMapToolStripMenuItem.Text = "Initialise Map"
        '
        'SplashMapToolStripMenuItem
        '
        Me.SplashMapToolStripMenuItem.Name = "SplashMapToolStripMenuItem"
        Me.SplashMapToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SplashMapToolStripMenuItem.Text = "SplashMap"
        '
        'MapEditorModeToolStripMenuItem
        '
        Me.MapEditorModeToolStripMenuItem.Name = "MapEditorModeToolStripMenuItem"
        Me.MapEditorModeToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MapEditorModeToolStripMenuItem.Text = "Map file editor mode"
        '
        'MapDesignerToolStripMenuItem
        '
        Me.MapDesignerToolStripMenuItem.Name = "MapDesignerToolStripMenuItem"
        Me.MapDesignerToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MapDesignerToolStripMenuItem.Text = "Map Designer"
        '
        'SavingExperimentToolStripMenuItem
        '
        Me.SavingExperimentToolStripMenuItem.Name = "SavingExperimentToolStripMenuItem"
        Me.SavingExperimentToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SavingExperimentToolStripMenuItem.Text = "View Save Data"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'SaveGameToolStripMenuItem
        '
        Me.SaveGameToolStripMenuItem.Name = "SaveGameToolStripMenuItem"
        Me.SaveGameToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SaveGameToolStripMenuItem.Text = "Save Game"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.lblCursor3)
        Me.GroupBox2.Controls.Add(Me.lblCursor2)
        Me.GroupBox2.Controls.Add(Me.lblCursor1)
        Me.GroupBox2.Controls.Add(Me.lblCursorTitle)
        Me.GroupBox2.Controls.Add(Me.InfoBox)
        Me.GroupBox2.Controls.Add(Me.PicCursor)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(757, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 73)
        Me.GroupBox2.TabIndex = 166
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cursor"
        '
        'lblCursor3
        '
        Me.lblCursor3.AutoSize = True
        Me.lblCursor3.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursor3.Location = New System.Drawing.Point(57, 56)
        Me.lblCursor3.Name = "lblCursor3"
        Me.lblCursor3.Size = New System.Drawing.Size(10, 13)
        Me.lblCursor3.TabIndex = 141
        Me.lblCursor3.Text = " "
        '
        'lblCursor2
        '
        Me.lblCursor2.AutoSize = True
        Me.lblCursor2.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursor2.Location = New System.Drawing.Point(57, 43)
        Me.lblCursor2.Name = "lblCursor2"
        Me.lblCursor2.Size = New System.Drawing.Size(10, 13)
        Me.lblCursor2.TabIndex = 140
        Me.lblCursor2.Text = " "
        '
        'lblCursor1
        '
        Me.lblCursor1.AutoSize = True
        Me.lblCursor1.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursor1.Location = New System.Drawing.Point(57, 30)
        Me.lblCursor1.Name = "lblCursor1"
        Me.lblCursor1.Size = New System.Drawing.Size(10, 13)
        Me.lblCursor1.TabIndex = 139
        Me.lblCursor1.Text = " "
        '
        'lblCursorTitle
        '
        Me.lblCursorTitle.AutoSize = True
        Me.lblCursorTitle.Font = New System.Drawing.Font("MicrogrammaDEEBolExt", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCursorTitle.Location = New System.Drawing.Point(56, 12)
        Me.lblCursorTitle.Name = "lblCursorTitle"
        Me.lblCursorTitle.Size = New System.Drawing.Size(10, 15)
        Me.lblCursorTitle.TabIndex = 138
        Me.lblCursorTitle.Text = " "
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.Color.Black
        Me.InfoBox.Controls.Add(Me.DisplayKey)
        Me.InfoBox.Controls.Add(Me.Label2)
        Me.InfoBox.Controls.Add(Me.Label1)
        Me.InfoBox.Controls.Add(Me.DisplayPos)
        Me.InfoBox.ForeColor = System.Drawing.Color.White
        Me.InfoBox.Location = New System.Drawing.Point(134, 2)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(128, 71)
        Me.InfoBox.TabIndex = 161
        Me.InfoBox.TabStop = False
        Me.InfoBox.Text = "Information"
        Me.InfoBox.Visible = False
        '
        'DisplayKey
        '
        Me.DisplayKey.AutoSize = True
        Me.DisplayKey.Location = New System.Drawing.Point(84, 33)
        Me.DisplayKey.Name = "DisplayKey"
        Me.DisplayKey.Size = New System.Drawing.Size(14, 13)
        Me.DisplayKey.TabIndex = 3
        Me.DisplayKey.Text = "S"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Keystroke:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Co-ordinates:"
        '
        'DisplayPos
        '
        Me.DisplayPos.AutoSize = True
        Me.DisplayPos.Location = New System.Drawing.Point(85, 16)
        Me.DisplayPos.Name = "DisplayPos"
        Me.DisplayPos.Size = New System.Drawing.Size(33, 13)
        Me.DisplayPos.TabIndex = 0
        Me.DisplayPos.Text = "X1Y1"
        '
        'PicCursor
        '
        Me.PicCursor.Location = New System.Drawing.Point(1, 19)
        Me.PicCursor.Name = "PicCursor"
        Me.PicCursor.Size = New System.Drawing.Size(55, 48)
        Me.PicCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCursor.TabIndex = 138
        Me.PicCursor.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.DisplayID)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DisplayArea)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DisplayLevel)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(890, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 71)
        Me.GroupBox3.TabIndex = 162
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "World"
        '
        'DisplayID
        '
        Me.DisplayID.AutoSize = True
        Me.DisplayID.Location = New System.Drawing.Point(86, 50)
        Me.DisplayID.Name = "DisplayID"
        Me.DisplayID.Size = New System.Drawing.Size(39, 13)
        Me.DisplayID.TabIndex = 5
        Me.DisplayID.Text = "Splash"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Section #:"
        '
        'DisplayArea
        '
        Me.DisplayArea.AutoSize = True
        Me.DisplayArea.Location = New System.Drawing.Point(86, 33)
        Me.DisplayArea.Name = "DisplayArea"
        Me.DisplayArea.Size = New System.Drawing.Size(39, 13)
        Me.DisplayArea.TabIndex = 3
        Me.DisplayArea.Text = "Splash"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Area:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Level:"
        '
        'DisplayLevel
        '
        Me.DisplayLevel.AutoSize = True
        Me.DisplayLevel.Location = New System.Drawing.Point(87, 16)
        Me.DisplayLevel.Name = "DisplayLevel"
        Me.DisplayLevel.Size = New System.Drawing.Size(13, 13)
        Me.DisplayLevel.TabIndex = 0
        Me.DisplayLevel.Text = "1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DisplayHealth)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(757, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 71)
        Me.GroupBox1.TabIndex = 164
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "None"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Transport"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Health"
        '
        'DisplayHealth
        '
        Me.DisplayHealth.AutoSize = True
        Me.DisplayHealth.Location = New System.Drawing.Point(60, 16)
        Me.DisplayHealth.Name = "DisplayHealth"
        Me.DisplayHealth.Size = New System.Drawing.Size(42, 13)
        Me.DisplayHealth.TabIndex = 0
        Me.DisplayHealth.Text = "10 / 10"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Black
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(113, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(903, 21)
        Me.GroupBox4.TabIndex = 147
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Splash X2 - Alpha 4 - Unlicensed development edition"
        '
        'bgplayer
        '
        Me.bgplayer.Enabled = True
        Me.bgplayer.Location = New System.Drawing.Point(1130, 403)
        Me.bgplayer.Name = "bgplayer"
        Me.bgplayer.OcxState = CType(resources.GetObject("bgplayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.bgplayer.Size = New System.Drawing.Size(45, 23)
        Me.bgplayer.TabIndex = 0
        Me.bgplayer.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Black
        Me.GroupBox5.Controls.Add(Me.EditorBreak)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Displaymsg3)
        Me.GroupBox5.Controls.Add(Me.Displaymsg2)
        Me.GroupBox5.Controls.Add(Me.Displaymsg1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(756, 124)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(260, 71)
        Me.GroupBox5.TabIndex = 162
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Messages"
        '
        'EditorBreak
        '
        Me.EditorBreak.BackColor = System.Drawing.Color.Black
        Me.EditorBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditorBreak.Location = New System.Drawing.Point(173, 13)
        Me.EditorBreak.Name = "EditorBreak"
        Me.EditorBreak.Size = New System.Drawing.Size(81, 49)
        Me.EditorBreak.TabIndex = 167
        Me.EditorBreak.Text = "Break for change"
        Me.EditorBreak.UseVisualStyleBackColor = False
        Me.EditorBreak.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Black
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(469, 359)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(127, 71)
        Me.GroupBox6.TabIndex = 166
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Messages"
        '
        'Displaymsg3
        '
        Me.Displaymsg3.AutoSize = True
        Me.Displaymsg3.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Displaymsg3.Location = New System.Drawing.Point(6, 49)
        Me.Displaymsg3.Name = "Displaymsg3"
        Me.Displaymsg3.Size = New System.Drawing.Size(39, 13)
        Me.Displaymsg3.TabIndex = 165
        Me.Displaymsg3.Text = "Line3"
        '
        'Displaymsg2
        '
        Me.Displaymsg2.AutoSize = True
        Me.Displaymsg2.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Displaymsg2.Location = New System.Drawing.Point(6, 36)
        Me.Displaymsg2.Name = "Displaymsg2"
        Me.Displaymsg2.Size = New System.Drawing.Size(39, 13)
        Me.Displaymsg2.TabIndex = 164
        Me.Displaymsg2.Text = "Line2"
        '
        'Displaymsg1
        '
        Me.Displaymsg1.AutoSize = True
        Me.Displaymsg1.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Displaymsg1.Location = New System.Drawing.Point(6, 23)
        Me.Displaymsg1.Name = "Displaymsg1"
        Me.Displaymsg1.Size = New System.Drawing.Size(39, 13)
        Me.Displaymsg1.TabIndex = 163
        Me.Displaymsg1.Text = "Line1"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Black
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.PictureBox56)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(757, 355)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(128, 77)
        Me.GroupBox7.TabIndex = 162
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Vehicle"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MicrogrammaDEEBolExt", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 15)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "Foot"
        '
        'PictureBox56
        '
        Me.PictureBox56.Location = New System.Drawing.Point(9, 17)
        Me.PictureBox56.Name = "PictureBox56"
        Me.PictureBox56.Size = New System.Drawing.Size(55, 48)
        Me.PictureBox56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox56.TabIndex = 142
        Me.PictureBox56.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MicrogrammaDMedExt", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(70, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Fuel"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Black
        Me.GroupBox8.Controls.Add(Me.InvDisplay3)
        Me.GroupBox8.Controls.Add(Me.InvDisplay2)
        Me.GroupBox8.Controls.Add(Me.InvDisplay1)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(891, 355)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(128, 77)
        Me.GroupBox8.TabIndex = 163
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Inventory"
        '
        'InvDisplay3
        '
        Me.InvDisplay3.BackColor = System.Drawing.Color.Black
        Me.InvDisplay3.BackgroundImage = CType(resources.GetObject("InvDisplay3.BackgroundImage"), System.Drawing.Image)
        Me.InvDisplay3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InvDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvDisplay3.Image = CType(resources.GetObject("InvDisplay3.Image"), System.Drawing.Image)
        Me.InvDisplay3.Location = New System.Drawing.Point(90, 23)
        Me.InvDisplay3.Margin = New System.Windows.Forms.Padding(0)
        Me.InvDisplay3.Name = "InvDisplay3"
        Me.InvDisplay3.Size = New System.Drawing.Size(32, 32)
        Me.InvDisplay3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InvDisplay3.TabIndex = 762
        Me.InvDisplay3.TabStop = False
        '
        'InvDisplay2
        '
        Me.InvDisplay2.BackColor = System.Drawing.Color.Black
        Me.InvDisplay2.BackgroundImage = CType(resources.GetObject("InvDisplay2.BackgroundImage"), System.Drawing.Image)
        Me.InvDisplay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InvDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvDisplay2.Image = CType(resources.GetObject("InvDisplay2.Image"), System.Drawing.Image)
        Me.InvDisplay2.Location = New System.Drawing.Point(48, 23)
        Me.InvDisplay2.Margin = New System.Windows.Forms.Padding(0)
        Me.InvDisplay2.Name = "InvDisplay2"
        Me.InvDisplay2.Size = New System.Drawing.Size(32, 32)
        Me.InvDisplay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InvDisplay2.TabIndex = 761
        Me.InvDisplay2.TabStop = False
        '
        'InvDisplay1
        '
        Me.InvDisplay1.BackColor = System.Drawing.Color.Black
        Me.InvDisplay1.BackgroundImage = CType(resources.GetObject("InvDisplay1.BackgroundImage"), System.Drawing.Image)
        Me.InvDisplay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InvDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InvDisplay1.Image = CType(resources.GetObject("InvDisplay1.Image"), System.Drawing.Image)
        Me.InvDisplay1.Location = New System.Drawing.Point(6, 23)
        Me.InvDisplay1.Margin = New System.Windows.Forms.Padding(0)
        Me.InvDisplay1.Name = "InvDisplay1"
        Me.InvDisplay1.Size = New System.Drawing.Size(32, 32)
        Me.InvDisplay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InvDisplay1.TabIndex = 760
        Me.InvDisplay1.TabStop = False
        '
        'Timer1
        '
        '
        'X1Y1
        '
        Me.X1Y1.BackColor = System.Drawing.Color.Black
        Me.X1Y1.BackgroundImage = CType(resources.GetObject("X1Y1.BackgroundImage"), System.Drawing.Image)
        Me.X1Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y1.Image = CType(resources.GetObject("X1Y1.Image"), System.Drawing.Image)
        Me.X1Y1.Location = New System.Drawing.Point(113, 124)
        Me.X1Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y1.Name = "X1Y1"
        Me.X1Y1.Size = New System.Drawing.Size(32, 32)
        Me.X1Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y1.TabIndex = 559
        Me.X1Y1.TabStop = False
        '
        'X1Y2
        '
        Me.X1Y2.BackColor = System.Drawing.Color.Black
        Me.X1Y2.BackgroundImage = CType(resources.GetObject("X1Y2.BackgroundImage"), System.Drawing.Image)
        Me.X1Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y2.Image = CType(resources.GetObject("X1Y2.Image"), System.Drawing.Image)
        Me.X1Y2.Location = New System.Drawing.Point(145, 124)
        Me.X1Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y2.Name = "X1Y2"
        Me.X1Y2.Size = New System.Drawing.Size(32, 32)
        Me.X1Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y2.TabIndex = 560
        Me.X1Y2.TabStop = False
        '
        'X1Y3
        '
        Me.X1Y3.BackColor = System.Drawing.Color.Black
        Me.X1Y3.BackgroundImage = CType(resources.GetObject("X1Y3.BackgroundImage"), System.Drawing.Image)
        Me.X1Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y3.Image = CType(resources.GetObject("X1Y3.Image"), System.Drawing.Image)
        Me.X1Y3.Location = New System.Drawing.Point(177, 124)
        Me.X1Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y3.Name = "X1Y3"
        Me.X1Y3.Size = New System.Drawing.Size(32, 32)
        Me.X1Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y3.TabIndex = 561
        Me.X1Y3.TabStop = False
        '
        'X1Y4
        '
        Me.X1Y4.BackColor = System.Drawing.Color.Black
        Me.X1Y4.BackgroundImage = CType(resources.GetObject("X1Y4.BackgroundImage"), System.Drawing.Image)
        Me.X1Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y4.Image = CType(resources.GetObject("X1Y4.Image"), System.Drawing.Image)
        Me.X1Y4.Location = New System.Drawing.Point(209, 124)
        Me.X1Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y4.Name = "X1Y4"
        Me.X1Y4.Size = New System.Drawing.Size(32, 32)
        Me.X1Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y4.TabIndex = 562
        Me.X1Y4.TabStop = False
        '
        'X1Y5
        '
        Me.X1Y5.BackColor = System.Drawing.Color.Black
        Me.X1Y5.BackgroundImage = CType(resources.GetObject("X1Y5.BackgroundImage"), System.Drawing.Image)
        Me.X1Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y5.Image = CType(resources.GetObject("X1Y5.Image"), System.Drawing.Image)
        Me.X1Y5.Location = New System.Drawing.Point(241, 124)
        Me.X1Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y5.Name = "X1Y5"
        Me.X1Y5.Size = New System.Drawing.Size(32, 32)
        Me.X1Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y5.TabIndex = 563
        Me.X1Y5.TabStop = False
        '
        'X1Y6
        '
        Me.X1Y6.BackColor = System.Drawing.Color.Black
        Me.X1Y6.BackgroundImage = CType(resources.GetObject("X1Y6.BackgroundImage"), System.Drawing.Image)
        Me.X1Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y6.Image = CType(resources.GetObject("X1Y6.Image"), System.Drawing.Image)
        Me.X1Y6.Location = New System.Drawing.Point(273, 124)
        Me.X1Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y6.Name = "X1Y6"
        Me.X1Y6.Size = New System.Drawing.Size(32, 32)
        Me.X1Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y6.TabIndex = 564
        Me.X1Y6.TabStop = False
        '
        'X1Y7
        '
        Me.X1Y7.BackColor = System.Drawing.Color.Black
        Me.X1Y7.BackgroundImage = CType(resources.GetObject("X1Y7.BackgroundImage"), System.Drawing.Image)
        Me.X1Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y7.Image = CType(resources.GetObject("X1Y7.Image"), System.Drawing.Image)
        Me.X1Y7.Location = New System.Drawing.Point(305, 124)
        Me.X1Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y7.Name = "X1Y7"
        Me.X1Y7.Size = New System.Drawing.Size(32, 32)
        Me.X1Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y7.TabIndex = 565
        Me.X1Y7.TabStop = False
        '
        'X1Y8
        '
        Me.X1Y8.BackColor = System.Drawing.Color.Black
        Me.X1Y8.BackgroundImage = CType(resources.GetObject("X1Y8.BackgroundImage"), System.Drawing.Image)
        Me.X1Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y8.Image = CType(resources.GetObject("X1Y8.Image"), System.Drawing.Image)
        Me.X1Y8.Location = New System.Drawing.Point(337, 124)
        Me.X1Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y8.Name = "X1Y8"
        Me.X1Y8.Size = New System.Drawing.Size(32, 32)
        Me.X1Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y8.TabIndex = 566
        Me.X1Y8.TabStop = False
        '
        'X1Y9
        '
        Me.X1Y9.BackColor = System.Drawing.Color.Black
        Me.X1Y9.BackgroundImage = CType(resources.GetObject("X1Y9.BackgroundImage"), System.Drawing.Image)
        Me.X1Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y9.Image = CType(resources.GetObject("X1Y9.Image"), System.Drawing.Image)
        Me.X1Y9.Location = New System.Drawing.Point(369, 124)
        Me.X1Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y9.Name = "X1Y9"
        Me.X1Y9.Size = New System.Drawing.Size(32, 32)
        Me.X1Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y9.TabIndex = 567
        Me.X1Y9.TabStop = False
        '
        'X1Y10
        '
        Me.X1Y10.BackColor = System.Drawing.Color.Black
        Me.X1Y10.BackgroundImage = CType(resources.GetObject("X1Y10.BackgroundImage"), System.Drawing.Image)
        Me.X1Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y10.Image = CType(resources.GetObject("X1Y10.Image"), System.Drawing.Image)
        Me.X1Y10.Location = New System.Drawing.Point(401, 124)
        Me.X1Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y10.Name = "X1Y10"
        Me.X1Y10.Size = New System.Drawing.Size(32, 32)
        Me.X1Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y10.TabIndex = 568
        Me.X1Y10.TabStop = False
        '
        'X2Y1
        '
        Me.X2Y1.BackColor = System.Drawing.Color.Black
        Me.X2Y1.BackgroundImage = CType(resources.GetObject("X2Y1.BackgroundImage"), System.Drawing.Image)
        Me.X2Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y1.Image = CType(resources.GetObject("X2Y1.Image"), System.Drawing.Image)
        Me.X2Y1.Location = New System.Drawing.Point(113, 155)
        Me.X2Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y1.Name = "X2Y1"
        Me.X2Y1.Size = New System.Drawing.Size(32, 32)
        Me.X2Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y1.TabIndex = 569
        Me.X2Y1.TabStop = False
        '
        'X2Y2
        '
        Me.X2Y2.BackColor = System.Drawing.Color.Black
        Me.X2Y2.BackgroundImage = CType(resources.GetObject("X2Y2.BackgroundImage"), System.Drawing.Image)
        Me.X2Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y2.Image = CType(resources.GetObject("X2Y2.Image"), System.Drawing.Image)
        Me.X2Y2.Location = New System.Drawing.Point(145, 155)
        Me.X2Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y2.Name = "X2Y2"
        Me.X2Y2.Size = New System.Drawing.Size(32, 32)
        Me.X2Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y2.TabIndex = 570
        Me.X2Y2.TabStop = False
        '
        'X2Y8
        '
        Me.X2Y8.BackColor = System.Drawing.Color.Black
        Me.X2Y8.BackgroundImage = CType(resources.GetObject("X2Y8.BackgroundImage"), System.Drawing.Image)
        Me.X2Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y8.Image = CType(resources.GetObject("X2Y8.Image"), System.Drawing.Image)
        Me.X2Y8.Location = New System.Drawing.Point(337, 155)
        Me.X2Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y8.Name = "X2Y8"
        Me.X2Y8.Size = New System.Drawing.Size(32, 32)
        Me.X2Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y8.TabIndex = 576
        Me.X2Y8.TabStop = False
        '
        'X2Y3
        '
        Me.X2Y3.BackColor = System.Drawing.Color.Black
        Me.X2Y3.BackgroundImage = CType(resources.GetObject("X2Y3.BackgroundImage"), System.Drawing.Image)
        Me.X2Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y3.Image = CType(resources.GetObject("X2Y3.Image"), System.Drawing.Image)
        Me.X2Y3.Location = New System.Drawing.Point(177, 155)
        Me.X2Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y3.Name = "X2Y3"
        Me.X2Y3.Size = New System.Drawing.Size(32, 32)
        Me.X2Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y3.TabIndex = 571
        Me.X2Y3.TabStop = False
        '
        'X2Y4
        '
        Me.X2Y4.BackColor = System.Drawing.Color.Black
        Me.X2Y4.BackgroundImage = CType(resources.GetObject("X2Y4.BackgroundImage"), System.Drawing.Image)
        Me.X2Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y4.Image = CType(resources.GetObject("X2Y4.Image"), System.Drawing.Image)
        Me.X2Y4.Location = New System.Drawing.Point(209, 155)
        Me.X2Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y4.Name = "X2Y4"
        Me.X2Y4.Size = New System.Drawing.Size(32, 32)
        Me.X2Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y4.TabIndex = 572
        Me.X2Y4.TabStop = False
        '
        'X2Y5
        '
        Me.X2Y5.BackColor = System.Drawing.Color.Black
        Me.X2Y5.BackgroundImage = CType(resources.GetObject("X2Y5.BackgroundImage"), System.Drawing.Image)
        Me.X2Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y5.Image = CType(resources.GetObject("X2Y5.Image"), System.Drawing.Image)
        Me.X2Y5.Location = New System.Drawing.Point(241, 155)
        Me.X2Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y5.Name = "X2Y5"
        Me.X2Y5.Size = New System.Drawing.Size(32, 32)
        Me.X2Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y5.TabIndex = 573
        Me.X2Y5.TabStop = False
        '
        'X2Y6
        '
        Me.X2Y6.BackColor = System.Drawing.Color.Black
        Me.X2Y6.BackgroundImage = CType(resources.GetObject("X2Y6.BackgroundImage"), System.Drawing.Image)
        Me.X2Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y6.Image = CType(resources.GetObject("X2Y6.Image"), System.Drawing.Image)
        Me.X2Y6.Location = New System.Drawing.Point(273, 155)
        Me.X2Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y6.Name = "X2Y6"
        Me.X2Y6.Size = New System.Drawing.Size(32, 32)
        Me.X2Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y6.TabIndex = 574
        Me.X2Y6.TabStop = False
        '
        'X2Y7
        '
        Me.X2Y7.BackColor = System.Drawing.Color.Black
        Me.X2Y7.BackgroundImage = CType(resources.GetObject("X2Y7.BackgroundImage"), System.Drawing.Image)
        Me.X2Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y7.Image = CType(resources.GetObject("X2Y7.Image"), System.Drawing.Image)
        Me.X2Y7.Location = New System.Drawing.Point(305, 155)
        Me.X2Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y7.Name = "X2Y7"
        Me.X2Y7.Size = New System.Drawing.Size(32, 32)
        Me.X2Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y7.TabIndex = 575
        Me.X2Y7.TabStop = False
        '
        'X2Y9
        '
        Me.X2Y9.BackColor = System.Drawing.Color.Black
        Me.X2Y9.BackgroundImage = CType(resources.GetObject("X2Y9.BackgroundImage"), System.Drawing.Image)
        Me.X2Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y9.Image = CType(resources.GetObject("X2Y9.Image"), System.Drawing.Image)
        Me.X2Y9.Location = New System.Drawing.Point(369, 155)
        Me.X2Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y9.Name = "X2Y9"
        Me.X2Y9.Size = New System.Drawing.Size(32, 32)
        Me.X2Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y9.TabIndex = 577
        Me.X2Y9.TabStop = False
        '
        'X2Y10
        '
        Me.X2Y10.BackColor = System.Drawing.Color.Black
        Me.X2Y10.BackgroundImage = CType(resources.GetObject("X2Y10.BackgroundImage"), System.Drawing.Image)
        Me.X2Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y10.Image = CType(resources.GetObject("X2Y10.Image"), System.Drawing.Image)
        Me.X2Y10.Location = New System.Drawing.Point(401, 155)
        Me.X2Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y10.Name = "X2Y10"
        Me.X2Y10.Size = New System.Drawing.Size(32, 32)
        Me.X2Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y10.TabIndex = 578
        Me.X2Y10.TabStop = False
        '
        'X3Y6
        '
        Me.X3Y6.BackColor = System.Drawing.Color.Black
        Me.X3Y6.BackgroundImage = CType(resources.GetObject("X3Y6.BackgroundImage"), System.Drawing.Image)
        Me.X3Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y6.Image = CType(resources.GetObject("X3Y6.Image"), System.Drawing.Image)
        Me.X3Y6.Location = New System.Drawing.Point(273, 186)
        Me.X3Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y6.Name = "X3Y6"
        Me.X3Y6.Size = New System.Drawing.Size(32, 32)
        Me.X3Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y6.TabIndex = 584
        Me.X3Y6.TabStop = False
        '
        'X3Y1
        '
        Me.X3Y1.BackColor = System.Drawing.Color.Black
        Me.X3Y1.BackgroundImage = CType(resources.GetObject("X3Y1.BackgroundImage"), System.Drawing.Image)
        Me.X3Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y1.Image = CType(resources.GetObject("X3Y1.Image"), System.Drawing.Image)
        Me.X3Y1.Location = New System.Drawing.Point(113, 186)
        Me.X3Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y1.Name = "X3Y1"
        Me.X3Y1.Size = New System.Drawing.Size(32, 32)
        Me.X3Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y1.TabIndex = 579
        Me.X3Y1.TabStop = False
        '
        'X3Y2
        '
        Me.X3Y2.BackColor = System.Drawing.Color.Black
        Me.X3Y2.BackgroundImage = CType(resources.GetObject("X3Y2.BackgroundImage"), System.Drawing.Image)
        Me.X3Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y2.Image = CType(resources.GetObject("X3Y2.Image"), System.Drawing.Image)
        Me.X3Y2.Location = New System.Drawing.Point(145, 186)
        Me.X3Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y2.Name = "X3Y2"
        Me.X3Y2.Size = New System.Drawing.Size(32, 32)
        Me.X3Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y2.TabIndex = 580
        Me.X3Y2.TabStop = False
        '
        'X3Y3
        '
        Me.X3Y3.BackColor = System.Drawing.Color.Black
        Me.X3Y3.BackgroundImage = CType(resources.GetObject("X3Y3.BackgroundImage"), System.Drawing.Image)
        Me.X3Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y3.Image = CType(resources.GetObject("X3Y3.Image"), System.Drawing.Image)
        Me.X3Y3.Location = New System.Drawing.Point(177, 186)
        Me.X3Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y3.Name = "X3Y3"
        Me.X3Y3.Size = New System.Drawing.Size(32, 32)
        Me.X3Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y3.TabIndex = 581
        Me.X3Y3.TabStop = False
        '
        'X3Y4
        '
        Me.X3Y4.BackColor = System.Drawing.Color.Black
        Me.X3Y4.BackgroundImage = CType(resources.GetObject("X3Y4.BackgroundImage"), System.Drawing.Image)
        Me.X3Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y4.Image = CType(resources.GetObject("X3Y4.Image"), System.Drawing.Image)
        Me.X3Y4.Location = New System.Drawing.Point(209, 186)
        Me.X3Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y4.Name = "X3Y4"
        Me.X3Y4.Size = New System.Drawing.Size(32, 32)
        Me.X3Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y4.TabIndex = 582
        Me.X3Y4.TabStop = False
        '
        'X3Y5
        '
        Me.X3Y5.BackColor = System.Drawing.Color.Black
        Me.X3Y5.BackgroundImage = CType(resources.GetObject("X3Y5.BackgroundImage"), System.Drawing.Image)
        Me.X3Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y5.Image = CType(resources.GetObject("X3Y5.Image"), System.Drawing.Image)
        Me.X3Y5.Location = New System.Drawing.Point(241, 186)
        Me.X3Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y5.Name = "X3Y5"
        Me.X3Y5.Size = New System.Drawing.Size(32, 32)
        Me.X3Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y5.TabIndex = 583
        Me.X3Y5.TabStop = False
        '
        'X3Y7
        '
        Me.X3Y7.BackColor = System.Drawing.Color.Black
        Me.X3Y7.BackgroundImage = CType(resources.GetObject("X3Y7.BackgroundImage"), System.Drawing.Image)
        Me.X3Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y7.Image = CType(resources.GetObject("X3Y7.Image"), System.Drawing.Image)
        Me.X3Y7.Location = New System.Drawing.Point(305, 186)
        Me.X3Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y7.Name = "X3Y7"
        Me.X3Y7.Size = New System.Drawing.Size(32, 32)
        Me.X3Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y7.TabIndex = 585
        Me.X3Y7.TabStop = False
        '
        'X3Y8
        '
        Me.X3Y8.BackColor = System.Drawing.Color.Black
        Me.X3Y8.BackgroundImage = CType(resources.GetObject("X3Y8.BackgroundImage"), System.Drawing.Image)
        Me.X3Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y8.Image = CType(resources.GetObject("X3Y8.Image"), System.Drawing.Image)
        Me.X3Y8.Location = New System.Drawing.Point(337, 186)
        Me.X3Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y8.Name = "X3Y8"
        Me.X3Y8.Size = New System.Drawing.Size(32, 32)
        Me.X3Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y8.TabIndex = 586
        Me.X3Y8.TabStop = False
        '
        'X3Y9
        '
        Me.X3Y9.BackColor = System.Drawing.Color.Black
        Me.X3Y9.BackgroundImage = CType(resources.GetObject("X3Y9.BackgroundImage"), System.Drawing.Image)
        Me.X3Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y9.Image = CType(resources.GetObject("X3Y9.Image"), System.Drawing.Image)
        Me.X3Y9.Location = New System.Drawing.Point(369, 186)
        Me.X3Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y9.Name = "X3Y9"
        Me.X3Y9.Size = New System.Drawing.Size(32, 32)
        Me.X3Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y9.TabIndex = 587
        Me.X3Y9.TabStop = False
        '
        'X3Y10
        '
        Me.X3Y10.BackColor = System.Drawing.Color.Black
        Me.X3Y10.BackgroundImage = CType(resources.GetObject("X3Y10.BackgroundImage"), System.Drawing.Image)
        Me.X3Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y10.Image = CType(resources.GetObject("X3Y10.Image"), System.Drawing.Image)
        Me.X3Y10.Location = New System.Drawing.Point(401, 186)
        Me.X3Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y10.Name = "X3Y10"
        Me.X3Y10.Size = New System.Drawing.Size(32, 32)
        Me.X3Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y10.TabIndex = 588
        Me.X3Y10.TabStop = False
        '
        'X4Y1
        '
        Me.X4Y1.BackColor = System.Drawing.Color.Black
        Me.X4Y1.BackgroundImage = CType(resources.GetObject("X4Y1.BackgroundImage"), System.Drawing.Image)
        Me.X4Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y1.Image = CType(resources.GetObject("X4Y1.Image"), System.Drawing.Image)
        Me.X4Y1.Location = New System.Drawing.Point(113, 217)
        Me.X4Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y1.Name = "X4Y1"
        Me.X4Y1.Size = New System.Drawing.Size(32, 32)
        Me.X4Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y1.TabIndex = 589
        Me.X4Y1.TabStop = False
        '
        'X4Y2
        '
        Me.X4Y2.BackColor = System.Drawing.Color.Black
        Me.X4Y2.BackgroundImage = CType(resources.GetObject("X4Y2.BackgroundImage"), System.Drawing.Image)
        Me.X4Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y2.Image = CType(resources.GetObject("X4Y2.Image"), System.Drawing.Image)
        Me.X4Y2.Location = New System.Drawing.Point(145, 217)
        Me.X4Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y2.Name = "X4Y2"
        Me.X4Y2.Size = New System.Drawing.Size(32, 32)
        Me.X4Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y2.TabIndex = 590
        Me.X4Y2.TabStop = False
        '
        'X4Y3
        '
        Me.X4Y3.BackColor = System.Drawing.Color.Black
        Me.X4Y3.BackgroundImage = CType(resources.GetObject("X4Y3.BackgroundImage"), System.Drawing.Image)
        Me.X4Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y3.Image = CType(resources.GetObject("X4Y3.Image"), System.Drawing.Image)
        Me.X4Y3.Location = New System.Drawing.Point(177, 217)
        Me.X4Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y3.Name = "X4Y3"
        Me.X4Y3.Size = New System.Drawing.Size(32, 32)
        Me.X4Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y3.TabIndex = 591
        Me.X4Y3.TabStop = False
        '
        'X4Y4
        '
        Me.X4Y4.BackColor = System.Drawing.Color.Black
        Me.X4Y4.BackgroundImage = CType(resources.GetObject("X4Y4.BackgroundImage"), System.Drawing.Image)
        Me.X4Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y4.Image = CType(resources.GetObject("X4Y4.Image"), System.Drawing.Image)
        Me.X4Y4.Location = New System.Drawing.Point(209, 217)
        Me.X4Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y4.Name = "X4Y4"
        Me.X4Y4.Size = New System.Drawing.Size(32, 32)
        Me.X4Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y4.TabIndex = 592
        Me.X4Y4.TabStop = False
        '
        'X4Y5
        '
        Me.X4Y5.BackColor = System.Drawing.Color.Black
        Me.X4Y5.BackgroundImage = CType(resources.GetObject("X4Y5.BackgroundImage"), System.Drawing.Image)
        Me.X4Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y5.Image = CType(resources.GetObject("X4Y5.Image"), System.Drawing.Image)
        Me.X4Y5.Location = New System.Drawing.Point(241, 217)
        Me.X4Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y5.Name = "X4Y5"
        Me.X4Y5.Size = New System.Drawing.Size(32, 32)
        Me.X4Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y5.TabIndex = 593
        Me.X4Y5.TabStop = False
        '
        'X4Y6
        '
        Me.X4Y6.BackColor = System.Drawing.Color.Black
        Me.X4Y6.BackgroundImage = CType(resources.GetObject("X4Y6.BackgroundImage"), System.Drawing.Image)
        Me.X4Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y6.Image = CType(resources.GetObject("X4Y6.Image"), System.Drawing.Image)
        Me.X4Y6.Location = New System.Drawing.Point(273, 217)
        Me.X4Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y6.Name = "X4Y6"
        Me.X4Y6.Size = New System.Drawing.Size(32, 32)
        Me.X4Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y6.TabIndex = 594
        Me.X4Y6.TabStop = False
        '
        'X4Y7
        '
        Me.X4Y7.BackColor = System.Drawing.Color.Black
        Me.X4Y7.BackgroundImage = CType(resources.GetObject("X4Y7.BackgroundImage"), System.Drawing.Image)
        Me.X4Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y7.Image = CType(resources.GetObject("X4Y7.Image"), System.Drawing.Image)
        Me.X4Y7.Location = New System.Drawing.Point(305, 217)
        Me.X4Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y7.Name = "X4Y7"
        Me.X4Y7.Size = New System.Drawing.Size(32, 32)
        Me.X4Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y7.TabIndex = 595
        Me.X4Y7.TabStop = False
        '
        'X4Y8
        '
        Me.X4Y8.BackColor = System.Drawing.Color.Black
        Me.X4Y8.BackgroundImage = CType(resources.GetObject("X4Y8.BackgroundImage"), System.Drawing.Image)
        Me.X4Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y8.Image = CType(resources.GetObject("X4Y8.Image"), System.Drawing.Image)
        Me.X4Y8.Location = New System.Drawing.Point(337, 217)
        Me.X4Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y8.Name = "X4Y8"
        Me.X4Y8.Size = New System.Drawing.Size(32, 32)
        Me.X4Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y8.TabIndex = 596
        Me.X4Y8.TabStop = False
        '
        'X4Y9
        '
        Me.X4Y9.BackColor = System.Drawing.Color.Black
        Me.X4Y9.BackgroundImage = CType(resources.GetObject("X4Y9.BackgroundImage"), System.Drawing.Image)
        Me.X4Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y9.Image = CType(resources.GetObject("X4Y9.Image"), System.Drawing.Image)
        Me.X4Y9.Location = New System.Drawing.Point(369, 217)
        Me.X4Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y9.Name = "X4Y9"
        Me.X4Y9.Size = New System.Drawing.Size(32, 32)
        Me.X4Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y9.TabIndex = 597
        Me.X4Y9.TabStop = False
        '
        'X4Y10
        '
        Me.X4Y10.BackColor = System.Drawing.Color.Black
        Me.X4Y10.BackgroundImage = CType(resources.GetObject("X4Y10.BackgroundImage"), System.Drawing.Image)
        Me.X4Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y10.Image = CType(resources.GetObject("X4Y10.Image"), System.Drawing.Image)
        Me.X4Y10.Location = New System.Drawing.Point(401, 217)
        Me.X4Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y10.Name = "X4Y10"
        Me.X4Y10.Size = New System.Drawing.Size(32, 32)
        Me.X4Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y10.TabIndex = 598
        Me.X4Y10.TabStop = False
        '
        'X5Y6
        '
        Me.X5Y6.BackColor = System.Drawing.Color.Black
        Me.X5Y6.BackgroundImage = CType(resources.GetObject("X5Y6.BackgroundImage"), System.Drawing.Image)
        Me.X5Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y6.Image = CType(resources.GetObject("X5Y6.Image"), System.Drawing.Image)
        Me.X5Y6.Location = New System.Drawing.Point(273, 248)
        Me.X5Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y6.Name = "X5Y6"
        Me.X5Y6.Size = New System.Drawing.Size(32, 32)
        Me.X5Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y6.TabIndex = 604
        Me.X5Y6.TabStop = False
        '
        'X5Y1
        '
        Me.X5Y1.BackColor = System.Drawing.Color.Black
        Me.X5Y1.BackgroundImage = CType(resources.GetObject("X5Y1.BackgroundImage"), System.Drawing.Image)
        Me.X5Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y1.Image = CType(resources.GetObject("X5Y1.Image"), System.Drawing.Image)
        Me.X5Y1.Location = New System.Drawing.Point(113, 248)
        Me.X5Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y1.Name = "X5Y1"
        Me.X5Y1.Size = New System.Drawing.Size(32, 32)
        Me.X5Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y1.TabIndex = 599
        Me.X5Y1.TabStop = False
        '
        'X5Y2
        '
        Me.X5Y2.BackColor = System.Drawing.Color.Black
        Me.X5Y2.BackgroundImage = CType(resources.GetObject("X5Y2.BackgroundImage"), System.Drawing.Image)
        Me.X5Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y2.Image = CType(resources.GetObject("X5Y2.Image"), System.Drawing.Image)
        Me.X5Y2.Location = New System.Drawing.Point(145, 248)
        Me.X5Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y2.Name = "X5Y2"
        Me.X5Y2.Size = New System.Drawing.Size(32, 32)
        Me.X5Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y2.TabIndex = 600
        Me.X5Y2.TabStop = False
        '
        'X5Y3
        '
        Me.X5Y3.BackColor = System.Drawing.Color.Black
        Me.X5Y3.BackgroundImage = CType(resources.GetObject("X5Y3.BackgroundImage"), System.Drawing.Image)
        Me.X5Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y3.Image = CType(resources.GetObject("X5Y3.Image"), System.Drawing.Image)
        Me.X5Y3.Location = New System.Drawing.Point(177, 248)
        Me.X5Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y3.Name = "X5Y3"
        Me.X5Y3.Size = New System.Drawing.Size(32, 32)
        Me.X5Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y3.TabIndex = 601
        Me.X5Y3.TabStop = False
        '
        'X5Y4
        '
        Me.X5Y4.BackColor = System.Drawing.Color.Black
        Me.X5Y4.BackgroundImage = CType(resources.GetObject("X5Y4.BackgroundImage"), System.Drawing.Image)
        Me.X5Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y4.Image = CType(resources.GetObject("X5Y4.Image"), System.Drawing.Image)
        Me.X5Y4.Location = New System.Drawing.Point(209, 248)
        Me.X5Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y4.Name = "X5Y4"
        Me.X5Y4.Size = New System.Drawing.Size(32, 32)
        Me.X5Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y4.TabIndex = 602
        Me.X5Y4.TabStop = False
        '
        'X5Y5
        '
        Me.X5Y5.BackColor = System.Drawing.Color.Black
        Me.X5Y5.BackgroundImage = CType(resources.GetObject("X5Y5.BackgroundImage"), System.Drawing.Image)
        Me.X5Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y5.Image = CType(resources.GetObject("X5Y5.Image"), System.Drawing.Image)
        Me.X5Y5.Location = New System.Drawing.Point(241, 248)
        Me.X5Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y5.Name = "X5Y5"
        Me.X5Y5.Size = New System.Drawing.Size(32, 32)
        Me.X5Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y5.TabIndex = 603
        Me.X5Y5.TabStop = False
        '
        'X5Y7
        '
        Me.X5Y7.BackColor = System.Drawing.Color.Black
        Me.X5Y7.BackgroundImage = CType(resources.GetObject("X5Y7.BackgroundImage"), System.Drawing.Image)
        Me.X5Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y7.Image = CType(resources.GetObject("X5Y7.Image"), System.Drawing.Image)
        Me.X5Y7.Location = New System.Drawing.Point(305, 248)
        Me.X5Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y7.Name = "X5Y7"
        Me.X5Y7.Size = New System.Drawing.Size(32, 32)
        Me.X5Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y7.TabIndex = 605
        Me.X5Y7.TabStop = False
        '
        'X5Y8
        '
        Me.X5Y8.BackColor = System.Drawing.Color.Black
        Me.X5Y8.BackgroundImage = CType(resources.GetObject("X5Y8.BackgroundImage"), System.Drawing.Image)
        Me.X5Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y8.Image = CType(resources.GetObject("X5Y8.Image"), System.Drawing.Image)
        Me.X5Y8.Location = New System.Drawing.Point(337, 248)
        Me.X5Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y8.Name = "X5Y8"
        Me.X5Y8.Size = New System.Drawing.Size(32, 32)
        Me.X5Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y8.TabIndex = 606
        Me.X5Y8.TabStop = False
        '
        'X5Y9
        '
        Me.X5Y9.BackColor = System.Drawing.Color.Black
        Me.X5Y9.BackgroundImage = CType(resources.GetObject("X5Y9.BackgroundImage"), System.Drawing.Image)
        Me.X5Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y9.Image = CType(resources.GetObject("X5Y9.Image"), System.Drawing.Image)
        Me.X5Y9.Location = New System.Drawing.Point(369, 248)
        Me.X5Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y9.Name = "X5Y9"
        Me.X5Y9.Size = New System.Drawing.Size(32, 32)
        Me.X5Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y9.TabIndex = 607
        Me.X5Y9.TabStop = False
        '
        'X5Y10
        '
        Me.X5Y10.BackColor = System.Drawing.Color.Black
        Me.X5Y10.BackgroundImage = CType(resources.GetObject("X5Y10.BackgroundImage"), System.Drawing.Image)
        Me.X5Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y10.Image = CType(resources.GetObject("X5Y10.Image"), System.Drawing.Image)
        Me.X5Y10.Location = New System.Drawing.Point(401, 248)
        Me.X5Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y10.Name = "X5Y10"
        Me.X5Y10.Size = New System.Drawing.Size(32, 32)
        Me.X5Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y10.TabIndex = 608
        Me.X5Y10.TabStop = False
        '
        'X6Y6
        '
        Me.X6Y6.BackColor = System.Drawing.Color.Black
        Me.X6Y6.BackgroundImage = CType(resources.GetObject("X6Y6.BackgroundImage"), System.Drawing.Image)
        Me.X6Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y6.Image = CType(resources.GetObject("X6Y6.Image"), System.Drawing.Image)
        Me.X6Y6.Location = New System.Drawing.Point(273, 279)
        Me.X6Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y6.Name = "X6Y6"
        Me.X6Y6.Size = New System.Drawing.Size(32, 32)
        Me.X6Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y6.TabIndex = 614
        Me.X6Y6.TabStop = False
        '
        'X6Y1
        '
        Me.X6Y1.BackColor = System.Drawing.Color.Black
        Me.X6Y1.BackgroundImage = CType(resources.GetObject("X6Y1.BackgroundImage"), System.Drawing.Image)
        Me.X6Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y1.Image = CType(resources.GetObject("X6Y1.Image"), System.Drawing.Image)
        Me.X6Y1.Location = New System.Drawing.Point(113, 279)
        Me.X6Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y1.Name = "X6Y1"
        Me.X6Y1.Size = New System.Drawing.Size(32, 32)
        Me.X6Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y1.TabIndex = 609
        Me.X6Y1.TabStop = False
        '
        'X6Y2
        '
        Me.X6Y2.BackColor = System.Drawing.Color.Black
        Me.X6Y2.BackgroundImage = CType(resources.GetObject("X6Y2.BackgroundImage"), System.Drawing.Image)
        Me.X6Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y2.Image = CType(resources.GetObject("X6Y2.Image"), System.Drawing.Image)
        Me.X6Y2.Location = New System.Drawing.Point(145, 279)
        Me.X6Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y2.Name = "X6Y2"
        Me.X6Y2.Size = New System.Drawing.Size(32, 32)
        Me.X6Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y2.TabIndex = 610
        Me.X6Y2.TabStop = False
        '
        'X6Y3
        '
        Me.X6Y3.BackColor = System.Drawing.Color.Black
        Me.X6Y3.BackgroundImage = CType(resources.GetObject("X6Y3.BackgroundImage"), System.Drawing.Image)
        Me.X6Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y3.Image = CType(resources.GetObject("X6Y3.Image"), System.Drawing.Image)
        Me.X6Y3.Location = New System.Drawing.Point(177, 279)
        Me.X6Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y3.Name = "X6Y3"
        Me.X6Y3.Size = New System.Drawing.Size(32, 32)
        Me.X6Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y3.TabIndex = 611
        Me.X6Y3.TabStop = False
        '
        'X6Y4
        '
        Me.X6Y4.BackColor = System.Drawing.Color.Black
        Me.X6Y4.BackgroundImage = CType(resources.GetObject("X6Y4.BackgroundImage"), System.Drawing.Image)
        Me.X6Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y4.Image = CType(resources.GetObject("X6Y4.Image"), System.Drawing.Image)
        Me.X6Y4.Location = New System.Drawing.Point(209, 279)
        Me.X6Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y4.Name = "X6Y4"
        Me.X6Y4.Size = New System.Drawing.Size(32, 32)
        Me.X6Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y4.TabIndex = 612
        Me.X6Y4.TabStop = False
        '
        'X6Y5
        '
        Me.X6Y5.BackColor = System.Drawing.Color.Black
        Me.X6Y5.BackgroundImage = CType(resources.GetObject("X6Y5.BackgroundImage"), System.Drawing.Image)
        Me.X6Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y5.Image = CType(resources.GetObject("X6Y5.Image"), System.Drawing.Image)
        Me.X6Y5.Location = New System.Drawing.Point(241, 279)
        Me.X6Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y5.Name = "X6Y5"
        Me.X6Y5.Size = New System.Drawing.Size(32, 32)
        Me.X6Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y5.TabIndex = 613
        Me.X6Y5.TabStop = False
        '
        'X6Y7
        '
        Me.X6Y7.BackColor = System.Drawing.Color.Black
        Me.X6Y7.BackgroundImage = CType(resources.GetObject("X6Y7.BackgroundImage"), System.Drawing.Image)
        Me.X6Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y7.Image = CType(resources.GetObject("X6Y7.Image"), System.Drawing.Image)
        Me.X6Y7.Location = New System.Drawing.Point(305, 279)
        Me.X6Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y7.Name = "X6Y7"
        Me.X6Y7.Size = New System.Drawing.Size(32, 32)
        Me.X6Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y7.TabIndex = 615
        Me.X6Y7.TabStop = False
        '
        'X6Y8
        '
        Me.X6Y8.BackColor = System.Drawing.Color.Black
        Me.X6Y8.BackgroundImage = CType(resources.GetObject("X6Y8.BackgroundImage"), System.Drawing.Image)
        Me.X6Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y8.Image = CType(resources.GetObject("X6Y8.Image"), System.Drawing.Image)
        Me.X6Y8.Location = New System.Drawing.Point(337, 279)
        Me.X6Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y8.Name = "X6Y8"
        Me.X6Y8.Size = New System.Drawing.Size(32, 32)
        Me.X6Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y8.TabIndex = 616
        Me.X6Y8.TabStop = False
        '
        'X6Y9
        '
        Me.X6Y9.BackColor = System.Drawing.Color.Black
        Me.X6Y9.BackgroundImage = CType(resources.GetObject("X6Y9.BackgroundImage"), System.Drawing.Image)
        Me.X6Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y9.Image = CType(resources.GetObject("X6Y9.Image"), System.Drawing.Image)
        Me.X6Y9.Location = New System.Drawing.Point(369, 279)
        Me.X6Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y9.Name = "X6Y9"
        Me.X6Y9.Size = New System.Drawing.Size(32, 32)
        Me.X6Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y9.TabIndex = 617
        Me.X6Y9.TabStop = False
        '
        'X6Y10
        '
        Me.X6Y10.BackColor = System.Drawing.Color.Black
        Me.X6Y10.BackgroundImage = CType(resources.GetObject("X6Y10.BackgroundImage"), System.Drawing.Image)
        Me.X6Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y10.Image = CType(resources.GetObject("X6Y10.Image"), System.Drawing.Image)
        Me.X6Y10.Location = New System.Drawing.Point(401, 279)
        Me.X6Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y10.Name = "X6Y10"
        Me.X6Y10.Size = New System.Drawing.Size(32, 32)
        Me.X6Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y10.TabIndex = 618
        Me.X6Y10.TabStop = False
        '
        'X7Y6
        '
        Me.X7Y6.BackColor = System.Drawing.Color.Black
        Me.X7Y6.BackgroundImage = CType(resources.GetObject("X7Y6.BackgroundImage"), System.Drawing.Image)
        Me.X7Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y6.Image = CType(resources.GetObject("X7Y6.Image"), System.Drawing.Image)
        Me.X7Y6.Location = New System.Drawing.Point(273, 310)
        Me.X7Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y6.Name = "X7Y6"
        Me.X7Y6.Size = New System.Drawing.Size(32, 32)
        Me.X7Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y6.TabIndex = 624
        Me.X7Y6.TabStop = False
        '
        'X7Y1
        '
        Me.X7Y1.BackColor = System.Drawing.Color.Black
        Me.X7Y1.BackgroundImage = CType(resources.GetObject("X7Y1.BackgroundImage"), System.Drawing.Image)
        Me.X7Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y1.Image = CType(resources.GetObject("X7Y1.Image"), System.Drawing.Image)
        Me.X7Y1.Location = New System.Drawing.Point(113, 310)
        Me.X7Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y1.Name = "X7Y1"
        Me.X7Y1.Size = New System.Drawing.Size(32, 32)
        Me.X7Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y1.TabIndex = 619
        Me.X7Y1.TabStop = False
        '
        'X7Y2
        '
        Me.X7Y2.BackColor = System.Drawing.Color.Black
        Me.X7Y2.BackgroundImage = CType(resources.GetObject("X7Y2.BackgroundImage"), System.Drawing.Image)
        Me.X7Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y2.Image = CType(resources.GetObject("X7Y2.Image"), System.Drawing.Image)
        Me.X7Y2.Location = New System.Drawing.Point(145, 310)
        Me.X7Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y2.Name = "X7Y2"
        Me.X7Y2.Size = New System.Drawing.Size(32, 32)
        Me.X7Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y2.TabIndex = 620
        Me.X7Y2.TabStop = False
        '
        'X7Y3
        '
        Me.X7Y3.BackColor = System.Drawing.Color.Black
        Me.X7Y3.BackgroundImage = CType(resources.GetObject("X7Y3.BackgroundImage"), System.Drawing.Image)
        Me.X7Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y3.Image = CType(resources.GetObject("X7Y3.Image"), System.Drawing.Image)
        Me.X7Y3.Location = New System.Drawing.Point(177, 310)
        Me.X7Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y3.Name = "X7Y3"
        Me.X7Y3.Size = New System.Drawing.Size(32, 32)
        Me.X7Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y3.TabIndex = 621
        Me.X7Y3.TabStop = False
        '
        'X7Y4
        '
        Me.X7Y4.BackColor = System.Drawing.Color.Black
        Me.X7Y4.BackgroundImage = CType(resources.GetObject("X7Y4.BackgroundImage"), System.Drawing.Image)
        Me.X7Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y4.Image = CType(resources.GetObject("X7Y4.Image"), System.Drawing.Image)
        Me.X7Y4.Location = New System.Drawing.Point(209, 310)
        Me.X7Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y4.Name = "X7Y4"
        Me.X7Y4.Size = New System.Drawing.Size(32, 32)
        Me.X7Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y4.TabIndex = 622
        Me.X7Y4.TabStop = False
        '
        'X7Y5
        '
        Me.X7Y5.BackColor = System.Drawing.Color.Black
        Me.X7Y5.BackgroundImage = CType(resources.GetObject("X7Y5.BackgroundImage"), System.Drawing.Image)
        Me.X7Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y5.Image = CType(resources.GetObject("X7Y5.Image"), System.Drawing.Image)
        Me.X7Y5.Location = New System.Drawing.Point(241, 310)
        Me.X7Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y5.Name = "X7Y5"
        Me.X7Y5.Size = New System.Drawing.Size(32, 32)
        Me.X7Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y5.TabIndex = 623
        Me.X7Y5.TabStop = False
        '
        'X7Y7
        '
        Me.X7Y7.BackColor = System.Drawing.Color.Black
        Me.X7Y7.BackgroundImage = CType(resources.GetObject("X7Y7.BackgroundImage"), System.Drawing.Image)
        Me.X7Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y7.Image = CType(resources.GetObject("X7Y7.Image"), System.Drawing.Image)
        Me.X7Y7.Location = New System.Drawing.Point(305, 310)
        Me.X7Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y7.Name = "X7Y7"
        Me.X7Y7.Size = New System.Drawing.Size(32, 32)
        Me.X7Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y7.TabIndex = 625
        Me.X7Y7.TabStop = False
        '
        'X7Y8
        '
        Me.X7Y8.BackColor = System.Drawing.Color.Black
        Me.X7Y8.BackgroundImage = CType(resources.GetObject("X7Y8.BackgroundImage"), System.Drawing.Image)
        Me.X7Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y8.Image = CType(resources.GetObject("X7Y8.Image"), System.Drawing.Image)
        Me.X7Y8.Location = New System.Drawing.Point(337, 310)
        Me.X7Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y8.Name = "X7Y8"
        Me.X7Y8.Size = New System.Drawing.Size(32, 32)
        Me.X7Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y8.TabIndex = 626
        Me.X7Y8.TabStop = False
        '
        'X7Y9
        '
        Me.X7Y9.BackColor = System.Drawing.Color.Black
        Me.X7Y9.BackgroundImage = CType(resources.GetObject("X7Y9.BackgroundImage"), System.Drawing.Image)
        Me.X7Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y9.Image = CType(resources.GetObject("X7Y9.Image"), System.Drawing.Image)
        Me.X7Y9.Location = New System.Drawing.Point(369, 310)
        Me.X7Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y9.Name = "X7Y9"
        Me.X7Y9.Size = New System.Drawing.Size(32, 32)
        Me.X7Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y9.TabIndex = 627
        Me.X7Y9.TabStop = False
        '
        'X7Y10
        '
        Me.X7Y10.BackColor = System.Drawing.Color.Black
        Me.X7Y10.BackgroundImage = CType(resources.GetObject("X7Y10.BackgroundImage"), System.Drawing.Image)
        Me.X7Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y10.Image = CType(resources.GetObject("X7Y10.Image"), System.Drawing.Image)
        Me.X7Y10.Location = New System.Drawing.Point(401, 310)
        Me.X7Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y10.Name = "X7Y10"
        Me.X7Y10.Size = New System.Drawing.Size(32, 32)
        Me.X7Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y10.TabIndex = 628
        Me.X7Y10.TabStop = False
        '
        'X8Y6
        '
        Me.X8Y6.BackColor = System.Drawing.Color.Black
        Me.X8Y6.BackgroundImage = CType(resources.GetObject("X8Y6.BackgroundImage"), System.Drawing.Image)
        Me.X8Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y6.Image = CType(resources.GetObject("X8Y6.Image"), System.Drawing.Image)
        Me.X8Y6.Location = New System.Drawing.Point(273, 341)
        Me.X8Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y6.Name = "X8Y6"
        Me.X8Y6.Size = New System.Drawing.Size(32, 32)
        Me.X8Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y6.TabIndex = 634
        Me.X8Y6.TabStop = False
        '
        'X8Y1
        '
        Me.X8Y1.BackColor = System.Drawing.Color.Black
        Me.X8Y1.BackgroundImage = CType(resources.GetObject("X8Y1.BackgroundImage"), System.Drawing.Image)
        Me.X8Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y1.Image = CType(resources.GetObject("X8Y1.Image"), System.Drawing.Image)
        Me.X8Y1.Location = New System.Drawing.Point(113, 341)
        Me.X8Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y1.Name = "X8Y1"
        Me.X8Y1.Size = New System.Drawing.Size(32, 32)
        Me.X8Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y1.TabIndex = 629
        Me.X8Y1.TabStop = False
        '
        'X8Y2
        '
        Me.X8Y2.BackColor = System.Drawing.Color.Black
        Me.X8Y2.BackgroundImage = CType(resources.GetObject("X8Y2.BackgroundImage"), System.Drawing.Image)
        Me.X8Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y2.Image = CType(resources.GetObject("X8Y2.Image"), System.Drawing.Image)
        Me.X8Y2.Location = New System.Drawing.Point(145, 341)
        Me.X8Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y2.Name = "X8Y2"
        Me.X8Y2.Size = New System.Drawing.Size(32, 32)
        Me.X8Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y2.TabIndex = 630
        Me.X8Y2.TabStop = False
        '
        'X8Y3
        '
        Me.X8Y3.BackColor = System.Drawing.Color.Black
        Me.X8Y3.BackgroundImage = CType(resources.GetObject("X8Y3.BackgroundImage"), System.Drawing.Image)
        Me.X8Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y3.Image = CType(resources.GetObject("X8Y3.Image"), System.Drawing.Image)
        Me.X8Y3.Location = New System.Drawing.Point(177, 341)
        Me.X8Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y3.Name = "X8Y3"
        Me.X8Y3.Size = New System.Drawing.Size(32, 32)
        Me.X8Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y3.TabIndex = 631
        Me.X8Y3.TabStop = False
        '
        'X8Y4
        '
        Me.X8Y4.BackColor = System.Drawing.Color.Black
        Me.X8Y4.BackgroundImage = CType(resources.GetObject("X8Y4.BackgroundImage"), System.Drawing.Image)
        Me.X8Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y4.Image = CType(resources.GetObject("X8Y4.Image"), System.Drawing.Image)
        Me.X8Y4.Location = New System.Drawing.Point(209, 341)
        Me.X8Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y4.Name = "X8Y4"
        Me.X8Y4.Size = New System.Drawing.Size(32, 32)
        Me.X8Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y4.TabIndex = 632
        Me.X8Y4.TabStop = False
        '
        'X8Y5
        '
        Me.X8Y5.BackColor = System.Drawing.Color.Black
        Me.X8Y5.BackgroundImage = CType(resources.GetObject("X8Y5.BackgroundImage"), System.Drawing.Image)
        Me.X8Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y5.Image = CType(resources.GetObject("X8Y5.Image"), System.Drawing.Image)
        Me.X8Y5.Location = New System.Drawing.Point(241, 341)
        Me.X8Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y5.Name = "X8Y5"
        Me.X8Y5.Size = New System.Drawing.Size(32, 32)
        Me.X8Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y5.TabIndex = 633
        Me.X8Y5.TabStop = False
        '
        'X8Y7
        '
        Me.X8Y7.BackColor = System.Drawing.Color.Black
        Me.X8Y7.BackgroundImage = CType(resources.GetObject("X8Y7.BackgroundImage"), System.Drawing.Image)
        Me.X8Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y7.Image = CType(resources.GetObject("X8Y7.Image"), System.Drawing.Image)
        Me.X8Y7.Location = New System.Drawing.Point(305, 341)
        Me.X8Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y7.Name = "X8Y7"
        Me.X8Y7.Size = New System.Drawing.Size(32, 32)
        Me.X8Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y7.TabIndex = 635
        Me.X8Y7.TabStop = False
        '
        'X8Y8
        '
        Me.X8Y8.BackColor = System.Drawing.Color.Black
        Me.X8Y8.BackgroundImage = CType(resources.GetObject("X8Y8.BackgroundImage"), System.Drawing.Image)
        Me.X8Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y8.Image = CType(resources.GetObject("X8Y8.Image"), System.Drawing.Image)
        Me.X8Y8.Location = New System.Drawing.Point(337, 341)
        Me.X8Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y8.Name = "X8Y8"
        Me.X8Y8.Size = New System.Drawing.Size(32, 32)
        Me.X8Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y8.TabIndex = 636
        Me.X8Y8.TabStop = False
        '
        'X8Y9
        '
        Me.X8Y9.BackColor = System.Drawing.Color.Black
        Me.X8Y9.BackgroundImage = CType(resources.GetObject("X8Y9.BackgroundImage"), System.Drawing.Image)
        Me.X8Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y9.Image = CType(resources.GetObject("X8Y9.Image"), System.Drawing.Image)
        Me.X8Y9.Location = New System.Drawing.Point(369, 341)
        Me.X8Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y9.Name = "X8Y9"
        Me.X8Y9.Size = New System.Drawing.Size(32, 32)
        Me.X8Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y9.TabIndex = 637
        Me.X8Y9.TabStop = False
        '
        'X8Y10
        '
        Me.X8Y10.BackColor = System.Drawing.Color.Black
        Me.X8Y10.BackgroundImage = CType(resources.GetObject("X8Y10.BackgroundImage"), System.Drawing.Image)
        Me.X8Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y10.Image = CType(resources.GetObject("X8Y10.Image"), System.Drawing.Image)
        Me.X8Y10.Location = New System.Drawing.Point(401, 341)
        Me.X8Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y10.Name = "X8Y10"
        Me.X8Y10.Size = New System.Drawing.Size(32, 32)
        Me.X8Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y10.TabIndex = 638
        Me.X8Y10.TabStop = False
        '
        'X9Y6
        '
        Me.X9Y6.BackColor = System.Drawing.Color.Black
        Me.X9Y6.BackgroundImage = CType(resources.GetObject("X9Y6.BackgroundImage"), System.Drawing.Image)
        Me.X9Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y6.Image = CType(resources.GetObject("X9Y6.Image"), System.Drawing.Image)
        Me.X9Y6.Location = New System.Drawing.Point(273, 372)
        Me.X9Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y6.Name = "X9Y6"
        Me.X9Y6.Size = New System.Drawing.Size(32, 32)
        Me.X9Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y6.TabIndex = 644
        Me.X9Y6.TabStop = False
        '
        'X9Y1
        '
        Me.X9Y1.BackColor = System.Drawing.Color.Black
        Me.X9Y1.BackgroundImage = CType(resources.GetObject("X9Y1.BackgroundImage"), System.Drawing.Image)
        Me.X9Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y1.Image = CType(resources.GetObject("X9Y1.Image"), System.Drawing.Image)
        Me.X9Y1.Location = New System.Drawing.Point(113, 372)
        Me.X9Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y1.Name = "X9Y1"
        Me.X9Y1.Size = New System.Drawing.Size(32, 32)
        Me.X9Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y1.TabIndex = 639
        Me.X9Y1.TabStop = False
        '
        'X9Y2
        '
        Me.X9Y2.BackColor = System.Drawing.Color.Black
        Me.X9Y2.BackgroundImage = CType(resources.GetObject("X9Y2.BackgroundImage"), System.Drawing.Image)
        Me.X9Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y2.Image = CType(resources.GetObject("X9Y2.Image"), System.Drawing.Image)
        Me.X9Y2.Location = New System.Drawing.Point(145, 372)
        Me.X9Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y2.Name = "X9Y2"
        Me.X9Y2.Size = New System.Drawing.Size(32, 32)
        Me.X9Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y2.TabIndex = 640
        Me.X9Y2.TabStop = False
        '
        'X9Y3
        '
        Me.X9Y3.BackColor = System.Drawing.Color.Black
        Me.X9Y3.BackgroundImage = CType(resources.GetObject("X9Y3.BackgroundImage"), System.Drawing.Image)
        Me.X9Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y3.Image = CType(resources.GetObject("X9Y3.Image"), System.Drawing.Image)
        Me.X9Y3.Location = New System.Drawing.Point(177, 372)
        Me.X9Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y3.Name = "X9Y3"
        Me.X9Y3.Size = New System.Drawing.Size(32, 32)
        Me.X9Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y3.TabIndex = 641
        Me.X9Y3.TabStop = False
        '
        'X9Y4
        '
        Me.X9Y4.BackColor = System.Drawing.Color.Black
        Me.X9Y4.BackgroundImage = CType(resources.GetObject("X9Y4.BackgroundImage"), System.Drawing.Image)
        Me.X9Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y4.Image = CType(resources.GetObject("X9Y4.Image"), System.Drawing.Image)
        Me.X9Y4.Location = New System.Drawing.Point(209, 372)
        Me.X9Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y4.Name = "X9Y4"
        Me.X9Y4.Size = New System.Drawing.Size(32, 32)
        Me.X9Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y4.TabIndex = 642
        Me.X9Y4.TabStop = False
        '
        'X9Y5
        '
        Me.X9Y5.BackColor = System.Drawing.Color.Black
        Me.X9Y5.BackgroundImage = CType(resources.GetObject("X9Y5.BackgroundImage"), System.Drawing.Image)
        Me.X9Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y5.Image = CType(resources.GetObject("X9Y5.Image"), System.Drawing.Image)
        Me.X9Y5.Location = New System.Drawing.Point(241, 372)
        Me.X9Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y5.Name = "X9Y5"
        Me.X9Y5.Size = New System.Drawing.Size(32, 32)
        Me.X9Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y5.TabIndex = 643
        Me.X9Y5.TabStop = False
        '
        'X9Y7
        '
        Me.X9Y7.BackColor = System.Drawing.Color.Black
        Me.X9Y7.BackgroundImage = CType(resources.GetObject("X9Y7.BackgroundImage"), System.Drawing.Image)
        Me.X9Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y7.Image = CType(resources.GetObject("X9Y7.Image"), System.Drawing.Image)
        Me.X9Y7.Location = New System.Drawing.Point(305, 372)
        Me.X9Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y7.Name = "X9Y7"
        Me.X9Y7.Size = New System.Drawing.Size(32, 32)
        Me.X9Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y7.TabIndex = 645
        Me.X9Y7.TabStop = False
        '
        'X9Y8
        '
        Me.X9Y8.BackColor = System.Drawing.Color.Black
        Me.X9Y8.BackgroundImage = CType(resources.GetObject("X9Y8.BackgroundImage"), System.Drawing.Image)
        Me.X9Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y8.Image = CType(resources.GetObject("X9Y8.Image"), System.Drawing.Image)
        Me.X9Y8.Location = New System.Drawing.Point(337, 372)
        Me.X9Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y8.Name = "X9Y8"
        Me.X9Y8.Size = New System.Drawing.Size(32, 32)
        Me.X9Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y8.TabIndex = 646
        Me.X9Y8.TabStop = False
        '
        'X9Y9
        '
        Me.X9Y9.BackColor = System.Drawing.Color.Black
        Me.X9Y9.BackgroundImage = CType(resources.GetObject("X9Y9.BackgroundImage"), System.Drawing.Image)
        Me.X9Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y9.Image = CType(resources.GetObject("X9Y9.Image"), System.Drawing.Image)
        Me.X9Y9.Location = New System.Drawing.Point(369, 372)
        Me.X9Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y9.Name = "X9Y9"
        Me.X9Y9.Size = New System.Drawing.Size(32, 32)
        Me.X9Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y9.TabIndex = 647
        Me.X9Y9.TabStop = False
        '
        'X9Y10
        '
        Me.X9Y10.BackColor = System.Drawing.Color.Black
        Me.X9Y10.BackgroundImage = CType(resources.GetObject("X9Y10.BackgroundImage"), System.Drawing.Image)
        Me.X9Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y10.Image = CType(resources.GetObject("X9Y10.Image"), System.Drawing.Image)
        Me.X9Y10.Location = New System.Drawing.Point(401, 372)
        Me.X9Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y10.Name = "X9Y10"
        Me.X9Y10.Size = New System.Drawing.Size(32, 32)
        Me.X9Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y10.TabIndex = 648
        Me.X9Y10.TabStop = False
        '
        'X10Y6
        '
        Me.X10Y6.BackColor = System.Drawing.Color.Black
        Me.X10Y6.BackgroundImage = CType(resources.GetObject("X10Y6.BackgroundImage"), System.Drawing.Image)
        Me.X10Y6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y6.Image = CType(resources.GetObject("X10Y6.Image"), System.Drawing.Image)
        Me.X10Y6.Location = New System.Drawing.Point(273, 403)
        Me.X10Y6.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y6.Name = "X10Y6"
        Me.X10Y6.Size = New System.Drawing.Size(32, 32)
        Me.X10Y6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y6.TabIndex = 654
        Me.X10Y6.TabStop = False
        '
        'X10Y1
        '
        Me.X10Y1.BackColor = System.Drawing.Color.Black
        Me.X10Y1.BackgroundImage = CType(resources.GetObject("X10Y1.BackgroundImage"), System.Drawing.Image)
        Me.X10Y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y1.Image = CType(resources.GetObject("X10Y1.Image"), System.Drawing.Image)
        Me.X10Y1.Location = New System.Drawing.Point(113, 403)
        Me.X10Y1.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y1.Name = "X10Y1"
        Me.X10Y1.Size = New System.Drawing.Size(32, 32)
        Me.X10Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y1.TabIndex = 649
        Me.X10Y1.TabStop = False
        '
        'X10Y2
        '
        Me.X10Y2.BackColor = System.Drawing.Color.Black
        Me.X10Y2.BackgroundImage = CType(resources.GetObject("X10Y2.BackgroundImage"), System.Drawing.Image)
        Me.X10Y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y2.Image = CType(resources.GetObject("X10Y2.Image"), System.Drawing.Image)
        Me.X10Y2.Location = New System.Drawing.Point(145, 403)
        Me.X10Y2.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y2.Name = "X10Y2"
        Me.X10Y2.Size = New System.Drawing.Size(32, 32)
        Me.X10Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y2.TabIndex = 650
        Me.X10Y2.TabStop = False
        '
        'X10Y3
        '
        Me.X10Y3.BackColor = System.Drawing.Color.Black
        Me.X10Y3.BackgroundImage = CType(resources.GetObject("X10Y3.BackgroundImage"), System.Drawing.Image)
        Me.X10Y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y3.Image = CType(resources.GetObject("X10Y3.Image"), System.Drawing.Image)
        Me.X10Y3.Location = New System.Drawing.Point(177, 403)
        Me.X10Y3.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y3.Name = "X10Y3"
        Me.X10Y3.Size = New System.Drawing.Size(32, 32)
        Me.X10Y3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y3.TabIndex = 651
        Me.X10Y3.TabStop = False
        '
        'X10Y4
        '
        Me.X10Y4.BackColor = System.Drawing.Color.Black
        Me.X10Y4.BackgroundImage = CType(resources.GetObject("X10Y4.BackgroundImage"), System.Drawing.Image)
        Me.X10Y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y4.Image = CType(resources.GetObject("X10Y4.Image"), System.Drawing.Image)
        Me.X10Y4.Location = New System.Drawing.Point(209, 403)
        Me.X10Y4.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y4.Name = "X10Y4"
        Me.X10Y4.Size = New System.Drawing.Size(32, 32)
        Me.X10Y4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y4.TabIndex = 652
        Me.X10Y4.TabStop = False
        '
        'X10Y5
        '
        Me.X10Y5.BackColor = System.Drawing.Color.Black
        Me.X10Y5.BackgroundImage = CType(resources.GetObject("X10Y5.BackgroundImage"), System.Drawing.Image)
        Me.X10Y5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y5.Image = CType(resources.GetObject("X10Y5.Image"), System.Drawing.Image)
        Me.X10Y5.Location = New System.Drawing.Point(241, 403)
        Me.X10Y5.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y5.Name = "X10Y5"
        Me.X10Y5.Size = New System.Drawing.Size(32, 32)
        Me.X10Y5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y5.TabIndex = 653
        Me.X10Y5.TabStop = False
        '
        'X10Y7
        '
        Me.X10Y7.BackColor = System.Drawing.Color.Black
        Me.X10Y7.BackgroundImage = CType(resources.GetObject("X10Y7.BackgroundImage"), System.Drawing.Image)
        Me.X10Y7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y7.Image = CType(resources.GetObject("X10Y7.Image"), System.Drawing.Image)
        Me.X10Y7.Location = New System.Drawing.Point(305, 403)
        Me.X10Y7.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y7.Name = "X10Y7"
        Me.X10Y7.Size = New System.Drawing.Size(32, 32)
        Me.X10Y7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y7.TabIndex = 655
        Me.X10Y7.TabStop = False
        '
        'X10Y8
        '
        Me.X10Y8.BackColor = System.Drawing.Color.Black
        Me.X10Y8.BackgroundImage = CType(resources.GetObject("X10Y8.BackgroundImage"), System.Drawing.Image)
        Me.X10Y8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y8.Image = CType(resources.GetObject("X10Y8.Image"), System.Drawing.Image)
        Me.X10Y8.Location = New System.Drawing.Point(337, 403)
        Me.X10Y8.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y8.Name = "X10Y8"
        Me.X10Y8.Size = New System.Drawing.Size(32, 32)
        Me.X10Y8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y8.TabIndex = 656
        Me.X10Y8.TabStop = False
        '
        'X10Y9
        '
        Me.X10Y9.BackColor = System.Drawing.Color.Black
        Me.X10Y9.BackgroundImage = CType(resources.GetObject("X10Y9.BackgroundImage"), System.Drawing.Image)
        Me.X10Y9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y9.Image = CType(resources.GetObject("X10Y9.Image"), System.Drawing.Image)
        Me.X10Y9.Location = New System.Drawing.Point(369, 403)
        Me.X10Y9.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y9.Name = "X10Y9"
        Me.X10Y9.Size = New System.Drawing.Size(32, 32)
        Me.X10Y9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y9.TabIndex = 657
        Me.X10Y9.TabStop = False
        '
        'X10Y10
        '
        Me.X10Y10.BackColor = System.Drawing.Color.Black
        Me.X10Y10.BackgroundImage = CType(resources.GetObject("X10Y10.BackgroundImage"), System.Drawing.Image)
        Me.X10Y10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y10.Image = CType(resources.GetObject("X10Y10.Image"), System.Drawing.Image)
        Me.X10Y10.Location = New System.Drawing.Point(401, 403)
        Me.X10Y10.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y10.Name = "X10Y10"
        Me.X10Y10.Size = New System.Drawing.Size(32, 32)
        Me.X10Y10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y10.TabIndex = 658
        Me.X10Y10.TabStop = False
        '
        'X1Y11
        '
        Me.X1Y11.BackColor = System.Drawing.Color.Black
        Me.X1Y11.BackgroundImage = CType(resources.GetObject("X1Y11.BackgroundImage"), System.Drawing.Image)
        Me.X1Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y11.Image = CType(resources.GetObject("X1Y11.Image"), System.Drawing.Image)
        Me.X1Y11.Location = New System.Drawing.Point(433, 124)
        Me.X1Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y11.Name = "X1Y11"
        Me.X1Y11.Size = New System.Drawing.Size(32, 32)
        Me.X1Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y11.TabIndex = 659
        Me.X1Y11.TabStop = False
        '
        'X1Y12
        '
        Me.X1Y12.BackColor = System.Drawing.Color.Black
        Me.X1Y12.BackgroundImage = CType(resources.GetObject("X1Y12.BackgroundImage"), System.Drawing.Image)
        Me.X1Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y12.Image = CType(resources.GetObject("X1Y12.Image"), System.Drawing.Image)
        Me.X1Y12.Location = New System.Drawing.Point(465, 124)
        Me.X1Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y12.Name = "X1Y12"
        Me.X1Y12.Size = New System.Drawing.Size(32, 32)
        Me.X1Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y12.TabIndex = 660
        Me.X1Y12.TabStop = False
        '
        'X1Y13
        '
        Me.X1Y13.BackColor = System.Drawing.Color.Black
        Me.X1Y13.BackgroundImage = CType(resources.GetObject("X1Y13.BackgroundImage"), System.Drawing.Image)
        Me.X1Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y13.Image = CType(resources.GetObject("X1Y13.Image"), System.Drawing.Image)
        Me.X1Y13.Location = New System.Drawing.Point(497, 124)
        Me.X1Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y13.Name = "X1Y13"
        Me.X1Y13.Size = New System.Drawing.Size(32, 32)
        Me.X1Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y13.TabIndex = 661
        Me.X1Y13.TabStop = False
        '
        'X1Y14
        '
        Me.X1Y14.BackColor = System.Drawing.Color.Black
        Me.X1Y14.BackgroundImage = CType(resources.GetObject("X1Y14.BackgroundImage"), System.Drawing.Image)
        Me.X1Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y14.Image = CType(resources.GetObject("X1Y14.Image"), System.Drawing.Image)
        Me.X1Y14.Location = New System.Drawing.Point(529, 124)
        Me.X1Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y14.Name = "X1Y14"
        Me.X1Y14.Size = New System.Drawing.Size(32, 32)
        Me.X1Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y14.TabIndex = 662
        Me.X1Y14.TabStop = False
        '
        'X1Y15
        '
        Me.X1Y15.BackColor = System.Drawing.Color.Black
        Me.X1Y15.BackgroundImage = CType(resources.GetObject("X1Y15.BackgroundImage"), System.Drawing.Image)
        Me.X1Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y15.Image = CType(resources.GetObject("X1Y15.Image"), System.Drawing.Image)
        Me.X1Y15.Location = New System.Drawing.Point(561, 124)
        Me.X1Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y15.Name = "X1Y15"
        Me.X1Y15.Size = New System.Drawing.Size(32, 32)
        Me.X1Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y15.TabIndex = 663
        Me.X1Y15.TabStop = False
        '
        'X1Y16
        '
        Me.X1Y16.BackColor = System.Drawing.Color.Black
        Me.X1Y16.BackgroundImage = CType(resources.GetObject("X1Y16.BackgroundImage"), System.Drawing.Image)
        Me.X1Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y16.Image = CType(resources.GetObject("X1Y16.Image"), System.Drawing.Image)
        Me.X1Y16.Location = New System.Drawing.Point(593, 124)
        Me.X1Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y16.Name = "X1Y16"
        Me.X1Y16.Size = New System.Drawing.Size(32, 32)
        Me.X1Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y16.TabIndex = 664
        Me.X1Y16.TabStop = False
        '
        'X1Y17
        '
        Me.X1Y17.BackColor = System.Drawing.Color.Black
        Me.X1Y17.BackgroundImage = CType(resources.GetObject("X1Y17.BackgroundImage"), System.Drawing.Image)
        Me.X1Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y17.Image = CType(resources.GetObject("X1Y17.Image"), System.Drawing.Image)
        Me.X1Y17.Location = New System.Drawing.Point(625, 124)
        Me.X1Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y17.Name = "X1Y17"
        Me.X1Y17.Size = New System.Drawing.Size(32, 32)
        Me.X1Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y17.TabIndex = 665
        Me.X1Y17.TabStop = False
        '
        'X1Y18
        '
        Me.X1Y18.BackColor = System.Drawing.Color.Black
        Me.X1Y18.BackgroundImage = CType(resources.GetObject("X1Y18.BackgroundImage"), System.Drawing.Image)
        Me.X1Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y18.Image = CType(resources.GetObject("X1Y18.Image"), System.Drawing.Image)
        Me.X1Y18.Location = New System.Drawing.Point(657, 124)
        Me.X1Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y18.Name = "X1Y18"
        Me.X1Y18.Size = New System.Drawing.Size(32, 32)
        Me.X1Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y18.TabIndex = 666
        Me.X1Y18.TabStop = False
        '
        'X1Y19
        '
        Me.X1Y19.BackColor = System.Drawing.Color.Black
        Me.X1Y19.BackgroundImage = CType(resources.GetObject("X1Y19.BackgroundImage"), System.Drawing.Image)
        Me.X1Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y19.Image = CType(resources.GetObject("X1Y19.Image"), System.Drawing.Image)
        Me.X1Y19.Location = New System.Drawing.Point(689, 124)
        Me.X1Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y19.Name = "X1Y19"
        Me.X1Y19.Size = New System.Drawing.Size(32, 32)
        Me.X1Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y19.TabIndex = 667
        Me.X1Y19.TabStop = False
        '
        'X1Y20
        '
        Me.X1Y20.BackColor = System.Drawing.Color.Black
        Me.X1Y20.BackgroundImage = CType(resources.GetObject("X1Y20.BackgroundImage"), System.Drawing.Image)
        Me.X1Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X1Y20.Image = CType(resources.GetObject("X1Y20.Image"), System.Drawing.Image)
        Me.X1Y20.Location = New System.Drawing.Point(721, 124)
        Me.X1Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X1Y20.Name = "X1Y20"
        Me.X1Y20.Size = New System.Drawing.Size(32, 32)
        Me.X1Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X1Y20.TabIndex = 668
        Me.X1Y20.TabStop = False
        '
        'X2Y11
        '
        Me.X2Y11.BackColor = System.Drawing.Color.Black
        Me.X2Y11.BackgroundImage = CType(resources.GetObject("X2Y11.BackgroundImage"), System.Drawing.Image)
        Me.X2Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y11.Image = CType(resources.GetObject("X2Y11.Image"), System.Drawing.Image)
        Me.X2Y11.Location = New System.Drawing.Point(433, 155)
        Me.X2Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y11.Name = "X2Y11"
        Me.X2Y11.Size = New System.Drawing.Size(32, 32)
        Me.X2Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y11.TabIndex = 669
        Me.X2Y11.TabStop = False
        '
        'X2Y12
        '
        Me.X2Y12.BackColor = System.Drawing.Color.Black
        Me.X2Y12.BackgroundImage = CType(resources.GetObject("X2Y12.BackgroundImage"), System.Drawing.Image)
        Me.X2Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y12.Image = CType(resources.GetObject("X2Y12.Image"), System.Drawing.Image)
        Me.X2Y12.Location = New System.Drawing.Point(465, 155)
        Me.X2Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y12.Name = "X2Y12"
        Me.X2Y12.Size = New System.Drawing.Size(32, 32)
        Me.X2Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y12.TabIndex = 670
        Me.X2Y12.TabStop = False
        '
        'X2Y18
        '
        Me.X2Y18.BackColor = System.Drawing.Color.Black
        Me.X2Y18.BackgroundImage = CType(resources.GetObject("X2Y18.BackgroundImage"), System.Drawing.Image)
        Me.X2Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y18.Image = CType(resources.GetObject("X2Y18.Image"), System.Drawing.Image)
        Me.X2Y18.Location = New System.Drawing.Point(657, 155)
        Me.X2Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y18.Name = "X2Y18"
        Me.X2Y18.Size = New System.Drawing.Size(32, 32)
        Me.X2Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y18.TabIndex = 676
        Me.X2Y18.TabStop = False
        '
        'X2Y13
        '
        Me.X2Y13.BackColor = System.Drawing.Color.Black
        Me.X2Y13.BackgroundImage = CType(resources.GetObject("X2Y13.BackgroundImage"), System.Drawing.Image)
        Me.X2Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y13.Image = CType(resources.GetObject("X2Y13.Image"), System.Drawing.Image)
        Me.X2Y13.Location = New System.Drawing.Point(497, 155)
        Me.X2Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y13.Name = "X2Y13"
        Me.X2Y13.Size = New System.Drawing.Size(32, 32)
        Me.X2Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y13.TabIndex = 671
        Me.X2Y13.TabStop = False
        '
        'X2Y14
        '
        Me.X2Y14.BackColor = System.Drawing.Color.Black
        Me.X2Y14.BackgroundImage = CType(resources.GetObject("X2Y14.BackgroundImage"), System.Drawing.Image)
        Me.X2Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y14.Image = CType(resources.GetObject("X2Y14.Image"), System.Drawing.Image)
        Me.X2Y14.Location = New System.Drawing.Point(529, 155)
        Me.X2Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y14.Name = "X2Y14"
        Me.X2Y14.Size = New System.Drawing.Size(32, 32)
        Me.X2Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y14.TabIndex = 672
        Me.X2Y14.TabStop = False
        '
        'X2Y15
        '
        Me.X2Y15.BackColor = System.Drawing.Color.Black
        Me.X2Y15.BackgroundImage = CType(resources.GetObject("X2Y15.BackgroundImage"), System.Drawing.Image)
        Me.X2Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y15.Image = CType(resources.GetObject("X2Y15.Image"), System.Drawing.Image)
        Me.X2Y15.Location = New System.Drawing.Point(561, 155)
        Me.X2Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y15.Name = "X2Y15"
        Me.X2Y15.Size = New System.Drawing.Size(32, 32)
        Me.X2Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y15.TabIndex = 673
        Me.X2Y15.TabStop = False
        '
        'X2Y16
        '
        Me.X2Y16.BackColor = System.Drawing.Color.Black
        Me.X2Y16.BackgroundImage = CType(resources.GetObject("X2Y16.BackgroundImage"), System.Drawing.Image)
        Me.X2Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y16.Image = CType(resources.GetObject("X2Y16.Image"), System.Drawing.Image)
        Me.X2Y16.Location = New System.Drawing.Point(593, 155)
        Me.X2Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y16.Name = "X2Y16"
        Me.X2Y16.Size = New System.Drawing.Size(32, 32)
        Me.X2Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y16.TabIndex = 674
        Me.X2Y16.TabStop = False
        '
        'X2Y17
        '
        Me.X2Y17.BackColor = System.Drawing.Color.Black
        Me.X2Y17.BackgroundImage = CType(resources.GetObject("X2Y17.BackgroundImage"), System.Drawing.Image)
        Me.X2Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y17.Image = CType(resources.GetObject("X2Y17.Image"), System.Drawing.Image)
        Me.X2Y17.Location = New System.Drawing.Point(625, 155)
        Me.X2Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y17.Name = "X2Y17"
        Me.X2Y17.Size = New System.Drawing.Size(32, 32)
        Me.X2Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y17.TabIndex = 675
        Me.X2Y17.TabStop = False
        '
        'X2Y19
        '
        Me.X2Y19.BackColor = System.Drawing.Color.Black
        Me.X2Y19.BackgroundImage = CType(resources.GetObject("X2Y19.BackgroundImage"), System.Drawing.Image)
        Me.X2Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y19.Image = CType(resources.GetObject("X2Y19.Image"), System.Drawing.Image)
        Me.X2Y19.Location = New System.Drawing.Point(689, 155)
        Me.X2Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y19.Name = "X2Y19"
        Me.X2Y19.Size = New System.Drawing.Size(32, 32)
        Me.X2Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y19.TabIndex = 677
        Me.X2Y19.TabStop = False
        '
        'X2Y20
        '
        Me.X2Y20.BackColor = System.Drawing.Color.Black
        Me.X2Y20.BackgroundImage = CType(resources.GetObject("X2Y20.BackgroundImage"), System.Drawing.Image)
        Me.X2Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X2Y20.Image = CType(resources.GetObject("X2Y20.Image"), System.Drawing.Image)
        Me.X2Y20.Location = New System.Drawing.Point(721, 155)
        Me.X2Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X2Y20.Name = "X2Y20"
        Me.X2Y20.Size = New System.Drawing.Size(32, 32)
        Me.X2Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X2Y20.TabIndex = 678
        Me.X2Y20.TabStop = False
        '
        'X3Y16
        '
        Me.X3Y16.BackColor = System.Drawing.Color.Black
        Me.X3Y16.BackgroundImage = CType(resources.GetObject("X3Y16.BackgroundImage"), System.Drawing.Image)
        Me.X3Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y16.Image = CType(resources.GetObject("X3Y16.Image"), System.Drawing.Image)
        Me.X3Y16.Location = New System.Drawing.Point(593, 186)
        Me.X3Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y16.Name = "X3Y16"
        Me.X3Y16.Size = New System.Drawing.Size(32, 32)
        Me.X3Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y16.TabIndex = 684
        Me.X3Y16.TabStop = False
        '
        'X3Y11
        '
        Me.X3Y11.BackColor = System.Drawing.Color.Black
        Me.X3Y11.BackgroundImage = CType(resources.GetObject("X3Y11.BackgroundImage"), System.Drawing.Image)
        Me.X3Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y11.Image = CType(resources.GetObject("X3Y11.Image"), System.Drawing.Image)
        Me.X3Y11.Location = New System.Drawing.Point(433, 186)
        Me.X3Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y11.Name = "X3Y11"
        Me.X3Y11.Size = New System.Drawing.Size(32, 32)
        Me.X3Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y11.TabIndex = 679
        Me.X3Y11.TabStop = False
        '
        'X3Y12
        '
        Me.X3Y12.BackColor = System.Drawing.Color.Black
        Me.X3Y12.BackgroundImage = CType(resources.GetObject("X3Y12.BackgroundImage"), System.Drawing.Image)
        Me.X3Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y12.Image = CType(resources.GetObject("X3Y12.Image"), System.Drawing.Image)
        Me.X3Y12.Location = New System.Drawing.Point(465, 186)
        Me.X3Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y12.Name = "X3Y12"
        Me.X3Y12.Size = New System.Drawing.Size(32, 32)
        Me.X3Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y12.TabIndex = 680
        Me.X3Y12.TabStop = False
        '
        'X3Y13
        '
        Me.X3Y13.BackColor = System.Drawing.Color.Black
        Me.X3Y13.BackgroundImage = CType(resources.GetObject("X3Y13.BackgroundImage"), System.Drawing.Image)
        Me.X3Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y13.Image = CType(resources.GetObject("X3Y13.Image"), System.Drawing.Image)
        Me.X3Y13.Location = New System.Drawing.Point(497, 186)
        Me.X3Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y13.Name = "X3Y13"
        Me.X3Y13.Size = New System.Drawing.Size(32, 32)
        Me.X3Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y13.TabIndex = 681
        Me.X3Y13.TabStop = False
        '
        'X3Y14
        '
        Me.X3Y14.BackColor = System.Drawing.Color.Black
        Me.X3Y14.BackgroundImage = CType(resources.GetObject("X3Y14.BackgroundImage"), System.Drawing.Image)
        Me.X3Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y14.Image = CType(resources.GetObject("X3Y14.Image"), System.Drawing.Image)
        Me.X3Y14.Location = New System.Drawing.Point(529, 186)
        Me.X3Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y14.Name = "X3Y14"
        Me.X3Y14.Size = New System.Drawing.Size(32, 32)
        Me.X3Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y14.TabIndex = 682
        Me.X3Y14.TabStop = False
        '
        'X3Y15
        '
        Me.X3Y15.BackColor = System.Drawing.Color.Black
        Me.X3Y15.BackgroundImage = CType(resources.GetObject("X3Y15.BackgroundImage"), System.Drawing.Image)
        Me.X3Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y15.Image = CType(resources.GetObject("X3Y15.Image"), System.Drawing.Image)
        Me.X3Y15.Location = New System.Drawing.Point(561, 186)
        Me.X3Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y15.Name = "X3Y15"
        Me.X3Y15.Size = New System.Drawing.Size(32, 32)
        Me.X3Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y15.TabIndex = 683
        Me.X3Y15.TabStop = False
        '
        'X3Y17
        '
        Me.X3Y17.BackColor = System.Drawing.Color.Black
        Me.X3Y17.BackgroundImage = CType(resources.GetObject("X3Y17.BackgroundImage"), System.Drawing.Image)
        Me.X3Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y17.Image = CType(resources.GetObject("X3Y17.Image"), System.Drawing.Image)
        Me.X3Y17.Location = New System.Drawing.Point(625, 186)
        Me.X3Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y17.Name = "X3Y17"
        Me.X3Y17.Size = New System.Drawing.Size(32, 32)
        Me.X3Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y17.TabIndex = 685
        Me.X3Y17.TabStop = False
        '
        'X3Y18
        '
        Me.X3Y18.BackColor = System.Drawing.Color.Black
        Me.X3Y18.BackgroundImage = CType(resources.GetObject("X3Y18.BackgroundImage"), System.Drawing.Image)
        Me.X3Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y18.Image = CType(resources.GetObject("X3Y18.Image"), System.Drawing.Image)
        Me.X3Y18.Location = New System.Drawing.Point(657, 186)
        Me.X3Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y18.Name = "X3Y18"
        Me.X3Y18.Size = New System.Drawing.Size(32, 32)
        Me.X3Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y18.TabIndex = 686
        Me.X3Y18.TabStop = False
        '
        'X3Y19
        '
        Me.X3Y19.BackColor = System.Drawing.Color.Black
        Me.X3Y19.BackgroundImage = CType(resources.GetObject("X3Y19.BackgroundImage"), System.Drawing.Image)
        Me.X3Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y19.Image = CType(resources.GetObject("X3Y19.Image"), System.Drawing.Image)
        Me.X3Y19.Location = New System.Drawing.Point(689, 186)
        Me.X3Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y19.Name = "X3Y19"
        Me.X3Y19.Size = New System.Drawing.Size(32, 32)
        Me.X3Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y19.TabIndex = 687
        Me.X3Y19.TabStop = False
        '
        'X3Y20
        '
        Me.X3Y20.BackColor = System.Drawing.Color.Black
        Me.X3Y20.BackgroundImage = CType(resources.GetObject("X3Y20.BackgroundImage"), System.Drawing.Image)
        Me.X3Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X3Y20.Image = CType(resources.GetObject("X3Y20.Image"), System.Drawing.Image)
        Me.X3Y20.Location = New System.Drawing.Point(721, 186)
        Me.X3Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X3Y20.Name = "X3Y20"
        Me.X3Y20.Size = New System.Drawing.Size(32, 32)
        Me.X3Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X3Y20.TabIndex = 688
        Me.X3Y20.TabStop = False
        '
        'X4Y11
        '
        Me.X4Y11.BackColor = System.Drawing.Color.Black
        Me.X4Y11.BackgroundImage = CType(resources.GetObject("X4Y11.BackgroundImage"), System.Drawing.Image)
        Me.X4Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y11.Image = CType(resources.GetObject("X4Y11.Image"), System.Drawing.Image)
        Me.X4Y11.Location = New System.Drawing.Point(433, 217)
        Me.X4Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y11.Name = "X4Y11"
        Me.X4Y11.Size = New System.Drawing.Size(32, 32)
        Me.X4Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y11.TabIndex = 689
        Me.X4Y11.TabStop = False
        '
        'X4Y12
        '
        Me.X4Y12.BackColor = System.Drawing.Color.Black
        Me.X4Y12.BackgroundImage = CType(resources.GetObject("X4Y12.BackgroundImage"), System.Drawing.Image)
        Me.X4Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y12.Image = CType(resources.GetObject("X4Y12.Image"), System.Drawing.Image)
        Me.X4Y12.Location = New System.Drawing.Point(465, 217)
        Me.X4Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y12.Name = "X4Y12"
        Me.X4Y12.Size = New System.Drawing.Size(32, 32)
        Me.X4Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y12.TabIndex = 690
        Me.X4Y12.TabStop = False
        '
        'X4Y13
        '
        Me.X4Y13.BackColor = System.Drawing.Color.Black
        Me.X4Y13.BackgroundImage = CType(resources.GetObject("X4Y13.BackgroundImage"), System.Drawing.Image)
        Me.X4Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y13.Image = CType(resources.GetObject("X4Y13.Image"), System.Drawing.Image)
        Me.X4Y13.Location = New System.Drawing.Point(497, 217)
        Me.X4Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y13.Name = "X4Y13"
        Me.X4Y13.Size = New System.Drawing.Size(32, 32)
        Me.X4Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y13.TabIndex = 691
        Me.X4Y13.TabStop = False
        '
        'X4Y14
        '
        Me.X4Y14.AccessibleDescription = "X4Y14"
        Me.X4Y14.BackColor = System.Drawing.Color.Black
        Me.X4Y14.BackgroundImage = CType(resources.GetObject("X4Y14.BackgroundImage"), System.Drawing.Image)
        Me.X4Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y14.Image = CType(resources.GetObject("X4Y14.Image"), System.Drawing.Image)
        Me.X4Y14.Location = New System.Drawing.Point(529, 217)
        Me.X4Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y14.Name = "X4Y14"
        Me.X4Y14.Size = New System.Drawing.Size(32, 32)
        Me.X4Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y14.TabIndex = 692
        Me.X4Y14.TabStop = False
        '
        'X4Y15
        '
        Me.X4Y15.BackColor = System.Drawing.Color.Black
        Me.X4Y15.BackgroundImage = CType(resources.GetObject("X4Y15.BackgroundImage"), System.Drawing.Image)
        Me.X4Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y15.Image = CType(resources.GetObject("X4Y15.Image"), System.Drawing.Image)
        Me.X4Y15.Location = New System.Drawing.Point(561, 217)
        Me.X4Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y15.Name = "X4Y15"
        Me.X4Y15.Size = New System.Drawing.Size(32, 32)
        Me.X4Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y15.TabIndex = 693
        Me.X4Y15.TabStop = False
        '
        'X4Y16
        '
        Me.X4Y16.BackColor = System.Drawing.Color.Black
        Me.X4Y16.BackgroundImage = CType(resources.GetObject("X4Y16.BackgroundImage"), System.Drawing.Image)
        Me.X4Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y16.Image = CType(resources.GetObject("X4Y16.Image"), System.Drawing.Image)
        Me.X4Y16.Location = New System.Drawing.Point(593, 217)
        Me.X4Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y16.Name = "X4Y16"
        Me.X4Y16.Size = New System.Drawing.Size(32, 32)
        Me.X4Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y16.TabIndex = 694
        Me.X4Y16.TabStop = False
        '
        'X4Y17
        '
        Me.X4Y17.BackColor = System.Drawing.Color.Black
        Me.X4Y17.BackgroundImage = CType(resources.GetObject("X4Y17.BackgroundImage"), System.Drawing.Image)
        Me.X4Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y17.Image = CType(resources.GetObject("X4Y17.Image"), System.Drawing.Image)
        Me.X4Y17.Location = New System.Drawing.Point(625, 217)
        Me.X4Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y17.Name = "X4Y17"
        Me.X4Y17.Size = New System.Drawing.Size(32, 32)
        Me.X4Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y17.TabIndex = 695
        Me.X4Y17.TabStop = False
        '
        'X4Y18
        '
        Me.X4Y18.BackColor = System.Drawing.Color.Black
        Me.X4Y18.BackgroundImage = CType(resources.GetObject("X4Y18.BackgroundImage"), System.Drawing.Image)
        Me.X4Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y18.Image = CType(resources.GetObject("X4Y18.Image"), System.Drawing.Image)
        Me.X4Y18.Location = New System.Drawing.Point(657, 217)
        Me.X4Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y18.Name = "X4Y18"
        Me.X4Y18.Size = New System.Drawing.Size(32, 32)
        Me.X4Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y18.TabIndex = 696
        Me.X4Y18.TabStop = False
        '
        'X4Y19
        '
        Me.X4Y19.BackColor = System.Drawing.Color.Black
        Me.X4Y19.BackgroundImage = CType(resources.GetObject("X4Y19.BackgroundImage"), System.Drawing.Image)
        Me.X4Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y19.Image = CType(resources.GetObject("X4Y19.Image"), System.Drawing.Image)
        Me.X4Y19.Location = New System.Drawing.Point(689, 217)
        Me.X4Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y19.Name = "X4Y19"
        Me.X4Y19.Size = New System.Drawing.Size(32, 32)
        Me.X4Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y19.TabIndex = 697
        Me.X4Y19.TabStop = False
        '
        'X4Y20
        '
        Me.X4Y20.BackColor = System.Drawing.Color.Black
        Me.X4Y20.BackgroundImage = CType(resources.GetObject("X4Y20.BackgroundImage"), System.Drawing.Image)
        Me.X4Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X4Y20.Image = CType(resources.GetObject("X4Y20.Image"), System.Drawing.Image)
        Me.X4Y20.Location = New System.Drawing.Point(721, 217)
        Me.X4Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X4Y20.Name = "X4Y20"
        Me.X4Y20.Size = New System.Drawing.Size(32, 32)
        Me.X4Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X4Y20.TabIndex = 698
        Me.X4Y20.TabStop = False
        '
        'X5Y16
        '
        Me.X5Y16.BackColor = System.Drawing.Color.Black
        Me.X5Y16.BackgroundImage = CType(resources.GetObject("X5Y16.BackgroundImage"), System.Drawing.Image)
        Me.X5Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y16.Image = CType(resources.GetObject("X5Y16.Image"), System.Drawing.Image)
        Me.X5Y16.Location = New System.Drawing.Point(593, 248)
        Me.X5Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y16.Name = "X5Y16"
        Me.X5Y16.Size = New System.Drawing.Size(32, 32)
        Me.X5Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y16.TabIndex = 704
        Me.X5Y16.TabStop = False
        '
        'X5Y11
        '
        Me.X5Y11.BackColor = System.Drawing.Color.Black
        Me.X5Y11.BackgroundImage = CType(resources.GetObject("X5Y11.BackgroundImage"), System.Drawing.Image)
        Me.X5Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y11.Image = CType(resources.GetObject("X5Y11.Image"), System.Drawing.Image)
        Me.X5Y11.Location = New System.Drawing.Point(433, 248)
        Me.X5Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y11.Name = "X5Y11"
        Me.X5Y11.Size = New System.Drawing.Size(32, 32)
        Me.X5Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y11.TabIndex = 699
        Me.X5Y11.TabStop = False
        '
        'X5Y12
        '
        Me.X5Y12.BackColor = System.Drawing.Color.Black
        Me.X5Y12.BackgroundImage = CType(resources.GetObject("X5Y12.BackgroundImage"), System.Drawing.Image)
        Me.X5Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y12.Image = CType(resources.GetObject("X5Y12.Image"), System.Drawing.Image)
        Me.X5Y12.Location = New System.Drawing.Point(465, 248)
        Me.X5Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y12.Name = "X5Y12"
        Me.X5Y12.Size = New System.Drawing.Size(32, 32)
        Me.X5Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y12.TabIndex = 700
        Me.X5Y12.TabStop = False
        '
        'X5Y13
        '
        Me.X5Y13.BackColor = System.Drawing.Color.Black
        Me.X5Y13.BackgroundImage = CType(resources.GetObject("X5Y13.BackgroundImage"), System.Drawing.Image)
        Me.X5Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y13.Image = CType(resources.GetObject("X5Y13.Image"), System.Drawing.Image)
        Me.X5Y13.Location = New System.Drawing.Point(497, 248)
        Me.X5Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y13.Name = "X5Y13"
        Me.X5Y13.Size = New System.Drawing.Size(32, 32)
        Me.X5Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y13.TabIndex = 701
        Me.X5Y13.TabStop = False
        '
        'X5Y14
        '
        Me.X5Y14.BackColor = System.Drawing.Color.Black
        Me.X5Y14.BackgroundImage = CType(resources.GetObject("X5Y14.BackgroundImage"), System.Drawing.Image)
        Me.X5Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y14.Image = CType(resources.GetObject("X5Y14.Image"), System.Drawing.Image)
        Me.X5Y14.Location = New System.Drawing.Point(529, 248)
        Me.X5Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y14.Name = "X5Y14"
        Me.X5Y14.Size = New System.Drawing.Size(32, 32)
        Me.X5Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y14.TabIndex = 702
        Me.X5Y14.TabStop = False
        '
        'X5Y15
        '
        Me.X5Y15.BackColor = System.Drawing.Color.Black
        Me.X5Y15.BackgroundImage = CType(resources.GetObject("X5Y15.BackgroundImage"), System.Drawing.Image)
        Me.X5Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y15.Image = CType(resources.GetObject("X5Y15.Image"), System.Drawing.Image)
        Me.X5Y15.Location = New System.Drawing.Point(561, 248)
        Me.X5Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y15.Name = "X5Y15"
        Me.X5Y15.Size = New System.Drawing.Size(32, 32)
        Me.X5Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y15.TabIndex = 703
        Me.X5Y15.TabStop = False
        '
        'X5Y17
        '
        Me.X5Y17.BackColor = System.Drawing.Color.Black
        Me.X5Y17.BackgroundImage = CType(resources.GetObject("X5Y17.BackgroundImage"), System.Drawing.Image)
        Me.X5Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y17.Image = CType(resources.GetObject("X5Y17.Image"), System.Drawing.Image)
        Me.X5Y17.Location = New System.Drawing.Point(625, 248)
        Me.X5Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y17.Name = "X5Y17"
        Me.X5Y17.Size = New System.Drawing.Size(32, 32)
        Me.X5Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y17.TabIndex = 705
        Me.X5Y17.TabStop = False
        '
        'X5Y18
        '
        Me.X5Y18.BackColor = System.Drawing.Color.Black
        Me.X5Y18.BackgroundImage = CType(resources.GetObject("X5Y18.BackgroundImage"), System.Drawing.Image)
        Me.X5Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y18.Image = CType(resources.GetObject("X5Y18.Image"), System.Drawing.Image)
        Me.X5Y18.Location = New System.Drawing.Point(657, 248)
        Me.X5Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y18.Name = "X5Y18"
        Me.X5Y18.Size = New System.Drawing.Size(32, 32)
        Me.X5Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y18.TabIndex = 706
        Me.X5Y18.TabStop = False
        '
        'X5Y19
        '
        Me.X5Y19.BackColor = System.Drawing.Color.Black
        Me.X5Y19.BackgroundImage = CType(resources.GetObject("X5Y19.BackgroundImage"), System.Drawing.Image)
        Me.X5Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y19.Image = CType(resources.GetObject("X5Y19.Image"), System.Drawing.Image)
        Me.X5Y19.Location = New System.Drawing.Point(689, 248)
        Me.X5Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y19.Name = "X5Y19"
        Me.X5Y19.Size = New System.Drawing.Size(32, 32)
        Me.X5Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y19.TabIndex = 707
        Me.X5Y19.TabStop = False
        '
        'X5Y20
        '
        Me.X5Y20.BackColor = System.Drawing.Color.Black
        Me.X5Y20.BackgroundImage = CType(resources.GetObject("X5Y20.BackgroundImage"), System.Drawing.Image)
        Me.X5Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X5Y20.Image = CType(resources.GetObject("X5Y20.Image"), System.Drawing.Image)
        Me.X5Y20.Location = New System.Drawing.Point(721, 248)
        Me.X5Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X5Y20.Name = "X5Y20"
        Me.X5Y20.Size = New System.Drawing.Size(32, 32)
        Me.X5Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X5Y20.TabIndex = 708
        Me.X5Y20.TabStop = False
        '
        'X6Y16
        '
        Me.X6Y16.BackColor = System.Drawing.Color.Black
        Me.X6Y16.BackgroundImage = CType(resources.GetObject("X6Y16.BackgroundImage"), System.Drawing.Image)
        Me.X6Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y16.Image = CType(resources.GetObject("X6Y16.Image"), System.Drawing.Image)
        Me.X6Y16.Location = New System.Drawing.Point(593, 279)
        Me.X6Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y16.Name = "X6Y16"
        Me.X6Y16.Size = New System.Drawing.Size(32, 32)
        Me.X6Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y16.TabIndex = 714
        Me.X6Y16.TabStop = False
        '
        'X6Y11
        '
        Me.X6Y11.BackColor = System.Drawing.Color.Black
        Me.X6Y11.BackgroundImage = CType(resources.GetObject("X6Y11.BackgroundImage"), System.Drawing.Image)
        Me.X6Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y11.Image = CType(resources.GetObject("X6Y11.Image"), System.Drawing.Image)
        Me.X6Y11.Location = New System.Drawing.Point(433, 279)
        Me.X6Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y11.Name = "X6Y11"
        Me.X6Y11.Size = New System.Drawing.Size(32, 32)
        Me.X6Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y11.TabIndex = 709
        Me.X6Y11.TabStop = False
        '
        'X6Y12
        '
        Me.X6Y12.BackColor = System.Drawing.Color.Black
        Me.X6Y12.BackgroundImage = CType(resources.GetObject("X6Y12.BackgroundImage"), System.Drawing.Image)
        Me.X6Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y12.Image = CType(resources.GetObject("X6Y12.Image"), System.Drawing.Image)
        Me.X6Y12.Location = New System.Drawing.Point(465, 279)
        Me.X6Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y12.Name = "X6Y12"
        Me.X6Y12.Size = New System.Drawing.Size(32, 32)
        Me.X6Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y12.TabIndex = 710
        Me.X6Y12.TabStop = False
        '
        'X6Y13
        '
        Me.X6Y13.BackColor = System.Drawing.Color.Black
        Me.X6Y13.BackgroundImage = CType(resources.GetObject("X6Y13.BackgroundImage"), System.Drawing.Image)
        Me.X6Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y13.Image = CType(resources.GetObject("X6Y13.Image"), System.Drawing.Image)
        Me.X6Y13.Location = New System.Drawing.Point(497, 279)
        Me.X6Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y13.Name = "X6Y13"
        Me.X6Y13.Size = New System.Drawing.Size(32, 32)
        Me.X6Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y13.TabIndex = 711
        Me.X6Y13.TabStop = False
        '
        'X6Y14
        '
        Me.X6Y14.BackColor = System.Drawing.Color.Black
        Me.X6Y14.BackgroundImage = CType(resources.GetObject("X6Y14.BackgroundImage"), System.Drawing.Image)
        Me.X6Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y14.Image = CType(resources.GetObject("X6Y14.Image"), System.Drawing.Image)
        Me.X6Y14.Location = New System.Drawing.Point(529, 279)
        Me.X6Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y14.Name = "X6Y14"
        Me.X6Y14.Size = New System.Drawing.Size(32, 32)
        Me.X6Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y14.TabIndex = 712
        Me.X6Y14.TabStop = False
        '
        'X6Y15
        '
        Me.X6Y15.BackColor = System.Drawing.Color.Black
        Me.X6Y15.BackgroundImage = CType(resources.GetObject("X6Y15.BackgroundImage"), System.Drawing.Image)
        Me.X6Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y15.Image = CType(resources.GetObject("X6Y15.Image"), System.Drawing.Image)
        Me.X6Y15.Location = New System.Drawing.Point(561, 279)
        Me.X6Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y15.Name = "X6Y15"
        Me.X6Y15.Size = New System.Drawing.Size(32, 32)
        Me.X6Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y15.TabIndex = 713
        Me.X6Y15.TabStop = False
        '
        'X6Y17
        '
        Me.X6Y17.BackColor = System.Drawing.Color.Black
        Me.X6Y17.BackgroundImage = CType(resources.GetObject("X6Y17.BackgroundImage"), System.Drawing.Image)
        Me.X6Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y17.Image = CType(resources.GetObject("X6Y17.Image"), System.Drawing.Image)
        Me.X6Y17.Location = New System.Drawing.Point(625, 279)
        Me.X6Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y17.Name = "X6Y17"
        Me.X6Y17.Size = New System.Drawing.Size(32, 32)
        Me.X6Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y17.TabIndex = 715
        Me.X6Y17.TabStop = False
        '
        'X6Y18
        '
        Me.X6Y18.BackColor = System.Drawing.Color.Black
        Me.X6Y18.BackgroundImage = CType(resources.GetObject("X6Y18.BackgroundImage"), System.Drawing.Image)
        Me.X6Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y18.Image = CType(resources.GetObject("X6Y18.Image"), System.Drawing.Image)
        Me.X6Y18.Location = New System.Drawing.Point(657, 279)
        Me.X6Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y18.Name = "X6Y18"
        Me.X6Y18.Size = New System.Drawing.Size(32, 32)
        Me.X6Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y18.TabIndex = 716
        Me.X6Y18.TabStop = False
        '
        'X6Y19
        '
        Me.X6Y19.BackColor = System.Drawing.Color.Black
        Me.X6Y19.BackgroundImage = CType(resources.GetObject("X6Y19.BackgroundImage"), System.Drawing.Image)
        Me.X6Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y19.Image = CType(resources.GetObject("X6Y19.Image"), System.Drawing.Image)
        Me.X6Y19.Location = New System.Drawing.Point(689, 279)
        Me.X6Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y19.Name = "X6Y19"
        Me.X6Y19.Size = New System.Drawing.Size(32, 32)
        Me.X6Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y19.TabIndex = 717
        Me.X6Y19.TabStop = False
        '
        'X6Y20
        '
        Me.X6Y20.BackColor = System.Drawing.Color.Black
        Me.X6Y20.BackgroundImage = CType(resources.GetObject("X6Y20.BackgroundImage"), System.Drawing.Image)
        Me.X6Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X6Y20.Image = CType(resources.GetObject("X6Y20.Image"), System.Drawing.Image)
        Me.X6Y20.Location = New System.Drawing.Point(721, 279)
        Me.X6Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X6Y20.Name = "X6Y20"
        Me.X6Y20.Size = New System.Drawing.Size(32, 32)
        Me.X6Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X6Y20.TabIndex = 718
        Me.X6Y20.TabStop = False
        '
        'X7Y16
        '
        Me.X7Y16.BackColor = System.Drawing.Color.Black
        Me.X7Y16.BackgroundImage = CType(resources.GetObject("X7Y16.BackgroundImage"), System.Drawing.Image)
        Me.X7Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y16.Image = CType(resources.GetObject("X7Y16.Image"), System.Drawing.Image)
        Me.X7Y16.Location = New System.Drawing.Point(593, 310)
        Me.X7Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y16.Name = "X7Y16"
        Me.X7Y16.Size = New System.Drawing.Size(32, 32)
        Me.X7Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y16.TabIndex = 724
        Me.X7Y16.TabStop = False
        '
        'X7Y11
        '
        Me.X7Y11.BackColor = System.Drawing.Color.Black
        Me.X7Y11.BackgroundImage = CType(resources.GetObject("X7Y11.BackgroundImage"), System.Drawing.Image)
        Me.X7Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y11.Image = CType(resources.GetObject("X7Y11.Image"), System.Drawing.Image)
        Me.X7Y11.Location = New System.Drawing.Point(433, 310)
        Me.X7Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y11.Name = "X7Y11"
        Me.X7Y11.Size = New System.Drawing.Size(32, 32)
        Me.X7Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y11.TabIndex = 719
        Me.X7Y11.TabStop = False
        '
        'X7Y12
        '
        Me.X7Y12.BackColor = System.Drawing.Color.Black
        Me.X7Y12.BackgroundImage = CType(resources.GetObject("X7Y12.BackgroundImage"), System.Drawing.Image)
        Me.X7Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y12.Image = CType(resources.GetObject("X7Y12.Image"), System.Drawing.Image)
        Me.X7Y12.Location = New System.Drawing.Point(465, 310)
        Me.X7Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y12.Name = "X7Y12"
        Me.X7Y12.Size = New System.Drawing.Size(32, 32)
        Me.X7Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y12.TabIndex = 720
        Me.X7Y12.TabStop = False
        '
        'X7Y13
        '
        Me.X7Y13.BackColor = System.Drawing.Color.Black
        Me.X7Y13.BackgroundImage = CType(resources.GetObject("X7Y13.BackgroundImage"), System.Drawing.Image)
        Me.X7Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y13.Image = CType(resources.GetObject("X7Y13.Image"), System.Drawing.Image)
        Me.X7Y13.Location = New System.Drawing.Point(497, 310)
        Me.X7Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y13.Name = "X7Y13"
        Me.X7Y13.Size = New System.Drawing.Size(32, 32)
        Me.X7Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y13.TabIndex = 721
        Me.X7Y13.TabStop = False
        '
        'X7Y14
        '
        Me.X7Y14.BackColor = System.Drawing.Color.Black
        Me.X7Y14.BackgroundImage = CType(resources.GetObject("X7Y14.BackgroundImage"), System.Drawing.Image)
        Me.X7Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y14.Image = CType(resources.GetObject("X7Y14.Image"), System.Drawing.Image)
        Me.X7Y14.Location = New System.Drawing.Point(529, 310)
        Me.X7Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y14.Name = "X7Y14"
        Me.X7Y14.Size = New System.Drawing.Size(32, 32)
        Me.X7Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y14.TabIndex = 722
        Me.X7Y14.TabStop = False
        '
        'X7Y15
        '
        Me.X7Y15.BackColor = System.Drawing.Color.Black
        Me.X7Y15.BackgroundImage = CType(resources.GetObject("X7Y15.BackgroundImage"), System.Drawing.Image)
        Me.X7Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y15.Image = CType(resources.GetObject("X7Y15.Image"), System.Drawing.Image)
        Me.X7Y15.Location = New System.Drawing.Point(561, 310)
        Me.X7Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y15.Name = "X7Y15"
        Me.X7Y15.Size = New System.Drawing.Size(32, 32)
        Me.X7Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y15.TabIndex = 723
        Me.X7Y15.TabStop = False
        '
        'X7Y17
        '
        Me.X7Y17.BackColor = System.Drawing.Color.Black
        Me.X7Y17.BackgroundImage = CType(resources.GetObject("X7Y17.BackgroundImage"), System.Drawing.Image)
        Me.X7Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y17.Image = CType(resources.GetObject("X7Y17.Image"), System.Drawing.Image)
        Me.X7Y17.Location = New System.Drawing.Point(625, 310)
        Me.X7Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y17.Name = "X7Y17"
        Me.X7Y17.Size = New System.Drawing.Size(32, 32)
        Me.X7Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y17.TabIndex = 725
        Me.X7Y17.TabStop = False
        '
        'X7Y18
        '
        Me.X7Y18.BackColor = System.Drawing.Color.Black
        Me.X7Y18.BackgroundImage = CType(resources.GetObject("X7Y18.BackgroundImage"), System.Drawing.Image)
        Me.X7Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y18.Image = CType(resources.GetObject("X7Y18.Image"), System.Drawing.Image)
        Me.X7Y18.Location = New System.Drawing.Point(657, 310)
        Me.X7Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y18.Name = "X7Y18"
        Me.X7Y18.Size = New System.Drawing.Size(32, 32)
        Me.X7Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y18.TabIndex = 726
        Me.X7Y18.TabStop = False
        '
        'X7Y19
        '
        Me.X7Y19.BackColor = System.Drawing.Color.Black
        Me.X7Y19.BackgroundImage = CType(resources.GetObject("X7Y19.BackgroundImage"), System.Drawing.Image)
        Me.X7Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y19.Image = CType(resources.GetObject("X7Y19.Image"), System.Drawing.Image)
        Me.X7Y19.Location = New System.Drawing.Point(689, 310)
        Me.X7Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y19.Name = "X7Y19"
        Me.X7Y19.Size = New System.Drawing.Size(32, 32)
        Me.X7Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y19.TabIndex = 727
        Me.X7Y19.TabStop = False
        '
        'X7Y20
        '
        Me.X7Y20.BackColor = System.Drawing.Color.Black
        Me.X7Y20.BackgroundImage = CType(resources.GetObject("X7Y20.BackgroundImage"), System.Drawing.Image)
        Me.X7Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X7Y20.Image = CType(resources.GetObject("X7Y20.Image"), System.Drawing.Image)
        Me.X7Y20.Location = New System.Drawing.Point(721, 310)
        Me.X7Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X7Y20.Name = "X7Y20"
        Me.X7Y20.Size = New System.Drawing.Size(32, 32)
        Me.X7Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X7Y20.TabIndex = 728
        Me.X7Y20.TabStop = False
        '
        'X8Y16
        '
        Me.X8Y16.BackColor = System.Drawing.Color.Black
        Me.X8Y16.BackgroundImage = CType(resources.GetObject("X8Y16.BackgroundImage"), System.Drawing.Image)
        Me.X8Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y16.Image = CType(resources.GetObject("X8Y16.Image"), System.Drawing.Image)
        Me.X8Y16.Location = New System.Drawing.Point(593, 341)
        Me.X8Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y16.Name = "X8Y16"
        Me.X8Y16.Size = New System.Drawing.Size(32, 32)
        Me.X8Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y16.TabIndex = 734
        Me.X8Y16.TabStop = False
        '
        'X8Y11
        '
        Me.X8Y11.BackColor = System.Drawing.Color.Black
        Me.X8Y11.BackgroundImage = CType(resources.GetObject("X8Y11.BackgroundImage"), System.Drawing.Image)
        Me.X8Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y11.Image = CType(resources.GetObject("X8Y11.Image"), System.Drawing.Image)
        Me.X8Y11.Location = New System.Drawing.Point(433, 341)
        Me.X8Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y11.Name = "X8Y11"
        Me.X8Y11.Size = New System.Drawing.Size(32, 32)
        Me.X8Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y11.TabIndex = 729
        Me.X8Y11.TabStop = False
        '
        'X8Y12
        '
        Me.X8Y12.BackColor = System.Drawing.Color.Black
        Me.X8Y12.BackgroundImage = CType(resources.GetObject("X8Y12.BackgroundImage"), System.Drawing.Image)
        Me.X8Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y12.Image = CType(resources.GetObject("X8Y12.Image"), System.Drawing.Image)
        Me.X8Y12.Location = New System.Drawing.Point(465, 341)
        Me.X8Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y12.Name = "X8Y12"
        Me.X8Y12.Size = New System.Drawing.Size(32, 32)
        Me.X8Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y12.TabIndex = 730
        Me.X8Y12.TabStop = False
        '
        'X8Y13
        '
        Me.X8Y13.BackColor = System.Drawing.Color.Black
        Me.X8Y13.BackgroundImage = CType(resources.GetObject("X8Y13.BackgroundImage"), System.Drawing.Image)
        Me.X8Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y13.Image = CType(resources.GetObject("X8Y13.Image"), System.Drawing.Image)
        Me.X8Y13.Location = New System.Drawing.Point(497, 341)
        Me.X8Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y13.Name = "X8Y13"
        Me.X8Y13.Size = New System.Drawing.Size(32, 32)
        Me.X8Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y13.TabIndex = 731
        Me.X8Y13.TabStop = False
        '
        'X8Y14
        '
        Me.X8Y14.BackColor = System.Drawing.Color.Black
        Me.X8Y14.BackgroundImage = CType(resources.GetObject("X8Y14.BackgroundImage"), System.Drawing.Image)
        Me.X8Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y14.Image = CType(resources.GetObject("X8Y14.Image"), System.Drawing.Image)
        Me.X8Y14.Location = New System.Drawing.Point(529, 341)
        Me.X8Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y14.Name = "X8Y14"
        Me.X8Y14.Size = New System.Drawing.Size(32, 32)
        Me.X8Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y14.TabIndex = 732
        Me.X8Y14.TabStop = False
        '
        'X8Y15
        '
        Me.X8Y15.BackColor = System.Drawing.Color.Black
        Me.X8Y15.BackgroundImage = CType(resources.GetObject("X8Y15.BackgroundImage"), System.Drawing.Image)
        Me.X8Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y15.Image = CType(resources.GetObject("X8Y15.Image"), System.Drawing.Image)
        Me.X8Y15.Location = New System.Drawing.Point(561, 341)
        Me.X8Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y15.Name = "X8Y15"
        Me.X8Y15.Size = New System.Drawing.Size(32, 32)
        Me.X8Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y15.TabIndex = 733
        Me.X8Y15.TabStop = False
        '
        'X8Y17
        '
        Me.X8Y17.BackColor = System.Drawing.Color.Black
        Me.X8Y17.BackgroundImage = CType(resources.GetObject("X8Y17.BackgroundImage"), System.Drawing.Image)
        Me.X8Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y17.Image = CType(resources.GetObject("X8Y17.Image"), System.Drawing.Image)
        Me.X8Y17.Location = New System.Drawing.Point(625, 341)
        Me.X8Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y17.Name = "X8Y17"
        Me.X8Y17.Size = New System.Drawing.Size(32, 32)
        Me.X8Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y17.TabIndex = 735
        Me.X8Y17.TabStop = False
        '
        'X8Y18
        '
        Me.X8Y18.BackColor = System.Drawing.Color.Black
        Me.X8Y18.BackgroundImage = CType(resources.GetObject("X8Y18.BackgroundImage"), System.Drawing.Image)
        Me.X8Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y18.Image = CType(resources.GetObject("X8Y18.Image"), System.Drawing.Image)
        Me.X8Y18.Location = New System.Drawing.Point(657, 341)
        Me.X8Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y18.Name = "X8Y18"
        Me.X8Y18.Size = New System.Drawing.Size(32, 32)
        Me.X8Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y18.TabIndex = 736
        Me.X8Y18.TabStop = False
        '
        'X8Y19
        '
        Me.X8Y19.BackColor = System.Drawing.Color.Black
        Me.X8Y19.BackgroundImage = CType(resources.GetObject("X8Y19.BackgroundImage"), System.Drawing.Image)
        Me.X8Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y19.Image = CType(resources.GetObject("X8Y19.Image"), System.Drawing.Image)
        Me.X8Y19.Location = New System.Drawing.Point(689, 341)
        Me.X8Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y19.Name = "X8Y19"
        Me.X8Y19.Size = New System.Drawing.Size(32, 32)
        Me.X8Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y19.TabIndex = 737
        Me.X8Y19.TabStop = False
        '
        'X8Y20
        '
        Me.X8Y20.BackColor = System.Drawing.Color.Black
        Me.X8Y20.BackgroundImage = CType(resources.GetObject("X8Y20.BackgroundImage"), System.Drawing.Image)
        Me.X8Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X8Y20.Image = CType(resources.GetObject("X8Y20.Image"), System.Drawing.Image)
        Me.X8Y20.Location = New System.Drawing.Point(721, 341)
        Me.X8Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X8Y20.Name = "X8Y20"
        Me.X8Y20.Size = New System.Drawing.Size(32, 32)
        Me.X8Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X8Y20.TabIndex = 738
        Me.X8Y20.TabStop = False
        '
        'X9Y16
        '
        Me.X9Y16.BackColor = System.Drawing.Color.Black
        Me.X9Y16.BackgroundImage = CType(resources.GetObject("X9Y16.BackgroundImage"), System.Drawing.Image)
        Me.X9Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y16.Image = CType(resources.GetObject("X9Y16.Image"), System.Drawing.Image)
        Me.X9Y16.Location = New System.Drawing.Point(593, 372)
        Me.X9Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y16.Name = "X9Y16"
        Me.X9Y16.Size = New System.Drawing.Size(32, 32)
        Me.X9Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y16.TabIndex = 744
        Me.X9Y16.TabStop = False
        '
        'X9Y11
        '
        Me.X9Y11.BackColor = System.Drawing.Color.Black
        Me.X9Y11.BackgroundImage = CType(resources.GetObject("X9Y11.BackgroundImage"), System.Drawing.Image)
        Me.X9Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y11.Image = CType(resources.GetObject("X9Y11.Image"), System.Drawing.Image)
        Me.X9Y11.Location = New System.Drawing.Point(433, 372)
        Me.X9Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y11.Name = "X9Y11"
        Me.X9Y11.Size = New System.Drawing.Size(32, 32)
        Me.X9Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y11.TabIndex = 739
        Me.X9Y11.TabStop = False
        '
        'X9Y12
        '
        Me.X9Y12.BackColor = System.Drawing.Color.Black
        Me.X9Y12.BackgroundImage = CType(resources.GetObject("X9Y12.BackgroundImage"), System.Drawing.Image)
        Me.X9Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y12.Image = CType(resources.GetObject("X9Y12.Image"), System.Drawing.Image)
        Me.X9Y12.Location = New System.Drawing.Point(465, 372)
        Me.X9Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y12.Name = "X9Y12"
        Me.X9Y12.Size = New System.Drawing.Size(32, 32)
        Me.X9Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y12.TabIndex = 740
        Me.X9Y12.TabStop = False
        '
        'X9Y13
        '
        Me.X9Y13.BackColor = System.Drawing.Color.Black
        Me.X9Y13.BackgroundImage = CType(resources.GetObject("X9Y13.BackgroundImage"), System.Drawing.Image)
        Me.X9Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y13.Image = CType(resources.GetObject("X9Y13.Image"), System.Drawing.Image)
        Me.X9Y13.Location = New System.Drawing.Point(497, 372)
        Me.X9Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y13.Name = "X9Y13"
        Me.X9Y13.Size = New System.Drawing.Size(32, 32)
        Me.X9Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y13.TabIndex = 741
        Me.X9Y13.TabStop = False
        '
        'X9Y14
        '
        Me.X9Y14.BackColor = System.Drawing.Color.Black
        Me.X9Y14.BackgroundImage = CType(resources.GetObject("X9Y14.BackgroundImage"), System.Drawing.Image)
        Me.X9Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y14.Image = CType(resources.GetObject("X9Y14.Image"), System.Drawing.Image)
        Me.X9Y14.Location = New System.Drawing.Point(529, 372)
        Me.X9Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y14.Name = "X9Y14"
        Me.X9Y14.Size = New System.Drawing.Size(32, 32)
        Me.X9Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y14.TabIndex = 742
        Me.X9Y14.TabStop = False
        '
        'X9Y15
        '
        Me.X9Y15.BackColor = System.Drawing.Color.Black
        Me.X9Y15.BackgroundImage = CType(resources.GetObject("X9Y15.BackgroundImage"), System.Drawing.Image)
        Me.X9Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y15.Image = CType(resources.GetObject("X9Y15.Image"), System.Drawing.Image)
        Me.X9Y15.Location = New System.Drawing.Point(561, 372)
        Me.X9Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y15.Name = "X9Y15"
        Me.X9Y15.Size = New System.Drawing.Size(32, 32)
        Me.X9Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y15.TabIndex = 743
        Me.X9Y15.TabStop = False
        '
        'X9Y17
        '
        Me.X9Y17.BackColor = System.Drawing.Color.Black
        Me.X9Y17.BackgroundImage = CType(resources.GetObject("X9Y17.BackgroundImage"), System.Drawing.Image)
        Me.X9Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y17.Image = CType(resources.GetObject("X9Y17.Image"), System.Drawing.Image)
        Me.X9Y17.Location = New System.Drawing.Point(625, 372)
        Me.X9Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y17.Name = "X9Y17"
        Me.X9Y17.Size = New System.Drawing.Size(32, 32)
        Me.X9Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y17.TabIndex = 745
        Me.X9Y17.TabStop = False
        '
        'X9Y18
        '
        Me.X9Y18.BackColor = System.Drawing.Color.Black
        Me.X9Y18.BackgroundImage = CType(resources.GetObject("X9Y18.BackgroundImage"), System.Drawing.Image)
        Me.X9Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y18.Image = CType(resources.GetObject("X9Y18.Image"), System.Drawing.Image)
        Me.X9Y18.Location = New System.Drawing.Point(657, 372)
        Me.X9Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y18.Name = "X9Y18"
        Me.X9Y18.Size = New System.Drawing.Size(32, 32)
        Me.X9Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y18.TabIndex = 746
        Me.X9Y18.TabStop = False
        '
        'X9Y19
        '
        Me.X9Y19.BackColor = System.Drawing.Color.Black
        Me.X9Y19.BackgroundImage = CType(resources.GetObject("X9Y19.BackgroundImage"), System.Drawing.Image)
        Me.X9Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y19.Image = CType(resources.GetObject("X9Y19.Image"), System.Drawing.Image)
        Me.X9Y19.Location = New System.Drawing.Point(689, 372)
        Me.X9Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y19.Name = "X9Y19"
        Me.X9Y19.Size = New System.Drawing.Size(32, 32)
        Me.X9Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y19.TabIndex = 747
        Me.X9Y19.TabStop = False
        '
        'X9Y20
        '
        Me.X9Y20.BackColor = System.Drawing.Color.Black
        Me.X9Y20.BackgroundImage = CType(resources.GetObject("X9Y20.BackgroundImage"), System.Drawing.Image)
        Me.X9Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X9Y20.Image = CType(resources.GetObject("X9Y20.Image"), System.Drawing.Image)
        Me.X9Y20.Location = New System.Drawing.Point(721, 372)
        Me.X9Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X9Y20.Name = "X9Y20"
        Me.X9Y20.Size = New System.Drawing.Size(32, 32)
        Me.X9Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X9Y20.TabIndex = 748
        Me.X9Y20.TabStop = False
        '
        'X10Y16
        '
        Me.X10Y16.BackColor = System.Drawing.Color.Black
        Me.X10Y16.BackgroundImage = CType(resources.GetObject("X10Y16.BackgroundImage"), System.Drawing.Image)
        Me.X10Y16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y16.Image = CType(resources.GetObject("X10Y16.Image"), System.Drawing.Image)
        Me.X10Y16.Location = New System.Drawing.Point(593, 403)
        Me.X10Y16.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y16.Name = "X10Y16"
        Me.X10Y16.Size = New System.Drawing.Size(32, 32)
        Me.X10Y16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y16.TabIndex = 754
        Me.X10Y16.TabStop = False
        '
        'X10Y11
        '
        Me.X10Y11.BackColor = System.Drawing.Color.Black
        Me.X10Y11.BackgroundImage = CType(resources.GetObject("X10Y11.BackgroundImage"), System.Drawing.Image)
        Me.X10Y11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y11.Image = CType(resources.GetObject("X10Y11.Image"), System.Drawing.Image)
        Me.X10Y11.Location = New System.Drawing.Point(433, 403)
        Me.X10Y11.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y11.Name = "X10Y11"
        Me.X10Y11.Size = New System.Drawing.Size(32, 32)
        Me.X10Y11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y11.TabIndex = 749
        Me.X10Y11.TabStop = False
        '
        'X10Y12
        '
        Me.X10Y12.BackColor = System.Drawing.Color.Black
        Me.X10Y12.BackgroundImage = CType(resources.GetObject("X10Y12.BackgroundImage"), System.Drawing.Image)
        Me.X10Y12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y12.Image = CType(resources.GetObject("X10Y12.Image"), System.Drawing.Image)
        Me.X10Y12.Location = New System.Drawing.Point(465, 403)
        Me.X10Y12.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y12.Name = "X10Y12"
        Me.X10Y12.Size = New System.Drawing.Size(32, 32)
        Me.X10Y12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y12.TabIndex = 750
        Me.X10Y12.TabStop = False
        '
        'X10Y13
        '
        Me.X10Y13.BackColor = System.Drawing.Color.Black
        Me.X10Y13.BackgroundImage = CType(resources.GetObject("X10Y13.BackgroundImage"), System.Drawing.Image)
        Me.X10Y13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y13.Image = CType(resources.GetObject("X10Y13.Image"), System.Drawing.Image)
        Me.X10Y13.Location = New System.Drawing.Point(497, 403)
        Me.X10Y13.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y13.Name = "X10Y13"
        Me.X10Y13.Size = New System.Drawing.Size(32, 32)
        Me.X10Y13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y13.TabIndex = 751
        Me.X10Y13.TabStop = False
        '
        'X10Y14
        '
        Me.X10Y14.BackColor = System.Drawing.Color.Black
        Me.X10Y14.BackgroundImage = CType(resources.GetObject("X10Y14.BackgroundImage"), System.Drawing.Image)
        Me.X10Y14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y14.Image = CType(resources.GetObject("X10Y14.Image"), System.Drawing.Image)
        Me.X10Y14.Location = New System.Drawing.Point(529, 403)
        Me.X10Y14.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y14.Name = "X10Y14"
        Me.X10Y14.Size = New System.Drawing.Size(32, 32)
        Me.X10Y14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y14.TabIndex = 752
        Me.X10Y14.TabStop = False
        '
        'X10Y15
        '
        Me.X10Y15.BackColor = System.Drawing.Color.Black
        Me.X10Y15.BackgroundImage = CType(resources.GetObject("X10Y15.BackgroundImage"), System.Drawing.Image)
        Me.X10Y15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y15.Image = CType(resources.GetObject("X10Y15.Image"), System.Drawing.Image)
        Me.X10Y15.Location = New System.Drawing.Point(561, 403)
        Me.X10Y15.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y15.Name = "X10Y15"
        Me.X10Y15.Size = New System.Drawing.Size(32, 32)
        Me.X10Y15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y15.TabIndex = 753
        Me.X10Y15.TabStop = False
        '
        'X10Y17
        '
        Me.X10Y17.BackColor = System.Drawing.Color.Black
        Me.X10Y17.BackgroundImage = CType(resources.GetObject("X10Y17.BackgroundImage"), System.Drawing.Image)
        Me.X10Y17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y17.Image = CType(resources.GetObject("X10Y17.Image"), System.Drawing.Image)
        Me.X10Y17.Location = New System.Drawing.Point(625, 403)
        Me.X10Y17.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y17.Name = "X10Y17"
        Me.X10Y17.Size = New System.Drawing.Size(32, 32)
        Me.X10Y17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y17.TabIndex = 755
        Me.X10Y17.TabStop = False
        '
        'X10Y18
        '
        Me.X10Y18.BackColor = System.Drawing.Color.Black
        Me.X10Y18.BackgroundImage = CType(resources.GetObject("X10Y18.BackgroundImage"), System.Drawing.Image)
        Me.X10Y18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y18.Image = CType(resources.GetObject("X10Y18.Image"), System.Drawing.Image)
        Me.X10Y18.Location = New System.Drawing.Point(657, 403)
        Me.X10Y18.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y18.Name = "X10Y18"
        Me.X10Y18.Size = New System.Drawing.Size(32, 32)
        Me.X10Y18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y18.TabIndex = 756
        Me.X10Y18.TabStop = False
        '
        'X10Y19
        '
        Me.X10Y19.BackColor = System.Drawing.Color.Black
        Me.X10Y19.BackgroundImage = CType(resources.GetObject("X10Y19.BackgroundImage"), System.Drawing.Image)
        Me.X10Y19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y19.Image = CType(resources.GetObject("X10Y19.Image"), System.Drawing.Image)
        Me.X10Y19.Location = New System.Drawing.Point(689, 403)
        Me.X10Y19.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y19.Name = "X10Y19"
        Me.X10Y19.Size = New System.Drawing.Size(32, 32)
        Me.X10Y19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y19.TabIndex = 757
        Me.X10Y19.TabStop = False
        '
        'X10Y20
        '
        Me.X10Y20.BackColor = System.Drawing.Color.Black
        Me.X10Y20.BackgroundImage = CType(resources.GetObject("X10Y20.BackgroundImage"), System.Drawing.Image)
        Me.X10Y20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.X10Y20.Image = CType(resources.GetObject("X10Y20.Image"), System.Drawing.Image)
        Me.X10Y20.Location = New System.Drawing.Point(721, 403)
        Me.X10Y20.Margin = New System.Windows.Forms.Padding(0)
        Me.X10Y20.Name = "X10Y20"
        Me.X10Y20.Size = New System.Drawing.Size(32, 32)
        Me.X10Y20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.X10Y20.TabIndex = 758
        Me.X10Y20.TabStop = False
        '
        'LineList
        '
        Me.LineList.FormattingEnabled = True
        Me.LineList.Location = New System.Drawing.Point(1002, 438)
        Me.LineList.Name = "LineList"
        Me.LineList.Size = New System.Drawing.Size(120, 95)
        Me.LineList.TabIndex = 759
        Me.LineList.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.Splash_X2.My.Resources.Resources.nullBlack
        Me.PictureBox1.Location = New System.Drawing.Point(104, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(922, 372)
        Me.PictureBox1.TabIndex = 760
        Me.PictureBox1.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1122, 517)
        Me.Controls.Add(Me.bgplayer)
        Me.Controls.Add(Me.LineList)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.X10Y20)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.X10Y19)
        Me.Controls.Add(Me.X10Y18)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.X10Y17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.X10Y15)
        Me.Controls.Add(Me.X10Y14)
        Me.Controls.Add(Me.X10Y13)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.X10Y12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.X10Y11)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.X10Y16)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.X9Y20)
        Me.Controls.Add(Me.X1Y1)
        Me.Controls.Add(Me.X9Y19)
        Me.Controls.Add(Me.X1Y2)
        Me.Controls.Add(Me.X9Y18)
        Me.Controls.Add(Me.X1Y3)
        Me.Controls.Add(Me.X9Y17)
        Me.Controls.Add(Me.X1Y4)
        Me.Controls.Add(Me.X9Y15)
        Me.Controls.Add(Me.X1Y5)
        Me.Controls.Add(Me.X9Y14)
        Me.Controls.Add(Me.X1Y6)
        Me.Controls.Add(Me.X9Y13)
        Me.Controls.Add(Me.X1Y7)
        Me.Controls.Add(Me.X9Y12)
        Me.Controls.Add(Me.X1Y8)
        Me.Controls.Add(Me.X9Y11)
        Me.Controls.Add(Me.X1Y9)
        Me.Controls.Add(Me.X9Y16)
        Me.Controls.Add(Me.X1Y10)
        Me.Controls.Add(Me.X8Y20)
        Me.Controls.Add(Me.X2Y1)
        Me.Controls.Add(Me.X8Y19)
        Me.Controls.Add(Me.X2Y2)
        Me.Controls.Add(Me.X8Y18)
        Me.Controls.Add(Me.X2Y8)
        Me.Controls.Add(Me.X8Y17)
        Me.Controls.Add(Me.X2Y3)
        Me.Controls.Add(Me.X8Y15)
        Me.Controls.Add(Me.X2Y4)
        Me.Controls.Add(Me.X8Y14)
        Me.Controls.Add(Me.X2Y5)
        Me.Controls.Add(Me.X8Y13)
        Me.Controls.Add(Me.X2Y6)
        Me.Controls.Add(Me.X8Y12)
        Me.Controls.Add(Me.X2Y7)
        Me.Controls.Add(Me.X8Y11)
        Me.Controls.Add(Me.X2Y9)
        Me.Controls.Add(Me.X8Y16)
        Me.Controls.Add(Me.X2Y10)
        Me.Controls.Add(Me.X7Y20)
        Me.Controls.Add(Me.X3Y6)
        Me.Controls.Add(Me.X7Y19)
        Me.Controls.Add(Me.X3Y1)
        Me.Controls.Add(Me.X7Y18)
        Me.Controls.Add(Me.X3Y2)
        Me.Controls.Add(Me.X7Y17)
        Me.Controls.Add(Me.X3Y3)
        Me.Controls.Add(Me.X7Y15)
        Me.Controls.Add(Me.X3Y4)
        Me.Controls.Add(Me.X7Y14)
        Me.Controls.Add(Me.X3Y5)
        Me.Controls.Add(Me.X7Y13)
        Me.Controls.Add(Me.X3Y7)
        Me.Controls.Add(Me.X7Y12)
        Me.Controls.Add(Me.X3Y8)
        Me.Controls.Add(Me.X7Y11)
        Me.Controls.Add(Me.X3Y9)
        Me.Controls.Add(Me.X7Y16)
        Me.Controls.Add(Me.X3Y10)
        Me.Controls.Add(Me.X6Y20)
        Me.Controls.Add(Me.X4Y1)
        Me.Controls.Add(Me.X6Y19)
        Me.Controls.Add(Me.X4Y2)
        Me.Controls.Add(Me.X6Y18)
        Me.Controls.Add(Me.X4Y3)
        Me.Controls.Add(Me.X6Y17)
        Me.Controls.Add(Me.X4Y4)
        Me.Controls.Add(Me.X6Y15)
        Me.Controls.Add(Me.X4Y5)
        Me.Controls.Add(Me.X6Y14)
        Me.Controls.Add(Me.X4Y6)
        Me.Controls.Add(Me.X6Y13)
        Me.Controls.Add(Me.X4Y7)
        Me.Controls.Add(Me.X6Y12)
        Me.Controls.Add(Me.X4Y8)
        Me.Controls.Add(Me.X6Y11)
        Me.Controls.Add(Me.X4Y9)
        Me.Controls.Add(Me.X6Y16)
        Me.Controls.Add(Me.X4Y10)
        Me.Controls.Add(Me.X5Y20)
        Me.Controls.Add(Me.X5Y6)
        Me.Controls.Add(Me.X5Y19)
        Me.Controls.Add(Me.X5Y1)
        Me.Controls.Add(Me.X5Y18)
        Me.Controls.Add(Me.X5Y2)
        Me.Controls.Add(Me.X5Y17)
        Me.Controls.Add(Me.X5Y3)
        Me.Controls.Add(Me.X5Y15)
        Me.Controls.Add(Me.X5Y4)
        Me.Controls.Add(Me.X5Y14)
        Me.Controls.Add(Me.X5Y5)
        Me.Controls.Add(Me.X5Y13)
        Me.Controls.Add(Me.X5Y7)
        Me.Controls.Add(Me.X5Y12)
        Me.Controls.Add(Me.X5Y8)
        Me.Controls.Add(Me.X5Y11)
        Me.Controls.Add(Me.X5Y9)
        Me.Controls.Add(Me.X5Y16)
        Me.Controls.Add(Me.X5Y10)
        Me.Controls.Add(Me.X4Y20)
        Me.Controls.Add(Me.X6Y6)
        Me.Controls.Add(Me.X4Y19)
        Me.Controls.Add(Me.X6Y1)
        Me.Controls.Add(Me.X4Y18)
        Me.Controls.Add(Me.X6Y2)
        Me.Controls.Add(Me.X4Y17)
        Me.Controls.Add(Me.X6Y3)
        Me.Controls.Add(Me.X4Y16)
        Me.Controls.Add(Me.X6Y4)
        Me.Controls.Add(Me.X4Y15)
        Me.Controls.Add(Me.X6Y5)
        Me.Controls.Add(Me.X4Y14)
        Me.Controls.Add(Me.X6Y7)
        Me.Controls.Add(Me.X4Y13)
        Me.Controls.Add(Me.X6Y8)
        Me.Controls.Add(Me.X4Y12)
        Me.Controls.Add(Me.X6Y9)
        Me.Controls.Add(Me.X4Y11)
        Me.Controls.Add(Me.X6Y10)
        Me.Controls.Add(Me.X3Y20)
        Me.Controls.Add(Me.X7Y6)
        Me.Controls.Add(Me.X3Y19)
        Me.Controls.Add(Me.X7Y1)
        Me.Controls.Add(Me.X3Y18)
        Me.Controls.Add(Me.X7Y2)
        Me.Controls.Add(Me.X3Y17)
        Me.Controls.Add(Me.X7Y3)
        Me.Controls.Add(Me.X3Y15)
        Me.Controls.Add(Me.X7Y4)
        Me.Controls.Add(Me.X3Y14)
        Me.Controls.Add(Me.X7Y5)
        Me.Controls.Add(Me.X3Y13)
        Me.Controls.Add(Me.X7Y7)
        Me.Controls.Add(Me.X3Y12)
        Me.Controls.Add(Me.X7Y8)
        Me.Controls.Add(Me.X3Y11)
        Me.Controls.Add(Me.X7Y9)
        Me.Controls.Add(Me.X3Y16)
        Me.Controls.Add(Me.X7Y10)
        Me.Controls.Add(Me.X2Y20)
        Me.Controls.Add(Me.X8Y6)
        Me.Controls.Add(Me.X2Y19)
        Me.Controls.Add(Me.X8Y1)
        Me.Controls.Add(Me.X2Y17)
        Me.Controls.Add(Me.X8Y2)
        Me.Controls.Add(Me.X2Y16)
        Me.Controls.Add(Me.X8Y3)
        Me.Controls.Add(Me.X2Y15)
        Me.Controls.Add(Me.X8Y4)
        Me.Controls.Add(Me.X2Y14)
        Me.Controls.Add(Me.X8Y5)
        Me.Controls.Add(Me.X2Y13)
        Me.Controls.Add(Me.X8Y7)
        Me.Controls.Add(Me.X2Y18)
        Me.Controls.Add(Me.X8Y8)
        Me.Controls.Add(Me.X2Y12)
        Me.Controls.Add(Me.X8Y9)
        Me.Controls.Add(Me.X2Y11)
        Me.Controls.Add(Me.X8Y10)
        Me.Controls.Add(Me.X1Y20)
        Me.Controls.Add(Me.X9Y6)
        Me.Controls.Add(Me.X1Y19)
        Me.Controls.Add(Me.X9Y1)
        Me.Controls.Add(Me.X1Y18)
        Me.Controls.Add(Me.X9Y2)
        Me.Controls.Add(Me.X1Y17)
        Me.Controls.Add(Me.X9Y3)
        Me.Controls.Add(Me.X1Y16)
        Me.Controls.Add(Me.X9Y4)
        Me.Controls.Add(Me.X1Y15)
        Me.Controls.Add(Me.X9Y5)
        Me.Controls.Add(Me.X1Y14)
        Me.Controls.Add(Me.X9Y7)
        Me.Controls.Add(Me.X1Y13)
        Me.Controls.Add(Me.X9Y8)
        Me.Controls.Add(Me.X1Y12)
        Me.Controls.Add(Me.X9Y9)
        Me.Controls.Add(Me.X1Y11)
        Me.Controls.Add(Me.X9Y10)
        Me.Controls.Add(Me.X10Y10)
        Me.Controls.Add(Me.X10Y6)
        Me.Controls.Add(Me.X10Y9)
        Me.Controls.Add(Me.X10Y1)
        Me.Controls.Add(Me.X10Y8)
        Me.Controls.Add(Me.X10Y2)
        Me.Controls.Add(Me.X10Y7)
        Me.Controls.Add(Me.X10Y3)
        Me.Controls.Add(Me.X10Y5)
        Me.Controls.Add(Me.X10Y4)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "a"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.InfoBox.ResumeLayout(False)
        Me.InfoBox.PerformLayout()
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bgplayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox56, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.InvDisplay3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvDisplay2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvDisplay1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X1Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X2Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X3Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X4Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X5Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X6Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X7Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X8Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X9Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X10Y20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InitialiseMapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplashMapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavingExperimentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCursor3 As Label
    Friend WithEvents lblCursor2 As Label
    Friend WithEvents lblCursor1 As Label
    Friend WithEvents lblCursorTitle As Label
    Friend WithEvents PicCursor As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DisplayID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DisplayArea As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DisplayLevel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DisplayHealth As Label
    Friend WithEvents InfoBox As GroupBox
    Friend WithEvents DisplayKey As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DisplayPos As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Displaymsg3 As Label
    Friend WithEvents Displaymsg2 As Label
    Friend WithEvents Displaymsg1 As Label
    Friend WithEvents bgplayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox56 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MapEditorModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorBreak As Button
    Friend WithEvents MapDesignerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents X1Y1 As PictureBox
    Friend WithEvents X1Y2 As PictureBox
    Friend WithEvents X1Y3 As PictureBox
    Friend WithEvents X1Y4 As PictureBox
    Friend WithEvents X1Y5 As PictureBox
    Friend WithEvents X1Y6 As PictureBox
    Friend WithEvents X1Y7 As PictureBox
    Friend WithEvents X1Y8 As PictureBox
    Friend WithEvents X1Y9 As PictureBox
    Friend WithEvents X1Y10 As PictureBox
    Friend WithEvents X2Y1 As PictureBox
    Friend WithEvents X2Y2 As PictureBox
    Friend WithEvents X2Y8 As PictureBox
    Friend WithEvents X2Y3 As PictureBox
    Friend WithEvents X2Y4 As PictureBox
    Friend WithEvents X2Y5 As PictureBox
    Friend WithEvents X2Y6 As PictureBox
    Friend WithEvents X2Y7 As PictureBox
    Friend WithEvents X2Y9 As PictureBox
    Friend WithEvents X2Y10 As PictureBox
    Friend WithEvents X3Y6 As PictureBox
    Friend WithEvents X3Y1 As PictureBox
    Friend WithEvents X3Y2 As PictureBox
    Friend WithEvents X3Y3 As PictureBox
    Friend WithEvents X3Y4 As PictureBox
    Friend WithEvents X3Y5 As PictureBox
    Friend WithEvents X3Y7 As PictureBox
    Friend WithEvents X3Y8 As PictureBox
    Friend WithEvents X3Y9 As PictureBox
    Friend WithEvents X3Y10 As PictureBox
    Friend WithEvents X4Y1 As PictureBox
    Friend WithEvents X4Y2 As PictureBox
    Friend WithEvents X4Y3 As PictureBox
    Friend WithEvents X4Y4 As PictureBox
    Friend WithEvents X4Y5 As PictureBox
    Friend WithEvents X4Y6 As PictureBox
    Friend WithEvents X4Y7 As PictureBox
    Friend WithEvents X4Y8 As PictureBox
    Friend WithEvents X4Y9 As PictureBox
    Friend WithEvents X4Y10 As PictureBox
    Friend WithEvents X5Y6 As PictureBox
    Friend WithEvents X5Y1 As PictureBox
    Friend WithEvents X5Y2 As PictureBox
    Friend WithEvents X5Y3 As PictureBox
    Friend WithEvents X5Y4 As PictureBox
    Friend WithEvents X5Y5 As PictureBox
    Friend WithEvents X5Y7 As PictureBox
    Friend WithEvents X5Y8 As PictureBox
    Friend WithEvents X5Y9 As PictureBox
    Friend WithEvents X5Y10 As PictureBox
    Friend WithEvents X6Y6 As PictureBox
    Friend WithEvents X6Y1 As PictureBox
    Friend WithEvents X6Y2 As PictureBox
    Friend WithEvents X6Y3 As PictureBox
    Friend WithEvents X6Y4 As PictureBox
    Friend WithEvents X6Y5 As PictureBox
    Friend WithEvents X6Y7 As PictureBox
    Friend WithEvents X6Y8 As PictureBox
    Friend WithEvents X6Y9 As PictureBox
    Friend WithEvents X6Y10 As PictureBox
    Friend WithEvents X7Y6 As PictureBox
    Friend WithEvents X7Y1 As PictureBox
    Friend WithEvents X7Y2 As PictureBox
    Friend WithEvents X7Y3 As PictureBox
    Friend WithEvents X7Y4 As PictureBox
    Friend WithEvents X7Y5 As PictureBox
    Friend WithEvents X7Y7 As PictureBox
    Friend WithEvents X7Y8 As PictureBox
    Friend WithEvents X7Y9 As PictureBox
    Friend WithEvents X7Y10 As PictureBox
    Friend WithEvents X8Y6 As PictureBox
    Friend WithEvents X8Y1 As PictureBox
    Friend WithEvents X8Y2 As PictureBox
    Friend WithEvents X8Y3 As PictureBox
    Friend WithEvents X8Y4 As PictureBox
    Friend WithEvents X8Y5 As PictureBox
    Friend WithEvents X8Y7 As PictureBox
    Friend WithEvents X8Y8 As PictureBox
    Friend WithEvents X8Y9 As PictureBox
    Friend WithEvents X8Y10 As PictureBox
    Friend WithEvents X9Y6 As PictureBox
    Friend WithEvents X9Y1 As PictureBox
    Friend WithEvents X9Y2 As PictureBox
    Friend WithEvents X9Y3 As PictureBox
    Friend WithEvents X9Y4 As PictureBox
    Friend WithEvents X9Y5 As PictureBox
    Friend WithEvents X9Y7 As PictureBox
    Friend WithEvents X9Y8 As PictureBox
    Friend WithEvents X9Y9 As PictureBox
    Friend WithEvents X9Y10 As PictureBox
    Friend WithEvents X10Y6 As PictureBox
    Friend WithEvents X10Y1 As PictureBox
    Friend WithEvents X10Y2 As PictureBox
    Friend WithEvents X10Y3 As PictureBox
    Friend WithEvents X10Y4 As PictureBox
    Friend WithEvents X10Y5 As PictureBox
    Friend WithEvents X10Y7 As PictureBox
    Friend WithEvents X10Y8 As PictureBox
    Friend WithEvents X10Y9 As PictureBox
    Friend WithEvents X10Y10 As PictureBox
    Friend WithEvents X1Y11 As PictureBox
    Friend WithEvents X1Y12 As PictureBox
    Friend WithEvents X1Y13 As PictureBox
    Friend WithEvents X1Y14 As PictureBox
    Friend WithEvents X1Y15 As PictureBox
    Friend WithEvents X1Y16 As PictureBox
    Friend WithEvents X1Y17 As PictureBox
    Friend WithEvents X1Y18 As PictureBox
    Friend WithEvents X1Y19 As PictureBox
    Friend WithEvents X1Y20 As PictureBox
    Friend WithEvents X2Y11 As PictureBox
    Friend WithEvents X2Y12 As PictureBox
    Friend WithEvents X2Y18 As PictureBox
    Friend WithEvents X2Y13 As PictureBox
    Friend WithEvents X2Y14 As PictureBox
    Friend WithEvents X2Y15 As PictureBox
    Friend WithEvents X2Y16 As PictureBox
    Friend WithEvents X2Y17 As PictureBox
    Friend WithEvents X2Y19 As PictureBox
    Friend WithEvents X2Y20 As PictureBox
    Friend WithEvents X3Y16 As PictureBox
    Friend WithEvents X3Y11 As PictureBox
    Friend WithEvents X3Y12 As PictureBox
    Friend WithEvents X3Y13 As PictureBox
    Friend WithEvents X3Y14 As PictureBox
    Friend WithEvents X3Y15 As PictureBox
    Friend WithEvents X3Y17 As PictureBox
    Friend WithEvents X3Y18 As PictureBox
    Friend WithEvents X3Y19 As PictureBox
    Friend WithEvents X3Y20 As PictureBox
    Friend WithEvents X4Y11 As PictureBox
    Friend WithEvents X4Y12 As PictureBox
    Friend WithEvents X4Y13 As PictureBox
    Friend WithEvents X4Y14 As PictureBox
    Friend WithEvents X4Y15 As PictureBox
    Friend WithEvents X4Y16 As PictureBox
    Friend WithEvents X4Y17 As PictureBox
    Friend WithEvents X4Y18 As PictureBox
    Friend WithEvents X4Y19 As PictureBox
    Friend WithEvents X4Y20 As PictureBox
    Friend WithEvents X5Y16 As PictureBox
    Friend WithEvents X5Y11 As PictureBox
    Friend WithEvents X5Y12 As PictureBox
    Friend WithEvents X5Y13 As PictureBox
    Friend WithEvents X5Y14 As PictureBox
    Friend WithEvents X5Y15 As PictureBox
    Friend WithEvents X5Y17 As PictureBox
    Friend WithEvents X5Y18 As PictureBox
    Friend WithEvents X5Y19 As PictureBox
    Friend WithEvents X5Y20 As PictureBox
    Friend WithEvents X6Y16 As PictureBox
    Friend WithEvents X6Y11 As PictureBox
    Friend WithEvents X6Y12 As PictureBox
    Friend WithEvents X6Y13 As PictureBox
    Friend WithEvents X6Y14 As PictureBox
    Friend WithEvents X6Y15 As PictureBox
    Friend WithEvents X6Y17 As PictureBox
    Friend WithEvents X6Y18 As PictureBox
    Friend WithEvents X6Y19 As PictureBox
    Friend WithEvents X6Y20 As PictureBox
    Friend WithEvents X7Y16 As PictureBox
    Friend WithEvents X7Y11 As PictureBox
    Friend WithEvents X7Y12 As PictureBox
    Friend WithEvents X7Y13 As PictureBox
    Friend WithEvents X7Y14 As PictureBox
    Friend WithEvents X7Y15 As PictureBox
    Friend WithEvents X7Y17 As PictureBox
    Friend WithEvents X7Y18 As PictureBox
    Friend WithEvents X7Y19 As PictureBox
    Friend WithEvents X7Y20 As PictureBox
    Friend WithEvents X8Y16 As PictureBox
    Friend WithEvents X8Y11 As PictureBox
    Friend WithEvents X8Y12 As PictureBox
    Friend WithEvents X8Y13 As PictureBox
    Friend WithEvents X8Y14 As PictureBox
    Friend WithEvents X8Y15 As PictureBox
    Friend WithEvents X8Y17 As PictureBox
    Friend WithEvents X8Y18 As PictureBox
    Friend WithEvents X8Y19 As PictureBox
    Friend WithEvents X8Y20 As PictureBox
    Friend WithEvents X9Y16 As PictureBox
    Friend WithEvents X9Y11 As PictureBox
    Friend WithEvents X9Y12 As PictureBox
    Friend WithEvents X9Y13 As PictureBox
    Friend WithEvents X9Y14 As PictureBox
    Friend WithEvents X9Y15 As PictureBox
    Friend WithEvents X9Y17 As PictureBox
    Friend WithEvents X9Y18 As PictureBox
    Friend WithEvents X9Y19 As PictureBox
    Friend WithEvents X9Y20 As PictureBox
    Friend WithEvents X10Y16 As PictureBox
    Friend WithEvents X10Y11 As PictureBox
    Friend WithEvents X10Y12 As PictureBox
    Friend WithEvents X10Y13 As PictureBox
    Friend WithEvents X10Y14 As PictureBox
    Friend WithEvents X10Y15 As PictureBox
    Friend WithEvents X10Y17 As PictureBox
    Friend WithEvents X10Y18 As PictureBox
    Friend WithEvents X10Y19 As PictureBox
    Friend WithEvents X10Y20 As PictureBox
    Friend WithEvents LineList As ListBox
    Friend WithEvents SaveGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvDisplay3 As PictureBox
    Friend WithEvents InvDisplay2 As PictureBox
    Friend WithEvents InvDisplay1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
