<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.dgvLibros = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(280, 25)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(253, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(88, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese cualquier dato del libro para buscar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.txtAutor)
        Me.GroupBox1.Controls.Add(Me.txtGenero)
        Me.GroupBox1.Controls.Add(Me.txtTitulo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 185)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRAR LIBRO"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(576, 138)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(487, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fecha de Publicación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Género:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Autor:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(490, 80)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ingresa Codigo:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(449, 138)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 12
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(301, 138)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(170, 138)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(39, 138)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(336, 35)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(100, 20)
        Me.txtAutor.TabIndex = 5
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(336, 80)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(100, 20)
        Me.txtGenero.TabIndex = 4
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(88, 80)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 2
        '
        'dgvLibros
        '
        Me.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibros.Location = New System.Drawing.Point(48, 276)
        Me.dgvLibros.Name = "dgvLibros"
        Me.dgvLibros.Size = New System.Drawing.Size(715, 150)
        Me.dgvLibros.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscar.Location = New System.Drawing.Point(552, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(686, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(88, 23)
        Me.btnConectar.TabIndex = 7
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Location = New System.Drawing.Point(686, 44)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(88, 23)
        Me.btnDesconectar.TabIndex = 8
        Me.btnDesconectar.Text = "Desconectar"
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDesconectar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.dgvLibros)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnConectar As Button
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnDesconectar As Button
End Class
