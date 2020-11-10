Imports System.Data.SQLite
Imports System.IO
Imports QRCoder

Public Class Form1
	Const cadena_conexion As String = "Data Source=TarjetasBD.db; Version=3;"
	Sub crearbd()
		Try
			Using oobjCon As New SQLiteConnection(cadena_conexion)
				oobjCon.Open()
				Using oobjComand As New SQLiteCommand("CREATE TABLE IF NOT EXISTS clientes (no_servicio INTEGER PRIMARY KEY, nombre TEXT, direccion TEXT, cobradora TEXT, mensualidad TEXT)", oobjCon)
					oobjComand.ExecuteNonQuery()
				End Using
				Using oobjComand As New SQLiteCommand("CREATE TABLE IF NOT EXISTS mensualidades (fk_no_servicio INTEGER REFERENCES clientes (no_servicio) ON DELETE CASCADE ON UPDATE CASCADE, anio TEXT, enero TEXT, febrero TEXT, marzo TEXT, abril TEXT, mayo TEXT, junio TEXT, julio TEXT, agosto TEXT, septiembre TEXT, octubre TEXT, noviembre TEXT, diciembre TEXT)", oobjCon)
					oobjComand.ExecuteNonQuery()
				End Using
			End Using

		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		crearbd()
		nuevo_reg()
		actualizar_tabla()
	End Sub
	Sub nuevo_reg()
		Try
			Using objCon As New SQLiteConnection(cadena_conexion)
				objCon.Open()
				Using objCommand As New SQLiteCommand("select max(no_servicio) from clientes", objCon)
					Using objReader As SQLiteDataReader = objCommand.ExecuteReader
						If (objReader.Read()) Then
							txt_ns.Text = objReader("max(no_servicio)") + 1
						End If
					End Using
				End Using
			End Using
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
		txt_nombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_nombre.Text)
		txt_nombre.SelectionStart = txt_nombre.Text.Length
	End Sub
	'AQUI COMIENZA A REALIZAR EL PDF
	Dim dt As New DataTable
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_save.Click
		If txt_nombre.Text <> "" And txt_ns.Text <> "" And txt_calle.Text <> "" And txt_numero.Text <> "" And txt_anio.Text <> "" Then

			dt.Columns.Clear() 'se limpian las columnas
			dt.Rows.Clear() 'se limpian las filas
			dt.Columns.Add("no_servicio")
			dt.Columns.Add("nombre")
			dt.Columns.Add("direccion")
			dt.Columns.Add("cobradora")
			dt.Columns.Add("mensual")


			Dim ns = txt_ns.Text
			Dim nombre = txt_nombre.Text
			Dim calle = txt_calle.Text
			Dim numero = txt_numero.Text
			Dim direccion = calle & " #" & numero & ", El Refugio (El Conejo), C.P.34340 Durango, Dgo."
			Dim cobradora = cb_cobradora.Text
			Dim mensual = cb_mensual.Text
			Dim anio = txt_anio.Text


			Dim ren As DataRow = dt.NewRow()
			ren("no_servicio") = ns
			ren("nombre") = nombre
			ren("direccion") = direccion
			ren("cobradora") = cobradora
			ren("mensual") = mensual
			dt.Rows.Add(ren)


			Try
				Using objCon As New SQLiteConnection(cadena_conexion)
					objCon.Open()
					Using objCommand As New SQLiteCommand("INSERT INTO clientes (no_servicio, nombre, direccion,cobradora,mensualidad)values('" & ns & "','" & nombre & "', '" & direccion & "', '" & cobradora & "', '" & mensual & "')", objCon)
						objCommand.ExecuteNonQuery()
					End Using
					Using objCommand As New SQLiteCommand("INSERT INTO mensualidades (fk_no_servicio, anio, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre)values('" & ns & "','" & anio & "','0','0','0','0','0','0','0','0','0','0','0','0')", objCon)
						objCommand.ExecuteNonQuery()
					End Using
				End Using

				Try
					picture.Image.Save("QR_TEMPORAL.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
				Catch ex As Exception
					MsgBox(ex.Message)
				End Try



				Dim ruta = "C:\Users\sergi\source\repos\TarjetasSIAPCO\TarjetasSIAPCO\bin\Debug\QR_TEMPORAL.jpeg"
				Dim ruta2 = "C:\Users\sergi\source\repos\TarjetasSIAPCO\TarjetasSIAPCO\bin\Debug\img\QR_TEMPORAL.jpeg"
				Dim imagen As New Bitmap(New Bitmap(ruta), 854, 816)
				imagen.Save(ruta2, System.Drawing.Imaging.ImageFormat.Jpeg)



				txt_ns.Text = ""
				txt_nombre.Text = ""
				txt_calle.Text = ""
				txt_numero.Text = ""
				cb_mensual.Text = ""
				cb_cobradora.Text = ""
				btn_save.Enabled = False
				picture.Image.Dispose()
				picture.Image = Nothing
				nuevo_reg()
				actualizar_tabla()


				Dim Cr As New CR_tarjeta

				Cr.SetDataSource(dt)

				Dim R As New Frm_Tarjeta

				Dim path = "C:\Users\sergi\source\repos\TarjetasSIAPCO\TarjetasSIAPCO\bin\Debug\img\QR_TEMPORAL.jpeg"
				Cr.SetParameterValue("picturePath", path)

				R.CRV_tarjeta.ReportSource = Cr
				R.ShowDialog()


			Catch ex As Exception
				MsgBox(ex.ToString)
			End Try

		Else
			MsgBox("Ningùn campo puede quedar vacio. Verifica e intenta de nuevo")
		End If

	End Sub
	Sub actualizar_tabla()
		dtgv_buscar.Rows.Clear()
		Try
			Using objCon As New SQLiteConnection(cadena_conexion)
				objCon.Open()
				Using objCommand As New SQLiteCommand("SELECT no_servicio, nombre, direccion, cobradora, mensualidad FROM clientes", objCon)
					Using objReader As SQLiteDataReader = objCommand.ExecuteReader
						While (objReader.Read())
							dtgv_buscar.Rows.Add(objReader("no_servicio"), objReader("nombre"), objReader("direccion"), objReader("cobradora"), objReader("mensualidad"))
						End While
					End Using
				End Using
				Using objCommand As New SQLiteCommand("SELECT count(nombre) FROM clientes", objCon)
					Using objReader As SQLiteDataReader = objCommand.ExecuteReader
						While (objReader.Read())
							lbl_total.Text = objReader("count(nombre)")
						End While
					End Using
				End Using

			End Using
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	'Sub men()
	'	Try
	'		Using objCon As New SQLiteConnection(cadena_conexion)
	'			objCon.Open()
	'			Dim i As Integer
	'			For i = 1000 To 1296
	'				Using objCommand As New SQLiteCommand("INSERT INTO mensualidades (fk_no_servicio, anio, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre)values('" & i & "','2020','0.0','0.0','0.0','0.0','0.0','0.0','0.0','0.0','0.0','0.0','0.0','0.0')", objCon)
	'					objCommand.ExecuteNonQuery()
	'				End Using
	'			Next
	'			MsgBox("Listo, carnal...espero y funcione!")
	'		End Using
	'	Catch ex As Exception
	'		MsgBox(ex.ToString)
	'	End Try
	'End Sub
	Sub buscar(cosa As String)

		Try
			If txt_buscar.Text = "" Then
				dtgv_buscar.Rows.Clear()
			Else
				Using objCon As New SQLiteConnection(cadena_conexion)
					objCon.Open()

					Using objCommand As New SQLiteCommand("SELECT no_servicio, nombre, direccion, cobradora, mensualidad FROM clientes WHERE nombre like '%" & cosa & "%' or no_servicio like '%" & cosa & "%'  ORDER BY nombre ASC", objCon)
						Using objReader As SQLiteDataReader = objCommand.ExecuteReader()
							dtgv_buscar.Rows.Clear()

							While (objReader.Read())
								dtgv_buscar.Rows.Add(objReader("no_servicio"), objReader("nombre"), objReader("direccion"), objReader("cobradora"), objReader("mensualidad"))
							End While

						End Using
					End Using

				End Using
			End If

		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	Private Sub txt_calle_TextChanged(sender As Object, e As EventArgs) Handles txt_calle.TextChanged
		txt_calle.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_calle.Text)
		txt_calle.SelectionStart = txt_calle.Text.Length
	End Sub

	Private Sub btn_qr_Click(sender As Object, e As EventArgs) Handles btn_qr.Click
		Dim gen As New QRCodeGenerator
		Dim data = gen.CreateQrCode(txt_ns.Text, QRCodeGenerator.ECCLevel.Q)
		Dim code As New QRCode(data)
		picture.Image = code.GetGraphic(6)

		btn_save.Enabled = True


	End Sub

	Private Sub txt_ns_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ns.KeyPress
		e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
		'Si no hay un punto en el textBox devuelve -1
		Dim existe As Integer = txt_ns.Text.IndexOf(".")

		If Char.IsNumber(e.KeyChar) Then
			e.Handled = False
		Else
			'Si es punto
			If Asc(e.KeyChar) = 46 Then

				If existe <> -1 Then
					e.Handled = True
				Else
					e.Handled = False
				End If

				'Si es la tecla borrar
			ElseIf Asc(e.KeyChar) = 8 Then
				e.Handled = False
			Else
				e.Handled = True
			End If
		End If
	End Sub

	Private Sub txt_buscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscar.KeyUp
		If txt_buscar.Text = "" Then
			actualizar_tabla()
		Else
			Dim nombre = txt_buscar.Text
			buscar(nombre)
		End If
	End Sub


	Private Sub Button2_Click(sender As Object, e As EventArgs)
		Form3.Show()
	End Sub


	Private Sub btn_entradas_Click(sender As Object, e As EventArgs) Handles btn_entradas.Click
		Me.Enabled = False
		Form3.Show()
	End Sub

	Private Sub Label11_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub cb_LICobradora_SelectedIndexChanged(sender As Object, e As EventArgs)

	End Sub
End Class
