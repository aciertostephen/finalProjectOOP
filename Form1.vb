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
End Class
