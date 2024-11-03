<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        cmbNombreRepuesto = New ComboBox()
        txtCantidadVendida = New TextBox()
        txtCliente = New TextBox()
        txttotal = New TextBox()
        btventarepuesto = New Button()
        Label1 = New Label()
        Label2 = New Label()
        cliente = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        btnLimpiarFiltros = New Button()
        btnBuscar = New Button()
        Label7 = New Label()
        DateTimePicker2 = New DateTimePicker()
        txtFiltroCliente = New TextBox()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        cmbFiltroRepuesto = New ComboBox()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbNombreRepuesto
        ' 
        cmbNombreRepuesto.FormattingEnabled = True
        cmbNombreRepuesto.Location = New Point(185, 142)
        cmbNombreRepuesto.Name = "cmbNombreRepuesto"
        cmbNombreRepuesto.Size = New Size(178, 23)
        cmbNombreRepuesto.TabIndex = 0
        ' 
        ' txtCantidadVendida
        ' 
        txtCantidadVendida.Location = New Point(185, 193)
        txtCantidadVendida.Name = "txtCantidadVendida"
        txtCantidadVendida.Size = New Size(178, 23)
        txtCantidadVendida.TabIndex = 1
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(185, 245)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(178, 23)
        txtCliente.TabIndex = 2
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(185, 346)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(178, 23)
        txttotal.TabIndex = 3
        ' 
        ' btventarepuesto
        ' 
        btventarepuesto.Location = New Point(175, 427)
        btventarepuesto.Name = "btventarepuesto"
        btventarepuesto.Size = New Size(188, 52)
        btventarepuesto.TabIndex = 4
        btventarepuesto.Text = "GUARDAR REGISTRO"
        btventarepuesto.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 5
        Label1.Text = "selecionar item"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 15)
        Label2.TabIndex = 6
        Label2.Text = "cantidad vendida"
        ' 
        ' cliente
        ' 
        cliente.AutoSize = True
        cliente.Location = New Point(34, 253)
        cliente.Name = "cliente"
        cliente.Size = New Size(44, 15)
        cliente.TabIndex = 7
        cliente.Text = "Cliente"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 354)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 8
        Label4.Text = "total"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btventarepuesto)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(cmbNombreRepuesto)
        Panel1.Controls.Add(cliente)
        Panel1.Controls.Add(txtCantidadVendida)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txttotal)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(30, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(495, 685)
        Panel1.TabIndex = 10
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(185, 292)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(225, 23)
        DateTimePicker1.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 15)
        Label6.TabIndex = 15
        Label6.Text = "Fecha"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 9
        Label3.Text = "MENU DE REGISTRO"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(btnLimpiarFiltros)
        Panel2.Controls.Add(btnBuscar)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(txtFiltroCliente)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(cmbFiltroRepuesto)
        Panel2.Location = New Point(565, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(666, 685)
        Panel2.TabIndex = 17
        ' 
        ' btnLimpiarFiltros
        ' 
        btnLimpiarFiltros.Location = New Point(490, 402)
        btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        btnLimpiarFiltros.Size = New Size(120, 39)
        btnLimpiarFiltros.TabIndex = 19
        btnLimpiarFiltros.Text = "LIMPIAR"
        btnLimpiarFiltros.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(446, 193)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(101, 40)
        btnBuscar.TabIndex = 18
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(186, 42)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 15)
        Label7.TabIndex = 17
        Label7.Text = "BUSQUEDA RESUMEN VENTA"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(144, 265)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(190, 23)
        DateTimePicker2.TabIndex = 16
        ' 
        ' txtFiltroCliente
        ' 
        txtFiltroCliente.Location = New Point(144, 198)
        txtFiltroCliente.Name = "txtFiltroCliente"
        txtFiltroCliente.Size = New Size(190, 23)
        txtFiltroCliente.TabIndex = 15
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 454)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(643, 219)
        DataGridView1.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(219, 414)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 15)
        Label5.TabIndex = 10
        Label5.Text = "RESUMEN DE VENTA"
        ' 
        ' cmbFiltroRepuesto
        ' 
        cmbFiltroRepuesto.FormattingEnabled = True
        cmbFiltroRepuesto.Location = New Point(144, 120)
        cmbFiltroRepuesto.Name = "cmbFiltroRepuesto"
        cmbFiltroRepuesto.Size = New Size(190, 23)
        cmbFiltroRepuesto.TabIndex = 13
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 128)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 15)
        Label8.TabIndex = 20
        Label8.Text = "NOMBRE REPUESTO"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 206)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 15)
        Label9.TabIndex = 21
        Label9.Text = "RUT CLIENTE"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(25, 273)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 15)
        Label10.TabIndex = 22
        Label10.Text = "FECHA"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1268, 736)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form7"
        Text = "Form7"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbNombreRepuesto As ComboBox
    Friend WithEvents txtCantidadVendida As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btventarepuesto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFiltroRepuesto As ComboBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtFiltroCliente As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiarFiltros As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
