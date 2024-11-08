Imports System.Data.SqlClient

Public Class Form1
    Private conexion As SqlConnection
    Private connectionString As String = "Data Source=DESKTOP-9R10QQU;Initial Catalog=Biblioteca;Trusted_Connection=True;"
    Private sqlConnection As New SqlConnection(connectionString)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDataGridView()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim searchTerm As String = txtBuscar.Text
        Dim query As String = "SELECT * FROM Libros WHERE Nombre LIKE @SearchTerm OR Autor LIKE @SearchTerm OR Genero LIKE @SearchTerm"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%") ' 
                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            txtCodigo.Text = reader("LibroID").ToString()
                            txtTitulo.Text = reader("Titulo").ToString()
                            txtAutor.Text = reader("Autor").ToString()
                            txtGenero.Text = reader("Genero").ToString()
                            dtpFecha.Value = Convert.ToDateTime(reader("FechaPublicacion"))
                        End While
                    Else
                        MessageBox.Show("No se encontraron libros.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            sqlConnection.Open()
            MessageBox.Show("Conectado a la base de datos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDesconectar_Click(sender As Object, e As EventArgs) Handles btnDesconectar.Click
        Try
            sqlConnection.Close()
            MessageBox.Show("Desconectado de la base de datos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al desconectar de la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarDataGridView()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM Productos"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvLibros.DataSource = table
        End Using
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim libroID As Integer
        If Not Integer.TryParse(txtCodigo.Text, libroID) Then
            MessageBox.Show("Por favor, ingrese un ID de libro válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsTextValid(txtTitulo.Text) Then
            MessageBox.Show("El título no puede contener números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsTextValid(txtAutor.Text) Then
            MessageBox.Show("El autor no puede contener números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsTextValid(txtGenero.Text) Then
            MessageBox.Show("El género no puede contener números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Libros (LibroID, Titulo, Autor, Genero, FechaPublicacion) VALUES (@LibroID, @Titulo, @Autor, @Genero, @FechaPublicacion)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@LibroID", Convert.ToInt32(txtCodigo.Text))
                    command.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                    command.Parameters.AddWithValue("@Autor", txtAutor.Text)
                    command.Parameters.AddWithValue("@Genero", txtGenero.Text)
                    command.Parameters.AddWithValue("@FechaPublicacion", dtpFecha.Value)

                    command.ExecuteNonQuery()
                End Using
            End Using
            ActualizarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error al insertar el libro: " & ex.Message)
        End Try
    End Sub
    Private Function IsTextValid(text As String) As Boolean
        ' Verifica si el texto contiene algún dígito
        Return Not text.Any(Function(c) Char.IsDigit(c))
    End Function
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Libros SET Titulo = @Titulo, Autor = @Autor, Genero = @Genero, FechaPublicacion = @FechaPublicacion WHERE LibroID = @LibroID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@LibroID", Convert.ToInt32(txtCodigo.Text))
                    command.Parameters.AddWithValue("@Titulo", txtTitulo.Text)
                    command.Parameters.AddWithValue("@Autor", txtAutor.Text)
                    command.Parameters.AddWithValue("@Genero", txtGenero.Text)
                    command.Parameters.AddWithValue("@FechaPublicacion", dtpFecha.Value)
                    command.ExecuteNonQuery()
                End Using
            End Using
            ActualizarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error al modificar el libro: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM Libros WHERE LibroID=@LibroID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@LibroID", Convert.ToInt32(txtCodigo.Text))
                    command.ExecuteNonQuery()
                End Using
            End Using
            ActualizarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el producto: " & ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ActualizarDataGridView()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodigo.Clear()
        txtTitulo.Clear()
        txtGenero.Clear()
        txtAutor.Clear()
    End Sub

    Private Sub dgvLibros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLibros.Rows(e.RowIndex)
            txtCodigo.Text = row.Cells("LibroID").Value.ToString()
            txtTitulo.Text = row.Cells("Titulo").Value.ToString()
            txtAutor.Text = row.Cells("Autor").Value.ToString()
            txtGenero.Text = row.Cells("Genero").Value.ToString()
            dtpFecha.Value = Convert.ToDateTime(row.Cells("FechaPublicacion").Value)
        End If
    End Sub

End Class
