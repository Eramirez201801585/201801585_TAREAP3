Public Class Form1
    Private Sub btnCalculo_Click(sender As Object, e As EventArgs) Handles btnCalculo.Click
        If txtNombre.Text = "" Then
            MsgBox("Ingrese nombre del paciente",, "Error")
            Exit Sub
        End If
        If txtNit.Text = "" Or IsNumeric(txtNit.Text) = False Then
            MsgBox("Ingrese número de Nit",, "Error")
            Exit Sub
        End If
        If txtDias.Text = "" Or IsNumeric(txtDias.Text) = False Then
            MsgBox("Ingrese el número de días de hospitalización",, "Error")
            Exit Sub
        End If
        If cmbHabitacion.Text = "" Then
            MsgBox("Seleccione el tipo de habitación",, "Error")
            Exit Sub
        End If
        If txtHonoraios.Text = "" Or IsNumeric(txtHonoraios.Text) = False Then
            MsgBox("Ingrese el monto de honorarios del médico",, "Error")
            Exit Sub
        End If
        If cmbFormaPago.Text = "" Then
            MsgBox("Seleccione la forma de pago",, "Error")
            Exit Sub
        End If

        If NitEnBD() Then

            Exit Sub
        Else

            If indice < 6 Then
                GuardarEnMatriz()
                indice = indice + 1
            Else
                MsgBox("Memoria Llena",, "Error")
                Exit Sub
            End If

        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Mostrar()
    End Sub

    Private Sub btnLimpiarMatriz_Click(sender As Object, e As EventArgs) Handles btnLimpiarMatriz.Click
        LimpiarMatriz()
    End Sub

    Private Sub btnLimpiarIngresos_Click(sender As Object, e As EventArgs) Handles btnLimpiarIngresos.Click
        LimpiarIngresos()
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click
        lblE1.Text = Fe1().ToString
        lblE2.Text = Fe2().ToString
        lblE3.Text = Fe3().ToString
    End Sub

    Private Sub btnLimpiarEstadisticas_Click(sender As Object, e As EventArgs) Handles btnLimpiarEstadisticas.Click
        lblE1.Text = ""
        lblE2.Text = ""
        lblE3.Text = ""
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If txtConsultar.Text = "" Or IsNumeric(txtConsultar.Text) = False Then
            MsgBox("Ingrese el número de NIT a consulta en el espacio 'CONSULTAR'",, "Error")
            Exit Sub
        Else
            If Consulta(txtConsultar.Text.ToString) Then
                MsgBox("Consulta Exitosa",, "Mensaje")
            Else
                MsgBox("Lo sentimos, no se encuentra este número de NIT en la matriz",, "Mensaje")
            End If
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgBox("¿Desea Salir", vbYesNo, "Mensaje") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class
