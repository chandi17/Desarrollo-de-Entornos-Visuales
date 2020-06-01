<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SumaDosNumeros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valor 2:"
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(144, 66)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero1.TabIndex = 1
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(144, 105)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero2.TabIndex = 1
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Enabled = False
        Me.txtRespuesta.Location = New System.Drawing.Point(144, 271)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(100, 22)
        Me.txtRespuesta.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Respuesta:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(58, 203)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(224, 203)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'SumaDosNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 386)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SumaDosNumeros"
        Me.Text = "Suma de dos numeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
End Class
