Public Class SplashMap_Part3
'====Map Info====
Public MapDrawn(10, 20)

Public MapName = **SplashMap_Part3**
Public MapFamily = **Splash**
Public MapTrack = **CrimsonDrive**
Public StartX = 1
Public StartY = 5

'Active Components
Public exitSet(9, 19)
Public exitName(9, 19)

Public charSet(10, 20) as Object
Public sub Initialise()
'Exits

'Intro
exitSet(2, 19) = " new SplashMap_part4**
exitName(2, 19) = **Intro**
'Character Set

'Row 0
charset(0, 0) = **TreeNew**
charset(0, 1) = **TreeNew**
charset(0, 2) = **TreeNew**
charset(0, 3) = **TreeNew**
charset(0, 4) = **RockSmall**
charset(0, 5) = **RockSmall**
charset(0, 6) = **RockSmall**
charset(0, 7) = **RockSmall**
charset(0, 8) = **PathBlack**
charset(0, 9) = **RockSmall**
charset(0, 10) = **RockSmall**
charset(0, 11) = **RockSmall**
charset(0, 12) = **PathBlack**
charset(0, 13) = **PathBlack**
charset(0, 14) = **PathBlack**
charset(0, 15) = **PathBlack**
charset(0, 16) = **WaterDown**
charset(0, 17) = **WaterDown**
charset(0, 18) = **WaterDown**
charset(0, 19) = **WaterDown**

'Row 1
charset(1, 0) = **TreeNew**
charset(1, 1) = **TreeNew**
charset(1, 2) = **TreeNew**
charset(1, 3) = **TreeNew**
charset(1, 4) = **PathBlack**
charset(1, 5) = **PathBlack**
charset(1, 6) = **RockSmall**
charset(1, 7) = **RockSmall**
charset(1, 8) = **RockSmall**
charset(1, 9) = **PathBlack**
charset(1, 10) = **RockSmall**
charset(1, 11) = **PathBlack**
charset(1, 12) = **PathBlack**
charset(1, 13) = **PathBlack**
charset(1, 14) = **PathBlack**
charset(1, 15) = **WaterDown**
charset(1, 16) = **PathBlack**
charset(1, 17) = **PathBlack**
charset(1, 18) = **WaterDown**
charset(1, 19) = **WaterDown**

'Row 2
charset(2, 0) = **TreeNew**
charset(2, 1) = **TreeNew**
charset(2, 2) = **TreeNew**
charset(2, 3) = **PathBlack**
charset(2, 4) = **PathBlack**
charset(2, 5) = **PathBlack**
charset(2, 6) = **PathBlack**
charset(2, 7) = **PathBlack**
charset(2, 8) = **RockSmall**
charset(2, 9) = **PathBlack**
charset(2, 10) = **PathBlack**
charset(2, 11) = **PathBlack**
charset(2, 12) = **PathBlack**
charset(2, 13) = **PathBlack**
charset(2, 14) = **PathBlack**
charset(2, 15) = **PathBlack**
charset(2, 16) = **PathBlack**
charset(2, 17) = **EnemyBase**
charset(2, 18) = **PathBlack**
charset(2, 19) = **PathExit**

'Row 3
charset(3, 0) = **TreeNew**
charset(3, 1) = **TreeNew**
charset(3, 2) = **TreeNew**
charset(3, 3) = **PathAxe**
charset(3, 4) = **PathBlack**
charset(3, 5) = **PathBlack**
charset(3, 6) = **PathBlack**
charset(3, 7) = **RockSmall**
charset(3, 8) = **PathBlack**
charset(3, 9) = **PathBlack**
charset(3, 10) = **PathBlack**
charset(3, 11) = **PathBlack**
charset(3, 12) = **PathBlack**
charset(3, 13) = **PathBlack**
charset(3, 14) = **PathBlack**
charset(3, 15) = **WaterDown**
charset(3, 16) = **PathBlack**
charset(3, 17) = **PathBlack**
charset(3, 18) = **WaterDown**
charset(3, 19) = **WaterDown**

'Row 4
charset(4, 0) = **TreeNew**
charset(4, 1) = **TreeNew**
charset(4, 2) = **PathBlack**
charset(4, 3) = **PathBlack**
charset(4, 4) = **PathBlack**
charset(4, 5) = **PathBlack**
charset(4, 6) = **PathBlack**
charset(4, 7) = **PathBlack**
charset(4, 8) = **PathBlack**
charset(4, 9) = **PathBlack**
charset(4, 10) = **PathBlack**
charset(4, 11) = **PathBlack**
charset(4, 12) = **PathBlack**
charset(4, 13) = **PathBlack**
charset(4, 14) = **PathBlack**
charset(4, 15) = **PathBlack**
charset(4, 16) = **WaterDown**
charset(4, 17) = **WaterDown**
charset(4, 18) = **WaterDown**
charset(4, 19) = **WaterDown**

