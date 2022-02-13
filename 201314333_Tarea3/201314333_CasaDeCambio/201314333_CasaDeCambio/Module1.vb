Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPM = 0.38
    Public Const tcEuro = 7.89
    Public Const tcCCR = 0.012

    Const comisionCompra = 2.5 / 100
    Const comisionVenta = 3 / 100

    Dim total_parcial = 0
    Dim total
    Public calcularCompra




    Sub Limpiar()
        Form1.txtCompra.Clear()
        Form1.txtVenta.Clear()
        Form1.cbCompras.Checked = False
        Form1.cbVentas.Checked = False

        Form2.Label1.Text = "Limpio"
    End Sub

    Function Calcular(cantidadCompra As Double, tipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            total_parcial = cantidadCompra / tipoCompra
            total = total_parcial * comisionCompra + total_parcial
        End If

        Return total


    End Function

End Module
