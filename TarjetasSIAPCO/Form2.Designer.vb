<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
		Me.CRV_lista = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.SuspendLayout()
		'
		'CRV_lista
		'
		Me.CRV_lista.ActiveViewIndex = -1
		Me.CRV_lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CRV_lista.Cursor = System.Windows.Forms.Cursors.Default
		Me.CRV_lista.DisplayStatusBar = False
		Me.CRV_lista.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CRV_lista.Location = New System.Drawing.Point(0, 0)
		Me.CRV_lista.Name = "CRV_lista"
		Me.CRV_lista.ShowCloseButton = False
		Me.CRV_lista.ShowCopyButton = False
		Me.CRV_lista.ShowGotoPageButton = False
		Me.CRV_lista.ShowGroupTreeButton = False
		Me.CRV_lista.ShowLogo = False
		Me.CRV_lista.ShowParameterPanelButton = False
		Me.CRV_lista.Size = New System.Drawing.Size(871, 450)
		Me.CRV_lista.TabIndex = 0
		Me.CRV_lista.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(871, 450)
		Me.Controls.Add(Me.CRV_lista)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form2"
		Me.ShowInTaskbar = False
		Me.Text = "LISTA COMPLETA"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents CRV_lista As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
