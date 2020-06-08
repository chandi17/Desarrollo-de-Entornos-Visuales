<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio3
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbMedia = New System.Windows.Forms.ListBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAlmacen10 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAlmacen9 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAlmacen8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAlmacen7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlmacen6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAlmacen5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlmacen4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlmacen3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAlmacen2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlmacen1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalcular.Location = New System.Drawing.Point(350, 273)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 28)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNuevo.Location = New System.Drawing.Point(466, 584)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 28)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Location = New System.Drawing.Point(262, 584)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.cmbMedia)
        Me.GroupBox2.Controls.Add(Me.txtMedia)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(110, 323)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(563, 254)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salida"
        '
        'cmbMedia
        '
        Me.cmbMedia.FormattingEnabled = True
        Me.cmbMedia.ItemHeight = 16
        Me.cmbMedia.Location = New System.Drawing.Point(257, 59)
        Me.cmbMedia.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMedia.Name = "cmbMedia"
        Me.cmbMedia.Size = New System.Drawing.Size(171, 164)
        Me.cmbMedia.TabIndex = 5
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(257, 23)
        Me.txtMedia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(132, 22)
        Me.txtMedia.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(133, 30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Media de ventas:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 63)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(199, 34)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Almacenes arriba de la media:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtAlmacen10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen8)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen5)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAlmacen1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(110, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(563, 244)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de almacenes"
        '
        'txtAlmacen10
        '
        Me.txtAlmacen10.Location = New System.Drawing.Point(392, 201)
        Me.txtAlmacen10.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen10.Name = "txtAlmacen10"
        Me.txtAlmacen10.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen10.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 204)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Almacen 10:"
        '
        'txtAlmacen9
        '
        Me.txtAlmacen9.Location = New System.Drawing.Point(392, 164)
        Me.txtAlmacen9.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen9.Name = "txtAlmacen9"
        Me.txtAlmacen9.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen9.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(303, 167)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Almacen 9:"
        '
        'txtAlmacen8
        '
        Me.txtAlmacen8.Location = New System.Drawing.Point(392, 119)
        Me.txtAlmacen8.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen8.Name = "txtAlmacen8"
        Me.txtAlmacen8.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen8.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(303, 123)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Almacen 8:"
        '
        'txtAlmacen7
        '
        Me.txtAlmacen7.Location = New System.Drawing.Point(392, 75)
        Me.txtAlmacen7.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen7.Name = "txtAlmacen7"
        Me.txtAlmacen7.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen7.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(303, 79)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Almacen 7:"
        '
        'txtAlmacen6
        '
        Me.txtAlmacen6.Location = New System.Drawing.Point(392, 31)
        Me.txtAlmacen6.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen6.Name = "txtAlmacen6"
        Me.txtAlmacen6.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen6.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(303, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Almacen 6:"
        '
        'txtAlmacen5
        '
        Me.txtAlmacen5.Location = New System.Drawing.Point(127, 201)
        Me.txtAlmacen5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen5.Name = "txtAlmacen5"
        Me.txtAlmacen5.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Almacen 5:"
        '
        'txtAlmacen4
        '
        Me.txtAlmacen4.Location = New System.Drawing.Point(127, 164)
        Me.txtAlmacen4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen4.Name = "txtAlmacen4"
        Me.txtAlmacen4.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Almacen 4:"
        '
        'txtAlmacen3
        '
        Me.txtAlmacen3.Location = New System.Drawing.Point(127, 119)
        Me.txtAlmacen3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen3.Name = "txtAlmacen3"
        Me.txtAlmacen3.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Almacen 3:"
        '
        'txtAlmacen2
        '
        Me.txtAlmacen2.Location = New System.Drawing.Point(127, 75)
        Me.txtAlmacen2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen2.Name = "txtAlmacen2"
        Me.txtAlmacen2.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Almacen 2:"
        '
        'txtAlmacen1
        '
        Me.txtAlmacen1.Location = New System.Drawing.Point(127, 31)
        Me.txtAlmacen1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen1.Name = "txtAlmacen1"
        Me.txtAlmacen1.Size = New System.Drawing.Size(132, 22)
        Me.txtAlmacen1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almacen 1:"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Ejercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 636)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ejercicio3"
        Me.Text = "Ejercicio3"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbMedia As ListBox
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAlmacen10 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAlmacen9 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAlmacen8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAlmacen7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAlmacen6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAlmacen5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlmacen4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlmacen3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAlmacen2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAlmacen1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
