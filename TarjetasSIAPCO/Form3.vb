Imports System.Data.SQLite
Public Class Form3
	Const cadena_conexion As String = "Data Source=TarjetasBD.db; Version=3;"

	Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
		Dim cobra = cb_cobradora.Text
		Dim anio = cb_anio.Text
		buscar(cobra, anio)
	End Sub
	Sub buscar(cobra As String, anio As String)
		dtgv_lista.Rows.Clear()

		Try
			Using objCon As New SQLiteConnection(cadena_conexion)
				objCon.Open()
				Using objCommand As New SQLiteCommand("SELECT no_servicio, nombre, anio, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre FROM clientes INNER JOIN mensualidades ON no_servicio = fk_no_servicio AND cobradora = '" & cobra & "' AND anio = '" & anio & "' ORDER BY nombre ASC", objCon)
					Using objReader As SQLiteDataReader = objCommand.ExecuteReader
						Dim i = 0
						'If (objReader.Read()) Then
						'MsgBox(objReader("no_servicio") & " - " & objReader("nombre"))
						While (objReader.Read())

								Dim no_servicio = objReader("no_servicio")
								Dim nombre = objReader("nombre")
								Dim enero = CInt(objReader("enero").ToString)
								Dim febrero = CInt(objReader("febrero").ToString)
								Dim marzo = CInt(objReader("marzo").ToString)
								Dim abril = CInt(objReader("abril").ToString)
								Dim mayo = CInt(objReader("mayo").ToString)
								Dim junio = CInt(objReader("junio").ToString)
								Dim julio = CInt(objReader("julio").ToString)
								Dim agosto = CInt(objReader("agosto").ToString)
								Dim septiembre = CInt(objReader("septiembre").ToString)
								Dim octubre = CInt(objReader("octubre").ToString)
								Dim noviembre = CInt(objReader("noviembre").ToString)
								Dim diciembre = CInt(objReader("diciembre").ToString)



								dtgv_lista.Rows.Add(no_servicio, nombre, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre)
								lbl_anio.Text = anio
								lbl_cobradora.Text = cobra
								If enero < 1 Then
									dtgv_lista.Rows(i).Cells(2).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(2).Style.BackColor = Color.YellowGreen
								End If

								If febrero < 1 Then
									dtgv_lista.Rows(i).Cells(3).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(3).Style.BackColor = Color.YellowGreen
								End If

								If marzo < 1 Then
									dtgv_lista.Rows(i).Cells(4).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(4).Style.BackColor = Color.YellowGreen
								End If

								If abril < 1 Then
									dtgv_lista.Rows(i).Cells(5).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(5).Style.BackColor = Color.YellowGreen
								End If

								If mayo < 1 Then
									dtgv_lista.Rows(i).Cells(6).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(6).Style.BackColor = Color.YellowGreen
								End If

								If junio < 1 Then
									dtgv_lista.Rows(i).Cells(7).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(7).Style.BackColor = Color.YellowGreen
								End If

								If julio < 1 Then
									dtgv_lista.Rows(i).Cells(8).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(8).Style.BackColor = Color.YellowGreen
								End If

								If agosto < 1 Then
									dtgv_lista.Rows(i).Cells(9).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(9).Style.BackColor = Color.YellowGreen
								End If

								If septiembre < 1 Then
									dtgv_lista.Rows(i).Cells(10).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(10).Style.BackColor = Color.YellowGreen
								End If

								If octubre < 1 Then
									dtgv_lista.Rows(i).Cells(11).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(11).Style.BackColor = Color.YellowGreen
								End If

								If noviembre < 1 Then
									dtgv_lista.Rows(i).Cells(12).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(12).Style.BackColor = Color.YellowGreen
								End If

								If diciembre < 1 Then
									dtgv_lista.Rows(i).Cells(13).Style.BackColor = Color.Orange
								Else
									dtgv_lista.Rows(i).Cells(13).Style.BackColor = Color.YellowGreen
								End If



								i = i + 1
							End While
						'Else
						'	Dim opcion As DialogResult
						'	opcion = MessageBox.Show("No hay registros del año seleccionado. ¿Desea generar un expediente con el año :" & anio & " ?", "Agregar nuevo año", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
						'	If (opcion = DialogResult.Yes) Then
						'		MsgBox("funcioa")
						'	Else
						'		MsgBox("Seleccione otro año para mostrar")
						'	End If
						'End If

					End Using
				End Using
				Using objCommand As New SQLiteCommand("SELECT count(no_servicio) FROM clientes 	INNER JOIN mensualidades ON no_servicio = fk_no_servicio AND cobradora = '" & cobra & "' AND anio = '" & anio & "'", objCon)
					Using objReader As SQLiteDataReader = objCommand.ExecuteReader
						While (objReader.Read())
							lbl_total.Text = objReader("count(no_servicio)")
						End While
					End Using
				End Using

			End Using
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		Form1.Enabled = True
	End Sub

	Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
		Dim no_servicio = ""
		Dim anio = lbl_anio.Text
		Dim enero = ""
		Dim febrero = ""
		Dim marzo = ""
		Dim abril = ""
		Dim mayo = ""
		Dim junio = ""
		Dim julio = ""
		Dim agosto = ""
		Dim septiembre = ""
		Dim octubre = ""
		Dim noviembre = ""
		Dim diciembre = ""


		Try
			Using objCon As New SQLiteConnection(cadena_conexion)
				objCon.Open()

				For i As Integer = 0 To dtgv_lista.RowCount - 1
					no_servicio = dtgv_lista.Rows(i).Cells(0).Value
					enero = dtgv_lista.Rows(i).Cells(2).Value
					If enero = "" Or Not IsNumeric(enero) Then enero = 0
					febrero = dtgv_lista.Rows(i).Cells(3).Value
					If febrero = "" Then febrero = 0
					marzo = dtgv_lista.Rows(i).Cells(4).Value
					If marzo = "" Then marzo = 0
					abril = dtgv_lista.Rows(i).Cells(5).Value
					If abril = "" Then abril = 0
					mayo = dtgv_lista.Rows(i).Cells(6).Value
					If mayo = "" Then mayo = 0
					junio = dtgv_lista.Rows(i).Cells(7).Value
					If junio = "" Then junio = 0
					julio = dtgv_lista.Rows(i).Cells(8).Value
					If julio = "" Then julio = 0
					agosto = dtgv_lista.Rows(i).Cells(9).Value
					If agosto = "" Then agosto = 0
					septiembre = dtgv_lista.Rows(i).Cells(10).Value
					If septiembre = "" Then septiembre = 0
					octubre = dtgv_lista.Rows(i).Cells(11).Value
					If octubre = "" Then octubre = 0
					noviembre = dtgv_lista.Rows(i).Cells(12).Value
					If noviembre = "" Then noviembre = 0
					diciembre = dtgv_lista.Rows(i).Cells(13).Value
					If diciembre = "" Then diciembre = 0

					Using objCommand As New SQLiteCommand("UPDATE mensualidades SET enero = '" & enero & "', febrero = '" & febrero & "', marzo = '" & marzo & "', 
																abril = '" & abril & "', mayo = '" & mayo & "', junio = '" & junio & "', julio = '" & julio & "', agosto = '" & agosto & "', 
																septiembre = '" & septiembre & "', octubre = '" & octubre & "', noviembre = '" & noviembre & "', diciembre = '" & diciembre & "' WHERE fk_no_servicio = " & no_servicio & " AND anio = '" & anio & "'", objCon)
						objCommand.ExecuteNonQuery()
					End Using

				Next
				Dim cobra = lbl_cobradora.Text
				buscar(cobra, anio)
				MsgBox("Registros actualizados correctamente ")
			End Using


		Catch ex As Exception
			MsgBox(ex)
		End Try
	End Sub

	Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
		Form1.Enabled = True
		Me.Close()
	End Sub

	Dim dt2 As New DataTable
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnt_listComp.Click
		dt2.Columns.Clear() 'se limpian las columnas
		dt2.Rows.Clear() 'se limpian las filas
		dt2.Columns.Add("no_servicio")
		dt2.Columns.Add("nombre")
		dt2.Columns.Add("direccion")
		dt2.Columns.Add("cobradora")

		dt2.Columns.Add("anio")
		dt2.Columns.Add("enero")
		dt2.Columns.Add("febrero")
		dt2.Columns.Add("marzo")
		dt2.Columns.Add("abril")
		dt2.Columns.Add("mayo")
		dt2.Columns.Add("junio")
		dt2.Columns.Add("julio")
		dt2.Columns.Add("agosto")
		dt2.Columns.Add("septiembre")
		dt2.Columns.Add("octubre")
		dt2.Columns.Add("noviembre")
		dt2.Columns.Add("diciembre")



		Try
			Using objCon As New SQLiteConnection(cadena_conexion)
				objCon.Open()
				'	Using objCommand As New SQLiteCommand("SELECT no_servicio, nombre, direccion, cobradora FROM clientes ORDER BY cobradora, nombre ASC", objCon)
				'		Using objReader As SQLiteDataReader = objCommand.ExecuteReader()

				'			While (objReader.Read())
				'				Dim ren As DataRow = dt2.NewRow()
				'				ren("no_servicio") = objReader("no_servicio")
				'				ren("nombre") = objReader("nombre")
				'				ren("direccion") = objReader("direccion")
				'				ren("cobradora") = objReader("cobradora")
				'				dt2.Rows.Add(ren)
				'			End While
				'		End Using
				'	End Using
				Using objCommand As New SQLiteCommand("SELECT no_servicio, nombre, cobradora, anio, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre FROM clientes 	INNER JOIN mensualidades ON no_servicio = fk_no_servicio ORDER BY cobradora, nombre ASC", objCon)
					Using objReader As SQLiteDataReader = objCommand.ExecuteReader()

						While (objReader.Read())
							Dim ren As DataRow = dt2.NewRow()
							ren("no_servicio") = objReader("no_servicio")
							ren("nombre") = objReader("nombre")
							ren("cobradora") = objReader("cobradora")


							ren("anio") = objReader("anio")
							If objReader("enero").ToString = "0.0" Then ren("enero") = "" Else ren("enero") = objReader("enero")

							If objReader("febrero").ToString = "0.0" Then ren("febrero") = "" Else ren("febrero") = objReader("febrero")

							If objReader("marzo").ToString = "0.0" Then ren("marzo") = "" Else ren("marzo") = objReader("marzo")

							If objReader("abril").ToString = "0.0" Then ren("abril") = "" Else ren("abril") = objReader("abril")

							If objReader("mayo").ToString = "0.0" Then ren("mayo") = "" Else ren("mayo") = objReader("mayo")

							If objReader("junio").ToString = "0.0" Then ren("junio") = "" Else ren("junio") = objReader("junio")

							If objReader("julio").ToString = "0.0" Then ren("julio") = "" Else ren("julio") = objReader("julio")

							If objReader("agosto").ToString = "0.0" Then ren("agosto") = "" Else ren("agosto") = objReader("agosto")

							If objReader("septiembre").ToString = "0.0" Then ren("septiembre") = "" Else ren("septiembre") = objReader("septiembre")

							If objReader("octubre").ToString = "0.0" Then ren("octubre") = "" Else ren("octubre") = objReader("octubre")

							If objReader("noviembre").ToString = "0.0" Then ren("noviembre") = "" Else ren("noviembre") = objReader("noviembre")

							If objReader("diciembre").ToString = "0.0" Then ren("diciembre") = "" Else ren("diciembre") = objReader("diciembre")

							dt2.Rows.Add(ren)
						End While
					End Using
				End Using
			End Using

			Dim Cr2 As New CR_lista

			Cr2.SetDataSource(dt2)

			Dim R2 As New Form2
			R2.CRV_lista.ReportSource = Cr2
			R2.ShowDialog()


		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try


	End Sub
	Dim dt_listInd As New DataTable
	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		If lbl_cobradora.Text = "- - -" Then
			MsgBox("Selecciona un nombre de la lista")
		Else
			Dim cobra = lbl_cobradora.Text
			dt_listInd.Columns.Clear() 'se limpian las columnas
			dt_listInd.Rows.Clear() 'se limpian las filas
			dt_listInd.Columns.Add("no_servicio")
			dt_listInd.Columns.Add("nombre")
			dt_listInd.Columns.Add("direccion")
			dt_listInd.Columns.Add("cobradora")
			dt_listInd.Columns.Add("mensualidad")

			dt_listInd.Columns.Add("anio")
			dt_listInd.Columns.Add("enero")
			dt_listInd.Columns.Add("febrero")
			dt_listInd.Columns.Add("marzo")
			dt_listInd.Columns.Add("abril")
			dt_listInd.Columns.Add("mayo")
			dt_listInd.Columns.Add("junio")
			dt_listInd.Columns.Add("julio")
			dt_listInd.Columns.Add("agosto")
			dt_listInd.Columns.Add("septiembre")
			dt_listInd.Columns.Add("octubre")
			dt_listInd.Columns.Add("noviembre")
			dt_listInd.Columns.Add("diciembre")



			Try
				Using objCon As New SQLiteConnection(cadena_conexion)
					objCon.Open()
					Using objCommand As New SQLiteCommand("SELECT no_servicio, nombre, cobradora, mensualidad, anio, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre FROM clientes 	INNER JOIN mensualidades ON no_servicio = fk_no_servicio AND cobradora = '" & cobra & "' ORDER BY cobradora, nombre ASC", objCon)
						Using objReader As SQLiteDataReader = objCommand.ExecuteReader()

							While (objReader.Read())
								Dim ren_listInd As DataRow = dt_listInd.NewRow()

								ren_listInd("cobradora") = objReader("cobradora")
								ren_listInd("anio") = objReader("anio")

								ren_listInd("no_servicio") = objReader("no_servicio")
								ren_listInd("nombre") = objReader("nombre")
								ren_listInd("mensualidad") = objReader("mensualidad")


								If objReader("enero").ToString = "0" Then ren_listInd("enero") = "" Else ren_listInd("enero") = objReader("enero")

								If objReader("febrero").ToString = "0" Then ren_listInd("febrero") = "" Else ren_listInd("febrero") = objReader("febrero")

								If objReader("marzo").ToString = "0" Then ren_listInd("marzo") = "" Else ren_listInd("marzo") = objReader("marzo")

								If objReader("abril").ToString = "0" Then ren_listInd("abril") = "" Else ren_listInd("abril") = objReader("abril")

								If objReader("mayo").ToString = "0" Then ren_listInd("mayo") = "" Else ren_listInd("mayo") = objReader("mayo")

								If objReader("junio").ToString = "0" Then ren_listInd("junio") = "" Else ren_listInd("junio") = objReader("junio")

								If objReader("julio").ToString = "0" Then ren_listInd("julio") = "" Else ren_listInd("julio") = objReader("julio")

								If objReader("agosto").ToString = "0" Then ren_listInd("agosto") = "" Else ren_listInd("agosto") = objReader("agosto")

								If objReader("septiembre").ToString = "0" Then ren_listInd("septiembre") = "" Else ren_listInd("septiembre") = objReader("septiembre")

								If objReader("octubre").ToString = "0" Then ren_listInd("octubre") = "" Else ren_listInd("octubre") = objReader("octubre")

								If objReader("noviembre").ToString = "0" Then ren_listInd("noviembre") = "" Else ren_listInd("noviembre") = objReader("noviembre")

								If objReader("diciembre").ToString = "0" Then ren_listInd("diciembre") = "" Else ren_listInd("diciembre") = objReader("diciembre")

								dt_listInd.Rows.Add(ren_listInd)
							End While
						End Using
					End Using
				End Using

				Dim Cr2 As New CR_lista_indi

				Cr2.SetDataSource(dt_listInd)

				Dim R2 As New Form2
				R2.CRV_lista.ReportSource = Cr2
				R2.ShowDialog()


			Catch ex As Exception
				MsgBox(ex.ToString)
			End Try
		End If

	End Sub

	Private Sub dtgv_lista_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles dtgv_lista.CellStateChanged
		Dim valor = dtgv_lista.CurrentCell.Value
		If IsNumeric(valor) Then
			If valor > 0 Then
				dtgv_lista.CurrentCell.Style.BackColor = Color.YellowGreen
			ElseIf IsNumeric(valor) Then
				dtgv_lista.CurrentCell.Style.BackColor = Color.Orange
			End If
		End If

	End Sub
End Class