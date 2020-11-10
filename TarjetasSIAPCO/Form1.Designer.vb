<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.txt_nombre = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txt_ns = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txt_calle = New System.Windows.Forms.TextBox()
		Me.btn_save = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txt_numero = New System.Windows.Forms.TextBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txt_anio = New System.Windows.Forms.TextBox()
		Me.cb_mensual = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.cb_cobradora = New System.Windows.Forms.ComboBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.picture = New System.Windows.Forms.PictureBox()
		Me.btn_qr = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lbl_total = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.dtgv_buscar = New System.Windows.Forms.DataGridView()
		Me.noservicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.cobradora = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.mensual = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txt_buscar = New System.Windows.Forms.TextBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btn_ElimCliente = New System.Windows.Forms.Button()
		Me.btn_ActCliente = New System.Windows.Forms.Button()
		Me.btn_salidas = New System.Windows.Forms.Button()
		Me.btn_entradas = New System.Windows.Forms.Button()
		Me.btn_rgeneral = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.dtgv_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'txt_nombre
		'
		Me.txt_nombre.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_nombre.Location = New System.Drawing.Point(212, 13)
		Me.txt_nombre.Name = "txt_nombre"
		Me.txt_nombre.Size = New System.Drawing.Size(352, 29)
		Me.txt_nombre.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(39, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(167, 22)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Nombre completo:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(89, 65)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(117, 22)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "No. Servicio:"
		'
		'txt_ns
		'
		Me.txt_ns.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_ns.Location = New System.Drawing.Point(212, 62)
		Me.txt_ns.Name = "txt_ns"
		Me.txt_ns.Size = New System.Drawing.Size(121, 29)
		Me.txt_ns.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(148, 113)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(58, 22)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Calle:"
		'
		'txt_calle
		'
		Me.txt_calle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_calle.Location = New System.Drawing.Point(212, 110)
		Me.txt_calle.Name = "txt_calle"
		Me.txt_calle.Size = New System.Drawing.Size(352, 29)
		Me.txt_calle.TabIndex = 7
		'
		'btn_save
		'
		Me.btn_save.Enabled = False
		Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_save.Location = New System.Drawing.Point(339, 297)
		Me.btn_save.Name = "btn_save"
		Me.btn_save.Size = New System.Drawing.Size(174, 43)
		Me.btn_save.TabIndex = 11
		Me.btn_save.Text = "Guardar / imprimir"
		Me.btn_save.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(124, 162)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(82, 22)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "Número:"
		'
		'txt_numero
		'
		Me.txt_numero.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_numero.Location = New System.Drawing.Point(212, 159)
		Me.txt_numero.Name = "txt_numero"
		Me.txt_numero.Size = New System.Drawing.Size(121, 29)
		Me.txt_numero.TabIndex = 8
		'
		'Panel1
		'
		Me.Panel1.AutoSize = True
		Me.Panel1.Controls.Add(Me.Label9)
		Me.Panel1.Controls.Add(Me.txt_anio)
		Me.Panel1.Controls.Add(Me.cb_mensual)
		Me.Panel1.Controls.Add(Me.Label8)
		Me.Panel1.Controls.Add(Me.cb_cobradora)
		Me.Panel1.Controls.Add(Me.Label7)
		Me.Panel1.Controls.Add(Me.picture)
		Me.Panel1.Controls.Add(Me.btn_qr)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.txt_nombre)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.txt_ns)
		Me.Panel1.Controls.Add(Me.txt_numero)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.btn_save)
		Me.Panel1.Controls.Add(Me.txt_calle)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(975, 386)
		Me.Panel1.TabIndex = 15
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(605, 16)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(49, 22)
		Me.Label9.TabIndex = 20
		Me.Label9.Text = "Año:"
		'
		'txt_anio
		'
		Me.txt_anio.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_anio.Location = New System.Drawing.Point(660, 13)
		Me.txt_anio.Name = "txt_anio"
		Me.txt_anio.Size = New System.Drawing.Size(121, 29)
		Me.txt_anio.TabIndex = 1
		'
		'cb_mensual
		'
		Me.cb_mensual.Font = New System.Drawing.Font("Arial", 14.25!)
		Me.cb_mensual.FormattingEnabled = True
		Me.cb_mensual.Items.AddRange(New Object() {"$80.00", "$160.00"})
		Me.cb_mensual.Location = New System.Drawing.Point(212, 250)
		Me.cb_mensual.Name = "cb_mensual"
		Me.cb_mensual.Size = New System.Drawing.Size(221, 30)
		Me.cb_mensual.TabIndex = 10
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(85, 253)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(121, 22)
		Me.Label8.TabIndex = 18
		Me.Label8.Text = "Mensualidad:"
		'
		'cb_cobradora
		'
		Me.cb_cobradora.Font = New System.Drawing.Font("Arial", 14.25!)
		Me.cb_cobradora.FormattingEnabled = True
		Me.cb_cobradora.Items.AddRange(New Object() {"ALEJANDRA", "CARMELA", "ISABEL"})
		Me.cb_cobradora.Location = New System.Drawing.Point(212, 204)
		Me.cb_cobradora.Name = "cb_cobradora"
		Me.cb_cobradora.Size = New System.Drawing.Size(221, 30)
		Me.cb_cobradora.TabIndex = 9
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(101, 207)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(105, 22)
		Me.Label7.TabIndex = 16
		Me.Label7.Text = "Cobradora:"
		'
		'picture
		'
		Me.picture.Location = New System.Drawing.Point(618, 76)
		Me.picture.Name = "picture"
		Me.picture.Size = New System.Drawing.Size(248, 214)
		Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.picture.TabIndex = 14
		Me.picture.TabStop = False
		'
		'btn_qr
		'
		Me.btn_qr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_qr.Location = New System.Drawing.Point(339, 61)
		Me.btn_qr.Name = "btn_qr"
		Me.btn_qr.Size = New System.Drawing.Size(107, 32)
		Me.btn_qr.TabIndex = 3
		Me.btn_qr.Text = "Generar QR"
		Me.btn_qr.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Panel2.Controls.Add(Me.Label10)
		Me.Panel2.Controls.Add(Me.Label6)
		Me.Panel2.Controls.Add(Me.lbl_total)
		Me.Panel2.Controls.Add(Me.Label5)
		Me.Panel2.Controls.Add(Me.dtgv_buscar)
		Me.Panel2.Controls.Add(Me.txt_buscar)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel2.Location = New System.Drawing.Point(0, 389)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1294, 346)
		Me.Panel2.TabIndex = 16
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(1045, 75)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(150, 18)
		Me.Label10.TabIndex = 18
		Me.Label10.Text = "Total de usuarios:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(10, 10)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(368, 18)
		Me.Label6.TabIndex = 17
		Me.Label6.Text = "Buscar por nombre o por nùmero de servicio:"
		'
		'lbl_total
		'
		Me.lbl_total.AutoSize = True
		Me.lbl_total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_total.Location = New System.Drawing.Point(1221, 75)
		Me.lbl_total.Name = "lbl_total"
		Me.lbl_total.Size = New System.Drawing.Size(18, 18)
		Me.lbl_total.TabIndex = 16
		Me.lbl_total.Text = "0"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(563, 363)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(153, 18)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "Total de registros:"
		'
		'dtgv_buscar
		'
		Me.dtgv_buscar.AllowUserToAddRows = False
		Me.dtgv_buscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dtgv_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dtgv_buscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noservicio, Me.nombre, Me.direccion, Me.cobradora, Me.mensual})
		Me.dtgv_buscar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.dtgv_buscar.Location = New System.Drawing.Point(0, 96)
		Me.dtgv_buscar.Name = "dtgv_buscar"
		Me.dtgv_buscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dtgv_buscar.Size = New System.Drawing.Size(1294, 250)
		Me.dtgv_buscar.TabIndex = 14
		'
		'noservicio
		'
		Me.noservicio.FillWeight = 29.52284!
		Me.noservicio.HeaderText = "No. Servicio"
		Me.noservicio.Name = "noservicio"
		Me.noservicio.ReadOnly = True
		'
		'nombre
		'
		Me.nombre.FillWeight = 98.47716!
		Me.nombre.HeaderText = "Nombre"
		Me.nombre.Name = "nombre"
		Me.nombre.ReadOnly = True
		'
		'direccion
		'
		Me.direccion.HeaderText = "Direcciòn"
		Me.direccion.Name = "direccion"
		Me.direccion.ReadOnly = True
		'
		'cobradora
		'
		Me.cobradora.HeaderText = "Cobradora"
		Me.cobradora.Name = "cobradora"
		Me.cobradora.ReadOnly = True
		'
		'mensual
		'
		Me.mensual.HeaderText = "Mensualidad"
		Me.mensual.Name = "mensual"
		Me.mensual.ReadOnly = True
		'
		'txt_buscar
		'
		Me.txt_buscar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_buscar.Location = New System.Drawing.Point(13, 31)
		Me.txt_buscar.Name = "txt_buscar"
		Me.txt_buscar.Size = New System.Drawing.Size(876, 29)
		Me.txt_buscar.TabIndex = 12
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.btn_ElimCliente)
		Me.Panel3.Controls.Add(Me.btn_ActCliente)
		Me.Panel3.Controls.Add(Me.btn_salidas)
		Me.Panel3.Controls.Add(Me.btn_entradas)
		Me.Panel3.Controls.Add(Me.btn_rgeneral)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel3.Location = New System.Drawing.Point(981, 0)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(313, 389)
		Me.Panel3.TabIndex = 17
		'
		'btn_ElimCliente
		'
		Me.btn_ElimCliente.BackColor = System.Drawing.Color.RosyBrown
		Me.btn_ElimCliente.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_ElimCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ElimCliente.Location = New System.Drawing.Point(3, 187)
		Me.btn_ElimCliente.Name = "btn_ElimCliente"
		Me.btn_ElimCliente.Size = New System.Drawing.Size(313, 46)
		Me.btn_ElimCliente.TabIndex = 19
		Me.btn_ElimCliente.Text = "Eliminar cliente"
		Me.btn_ElimCliente.UseVisualStyleBackColor = False
		'
		'btn_ActCliente
		'
		Me.btn_ActCliente.BackColor = System.Drawing.Color.DarkSalmon
		Me.btn_ActCliente.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_ActCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_ActCliente.Location = New System.Drawing.Point(3, 141)
		Me.btn_ActCliente.Name = "btn_ActCliente"
		Me.btn_ActCliente.Size = New System.Drawing.Size(313, 46)
		Me.btn_ActCliente.TabIndex = 18
		Me.btn_ActCliente.Text = "Actualizar cliente"
		Me.btn_ActCliente.UseVisualStyleBackColor = False
		'
		'btn_salidas
		'
		Me.btn_salidas.BackColor = System.Drawing.Color.Bisque
		Me.btn_salidas.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_salidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_salidas.Location = New System.Drawing.Point(3, 95)
		Me.btn_salidas.Name = "btn_salidas"
		Me.btn_salidas.Size = New System.Drawing.Size(313, 46)
		Me.btn_salidas.TabIndex = 17
		Me.btn_salidas.Text = "Salidas"
		Me.btn_salidas.UseVisualStyleBackColor = False
		'
		'btn_entradas
		'
		Me.btn_entradas.BackColor = System.Drawing.Color.DarkSeaGreen
		Me.btn_entradas.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_entradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_entradas.Location = New System.Drawing.Point(3, 49)
		Me.btn_entradas.Name = "btn_entradas"
		Me.btn_entradas.Size = New System.Drawing.Size(313, 46)
		Me.btn_entradas.TabIndex = 16
		Me.btn_entradas.Text = "Entradas por cobradora"
		Me.btn_entradas.UseVisualStyleBackColor = False
		'
		'btn_rgeneral
		'
		Me.btn_rgeneral.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btn_rgeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btn_rgeneral.Location = New System.Drawing.Point(3, 3)
		Me.btn_rgeneral.Name = "btn_rgeneral"
		Me.btn_rgeneral.Size = New System.Drawing.Size(313, 46)
		Me.btn_rgeneral.TabIndex = 15
		Me.btn_rgeneral.Text = "Reporte general"
		Me.btn_rgeneral.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(1294, 735)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SIAPCO"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.dtgv_buscar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txt_nombre As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txt_ns As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txt_calle As TextBox
	Friend WithEvents btn_save As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents txt_numero As TextBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents dtgv_buscar As DataGridView
	Friend WithEvents txt_buscar As TextBox
	Friend WithEvents btn_qr As Button
	Friend WithEvents lbl_total As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents picture As PictureBox
	Friend WithEvents cb_cobradora As ComboBox
	Friend WithEvents Label7 As Label
	Friend WithEvents cb_mensual As ComboBox
	Friend WithEvents Label8 As Label
	Friend WithEvents noservicio As DataGridViewTextBoxColumn
	Friend WithEvents nombre As DataGridViewTextBoxColumn
	Friend WithEvents direccion As DataGridViewTextBoxColumn
	Friend WithEvents cobradora As DataGridViewTextBoxColumn
	Friend WithEvents mensual As DataGridViewTextBoxColumn
	Friend WithEvents btn_salidas As Button
	Friend WithEvents btn_entradas As Button
	Friend WithEvents btn_rgeneral As Button
	Friend WithEvents btn_ElimCliente As Button
	Friend WithEvents btn_ActCliente As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents txt_anio As TextBox
	Friend WithEvents Label10 As Label
	Protected WithEvents Panel3 As Panel
End Class
