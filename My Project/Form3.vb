Imports System.Security.Cryptography.X509Certificates

Public Class form3
    Private form1 As Form1
    Private form2 As Form2
    Public Sub New(f1 As Form1, f2 As Form2)
        InitializeComponent()
        Me.form1 = f1
        Me.form2 = f2
    End Sub
    'Sub procedures to display a message to the user after the completion of the quizlet
    Public Sub displayCode()
        If form2.RadPython.Checked = True Then
            LstCodingLanguage.Items.Add("Python")
            LstCodingLanguage.Items.Add("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~")
            LstCodingLanguage.Items.Add("Python is a beginner-friendly coding language")
            LstCodingLanguage.Items.Add("It has a simplistic syntax that makes it easy to read and write")
            LstCodingLanguage.Items.Add("Used in vatious fields like web development,data science and AI")
            LstCodingLanguage.Items.Add("There is an abundance of online resources and communities to help you learn")
        ElseIf form2.RadJavaScript.Checked = True Then
            LstCodingLanguage.Items.Add("JavaScript")
            LstCodingLanguage.Items.Add("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~")
            LstCodingLanguage.Items.Add("A browser and general purpose coding language")
            LstCodingLanguage.Items.Add("It makes a web page interactive by having things pop-up and slide")
            LstCodingLanguage.Items.Add("It allows the website to respond to a user without reloading")
            LstCodingLanguage.Items.Add("In website development JavaScript adds behaviour tothe website")
        ElseIf form2.RadC.Checked = True Then
            LstCodingLanguage.Items.Add("C")
            LstCodingLanguage.Items.Add("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~")
            LstCodingLanguage.Items.Add("C is a foundational programming language with a lot of languages based-on it ")
            LstCodingLanguage.Items.Add("A great low-level coding language to get a better understanding of machine level ")
            LstCodingLanguage.Items.Add("Used to write a network application by sending and receiving data over a network")
        ElseIf form2.RadCPlus.Checked = True Then
            LstCodingLanguage.Items.Add("C++")
            LstCodingLanguage.Items.Add("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~")
            LstCodingLanguage.Items.Add("This is an extention of the Coding language C")
            LstCodingLanguage.Items.Add("It adds Object-Orientated coding features which are used for system development")
            LstCodingLanguage.Items.Add("The coding language is perfect for games,desktop and operating system")
        ElseIf form2.RadHTML.Checked = True Then
            LstCodingLanguage.Items.Add("HTML")
            LstCodingLanguage.Items.Add("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~")
            LstCodingLanguage.Items.Add("Unlike programming languges like C,HTML is a markup language meaning it organises rather use logic")
            LstCodingLanguage.Items.Add("It is used to creates the skelton which is the structure of a websites")
            LstCodingLanguage.Items.Add("Browsers read HTML to display websites")
        End If
    End Sub
    'Sub Procedure to display Development picture
    Public Sub imagecode()
        Dim ImageNo1 As Image = My.Resources.python
        Dim ImageNo2 As Image = My.Resources.C_
        Dim ImageNo3 As Image = My.Resources.JavaScript
        Dim ImageNo4 As Image = My.Resources.Cplus
        Dim ImageNo5 As Image = My.Resources.HTML
        If form2.RadPython.Checked = True Then
            PictureBoxCode.Image = ImageNo1
        ElseIf form2.RadC.Checked = True Then
            PictureBoxCode.Image = ImageNo2
        ElseIf form2.RadJavaScript.Checked = True Then
            PictureBoxCode.Image = ImageNo3
        ElseIf form2.RadCPlus.Checked = True Then
            PictureBoxCode.Image = ImageNo4
        ElseIf form2.RadHTML.Checked = True Then
            PictureBoxCode.Image = ImageNo5
        End If
    End Sub
    Public Sub DisplayDevelopment()
        If form2.RadFront.Checked = True Then
            LstDevelopment.Items.Add("FrontEnd Development")
            LstDevelopment.Items.Add("FrontEnd Development deals with building the components that the user interacts with")
            LstDevelopment.Items.Add("This is the User Interface(UI) design which are the colours,arrangements and text ")
            LstDevelopment.Items.Add("")
        ElseIf form2.RadBack.Checked = True Then
            LstDevelopment.Items.Add("BackEnd Development")
            LstDevelopment.Items.Add("This is focuses on the inner workings of an application or websites")
            LstDevelopment.Items.Add("This type of development works with databases and servers basically everything behind the interface")

        ElseIf form2.RadFull.Checked = True Then
            LstDevelopment.Items.Add("Full Stack Development")
            LstDevelopment.Items.Add("This is a combination of Back and Front End development")
            LstDevelopment.Items.Add("Here you are able to create the interface and work in with the servers")
        End If
    End Sub
    Public Sub imagedevelopment()
        Dim PictureNo1 As Image = My.Resources.FrontEnd
        Dim PictureNo2 As Image = My.Resources.FullStack
        Dim PictureNo3 As Image = My.Resources.BackEnd
        If form2.RadFront.Checked = True Then
            PictureBoxDevelop.Image = PictureNo1
        ElseIf form2.RadBack.Checked = True Then
            PictureBoxDevelop.Image = PictureNo2
        ElseIf form2.RadFull.Checked = True Then
            PictureBoxDevelop.Image = PictureNo3
        End If
    End Sub
    'Sub Procedure for secondary information
    Public Sub secondary()
        LstDisplay.Items.Add("Here are your results " & form1.TextBox1.Text)
        If form2.ChkBoot.Checked = True Then
            LstDisplay.Items.Add("BootCamps are training programs that can happen online and work as an alternative to degrees")
            LstDisplay.Items.Add("There are various bootcamp options to choose from like WeThinkCode and SheCodes ")
        ElseIf form2.ChkContact.Checked = True Then
            LstDisplay.Items.Add("Contact lessons can be conducted via colleges and univerties as a degree or certification")
            LstDisplay.Items.Add("Course are provide by the EEC and other public and private universities ")
        ElseIf form2.ChkYouTube.Checked = True Then
            LstDisplay.Items.Add("YouTube Tutorials are a free and cost effective way to learn how to code")
            LstDisplay.Items.Add("YouTube Channels like Ucademy and freeCodeCamp")
        End If
        If form2.PictureBox1.Image IsNot Nothing Then
            LstDisplay.Items.Add("Easy game projects to code:Guess the number and Rock,Paper,Scissors")
        ElseIf form2.PictureBox2.Image IsNot Nothing Then
            LstDisplay.Items.Add("Beginner friendly website to create:Personal portfolio and To-Do list")
        ElseIf form2.PictureBox3.Image IsNot Nothing Then
            LstDisplay.Items.Add("First-timer networking projects:Local Network Chat and File Transfer program")
        ElseIf form2.PictureBox4.Image IsNot Nothing Then
            LstDisplay.Items.Add("Start-up applications:Calculator App and Student Grading System")
        End If
        LstDisplay.Items.Add("There are various ways to learn coding and many fields to Join,Get started with a roadmap from Roadmap.sh")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Thank you for participating in our quizlet :)")
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnClick.Click
        secondary()
        imagecode()
        imagedevelopment()
        displayCode()
        DisplayDevelopment()
    End Sub
End Class