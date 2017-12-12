Public Class Form2
    Private Sub btnBlueViolet_Click(sender As Object, e As EventArgs) Handles btnBlueViolet.Click
        My.Forms.Form1.BackColor = Color.BlueViolet
        My.Forms.Form2.Visible = False
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        My.Forms.Form1.BackColor = Color.Empty
        My.Forms.Form2.Visible = False
    End Sub

    Private Sub btnCyan_Click(sender As Object, e As EventArgs) Handles btnCyan.Click
        My.Forms.Form1.BackColor = Color.DarkCyan
        My.Forms.Form2.Visible = False
    End Sub

    Private Sub btnLimeGreen_Click(sender As Object, e As EventArgs) Handles btnLimeGreen.Click
        My.Forms.Form1.BackColor = Color.LimeGreen
        My.Forms.Form2.Visible = False
    End Sub

    Private Sub btnCornFlowerBlue_Click(sender As Object, e As EventArgs) Handles btnCornFlowerBlue.Click
        My.Forms.Form1.BackColor = Color.CornflowerBlue
        My.Forms.Form2.Visible = False
    End Sub
End Class