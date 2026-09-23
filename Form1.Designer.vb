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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        SplitContainer1 = New SplitContainer()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        PLP = New Label()
        logoPLP = New PictureBox()
        gradeEncoder = New Label()
        pnlLoginCard = New Panel()
        teacher = New Panel()
        btnEXIT = New Guna.UI2.WinForms.Guna2Button()
        student = New Panel()
        pnlLogin = New Panel()
        Label1 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        CType(logoPLP, ComponentModel.ISupportInitialize).BeginInit()
        pnlLoginCard.SuspendLayout()
        teacher.SuspendLayout()
        pnlLogin.SuspendLayout()
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
        SplitContainer1.Panel1.Controls.Add(Guna2GradientPanel1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(pnlLoginCard)
        SplitContainer1.Size = New Size(1924, 1055)
        SplitContainer1.SplitterDistance = 1160
        SplitContainer1.SplitterWidth = 1
        SplitContainer1.TabIndex = 0
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Controls.Add(PLP)
        Guna2GradientPanel1.Controls.Add(logoPLP)
        Guna2GradientPanel1.Controls.Add(gradeEncoder)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(20), CByte(83), CByte(45))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        Guna2GradientPanel1.GradientMode = Drawing2D.LinearGradientMode.Vertical
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(1160, 1055)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' PLP
        ' 
        PLP.BackColor = Color.Transparent
        PLP.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PLP.ForeColor = Color.FromArgb(CByte(247), CByte(242), CByte(101))
        PLP.Location = New Point(406, 150)
        PLP.Name = "PLP"
        PLP.Size = New Size(389, 26)
        PLP.TabIndex = 2
        PLP.Text = "PAMANTASAN NG LUNGSOD NG PASIG" & vbCrLf
        PLP.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logoPLP
        ' 
        logoPLP.BackColor = Color.Transparent
        logoPLP.BackgroundImage = CType(resources.GetObject("logoPLP.BackgroundImage"), Image)
        logoPLP.BackgroundImageLayout = ImageLayout.Zoom
        logoPLP.Location = New Point(550, 50)
        logoPLP.Name = "logoPLP"
        logoPLP.Size = New Size(100, 100)
        logoPLP.TabIndex = 1
        logoPLP.TabStop = False
        ' 
        ' gradeEncoder
        ' 
        gradeEncoder.BackColor = Color.Transparent
        gradeEncoder.Font = New Font("Century Gothic", 60F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradeEncoder.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        gradeEncoder.Location = New Point(340, 440)
        gradeEncoder.Name = "gradeEncoder"
        gradeEncoder.Size = New Size(520, 234)
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
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(763, 1055)
        pnlLoginCard.TabIndex = 0
        ' 
        ' teacher
        ' 
        teacher.BackColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        teacher.Controls.Add(Label1)
        teacher.Controls.Add(btnEXIT)
        teacher.Dock = DockStyle.Fill
        teacher.Location = New Point(0, 0)
        teacher.Name = "teacher"
        teacher.Size = New Size(763, 1055)
        teacher.TabIndex = 0
        ' 
        ' btnEXIT
        ' 
        btnEXIT.BackColor = Color.Transparent
        btnEXIT.BorderColor = Color.Transparent
        btnEXIT.BorderRadius = 10
        btnEXIT.CustomizableEdges = CustomizableEdges3
        btnEXIT.DisabledState.BorderColor = Color.DarkGray
        btnEXIT.DisabledState.CustomBorderColor = Color.DarkGray
        btnEXIT.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEXIT.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEXIT.FillColor = Color.FromArgb(CByte(20), CByte(83), CByte(45))
        btnEXIT.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEXIT.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        btnEXIT.Location = New Point(656, 26)
        btnEXIT.Name = "btnEXIT"
        btnEXIT.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEXIT.Size = New Size(73, 46)
        btnEXIT.TabIndex = 1
        btnEXIT.Text = "EXIT"
        ' 
        ' student
        ' 
        student.BackColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        student.Dock = DockStyle.Fill
        student.Location = New Point(0, 0)
        student.Name = "student"
        student.Size = New Size(763, 1055)
        student.TabIndex = 1
        ' 
        ' pnlLogin
        ' 
        pnlLogin.Controls.Add(SplitContainer1)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(0, 0)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(1924, 1055)
        pnlLogin.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(232, 288)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 87)
        Label1.TabIndex = 2
        Label1.Text = "LOG IN TO YOUR" & vbCrLf & "ACCOUNT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(pnlLogin)
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
        Guna2GradientPanel1.ResumeLayout(False)
        CType(logoPLP, ComponentModel.ISupportInitialize).EndInit()
        pnlLoginCard.ResumeLayout(False)
        teacher.ResumeLayout(False)
        pnlLogin.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PLP As Label
    Friend WithEvents logoPLP As PictureBox
    Friend WithEvents gradeEncoder As Label
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents teacher As Panel
    Friend WithEvents student As Panel
    Friend WithEvents btnEXIT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label

End Class
