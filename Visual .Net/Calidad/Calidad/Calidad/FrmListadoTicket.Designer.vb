<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoTicket
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
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        Me.BtnCerrarT = New System.Windows.Forms.Button()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAtender = New System.Windows.Forms.Button()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(14, 11)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(112, 41)
        Me.BtnActualizar.TabIndex = 0
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnAsignar
        '
        Me.BtnAsignar.Location = New System.Drawing.Point(249, 9)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(114, 42)
        Me.BtnAsignar.TabIndex = 1
        Me.BtnAsignar.Text = "Asignar Ticket"
        Me.BtnAsignar.UseVisualStyleBackColor = True
        '
        'BtnCerrarT
        '
        Me.BtnCerrarT.Location = New System.Drawing.Point(488, 11)
        Me.BtnCerrarT.Name = "BtnCerrarT"
        Me.BtnCerrarT.Size = New System.Drawing.Size(113, 42)
        Me.BtnCerrarT.TabIndex = 2
        Me.BtnCerrarT.Text = "Cerrar Ticket"
        Me.BtnCerrarT.UseVisualStyleBackColor = True
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(607, 12)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(113, 41)
        Me.BtnAnular.TabIndex = 3
        Me.BtnAnular.Text = "Anular Ticket"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Crear Ticket"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(726, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(113, 41)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(858, 273)
        Me.DataGridView1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.BtnAtender)
        Me.Panel1.Controls.Add(Me.BtnActualizar)
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnAnular)
        Me.Panel1.Controls.Add(Me.BtnAsignar)
        Me.Panel1.Controls.Add(Me.BtnCerrarT)
        Me.Panel1.Location = New System.Drawing.Point(-2, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 66)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LabelTipo)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(858, 109)
        Me.Panel2.TabIndex = 8
        '
        'BtnAtender
        '
        Me.BtnAtender.Location = New System.Drawing.Point(369, 10)
        Me.BtnAtender.Name = "BtnAtender"
        Me.BtnAtender.Size = New System.Drawing.Size(113, 42)
        Me.BtnAtender.TabIndex = 6
        Me.BtnAtender.Text = "Atender Ticket"
        Me.BtnAtender.UseVisualStyleBackColor = True
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.BackColor = System.Drawing.Color.Khaki
        Me.LabelTipo.Location = New System.Drawing.Point(12, 5)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(83, 20)
        Me.LabelTipo.TabIndex = 0
        Me.LabelTipo.Text = "Area Ticket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Ticket:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Khaki
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Asignado:  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Khaki
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fechas:       "
        '
        'FrmListadoTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmListadoTicket"
        Me.Text = "FrmListadoTicket"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAsignar As Button
    Friend WithEvents BtnCerrarT As Button
    Friend WithEvents BtnAnular As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAtender As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTipo As Label
End Class
