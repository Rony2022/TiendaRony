Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim cmd As New SqlCommand
        If txtnombre.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" And txtfecha.Text <> "" And txttelefono.Text <> "" And txtemail.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("AgregarCliente", conect)
                'parametros
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@apellido", txtapellido.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.Parameters.AddWithValue("fecha_nacimiento", txtfecha.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()

                MsgBox("Cliente: " & txtnombre.Text & " " & txtapellido.Text & " agregado Exitosamente", MsgBoxStyle.Information)
                LimpiarCajas()
            Catch ex As Exception
                MsgBox(ex.ToString & "Ha ocurrido un error", MsgBoxStyle.Critical)
                Cerrar_Conexion()
            End Try
        Else
            MsgBox("Por favor llena todos los campos para agregar un nuevo cliente", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Dim cmd As New SqlCommand
        If txtid.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" And txtfecha.Text <> "" And txttelefono.Text <> "" And txtemail.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("ActualizarCliente", conect)
                'parametros
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Id_Cliente", txtid.Text)
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text)
                cmd.Parameters.AddWithValue("@apellido", txtapellido.Text)
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text)
                cmd.Parameters.AddWithValue("fecha_nacimiento", txtfecha.Text)
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text)
                cmd.Parameters.AddWithValue("@email", txtemail.Text)
                cmd.ExecuteNonQuery()
                Cerrar_Conexion()

                MsgBox("Cliente: " & txtnombre.Text & " " & txtapellido.Text & " Actualizado Exitosamente", MsgBoxStyle.Information)
                LimpiarCajas()

            Catch ex As Exception
                MsgBox(ex.ToString & "Error", MsgBoxStyle.Critical)
                Cerrar_Conexion()
            End Try
        Else
            MsgBox("LLene los campos", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim del As New SqlCommand
        If txtid.Text <> "" Then

            Try
                Abrir_Conexion()
                del = New SqlCommand("EliminarClientes", conect)

                del.CommandType = CommandType.StoredProcedure
                del.Parameters.AddWithValue("@Id_Cliente", txtid.Text)
                del.ExecuteNonQuery()
                Cerrar_Conexion()
                MsgBox("Cliente Eliminado Exitosamente", MsgBoxStyle.Information)
                LimpiarCajas()
            Catch ex As Exception
                MsgBox("Error", MsgBoxStyle.Critical)
                Cerrar_Conexion()
            End Try
        Else
            MsgBox("Ingrese un id para poder eliminar un Cliente", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        mostrar()

    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        LimpiarCajas()
    End Sub
    Private Sub LimpiarCajas()
        txtid.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdireccion.Text = ""
        txtfecha.Text = ""
        txttelefono.Text = ""
        txtemail.Text = ""
    End Sub
    Private Sub mostrar()
        If txtid.Text <> "" Then
            Try
                Abrir_Conexion()
                Dim sql As String
                Dim rs As SqlDataReader
                Dim com As New SqlCommand
                sql = "select nombre,apellido,direccion,fecha_nacimiento,telefono,email from cliente where id_cliente=" & txtid.Text
                com = New SqlCommand(sql, conect)
                rs = com.ExecuteReader()
                rs.Read()

                txtnombre.Text = rs(0)
                txtapellido.Text = rs(1)
                txtdireccion.Text = rs(2)
                txtfecha.Text = rs(3)
                txttelefono.Text = rs(4)
                txtemail.Text = rs(5)

                Cerrar_Conexion()
            Catch ex As Exception
                MsgBox("No se encontro ningun cliente con ese id", MsgBoxStyle.Critical, Title:="Sistema Biblioteca")
                LimpiarCajas()
                Cerrar_Conexion()
            End Try
        Else
            MsgBox("Seleccione un id para mostrar el cliente", MsgBoxStyle.Critical, Title:="Sistema Biblioteca")
        End If
    End Sub
End Class
