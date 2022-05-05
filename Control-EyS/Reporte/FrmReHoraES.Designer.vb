<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReHoraES
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New Control_EyS.DataSet1()
        Me.HorasESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreEmpleadoRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoEmpleadoRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHorasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorasESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreEmpleadoRDataGridViewTextBoxColumn, Me.ApellidoEmpleadoRDataGridViewTextBoxColumn, Me.HoraEntradaDataGridViewTextBoxColumn, Me.HoraSalidaDataGridViewTextBoxColumn, Me.TotalHorasDataGridViewTextBoxColumn, Me.FechasDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HorasESBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HorasESBindingSource
        '
        Me.HorasESBindingSource.DataMember = "Horas E/S"
        Me.HorasESBindingSource.DataSource = Me.DataSet1
        '
        'NombreEmpleadoRDataGridViewTextBoxColumn
        '
        Me.NombreEmpleadoRDataGridViewTextBoxColumn.DataPropertyName = "nombreEmpleadoR"
        Me.NombreEmpleadoRDataGridViewTextBoxColumn.HeaderText = "nombreEmpleadoR"
        Me.NombreEmpleadoRDataGridViewTextBoxColumn.Name = "NombreEmpleadoRDataGridViewTextBoxColumn"
        '
        'ApellidoEmpleadoRDataGridViewTextBoxColumn
        '
        Me.ApellidoEmpleadoRDataGridViewTextBoxColumn.DataPropertyName = "apellidoEmpleadoR"
        Me.ApellidoEmpleadoRDataGridViewTextBoxColumn.HeaderText = "apellidoEmpleadoR"
        Me.ApellidoEmpleadoRDataGridViewTextBoxColumn.Name = "ApellidoEmpleadoRDataGridViewTextBoxColumn"
        '
        'HoraEntradaDataGridViewTextBoxColumn
        '
        Me.HoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.HeaderText = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.Name = "HoraEntradaDataGridViewTextBoxColumn"
        '
        'HoraSalidaDataGridViewTextBoxColumn
        '
        Me.HoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.HeaderText = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.Name = "HoraSalidaDataGridViewTextBoxColumn"
        '
        'TotalHorasDataGridViewTextBoxColumn
        '
        Me.TotalHorasDataGridViewTextBoxColumn.DataPropertyName = "totalHoras"
        Me.TotalHorasDataGridViewTextBoxColumn.HeaderText = "totalHoras"
        Me.TotalHorasDataGridViewTextBoxColumn.Name = "TotalHorasDataGridViewTextBoxColumn"
        '
        'FechasDataGridViewTextBoxColumn
        '
        Me.FechasDataGridViewTextBoxColumn.DataPropertyName = "Fechas"
        Me.FechasDataGridViewTextBoxColumn.HeaderText = "Fechas"
        Me.FechasDataGridViewTextBoxColumn.Name = "FechasDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REPORTE DE ENTRADA Y SALIDA"
        '
        'FrmReHoraES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmReHoraES"
        Me.Text = "FrmReHoraES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorasESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NombreEmpleadoRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoEmpleadoRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalHorasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasESBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
