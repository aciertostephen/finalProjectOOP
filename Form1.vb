Imports System.Xml

Public Class Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
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
End Class
