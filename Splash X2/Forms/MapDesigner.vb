Public Class MapDesigner
    Public selectedTile = "PathBlack"
    Public selectorx = 1
    Public selectory = 1
    Public drawndisplay(10, 20)

    Private Sub MapDesigner_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cursor As PictureBox
        selectorx = 1
        selectedTile = "PathBlack"
        selectory = 1
        For rowcount = 0 To 9 Step 1
            For columncount = 0 To 19 Step 1
                Try
                    cursor = Me.Controls("X" & rowcount + 1 & "Y" & columncount + 1)
                    cursor.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                    Dim Style = FileWrite.ReadFromTable(rowcount, columncount + 30)
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
                Case "a"
                    If selectory = 1 Then
                        Exit Sub
                    End If
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.None
                    selectory += -1
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                Case "s"
                    If selectorx = 10 Then
                        Exit Sub
                    End If
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.None
                    selectorx += 1
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                Case "d"
                    If selectory = 20 Then
                        Exit Sub
                    End If
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.None
                    selectory += 1
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.BorderStyle = BorderStyle.Fixed3D
                Case "1"
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                    drawndisplay(selectorx - 1, selectory - 1) = selectedTile
                Case "3"
                    cursor = Controls("X" & selectorx & "Y" & selectory)
                    cursor.Image = My.Resources.PathBlack
                Case "+"
                    Me.Controls.Clear()
                    Me.InitializeComponent()
                    MapDesigner_Load(Me, EventArgs.Empty)
                Case "f"
                    For rowcount = 0 To 9 Step 1
                        For columncount = 0 To 19 Step 1
                            Try
                                Dim style = selectedTile
                                cursor = Me.Controls("X" & rowcount + 1 & "Y" & columncount + 1)
                                cursor.Image = My.Resources.ResourceManager.GetObject(selectedTile)
                                drawndisplay(rowcount, columncount) = style
                            Catch
                            End Try
                        Next
                    Next
                Case "2"
                    Button2_Click(Me, EventArgs.Empty)
            End Select
        Catch ex As Exception
            Dim err = ex.Message
        End Try
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub MapDesigner_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Game.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cursor As PictureBox
        For rowcount = 0 To 9 Step 1
            For columncount = 0 To 19 Step 1
                Try
                    Cursor = Me.Controls("X" & rowcount + 1 & "Y" & columncount + 1)
                    cursor.Image = My.Resources.PathBlack
                    drawndisplay(rowcount, columncount) = selectedTile

                Catch
                End Try
            Next
        Next
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) 

    End Sub
End Class