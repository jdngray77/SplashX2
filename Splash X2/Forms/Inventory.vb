Public Class Inventory
    Public Slots(1, 3, 1)
    Public Sub RemoveItem(item)
        'slot 1
        If Slots(1, 1, 0) = item Then
            If Slots(1, 1, 1) = 1 Then
                Slots(1, 1, 0) = ""
                PicSlot1.Image = My.Resources.nullBlack
                Game.InvDisplay1.Image = My.Resources.nullBlack
                lblSlot1.Text = "Empty"
            Else
                Slots(1, 1, 1) += -1
                lblSlot2.Text = Slots(1, 1, 1) & "X " & item
            End If
            'slot 2
        ElseIf Slots(1, 2, 0) = item Then
            If Slots(1, 2, 1) = 1 Then
                Slots(1, 2, 0) = ""
                PicSlot2.Image = My.Resources.nullBlack
                Game.InvDisplay2.Image = My.Resources.nullBlack
                lblSlot2.Text = "Empty"
            Else
                Slots(1, 2, 1) += -1
                lblSlot2.Text = Slots(1, 2, 1) & "X " & item
            End If
            'slot 3
        ElseIf Slots(1, 3, 0) = item Then
            If Slots(1, 3, 1) = 1 Then
                If Slots(1, 3, 1) = 1 Then
                    Slots(1, 3, 0) = ""
                    PicSlot3.Image = My.Resources.nullBlack
                    Game.InvDisplay3.Image = My.Resources.nullBlack
                    lblSlot3.Text = "Empty"
                Else
                    Slots(1, 3, 1) += -1
                    lblSlot2.Text = Slots(1, 3, 1) & "X " & item
                End If
            End If

        End If
    End Sub

    Public Sub AddItem(item)
        'slot 1
        If Slots(1, 1, 0) = item Then
            Slots(1, 1, 1) += 1
            lblSlot1.Text = Slots(1, 1, 1) & "X " & item
        ElseIf Slots(1, 2, 0) = item Then
            Slots(1, 2, 1) += 1
            lblSlot2.Text = Slots(1, 2, 1) & "X " & item
        ElseIf Slots(1, 3, 0) = item Then
            Slots(1, 3, 1) += 1
            lblSlot3.Text = Slots(1, 3, 1) & "X " & item

        ElseIf Slots(1, 1, 0) = Nothing Then
            Slots(1, 1, 0) = item
            Slots(1, 1, 1) = 1
            PicSlot1.Image = My.Resources.ResourceManager.GetObject(item)
            Game.InvDisplay1.Image = My.Resources.ResourceManager.GetObject(item)
            lblSlot1.Text = Slots(1, 1, 1) & "X " & item

            ' slot 2
        ElseIf Slots(1, 2, 0) = Nothing Then
            Slots(1, 2, 0) = item
            Slots(1, 2, 1) = 1
            PicSlot2.Image = My.Resources.ResourceManager.GetObject(item)
            Game.InvDisplay2.Image = My.Resources.ResourceManager.GetObject(item)
            lblSlot2.Text = Slots(1, 2, 1) & "X " & item

            'slot 3
        ElseIf Slots(1, 3, 0) = Nothing Then
            Slots(1, 3, 0) = item
            Slots(1, 3, 1) = 1
            PicSlot3.Image = My.Resources.ResourceManager.GetObject(item)
            Game.InvDisplay3.Image = My.Resources.ResourceManager.GetObject(item)
            lblSlot3.Text = Slots(1, 3, 1) & "X " & item
        End If
    End Sub

    Private Sub Inventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Game.Show()
    End Sub

    Private Sub Inventory_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.Gray
    End Sub

    Private Sub Inventory_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Navy
    End Sub

    Private menuIndex = 1
    Private Sub Inventory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "d"
                If Not menuIndex = 3 Then
                    Dim cursor As PictureBox = Me.Controls("PicSlot" & menuIndex)
                    cursor.BorderStyle = BorderStyle.None
                    menuIndex += 1
                    cursor = Me.Controls("PicSlot" & menuIndex)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                End If
            Case "a"
                If Not menuIndex = 1 Then
                    Dim cursor As PictureBox = Me.Controls("PicSlot" & menuIndex)
                    cursor.BorderStyle = BorderStyle.None
                    menuIndex -= 1
                    cursor = Me.Controls("PicSlot" & menuIndex)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                End If
            Case "4"
                Me.Hide()
                Game.Show()
            Case "e"
                Me.Hide()
                Game.Show()
            Case "E"
                Me.Hide()
                Game.Show()
            Case "1"
                Dim selecter As SelecterEngine = New SelecterEngine
                Select Case Slots(1, menuIndex, 0)
                    Case "PathAxe"
                        Game.SelectedTile = "PlaceAxe"
                        selecter.OpenSelecter("")
                        Me.Hide()
                        Game.Show()
                    Case "Apple"
                        Dim cursorUI As CursorEngine = New CursorEngine
                        cursorUI.Display("Apple")
                        RemoveItem("Apple")
                    Case "WoodPlank"
                        Game.SelectedTile = "WoodPlank"
                        selecter.OpenSelecter("")
                        Me.Hide()
                        Game.Show()
                End Select
            Case "5"
                Crafting.ShowDialog()
        End Select
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cursor As PictureBox = Me.Controls("PicSlot" & menuIndex)
        cursor = Me.Controls("PicSlot" & menuIndex)
        cursor.BorderStyle = BorderStyle.Fixed3D
        lblSlot1.ResetText()
        lblSlot2.ResetText()
        lblSlot3.ResetText()
    End Sub

    Public Function ContainsItem(item, quantity)
        If Not quantity = 0 Then
            If Slots(1, 1, 0) = item Then
                If Slots(1, 1, 1) >= quantity Then
                    Return (True)
                End If
                Exit Function
            ElseIf Slots(1, 2, 0) = item Then
                If Slots(1, 2, 1) >= quantity Then
                    Return (True)
                End If
                Exit Function
            ElseIf Slots(1, 3, 0) = item Then
                If Slots(1, 3, 1) >= quantity Then
                    Return (True)
                End If
                Exit Function
            End If
        Else
            If Slots(1, 1, 0) = item Then
                Return (True)
                Exit Function
            ElseIf Slots(1, 2, 0) = item Then
                Return (True)
                Exit Function
            ElseIf Slots(1, 3, 0) = item Then
                Return (True)
                Exit Function
            End If
        End If
        Return (False)
    End Function

    Private Sub Inventory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim cursor As Label
        For i = 1 To 3 Step 1
            cursor = Me.Controls("lblSlot" & i)
            Try
                cursor.Text = Slots(1, i, 1) & "X " & Slots(1, i, 0)
                If cursor.Text = "X " Then
                    cursor.Text = "Empty"
                End If
            Catch
                cursor.Text = "Empty"
            End Try
        Next
    End Sub
End Class