'Row 5
charset(5, 0) = **TreeNew**
charset(5, 1) = **TreeNew**
charset(5, 2) = **PathBlack**
charset(5, 3) = **PathBlack**
charset(5, 4) = **PathBlack**
charset(5, 5) = **PathBlack**
charset(5, 6) = **PathBlack**
charset(5, 7) = **PathBlack**
charset(5, 8) = **PathBlack**
charset(5, 9) = **PathBlack**
charset(5, 10) = **PathBlack**
charset(5, 11) = **PathBlack**
charset(5, 12) = **PathBlack**
charset(5, 13) = **SavePoint**
charset(5, 14) = **SandPlain**
charset(5, 15) = **PathBlack**
charset(5, 16) = **PathBlack**
charset(5, 17) = **PathBlack**
charset(5, 18) = **PathBlack**
charset(5, 19) = **PathBlack**

'Row 6
charset(6, 0) = **TreeNew**
charset(6, 1) = **PathBlack**
charset(6, 2) = **PathBlack**
charset(6, 3) = **PathBlack**
charset(6, 4) = **PathBlack**
charset(6, 5) = **PathBlack**
charset(6, 6) = **PathBlack**
charset(6, 7) = **PathBlack**
charset(6, 8) = **SandPlain**
charset(6, 9) = **SandPlain**
charset(6, 10) = **SandCactus**
charset(6, 11) = **SandPlain**
charset(6, 12) = **SandPlain**
charset(6, 13) = **SandPlain**
charset(6, 14) = **WaterNew**
charset(6, 15) = **SandPlain**
charset(6, 16) = **PathBlack**
charset(6, 17) = **PathBlack**
charset(6, 18) = **PathBlack**
charset(6, 19) = **PathBlack**

'Row 7
charset(7, 0) = **PathBlack**
charset(7, 1) = **PathBlack**
charset(7, 2) = **PathBlack**
charset(7, 3) = **PathBlack**
charset(7, 4) = **SandPlain**
charset(7, 5) = **SandPlain**
charset(7, 6) = **SandPlain**
charset(7, 7) = **SandPlain**
charset(7, 8) = **WaterNew**
charset(7, 9) = **WaterNew**
charset(7, 10) = **WaterNew**
charset(7, 11) = **WaterNew**
charset(7, 12) = **WaterNew**
charset(7, 13) = **WaterNew**
charset(7, 14) = **WaterNew**
charset(7, 15) = **WaterNew**
charset(7, 16) = **SandPlain**
charset(7, 17) = **PathBlack**
charset(7, 18) = **SandPlain**
charset(7, 19) = **SandCactus**

'Row 8
charset(8, 0) = **PathBlack**
charset(8, 1) = **PathBlack**
charset(8, 2) = **SandPlain**
charset(8, 3) = **SandCactus**
charset(8, 4) = **WaterNew**
charset(8, 5) = **WaterNew**
charset(8, 6) = **WaterNew**
charset(8, 7) = **WaterNew**
charset(8, 8) = **WaterNew**
charset(8, 9) = **WaterNew**
charset(8, 10) = **WaterNew**
charset(8, 11) = **WaterNew**
charset(8, 12) = **WaterNew**
charset(8, 13) = **WaterNew**
charset(8, 14) = **WaterNew**
charset(8, 15) = **WaterNew**
charset(8, 16) = **SandCactus**
charset(8, 17) = **SandPlain**
charset(8, 18) = **WaterNew**
charset(8, 19) = **WaterNew**

'Row 9
charset(9, 0) = **TreeNew**
charset(9, 1) = **SandPlain**
charset(9, 2) = **WaterNew**
charset(9, 3) = **WaterNew**
charset(9, 4) = **WaterNew**
charset(9, 5) = **WaterNew**
charset(9, 6) = **WaterNew**
charset(9, 7) = **WaterNew**
charset(9, 8) = **WaterNew**
charset(9, 9) = **WaterNew**
charset(9, 10) = **WaterNew**
charset(9, 11) = **WaterNew**
charset(9, 12) = **WaterNew**
charset(9, 13) = **WaterNew**
charset(9, 14) = **WaterNew**
charset(9, 15) = **WaterNew**
charset(9, 16) = **WaterNew**
charset(9, 17) = **WaterNew**
charset(9, 18) = **WaterNew**
charset(9, 19) = **WaterNew**
End sub
Public sub StoryLine(trigger)
dim story As storyEngine = new storyEngine
 Dim message As MessageEngine = New MessageEngine
Dim display As DisplayEngine = New DisplayEngine
Select case game.StoryProgress
Case 1
if trigger = **Load** then
end if
end select
end sub
end class
