<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        SplitContainer1 = New SplitContainer()
        LoginDesign = New Panel()
        lblEncoder = New Label()
        lblElement = New Label()
        lblSchool = New Label()
        picLogo = New PictureBox()
        lblGrade = New Label()
        pnlLoginCard = New Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        btnEXIT = New Guna.UI2.WinForms.Guna2Button()
        pnlLogin = New Panel()
        pnlExitConfirmation = New Guna.UI2.WinForms.Guna2Panel()
        btnEXITF = New Guna.UI2.WinForms.Guna2Button()
        btnCANCEL = New Guna.UI2.WinForms.Guna2Button()
        exitQuestions = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        LoginDesign.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlLoginCard.SuspendLayout()
        pnlLogin.SuspendLayout()
        pnlExitConfirmation.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(LoginDesign)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(pnlLoginCard)
        SplitContainer1.Size = New Size(1924, 1055)
        SplitContainer1.SplitterDistance = 1160
        SplitContainer1.SplitterWidth = 1
        SplitContainer1.TabIndex = 0
        ' 
        ' LoginDesign
        ' 
        LoginDesign.BackgroundImage = CType(resources.GetObject("LoginDesign.BackgroundImage"), Image)
        LoginDesign.BackgroundImageLayout = ImageLayout.Stretch
        LoginDesign.Controls.Add(lblEncoder)
        LoginDesign.Controls.Add(lblElement)
        LoginDesign.Controls.Add(lblSchool)
        LoginDesign.Controls.Add(picLogo)
        LoginDesign.Controls.Add(lblGrade)
        LoginDesign.Dock = DockStyle.Left
        LoginDesign.Location = New Point(0, 0)
        LoginDesign.Name = "LoginDesign"
        LoginDesign.Size = New Size(1160, 1055)
        LoginDesign.TabIndex = 3
        ' 
        ' lblEncoder
        ' 
        lblEncoder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblEncoder.BackColor = Color.Transparent
        lblEncoder.Font = New Font("Century Gothic", 60F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEncoder.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        lblEncoder.Location = New Point(329, 643)
        lblEncoder.Name = "lblEncoder"
        lblEncoder.Size = New Size(522, 102)
        lblEncoder.TabIndex = 4
        lblEncoder.Text = "ENCODER"
        lblEncoder.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblElement
        ' 
        lblElement.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblElement.BackColor = Color.Transparent
        lblElement.Font = New Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblElement.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        lblElement.Location = New Point(537, 1018)
        lblElement.Name = "lblElement"
        lblElement.Size = New Size(83, 28)
        lblElement.TabIndex = 3
        lblElement.Text = "ELEMENT"
        lblElement.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSchool
        ' 
        lblSchool.BackColor = Color.Transparent
        lblSchool.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSchool.ForeColor = Color.FromArgb(CByte(247), CByte(242), CByte(101))
        lblSchool.Location = New Point(406, 150)
        lblSchool.Name = "lblSchool"
        lblSchool.Size = New Size(389, 26)
        lblSchool.TabIndex = 2
        lblSchool.Text = "PAMANTASAN NG LUNGSOD NG PASIG" & vbCrLf
        lblSchool.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), Image)
        picLogo.BackgroundImageLayout = ImageLayout.Zoom
        picLogo.Location = New Point(550, 47)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(100, 100)
        picLogo.TabIndex = 1
        picLogo.TabStop = False
        ' 
        ' lblGrade
        ' 
        lblGrade.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblGrade.BackColor = Color.Transparent
        lblGrade.Font = New Font("Century Gothic", 60F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrade.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        lblGrade.Location = New Point(394, 526)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(389, 117)
        lblGrade.TabIndex = 0
        lblGrade.Text = "GRADE"
        lblGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.Controls.Add(Guna2Button1)
        pnlLoginCard.Controls.Add(Label2)
        pnlLoginCard.Controls.Add(btnEXIT)
        pnlLoginCard.Dock = DockStyle.Right
        pnlLoginCard.Location = New Point(0, 0)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(763, 1055)
        pnlLoginCard.TabIndex = 0
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.BorderColor = Color.Transparent
        Guna2Button1.BorderRadius = 10
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(34), CByte(90), CByte(74))
        Guna2Button1.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        Guna2Button1.Location = New Point(232, 712)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(327, 52)
        Guna2Button1.TabIndex = 4
        Guna2Button1.Text = "Log in"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(232, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(327, 87)
        Label2.TabIndex = 3
        Label2.Text = "LOG IN TO YOUR" & vbCrLf & "ACCOUNT"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnEXIT
        ' 
        btnEXIT.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnEXIT.BackColor = Color.Transparent
        btnEXIT.BorderColor = Color.Transparent
        btnEXIT.BorderRadius = 10
        btnEXIT.CustomizableEdges = CustomizableEdges3
        btnEXIT.DisabledState.BorderColor = Color.DarkGray
        btnEXIT.DisabledState.CustomBorderColor = Color.DarkGray
        btnEXIT.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEXIT.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEXIT.FillColor = Color.FromArgb(CByte(200), CByte(51), CByte(51))
        btnEXIT.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEXIT.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        btnEXIT.Location = New Point(232, 859)
        btnEXIT.Name = "btnEXIT"
        btnEXIT.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEXIT.Size = New Size(327, 39)
        btnEXIT.TabIndex = 1
        btnEXIT.Text = "Exit"
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackgroundImageLayout = ImageLayout.Stretch
        pnlLogin.Controls.Add(SplitContainer1)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(0, 0)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(1924, 1055)
        pnlLogin.TabIndex = 0
        ' 
        ' pnlExitConfirmation
        ' 
        pnlExitConfirmation.BackColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        pnlExitConfirmation.BackgroundImageLayout = ImageLayout.None
        pnlExitConfirmation.BorderColor = Color.Black
        pnlExitConfirmation.BorderRadius = 15
        pnlExitConfirmation.BorderThickness = 1
        pnlExitConfirmation.Controls.Add(btnEXITF)
        pnlExitConfirmation.Controls.Add(btnCANCEL)
        pnlExitConfirmation.Controls.Add(exitQuestions)
        pnlExitConfirmation.CustomBorderColor = Color.Black
        pnlExitConfirmation.CustomBorderThickness = New Padding(2)
        CustomizableEdges9.BottomLeft = False
        CustomizableEdges9.BottomRight = False
        CustomizableEdges9.TopLeft = False
        CustomizableEdges9.TopRight = False
        pnlExitConfirmation.CustomizableEdges = CustomizableEdges9
        pnlExitConfirmation.FillColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        pnlExitConfirmation.Location = New Point(637, 427)
        pnlExitConfirmation.Name = "pnlExitConfirmation"
        pnlExitConfirmation.RightToLeft = RightToLeft.No
        pnlExitConfirmation.ShadowDecoration.BorderRadius = 1
        pnlExitConfirmation.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlExitConfirmation.ShadowDecoration.Depth = 50
        pnlExitConfirmation.ShadowDecoration.Shadow = New Padding(1)
        pnlExitConfirmation.Size = New Size(650, 200)
        pnlExitConfirmation.TabIndex = 3
        pnlExitConfirmation.Visible = False
        ' 
        ' btnEXITF
        ' 
        btnEXITF.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnEXITF.BackColor = Color.Transparent
        btnEXITF.BorderColor = Color.Transparent
        btnEXITF.BorderRadius = 10
        btnEXITF.CustomizableEdges = CustomizableEdges5
        btnEXITF.DisabledState.BorderColor = Color.DarkGray
        btnEXITF.DisabledState.CustomBorderColor = Color.DarkGray
        btnEXITF.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEXITF.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEXITF.FillColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        btnEXITF.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEXITF.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        btnEXITF.Location = New Point(526, 128)
        btnEXITF.Name = "btnEXITF"
        btnEXITF.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnEXITF.Size = New Size(104, 46)
        btnEXITF.TabIndex = 4
        btnEXITF.Text = "EXIT"
        ' 
        ' btnCANCEL
        ' 
        btnCANCEL.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCANCEL.BackColor = Color.Transparent
        btnCANCEL.BorderColor = Color.Transparent
        btnCANCEL.BorderRadius = 10
        btnCANCEL.CustomizableEdges = CustomizableEdges7
        btnCANCEL.DisabledState.BorderColor = Color.DarkGray
        btnCANCEL.DisabledState.CustomBorderColor = Color.DarkGray
        btnCANCEL.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCANCEL.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCANCEL.FillColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        btnCANCEL.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCANCEL.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        btnCANCEL.Location = New Point(416, 128)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnCANCEL.Size = New Size(104, 46)
        btnCANCEL.TabIndex = 3
        btnCANCEL.Text = "CANCEL"
        ' 
        ' exitQuestions
        ' 
        exitQuestions.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        exitQuestions.AutoSize = True
        exitQuestions.BackColor = Color.Transparent
        exitQuestions.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitQuestions.Location = New Point(34, 35)
        exitQuestions.Name = "exitQuestions"
        exitQuestions.Size = New Size(424, 49)
        exitQuestions.TabIndex = 0
        exitQuestions.Text = "Do you want to exit?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(pnlLogin)
        Controls.Add(pnlExitConfirmation)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ELEMENT - GRADING SYSTEM"
        WindowState = FormWindowState.Maximized
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        LoginDesign.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlLoginCard.ResumeLayout(False)
        pnlLogin.ResumeLayout(False)
        pnlExitConfirmation.ResumeLayout(False)
        pnlExitConfirmation.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblSchool As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents btnEXIT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlExitConfirmation As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnEXITF As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCANCEL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents exitQuestions As Label
    Friend WithEvents LoginDesign As Panel
    Friend WithEvents lblElement As Label
    Friend WithEvents lblEncoder As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button

End Class
