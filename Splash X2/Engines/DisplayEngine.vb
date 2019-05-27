Public Class DisplayEngine
    Public stack
    'Object Reference
    Dim Message As MessageEngine = New MessageEngine
    Dim Player As PlayerEngine = New PlayerEngine

    'Local Variables
    Private resourceFilePath


    Public Sub initmap(Currentmap, loadarg)
        If Currentmap = "SplashMap_Part1" Then
            Currentmap = New SplashMap_Part1

        ElseIf Currentmap = "SplashMap_Part2" Then
            Currentmap = New SplashMap_Part2
        ElseIf Currentmap = "SplashMap_Part3" Then
            Currentmap = New SplashMap_Part3
        Else
            Game.Hide()
            SaveFileCorroupted.ShowDialog()
            Game.Close()
        End If
        Game.CurrentMap = Currentmap
        Currentmap.initialise()
        If System.Diagnostics.Debugger.IsAttached() Then
            resourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
        Else
            resourceFilePath = Application.StartupPath & "\resources\"

        End If
        Game.bgplayer.close()
        Game.bgplayer.URL = resourceFilePath & "\Music\" & Currentmap.MapTrack & ".wav"

        Dim Style
        If loadarg = "FromSave" Then
            For RowCount = 1 To 10 Step 1
                For ColumnCount = 1 To 20 Step 1
                    Style = FileWrite.ReadFromTable(RowCount - 1, ColumnCount + 29)
                    PlaceTile(RowCount - 1, ColumnCount - 1, Style, "ForAndBack")
                Next
            Next
        Else
            For RowCount = 0 To 9 Step 1
                For ColumnCount = 0 To 19 Step 1
                    Style = Currentmap.charset(RowCount, ColumnCount)
                    PlaceTile(RowCount, ColumnCount, Style, "ForAndBack")
                Next
            Next
        End If
        Player.initplayer(loadarg)
        FileWrite.SaveGame()
    End Sub

    Public Sub PlaceTile(X, Y, tile, Special)
        Try
            Dim Cursor As PictureBox = Game.Controls("X" & X + 1 & "Y" & Y + 1)
            Select Case Special
                Case "ForAndBack"
                    Game.DrawnDisplay(X, Y) = tile
                    Cursor.Image = My.Resources.ResourceManager.GetObject(tile)
                    Cursor.BackgroundImage = My.Resources.ResourceManager.GetObject(tile)
                    If tile = "PathAxe" Then
                        Dim tiledat As TileData = New TileData
                        tiledat.Initialise()
                        Game.TileDataArray(X, Y, 0) = tiledat.TileData(8, 3)
                    ElseIf tile = "PickAxe" Then
                        Dim tiledat As TileData = New TileData
                        tiledat.Initialise()
                        Game.TileDataArray(X, Y, 0) = tiledat.TileData(12, 3)
                    ElseIf tile = "EnemyTurret" Then
                        Game.EnemyArray(X - 1, Y - 1) = "EnemyTurrent"
                    End If
                    Exit Sub
                Case "NoOverdraw"
                    Cursor.Image = My.Resources.ResourceManager.GetObject(tile)
                    Game.DrawnDisplay(X, Y) = tile
                Case "PlayerMove"
                    Cursor = Game.Controls("X" & Game.PlayerPreviousX & "Y" & Game.PlayerPreviousY)
                    Cursor.Image = My.Resources.ResourceManager.GetObject(Game.DrawnDisplay(Game.PlayerPreviousX - 1, Game.PlayerPreviousY - 1))
                    Cursor = Game.Controls("X" & X & "Y" & Y)
                    Cursor.Image = My.Resources.ResourceManager.GetObject(tile)
                    Game.PlayerPreviousX = X
                    Game.PlayerPreviousY = Y
                Case "PlayerInit"
                    Cursor = Game.Controls("X" & X & "Y" & Y)
                    Cursor.Image = My.Resources.ResourceManager.GetObject(tile)
            End Select
        Catch ex As Exception
            Message.debug("[ER] PlaceTile: " & ex.Message)
        End Try
    End Sub
End Class