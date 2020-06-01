<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsoCheckBox
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkSuma = New System.Windows.Forms.CheckBox()
        Me.chkResta = New System.Windows.Forms.CheckBox()
        Me.chkMulti = New System.Windows.Forms.CheckBox()
        Me.chkDivi = New System.Windows.Forms.CheckBox()
        Me.chkRaiz = New System.Windows.Forms.CheckBox()
        Me.chkPotencia = New System.Windows.Forms.CheckBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valor 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Respuesta:"
        '
        'chkSuma
        '
        Me.chkSuma.AutoSize = True
        Me.chkSuma.Location = New System.Drawing.Point(469, 80)
        Me.chkSuma.Name = "chkSuma"
        Me.chkSuma.Size = New System.Drawing.Size(66, 21)
        Me.chkSuma.TabIndex = 2
        Me.chkSuma.Text = "Suma"
        Me.chkSuma.UseVisualStyleBackColor = True
        '
        'chkResta
        '
        Me.chkResta.AutoSize = True
        Me.chkResta.Location = New System.Drawing.Point(469, 123)
        Me.chkResta.Name = "chkResta"
        Me.chkResta.Size = New System.Drawing.Size(67, 21)
        Me.chkResta.TabIndex = 3
        Me.chkResta.Text = "Resta"
        Me.chkResta.UseVisualStyleBackColor = True
        '
        'chkMulti
        '
        Me.chkMulti.AutoSize = True
        Me.chkMulti.Location = New System.Drawing.Point(469, 171)
        Me.chkMulti.Name = "chkMulti"
        Me.chkMulti.Size = New System.Drawing.Size(114, 21)
        Me.chkMulti.TabIndex = 4
        Me.chkMulti.Text = "Multiplicación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkMulti.UseVisualStyleBackColor = True
        '
        'chkDivi
        '
        Me.chkDivi.AutoSize = True
        Me.chkDivi.Location = New System.Drawing.Point(469, 214)
        Me.chkDivi.Name = "chkDivi"
        Me.chkDivi.Size = New System.Drawing.Size(79, 21)
        Me.chkDivi.TabIndex = 5
        Me.chkDivi.Text = "División"
        Me.chkDivi.UseVisualStyleBackColor = True
        '
        'chkRaiz
        '
        Me.chkRaiz.AutoSize = True
        Me.chkRaiz.Location = New System.Drawing.Point(469, 257)
        Me.chkRaiz.Name = "chkRaiz"
        Me.chkRaiz.Size = New System.Drawing.Size(58, 21)
        Me.chkRaiz.TabIndex = 6
        Me.chkRaiz.Text = "Raiz"
        Me.chkRaiz.UseVisualStyleBackColor = True
        '
        'chkPotencia
        '
        Me.chkPotencia.AutoSize = True
        Me.chkPotencia.Location = New System.Drawing.Point(469, 300)
        Me.chkPotencia.Name = "chkPotencia"
        Me.chkPotencia.Size = New System.Drawing.Size(85, 21)
        Me.chkPotencia.TabIndex = 7
        Me.chkPotencia.Text = "Potencia"
        Me.chkPotencia.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(67, 460)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(256, 460)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(447, 460)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(150, 79)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero1.TabIndex = 0
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(150, 136)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero2.TabIndex = 1
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Enabled = False
        Me.txtRespuesta.Location = New System.Drawing.Point(150, 278)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(100, 22)
        Me.txtRespuesta.TabIndex = 3
        '
        'UsoCheckBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 583)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.chkPotencia)
        Me.Controls.Add(Me.chkRaiz)
        Me.Controls.Add(Me.chkDivi)
        Me.Controls.Add(Me.chkMulti)
        Me.Controls.Add(Me.chkResta)
        Me.Controls.Add(Me.chkSuma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UsoCheckBox"
        Me.Text = "Operaciones Aritmeticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkSuma As CheckBox
    Friend WithEvents chkResta As CheckBox
    Friend WithEvents chkMulti As CheckBox
    Friend WithEvents chkDivi As CheckBox
    Friend WithEvents chkRaiz As CheckBox
    Friend WithEvents chkPotencia As CheckBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents txtRespuesta As TextBox
End Class
