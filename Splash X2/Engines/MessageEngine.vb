Public Class MessageEngine

    Public Sub addline(line)
        If line = "cls" Then
            Game.LineList.Items.Clear()
        End If

        Game.LineList.Items.Add(line)
    End Sub

    Public Sub Display(line)
        My.Computer.Audio.Play(My.Resources.Notification, AudioPlayMode.Background)
        Game.Displaymsg1.ResetText()
        Game.Displaymsg2.ResetText()
        Game.Displaymsg3.ResetText()
        If Not line = "null" Then
            Game.Displaymsg1.Text = line
            Exit Sub
        End If

        Try
            Game.Displaymsg1.Text = Game.LineList.Items(0)
            Game.LineList.Items.RemoveAt(0)

            Game.Displaymsg2.Text = Game.LineList.Items(0)
            Game.LineList.Items.RemoveAt(0)

            Game.Displaymsg3.Text = Game.LineList.Items(0)
            Game.LineList.Items.RemoveAt(0)
        Catch
        End Try
    End Sub

    Public Sub debug(Message)





    End Sub
End Class
