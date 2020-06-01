<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(123, 128)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(194, 124)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(132, 22)
        Me.txtCantidad.TabIndex = 28
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(194, 211)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 28)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(336, 211)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(62, 211)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 28)
        Me.btnCalcular.TabIndex = 25
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(194, 92)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(132, 22)
        Me.txtPrecio.TabIndex = 23
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Location = New System.Drawing.Point(186, 158)
        Me.chkDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(98, 21)
        Me.chkDescuento.TabIndex = 22
        Me.chkDescuento.Text = "Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 381)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(180, 377)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtTotal.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 332)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Descuento"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(180, 328)
        Me.txtDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(132, 22)
        Me.txtDescuento.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 285)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(180, 281)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(132, 22)
        Me.txtSubtotal.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "FACTURA"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 529)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.chkDescuento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label1 As Label
End Class
