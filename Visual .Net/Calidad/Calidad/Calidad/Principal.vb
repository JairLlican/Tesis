Public Class Principal
    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs)
        CenterPictureBox()
    End Sub

    Private Sub Principal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterPictureBox()
    End Sub

    Private Sub CenterPictureBox()
        PictureBox1.Left = (Me.ClientSize.Width - PictureBox1.Width) / 2
        PictureBox1.Top = (Me.ClientSize.Height - PictureBox1.Height) / 2
    End Sub
End Class
