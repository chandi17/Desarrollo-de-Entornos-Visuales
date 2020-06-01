<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EjemplocicloForVentanaEme
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
        Me.cmbEquipos = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbEquipos
        '
        Me.cmbEquipos.FormattingEnabled = True
        Me.cmbEquipos.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbEquipos.Location = New System.Drawing.Point(93, 141)
        Me.cmbEquipos.Name = "cmbEquipos"
        Me.cmbEquipos.Size = New System.Drawing.Size(289, 24)
        Me.cmbEquipos.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Validar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbEquipos)
        Me.Name = "Validar"
        Me.Text = "Validar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbEquipos As ComboBox
    Friend WithEvents Button1 As Button
End Class
