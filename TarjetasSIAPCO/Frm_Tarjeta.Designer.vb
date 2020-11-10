<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Tarjeta
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
		Me.CRV_tarjeta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.SuspendLayout()
		'
		'CRV_tarjeta
		'
		Me.CRV_tarjeta.ActiveViewIndex = -1
		Me.CRV_tarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CRV_tarjeta.Cursor = System.Windows.Forms.Cursors.Default
		Me.CRV_tarjeta.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CRV_tarjeta.Location = New System.Drawing.Point(0, 0)
		Me.CRV_tarjeta.Name = "CRV_tarjeta"
		Me.CRV_tarjeta.ShowCloseButton = False
		Me.CRV_tarjeta.ShowCopyButton = False
		Me.CRV_tarjeta.ShowGotoPageButton = False
		Me.CRV_tarjeta.ShowGroupTreeButton = False
		Me.CRV_tarjeta.ShowLogo = False
		Me.CRV_tarjeta.ShowParameterPanelButton = False
		Me.CRV_tarjeta.ShowRefreshButton = False
		Me.CRV_tarjeta.ShowTextSearchButton = False
		Me.CRV_tarjeta.Size = New System.Drawing.Size(894, 498)
		Me.CRV_tarjeta.TabIndex = 0
		Me.CRV_tarjeta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
		'
		'Frm_Tarjeta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(894, 498)
		Me.Controls.Add(Me.CRV_tarjeta)
		Me.Name = "Frm_Tarjeta"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.Text = "Tarjeta Final"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents CRV_tarjeta As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
