Public Class About
    Private Sub About_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "1" Then
            Me.Hide()
            SplashMenu.Show()
        End If
        Label1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Notification, AudioPlayMode.Background)
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
    End Sub
End Class