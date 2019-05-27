Public Class SaveFileCorroupted
    Public Sub death_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Game.bgplayer.close()
        My.Computer.Audio.Play(My.Resources.MissionOver, AudioPlayMode.Background)
    End Sub

    Public Sub Death_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "1" Then
            End
        End If
    End Sub
End Class