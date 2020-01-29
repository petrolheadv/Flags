Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim itemselect As String
        itemselect = ListBox1.SelectedItem

        Select Case itemselect
            Case "England"
                Label1.Text = itemselect
                Label2.Text = "Hello Programmer"
                PictureBox1.Image = My.Resources.enn

            Case "Germany"
                Label1.Text = itemselect
                Label2.Text = "Hallo Programmierer"
                PictureBox1.Image = My.Resources.german

            Case "Mexico"
                Label1.Text = itemselect
                Label2.Text = "Hola Programador"
                PictureBox1.Image = My.Resources.mexico

            Case "Italy"
                Label1.Text = itemselect
                Label2.Text = "Ciao Programmator"
                PictureBox1.Image = My.Resources.italy
        End Select
    End Sub
End Class
