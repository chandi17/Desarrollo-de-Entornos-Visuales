<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorProvide
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
        Me.components = New System.ComponentModel.Container()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(171, 250)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(233, 121)
        Me.txtDescripcion.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 252)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Descripcion"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(171, 197)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(132, 22)
        Me.txtCantidad.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 200)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(171, 129)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(132, 22)
        Me.txtPrecio.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Precio"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(171, 69)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(221, 22)
        Me.txtProducto.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Producto"
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(227, 409)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(100, 28)
        Me.btnValidar.TabIndex = 9
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'ErrorProvide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 494)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnValidar)
        Me.Name = "ErrorProvide"
        Me.Text = "ErrorProvide"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnValidar As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents errorValidacion As ErrorProvider
End Class
