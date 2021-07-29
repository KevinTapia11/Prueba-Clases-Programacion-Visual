Imports Clases


Public Class frmRegistro
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Empleado1.Apellidos = txtApellidos.Text
        empleado1.Nombres = txtNombres.Text
        empleado1.Documento = txtDocumento.Text
        empleado1.Tipo = cboTipo.Text
        empleado1.TipoContrato = cboContrato.Text

        empleado1.calcularSueldo(750)

        dgbEmpleados.Rows.Insert(0, empleado1.Tipo, empleado1.Apellidos, empleado1.Nombres, empleado1.Documento, empleado1.Sueldo)

    End Sub
End Class
