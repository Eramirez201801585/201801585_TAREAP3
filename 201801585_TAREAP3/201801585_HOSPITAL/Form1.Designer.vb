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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHonoraios = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbHabitacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnCalculo = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMostrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLimpiarMatriz = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLimpiarEstadisticas = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLimpiarIngresos = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEstadisticas = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblE3 = New System.Windows.Forms.Label()
        Me.lblE2 = New System.Windows.Forms.Label()
        Me.lblE1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CONSULTAR = New System.Windows.Forms.GroupBox()
        Me.txtConsultar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.CONSULTAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DATOS"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbFormaPago)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtHonoraios)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(488, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(255, 85)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pago"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Efectivo", "Transferencia ACH", "Depósito bancario", "Tarjeta de crédito", "Seguro médico"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(121, 50)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(121, 23)
        Me.cmbFormaPago.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Forma de Pago"
        '
        'txtHonoraios
        '
        Me.txtHonoraios.Location = New System.Drawing.Point(121, 15)
        Me.txtHonoraios.Name = "txtHonoraios"
        Me.txtHonoraios.Size = New System.Drawing.Size(121, 23)
        Me.txtHonoraios.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Honorarios Médico"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbHabitacion)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtDias)
        Me.GroupBox3.Location = New System.Drawing.Point(213, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 84)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hospitalización"
        '
        'cmbHabitacion
        '
        Me.cmbHabitacion.FormattingEnabled = True
        Me.cmbHabitacion.Items.AddRange(New Object() {"Privada", "Semiprivada", "No privada"})
        Me.cmbHabitacion.Location = New System.Drawing.Point(141, 52)
        Me.cmbHabitacion.Name = "cmbHabitacion"
        Me.cmbHabitacion.Size = New System.Drawing.Size(121, 23)
        Me.cmbHabitacion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de Habitación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Días de Hospitalización"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(141, 16)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(121, 23)
        Me.txtDias.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNit)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 85)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Paciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(63, 45)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(131, 23)
        Me.txtNit.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(63, 16)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(131, 23)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCalculo, Me.btnMostrar, Me.LimpiarMatrizToolStripMenuItem, Me.btnEstadisticas, Me.btnConsultar, Me.btnCerrar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnCalculo
        '
        Me.btnCalculo.Name = "btnCalculo"
        Me.btnCalculo.Size = New System.Drawing.Size(59, 20)
        Me.btnCalculo.Text = "&Cálculo"
        '
        'btnMostrar
        '
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(60, 20)
        Me.btnMostrar.Text = "&Mostrar"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLimpiarMatriz, Me.btnLimpiarEstadisticas, Me.btnLimpiarIngresos})
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarMatrizToolStripMenuItem.Text = "&Limpiar"
        '
        'btnLimpiarMatriz
        '
        Me.btnLimpiarMatriz.Name = "btnLimpiarMatriz"
        Me.btnLimpiarMatriz.Size = New System.Drawing.Size(164, 22)
        Me.btnLimpiarMatriz.Text = "&Matriz"
        '
        'btnLimpiarEstadisticas
        '
        Me.btnLimpiarEstadisticas.Name = "btnLimpiarEstadisticas"
        Me.btnLimpiarEstadisticas.Size = New System.Drawing.Size(164, 22)
        Me.btnLimpiarEstadisticas.Text = "&Estadísticas"
        '
        'btnLimpiarIngresos
        '
        Me.btnLimpiarIngresos.Name = "btnLimpiarIngresos"
        Me.btnLimpiarIngresos.Size = New System.Drawing.Size(164, 22)
        Me.btnLimpiarIngresos.Text = "&Datos Ingresados"
        '
        'btnEstadisticas
        '
        Me.btnEstadisticas.Name = "btnEstadisticas"
        Me.btnEstadisticas.Size = New System.Drawing.Size(82, 20)
        Me.btnEstadisticas.Text = "&Estadiísticas"
        '
        'btnConsultar
        '
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 20)
        Me.btnConsultar.Text = "&Hacer Consulta"
        '
        'btnCerrar
        '
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(41, 20)
        Me.btnCerrar.Text = "&Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(752, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Paciente"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NIT"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Días"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Habitación"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Honoraios"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Forma de Pago"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pago Parcial"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Descuento o Recargo"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Pago Final"
        Me.Column9.Name = "Column9"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblE3)
        Me.GroupBox5.Controls.Add(Me.lblE2)
        Me.GroupBox5.Controls.Add(Me.lblE1)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 386)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(752, 100)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ESTADÍSTICAS"
        '
        'lblE3
        '
        Me.lblE3.AutoSize = True
        Me.lblE3.Location = New System.Drawing.Point(245, 61)
        Me.lblE3.Name = "lblE3"
        Me.lblE3.Size = New System.Drawing.Size(0, 15)
        Me.lblE3.TabIndex = 5
        '
        'lblE2
        '
        Me.lblE2.AutoSize = True
        Me.lblE2.Location = New System.Drawing.Point(175, 41)
        Me.lblE2.Name = "lblE2"
        Me.lblE2.Size = New System.Drawing.Size(0, 15)
        Me.lblE2.TabIndex = 4
        '
        'lblE1
        '
        Me.lblE1.AutoSize = True
        Me.lblE1.Location = New System.Drawing.Point(254, 23)
        Me.lblE1.Name = "lblE1"
        Me.lblE1.Size = New System.Drawing.Size(0, 15)
        Me.lblE1.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Días de habitaciones no privadas utilizados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total en trasferencias  ACH Q"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cantidad de habitaciones privadas utilizadas"
        '
        'CONSULTAR
        '
        Me.CONSULTAR.Controls.Add(Me.txtConsultar)
        Me.CONSULTAR.Controls.Add(Me.Label7)
        Me.CONSULTAR.Location = New System.Drawing.Point(12, 150)
        Me.CONSULTAR.Name = "CONSULTAR"
        Me.CONSULTAR.Size = New System.Drawing.Size(269, 74)
        Me.CONSULTAR.TabIndex = 4
        Me.CONSULTAR.TabStop = False
        Me.CONSULTAR.Text = "CONSULTAR"
        '
        'txtConsultar
        '
        Me.txtConsultar.Location = New System.Drawing.Point(69, 32)
        Me.txtConsultar.Name = "txtConsultar"
        Me.txtConsultar.Size = New System.Drawing.Size(192, 23)
        Me.txtConsultar.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "NIT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(787, 494)
        Me.Controls.Add(Me.CONSULTAR)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes Hospitalizados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.CONSULTAR.ResumeLayout(False)
        Me.CONSULTAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnCalculo As ToolStripMenuItem
    Friend WithEvents btnMostrar As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLimpiarMatriz As ToolStripMenuItem
    Friend WithEvents btnLimpiarEstadisticas As ToolStripMenuItem
    Friend WithEvents btnLimpiarIngresos As ToolStripMenuItem
    Friend WithEvents btnEstadisticas As ToolStripMenuItem
    Friend WithEvents btnConsultar As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbHabitacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDias As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHonoraios As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCerrar As ToolStripMenuItem
    Friend WithEvents CONSULTAR As GroupBox
    Friend WithEvents txtConsultar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblE3 As Label
    Friend WithEvents lblE2 As Label
    Friend WithEvents lblE1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
