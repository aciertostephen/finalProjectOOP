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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        SplitContainer1 = New SplitContainer()
        Panel1 = New Panel()
        PLP = New Label()
        logoPLP = New PictureBox()
        gradeEncoder = New Label()
        pnlLoginCard = New Panel()
        teacher = New Panel()
        Label1 = New Label()
        btnEXIT = New Guna.UI2.WinForms.Guna2Button()
        student = New Panel()
        pnlLogin = New Panel()
        pnlExitConfirmation = New Guna.UI2.WinForms.Guna2Panel()
        btnEXITF = New Guna.UI2.WinForms.Guna2Button()
        btnCANCEL = New Guna.UI2.WinForms.Guna2Button()
        exitQuestions = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(logoPLP, ComponentModel.ISupportInitialize).BeginInit()
        pnlLoginCard.SuspendLayout()
        teacher.SuspendLayout()
        pnlLogin.SuspendLayout()
        pnlExitConfirmation.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(4)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(pnlLoginCard)
        SplitContainer1.Size = New Size(1946, 1106)
        SplitContainer1.SplitterDistance = 1173
        SplitContainer1.SplitterWidth = 1
        SplitContainer1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(PLP)
        Panel1.Controls.Add(logoPLP)
        Panel1.Controls.Add(gradeEncoder)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1173, 1106)
        Panel1.TabIndex = 3
        ' 
        ' PLP
        ' 
        PLP.BackColor = Color.Transparent
        PLP.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PLP.ForeColor = Color.FromArgb(CByte(247), CByte(242), CByte(101))
        PLP.Location = New Point(508, 188)
        PLP.Margin = New Padding(4, 0, 4, 0)
        PLP.Name = "PLP"
        PLP.Size = New Size(486, 32)
        PLP.TabIndex = 2
        PLP.Text = "PAMANTASAN NG LUNGSOD NG PASIG" & vbCrLf
        PLP.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logoPLP
        ' 
        logoPLP.BackColor = Color.Transparent
        logoPLP.BackgroundImage = CType(resources.GetObject("logoPLP.BackgroundImage"), Image)
        logoPLP.BackgroundImageLayout = ImageLayout.Zoom
        logoPLP.Location = New Point(688, 62)
        logoPLP.Margin = New Padding(4)
        logoPLP.Name = "logoPLP"
        logoPLP.Size = New Size(125, 125)
        logoPLP.TabIndex = 1
        logoPLP.TabStop = False
        ' 
        ' gradeEncoder
        ' 
        gradeEncoder.BackColor = Color.Transparent
        gradeEncoder.Font = New Font("Century Gothic", 55.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradeEncoder.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        gradeEncoder.Location = New Point(425, 550)
        gradeEncoder.Margin = New Padding(4, 0, 4, 0)
        gradeEncoder.Name = "gradeEncoder"
        gradeEncoder.Size = New Size(650, 292)
        gradeEncoder.TabIndex = 0
        gradeEncoder.Text = "GRADE " & vbCrLf & "ENCODER"
        gradeEncoder.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.Controls.Add(teacher)
        pnlLoginCard.Controls.Add(student)
        pnlLoginCard.Dock = DockStyle.Fill
        pnlLoginCard.Location = New Point(0, 0)
        pnlLoginCard.Margin = New Padding(4)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(772, 1106)
        pnlLoginCard.TabIndex = 0
        ' 
        ' teacher
        ' 
        teacher.BackColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        teacher.Controls.Add(Label1)
        teacher.Controls.Add(btnEXIT)
        teacher.Dock = DockStyle.Fill
        teacher.Location = New Point(0, 0)
        teacher.Margin = New Padding(4)
        teacher.Name = "teacher"
        teacher.Size = New Size(772, 1106)
        teacher.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(290, 360)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(409, 109)
        Label1.TabIndex = 2
        Label1.Text = "LOG IN TO YOUR" & vbCrLf & "ACCOUNT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnEXIT
        ' 
        btnEXIT.BackColor = Color.Transparent
        btnEXIT.BorderColor = Color.Transparent
        btnEXIT.BorderRadius = 10
        btnEXIT.CustomizableEdges = CustomizableEdges1
        btnEXIT.DisabledState.BorderColor = Color.DarkGray
        btnEXIT.DisabledState.CustomBorderColor = Color.DarkGray
        btnEXIT.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEXIT.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEXIT.FillColor = Color.FromArgb(CByte(20), CByte(83), CByte(45))
        btnEXIT.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEXIT.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        btnEXIT.Location = New Point(820, 32)
        btnEXIT.Margin = New Padding(4)
        btnEXIT.Name = "btnEXIT"
        btnEXIT.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnEXIT.Size = New Size(91, 58)
        btnEXIT.TabIndex = 1
        btnEXIT.Text = "EXIT"
        ' 
        ' student
        ' 
        student.BackColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        student.Dock = DockStyle.Fill
        student.Location = New Point(0, 0)
        student.Margin = New Padding(4)
        student.Name = "student"
        student.Size = New Size(772, 1106)
        student.TabIndex = 1
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackgroundImageLayout = ImageLayout.Stretch
        pnlLogin.Controls.Add(SplitContainer1)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(0, 0)
        pnlLogin.Margin = New Padding(4)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(1946, 1106)
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
        CustomizableEdges7.BottomLeft = False
        CustomizableEdges7.BottomRight = False
        CustomizableEdges7.TopLeft = False
        CustomizableEdges7.TopRight = False
        pnlExitConfirmation.CustomizableEdges = CustomizableEdges7
        pnlExitConfirmation.FillColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        pnlExitConfirmation.Location = New Point(796, 534)
        pnlExitConfirmation.Margin = New Padding(4)
        pnlExitConfirmation.Name = "pnlExitConfirmation"
        pnlExitConfirmation.RightToLeft = RightToLeft.No
        pnlExitConfirmation.ShadowDecoration.BorderRadius = 1
        pnlExitConfirmation.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlExitConfirmation.ShadowDecoration.Depth = 50
        pnlExitConfirmation.ShadowDecoration.Shadow = New Padding(1)
        pnlExitConfirmation.Size = New Size(812, 250)
        pnlExitConfirmation.TabIndex = 3
        pnlExitConfirmation.Visible = False
        ' 
        ' btnEXITF
        ' 
        btnEXITF.BackColor = Color.Transparent
        btnEXITF.BorderColor = Color.Transparent
        btnEXITF.BorderRadius = 10
        btnEXITF.CustomizableEdges = CustomizableEdges3
        btnEXITF.DisabledState.BorderColor = Color.DarkGray
        btnEXITF.DisabledState.CustomBorderColor = Color.DarkGray
        btnEXITF.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEXITF.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEXITF.FillColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        btnEXITF.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEXITF.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        btnEXITF.Location = New Point(658, 160)
        btnEXITF.Margin = New Padding(4)
        btnEXITF.Name = "btnEXITF"
        btnEXITF.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEXITF.Size = New Size(130, 58)
        btnEXITF.TabIndex = 4
        btnEXITF.Text = "EXIT"
        ' 
        ' btnCANCEL
        ' 
        btnCANCEL.BackColor = Color.Transparent
        btnCANCEL.BorderColor = Color.Transparent
        btnCANCEL.BorderRadius = 10
        btnCANCEL.CustomizableEdges = CustomizableEdges5
        btnCANCEL.DisabledState.BorderColor = Color.DarkGray
        btnCANCEL.DisabledState.CustomBorderColor = Color.DarkGray
        btnCANCEL.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCANCEL.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCANCEL.FillColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        btnCANCEL.Font = New Font("Century Gothic", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCANCEL.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        btnCANCEL.Location = New Point(520, 160)
        btnCANCEL.Margin = New Padding(4)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnCANCEL.Size = New Size(130, 58)
        btnCANCEL.TabIndex = 3
        btnCANCEL.Text = "CANCEL"
        ' 
        ' exitQuestions
        ' 
        exitQuestions.AutoSize = True
        exitQuestions.BackColor = Color.Transparent
        exitQuestions.Font = New Font("Century Gothic", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitQuestions.Location = New Point(42, 44)
        exitQuestions.Margin = New Padding(4, 0, 4, 0)
        exitQuestions.Name = "exitQuestions"
        exitQuestions.Size = New Size(496, 58)
        exitQuestions.TabIndex = 0
        exitQuestions.Text = "Do you want to exit?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1946, 1106)
        Controls.Add(pnlLogin)
        Controls.Add(pnlExitConfirmation)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ELEMENT - GRADING SYSTEM"
        WindowState = FormWindowState.Maximized
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(logoPLP, ComponentModel.ISupportInitialize).EndInit()
        pnlLoginCard.ResumeLayout(False)
        teacher.ResumeLayout(False)
        pnlLogin.ResumeLayout(False)
        pnlExitConfirmation.ResumeLayout(False)
        pnlExitConfirmation.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents PLP As Label
    Friend WithEvents logoPLP As PictureBox
    Friend WithEvents gradeEncoder As Label
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents teacher As Panel
    Friend WithEvents student As Panel
    Friend WithEvents btnEXIT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlExitConfirmation As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnEXITF As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCANCEL As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents exitQuestions As Label
    Friend WithEvents Panel1 As Panel

End Class
