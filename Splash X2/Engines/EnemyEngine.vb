'Public Class EnemyEngine

'    Private HarmRange = 5
'    Private HarmQuantity = 4
'    Public Sub EnemyBoundCheck()
'        If HarmCheck() = True Then
'            Dim health As HealthEngine = New HealthEngine
'            health.harm(HarmQuantity)
'        End If
'    End Sub

'    Private Function HarmCheck()

'        For i = 0 To HarmRange Step 1
'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX + i, Game.PlayerCurrentY) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try

'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX + i, Game.PlayerCurrentY - i) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try

'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX + i, Game.PlayerCurrentY + i) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try

'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX, Game.PlayerCurrentY + i) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try

'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX, Game.PlayerCurrentY - i) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try

'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX - i, Game.PlayerCurrentY) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try

'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX - i, Game.PlayerCurrentY - i) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try

'            Try
'                If Game.EnemyArray(Game.PlayerCurrentX - i, Game.PlayerCurrentY + i) = "EnemyTurret" Then
'                    Return (False)
'                End If
'            Catch
'            End Try
'        Next

'            Return (True)
'    End Function
'End Class
