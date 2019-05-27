Public Class SelecterEngine


    Public Sub OpenSelecter(tile)
        Game.Selectermode = True
        Game.SelecterX = Game.PlayerCurrentX
        Game.SelecterY = Game.PlayerCurrentY
        SelectDrawer("Open")
    End Sub

    Public Sub CloseSelecter()
        Game.Selectermode = False
        SelectDrawer("Close")
    End Sub

    'XXX bound check
    Public Sub SelectHandler(action)
        Dim cursorUI As CursorEngine = New CursorEngine
        Select Case action
            Case "w"
                SelectDrawer("Up")
            Case "a"
                SelectDrawer("Left")
            Case "s"
                SelectDrawer("Down")
            Case "d"
                SelectDrawer("Right")
            Case "W"
                SelectDrawer("Up")
            Case "A"
                SelectDrawer("Left")
            Case "S"
                SelectDrawer("Down")
            Case "D"
                SelectDrawer("Right")
            Case "1"
                Dim display As DisplayEngine = New DisplayEngine
                Select Case Game.SelectedTile
                    Case "PathAxe"
                        Select Case Game.DrawnDisplay(Game.SelecterX - 1, Game.SelecterY - 1)
                            Case "TreeSmall"
                                cursorUI.process("AxeTree")
                            Case "TreeNew"
                                cursorUI.process("AxeTree")
                        End Select
                    Case "PlaceAxe"
                        CloseSelecter()
                        Dim tiledat As TileData = New TileData
                        tiledat.Initialise()
                        Select Case Game.DrawnDisplay(Game.SelecterX - 1, Game.SelecterY - 1)
                            Case "PathBlack"
                                If Not tiledat.TileData(0, 1) = True Then
                                    Exit Sub
                                End If
                            Case "SandPlain"
                                If Not tiledat.TileData(6, 1) = True Then
                                    Exit Sub
                                End If
                            Case Else
                                Exit Sub

                        End Select
                        Inventory.RemoveItem("PathAxe")
                        display.PlaceTile(Game.SelecterX - 1, Game.SelecterY - 1, "PathAxe", "ForAndBack")
                    Case "WoodPlank"
                        Dim x = Game.DrawnDisplay(Game.SelecterX - 1, Game.SelecterY - 1)
                        If x = "SandPlain" Or x = "WaterDown" Or x = "WaterNew" Or x = "PathBlack" Then
                            Inventory.RemoveItem("WoodPlank")
                            display.PlaceTile(Game.SelecterX - 1, Game.SelecterY - 1, "WoodPlank", "ForAndBack")
                            If Not Inventory.ContainsItem("WoodPlank", 1) Then
                                Dim selecter As SelecterEngine = New SelecterEngine
                                selecter.CloseSelecter()
                            End If
                        End If
                    Case "PickAxe"
                        Select Case Game.DrawnDisplay(Game.SelecterX - 1, Game.SelecterY - 1)
                            Case "RockSmall"
                                cursorUI.process("MineSmall")
                            Case "RockBig"
                                cursorUI.process("MineLarge")
                        End Select
                End Select
            Case "2"


            Case "3"
                SelectDrawer("Close")
        End Select
    End Sub

    Private Sub SelectDrawer(Dir)
        Dim cursor As PictureBox = Game.Controls("X" & Game.SelecterX & "Y" & Game.SelecterY)
        Dim cursorUI As CursorEngine = New CursorEngine
        Select Case Dir
            Case "Open"
                cursor.BorderStyle = BorderStyle.Fixed3D
                cursorUI.Display("Selecter")
            Case "Close"
                cursor.BorderStyle = BorderStyle.None
                Game.Selectermode = False
                cursorUI.Display(Game.CurrentMap.charset(Game.PlayerCurrentX - 1, Game.PlayerCurrentY - 1))
            Case "Up"
                If Game.SelecterX = 1 Then
                    Exit Sub
                ElseIf Game.SelecterX = Game.PlayerCurrentX - 5 Then
                    Exit Sub
                End If
                cursor.BorderStyle = BorderStyle.None
                Game.SelecterX += -1
                cursor = Game.Controls("X" & Game.SelecterX & "Y" & Game.SelecterY)
                cursor.BorderStyle = BorderStyle.Fixed3D
            Case "Down"
                If Game.SelecterX = 10 Then
                    Exit Sub
                ElseIf Game.SelecterX = Game.PlayerCurrentX + 5 Then
                    Exit Sub
                End If
                cursor.BorderStyle = BorderStyle.None
                Game.SelecterX += 1
                cursor = Game.Controls("X" & Game.SelecterX & "Y" & Game.SelecterY)
                cursor.BorderStyle = BorderStyle.Fixed3D
            Case "Left"
                If Game.SelecterY = 1 Then
                    Exit Sub
                ElseIf Game.SelecterY = Game.PlayerCurrentY - 5 Then
                    Exit Sub
                End If
                cursor.BorderStyle = BorderStyle.None
                Game.SelecterY += -1
                cursor = Game.Controls("X" & Game.SelecterX & "Y" & Game.SelecterY)
                cursor.BorderStyle = BorderStyle.Fixed3D
            Case "Right"
                If Game.SelecterY = 20 Then
                    Exit Sub
                ElseIf Game.SelecterY = Game.PlayerCurrenty + 5 Then
                    Exit Sub
                End If
                cursor.BorderStyle = BorderStyle.None
                Game.SelecterY += 1
                cursor = Game.Controls("X" & Game.SelecterX & "Y" & Game.SelecterY)
                cursor.BorderStyle = BorderStyle.Fixed3D
        End Select
    End Sub
End Class
