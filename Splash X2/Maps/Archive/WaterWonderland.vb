Public Class SplashMap
    '====Map Info====
    Public MapDrawn(10, 20)

    Public MapName = "SplashMap"
    Public MapFamily = "SplashMap"
    Public MapTrack = "CrimsonDrive"
    Public StartX = 4
    Public StartY = 4

    'Active Components
    Public exitSet(9, 19)
    Public exitName(9, 19)

    Public charSet(10, 20) As Object

    Public Sub Initialise()
        'Exits

        'Character Set

        'Row 0
        charSet(0, 0) = "WaterNew"
        charSet(0, 1) = "WaterNew"
        charSet(0, 2) = "WaterNew"
        charSet(0, 3) = "WaterNew"
        charSet(0, 4) = "WaterNew"
        charSet(0, 5) = "WaterNew"
        charSet(0, 6) = "WaterNew"
        charSet(0, 7) = "WaterNew"
        charSet(0, 8) = "WaterNew"
        charSet(0, 9) = "WaterNew"
        charSet(0, 10) = "WaterNew"
        charSet(0, 11) = "WaterNew"
        charSet(0, 12) = "WaterNew"
        charSet(0, 13) = "WaterNew"
        charSet(0, 14) = "WaterNew"
        charSet(0, 15) = "WaterNew"
        charSet(0, 16) = "WaterNew"
        charSet(0, 17) = "WaterNew"
        charSet(0, 18) = "WaterNew"
        charSet(0, 19) = "WaterNew"

        'Row 1
        charSet(1, 0) = "WaterNew"
        charSet(1, 1) = "WaterNew"
        charSet(1, 2) = "WaterNew"
        charSet(1, 3) = "SandPlain"
        charSet(1, 4) = "SandPlain"
        charSet(1, 5) = "SandPlain"
        charSet(1, 6) = "SandPlain"
        charSet(1, 7) = "WaterNew"
        charSet(1, 8) = "WaterNew"
        charSet(1, 9) = "WaterNew"
        charSet(1, 10) = "WaterNew"
        charSet(1, 11) = "WaterNew"
        charSet(1, 12) = "WaterNew"
        charSet(1, 13) = "WaterNew"
        charSet(1, 14) = "WaterNew"
        charSet(1, 15) = "WaterNew"
        charSet(1, 16) = "WaterNew"
        charSet(1, 17) = "WaterNew"
        charSet(1, 18) = "WaterNew"
        charSet(1, 19) = "WaterNew"

        'Row 2
        charSet(2, 0) = "WaterNew"
        charSet(2, 1) = "WaterNew"
        charSet(2, 2) = "SandPlain"
        charSet(2, 3) = "SandPlain"
        charSet(2, 4) = "SandPlain"
        charSet(2, 5) = "SandPlain"
        charSet(2, 6) = "SandPlain"
        charSet(2, 7) = "SandPlain"
        charSet(2, 8) = "SandPlain"
        charSet(2, 9) = "WaterNew"
        charSet(2, 10) = "WaterNew"
        charSet(2, 11) = "WaterNew"
        charSet(2, 12) = "WaterNew"
        charSet(2, 13) = "WaterNew"
        charSet(2, 14) = "WaterNew"
        charSet(2, 15) = "WaterNew"
        charSet(2, 16) = "WaterNew"
        charSet(2, 17) = "WaterNew"
        charSet(2, 18) = "WaterNew"
        charSet(2, 19) = "WaterNew"

        'Row 3
        charSet(3, 0) = "WaterNew"
        charSet(3, 1) = "WaterNew"
        charSet(3, 2) = "SandPlain"
        charSet(3, 3) = "SandPlain"
        charSet(3, 4) = "SandPlain"
        charSet(3, 5) = "SandPlain"
        charSet(3, 6) = "SandPlain"
        charSet(3, 7) = "SaveNew"
        charSet(3, 8) = "SandPlain"
        charSet(3, 9) = "WaterNew"
        charSet(3, 10) = "WaterNew"
        charSet(3, 11) = "WaterNew"
        charSet(3, 12) = "WaterNew"
        charSet(3, 13) = "WaterNew"
        charSet(3, 14) = "WaterNew"
        charSet(3, 15) = "WaterNew"
        charSet(3, 16) = "WaterNew"
        charSet(3, 17) = "WaterNew"
        charSet(3, 18) = "WaterNew"
        charSet(3, 19) = "WaterNew"

        'Row 4
        charSet(4, 0) = "WaterNew"
        charSet(4, 1) = "SandPlain"
        charSet(4, 2) = "SandPlain"
        charSet(4, 3) = "SandPlain"
        charSet(4, 4) = "TreeSmall"
        charSet(4, 5) = "SandPlain"
        charSet(4, 6) = "SandPlain"
        charSet(4, 7) = "SandPlain"
        charSet(4, 8) = "SandPlain"
        charSet(4, 9) = "WaterNew"
        charSet(4, 10) = "WaterNew"
        charSet(4, 11) = "WaterNew"
        charSet(4, 12) = "WaterNew"
        charSet(4, 13) = "WaterNew"
        charSet(4, 14) = "WaterNew"
        charSet(4, 15) = "WaterNew"
        charSet(4, 16) = "WaterNew"
        charSet(4, 17) = "WaterNew"
        charSet(4, 18) = "WaterNew"
        charSet(4, 19) = "WaterNew"

        'Row 5
        charSet(5, 0) = "WaterNew"
        charSet(5, 1) = "WaterNew"
        charSet(5, 2) = "SandPlain"
        charSet(5, 3) = "SandPlain"
        charSet(5, 4) = "SandPlain"
        charSet(5, 5) = "SandPlain"
        charSet(5, 6) = "SandPlain"
        charSet(5, 7) = "SandPlain"
        charSet(5, 8) = "WaterNew"
        charSet(5, 9) = "WaterNew"
        charSet(5, 10) = "WaterNew"
        charSet(5, 11) = "WaterNew"
        charSet(5, 12) = "WaterNew"
        charSet(5, 13) = "WaterNew"
        charSet(5, 14) = "WaterNew"
        charSet(5, 15) = "WaterNew"
        charSet(5, 16) = "WaterNew"
        charSet(5, 17) = "WaterNew"
        charSet(5, 18) = "WaterNew"
        charSet(5, 19) = "WaterNew"

        'Row 6
        charSet(6, 0) = "WaterNew"
        charSet(6, 1) = "WaterNew"
        charSet(6, 2) = "WaterNew"
        charSet(6, 3) = "SandPlain"
        charSet(6, 4) = "SandPlain"
        charSet(6, 5) = "SandPlain"
        charSet(6, 6) = "SandPlain"
        charSet(6, 7) = "WaterNew"
        charSet(6, 8) = "WaterNew"
        charSet(6, 9) = "WaterNew"
        charSet(6, 10) = "WaterNew"
        charSet(6, 11) = "WaterNew"
        charSet(6, 12) = "WaterNew"
        charSet(6, 13) = "WaterNew"
        charSet(6, 14) = "WaterNew"
        charSet(6, 15) = "WaterNew"
        charSet(6, 16) = "WaterNew"
        charSet(6, 17) = "WaterNew"
        charSet(6, 18) = "WaterNew"
        charSet(6, 19) = "WaterNew"

        'Row 7
        charSet(7, 0) = "WaterNew"
        charSet(7, 1) = "WaterNew"
        charSet(7, 2) = "SandPlain"
        charSet(7, 3) = "WaterNew"
        charSet(7, 4) = "SandPlain"
        charSet(7, 5) = "WaterNew"
        charSet(7, 6) = "WaterNew"
        charSet(7, 7) = "WaterNew"
        charSet(7, 8) = "WaterNew"
        charSet(7, 9) = "WaterNew"
        charSet(7, 10) = "WaterNew"
        charSet(7, 11) = "WaterNew"
        charSet(7, 12) = "WaterNew"
        charSet(7, 13) = "WaterNew"
        charSet(7, 14) = "WaterNew"
        charSet(7, 15) = "WaterNew"
        charSet(7, 16) = "WaterNew"
        charSet(7, 17) = "WaterNew"
        charSet(7, 18) = "WaterNew"
        charSet(7, 19) = "WaterNew"

        'Row 8
        charSet(8, 0) = "WaterNew"
        charSet(8, 1) = "WaterNew"
        charSet(8, 2) = "WaterNew"
        charSet(8, 3) = "WaterNew"
        charSet(8, 4) = "WaterNew"
        charSet(8, 5) = "WaterNew"
        charSet(8, 6) = "WaterNew"
        charSet(8, 7) = "WaterNew"
        charSet(8, 8) = "WaterNew"
        charSet(8, 9) = "WaterNew"
        charSet(8, 10) = "WaterNew"
        charSet(8, 11) = "WaterNew"
        charSet(8, 12) = "WaterNew"
        charSet(8, 13) = "WaterNew"
        charSet(8, 14) = "WaterNew"
        charSet(8, 15) = "WaterNew"
        charSet(8, 16) = "WaterNew"
        charSet(8, 17) = "WaterNew"
        charSet(8, 18) = "WaterNew"
        charSet(8, 19) = "WaterNew"

        'Row 9
        charSet(9, 0) = "WaterNew"
        charSet(9, 1) = "WaterNew"
        charSet(9, 2) = "WaterNew"
        charSet(9, 3) = "WaterNew"
        charSet(9, 4) = "WaterNew"
        charSet(9, 5) = "WaterNew"
        charSet(9, 6) = "WaterNew"
        charSet(9, 7) = "WaterNew"
        charSet(9, 8) = "WaterNew"
        charSet(9, 9) = "WaterNew"
        charSet(9, 10) = "WaterNew"
        charSet(9, 11) = "WaterNew"
        charSet(9, 12) = "WaterNew"
        charSet(9, 13) = "WaterNew"
        charSet(9, 14) = "WaterNew"
        charSet(9, 15) = "WaterNew"
        charSet(9, 16) = "WaterNew"
        charSet(9, 17) = "WaterNew"
        charSet(9, 18) = "WaterNew"
        charSet(9, 19) = "WaterNew"
    End Sub


    Public Sub StoryLine(trigger)
        Dim story As storyEngine = New storyEngine
        Dim message As MessageEngine = New MessageEngine
        Dim display As DisplayEngine = New DisplayEngine
        Select Case game.StoryProgress
            Case 1
                If trigger = "Load" Then
                End If
        End Select
    End Sub
End Class
