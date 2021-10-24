Imports System.Math
Module Module1
    Public Const Pprivada As Double = 350
    Public Const Psemiprivada As Double = 250
    Public Const Pnoprivada As Double = 150
    Public Const DescEfec As Double = -0.1
    Public Const DesDepos As Double = -0.1
    Public Const DescACH As Double = -0.08
    Public Const RecTarjeta As Double = +0.015

    Public Matriz(5, 8) As String
    Public indice As Byte = 0

    Function NitEnBD() As Boolean
        Dim i As Byte = 0

        While i < indice

            If Matriz(i, 1) = Form1.txtNit.Text Then
                MsgBox("El número de NIT del paciente ya existe en la base de Datos",, "Error")
                Form1.txtNit.Text = ""
                Form1.txtNit.Focus()
                NitEnBD = True
                Return NitEnBD
            Else

                i = i + 1
            End If
        End While

        NitEnBD = False
        Return NitEnBD
    End Function

    Sub GuardarEnMatriz()
        Matriz(indice, 0) = Form1.txtNombre.Text
        Matriz(indice, 1) = Form1.txtNit.Text.ToString
        Matriz(indice, 2) = Form1.txtDias.Text.ToString
        Matriz(indice, 3) = Form1.cmbHabitacion.Text
        Matriz(indice, 4) = Form1.txtHonoraios.Text.ToString
        Matriz(indice, 5) = Form1.cmbFormaPago.Text.ToString
        Matriz(indice, 6) = Fparcial(Val(Form1.txtDias.Text), Form1.cmbHabitacion.Text, Val(Form1.txtHonoraios.Text)).ToString
        Matriz(indice, 7) = Fdescrec(Form1.cmbFormaPago.Text, Val(Matriz(indice, 6))).ToString
        Matriz(indice, 8) = Round(Val(Matriz(indice, 6)) + Val(Matriz(indice, 7)), 2)

    End Sub

    Function Fparcial(ByVal dias As Double, ByVal habitacion As String, ByVal honorarios As Double) As Double
        Select Case habitacion
            Case "Privada"
                Fparcial = Round((dias * Pprivada) + honorarios, 2)
            Case "Semiprivada"
                Fparcial = Round((dias * Psemiprivada) + honorarios, 2)
            Case "No privada"
                Fparcial = Round((dias * Pnoprivada) + honorarios, 2)
        End Select
        Return Fparcial
    End Function

    Function Fdescrec(ByVal forma As String, ByVal parcial As Double) As Double
        Select Case forma
            Case "Efectivo"
                Fdescrec = Round(parcial * DescEfec, 2)
            Case "Transferencia ACH"
                Fdescrec = Round(parcial * DescACH, 2)
            Case "Depósito bancario"
                Fdescrec = Round(parcial * DesDepos, 2)
            Case "Tarjeta de crédito"
                Fdescrec = Round(parcial * RecTarjeta, 2)
            Case Else
                Fdescrec = 0
        End Select
        Return Fdescrec
    End Function


    Sub Mostrar()
        Form1.DataGridView1.Rows.Clear()

        Dim i As Byte = 0

        While i < indice
            Form1.DataGridView1.Rows.Add(Matriz(i, 0), Matriz(i, 1), Matriz(i, 2), Matriz(i, 3), Matriz(i, 4), Matriz(i, 5), Matriz(i, 6), Matriz(i, 7), Matriz(i, 8))
            i = i + 1
        End While
    End Sub

    Sub LimpiarMatriz()
        Form1.DataGridView1.Rows.Clear()

        Dim i As Byte = 0
        Dim j As Byte = 0

        While i < indice
            While j < 9
                Matriz(i, j) = Nothing
                j = j + 1
            End While
            i = i + 1
            j = 0
        End While

        indice = 0
    End Sub

    Sub LimpiarIngresos()
        Form1.txtNombre.Clear()
        Form1.txtNit.Clear()
        Form1.txtDias.Clear()
        Form1.cmbHabitacion.SelectedIndex = -1
        Form1.txtHonoraios.Clear()
        Form1.cmbFormaPago.SelectedIndex = -1
        Form1.txtConsultar.Clear()

    End Sub

    Function Fe1() As Byte
        Dim i As Byte = 0
        Fe1 = 0

        While i < indice
            If Matriz(i, 3) = "Privada" Then
                Fe1 = Fe1 + 1
            End If
            i = i + 1
        End While
        Return Fe1
    End Function

    Function Fe2() As Double
        Dim i As Byte = 0
        Fe2 = 0

        While i < indice
            If Matriz(i, 5) = "Transferencia ACH" Then
                Fe2 = Fe2 + Val(Matriz(i, 8))
            End If
            i = i + 1
        End While

        Return Fe2
    End Function

    Function Fe3() As Double
        Dim i As Byte = 0
        Fe3 = 0

        While i < indice
            If Matriz(i, 3) = "No privada" Then
                Fe3 = Fe3 + Val(Matriz(i, 2))
            End If
            i = i + 1
        End While
        Return Fe3
    End Function

    Function Consulta(ByRef nit As String)
        Dim i As Byte = 0

        While i < indice

            If Matriz(i, 1) = nit Then
                Form1.DataGridView1.Rows.Clear()
                Form1.txtNombre.Text = Matriz(i, 0)
                Form1.txtNit.Text = Val(Matriz(i, 1))
                Form1.txtDias.Text = Val(Matriz(i, 2))
                Form1.cmbHabitacion.Text = Matriz(i, 3)
                Form1.txtHonoraios.Text = Val(Matriz(i, 4))
                Form1.cmbFormaPago.Text = Matriz(i, 5)
                Form1.DataGridView1.Rows.Add(Matriz(i, 0), Matriz(i, 1), Matriz(i, 2), Matriz(i, 3), Matriz(i, 4), Matriz(i, 5), Matriz(i, 6), Matriz(i, 7), Matriz(i, 8))
                Consulta = True
                Return Consulta
            Else
                i = i + 1
            End If
        End While

        Consulta = False
        Return Consulta
    End Function
End Module
