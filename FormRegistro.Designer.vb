<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_EmpleadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim QRLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro))
        Me.GroupBoxQR = New System.Windows.Forms.GroupBox()
        Me.ButtonRegresar = New System.Windows.Forms.Button()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.Id_EmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.EmpleadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectBDDataSet1 = New GENERAR_BARRAS.ProyectBDDataSet1()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroComboBox = New System.Windows.Forms.ComboBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.QRTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonCrearqr = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectBDDataSet = New GENERAR_BARRAS.ProyectBDDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosTableAdapter = New GENERAR_BARRAS.ProyectBDDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New GENERAR_BARRAS.ProyectBDDataSetTableAdapters.TableAdapterManager()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosTableAdapter1 = New GENERAR_BARRAS.ProyectBDDataSet1TableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager1 = New GENERAR_BARRAS.ProyectBDDataSet1TableAdapters.TableAdapterManager()
        Me.ButtonImprimir = New System.Windows.Forms.Button()
        Id_EmpleadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        QRLabel = New System.Windows.Forms.Label()
        Me.GroupBoxQR.SuspendLayout()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_EmpleadoLabel
        '
        Id_EmpleadoLabel.AutoSize = True
        Id_EmpleadoLabel.Location = New System.Drawing.Point(11, 35)
        Id_EmpleadoLabel.Name = "Id_EmpleadoLabel"
        Id_EmpleadoLabel.Size = New System.Drawing.Size(91, 15)
        Id_EmpleadoLabel.TabIndex = 28
        Id_EmpleadoLabel.Text = "Id Empleado:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(11, 64)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(63, 15)
        NombreLabel.TabIndex = 30
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(11, 93)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(64, 15)
        ApellidoLabel.TabIndex = 32
        ApellidoLabel.Text = "Apellido:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(11, 122)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(75, 15)
        DireccionLabel.TabIndex = 34
        DireccionLabel.Text = "Direccion:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(11, 151)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(59, 15)
        GeneroLabel.TabIndex = 36
        GeneroLabel.Text = "Genero:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(11, 180)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(67, 15)
        TelefonoLabel.TabIndex = 38
        TelefonoLabel.Text = "Telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(11, 209)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(57, 15)
        CorreoLabel.TabIndex = 40
        CorreoLabel.Text = "Correo:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(436, 38)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(42, 15)
        AreaLabel.TabIndex = 42
        AreaLabel.Text = "Area:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(436, 67)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(62, 15)
        UsuarioLabel.TabIndex = 44
        UsuarioLabel.Text = "Usuario:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(436, 96)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(87, 15)
        ContraseñaLabel.TabIndex = 46
        ContraseñaLabel.Text = "Contraseña:"
        '
        'QRLabel
        '
        QRLabel.AutoSize = True
        QRLabel.Location = New System.Drawing.Point(436, 125)
        QRLabel.Name = "QRLabel"
        QRLabel.Size = New System.Drawing.Size(30, 15)
        QRLabel.TabIndex = 48
        QRLabel.Text = "QR:"
        '
        'GroupBoxQR
        '
        Me.GroupBoxQR.Controls.Add(Me.ButtonImprimir)
        Me.GroupBoxQR.Controls.Add(Me.ButtonRegresar)
        Me.GroupBoxQR.Controls.Add(Me.ButtonMostrar)
        Me.GroupBoxQR.Controls.Add(Me.ButtonBuscar)
        Me.GroupBoxQR.Controls.Add(Me.ButtonEliminar)
        Me.GroupBoxQR.Controls.Add(Me.ButtonActualizar)
        Me.GroupBoxQR.Controls.Add(Me.ButtonNuevo)
        Me.GroupBoxQR.Controls.Add(Id_EmpleadoLabel)
        Me.GroupBoxQR.Controls.Add(Me.Id_EmpleadoTextBox)
        Me.GroupBoxQR.Controls.Add(NombreLabel)
        Me.GroupBoxQR.Controls.Add(Me.NombreTextBox)
        Me.GroupBoxQR.Controls.Add(ApellidoLabel)
        Me.GroupBoxQR.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBoxQR.Controls.Add(DireccionLabel)
        Me.GroupBoxQR.Controls.Add(Me.DireccionTextBox)
        Me.GroupBoxQR.Controls.Add(GeneroLabel)
        Me.GroupBoxQR.Controls.Add(Me.GeneroComboBox)
        Me.GroupBoxQR.Controls.Add(TelefonoLabel)
        Me.GroupBoxQR.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBoxQR.Controls.Add(CorreoLabel)
        Me.GroupBoxQR.Controls.Add(Me.CorreoTextBox)
        Me.GroupBoxQR.Controls.Add(AreaLabel)
        Me.GroupBoxQR.Controls.Add(Me.AreaComboBox)
        Me.GroupBoxQR.Controls.Add(UsuarioLabel)
        Me.GroupBoxQR.Controls.Add(Me.UsuarioTextBox)
        Me.GroupBoxQR.Controls.Add(ContraseñaLabel)
        Me.GroupBoxQR.Controls.Add(Me.ContraseñaTextBox)
        Me.GroupBoxQR.Controls.Add(QRLabel)
        Me.GroupBoxQR.Controls.Add(Me.QRTextBox)
        Me.GroupBoxQR.Controls.Add(Me.ButtonCrearqr)
        Me.GroupBoxQR.Controls.Add(Me.button3)
        Me.GroupBoxQR.Controls.Add(Me.ButtonAgregar)
        Me.GroupBoxQR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.GroupBoxQR.Location = New System.Drawing.Point(16, 14)
        Me.GroupBoxQR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxQR.Name = "GroupBoxQR"
        Me.GroupBoxQR.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxQR.Size = New System.Drawing.Size(840, 300)
        Me.GroupBoxQR.TabIndex = 1
        Me.GroupBoxQR.TabStop = False
        Me.GroupBoxQR.Text = "Registro de Usuario"
        '
        'ButtonRegresar
        '
        Me.ButtonRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegresar.Location = New System.Drawing.Point(758, 271)
        Me.ButtonRegresar.Name = "ButtonRegresar"
        Me.ButtonRegresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegresar.TabIndex = 55
        Me.ButtonRegresar.Text = "Regresar"
        Me.ButtonRegresar.UseVisualStyleBackColor = True
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMostrar.Location = New System.Drawing.Point(584, 236)
        Me.ButtonMostrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(100, 27)
        Me.ButtonMostrar.TabIndex = 54
        Me.ButtonMostrar.Text = "Mostrar "
        Me.ButtonMostrar.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBuscar.Location = New System.Drawing.Point(584, 203)
        Me.ButtonBuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(100, 27)
        Me.ButtonBuscar.TabIndex = 53
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEliminar.Location = New System.Drawing.Point(476, 236)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(100, 27)
        Me.ButtonEliminar.TabIndex = 52
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonActualizar.Location = New System.Drawing.Point(368, 236)
        Me.ButtonActualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(100, 27)
        Me.ButtonActualizar.TabIndex = 51
        Me.ButtonActualizar.Text = "Actualizar"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNuevo.Location = New System.Drawing.Point(368, 203)
        Me.ButtonNuevo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(100, 27)
        Me.ButtonNuevo.TabIndex = 50
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'Id_EmpleadoTextBox
        '
        Me.Id_EmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Id_Empleado", True))
        Me.Id_EmpleadoTextBox.Location = New System.Drawing.Point(108, 32)
        Me.Id_EmpleadoTextBox.Name = "Id_EmpleadoTextBox"
        Me.Id_EmpleadoTextBox.Size = New System.Drawing.Size(253, 23)
        Me.Id_EmpleadoTextBox.TabIndex = 29
        '
        'EmpleadosBindingSource1
        '
        Me.EmpleadosBindingSource1.DataMember = "Empleados"
        Me.EmpleadosBindingSource1.DataSource = Me.ProyectBDDataSet1
        '
        'ProyectBDDataSet1
        '
        Me.ProyectBDDataSet1.DataSetName = "ProyectBDDataSet1"
        Me.ProyectBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(108, 61)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(253, 23)
        Me.NombreTextBox.TabIndex = 31
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(108, 90)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(253, 23)
        Me.ApellidoTextBox.TabIndex = 33
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(108, 119)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(253, 23)
        Me.DireccionTextBox.TabIndex = 35
        '
        'GeneroComboBox
        '
        Me.GeneroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Genero", True))
        Me.GeneroComboBox.FormattingEnabled = True
        Me.GeneroComboBox.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.GeneroComboBox.Location = New System.Drawing.Point(108, 148)
        Me.GeneroComboBox.Name = "GeneroComboBox"
        Me.GeneroComboBox.Size = New System.Drawing.Size(253, 23)
        Me.GeneroComboBox.TabIndex = 37
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(108, 177)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(253, 23)
        Me.TelefonoTextBox.TabIndex = 39
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(108, 206)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(253, 23)
        Me.CorreoTextBox.TabIndex = 41
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Area", True))
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Items.AddRange(New Object() {"Administrador", "Usuario"})
        Me.AreaComboBox.Location = New System.Drawing.Point(533, 35)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(257, 23)
        Me.AreaComboBox.TabIndex = 43
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(533, 64)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(257, 23)
        Me.UsuarioTextBox.TabIndex = 45
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "Contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(533, 93)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(257, 23)
        Me.ContraseñaTextBox.TabIndex = 47
        '
        'QRTextBox
        '
        Me.QRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource1, "QR", True))
        Me.QRTextBox.Location = New System.Drawing.Point(533, 122)
        Me.QRTextBox.Name = "QRTextBox"
        Me.QRTextBox.Size = New System.Drawing.Size(235, 23)
        Me.QRTextBox.TabIndex = 49
        '
        'ButtonCrearqr
        '
        Me.ButtonCrearqr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCrearqr.Location = New System.Drawing.Point(672, 151)
        Me.ButtonCrearqr.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonCrearqr.Name = "ButtonCrearqr"
        Me.ButtonCrearqr.Size = New System.Drawing.Size(96, 27)
        Me.ButtonCrearqr.TabIndex = 28
        Me.ButtonCrearqr.Text = "Crear QR"
        Me.ButtonCrearqr.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(767, 121)
        Me.button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(30, 24)
        Me.button3.TabIndex = 27
        Me.button3.Text = "..."
        Me.button3.UseVisualStyleBackColor = True
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAgregar.Location = New System.Drawing.Point(476, 203)
        Me.ButtonAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(100, 27)
        Me.ButtonAgregar.TabIndex = 3
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(1067, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 2
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
        Me.EmpleadosBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ProyectBDDataSet
        '
        'ProyectBDDataSet
        '
        Me.ProyectBDDataSet.DataSetName = "ProyectBDDataSet"
        Me.ProyectBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.HorarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GENERAR_BARRAS.ProyectBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource1
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(16, 320)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(840, 260)
        Me.EmpleadosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Genero"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Genero"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "QR"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'EmpleadosTableAdapter1
        '
        Me.EmpleadosTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.EmpleadosTableAdapter = Me.EmpleadosTableAdapter1
        Me.TableAdapterManager1.HorarioTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = GENERAR_BARRAS.ProyectBDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonImprimir.Location = New System.Drawing.Point(558, 151)
        Me.ButtonImprimir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.Size = New System.Drawing.Size(96, 27)
        Me.ButtonImprimir.TabIndex = 56
        Me.ButtonImprimir.Text = "Imprimir QR"
        Me.ButtonImprimir.UseVisualStyleBackColor = True
        '
        'FormRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(872, 586)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Controls.Add(Me.GroupBoxQR)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBoxQR.ResumeLayout(False)
        Me.GroupBoxQR.PerformLayout()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxQR As GroupBox
    Friend WithEvents ButtonCrearqr As Button
    Friend WithEvents button3 As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ProyectBDDataSet As ProyectBDDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As ProyectBDDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As ProyectBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProyectBDDataSet1 As ProyectBDDataSet1
    Friend WithEvents EmpleadosBindingSource1 As BindingSource
    Friend WithEvents EmpleadosTableAdapter1 As ProyectBDDataSet1TableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager1 As ProyectBDDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Id_EmpleadoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents GeneroComboBox As ComboBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents AreaComboBox As ComboBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents QRTextBox As TextBox
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonMostrar As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonRegresar As Button
    Friend WithEvents ButtonImprimir As Button
End Class
