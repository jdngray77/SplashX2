Public Class StoryEngine

    Public Sub trigger(trigger)
        Game.CurrentMap.storyline(trigger)
    End Sub

    Public Sub progwrite(prog)
        Game.Storyprogress += 1
        FileWrite.WriteToTable(2, 5, Game.Storyprogress)
    End Sub
End Class
