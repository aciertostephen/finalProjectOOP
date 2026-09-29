Imports System.Xml

Public Class Form1

    ' ============================================================
    ' FORM LOAD / RESIZE
    ' ============================================================
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


    ' ============================================================
    ' WINDOW CONTROLS (minimize / close)
    ' ============================================================
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        pnlExitConfirmation.Visible = True
        pnlExitConfirmation.BringToFront()
    End Sub


    ' ============================================================
    ' EXIT CONFIRMATION
    ' ============================================================
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

End Class