Public Class PlayerEngine
    'Public Variables
    Public Transport = "foot"

    'Object References


    Public Sub initplayer(loadarg)
        Dim x, y
        Dim Display As DisplayEngine = New DisplayEngine
        Select Case loadarg
            Case "FromSave"
                x = FileWrite.ReadFromTable(3, 3)
                y = FileWrite.ReadFromTable(4, 3)
                Display.PlaceTile(x, y, "idle", "PlayerInit")
            Case Else

                x = Game.CurrentMap.startx
                y = Game.CurrentMap.starty
                Display.PlaceTile(x, y, "idle", "PlayerInit")
        End Select
        Game.PlayerCurrentX = x
        Game.PlayerCurrentY = y
        Game.PlayerPreviousX = x
        Game.PlayerPreviousY = y
        FileWrite.WriteToTable(3, 3, x)
        FileWrite.WriteToTable(4, 3, y)
        FileWrite.WriteToTable(3, 3, x)
        FileWrite.WriteToTable(4, 3, y)
    End Sub

    Public Sub Move(Dir)
        Game.movementcount += 1
        If Game.movementcount = 8 Then
            Dim story As StoryEngine = New StoryEngine
            story.trigger("Movement")
        End If
        Game.DisplayPos.Text = "X" & Game.PlayerCurrentX & "Y" & Game.PlayerCurrentY
        Dim display As DisplayEngine = New DisplayEngine
        Select Case Dir
            Case "Up"
                Game.SelecterCallX = Game.PlayerCurrentX - 1
                Game.SelecterCallY = Game.PlayerCurrentY
                If Game.PlayerCurrentX = 1 Then
                    Exit Sub
                End If

                If TileBoundary(Game.DrawnDisplay(Game.PlayerCurrentX - 2, Game.PlayerCurrentY - 1)) = True Then
                    Game.PlayerCurrentX += -1
                    display.PlaceTile(Game.PlayerCurrentX, Game.PlayerCurrentY, "idle", "PlayerMove")
                End If
            Case "Down"
                Game.SelecterCallX = Game.PlayerCurrentX + 1
                Game.SelecterCallY = Game.PlayerCurrentY
                If Game.PlayerCurrentX = 10 Then
                    Exit Sub
                End If
                If TileBoundary(Game.DrawnDisplay(Game.PlayerCurrentX, Game.PlayerCurrentY - 1)) = True Then
                    Game.PlayerCurrentX += 1
                    display.PlaceTile(Game.PlayerCurrentX, Game.PlayerCurrentY, "idle", "PlayerMove")

                End If
            Case "Right"
                Game.SelecterCallY = Game.PlayerCurrentY + 1
                Game.SelecterCallX = Game.PlayerCurrentX
                If Game.PlayerCurrentY = 20 Then
                    Exit Sub
                End If
                If TileBoundary(Game.DrawnDisplay(Game.PlayerCurrentX - 1, Game.PlayerCurrentY)) = True Then
                    Game.PlayerCurrentY += 1
                    display.PlaceTile(Game.PlayerCurrentX, Game.PlayerCurrentY, "idle", "PlayerMove")

                End If
            Case "Left"
                Game.SelecterCallY = Game.PlayerCurrentY - 1
                Game.SelecterCallX = Game.PlayerCurrentX
                If Game.PlayerCurrentY = 1 Then
                    Exit Sub
                End If
                If TileBoundary(Game.DrawnDisplay(Game.PlayerCurrentX - 1, Game.PlayerCurrentY - 2)) = True Then
                    Game.PlayerCurrentY += -1
                    display.PlaceTile(Game.PlayerCurrentX, Game.PlayerCurrentY, "idleLeft", "PlayerMove")
                End If
        End Select
        Game.DisplayPos.Text = "X" & Game.PlayerCurrentX & "Y" & Game.PlayerCurrentY
    End Sub

    Private Function TileBoundary(Tile)
        Dim cursor As CursorEngine = New CursorEngine
        cursor.Display(Tile)
        Dim TileDatabase As TileData = New TileData
        TileDatabase.Initialise()
        Dim transporttype = 1
        ' Dim enemy As EnemyEngine = New EnemyEngine
        'enemy.EnemyBoundCheck()
        Select Case Transport
            Case "foot"
                transporttype = 1
            Case "Air"
                transporttype = 0
            Case "Heavy"
                transporttype = 2
        End Select

        Select Case Tile
            Case "PathBlack"
                Return (TileDatabase.TileData(0, transporttype))
            Case "PathAxe"
                Return (TileDatabase.TileData(8, transporttype))
            Case "WoodPlank"
                Return (TileDatabase.TileData(11, transporttype))
            Case "PathExit"
                Return (True)
            Case "RockBig"
                Return (TileDatabase.TileData(2, transporttype))
            Case "RockSmall"
                Return (TileDatabase.TileData(2, transporttype))
            Case "SandCactus"
                Return (TileDatabase.TileData(7, transporttype))
            Case "SandPlain"
                Return (TileDatabase.TileData(6, transporttype))
            Case "SavePoint"
                Return (TileDatabase.TileData(9, transporttype))
            Case "TreeSmall"
                Return (TileDatabase.TileData(4, transporttype))
            Case "WaterDown"
                Return (TileDatabase.TileData(5, transporttype))
            Case "StoryPointerDown"
                Game.CurrentMap.storyline("StoryPointer")
                Return (TileDatabase.TileData(10, transporttype))
            Case "StoryPointerLeft"
                Game.CurrentMap.storyline("StoryPointer")
                Return (TileDatabase.TileData(10, transporttype))
            Case "StoryPointerUp"
                Game.CurrentMap.storyline("StoryPointer")
                Return (TileDatabase.TileData(10, transporttype))
            Case "StoryPointerRight"
                Game.CurrentMap.storyline("StoryPointer")
                Return (TileDatabase.TileData(10, transporttype))
        End Select
        Return (False)
    End Function

End Class
