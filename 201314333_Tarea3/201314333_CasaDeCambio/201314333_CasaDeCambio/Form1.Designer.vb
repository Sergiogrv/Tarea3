﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbVentas = New System.Windows.Forms.CheckBox()
        Me.cbCompras = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.compraDolar = New System.Windows.Forms.RadioButton()
        Me.compraPM = New System.Windows.Forms.RadioButton()
        Me.compraEuro = New System.Windows.Forms.RadioButton()
        Me.compraCCR = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ventaCCR = New System.Windows.Forms.RadioButton()
        Me.ventaEuro = New System.Windows.Forms.RadioButton()
        Me.ventaPM = New System.Windows.Forms.RadioButton()
        Me.ventaDolar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbVentas)
        Me.GroupBox1.Controls.Add(Me.cbCompras)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tarasacciones"
        '
        'cbVentas
        '
        Me.cbVentas.AutoSize = True
        Me.cbVentas.Location = New System.Drawing.Point(34, 43)
        Me.cbVentas.Name = "cbVentas"
        Me.cbVentas.Size = New System.Drawing.Size(53, 17)
        Me.cbVentas.TabIndex = 1
        Me.cbVentas.Text = "venta"
        Me.cbVentas.UseVisualStyleBackColor = True
        '
        'cbCompras
        '
        Me.cbCompras.AutoSize = True
        Me.cbCompras.Location = New System.Drawing.Point(34, 19)
        Me.cbCompras.Name = "cbCompras"
        Me.cbCompras.Size = New System.Drawing.Size(62, 17)
        Me.cbCompras.TabIndex = 0
        Me.cbCompras.Text = "Compra"
        Me.cbCompras.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtVenta)
        Me.GroupBox2.Controls.Add(Me.txtCompra)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Compra"
        '
        'txtVenta
        '
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(119, 88)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(100, 20)
        Me.txtVenta.TabIndex = 4
        '
        'txtCompra
        '
        Me.txtCompra.Enabled = False
        Me.txtCompra.Location = New System.Drawing.Point(119, 37)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtCompra.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.compraCCR)
        Me.GroupBox3.Controls.Add(Me.compraEuro)
        Me.GroupBox3.Controls.Add(Me.compraPM)
        Me.GroupBox3.Controls.Add(Me.compraDolar)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 173)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra"
        '
        'compraDolar
        '
        Me.compraDolar.AutoSize = True
        Me.compraDolar.Location = New System.Drawing.Point(13, 30)
        Me.compraDolar.Name = "compraDolar"
        Me.compraDolar.Size = New System.Drawing.Size(50, 17)
        Me.compraDolar.TabIndex = 0
        Me.compraDolar.TabStop = True
        Me.compraDolar.Text = "Dolar"
        Me.compraDolar.UseVisualStyleBackColor = True
        '
        'compraPM
        '
        Me.compraPM.AutoSize = True
        Me.compraPM.Location = New System.Drawing.Point(13, 63)
        Me.compraPM.Name = "compraPM"
        Me.compraPM.Size = New System.Drawing.Size(108, 17)
        Me.compraPM.TabIndex = 1
        Me.compraPM.TabStop = True
        Me.compraPM.Text = "Pesos Mexicanos"
        Me.compraPM.UseVisualStyleBackColor = True
        '
        'compraEuro
        '
        Me.compraEuro.AutoSize = True
        Me.compraEuro.Location = New System.Drawing.Point(13, 97)
        Me.compraEuro.Name = "compraEuro"
        Me.compraEuro.Size = New System.Drawing.Size(52, 17)
        Me.compraEuro.TabIndex = 2
        Me.compraEuro.TabStop = True
        Me.compraEuro.Text = "Euros"
        Me.compraEuro.UseVisualStyleBackColor = True
        '
        'compraCCR
        '
        Me.compraCCR.AutoSize = True
        Me.compraCCR.Location = New System.Drawing.Point(13, 131)
        Me.compraCCR.Name = "compraCCR"
        Me.compraCCR.Size = New System.Drawing.Size(52, 17)
        Me.compraCCR.TabIndex = 3
        Me.compraCCR.TabStop = True
        Me.compraCCR.Text = "Colon"
        Me.compraCCR.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ventaCCR)
        Me.GroupBox4.Controls.Add(Me.ventaEuro)
        Me.GroupBox4.Controls.Add(Me.ventaPM)
        Me.GroupBox4.Controls.Add(Me.ventaDolar)
        Me.GroupBox4.Location = New System.Drawing.Point(184, 183)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(135, 173)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Venta"
        '
        'ventaCCR
        '
        Me.ventaCCR.AutoSize = True
        Me.ventaCCR.Location = New System.Drawing.Point(13, 131)
        Me.ventaCCR.Name = "ventaCCR"
        Me.ventaCCR.Size = New System.Drawing.Size(52, 17)
        Me.ventaCCR.TabIndex = 3
        Me.ventaCCR.TabStop = True
        Me.ventaCCR.Text = "Colon"
        Me.ventaCCR.UseVisualStyleBackColor = True
        '
        'ventaEuro
        '
        Me.ventaEuro.AutoSize = True
        Me.ventaEuro.Location = New System.Drawing.Point(13, 97)
        Me.ventaEuro.Name = "ventaEuro"
        Me.ventaEuro.Size = New System.Drawing.Size(52, 17)
        Me.ventaEuro.TabIndex = 2
        Me.ventaEuro.TabStop = True
        Me.ventaEuro.Text = "Euros"
        Me.ventaEuro.UseVisualStyleBackColor = True
        '
        'ventaPM
        '
        Me.ventaPM.AutoSize = True
        Me.ventaPM.Location = New System.Drawing.Point(13, 63)
        Me.ventaPM.Name = "ventaPM"
        Me.ventaPM.Size = New System.Drawing.Size(108, 17)
        Me.ventaPM.TabIndex = 1
        Me.ventaPM.TabStop = True
        Me.ventaPM.Text = "Pesos Mexicanos"
        Me.ventaPM.UseVisualStyleBackColor = True
        '
        'ventaDolar
        '
        Me.ventaDolar.AutoSize = True
        Me.ventaDolar.Location = New System.Drawing.Point(13, 30)
        Me.ventaDolar.Name = "ventaDolar"
        Me.ventaDolar.Size = New System.Drawing.Size(50, 17)
        Me.ventaDolar.TabIndex = 0
        Me.ventaDolar.TabStop = True
        Me.ventaDolar.Text = "Dolar"
        Me.ventaDolar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(495, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(495, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbVentas As CheckBox
    Friend WithEvents cbCompras As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents compraCCR As RadioButton
    Friend WithEvents compraEuro As RadioButton
    Friend WithEvents compraPM As RadioButton
    Friend WithEvents compraDolar As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ventaCCR As RadioButton
    Friend WithEvents ventaEuro As RadioButton
    Friend WithEvents ventaPM As RadioButton
    Friend WithEvents ventaDolar As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
