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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboMarca = New System.Windows.Forms.ComboBox()
        Me.ListBoxModelos = New System.Windows.Forms.ListBox()
        Me.PictureBoxCentro = New System.Windows.Forms.PictureBox()
        Me.TextBoxCC = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxCV = New System.Windows.Forms.TextBox()
        Me.TextBoxPromocion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonElec = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHibri = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGaso = New System.Windows.Forms.RadioButton()
        Me.ListBoxPedidos = New System.Windows.Forms.ListBox()
        Me.ButtonRealiza = New System.Windows.Forms.Button()
        Me.ButtonBorrarP = New System.Windows.Forms.Button()
        Me.ButtonVerPedi = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(528, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Caracteristicas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(748, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Propulsión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "pedidos"
        '
        'ComboMarca
        '
        Me.ComboMarca.FormattingEnabled = True
        Me.ComboMarca.Items.AddRange(New Object() {"BMW", "KIA", "RENAULT"})
        Me.ComboMarca.Location = New System.Drawing.Point(21, 57)
        Me.ComboMarca.Name = "ComboMarca"
        Me.ComboMarca.Size = New System.Drawing.Size(106, 21)
        Me.ComboMarca.TabIndex = 5
        '
        'ListBoxModelos
        '
        Me.ListBoxModelos.FormattingEnabled = True
        Me.ListBoxModelos.Location = New System.Drawing.Point(149, 50)
        Me.ListBoxModelos.Name = "ListBoxModelos"
        Me.ListBoxModelos.Size = New System.Drawing.Size(126, 108)
        Me.ListBoxModelos.TabIndex = 6
        '
        'PictureBoxCentro
        '
        Me.PictureBoxCentro.Location = New System.Drawing.Point(281, 50)
        Me.PictureBoxCentro.Name = "PictureBoxCentro"
        Me.PictureBoxCentro.Size = New System.Drawing.Size(152, 101)
        Me.PictureBoxCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCentro.TabIndex = 7
        Me.PictureBoxCentro.TabStop = False
        '
        'TextBoxCC
        '
        Me.TextBoxCC.Location = New System.Drawing.Point(465, 57)
        Me.TextBoxCC.Name = "TextBoxCC"
        Me.TextBoxCC.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxCC.TabIndex = 8
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(465, 104)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxPrecio.TabIndex = 9
        '
        'TextBoxCV
        '
        Me.TextBoxCV.Location = New System.Drawing.Point(578, 58)
        Me.TextBoxCV.Name = "TextBoxCV"
        Me.TextBoxCV.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxCV.TabIndex = 10
        '
        'TextBoxPromocion
        '
        Me.TextBoxPromocion.Location = New System.Drawing.Point(578, 104)
        Me.TextBoxPromocion.Name = "TextBoxPromocion"
        Me.TextBoxPromocion.Size = New System.Drawing.Size(93, 20)
        Me.TextBoxPromocion.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonGaso)
        Me.GroupBox1.Controls.Add(Me.RadioButtonHibri)
        Me.GroupBox1.Controls.Add(Me.RadioButtonElec)
        Me.GroupBox1.Location = New System.Drawing.Point(723, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 121)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButtonElec
        '
        Me.RadioButtonElec.AutoSize = True
        Me.RadioButtonElec.Location = New System.Drawing.Point(29, 26)
        Me.RadioButtonElec.Name = "RadioButtonElec"
        Me.RadioButtonElec.Size = New System.Drawing.Size(66, 17)
        Me.RadioButtonElec.TabIndex = 0
        Me.RadioButtonElec.TabStop = True
        Me.RadioButtonElec.Text = "Electrico"
        Me.RadioButtonElec.UseVisualStyleBackColor = True
        '
        'RadioButtonHibri
        '
        Me.RadioButtonHibri.AutoSize = True
        Me.RadioButtonHibri.Location = New System.Drawing.Point(29, 49)
        Me.RadioButtonHibri.Name = "RadioButtonHibri"
        Me.RadioButtonHibri.Size = New System.Drawing.Size(58, 17)
        Me.RadioButtonHibri.TabIndex = 1
        Me.RadioButtonHibri.TabStop = True
        Me.RadioButtonHibri.Text = "Hibrido"
        Me.RadioButtonHibri.UseVisualStyleBackColor = True
        '
        'RadioButtonGaso
        '
        Me.RadioButtonGaso.AutoSize = True
        Me.RadioButtonGaso.Location = New System.Drawing.Point(29, 75)
        Me.RadioButtonGaso.Name = "RadioButtonGaso"
        Me.RadioButtonGaso.Size = New System.Drawing.Size(66, 17)
        Me.RadioButtonGaso.TabIndex = 2
        Me.RadioButtonGaso.TabStop = True
        Me.RadioButtonGaso.Text = "Gasolina"
        Me.RadioButtonGaso.UseVisualStyleBackColor = True
        '
        'ListBoxPedidos
        '
        Me.ListBoxPedidos.FormattingEnabled = True
        Me.ListBoxPedidos.Location = New System.Drawing.Point(24, 295)
        Me.ListBoxPedidos.Name = "ListBoxPedidos"
        Me.ListBoxPedidos.Size = New System.Drawing.Size(125, 134)
        Me.ListBoxPedidos.TabIndex = 13
        '
        'ButtonRealiza
        '
        Me.ButtonRealiza.Location = New System.Drawing.Point(228, 282)
        Me.ButtonRealiza.Name = "ButtonRealiza"
        Me.ButtonRealiza.Size = New System.Drawing.Size(124, 23)
        Me.ButtonRealiza.TabIndex = 14
        Me.ButtonRealiza.Text = "Realizar pedido"
        Me.ButtonRealiza.UseVisualStyleBackColor = True
        '
        'ButtonBorrarP
        '
        Me.ButtonBorrarP.Location = New System.Drawing.Point(228, 326)
        Me.ButtonBorrarP.Name = "ButtonBorrarP"
        Me.ButtonBorrarP.Size = New System.Drawing.Size(124, 23)
        Me.ButtonBorrarP.TabIndex = 15
        Me.ButtonBorrarP.Text = "Borrar pedido"
        Me.ButtonBorrarP.UseVisualStyleBackColor = True
        '
        'ButtonVerPedi
        '
        Me.ButtonVerPedi.Location = New System.Drawing.Point(227, 370)
        Me.ButtonVerPedi.Name = "ButtonVerPedi"
        Me.ButtonVerPedi.Size = New System.Drawing.Size(125, 23)
        Me.ButtonVerPedi.TabIndex = 16
        Me.ButtonVerPedi.Text = "Ver pedido"
        Me.ButtonVerPedi.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(251, 400)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(76, 38)
        Me.ButtonSalir.TabIndex = 17
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(599, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "CV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(492, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(599, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Promocion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Fotografia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonVerPedi)
        Me.Controls.Add(Me.ButtonBorrarP)
        Me.Controls.Add(Me.ButtonRealiza)
        Me.Controls.Add(Me.ListBoxPedidos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxPromocion)
        Me.Controls.Add(Me.TextBoxCV)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxCC)
        Me.Controls.Add(Me.PictureBoxCentro)
        Me.Controls.Add(Me.ListBoxModelos)
        Me.Controls.Add(Me.ComboMarca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBoxCentro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboMarca As ComboBox
    Friend WithEvents ListBoxModelos As ListBox
    Friend WithEvents PictureBoxCentro As PictureBox
    Friend WithEvents TextBoxCC As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxCV As TextBox
    Friend WithEvents TextBoxPromocion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonGaso As RadioButton
    Friend WithEvents RadioButtonHibri As RadioButton
    Friend WithEvents RadioButtonElec As RadioButton
    Friend WithEvents ListBoxPedidos As ListBox
    Friend WithEvents ButtonRealiza As Button
    Friend WithEvents ButtonBorrarP As Button
    Friend WithEvents ButtonVerPedi As Button
    Private WithEvents ButtonSalir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
