Public Class CursorEngine


    Public Sub Display(Tile)
        If Not Tile = "Selecter" Then
            Game.SelectedTile = Tile
        End If

        Game.PicCursor.Image = My.Resources.ResourceManager.GetObject(Tile)
        Select Case Tile
            Case "Selecter"
                Game.lblCursorTitle.Text = "Selecter"
                Game.lblCursor1.Text = "1: Use item on"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.Text = "3: Cancel"
            Case "PathExit"
                Game.lblCursorTitle.Text = "Exit to " & Game.CurrentMap.exitName(Game.PlayerCurrentX - 1, Game.PlayerCurrentY - 1)
                Game.lblCursor1.Text = "1: Exit"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "PathBlack"
                Game.lblCursorTitle.Text = "Path"
                Game.lblCursor1.Text = "Glad i'm"
                Game.lblCursor2.Text = "wearing shoes!"
                Game.lblCursor3.ResetText()
            Case "RockBig"
                Game.lblCursorTitle.Text = "Boulder"
                Game.lblCursor1.Text = "Too big to climb"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "RockSmall"
                Game.lblCursorTitle.Text = "Pile Of Rocks"
                Game.lblCursor1.Text = "To unstable"
                Game.lblCursor2.Text = "To climb"
                Game.lblCursor3.ResetText()
            Case "TreeSmall"
                Game.lblCursorTitle.Text = "Tree"
                Game.lblCursor1.Text = "1: Shake"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "TreeNew"
                Game.lblCursorTitle.Text = "Tree"
                Game.lblCursor1.Text = "1: Shake"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "WaterDown"
                Game.lblCursorTitle.Text = "Water"
                Game.lblCursor1.Text = "I can't swim!"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "WaterNew"
                Game.lblCursorTitle.Text = "Water"
                Game.lblCursor1.Text = "I can't swim!"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "PickAxe"
                Game.lblCursorTitle.Text = "Pick Axe"
                Game.lblCursor1.Text = "1: Mine"
                Game.lblCursor2.Text = "2: Collect"
                Game.lblCursor3.ResetText()
            Case "SandCactus"
                Game.lblCursorTitle.Text = "A cactus"
                Game.lblCursor1.Text = "Ouch"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
                Dim health As HealthEngine = New HealthEngine
                health.harm(1)
            Case "SandPlain"
                Game.lblCursorTitle.Text = "Beach"
                Game.lblCursor1.Text = "How lovely!"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "Apple"
                Game.lblCursorTitle.Text = "Apple"
                Game.lblCursor1.Text = "+1 HP"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
                Dim Health As HealthEngine = New HealthEngine
                Health.heal(1)
            Case "AppleCollect"
                Game.PicCursor.Image = My.Resources.Apple
                Game.lblCursorTitle.Text = "Collected: Apple"
                Game.lblCursor1.ResetText()
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "PathAxe"
                Game.lblCursorTitle.Text = "Axe"
                Game.lblCursor1.Text = "1: Use"
                Game.lblCursor2.Text = "2: Pick up"
                Game.lblCursor3.ResetText()
            Case "WoodPlank"
                Game.lblCursorTitle.Text = "Wooden Plank"
                Game.lblCursor1.Text = "Surprisingly soft underfoot"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "SavePoint"
                Game.lblCursorTitle.Text = "Save Point"
                Game.lblCursor1.Text = "1: Use"
                Game.lblCursor2.ResetText()
            Case "SaveNew"
                Game.lblCursorTitle.Text = "Save Point"
                Game.lblCursor1.Text = "1: Use"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "Saved"
                Game.lblCursorTitle.Text = "Saved!"
                Game.lblCursor1.ResetText()
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "StoryPointerLeft"
                Game.lblCursorTitle.Text = "A quest!"
                Game.lblCursor1.ResetText()
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "StoryPointerRight"
                Game.lblCursorTitle.Text = "A quest!"
                Game.lblCursor1.ResetText()
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "StoryPointerUp"
                Game.lblCursorTitle.Text = "A quest!"
                Game.lblCursor1.ResetText()
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
            Case "StoryPointerDown"
                Game.lblCursorTitle.Text = "A quest!"
                Game.lblCursor1.ResetText()
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
        End Select
    End Sub


    Public Sub process(Action)
        Game.actionstore = Action
        Select Case Action
            Case "AxeTree"
                If Not Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = Nothing Then
                    If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = 1 Then
                        Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = "-1"
                    Else
                        Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) += -1
                    End If
                End If
                Game.PicCursor.Image = My.Resources.PathAxe
                Game.lblCursorTitle.Text = "Cutting tree"
                Game.ProcessHandler(1000)
                If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = "-1" Then
                    Dim Display As DisplayEngine = New DisplayEngine
                    Display.PlaceTile(Game.SelecterCallX - 1, Game.SelecterCallY - 1, "PathBlack", "ForAndBack")
                    Dim selecter As SelecterEngine = New SelecterEngine
                    selecter.CloseSelecter()
                    Exit Sub
                End If
            Case "MineLarge"
                If Not Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = Nothing Then
                    If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = 1 Then
                        Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = "-1"
                    Else
                        Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) += -1
                    End If
                End If
                Game.PicCursor.Image = My.Resources.PickAxe
                Game.lblCursorTitle.Text = "Mining Boulder"
                Game.ProcessHandler(1000)
                If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = "-1" Then
                    Dim Display As DisplayEngine = New DisplayEngine
                    Display.PlaceTile(Game.SelecterCallX - 1, Game.SelecterCallY - 1, "PathBlack", "ForAndBack")
                    Dim selecter As SelecterEngine = New SelecterEngine
                    selecter.CloseSelecter()
                    Exit Sub
                End If
            Case "MineSmall"
                If Not Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = Nothing Then
                    If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = 1 Then
                        Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = "-1"
                    Else
                        Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) += -1
                    End If
                End If
                Game.PicCursor.Image = My.Resources.PickAxe
                Game.lblCursorTitle.Text = "Mining Stones"
                Game.ProcessHandler(1000)
                If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = "-1" Then
                    Dim Display As DisplayEngine = New DisplayEngine
                    Display.PlaceTile(Game.SelecterCallX - 1, Game.SelecterCallY - 1, "PathBlack", "ForAndBack")
                    Dim selecter As SelecterEngine = New SelecterEngine
                    selecter.CloseSelecter()
                    Exit Sub
                End If
        End Select
    End Sub

    Public Sub ProcessComplete()
        Dim display As DisplayEngine = New DisplayEngine
        Select Case Game.actionstore
            Case "AxeTree"
                Game.lblCursorTitle.Text = "Done!"
                Game.lblCursor1.ResetText()
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
                display.PlaceTile(Game.SelecterX - 1, Game.SelecterY - 1, "PathBlack", "ForAndBack")
                Inventory.AddItem("WoodPlank")
            Case "MineSmall"
                Game.lblCursorTitle.Text = "Done!"
                Game.lblCursor1.Text = "Collected Stone"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
                display.PlaceTile(Game.SelecterX - 1, Game.SelecterY - 1, "PathBlack", "ForAndBack")
                Inventory.AddItem("Stone")
            Case "MineLarge"
                Game.lblCursorTitle.Text = "Done!"
                Game.lblCursor1.Text = "Collected Iron"
                Game.lblCursor2.ResetText()
                Game.lblCursor3.ResetText()
                display.PlaceTile(Game.SelecterX - 1, Game.SelecterY - 1, "PathBlack", "ForAndBack")
                Inventory.AddItem("Iron")
        End Select
    End Sub
End Class
