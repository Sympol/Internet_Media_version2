Imports System.ComponentModel
Public Class Form2

    Private WithEvents bwg As New BackgroundWorker
    Private ausfahren As Boolean = True

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bwg.IsBusy = True Then
            bwg.CancelAsync()
        End If
    End Sub

    Private Sub Form2_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Form4.Location = New Point(Me.Right, Me.Top)
    End Sub

    Private Sub bwg_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwg.DoWork
        Select Case e.Argument
            Case True
                For i As Integer = 0 To Form4.Width
                    bwg.ReportProgress(i, i)
                    Threading.Thread.Sleep(2)
                Next
            Case False
                For i As Integer = Form4.Width To 0 Step -1
                    bwg.ReportProgress(i, i)
                    Threading.Thread.Sleep(2)
                Next
            Case bwg.IsBusy
                For i As Integer = Me.Width To 0
                    bwg.ReportProgress(i, i)
                    Threading.Thread.Sleep(2)
                Next
        End Select
    End Sub

    Private Sub bwg_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwg.ProgressChanged
        Form4.Size = New Size(e.UserState, Me.Height)
    End Sub

    Sub PrepareFormForSlider()
        Form4.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        bwg.WorkerReportsProgress = True
        bwg.WorkerSupportsCancellation = True
        Form4.ShowInTaskbar = False
        Form4.Show()
        Form4.Size = New Size(0, Me.Height)
        Form4.Location = New Point(Me.Right, Me.Top)
    End Sub

    Sub PopoutSidebar()
        Try
            Form4.Visible = False
            bwg.RunWorkerAsync(ausfahren)
        Catch ex As Exception
            Form4.Visible = True
            MsgBox("test")
        End Try
        If ausfahren = True Then ausfahren = False Else ausfahren = True

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareFormForSlider()
    End Sub
    
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        PopoutSidebar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Close()
    End Sub
End Class