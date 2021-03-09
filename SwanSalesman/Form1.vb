Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.intro, AudioPlayMode.WaitToComplete)
        Label1.Hide()
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.Text = ">> Free swan giveaway"
        Button1.Image = My.Resources.Swan
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Text = "Free swan giveaway"
        Button1.Image = My.Resources._Nothing
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Text = ">> Customer Testimonials"
        Button2.Image = My.Resources.Swan
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Text = "Customer Testimonials"
        Button2.Image = My.Resources._Nothing
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.Text = ">> Customer Support"
        Button3.Image = My.Resources.Swan
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Text = "Customer Support"
        Button3.Image = My.Resources._Nothing
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.Text = ">> Buy your swan"
        Button4.Image = My.Resources.Swan
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.Text = "Buy your swan"
        Button4.Image = My.Resources._Nothing
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.UI, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Stop()
        Try
            Process.Start("C:\OEM\Software\FreeSIP\FreeSIP.exe", "+1 (800) 234-6839")
            Me.Close()
        Catch ex As Exception
            Button3.Hide()
            My.Computer.Audio.Play(My.Resources.Pain, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.UI, AudioPlayMode.WaitToComplete)
        CustomerTestimonials.Location = New Point(0, 149)
        CustomerTestimonials.Show()
        Label1.Show()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.Testimonials, AudioPlayMode.WaitToComplete)
        Label1.Hide()
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
        PictureBox4.Show()
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
        PictureBox5.Show()
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
        PictureBox6.Show()
        Application.DoEvents()
        Threading.Thread.Sleep(1000)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.UI, AudioPlayMode.WaitToComplete)
        Giveaway.ShowDialog()
    End Sub


    Private Sub PictureBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.DoubleClick
        Label1.Show()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.ShutUp, AudioPlayMode.WaitToComplete)
        Label1.Hide()
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.UI, AudioPlayMode.WaitToComplete)
        BuyMenu.Location = New Point(0, 149)
        BuyMenu.Show()
        Label1.Show()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.purchaseinstructions, AudioPlayMode.WaitToComplete)
        Label1.Hide()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.purchasescreen, AudioPlayMode.BackgroundLoop)

    End Sub
    Private Sub PictureBox2_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseWheel

        Label1.Show()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.Death3, AudioPlayMode.WaitToComplete)
        Label1.Hide()
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
    End Sub

    '    ########################################
    '    #      P U R C H A S E S C R E E N     #
    '    ########################################

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label3.Click
        My.Computer.Audio.Play(My.Resources.Pain, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            PictureBox3.Image = My.Resources.Swan1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            PictureBox3.Image = My.Resources.Swan2
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            PictureBox3.Image = My.Resources.Swan3
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            PictureBox3.Image = My.Resources.Swan4
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            PictureBox3.Image = My.Resources.Swan5
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            PictureBox3.Image = My.Resources.Swan6
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.Shatter, AudioPlayMode.WaitToComplete)
        Me.Close()
    End Sub

   

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Play(My.Resources.T11, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        My.Computer.Audio.Play(My.Resources.T21, AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Label1.Show()
        Application.DoEvents()
        My.Computer.Audio.Play(My.Resources.T31, AudioPlayMode.WaitToComplete)
        Label1.Hide()
        My.Computer.Audio.Play(My.Resources.menu, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        CustomerTestimonials.Hide()
        BuyMenu.Hide()
    End Sub
End Class
