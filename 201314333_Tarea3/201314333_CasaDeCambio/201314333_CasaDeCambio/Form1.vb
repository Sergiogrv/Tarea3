Public Class Form1

    Private Sub cbCompras_CheckedChanged(sender As Object, e As EventArgs) Handles cbCompras.CheckedChanged
        If cbCompras.Checked = True Then
            txtCompra.Enabled = True
        Else
            txtCompra.Enabled = False
        End If

    End Sub

    Private Sub cbVentas_CheckedChanged(sender As Object, e As EventArgs) Handles cbVentas.CheckedChanged
        If cbVentas.Checked = True Then
            txtVenta.Enabled = True
        Else
            txtVenta.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub
End Class
