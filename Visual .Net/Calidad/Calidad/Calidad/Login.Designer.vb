﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LogoLogin = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsuarioText = New System.Windows.Forms.TextBox()
        Me.ContraseñaText = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.LogoLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoLogin
        '
        Me.LogoLogin.Image = Global.Calidad.My.Resources.Resources.UNMSM2
        Me.LogoLogin.Location = New System.Drawing.Point(12, 12)
        Me.LogoLogin.Name = "LogoLogin"
        Me.LogoLogin.Size = New System.Drawing.Size(233, 280)
        Me.LogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoLogin.TabIndex = 0
        Me.LogoLogin.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(290, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(252, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inicio Sesion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(290, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(251, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contraseña"
        '
        'UsuarioText
        '
        Me.UsuarioText.BackColor = System.Drawing.Color.White
        Me.UsuarioText.Location = New System.Drawing.Point(383, 111)
        Me.UsuarioText.Name = "UsuarioText"
        Me.UsuarioText.Size = New System.Drawing.Size(205, 27)
        Me.UsuarioText.TabIndex = 4
        '
        'ContraseñaText
        '
        Me.ContraseñaText.Location = New System.Drawing.Point(383, 193)
        Me.ContraseñaText.Name = "ContraseñaText"
        Me.ContraseñaText.Size = New System.Drawing.Size(205, 27)
        Me.ContraseñaText.TabIndex = 5
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(290, 248)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(127, 29)
        Me.BtnIngresar.TabIndex = 6
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(449, 248)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 29)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 304)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LogoLogin)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.ContraseñaText)
        Me.Controls.Add(Me.UsuarioText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoLogin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UsuarioText As TextBox
    Friend WithEvents ContraseñaText As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnSalir As Button
End Class
