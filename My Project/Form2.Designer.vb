<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadFull = New System.Windows.Forms.RadioButton()
        Me.RadBack = New System.Windows.Forms.RadioButton()
        Me.RadFront = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkYouTube = New System.Windows.Forms.CheckBox()
        Me.ChkContact = New System.Windows.Forms.CheckBox()
        Me.ChkBoot = New System.Windows.Forms.CheckBox()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadHTML = New System.Windows.Forms.RadioButton()
        Me.RadCPlus = New System.Windows.Forms.RadioButton()
        Me.RadJavaScript = New System.Windows.Forms.RadioButton()
        Me.RadC = New System.Windows.Forms.RadioButton()
        Me.RadPython = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCoral
        Me.Label1.Location = New System.Drawing.Point(119, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Let's get started...There's just 5 simple questions*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(28, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select a field of interest:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Which type of development are you interested in?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label4.Location = New System.Drawing.Point(12, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "*There are so many coding careers to choose from"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadFull)
        Me.GroupBox1.Controls.Add(Me.RadBack)
        Me.GroupBox1.Controls.Add(Me.RadFront)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Development"
        '
        'RadFull
        '
        Me.RadFull.AutoSize = True
        Me.RadFull.Location = New System.Drawing.Point(7, 68)
        Me.RadFull.Name = "RadFull"
        Me.RadFull.Size = New System.Drawing.Size(135, 17)
        Me.RadFull.TabIndex = 2
        Me.RadFull.TabStop = True
        Me.RadFull.Text = "Full Stack/Combination"
        Me.RadFull.UseVisualStyleBackColor = True
        '
        'RadBack
        '
        Me.RadBack.AutoSize = True
        Me.RadBack.Location = New System.Drawing.Point(7, 44)
        Me.RadBack.Name = "RadBack"
        Me.RadBack.Size = New System.Drawing.Size(196, 17)
        Me.RadBack.TabIndex = 1
        Me.RadBack.TabStop = True
        Me.RadBack.Text = "Back-End Development/Server-side"
        Me.RadBack.UseVisualStyleBackColor = True
        '
        'RadFront
        '
        Me.RadFront.AutoSize = True
        Me.RadFront.Location = New System.Drawing.Point(7, 20)
        Me.RadFront.Name = "RadFront"
        Me.RadFront.Size = New System.Drawing.Size(153, 17)
        Me.RadFront.TabIndex = 0
        Me.RadFront.TabStop = True
        Me.RadFront.Text = "Front-End Development/UI"
        Me.RadFront.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Software Development", "Game Development", "Networking", "Web Development"})
        Me.ComboBox1.Location = New System.Drawing.Point(194, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "*This is how you work and design"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(431, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label7.Location = New System.Drawing.Point(0, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(353, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Select a coding language best suited for your interest:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label8.Location = New System.Drawing.Point(448, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(245, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "How would you like to learn coding?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(452, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(312, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "What would you like to create?...Select an image"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label10.Location = New System.Drawing.Point(12, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(302, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "*This is what you would use to code,select 2 languages"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label11.Location = New System.Drawing.Point(409, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(325, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "*Here you can decide the way you want to approach coding"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label12.Location = New System.Drawing.Point(449, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(241, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "*Here are something you make from stratch"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkYouTube)
        Me.GroupBox2.Controls.Add(Me.ChkContact)
        Me.GroupBox2.Controls.Add(Me.ChkBoot)
        Me.GroupBox2.Location = New System.Drawing.Point(470, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Learning Apporach"
        '
        'ChkYouTube
        '
        Me.ChkYouTube.AutoSize = True
        Me.ChkYouTube.Location = New System.Drawing.Point(7, 77)
        Me.ChkYouTube.Name = "ChkYouTube"
        Me.ChkYouTube.Size = New System.Drawing.Size(113, 17)
        Me.ChkYouTube.TabIndex = 2
        Me.ChkYouTube.Text = "YouTube Tutorials"
        Me.ChkYouTube.UseVisualStyleBackColor = True
        '
        'ChkContact
        '
        Me.ChkContact.AutoSize = True
        Me.ChkContact.Location = New System.Drawing.Point(7, 47)
        Me.ChkContact.Name = "ChkContact"
        Me.ChkContact.Size = New System.Drawing.Size(105, 17)
        Me.ChkContact.TabIndex = 1
        Me.ChkContact.Text = "Contact Lessons"
        Me.ChkContact.UseVisualStyleBackColor = True
        '
        'ChkBoot
        '
        Me.ChkBoot.AutoSize = True
        Me.ChkBoot.Location = New System.Drawing.Point(7, 20)
        Me.ChkBoot.Name = "ChkBoot"
        Me.ChkBoot.Size = New System.Drawing.Size(80, 17)
        Me.ChkBoot.TabIndex = 0
        Me.ChkBoot.Text = "BootCamps"
        Me.ChkBoot.UseVisualStyleBackColor = True
        '
        'BtnDone
        '
        Me.BtnDone.BackColor = System.Drawing.Color.DarkOrchid
        Me.BtnDone.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDone.Location = New System.Drawing.Point(72, 589)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(91, 40)
        Me.BtnDone.TabIndex = 20
        Me.BtnDone.Text = "*Done*"
        Me.BtnDone.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.MediumOrchid
        Me.BtnExit.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(523, 589)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(87, 40)
        Me.BtnExit.TabIndex = 21
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnClear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Fuchsia
        Me.BtnClear.Location = New System.Drawing.Point(285, 591)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(88, 40)
        Me.BtnClear.TabIndex = 22
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadHTML)
        Me.GroupBox3.Controls.Add(Me.RadCPlus)
        Me.GroupBox3.Controls.Add(Me.RadJavaScript)
        Me.GroupBox3.Controls.Add(Me.RadC)
        Me.GroupBox3.Controls.Add(Me.RadPython)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 353)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 199)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coding language"
        '
        'RadHTML
        '
        Me.RadHTML.AutoSize = True
        Me.RadHTML.Location = New System.Drawing.Point(10, 162)
        Me.RadHTML.Name = "RadHTML"
        Me.RadHTML.Size = New System.Drawing.Size(161, 17)
        Me.RadHTML.TabIndex = 7
        Me.RadHTML.TabStop = True
        Me.RadHTML.Text = "HTML for website structuring"
        Me.RadHTML.UseVisualStyleBackColor = True
        '
        'RadCPlus
        '
        Me.RadCPlus.AutoSize = True
        Me.RadCPlus.Location = New System.Drawing.Point(10, 125)
        Me.RadCPlus.Name = "RadCPlus"
        Me.RadCPlus.Size = New System.Drawing.Size(147, 17)
        Me.RadCPlus.TabIndex = 6
        Me.RadCPlus.TabStop = True
        Me.RadCPlus.Text = "C++ for App Development"
        Me.RadCPlus.UseVisualStyleBackColor = True
        '
        'RadJavaScript
        '
        Me.RadJavaScript.AutoSize = True
        Me.RadJavaScript.Location = New System.Drawing.Point(10, 90)
        Me.RadJavaScript.Name = "RadJavaScript"
        Me.RadJavaScript.Size = New System.Drawing.Size(192, 17)
        Me.RadJavaScript.TabIndex = 5
        Me.RadJavaScript.TabStop = True
        Me.RadJavaScript.Text = "JavaScript for web page interaction"
        Me.RadJavaScript.UseVisualStyleBackColor = True
        '
        'RadC
        '
        Me.RadC.AutoSize = True
        Me.RadC.Location = New System.Drawing.Point(10, 58)
        Me.RadC.Name = "RadC"
        Me.RadC.Size = New System.Drawing.Size(149, 17)
        Me.RadC.TabIndex = 4
        Me.RadC.TabStop = True
        Me.RadC.Text = "C for computer networking"
        Me.RadC.UseVisualStyleBackColor = True
        '
        'RadPython
        '
        Me.RadPython.AutoSize = True
        Me.RadPython.Location = New System.Drawing.Point(10, 30)
        Me.RadPython.Name = "RadPython"
        Me.RadPython.Size = New System.Drawing.Size(166, 17)
        Me.RadPython.TabIndex = 3
        Me.RadPython.TabStop = True
        Me.RadPython.Text = "Python for game development"
        Me.RadPython.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(388, 304)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(363, 279)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Click"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(224, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 17)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Complex Systems"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(79, 250)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 17)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Networks"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(237, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 19)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Websites"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 19)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Games"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(24, 154)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(156, 83)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(214, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(214, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(763, 641)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Quizlet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents RadFull As RadioButton
    Public WithEvents RadBack As RadioButton
    Public WithEvents RadFront As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnDone As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Public WithEvents PictureBox4 As PictureBox
    Public WithEvents PictureBox2 As PictureBox
    Public WithEvents PictureBox1 As PictureBox
    Public WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RadPython As RadioButton
    Public WithEvents RadJavaScript As RadioButton
    Public WithEvents RadC As RadioButton
    Public WithEvents RadHTML As RadioButton
    Public WithEvents RadCPlus As RadioButton
    Public WithEvents ChkYouTube As CheckBox
    Public WithEvents ChkContact As CheckBox
    Public WithEvents ChkBoot As CheckBox
End Class
