Imports System.Xml

Public Class Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        pnlExitConfirmation.Visible = True
        pnlExitConfirmation.BringToFront()
    End Sub

    Private Sub btnEXITF_Click(sender As Object, e As EventArgs) Handles btnEXITF.Click
        Application.Exit()
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        pnlExitConfirmation.Visible = False
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.IsSplitterFixed = True

        UpdateLayout()

    End Sub
    Private Sub frmLogin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        UpdateLayout()

    End Sub

    Private Sub UpdateLayout()

        If SplitContainer1.Width <= 0 OrElse SplitContainer1.Height <= 0 Then
            Return
        End If

        '60% LEFT / 40% RIGHT
        SplitContainer1.SplitterDistance =
        CInt(SplitContainer1.ClientSize.Width * 0.6)

        UpdateLeftPanel()
        UpdateRightPanel()

    End Sub
    Private Sub UpdateLeftPanel()

        Dim panelWidth As Integer = SplitContainer1.Panel1.ClientSize.Width
        Dim panelHeight As Integer = SplitContainer1.Panel1.ClientSize.Height

        '========================================
        ' COMMON CENTER
        '========================================

        Dim centerX As Integer = panelWidth \ 2

        '========================================
        ' LOGO
        '========================================

        Dim logoSize As Integer =
        CInt(panelWidth * 0.048)

        picLogo.Size = New Size(
        logoSize,
        logoSize
    )

        picLogo.Location = New Point(
        centerX - (picLogo.Width \ 2),
        CInt(panelHeight * 0.045)
    )

        picLogo.SizeMode = PictureBoxSizeMode.Zoom


        '========================================
        ' SCHOOL NAME
        '========================================

        lblSchool.AutoSize = False

        Dim schoolWidth As Integer =
        CInt(panelWidth * 0.4)

        Dim schoolHeight As Integer =
        CInt(panelHeight * 0.035)

        lblSchool.Size = New Size(
        schoolWidth,
        schoolHeight
    )

        lblSchool.Location = New Point(
        centerX - (lblSchool.Width \ 2),
        CInt(panelHeight * 0.105)
    )

        lblSchool.TextAlign = ContentAlignment.MiddleCenter


        '========================================
        ' GRADE
        '========================================

        lblGrade.AutoSize = False

        Dim gradeWidth As Integer =
        CInt(panelWidth * 0.45)

        Dim gradeHeight As Integer =
        CInt(panelHeight * 0.095)

        lblGrade.Size = New Size(
        gradeWidth,
        gradeHeight
    )

        lblGrade.Location = New Point(
        centerX - (lblGrade.Width \ 2) - 17,
        CInt(panelHeight * 0.4)
    )

        lblGrade.TextAlign = ContentAlignment.MiddleCenter


        '========================================
        ' ENCODER
        '========================================

        lblEncoder.AutoSize = False

        Dim encoderWidth As Integer =
        CInt(panelWidth * 0.55)

        Dim encoderHeight As Integer =
        CInt(panelHeight * 0.095)

        lblEncoder.Size = New Size(
        encoderWidth,
        encoderHeight
    )

        lblEncoder.Location = New Point(
        centerX - (lblEncoder.Width \ 2) - 17,
        lblGrade.Bottom - CInt(panelHeight * 0.005)
    )

        lblEncoder.TextAlign = ContentAlignment.MiddleCenter


        '========================================
        ' TITLE FONT SIZE
        '========================================

        Dim titleFontSize As Single =
        Math.Max(30, panelWidth * 0.052)

        lblGrade.Font = New Font(
        lblGrade.Font.FontFamily,
        titleFontSize,
        FontStyle.Bold
    )

        lblEncoder.Font = New Font(
        lblEncoder.Font.FontFamily,
        titleFontSize,
        FontStyle.Bold
    )


        '========================================
        ' ELEMENT
        '========================================

        lblElement.AutoSize = False

        Dim elementWidth As Integer =
        CInt(panelWidth * 0.12)

        Dim elementHeight As Integer =
        CInt(panelHeight * 0.035)

        lblElement.Size = New Size(
        elementWidth,
        elementHeight
    )

        lblElement.Location = New Point(
        centerX - (lblElement.Width \ 2) - 15,
        CInt(panelHeight * 0.915)
    )

        lblElement.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub pnlExitConfirmation_Paint(sender As Object, e As PaintEventArgs) Handles pnlExitConfirmation.Paint
        pnlExitConfirmation.Location = New Point(
        (Me.ClientSize.Width - pnlExitConfirmation.Width) \ 2,
        (Me.ClientSize.Height - pnlExitConfirmation.Height) \ 2)
    End Sub

    Private Sub LoginDesign_Paint(sender As Object, e As PaintEventArgs) Handles LoginDesign.Paint

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgot.LinkClicked

    End Sub

    Private Sub UpdateRightPanel()

        Dim panelWidth As Integer = SplitContainer1.Panel2.ClientSize.Width
        Dim panelHeight As Integer = SplitContainer1.Panel2.ClientSize.Height

        If panelWidth <= 0 OrElse panelHeight <= 0 Then
            Return
        End If


        '========================================
        ' HORIZONTAL CENTER
        '========================================

        Dim centerX As Integer = panelWidth \ 2

        Dim contentX As Integer =
        centerX - (492 \ 2)


        '========================================
        ' VERTICAL SPACING
        '========================================

        Dim headingTop As Integer =
        CInt(panelHeight * 0.2)

        Dim headingGap As Integer =
        CInt(panelHeight * 0.01)

        Dim labelGap As Integer =
        CInt(panelHeight * 0.045)

        Dim textboxGap As Integer =
        CInt(panelHeight * 0.01)

        Dim passwordGap As Integer =
        CInt(panelHeight * 0.01)

        Dim buttonGap As Integer =
        CInt(panelHeight * 0.055)

        Dim forgotGap As Integer =
        CInt(panelHeight * 0.015)

        Dim exitGap As Integer =
        CInt(panelHeight * 0.035)


        '========================================
        ' LOG IN TO YOUR
        ' SIZE = 327 × 45
        '========================================

        lblLogintext.AutoSize = False
        lblLogintext.Size = New Size(327, 45)

        lblLogintext.Location = New Point(
        centerX - (lblLogintext.Width \ 2),
        headingTop
    )

        lblLogintext.TextAlign =
        ContentAlignment.MiddleCenter


        '========================================
        ' ACCOUNT
        ' SIZE = 188 × 43
        '========================================

        lblAccounttext.AutoSize = False
        lblAccounttext.Size = New Size(188, 43)

        lblAccounttext.Location = New Point(
        centerX - (lblAccounttext.Width \ 2),
        lblLogintext.Bottom + headingGap
    )

        lblAccounttext.TextAlign =
        ContentAlignment.MiddleCenter


        '========================================
        ' USERNAME LABEL
        ' SIZE = 172 × 28
        '========================================

        lblUsername.AutoSize = False
        lblUsername.Size = New Size(172, 28)

        lblUsername.Location = New Point(
        contentX,
        lblAccounttext.Bottom + labelGap
    )

        lblUsername.TextAlign =
        ContentAlignment.MiddleLeft


        '========================================
        ' USERNAME TEXTBOX
        ' SIZE = 492 × 51
        '========================================

        txtUsername.Size = New Size(492, 51)

        txtUsername.Location = New Point(
        contentX,
        lblUsername.Bottom + textboxGap
    )


        '========================================
        ' PASSWORD LABEL
        ' SIZE = 108 × 28
        '========================================

        lblPassword.AutoSize = False
        lblPassword.Size = New Size(108, 28)

        lblPassword.Location = New Point(
        contentX,
        txtUsername.Bottom + passwordGap
    )

        lblPassword.TextAlign =
        ContentAlignment.MiddleLeft


        '========================================
        ' PASSWORD TEXTBOX
        ' SIZE = 492 × 51
        '========================================

        txtPassword.Size = New Size(492, 51)

        txtPassword.Location = New Point(
        contentX,
        lblPassword.Bottom + textboxGap
    )


        '========================================
        ' LOGIN BUTTON
        ' SIZE = 492 × 65
        '========================================

        btnLogin.Size = New Size(492, 65)

        btnLogin.Location = New Point(
        contentX,
        txtPassword.Bottom + buttonGap
    )


        '========================================
        ' FORGOT PASSWORD
        ' SIZE = 139 × 20
        '========================================

        linkForgot.AutoSize = False
        linkForgot.Size = New Size(139, 20)

        linkForgot.Location = New Point(
        btnLogin.Right - linkForgot.Width,
        btnLogin.Bottom + forgotGap
    )

        linkForgot.TextAlign =
        ContentAlignment.MiddleRight


        '========================================
        ' EXIT BUTTON
        ' SIZE = 492 × 44
        '========================================

        btnExit.Size = New Size(492, 44)

        btnExit.Location = New Point(
        contentX,
        linkForgot.Bottom + exitGap
    )

    End Sub

End Class