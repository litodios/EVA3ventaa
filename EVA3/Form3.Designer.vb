<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        panel1 = New Panel()
        btvolver = New Button()
        DataGridView1 = New DataGridView()
        btconsulta = New Button()
        Label4 = New Label()
        txtrut = New TextBox()
        btborrar = New Button()
        bteditar = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cmbtipo = New ComboBox()
        btagregar = New Button()
        txtcontraseña = New TextBox()
        txtusuario = New TextBox()
        panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        panel1.Controls.Add(btvolver)
        panel1.Controls.Add(DataGridView1)
        panel1.Controls.Add(btconsulta)
        panel1.Controls.Add(Label4)
        panel1.Controls.Add(txtrut)
        panel1.Controls.Add(btborrar)
        panel1.Controls.Add(bteditar)
        panel1.Controls.Add(Label3)
        panel1.Controls.Add(Label2)
        panel1.Controls.Add(Label1)
        panel1.Controls.Add(cmbtipo)
        panel1.Controls.Add(btagregar)
        panel1.Controls.Add(txtcontraseña)
        panel1.Controls.Add(txtusuario)
        resources.ApplyResources(panel1, "panel1")
        panel1.Name = "panel1"
        ' 
        ' btvolver
        ' 
        resources.ApplyResources(btvolver, "btvolver")
        btvolver.Name = "btvolver"
        btvolver.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Lavender
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(DataGridView1, "DataGridView1")
        DataGridView1.Name = "DataGridView1"
        ' 
        ' btconsulta
        ' 
        resources.ApplyResources(btconsulta, "btconsulta")
        btconsulta.Name = "btconsulta"
        btconsulta.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.Name = "Label4"
        ' 
        ' txtrut
        ' 
        resources.ApplyResources(txtrut, "txtrut")
        txtrut.Name = "txtrut"
        ' 
        ' btborrar
        ' 
        resources.ApplyResources(btborrar, "btborrar")
        btborrar.Name = "btborrar"
        btborrar.UseVisualStyleBackColor = True
        ' 
        ' bteditar
        ' 
        resources.ApplyResources(bteditar, "bteditar")
        bteditar.Name = "bteditar"
        bteditar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' cmbtipo
        ' 
        cmbtipo.FormattingEnabled = True
        resources.ApplyResources(cmbtipo, "cmbtipo")
        cmbtipo.Name = "cmbtipo"
        ' 
        ' btagregar
        ' 
        resources.ApplyResources(btagregar, "btagregar")
        btagregar.Name = "btagregar"
        btagregar.UseVisualStyleBackColor = True
        ' 
        ' txtcontraseña
        ' 
        resources.ApplyResources(txtcontraseña, "txtcontraseña")
        txtcontraseña.Name = "txtcontraseña"
        ' 
        ' txtusuario
        ' 
        resources.ApplyResources(txtusuario, "txtusuario")
        txtusuario.Name = "txtusuario"
        ' 
        ' Form3
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panel1 As Panel
    Friend WithEvents btagregar As Button
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents bteditar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrut As TextBox
    Friend WithEvents btborrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btconsulta As Button
    Friend WithEvents btvolver As Button
End Class
