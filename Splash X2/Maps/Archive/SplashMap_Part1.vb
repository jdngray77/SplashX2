Public Class SplashMap_Part1

    '====Map Info====
    Public MapDrawn(10, 20)

    Public MapName = "SplashMap_Part1"
    Public MapFamily = "SplashMap"
    Public MapTrack = "CrimsonDrive"
    Public StartX = 1
    Public StartY = 2

    'Active Components
    Public exitSet(9, 19)
    Public exitName(9, 19)

    Public charSet(10, 20) As Object
    Public Sub Initialise()
        'Exits

        'Next Area
        exitSet(9, 19) = "SplashMap_Part3"
        exitName(9, 19) = "Next Area"
        'Next Area
        exitSet(8, 19) = "SplashMap_Part3"
        exitName(8, 19) = "Next Area"
        'Character Set

        'Row 0
        charSet(0, 0) = "PathBlack"
        charSet(0, 1) = "PathBlack"
        charSet(0, 2) = "PathBlack"
        charSet(0, 3) = "RockSmall"
        charSet(0, 4) = "TreeNew"
        charSet(0, 5) = "TreeNew"
        charSet(0, 6) = "TreeNew"
        charSet(0, 7) = "TreeNew"
        charSet(0, 8) = "TreeNew"
        charSet(0, 9) = "TreeNew"
        charSet(0, 10) = "TreeNew"
        charSet(0, 11) = "TreeNew"
        charSet(0, 12) = "TreeNew"
        charSet(0, 13) = "PathBlack"
        charSet(0, 14) = "PathBlack"
        charSet(0, 15) = "PathBlack"
        charSet(0, 16) = "PathBlack"
        charSet(0, 17) = "PathBlack"
        charSet(0, 18) = "PathBlack"
        charSet(0, 19) = "PathBlack"

        'Row 1
        charSet(1, 0) = "PathBlack"
        charSet(1, 1) = "PathAxe"
        charSet(1, 2) = "PathBlack"
        charSet(1, 3) = "RockSmall"
        charSet(1, 4) = "TreeNew"
        charSet(1, 5) = "TreeNew"
        charSet(1, 6) = "TreeNew"
        charSet(1, 7) = "TreeNew"
        charSet(1, 8) = "TreeNew"
        charSet(1, 9) = "TreeNew"
        charSet(1, 10) = "PathBlack"
        charSet(1, 11) = "TreeNew"
        charSet(1, 12) = "PathBlack"
        charSet(1, 13) = "SandPlain"
        charSet(1, 14) = "SandPlain"
        charSet(1, 15) = "SandPlain"
        charSet(1, 16) = "SandPlain"
        charSet(1, 17) = "SandPlain"
        charSet(1, 18) = "SandCactus"
        charSet(1, 19) = "SandPlain"

        'Row 2
        charSet(2, 0) = "PathBlack"
        charSet(2, 1) = "TreeNew"
        charSet(2, 2) = "TreeNew"
        charSet(2, 3) = "TreeNew"
        charSet(2, 4) = "TreeNew"
        charSet(2, 5) = "TreeNew"
        charSet(2, 6) = "TreeNew"
        charSet(2, 7) = "TreeNew"
        charSet(2, 8) = "TreeNew"
        charSet(2, 9) = "TreeNew"
        charSet(2, 10) = "PathBlack"
        charSet(2, 11) = "PathBlack"
        charSet(2, 12) = "SandPlain"
        charSet(2, 13) = "WaterNew"
        charSet(2, 14) = "WaterNew"
        charSet(2, 15) = "WaterNew"
        charSet(2, 16) = "WaterNew"
        charSet(2, 17) = "WaterNew"
        charSet(2, 18) = "WaterNew"
        charSet(2, 19) = "WaterNew"

        'Row 3
        charSet(3, 0) = "TreeNew"
        charSet(3, 1) = "TreeNew"
        charSet(3, 2) = "TreeNew"
        charSet(3, 3) = "TreeNew"
        charSet(3, 4) = "TreeNew"
        charSet(3, 5) = "TreeNew"
        charSet(3, 6) = "TreeNew"
        charSet(3, 7) = "TreeNew"
        charSet(3, 8) = "TreeNew"
        charSet(3, 9) = "TreeNew"
        charSet(3, 10) = "SandCactus"
        charSet(3, 11) = "SandPlain"
        charSet(3, 12) = "WaterNew"
        charSet(3, 13) = "WaterNew"
        charSet(3, 14) = "WaterNew"
        charSet(3, 15) = "WaterNew"
        charSet(3, 16) = "WaterNew"
        charSet(3, 17) = "WaterNew"
        charSet(3, 18) = "WaterNew"
        charSet(3, 19) = "WaterNew"

        'Row 4
        charSet(4, 0) = "SandCactus"
        charSet(4, 1) = "SandPlain"
        charSet(4, 2) = "TreeNew"
        charSet(4, 3) = "TreeNew"
        charSet(4, 4) = "TreeNew"
        charSet(4, 5) = "TreeNew"
        charSet(4, 6) = "SandPlain"
        charSet(4, 7) = "SandPlain"
        charSet(4, 8) = "SandPlain"
        charSet(4, 9) = "SandPlain"
        charSet(4, 10) = "WaterNew"
        charSet(4, 11) = "WaterNew"
        charSet(4, 12) = "WaterNew"
        charSet(4, 13) = "WaterNew"
        charSet(4, 14) = "SandPlain"
        charSet(4, 15) = "SandPlain"
        charSet(4, 16) = "SandPlain"
        charSet(4, 17) = "SandCactus"
        charSet(4, 18) = "SandPlain"
        charSet(4, 19) = "SandPlain"

        'Row 5
        charSet(5, 0) = "WaterNew"
        charSet(5, 1) = "SandPlain"
        charSet(5, 2) = "SandPlain"
        charSet(5, 3) = "TreeNew"
        charSet(5, 4) = "RockSmall"
        charSet(5, 5) = "SandPlain"
        charSet(5, 6) = "WaterNew"
        charSet(5, 7) = "WaterNew"
        charSet(5, 8) = "WaterNew"
        charSet(5, 9) = "WaterNew"
        charSet(5, 10) = "WaterNew"
        charSet(5, 11) = "WaterNew"
        charSet(5, 12) = "SandPlain"
        charSet(5, 13) = "SandCactus"
        charSet(5, 14) = "PathBlack"
        charSet(5, 15) = "PathBlack"
        charSet(5, 16) = "PathBlack"
        charSet(5, 17) = "PathBlack"
        charSet(5, 18) = "RockSmall"
        charSet(5, 19) = "PathBlack"

        'Row 6
        charSet(6, 0) = "WaterNew"
        charSet(6, 1) = "WaterNew"
        charSet(6, 2) = "SandPlain"
        charSet(6, 3) = "SandPlain"
        charSet(6, 4) = "SandPlain"
        charSet(6, 5) = "WaterNew"
        charSet(6, 6) = "WaterNew"
        charSet(6, 7) = "WaterNew"
        charSet(6, 8) = "WaterNew"
        charSet(6, 9) = "WaterNew"
        charSet(6, 10) = "WaterNew"
        charSet(6, 11) = "SandPlain"
        charSet(6, 12) = "SandPlain"
        charSet(6, 13) = "PathBlack"
        charSet(6, 14) = "PathBlack"
        charSet(6, 15) = "PathBlack"
        charSet(6, 16) = "PathBlack"
        charSet(6, 17) = "PathBlack"
        charSet(6, 18) = "PathBlack"
        charSet(6, 19) = "PathBlack"

        'Row 7
        charSet(7, 0) = "WaterNew"
        charSet(7, 1) = "WaterNew"
        charSet(7, 2) = "SandPlain"
        charSet(7, 3) = "WaterNew"
        charSet(7, 4) = "WaterNew"
        charSet(7, 5) = "WaterNew"
        charSet(7, 6) = "WaterNew"
        charSet(7, 7) = "SandCactus"
        charSet(7, 8) = "SandPlain"
        charSet(7, 9) = "SandPlain"
        charSet(7, 10) = "SandPlain"
        charSet(7, 11) = "PathBlack"
        charSet(7, 12) = "PathBlack"
        charSet(7, 13) = "PathBlack"
        charSet(7, 14) = "PathBlack"
        charSet(7, 15) = "SaveNew"
        charSet(7, 16) = "PathBlack"
        charSet(7, 17) = "PathBlack"
        charSet(7, 18) = "PathBlack"
        charSet(7, 19) = "PathBlack"

        'Row 8
        charSet(8, 0) = "WaterNew"
        charSet(8, 1) = "WaterNew"
        charSet(8, 2) = "WaterNew"
        charSet(8, 3) = "WaterNew"
        charSet(8, 4) = "WaterNew"
        charSet(8, 5) = "WaterNew"
        charSet(8, 6) = "SandPlain"
        charSet(8, 7) = "SandPlain"
        charSet(8, 8) = "SandPlain"
        charSet(8, 9) = "SandPlain"
        charSet(8, 10) = "PathBlack"
        charSet(8, 11) = "PathBlack"
        charSet(8, 12) = "PathBlack"
        charSet(8, 13) = "PathBlack"
        charSet(8, 14) = "PathBlack"
        charSet(8, 15) = "PathBlack"
        charSet(8, 16) = "PathBlack"
        charSet(8, 17) = "PathBlack"
        charSet(8, 18) = "PathBlack"
        charSet(8, 19) = "PathExit"

        'Row 9
        charSet(9, 0) = "WaterNew"
        charSet(9, 1) = "WaterNew"
        charSet(9, 2) = "WaterNew"
        charSet(9, 3) = "WaterNew"
        charSet(9, 4) = "WaterNew"
        charSet(9, 5) = "WaterNew"
        charSet(9, 6) = "SandPlain"
        charSet(9, 7) = "SandPlain"
        charSet(9, 8) = "SandPlain"
        charSet(9, 9) = "SandPlain"
        charSet(9, 10) = "RockSmall"
        charSet(9, 11) = "PathBlack"
        charSet(9, 12) = "PathBlack"
        charSet(9, 13) = "PathBlack"
        charSet(9, 14) = "PathBlack"
        charSet(9, 15) = "PathBlack"
        charSet(9, 16) = "PathBlack"
        charSet(9, 17) = "PathBlack"
        charSet(9, 18) = "PathBlack"
        charSet(9, 19) = "PathExit"
    End Sub
    Public Sub StoryLine(trigger)
        Dim story As StoryEngine = New StoryEngine
        Dim message As MessageEngine = New MessageEngine
        Dim display As DisplayEngine = New DisplayEngine
        Select Case Game.Storyprogress
            Case 1
                If trigger = "Load" Then
                End If
        End Select
    End Sub
End Class
