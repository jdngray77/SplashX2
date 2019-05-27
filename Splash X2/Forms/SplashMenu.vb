Public Class SplashMenu
    'XXX MUSIC FROM JOHN SO
    Public Sub SplashMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menuindex = 1
        Splashimg.Image = My.Resources.LegalSplash
        My.Computer.Audio.Play(My.Resources.Splash, AudioPlayMode.Background)
        MenuTimer.Start()
        Sel1.Hide()
        Sel2.Hide()
        Sel3.Hide()
        Sel4.Hide()
        Sel5.Hide()
        Sel1.ResetText()
        Sel2.ResetText()
        Sel3.ResetText()
        Sel4.ResetText()
        Sel5.ResetText()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label7.Hide()
        lbl6.Hide()
        Label5.Hide()
        menushow = False
        Me.Select()
    End Sub

    Public menushow = False
    Private Sub MenuTimer_Tick(sender As Object, e As EventArgs) Handles MenuTimer.Tick
        MenuTimer.Stop()
        If Me.BackColor = Color.Navy Then
            Menudisplay()
            Exit Sub
        End If
        Label4.Show()
    End Sub

    Public Menuindex = 1
    Private Sub SplashMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If menushow = False Then
            If e.KeyChar = "3" Then
                Splashimg.Image = My.Resources.SplashLogo
                MenuTimer.Stop()
                Menudisplay()
                Exit Sub
            End If
        End If
        If e.KeyChar = "w" Or e.KeyChar = "W" Then
            MenuUpdate("Up")
        ElseIf e.KeyChar = "s" Or e.KeyChar = "W" Then
            MenuUpdate("Down")
        ElseIf e.KeyChar = "1" Then
            menuselect()
        ElseIf e.KeyChar = "+" Then
            Me.Controls.Clear()
            Me.InitializeComponent()
            SplashMenu_Load(Me, EventArgs.Empty)
        End If
    End Sub


    Private prevCursor = "Sel1"
    Private Sub MenuUpdate(Dir)
        If menushow = False Then
            Exit Sub
        ElseIf MenuTimer.Enabled = True Then
            Exit Sub
        End If
        Select Case Dir
            Case "Up"
                If Menuindex = 1 Then
                    Exit Sub
                End If

                Menuindex += -1
            Case "Down"

                If Menuindex = 5 Then
                    Exit Sub
                End If

                Menuindex += 1
        End Select
        Dim selcursor = "Sel" & Menuindex
        Dim cursor As Label = Me.Controls(prevCursor)
        cursor.ResetText()
        cursor = Me.Controls(selcursor)
        cursor.Text = "►"
        prevCursor = selcursor
    End Sub


    Private Sub Menudisplay()
        Menuindex = 1
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Hide()
        lbl6.Show()
        Label7.Show()
        Label5.Show()
        Sel1.Show()
        Sel2.Show()
        Sel3.Show()
        Sel4.Show()
        Sel5.Show()
        Sel1.Text = "►"
        menushow = True
    End Sub

    Private Sub MenuHide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        lbl6.Hide()
        Label7.Hide()
        Label5.Hide()
        Sel1.Hide()
        Sel2.Hide()
        Sel3.Hide()
        Sel4.Hide()
        Sel5.Hide()
        menushow = False
    End Sub

    Public Sub menuselect()
        If menushow = False Then
            Exit Sub
        ElseIf MenuTimer.Enabled = True Then
            Exit Sub
        End If
        Select Case Menuindex
            Case 1
                'Continue

                My.Computer.Audio.Stop()
                Me.Hide()
                Game.ShowDialog()
            Case 2
                'New
                Dim intent = MsgBox("This will overwrite the current file, are you sure?", MessageBoxButtons.YesNo)
                My.Computer.Audio.Stop()
                Select Case intent
                    Case vbYes
                        Try
                            System.IO.File.Delete("CharData.csv")
                            Inventory.Close()
                        Catch
                        End Try
                        Me.Hide()
                        Game.ShowDialog()
                    Case vbNo
                        Exit Sub
                End Select
            Case 3
                'options.show()
                ' languages
                ' graphics modes
            Case 4
                About.ShowDialog()
                Me.Hide()
            Case 5
                End
            Case 9
                Game.Close()
                Try
                    System.IO.File.Delete("CharData.csv")
                Catch
                End Try
                Game.Show()
                Menuindex = 1
        End Select
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Menudisplay()
        MenuTimer.Stop()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        End
    End Sub

    Private Sub lbl6_Click(sender As Object, e As EventArgs) Handles lbl6.Click
        About.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim intent = MsgBox("This will overwrite the current file, are you sure?", MessageBoxButtons.YesNo)
        Select Case intent
            Case vbYes
                Try
                    System.IO.File.Delete("CharData.csv")
                Catch
                End Try
                Me.Hide()
                Game.ShowDialog()
            Case vbNo
                Exit Sub
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Game.ShowDialog()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub SplashMenu_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.BackColor = Color.Gray
        Label4.Show()
        MenuHide()
    End Sub

    Private Sub SplashMenu_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.BackColor = Color.Navy
        If MenuTimer.Enabled = True Then
            Exit Sub
        End If
        Label4.Hide()
        Menudisplay()
    End Sub

    Private Sub SplashMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class