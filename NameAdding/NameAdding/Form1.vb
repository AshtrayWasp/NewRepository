Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnAddName_Click(sender As Object, e As EventArgs) Handles btnAddName.Click
        ListBox1.Items.Add("Joshy ;)")
        'ListBox1.Items.Add("Your Name")
        ListBox1.Items.Add("Thomas Kramer")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
