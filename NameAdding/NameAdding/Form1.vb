Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnAddName_Click(sender As Object, e As EventArgs) Handles btnAddName.Click
        ListBox1.Items.Add("Joshua")
        'ListBox1.Items.Add("Your Name")
    End Sub
End Class
