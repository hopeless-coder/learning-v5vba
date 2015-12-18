Public Class frmFirst

    Private Sub frmFirst_Click(sender As Object, e As EventArgs) Handles Me.Click
        MessageBox.Show("form is clicked")
    End Sub

   

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        MessageBox.Show("button is clicked")
        lstBxSearch.Items.Add(txtSearch.Text)
    End Sub

    Private Sub frmFirst_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnSearch.Enabled = False
        lstBxSearch.Enabled = False
        trViewNodes.Nodes.Add(1)
        trViewNodes.Nodes.Add(2)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        btnSearch.Enabled = True
        txtSearch.ForeColor = Color.Red
        lstBxSearch.Enabled = True
        lstBxSearch.Items.Clear()
    End Sub

   
    Private Sub lstBxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxSearch.SelectedIndexChanged
        'MessageBox.Show("listbox is clicked")
        lstBxResult.Items.Add(lstBxSearch.SelectedItem)
    End Sub

    Private Sub trViewNodes_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trViewNodes.AfterSelect

    End Sub
End Class
