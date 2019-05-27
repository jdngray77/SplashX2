Public Class SplashBG
    Private Sub SplashBG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Diagnostics.Debugger.IsAttached Then
            SplashMenu.ShowDialog()
            SplashMenu.Select()
            'Form1.ShowDialog()
            'Form1.Select()
        Else
            SplashMenu.ShowDialog()
            SplashMenu.Select()
        End If
    End Sub
End Class