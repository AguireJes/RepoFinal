<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btncomenzar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownEdad = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxSexo = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMuj = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHomb = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDesarrolladores = New System.Windows.Forms.Button()
        Me.ComboBoxTratamientos = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerSalida = New System.Windows.Forms.DateTimePicker()
        CType(Me.NumericUpDownEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSexo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncomenzar
        '
        Me.btncomenzar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btncomenzar.Font = New System.Drawing.Font("Ebrima", 8.25!)
        Me.btncomenzar.Location = New System.Drawing.Point(155, 300)
        Me.btncomenzar.Name = "btncomenzar"
        Me.btncomenzar.Size = New System.Drawing.Size(75, 23)
        Me.btncomenzar.TabIndex = 4
        Me.btncomenzar.Text = "Calcular"
        Me.btncomenzar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "1. Inserte Su Nombre "
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxNombre.Location = New System.Drawing.Point(6, 35)
        Me.TextBoxNombre.MaxLength = 20
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(145, 20)
        Me.TextBoxNombre.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "2. Escoga Su Edad"
        '
        'NumericUpDownEdad
        '
        Me.NumericUpDownEdad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.NumericUpDownEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDownEdad.Location = New System.Drawing.Point(6, 104)
        Me.NumericUpDownEdad.Name = "NumericUpDownEdad"
        Me.NumericUpDownEdad.Size = New System.Drawing.Size(84, 20)
        Me.NumericUpDownEdad.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "3. Fecha De Internacion"
        '
        'DateTimePickerEntrada
        '
        Me.DateTimePickerEntrada.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.DateTimePickerEntrada.Location = New System.Drawing.Point(6, 35)
        Me.DateTimePickerEntrada.Name = "DateTimePickerEntrada"
        Me.DateTimePickerEntrada.Size = New System.Drawing.Size(145, 20)
        Me.DateTimePickerEntrada.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "5. Requerimos de Su Telefono"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(9, 143)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(142, 20)
        Me.MaskedTextBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "7. Requerimos Su Sexo"
        '
        'GroupBoxSexo
        '
        Me.GroupBoxSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GroupBoxSexo.Controls.Add(Me.RadioButtonMuj)
        Me.GroupBoxSexo.Controls.Add(Me.RadioButtonHomb)
        Me.GroupBoxSexo.Location = New System.Drawing.Point(245, 24)
        Me.GroupBoxSexo.Name = "GroupBoxSexo"
        Me.GroupBoxSexo.Size = New System.Drawing.Size(104, 64)
        Me.GroupBoxSexo.TabIndex = 14
        Me.GroupBoxSexo.TabStop = False
        Me.GroupBoxSexo.Text = "Eliga Su Sexo"
        '
        'RadioButtonMuj
        '
        Me.RadioButtonMuj.AutoSize = True
        Me.RadioButtonMuj.Location = New System.Drawing.Point(7, 44)
        Me.RadioButtonMuj.Name = "RadioButtonMuj"
        Me.RadioButtonMuj.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonMuj.TabIndex = 1
        Me.RadioButtonMuj.TabStop = True
        Me.RadioButtonMuj.Text = "Mujer"
        Me.RadioButtonMuj.UseVisualStyleBackColor = True
        '
        'RadioButtonHomb
        '
        Me.RadioButtonHomb.AutoSize = True
        Me.RadioButtonHomb.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonHomb.Name = "RadioButtonHomb"
        Me.RadioButtonHomb.Size = New System.Drawing.Size(62, 17)
        Me.RadioButtonHomb.TabIndex = 0
        Me.RadioButtonHomb.TabStop = True
        Me.RadioButtonHomb.Text = "Hombre"
        Me.RadioButtonHomb.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBoxNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.NumericUpDownEdad)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 153)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DateTimePickerSalida)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DateTimePickerEntrada)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.MaskedTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(210, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 174)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.ComboBoxTratamientos)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.GroupBoxSexo)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(12, 181)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 113)
        Me.Panel3.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnDesarrolladores)
        Me.Panel4.Location = New System.Drawing.Point(9, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 42)
        Me.Panel4.TabIndex = 17
        '
        'btnDesarrolladores
        '
        Me.btnDesarrolladores.Location = New System.Drawing.Point(3, 9)
        Me.btnDesarrolladores.Name = "btnDesarrolladores"
        Me.btnDesarrolladores.Size = New System.Drawing.Size(194, 24)
        Me.btnDesarrolladores.TabIndex = 0
        Me.btnDesarrolladores.Text = "Acerca De Los Desarrolladores"
        Me.btnDesarrolladores.UseVisualStyleBackColor = True
        '
        'ComboBoxTratamientos
        '
        Me.ComboBoxTratamientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ComboBoxTratamientos.FormattingEnabled = True
        Me.ComboBoxTratamientos.Items.AddRange(New Object() {"Tratamiento A", "Tratamiento B", "Tratamiento C"})
        Me.ComboBoxTratamientos.Location = New System.Drawing.Point(9, 24)
        Me.ComboBoxTratamientos.Name = "ComboBoxTratamientos"
        Me.ComboBoxTratamientos.Size = New System.Drawing.Size(198, 21)
        Me.ComboBoxTratamientos.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "6. Escoga El Tipo De Tratamiento Deseado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "4. Fecha de Salida"
        '
        'DateTimePickerSalida
        '
        Me.DateTimePickerSalida.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.DateTimePickerSalida.Location = New System.Drawing.Point(9, 89)
        Me.DateTimePickerSalida.Name = "DateTimePickerSalida"
        Me.DateTimePickerSalida.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePickerSalida.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 335)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncomenzar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Inicio"
        CType(Me.NumericUpDownEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSexo.ResumeLayout(False)
        Me.GroupBoxSexo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncomenzar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDownEdad As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerEntrada As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBoxSexo As GroupBox
    Friend WithEvents RadioButtonMuj As RadioButton
    Friend WithEvents RadioButtonHomb As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxTratamientos As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnDesarrolladores As Button
    Friend WithEvents DateTimePickerSalida As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
