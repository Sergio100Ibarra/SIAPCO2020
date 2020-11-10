<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.cb_cobradora = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.btn_buscar = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lbl_total = New System.Windows.Forms.Label()
		Me.btn_guardar = New System.Windows.Forms.Button()
		Me.btn_cancelar = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.bnt_listComp = New System.Windows.Forms.Button()
		Me.cb_anio = New System.Windows.Forms.ComboBox()
		Me.lbl_cobradora = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lbl_anio = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.dtgv_lista = New System.Windows.Forms.DataGridView()
		Me.noservicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.enero = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.febrero = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.marzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.abril = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.mayo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.junio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.julio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.agosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.septiembre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.octubre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.noviembre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.diciembre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.dtgv_lista, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cb_cobradora
		'
		Me.cb_cobradora.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cb_cobradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cb_cobradora.Font = New System.Drawing.Font("Arial", 14.25!)
		Me.cb_cobradora.FormattingEnabled = True
		Me.cb_cobradora.Items.AddRange(New Object() {"ALEJANDRA", "CARMELA", "ISABEL"})
		Me.cb_cobradora.Location = New System.Drawing.Point(166, 25)
		Me.cb_cobradora.Name = "cb_cobradora"
		Me.cb_cobradora.Size = New System.Drawing.Size(221, 30)
		Me.cb_cobradora.TabIndex = 16
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(55, 28)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(105, 22)
		Me.Label7.TabIndex = 17
		Me.Label7.Text = "Cobradora:"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(445, 28)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(49, 22)
		Me.Label9.TabIndex = 22
		Me.Label9.Text = "Año:"
		'
		'btn_buscar
		'
		Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_buscar.Location = New System.Drawing.Point(658, 25)
		Me.btn_buscar.Name = "btn_buscar"
		Me.btn_buscar.Size = New System.Drawing.Size(118, 29)
		Me.btn_buscar.TabIndex = 23
		Me.btn_buscar.Text = "Buscar"
		Me.btn_buscar.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(3, 166)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(247, 22)
		Me.Label1.TabIndex = 24
		Me.Label1.Text = "Total de clientes mostrados:"
		'
		'lbl_total
		'
		Me.lbl_total.AutoSize = True
		Me.lbl_total.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_total.Location = New System.Drawing.Point(256, 166)
		Me.lbl_total.Name = "lbl_total"
		Me.lbl_total.Size = New System.Drawing.Size(21, 22)
		Me.lbl_total.TabIndex = 25
		Me.lbl_total.Text = "0"
		'
		'btn_guardar
		'
		Me.btn_guardar.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
		Me.btn_guardar.Location = New System.Drawing.Point(814, 168)
		Me.btn_guardar.Name = "btn_guardar"
		Me.btn_guardar.Size = New System.Drawing.Size(208, 35)
		Me.btn_guardar.TabIndex = 26
		Me.btn_guardar.Text = "Guardar cambios"
		Me.btn_guardar.UseVisualStyleBackColor = False
		'
		'btn_cancelar
		'
		Me.btn_cancelar.BackColor = System.Drawing.Color.RosyBrown
		Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
		Me.btn_cancelar.Location = New System.Drawing.Point(1028, 168)
		Me.btn_cancelar.Name = "btn_cancelar"
		Me.btn_cancelar.Size = New System.Drawing.Size(159, 35)
		Me.btn_cancelar.TabIndex = 27
		Me.btn_cancelar.Text = "Cancelar"
		Me.btn_cancelar.UseVisualStyleBackColor = False
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Controls.Add(Me.bnt_listComp)
		Me.Panel1.Controls.Add(Me.cb_anio)
		Me.Panel1.Controls.Add(Me.lbl_cobradora)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.lbl_anio)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.btn_cancelar)
		Me.Panel1.Controls.Add(Me.btn_buscar)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.Label9)
		Me.Panel1.Controls.Add(Me.lbl_total)
		Me.Panel1.Controls.Add(Me.btn_guardar)
		Me.Panel1.Controls.Add(Me.Label7)
		Me.Panel1.Controls.Add(Me.cb_cobradora)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1199, 209)
		Me.Panel1.TabIndex = 28
		'
		'Button1
		'
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
		Me.Button1.Location = New System.Drawing.Point(674, 171)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(134, 32)
		Me.Button1.TabIndex = 36
		Me.Button1.Text = "Imprimir lista"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'bnt_listComp
		'
		Me.bnt_listComp.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bnt_listComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bnt_listComp.Location = New System.Drawing.Point(994, 12)
		Me.bnt_listComp.Name = "bnt_listComp"
		Me.bnt_listComp.Size = New System.Drawing.Size(193, 38)
		Me.bnt_listComp.TabIndex = 33
		Me.bnt_listComp.Text = "Lista todos los usuarios"
		Me.bnt_listComp.UseVisualStyleBackColor = True
		'
		'cb_anio
		'
		Me.cb_anio.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cb_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cb_anio.Font = New System.Drawing.Font("Arial", 14.25!)
		Me.cb_anio.FormattingEnabled = True
		Me.cb_anio.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
		Me.cb_anio.Location = New System.Drawing.Point(500, 25)
		Me.cb_anio.Name = "cb_anio"
		Me.cb_anio.Size = New System.Drawing.Size(121, 30)
		Me.cb_anio.TabIndex = 32
		'
		'lbl_cobradora
		'
		Me.lbl_cobradora.AutoSize = True
		Me.lbl_cobradora.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_cobradora.Location = New System.Drawing.Point(114, 126)
		Me.lbl_cobradora.Name = "lbl_cobradora"
		Me.lbl_cobradora.Size = New System.Drawing.Size(38, 22)
		Me.lbl_cobradora.TabIndex = 31
		Me.lbl_cobradora.Text = "- - -"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(3, 126)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(105, 22)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "Cobradora:"
		'
		'lbl_anio
		'
		Me.lbl_anio.AutoSize = True
		Me.lbl_anio.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_anio.Location = New System.Drawing.Point(294, 90)
		Me.lbl_anio.Name = "lbl_anio"
		Me.lbl_anio.Size = New System.Drawing.Size(21, 22)
		Me.lbl_anio.TabIndex = 29
		Me.lbl_anio.Text = "0"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 90)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(285, 22)
		Me.Label2.TabIndex = 28
		Me.Label2.Text = "Registro correspondiente al año:"
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.dtgv_lista)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 209)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1199, 252)
		Me.Panel2.TabIndex = 29
		'
		'dtgv_lista
		'
		Me.dtgv_lista.AllowUserToAddRows = False
		Me.dtgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dtgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dtgv_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noservicio, Me.nombre, Me.enero, Me.febrero, Me.marzo, Me.abril, Me.mayo, Me.junio, Me.julio, Me.agosto, Me.septiembre, Me.octubre, Me.noviembre, Me.diciembre})
		DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dtgv_lista.DefaultCellStyle = DataGridViewCellStyle13
		Me.dtgv_lista.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dtgv_lista.Location = New System.Drawing.Point(0, 0)
		Me.dtgv_lista.Name = "dtgv_lista"
		Me.dtgv_lista.RowHeadersVisible = False
		Me.dtgv_lista.RowTemplate.Height = 35
		Me.dtgv_lista.Size = New System.Drawing.Size(1199, 252)
		Me.dtgv_lista.TabIndex = 16
		'
		'noservicio
		'
		Me.noservicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.noservicio.FillWeight = 29.52284!
		Me.noservicio.Frozen = True
		Me.noservicio.HeaderText = "No. Servicio"
		Me.noservicio.Name = "noservicio"
		Me.noservicio.ReadOnly = True
		Me.noservicio.Width = 60
		'
		'nombre
		'
		Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.nombre.FillWeight = 98.47716!
		Me.nombre.Frozen = True
		Me.nombre.HeaderText = "Nombre"
		Me.nombre.Name = "nombre"
		Me.nombre.ReadOnly = True
		Me.nombre.Width = 260
		'
		'enero
		'
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.Format = "N2"
		DataGridViewCellStyle1.NullValue = "0"
		Me.enero.DefaultCellStyle = DataGridViewCellStyle1
		Me.enero.HeaderText = "Enero"
		Me.enero.Name = "enero"
		'
		'febrero
		'
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.Format = "N2"
		DataGridViewCellStyle2.NullValue = "0"
		Me.febrero.DefaultCellStyle = DataGridViewCellStyle2
		Me.febrero.HeaderText = "Febrero"
		Me.febrero.Name = "febrero"
		'
		'marzo
		'
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle3.Format = "N2"
		DataGridViewCellStyle3.NullValue = "0"
		Me.marzo.DefaultCellStyle = DataGridViewCellStyle3
		Me.marzo.HeaderText = "Marzo"
		Me.marzo.Name = "marzo"
		'
		'abril
		'
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle4.Format = "N2"
		DataGridViewCellStyle4.NullValue = "0"
		Me.abril.DefaultCellStyle = DataGridViewCellStyle4
		Me.abril.HeaderText = "Abril"
		Me.abril.Name = "abril"
		'
		'mayo
		'
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle5.Format = "N2"
		DataGridViewCellStyle5.NullValue = "0"
		Me.mayo.DefaultCellStyle = DataGridViewCellStyle5
		Me.mayo.HeaderText = "Mayo"
		Me.mayo.Name = "mayo"
		'
		'junio
		'
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle6.Format = "N2"
		DataGridViewCellStyle6.NullValue = "0"
		Me.junio.DefaultCellStyle = DataGridViewCellStyle6
		Me.junio.HeaderText = "Junio"
		Me.junio.Name = "junio"
		'
		'julio
		'
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle7.Format = "N2"
		DataGridViewCellStyle7.NullValue = "0"
		Me.julio.DefaultCellStyle = DataGridViewCellStyle7
		Me.julio.HeaderText = "Julio"
		Me.julio.Name = "julio"
		'
		'agosto
		'
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle8.Format = "N2"
		DataGridViewCellStyle8.NullValue = "0"
		Me.agosto.DefaultCellStyle = DataGridViewCellStyle8
		Me.agosto.HeaderText = "Agosto"
		Me.agosto.Name = "agosto"
		'
		'septiembre
		'
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle9.Format = "N2"
		DataGridViewCellStyle9.NullValue = "0"
		Me.septiembre.DefaultCellStyle = DataGridViewCellStyle9
		Me.septiembre.HeaderText = "Septiembre"
		Me.septiembre.Name = "septiembre"
		'
		'octubre
		'
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle10.Format = "N2"
		DataGridViewCellStyle10.NullValue = "0"
		Me.octubre.DefaultCellStyle = DataGridViewCellStyle10
		Me.octubre.HeaderText = "Octubre"
		Me.octubre.Name = "octubre"
		'
		'noviembre
		'
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle11.Format = "N2"
		DataGridViewCellStyle11.NullValue = "0"
		Me.noviembre.DefaultCellStyle = DataGridViewCellStyle11
		Me.noviembre.HeaderText = "Noviembre"
		Me.noviembre.Name = "noviembre"
		'
		'diciembre
		'
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle12.Format = "N2"
		DataGridViewCellStyle12.NullValue = "0"
		Me.diciembre.DefaultCellStyle = DataGridViewCellStyle12
		Me.diciembre.HeaderText = "Diciembre"
		Me.diciembre.Name = "diciembre"
		'
		'Form3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1199, 461)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "Form3"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form3"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		CType(Me.dtgv_lista, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents cb_cobradora As ComboBox
	Friend WithEvents Label7 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents btn_buscar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents lbl_total As Label
	Friend WithEvents btn_guardar As Button
	Friend WithEvents btn_cancelar As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents dtgv_lista As DataGridView
	Friend WithEvents lbl_anio As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents noservicio As DataGridViewTextBoxColumn
	Friend WithEvents nombre As DataGridViewTextBoxColumn
	Friend WithEvents enero As DataGridViewTextBoxColumn
	Friend WithEvents febrero As DataGridViewTextBoxColumn
	Friend WithEvents marzo As DataGridViewTextBoxColumn
	Friend WithEvents abril As DataGridViewTextBoxColumn
	Friend WithEvents mayo As DataGridViewTextBoxColumn
	Friend WithEvents junio As DataGridViewTextBoxColumn
	Friend WithEvents julio As DataGridViewTextBoxColumn
	Friend WithEvents agosto As DataGridViewTextBoxColumn
	Friend WithEvents septiembre As DataGridViewTextBoxColumn
	Friend WithEvents octubre As DataGridViewTextBoxColumn
	Friend WithEvents noviembre As DataGridViewTextBoxColumn
	Friend WithEvents diciembre As DataGridViewTextBoxColumn
	Friend WithEvents Label3 As Label
	Friend WithEvents lbl_cobradora As Label
	Friend WithEvents cb_anio As ComboBox
	Friend WithEvents bnt_listComp As Button
	Friend WithEvents Button1 As Button
End Class
