<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validacion
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
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(116, 105)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(100, 28)
        Me.btnValidar.TabIndex = 5
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(115, 63)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(99, 22)
        Me.txtNumero.TabIndex = 4
        '
        'Validacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 294)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "Validacion"
        Me.Text = "Validacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnValidar As Button
    Friend WithEvents txtNumero As TextBox
End Class
