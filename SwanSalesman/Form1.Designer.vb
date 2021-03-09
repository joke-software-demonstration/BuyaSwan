<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuyMenu = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CVC = New System.Windows.Forms.TextBox()
        Me.MMYY = New System.Windows.Forms.TextBox()
        Me.Creditcard = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EMAIL = New System.Windows.Forms.TextBox()
        Me.ZIP = New System.Windows.Forms.TextBox()
        Me.Country = New System.Windows.Forms.TextBox()
        Me.Street2 = New System.Windows.Forms.TextBox()
        Me.Street = New System.Windows.Forms.TextBox()
        Me.MiddleName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.CustomerTestimonials = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BuyMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerTestimonials.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(462, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 77)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MR. TEA IS TALKING... PLEASE WAIT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BuyMenu
        '
        Me.BuyMenu.Controls.Add(Me.GroupBox1)
        Me.BuyMenu.Controls.Add(Me.PictureBox3)
        Me.BuyMenu.Controls.Add(Me.RadioButton1)
        Me.BuyMenu.Controls.Add(Me.RadioButton2)
        Me.BuyMenu.Controls.Add(Me.Label2)
        Me.BuyMenu.Controls.Add(Me.RadioButton3)
        Me.BuyMenu.Controls.Add(Me.RadioButton4)
        Me.BuyMenu.Controls.Add(Me.RadioButton5)
        Me.BuyMenu.Controls.Add(Me.RadioButton6)
        Me.BuyMenu.Location = New System.Drawing.Point(776, 538)
        Me.BuyMenu.Name = "BuyMenu"
        Me.BuyMenu.Size = New System.Drawing.Size(465, 429)
        Me.BuyMenu.TabIndex = 4
        Me.BuyMenu.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.CVC)
        Me.GroupBox1.Controls.Add(Me.MMYY)
        Me.GroupBox1.Controls.Add(Me.Creditcard)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.EMAIL)
        Me.GroupBox1.Controls.Add(Me.ZIP)
        Me.GroupBox1.Controls.Add(Me.Country)
        Me.GroupBox1.Controls.Add(Me.Street2)
        Me.GroupBox1.Controls.Add(Me.Street)
        Me.GroupBox1.Controls.Add(Me.MiddleName)
        Me.GroupBox1.Controls.Add(Me.LastName)
        Me.GroupBox1.Controls.Add(Me.FirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 211)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Details"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(132, 172)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 29)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Place Order"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CVC
        '
        Me.CVC.Location = New System.Drawing.Point(68, 176)
        Me.CVC.Name = "CVC"
        Me.CVC.Size = New System.Drawing.Size(56, 20)
        Me.CVC.TabIndex = 11
        Me.CVC.Text = "CVC#"
        '
        'MMYY
        '
        Me.MMYY.Location = New System.Drawing.Point(6, 176)
        Me.MMYY.Name = "MMYY"
        Me.MMYY.Size = New System.Drawing.Size(56, 20)
        Me.MMYY.TabIndex = 10
        Me.MMYY.Text = "MM/YY"
        '
        'Creditcard
        '
        Me.Creditcard.Location = New System.Drawing.Point(6, 150)
        Me.Creditcard.Name = "Creditcard"
        Me.Creditcard.Size = New System.Drawing.Size(197, 20)
        Me.Creditcard.TabIndex = 9
        Me.Creditcard.Text = "Credit Card"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 20)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Mobile Phone Number"
        '
        'EMAIL
        '
        Me.EMAIL.Location = New System.Drawing.Point(6, 98)
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.Size = New System.Drawing.Size(197, 20)
        Me.EMAIL.TabIndex = 7
        Me.EMAIL.Text = "blink182s_enema@yahoo.com"
        '
        'ZIP
        '
        Me.ZIP.Location = New System.Drawing.Point(97, 72)
        Me.ZIP.Name = "ZIP"
        Me.ZIP.Size = New System.Drawing.Size(106, 20)
        Me.ZIP.TabIndex = 6
        Me.ZIP.Text = "87410"
        '
        'Country
        '
        Me.Country.Location = New System.Drawing.Point(7, 72)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(84, 20)
        Me.Country.TabIndex = 5
        Me.Country.Text = "United States of..."
        '
        'Street2
        '
        Me.Street2.Location = New System.Drawing.Point(87, 46)
        Me.Street2.Name = "Street2"
        Me.Street2.Size = New System.Drawing.Size(118, 20)
        Me.Street2.TabIndex = 4
        Me.Street2.Text = "Street 2ND"
        '
        'Street
        '
        Me.Street.Location = New System.Drawing.Point(7, 46)
        Me.Street.Name = "Street"
        Me.Street.Size = New System.Drawing.Size(74, 20)
        Me.Street.TabIndex = 3
        Me.Street.Text = "Street Ad,"
        '
        'MiddleName
        '
        Me.MiddleName.Location = New System.Drawing.Point(83, 20)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(24, 20)
        Me.MiddleName.TabIndex = 2
        Me.MiddleName.Text = "d."
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(109, 20)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(96, 20)
        Me.LastName.TabIndex = 1
        Me.LastName.Text = "Lange"
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(7, 20)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(74, 20)
        Me.FirstName.TabIndex = 0
        Me.FirstName.Text = "Vince"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(238, 204)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(218, 212)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(23, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(258, 26)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mega Swan Island (2019)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(23, 90)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(238, 26)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Majestic Swan Ride-On"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(90, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "The Purchase Screen"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(23, 110)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(308, 26)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Intex 56287EU Bathing Island"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(23, 131)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(188, 26)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "MEGA SWAN ISLAND"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(23, 152)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(368, 26)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Intex Mega Swan, Inflatable Island"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(23, 172)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(318, 26)
        Me.RadioButton6.TabIndex = 1
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Intex Swan Inflatable Ride-On"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'CustomerTestimonials
        '
        Me.CustomerTestimonials.Controls.Add(Me.PictureBox6)
        Me.CustomerTestimonials.Controls.Add(Me.PictureBox5)
        Me.CustomerTestimonials.Controls.Add(Me.PictureBox4)
        Me.CustomerTestimonials.Controls.Add(Me.Label3)
        Me.CustomerTestimonials.Location = New System.Drawing.Point(789, 480)
        Me.CustomerTestimonials.Name = "CustomerTestimonials"
        Me.CustomerTestimonials.Size = New System.Drawing.Size(465, 429)
        Me.CustomerTestimonials.TabIndex = 4
        Me.CustomerTestimonials.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.SwanSalesman.My.Resources.Resources.T3
        Me.PictureBox6.Location = New System.Drawing.Point(18, 281)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(432, 91)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SwanSalesman.My.Resources.Resources.T2
        Me.PictureBox5.Location = New System.Drawing.Point(18, 165)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(432, 91)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SwanSalesman.My.Resources.Resources.T1
        Me.PictureBox4.Location = New System.Drawing.Point(18, 57)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(432, 91)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(90, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer Testimonials"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.SwanSalesman.My.Resources.Resources._Nothing
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(43, 163)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(361, 70)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Buy your swan"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.SwanSalesman.My.Resources.Resources._Nothing
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(43, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(361, 70)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Customer Support"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.SwanSalesman.My.Resources.Resources._Nothing
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(43, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(361, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Customer Testimonials"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Image = Global.SwanSalesman.My.Resources.Resources._Nothing
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(43, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(361, 70)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Free swan giveaway"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SwanSalesman.My.Resources.Resources.Salesma
        Me.PictureBox2.Location = New System.Drawing.Point(491, 156)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(279, 422)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SwanSalesman.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 150)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 577)
        Me.Controls.Add(Me.CustomerTestimonials)
        Me.Controls.Add(Me.BuyMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Macromedia Flash MX 2004"
        Me.BuyMenu.ResumeLayout(False)
        Me.BuyMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerTestimonials.ResumeLayout(False)
        Me.CustomerTestimonials.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BuyMenu As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CVC As System.Windows.Forms.TextBox
    Friend WithEvents MMYY As System.Windows.Forms.TextBox
    Friend WithEvents Creditcard As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents ZIP As System.Windows.Forms.TextBox
    Friend WithEvents Country As System.Windows.Forms.TextBox
    Friend WithEvents Street2 As System.Windows.Forms.TextBox
    Friend WithEvents Street As System.Windows.Forms.TextBox
    Friend WithEvents MiddleName As System.Windows.Forms.TextBox
    Friend WithEvents LastName As System.Windows.Forms.TextBox
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTestimonials As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox

End Class
