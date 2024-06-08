<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Boton = New System.Windows.Forms.Button()
        Me.EntradaDato = New System.Windows.Forms.TextBox()
        Me.NumCentena = New System.Windows.Forms.Label()
        Me.NumDecena = New System.Windows.Forms.Label()
        Me.NumUnidad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(283, 170)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(188, 43)
        Me.Boton.TabIndex = 0
        Me.Boton.Text = "Button1"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'EntradaDato
        '
        Me.EntradaDato.Location = New System.Drawing.Point(329, 112)
        Me.EntradaDato.Name = "EntradaDato"
        Me.EntradaDato.Size = New System.Drawing.Size(100, 20)
        Me.EntradaDato.TabIndex = 1
        '
        'NumCentena
        '
        Me.NumCentena.AutoSize = True
        Me.NumCentena.Location = New System.Drawing.Point(215, 283)
        Me.NumCentena.Name = "NumCentena"
        Me.NumCentena.Size = New System.Drawing.Size(47, 13)
        Me.NumCentena.TabIndex = 2
        Me.NumCentena.Text = "Centena"
        '
        'NumDecena
        '
        Me.NumDecena.AutoSize = True
        Me.NumDecena.Location = New System.Drawing.Point(352, 283)
        Me.NumDecena.Name = "NumDecena"
        Me.NumDecena.Size = New System.Drawing.Size(45, 13)
        Me.NumDecena.TabIndex = 3
        Me.NumDecena.Text = "Decena"
        '
        'NumUnidad
        '
        Me.NumUnidad.AutoSize = True
        Me.NumUnidad.Location = New System.Drawing.Point(491, 283)
        Me.NumUnidad.Name = "NumUnidad"
        Me.NumUnidad.Size = New System.Drawing.Size(41, 13)
        Me.NumUnidad.TabIndex = 4
        Me.NumUnidad.Text = "Unidad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumUnidad)
        Me.Controls.Add(Me.NumDecena)
        Me.Controls.Add(Me.NumCentena)
        Me.Controls.Add(Me.EntradaDato)
        Me.Controls.Add(Me.Boton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Boton As Button
    Friend WithEvents EntradaDato As TextBox
    Friend WithEvents NumCentena As Label
    Friend WithEvents NumDecena As Label
    Friend WithEvents NumUnidad As Label
End Class
