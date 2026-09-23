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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        SplitContainer1 = New SplitContainer()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        PLP = New Label()
        logoPLP = New PictureBox()
        gradeEncoder = New Label()
        pnlLoginCard = New Panel()
        Panel1 = New Panel()
        pnlLogin = New Panel()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        CType(logoPLP, ComponentModel.ISupportInitialize).BeginInit()
        pnlLoginCard.SuspendLayout()
        pnlLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.IsSplitterFixed = True
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
        SplitContainer1.SplitterDistance = 1120
        SplitContainer1.SplitterWidth = 1
        SplitContainer1.TabIndex = 0
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Controls.Add(PLP)
        Guna2GradientPanel1.Controls.Add(logoPLP)
        Guna2GradientPanel1.Controls.Add(gradeEncoder)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(20), CByte(83), CByte(45))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        Guna2GradientPanel1.GradientMode = Drawing2D.LinearGradientMode.Vertical
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientPanel1.Size = New Size(1120, 1055)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' PLP
        ' 
        PLP.BackColor = Color.Transparent
        PLP.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PLP.ForeColor = Color.FromArgb(CByte(247), CByte(242), CByte(101))
        PLP.Location = New Point(366, 195)
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
        logoPLP.BackgroundImageLayout = ImageLayout.Stretch
        logoPLP.Location = New Point(510, 80)
        logoPLP.Name = "logoPLP"
        logoPLP.Size = New Size(100, 100)
        logoPLP.TabIndex = 1
        logoPLP.TabStop = False
        ' 
        ' gradeEncoder
        ' 
        gradeEncoder.BackColor = Color.Transparent
        gradeEncoder.Font = New Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradeEncoder.ForeColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        gradeEncoder.Location = New Point(341, 430)
        gradeEncoder.Name = "gradeEncoder"
        gradeEncoder.Size = New Size(439, 196)
        gradeEncoder.TabIndex = 0
        gradeEncoder.Text = "GRADE " & vbCrLf & "ENCODER"
        gradeEncoder.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.Controls.Add(Panel1)
        pnlLoginCard.Dock = DockStyle.Fill
        pnlLoginCard.Location = New Point(0, 0)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(803, 1055)
        pnlLoginCard.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(243), CByte(243), CByte(243))
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(803, 1055)
        Panel1.TabIndex = 0
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
        pnlLogin.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gradeEncoder As Label
    Friend WithEvents logoPLP As PictureBox
    Friend WithEvents PLP As Label

End Class
