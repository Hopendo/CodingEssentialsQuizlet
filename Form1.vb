Public Class Form1
    Dim StrName As String
    'Sub procedure to display second form
    Public Sub DisplayForm()
        Dim f2 As New Form2(Me)
        f2.Show()
        Me.Hide()
    End Sub

    'sub procedure for progress bar
    Public Sub progressBar()
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        Else Timer1.Stop()
            DisplayForm()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressBar()
    End Sub
End Class
