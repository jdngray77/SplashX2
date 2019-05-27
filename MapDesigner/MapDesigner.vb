Public Class MapDesigner
    Public selectedTile = "PathBlack"
    Public SecondaryTile = "TreeNew"
    Public selectorx = 1
    Public selectory = 1
    Public drawndisplay(10, 20)
    Public fillsize = 1


    Private Sub MapDesigner_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cursor As PictureBox
        Label3.Text = "Fill size: " & fillsize + 2
        itemlist.Items.Add("PathAxe")
        ItemList.Items.Add("PathBlack")
        ItemList.Items.Add("PathExit")
        ItemList.Items.Add("RockBig")
        ItemList.Items.Add("RockSmall")
        ItemList.Items.Add("SandCactus")
        ItemList.Items.Add("SandPlain")
        itemlist.Items.Add("SavePoint")
        itemlist.Items.Add("TreeSmall")
        itemlist.Items.Add("WaterDown")
        itemlist.Items.Add("EnemyTurrets")
        itemlist.Items.Add("WoodPlank")
        itemlist.Items.Add("PickAxe")
        itemlist.Items.Add("EnemyBase")
        itemlist.Items.Add("WaterNew")
        itemlist.Items.Add("TreeNew")
        itemlist.Items.Add("SaveNew")
        FileWrite.LoadData()
        selectorx = 1
        selectedTile = "PathBlack"
        ItemList.SelectedItem = selectedTile
        selectory = 1
        For rowcount = 0 To 9 Step 1
            For columncount = 0 To 19 Step 1
                Try
                    cursor = Me.Controls("X" & rowcount + 1 & "Y" & columncount + 1)
                    cursor.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                    Dim Style = FileWrite.ReadFromTable(rowcount, columncount + 30)
                    If Style = "" Then
                        Style = "PathBlack"
                    End If

                    drawndisplay(rowcount, columncount) = Style
                    Try
                        cursor.Image = My.Resources.ResourceManager.GetObject(Style)
                    Catch
                        cursor.Image = My.Resources.PathBlack
                    End Try

                Catch
                End Try
            Next
        Next

        cursor = Controls("X" & selectorx & "Y" & selectory)
        cursor.BorderStyle = BorderStyle.Fixed3D
        Me.KeyPreview = True
    End Sub

    Private Sub MapDesigner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim cursor As PictureBox
        Try
            Select Case e.KeyChar
                Case "w"
                    If selectorx = 1 Then
                        Exit Sub
                    End If
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.None
                    selectorx += -1
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                    Label4.Text = "X" & selectorx & "Y" & selectory
                Case "a"
                    If selectory = 1 Then
                        Exit Sub
                    End If
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.None
                    selectory += -1
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                    Label4.Text = "X" & selectorx & "Y" & selectory
                Case "s"
                    If selectorx = 10 Then
                        Exit Sub
                    End If
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.None
                    selectorx += 1
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                    Label4.Text = "X" & selectorx & "Y" & selectory
                Case "d"
                    If selectory = 20 Then
                        Exit Sub
                    End If
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.None
                    selectory += 1
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                    Label4.Text = "X" & selectorx & "Y" & selectory
                Case "1"
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                    drawndisplay(selectorx - 1, selectory - 1) = selectedTile
                    FileWrite.WriteToTable(selectorx - 1, selectory + 29, selectedTile)
                    FileWrite.SaveToFile()
                Case "2"
                    selectedTile = drawndisplay(selectorx - 1, selectory - 1)
                    DisplaySelected.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                Case "3"
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.Image = My.Resources.ResourceManager.GetObject(SecondaryTile)
                    drawndisplay(selectorx - 1, selectory - 1) = SecondaryTile
                    FileWrite.WriteToTable(selectorx - 1, selectory + 29, SecondaryTile)
                Case "5"
                    SecondaryTile = selectedTile
                    DisplaySecond.Image = My.Resources.ResourceManager.GetObject(SecondaryTile)
                Case "*"
                    Dim intent = MsgBox("Reload form?", MessageBoxButtons.YesNo)
                    If Not intent = vbYes Then
                        Exit Sub
                    End If
                    Me.Controls.Clear()
                    Me.InitializeComponent()
                    MapDesigner_Load(Me, EventArgs.Empty)
                Case "7"
                    Dim ReplaceCursor As PictureBox
                    Dim TileToReplace = drawndisplay(selectorx - 1, selectory - 1)
                    For rowcount = -1 To fillsize Step 1
                        For columncount = -1 To fillsize Step 1
                            Try
                                If drawndisplay(selectorx - 1 + rowcount, selectory - 1 + columncount) = TileToReplace Then
                                    ReplaceCursor = Me.Controls("X" & selectorx + rowcount & "Y" & selectory + columncount)
                                    ReplaceCursor.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                                    drawndisplay(rowcount + (selectorx - 1), columncount + (selectory - 1)) = selectedTile
                                    FileWrite.WriteToTable(selectorx - 1, selectory + 29, selectedTile)
                                End If
                            Catch
                            End Try
                        Next
                    Next
                Case "8"
                    Dim intent = MsgBox("Fill entire canvas?", MessageBoxButtons.YesNo)
                    If Not intent = vbYes Then
                        Exit Sub
                    End If
                    For rowcount = 0 To 9 Step 1
                        For columncount = 0 To 19 Step 1
                            Try
                                Dim style = selectedTile
                                cursor = Me.Controls("X" & rowcount + 1 & "Y" & columncount + 1)
                                cursor.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                                drawndisplay(rowcount, columncount) = style
                                FileWrite.WriteToTable(selectorx - 1, selectory + 29, style)
                            Catch
                            End Try
                        Next
                    Next
                    FileWrite.SaveToFile()
                Case "4"
                    If itemlist.SelectedIndex = 0 Then
                        Exit Sub
                    End If
                    itemlist.SelectedIndex += -1
                    selectedTile = ItemList.SelectedItem
                    DisplaySelected.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                Case "6"
                    If ItemList.SelectedIndex = ItemList.Items.Count Then
                        Exit Sub
                    End If
                    ItemList.SelectedIndex += 1
                    selectedTile = ItemList.SelectedItem
                    DisplaySelected.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                Case "9"
                    Dim intent = MsgBox("Clear the entire canvas?", MessageBoxButtons.YesNo)
                    If Not intent = vbYes Then
                        Exit Sub
                    End If
                    Button2_Click(Me, EventArgs.Empty)
                Case "-"
                    If fillsize = 0 Then
                        Exit Sub
                    End If
                    fillsize += -1
                    Label3.Text = "Fill size: " & fillsize + 2
                Case "+"
                    If fillsize = 5 Then
                        Exit Sub
                    End If
                    fillsize += 1
                    Label3.Text = "Fill size: " & fillsize + 2
            End Select
        Catch ex As Exception
            Dim err = ex.Message
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For rowcount = 1 To 10 Step 1
            For columncount = 1 To 20 Step 1
                Try
                    FileWrite.WriteToTable(rowcount - 1, columncount + 29, drawndisplay(rowcount - 1, columncount - 1))
                Catch ex As Exception

                End Try
            Next
        Next
        FileWrite.SaveToFile()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim cursor As PictureBox
        For rowcount = 0 To 9 Step 1
            For columncount = 0 To 19 Step 1
                Try
                    cursor = Me.Controls("X" & rowcount + 1 & "Y" & columncount + 1)
                    cursor.Image = My.Resources.PathBlack
                    drawndisplay(rowcount, columncount) = "PathBlack"
                    FileWrite.WriteToTable(selectorx - 1, selectory + 29, "PathBlack")
                Catch
                End Try
            Next
        Next
        FileWrite.SaveToFile()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1_Click(Me, EventArgs.Empty)
        FileWrite.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Button1_Click(Me, EventArgs.Empty)
        Export.Show()
    End Sub

    Private Sub DisplayPathAxe_Click(sender As Object, e As EventArgs) Handles DisplayPathAxe.Click
        selectedTile = "PathAxe"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayTreeSmall_Click(sender As Object, e As EventArgs) Handles DisplayTreeSmall.Click
        selectedTile = "TreeSmall"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplaySavePoint_Click(sender As Object, e As EventArgs) Handles DisplaySavePoint.Click
        selectedTile = "SavePoint"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayWaterDown_Click(sender As Object, e As EventArgs) Handles DisplayWaterDown.Click
        selectedTile = "WaterDown"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplaySandPlain_Click(sender As Object, e As EventArgs) Handles DisplaySandPlain.Click
        selectedTile = "SandPlain"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayRockSmall_Click(sender As Object, e As EventArgs) Handles DisplayRockSmall.Click
        selectedTile = "RockSmall"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplaySandCactus_Click(sender As Object, e As EventArgs) Handles DisplaySandCactus.Click
        selectedTile = "SandCactus"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayRockBig_Click(sender As Object, e As EventArgs) Handles DisplayRockBig.Click
        selectedTile = "RockBig"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayPathExit_Click(sender As Object, e As EventArgs) Handles DisplayPathExit.Click
        selectedTile = "PathExit"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayPathBlack_Click(sender As Object, e As EventArgs) Handles DisplayPathBlack.Click
        selectedTile = "PathBlack"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayWaterNew_Click(sender As Object, e As EventArgs) Handles DisplayWaterNew.Click
        selectedTile = "WaterNew"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayTreeNew_Click(sender As Object, e As EventArgs) Handles DisplayTreeNew.Click
        selectedTile = "TreeNew"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplaySaveNew_Click(sender As Object, e As EventArgs) Handles DisplaySaveNew.Click
        selectedTile = "SaveNew"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles DisplayBase.Click
        selectedTile = "EnemyBase"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayTurret_Click(sender As Object, e As EventArgs) Handles DisplayTurret.Click
        selectedTile = "EnemyTurrets"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub Label4_TextChanged(sender As Object, e As EventArgs) Handles Label4.TextChanged
        Export.Label20.Text = "X" & selectorx & "Y" & selectory
        Export.Label12.Text = "X" & selectorx - 1 & "Y" & selectory - 1
    End Sub

    Private Sub MapDesigner_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FileWrite.SaveToFile()
    End Sub

    Private Sub DisplayWoodenPlanks_Click(sender As Object, e As EventArgs) Handles DisplayWoodenPlanks.Click
        selectedTile = "WoodPlank"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub

    Private Sub DisplayPickAxe_Click(sender As Object, e As EventArgs) Handles DisplayPickAxe.Click
        selectedTile = "PickAxe"
        DisplaySelected.Text = "Selected: " & selectedTile
    End Sub
End Class