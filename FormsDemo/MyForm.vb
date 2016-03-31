Public Class frmDemo

    Private Sub frmDemo_Click(sender As Object, e As EventArgs) Handles Me.Click
        MessageBox.Show("Form is clicked")
    End Sub


    Private Sub frmDemo_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnSubmit.Enabled = False
    End Sub

    Private Sub txtBx_TextChanged(sender As Object, e As EventArgs) Handles txtBx.TextChanged
        txtBx.BackColor = Color.RoyalBlue
        txtBx.ForeColor = Color.Yellow
        btnSubmit.Enabled = True
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Button is clicked")
    End Sub
End Class
