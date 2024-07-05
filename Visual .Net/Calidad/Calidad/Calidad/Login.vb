Imports System.Data.SqlClient
Imports System.Configuration
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If (UsuarioText.Text = "jllican" And ContraseñaText.Text = "Awvx6jgK") Then
            ' Crear una instancia del formulario Principal
            Dim principalForm As New Principal
            ' Mostrar el formulario
            principalForm.Show()
            ' Ocultar el formulario actual
            Me.Hide()
        Else
            MsgBox("El usuario no se encuentra registrado")
        End If
    End Sub

End Class