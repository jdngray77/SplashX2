Imports System.ComponentModel

Public Class Game
    'Public Variables
    Public DebugMode, Selectermode
    Public CurrentMap, SelectedTile
    Public SelecterCallX, SelecterCallY
    Public PlayerCurrentX, PlayerCurrentY, PlayerPreviousX, PlayerPreviousY
    Public PlayerHealth = 10
    Public PlayerMaxHealth = 10
    Public actionstore, movementcount
    Public Storyprogress = 0
    Public EnemyArray(9, 19)
    Public TileDataArray(9, 19, 5) '(X, Y, Durability/health - other - other - other - other)


    Public SelecterX, SelecterY
    Public DrawnDisplay(10, 20)

    Private Sub SavingExperimentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavingExperimentToolStripMenuItem.Click
        Me.Hide()
        FileWrite.ShowDialog()
    End Sub
    'Local


    'Object References
    Private Display As DisplayEngine = New DisplayEngine()

    '================ Passive ===================
    'Load
    Public Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileWrite.LoadUser()
        Dim map = FileWrite.LoadWorld()
        GroupBox4.Text = "Splash X2 - Alpha 5"
        If System.Diagnostics.Debugger.IsAttached() Then
            GroupBox4.Text += " - Licensed development edition - Debugger attached"
            MenuStrip1.Show()
            DebugMode = True
        Else
            GroupBox4.Text += " - Unlicensed development edition - No debugger attached"
        End If


        If FileWrite.ReadFromTable(1, 7) = "True" Then
            Display.initmap(map, "FromSave")
        Else
            Display.initmap(map, "null")
        End If
        Me.KeyPreview = True
        Me.Select()
        Storyprogress = FileWrite.ReadFromTable(2, 5)
        PlayerHealth = FileWrite.ReadFromTable(3, 5)
        PlayerMaxHealth = FileWrite.ReadFromTable(4, 5)
        PlayerCurrentX = FileWrite.ReadFromTable(3, 3)
        PlayerCurrentY = FileWrite.ReadFromTable(4, 3)
        PlayerPreviousX = FileWrite.ReadFromTable(3, 3)
        PlayerPreviousY = FileWrite.ReadFromTable(4, 3)
        Storyprogress = FileWrite.ReadFromTable(2, 5)
        FileWrite.SaveToFile()

        Displaymsg1.ResetText()
        Displaymsg2.ResetText()
        Displaymsg3.ResetText()

        Dim story As StoryEngine = New StoryEngine
        story.trigger("Load")
    End Sub

    'debug tools
    Public mapeditormode = False
    Private Sub MapEditorModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapEditorModeToolStripMenuItem.Click
        If mapeditormode = False Then
            mapeditormode = True
            EditorBreak.Show()
        Else
            mapeditormode = False
            EditorBreak.Hide()
        End If
    End Sub


    Private Sub EditorBreak_Click(sender As Object, e As EventArgs) Handles EditorBreak.Click
        System.Diagnostics.Debugger.Break()
        Display.initmap(CurrentMap, "null")
    End Sub

    Private Sub SaveGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveGameToolStripMenuItem.Click
        FileWrite.SaveGame()
    End Sub

    Private Sub MapDesignerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapDesignerToolStripMenuItem.Click
        Me.Hide()
        SplashBG.Hide()
        MapDesigner.ShowDialog()
    End Sub


    'Close
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        bgplayer.close()
        Try
            FileWrite.WriteToTable(2, 3, CurrentMap.mapname)
            FileWrite.WriteToTable(3, 5, PlayerHealth)
            FileWrite.WriteToTable(4, 5, PlayerMaxHealth)
            FileWrite.WriteToTable(3, 3, PlayerCurrentX)
            FileWrite.WriteToTable(4, 3, PlayerCurrentY)
            FileWrite.SaveToFile()

            Me.Hide()
        Catch
        End Try
        SplashMenu.Show()
    End Sub

    '=============== Active =========================
    Private Sub Game_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim Player As PlayerEngine = New PlayerEngine
        Dim behaviour As BehaviourEngine = New BehaviourEngine
        Dim selecter As SelecterEngine = New SelecterEngine
        If Timer1.Enabled = True Or mapeditormode = True Then
            If Timer1.Enabled And e.KeyChar = "3" Then
                Timer1.Stop()
                selecter.SelectHandler(e.KeyChar)
            End If
            Exit Sub
        End If
        If Selectermode = True Then
            selecter.SelectHandler(e.KeyChar)
            Exit Sub
        End If

        Select Case e.KeyChar
            Case "w"
                Player.Move("Up")
            Case "a"
                Player.Move("Left")
            Case "s"
                Player.Move("Down")
            Case "d"
                Player.Move("Right")
            Case "W"
                Player.Move("Up")
            Case "A"
                Player.Move("Left")
            Case "S"
                Player.Move("Down")
            Case "D"
                Player.Move("Right")
            Case "1"
                behaviour.PlayerAction("1")
            Case "2"
                behaviour.PlayerAction("2")
            Case "3"
                behaviour.PlayerAction("3")
            Case "e"
                Me.Hide()
                Inventory.ShowDialog()
            Case "4"
                Me.Hide()
                Inventory.ShowDialog()
            Case "E"
                Me.Hide()
                Inventory.ShowDialog()
            Case "+"
                If DebugMode = True Then
                    FileWrite.SaveGame()
                    bgplayer.close()
                    Me.Controls.Clear()
                    Me.InitializeComponent()
                    Game_Load(Me, EventArgs.Empty)
                End If
            Case "*"
                If DebugMode = False Then
                    MenuStrip1.Show()
                    DebugMode = True
                Else
                    MenuStrip1.Hide()
                    DebugMode = False
                End If
            Case "/"
                If DebugMode = True Then
                    Me.Controls.Clear()
                    bgplayer.close()
                    Me.Hide()
                    SplashMenu.Menuindex = 9
                    SplashMenu.menushow = True
                    SplashMenu.menuselect()
                    Me.InitializeComponent()
                End If
            Case "`"
                'XXX Open in game Menu
            Case "-"
                If DebugMode = True Then
                    FileWrite.SaveGame()
                End If
        End Select
    End Sub
    '============External===========
    Private eventtime, eventtotaltime
    Public Sub ProcessHandler(time)
        eventtime = time / 6
        eventtotaltime = time / 1000
        timercount = 0
        Timer1.Interval = eventtime
        Timer1.Start()
    End Sub

    Private timercount = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timercount = 7 Then
            Dim cursor As CursorEngine = New CursorEngine
            cursor.ProcessComplete()
            Timer1.Stop()
            Exit Sub
        End If

        lblCursor1.Text = "Progress"
        lblCursor2.ResetText()
        For row = 1 To timercount
            lblCursor2.Text += "="
        Next
        For row = 1 To 6 - timercount
            lblCursor2.Text += "+"
        Next
        lblCursor3.Text = "Time: " & eventtotaltime & "s    3: Cancel"
        timercount += 1
    End Sub

    Private Sub Game_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.Gray
    End Sub

    Private Sub Game_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Navy
    End Sub

    Private Sub Game_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        btnClose_Click(Me, EventArgs.Empty)
    End Sub
End Class
