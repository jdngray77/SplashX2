Public Class BehaviourEngine

    'If Action = 1 Then
    'ElseIf Action = 2 Then
    'ElseIf Action = 3 Then
    'End If

    Public Sub PlayerAction(Action)
        Dim selecter As SelecterEngine = New SelecterEngine
        Dim Cursor As CursorEngine = New CursorEngine
        Select Case Game.SelectedTile

            Case "TreeSmall"
                If Action = 1 Then
                    Cursor.Display("AppleCollect")
                    Inventory.AddItem("Apple")
                End If
            Case "TreeNew"
                If Action = 1 Then
                    Cursor.Display("AppleCollect")
                    Inventory.AddItem("Apple")
                End If
            Case "PathAxe"
                If Action = 1 Then
                    If Game.Selectermode = False Then
                        selecter.Openselecter(Game.SelectedTile)
                    Else
                        selecter.SelectHandler("Select")
                    End If
                ElseIf Action = 2 Then
                    If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = 5 Then
                        Dim display As DisplayEngine = New DisplayEngine
                        display.PlaceTile(Game.SelecterCallX - 1, Game.SelecterCallY - 1, "PathBlack", "ForAndBack")
                        Inventory.AddItem(Game.SelectedTile)
                    End If
                End If
            Case "PickAxe"
                If Action = 1 Then
                    If Game.Selectermode = False Then
                        selecter.OpenSelecter(Game.SelectedTile)
                    Else
                        selecter.SelectHandler("Select")
                    End If
                ElseIf Action = 2 Then
                    If Game.TileDataArray(Game.SelecterCallX - 1, Game.SelecterCallY - 1, 0) = 5 Then
                        Dim display As DisplayEngine = New DisplayEngine
                        display.PlaceTile(Game.SelecterCallX - 1, Game.SelecterCallY - 1, "PathBlack", "ForAndBack")
                        Inventory.AddItem(Game.SelectedTile)
                    End If
                End If
            Case "SavePoint"
                Cursor.Display("Saved")
                FileWrite.SaveGame()
            Case "PathExit"
                Dim display As DisplayEngine = New DisplayEngine
                Dim debus = Game.CurrentMap
                Dim maptoload = Game.CurrentMap.exitset(Game.PlayerCurrentX - 1, Game.PlayerCurrentY - 1)
                display.initmap(maptoload, "null")

        End Select
    End Sub
End Class
