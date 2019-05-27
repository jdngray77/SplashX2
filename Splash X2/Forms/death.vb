Public Class death
    Public Sub death_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileWrite.WriteToTable(3, 5, Game.PlayerHealth)
        FileWrite.WriteToTable(4, 5, Game.PlayerMaxHealth)
        Game.bgplayer.close()
        My.Computer.Audio.Play(My.Resources.GameOverTrack, AudioPlayMode.Background)
        Sel2.ResetText()
    End Sub

    Private Menuindex = 1
    Public Sub Death_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            MenuUpdate("Down")
        ElseIf e.KeyChar = "A" Or e.KeyChar = "a" Then
            MenuUpdate("Up")
        ElseIf e.KeyChar = "1" Then
            menuselect()
        End If
    End Sub

    Private prevCursor = "Sel1"
    Private Sub MenuUpdate(Dir)
        Select Case Dir
            Case "Up"
                If Menuindex = 1 Then
                    Exit Sub
                End If

                Menuindex += -1
            Case "Down"

                If Menuindex = 2 Then
                    Exit Sub
                End If

                Menuindex += 1
        End Select
        Dim selcursor = "Sel" & Menuindex
        Dim cursor As Label = Me.Controls(prevCursor)
        cursor.ResetText()
        cursor = Me.Controls(selcursor)
        cursor.Text = "►"
        prevCursor = selcursor
    End Sub

    Private Sub menuselect()
        Select Case Menuindex
            Case 1
                Game.Show()
                Me.Hide()
                Game.Game_Load(Me, EventArgs.Empty)
            Case 2
                Me.Controls.Clear()
                SplashMenu.Show()
                Me.Hide()
                SplashMenu.SplashMenu_Load(Me, EventArgs.Empty)
        End Select
    End Sub
End Class