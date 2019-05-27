Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        CurrentCommand(1) = "ShinkOS"
        Dim x As Process = Process.GetCurrentProcess()
        writeNew("ShinkOS Console test - Ver 0.0.1", False, False)
        writeNew("Mem Usage: " & x.WorkingSet64 & "k" & vbCrLf & "Paged Memory: " & x.PagedMemorySize64 & " K", False, True)
        TextBox2.Select()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            newCommand()
            TextBox2.ResetText()
            If e.KeyChar = "*" Then
                Me.Hide()
                SplashMenu.Show()
            End If
        End If
    End Sub

    Private loadCursor
    Private autoclear = False
    Private CurrentCommand(1)
    Private Sub newCommand()
        If Not CurrentCommand(0) = True Then
            CurrentCommand(1) = "ShinkOS"
            Select Case TextBox2.Text.ToLower
                Case "run"

                    writeNew("run > Preparing to execute..", True, True)
                    Threading.Thread.Sleep(1000)
                    Me.Hide()

                    Try
                        loadCursor.show
                        If Not loadCursor = Nothing Then
                            writeNew("run > Failed to execute!", True, True)
                        End If

                    Catch ex As Exception
                        writeNew("run > Failed to execute: " & ex.Message, True, True)
                    End Try


                Case "print"
                    CurrentCommand(0) = True
                    CurrentCommand(1) = "print"
                    writeNew("print > Enter text to print:", False, True)
                Case "exit"
                    End
                Case "clear"
                    writeNew("", False, True)
                Case "cls"
                    writeNew("", False, True)
                Case "set"
                    CurrentCommand(0) = True
                    CurrentCommand(1) = "set"
                    writeNew("Select object to set", False, True)
                Case "load"
                    CurrentCommand(0) = True
                    CurrentCommand(1) = "load"
                    writeNew("load > Select object to load", True, True)
                Case "getmem"
                    Dim x As Process = Process.GetCurrentProcess()
                    writeNew("Mem Usage: " & x.WorkingSet64 & "k" & vbCrLf & "Paged Memory: " & x.PagedMemorySize64 & " K", True, True)
                Case Else
                    writeNew(CurrentCommand(1) & " > " & TextBox2.Text & ": Intent unknown.", True, True)
            End Select
        Else
            Select Case CurrentCommand(1)
                Case "print"
                    CurrentCommand(0) = False
                    writeNew(TextBox2.Text, False, True)

                Case "set"
                    Select Case TextBox2.Text.ToLower
                        Case "autoclear"
                            If autoclear = True Then
                                autoclear = False
                            Else
                                autoclear = True
                            End If
                            writeNew("autoclear > Toggled AutoClear to: " & autoclear, False, True)
                            CurrentCommand(0) = False
                    End Select
                Case "load"
                    Select Case TextBox2.Text.ToLower
                        Case "splash x2"
                            loadCursor = New SplashMenu
                        Case "map designer"
                            loadCursor = New MapDesigner
                        Case Else
                            CurrentCommand(0) = False
                            writeNew("load > Unable to locate object. Exiting load.", True, True)
                            Exit Sub
                    End Select
                    CurrentCommand(0) = False
                    writeNew("Load > Sucsessfully Loaded:" & TextBox2.Text, True, True)

            End Select
        End If

    End Sub


    Private WriteMemory(1, 100)
    Private Sub writeNew(Line, append, write)
        If write = False Then
            WriteMemory(1, 1) += 1
            WriteMemory(0, WriteMemory(1, 1)) = Line
        Else
            If autoclear = True Then
                TextBox1.ResetText()
            End If
            WriteMemory(1, 1) += 1
                WriteMemory(0, WriteMemory(1, 1)) = Line
                If append = False Then
                    TextBox1.ResetText()
                End If
                For i = 1 To WriteMemory(1, 1) Step 1
                    TextBox1.Text += vbCrLf & WriteMemory(0, i)
                Next

                WriteMemory(1, 1) = 0
            End If
    End Sub
End Class
