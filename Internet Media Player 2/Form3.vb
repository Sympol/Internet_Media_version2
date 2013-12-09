Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = "http://lb.streamakaci.com/rti/"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.URL = "http://lb.streamakaci.com/lc2/"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = "http://www.voxafrica.com/fr_old/direct/player.php"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.URL = "mms://stream1.france24.yacast.net/f24_livefr"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.URL = "http://www.congoplanete.com/congo_television_live.jsp"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.URL = "http://www.congoplanete.com/congo_television_live_2.jsp"
    End Sub
End Class