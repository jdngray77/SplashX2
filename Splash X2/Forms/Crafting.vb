Public Class Crafting
    Private Sub Crafting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        ItemList.Items.Clear()
        ItemList.Items.AddRange({"PathAxe", "PickAxe", "Tank"})
        ItemList.SelectedIndex = 1
        ItemUpdate
    End Sub


    Private craftable
    Private selected
Private Sub ItemUpdate()
        selected = ItemList.SelectedIndex
        Try
            DisplayItemCurrent.Image = My.Resources.ResourceManager.GetObject(ItemList.SelectedItem)
            Try
                ItemList.SelectedIndex += -1
                DisplayItemPrev.Image = My.Resources.ResourceManager.GetObject(ItemList.SelectedItem)
            Catch
            End Try
            Try
                ItemList.SelectedIndex += 2
                DisplayItemNext.Image = My.Resources.ResourceManager.GetObject(ItemList.SelectedItem)
            Catch
            End Try
        Catch ex As Exception

            End Try
        ItemList.SelectedIndex = selected

        Select Case ItemList.SelectedItem
            Case "PathAxe"
                lblTitle.Text = "Axe"
                lblDesc.Text = "Used to cut trees!"
                Req1.Image = My.Resources.WoodPlank
                If Inventory.ContainsItem("WoodPlank", 2) Then
                    txtReq1.BackColor = Color.Green
                Else
                    txtreq1.backcolor = Color.red
                End If
                txtReq1.Text = "2X Wooden Planks"


                Req2.Image = My.Resources.Stone
                If Inventory.ContainsItem("Stone", 3) Then
                    txtReq2.BackColor = Color.Green
                Else
                    txtReq2.BackColor = Color.Red
                End If
                txtReq2.Text = "3X Stone"



                Req3.Image = My.Resources.nullBlack
                txtReq3.ResetText()
                txtReq3.BackColor = Color.Black


            Case "PickAxe"
                craftable = True
                lblTitle.Text = "Pick Axe"
                lblDesc.Text = "Used to mine minerals and rocks"
                Req1.Image = My.Resources.Iron
                If Inventory.ContainsItem("Iron", 2) Then
                    txtReq1.BackColor = Color.Green
                Else
                    txtReq1.BackColor = Color.Red
                    craftable = False
                End If
                txtReq1.Text = "2X Iron"


                Req2.Image = My.Resources.WoodPlank
                If Inventory.ContainsItem("WoodPlank", 3) Then
                    txtReq2.BackColor = Color.Green
                Else
                    txtReq2.BackColor = Color.Red
                    craftable = False
                End If
                txtReq2.Text = "3X Wooden Planks"



                Req3.Image = My.Resources.nullBlack
                txtReq3.ResetText()
                txtReq3.BackColor = Color.Black


            Case "Tank"
                craftable = True
                lblTitle.Text = "Tank"
                lblDesc.Text = "Offensive and Defensive!"
                Req1.Image = My.Resources.Stone
                If Inventory.ContainsItem("Stone", 2) Then
                    txtReq1.BackColor = Color.Green
                Else
                    txtReq1.BackColor = Color.Red
                End If
                txtReq1.Text = "2X Stone"


                Req2.Image = My.Resources.Iron
                If Inventory.ContainsItem("Iron", 2) Then
                    txtReq2.BackColor = Color.Green
                Else
                    txtReq2.BackColor = Color.Red
                End If
                txtReq2.Text = "2X Iron"

                Req3.Image = My.Resources.nullBlack
                txtReq3.ResetText()
                txtReq3.BackColor = Color.Black
        End Select
    End Sub

    Private Sub Crafting_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar.ToString.ToLower
            Case "s"

                If ItemList.SelectedIndex = ItemList.Items.Count - 1 Then
                    Exit Sub
                Else
                    DisplayItemCurrent.Image = My.Resources.nullBlack
                    DisplayItemNext.Image = My.Resources.nullBlack
                    DisplayItemPrev.Image = My.Resources.nullBlack
                    ItemList.SelectedIndex += 1
                    ItemUpdate()
                End If
            Case "w"

                If ItemList.SelectedIndex = 0 Then
                    Exit Sub
                Else
                    DisplayItemCurrent.Image = My.Resources.nullBlack
                    DisplayItemNext.Image = My.Resources.nullBlack
                    DisplayItemPrev.Image = My.Resources.nullBlack
                    ItemList.SelectedIndex += -1
                    ItemUpdate()
                End If

            Case "3"
                Me.Close()
            Case "1"
                If craftable = False Then
                    Exit Sub
                End If
                Select Case ItemList.SelectedItem
                    Case "PathAxe"
                        Inventory.RemoveItem("WoodPlank")
                        Inventory.RemoveItem("WoodPlank")
                        Inventory.RemoveItem("Stone")
                        Inventory.RemoveItem("Stone")
                        Inventory.RemoveItem("Stone")
                        Inventory.AddItem("PathAxe")
                    Case "PickAxe"
                        Inventory.RemoveItem("Iron")
                        Inventory.RemoveItem("Iron")
                        Inventory.RemoveItem("WoodPlank")
                        Inventory.RemoveItem("WoodPlank")
                        Inventory.RemoveItem("WoodPlank")
                        Inventory.AddItem("PickAxe")

                    Case "Tank"
                        Inventory.RemoveItem("Iron")
                        Inventory.RemoveItem("Iron")
                        Inventory.RemoveItem("Stone")
                        Inventory.RemoveItem("Stone")
                        Inventory.AddItem("Tank")
                End Select
                ItemUpdate()
        End Select

    End Sub
End Class