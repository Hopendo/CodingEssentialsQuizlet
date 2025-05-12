Public Class Form2
    Private form1 As Form1
    'Sub procedure to display the third form
    Public Sub New(f1 As Form1)
        InitializeComponent()
        Me.form1 = f1
    End Sub
    Public Sub displayform3()
        Dim form3 As New form3(form1, Me)
        form3.Show()
        Me.Hide()
    End Sub
    'Sub procedure to clear all the controls
    Public Sub clear()
        RadPython.Focus()
        ComboBox1.Focus()
        ChkBoot.Checked = Nothing
        ChkContact.Checked = Nothing
        ChkYouTube.Checked = Nothing
        RadFront.Focus()
        PictureBox1.Focus()
    End Sub
    'Sub procedure to close the form entirely
    Public Sub ExitForm()
        Me.Close()
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ExitForm()
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        displayForm3()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ClickedBoxGame As PictureBox = CType(sender, PictureBox)
        If ClickedBoxGame.Tag Is Nothing OrElse ClickedBoxGame.Tag = False Then
            ClickedBoxGame.Tag = True
            ClickedBoxGame.BorderStyle = BorderStyle.Fixed3D
        ElseIf ClickedBoxGame.Tag = False Then
            ClickedBoxGame.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ClickedBoxWeb As PictureBox = CType(sender, PictureBox)
        If ClickedBoxWeb.Tag Is Nothing OrElse ClickedBoxWeb.Tag = False Then
            ClickedBoxWeb.Tag = True
            ClickedBoxWeb.BorderStyle = BorderStyle.Fixed3D
        ElseIf ClickedBoxWeb.Tag = False Then
            ClickedBoxWeb.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim ClickedBoxNetwork As PictureBox = CType(sender, PictureBox)
        If ClickedBoxNetwork.Tag Is Nothing OrElse ClickedBoxNetwork.Tag = False Then
            ClickedBoxNetwork.Tag = True
            ClickedBoxNetwork.BorderStyle = BorderStyle.Fixed3D
        ElseIf ClickedBoxNetwork.Tag = False Then
            ClickedBoxNetwork.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ClickedBoxSystems As PictureBox = CType(sender, PictureBox)
        If ClickedBoxSystems.Tag Is Nothing OrElse ClickedBoxSystems.Tag = False Then
            ClickedBoxSystems.Tag = True
            ClickedBoxSystems.BorderStyle = BorderStyle.Fixed3D
        ElseIf ClickedBoxSystems.Tag = False Then
            ClickedBoxSystems.BorderStyle = BorderStyle.None
        End If
    End Sub


End Class