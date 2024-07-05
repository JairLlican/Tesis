Public Class Principal
    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Public Sub New()
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()

        ' Agrega cualquier inicialización después de la llamada a InitializeComponent().
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

    Private Sub ListadoDeTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTicketsToolStripMenuItem.Click

    End Sub

    Private Sub ReporteFormulariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteFormulariosToolStripMenuItem.Click

    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Cerrar la aplicación cuando se cierre el formulario Principal
        Application.Exit()
    End Sub

    Private Sub ListadoTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoTicketsToolStripMenuItem.Click
        ' Crear una instancia del formulario FrmListadoTickets
        Dim listadoTicketsForm As New FrmListadoTicket
        ' Mostrar el formulario como un diálogo modal
        listadoTicketsForm.ShowDialog()
    End Sub
End Class
