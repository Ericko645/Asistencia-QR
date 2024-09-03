Public Class FormRegistro
    Private Sub GroupBoxQR_Enter(sender As Object, e As EventArgs) Handles GroupBoxQR.Enter
        ButtonAgregar.Enabled = False
        ButtonNuevo.Enabled = True
        ButtonCrearqr.Enabled = False
        ButtonActualizar.Enabled = False
        ButtonEliminar.Enabled = False
        ButtonBuscar.Enabled = True
        ButtonMostrar.Enabled = True
        ButtonRegresar.Enabled = True
        ButtonImprimir.Enabled = False
    End Sub

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ProyectBDDataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectBDDataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter1.Fill(Me.ProyectBDDataSet1.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'ProyectBDDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter1.Fill(Me.ProyectBDDataSet1.Empleados)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Me.EmpleadosTableAdapter1.Agregar(Id_EmpleadoTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DireccionTextBox.Text,
                                        GeneroComboBox.Text, TelefonoTextBox.Text, CorreoTextBox.Text, AreaComboBox.Text,
                                        UsuarioTextBox.Text, ContraseñaTextBox.Text, QRTextBox.Text)
        MessageBox.Show("Datos se han Registrado Correctamente")
        Me.EmpleadosTableAdapter1.Fill(Me.ProyectBDDataSet1.Empleados)
        ButtonAgregar.Enabled = False
        ButtonNuevo.Enabled = True
        ButtonCrearqr.Enabled = True
        ButtonActualizar.Enabled = True
        ButtonEliminar.Enabled = True
        ButtonBuscar.Enabled = True
        ButtonMostrar.Enabled = True
        ButtonRegresar.Enabled = True
        ButtonImprimir.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonCrearqr.Click
        FormQR.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                QRTextBox.Text = Me.OpenFileDialog1.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Id_EmpleadoTextBox.Clear()
        NombreTextBox.Clear()
        ApellidoTextBox.Clear()
        DireccionTextBox.Clear()
        TelefonoTextBox.Clear()
        CorreoTextBox.Clear()
        UsuarioTextBox.Clear()
        ContraseñaTextBox.Clear()
        QRTextBox.Clear()

        ButtonAgregar.Enabled = True
        ButtonNuevo.Enabled = False
        ButtonCrearqr.Enabled = False
        ButtonActualizar.Enabled = False
        ButtonEliminar.Enabled = False
        ButtonBuscar.Enabled = True
        ButtonMostrar.Enabled = True
        ButtonRegresar.Enabled = True
        ButtonImprimir.Enabled = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        Me.EmpleadosTableAdapter1.Actualizar(Id_EmpleadoTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DireccionTextBox.Text,
                                        GeneroComboBox.Text, TelefonoTextBox.Text, CorreoTextBox.Text, AreaComboBox.Text,
                                        UsuarioTextBox.Text, ContraseñaTextBox.Text, QRTextBox.Text, Id_EmpleadoTextBox.Text)
        MessageBox.Show("Datos Actualizados Correctamente")
        Me.EmpleadosTableAdapter1.Fill(Me.ProyectBDDataSet1.Empleados)
        ButtonAgregar.Enabled = False
        ButtonNuevo.Enabled = True
        ButtonCrearqr.Enabled = True
        ButtonActualizar.Enabled = True
        ButtonEliminar.Enabled = True
        ButtonBuscar.Enabled = True
        ButtonMostrar.Enabled = True
        ButtonRegresar.Enabled = True
        ButtonImprimir.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Me.EmpleadosTableAdapter1.Eliminar(Id_EmpleadoTextBox.Text)
        MessageBox.Show("Datos Eliminados")
        Me.EmpleadosTableAdapter1.Fill(Me.ProyectBDDataSet1.Empleados)
        ButtonAgregar.Enabled = False
        ButtonNuevo.Enabled = True
        ButtonCrearqr.Enabled = True
        ButtonActualizar.Enabled = True
        ButtonEliminar.Enabled = True
        ButtonBuscar.Enabled = True
        ButtonMostrar.Enabled = True
        ButtonRegresar.Enabled = True
        ButtonImprimir.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Me.EmpleadosTableAdapter1.Buscar(ProyectBDDataSet1.Empleados, Id_EmpleadoTextBox.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Me.EmpleadosTableAdapter1.Fill(Me.ProyectBDDataSet1.Empleados)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        FormCentro.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonImprimir_Click(sender As Object, e As EventArgs) Handles ButtonImprimir.Click
        FormQR.TextBoxGENERAR.Text = "Nombre: " & NombreTextBox.Text & " " & ApellidoTextBox.Text & " Area: " & AreaComboBox.Text & " Usuario: " & UsuarioTextBox.Text & " Contraseña: " & ContraseñaTextBox.Text & ""
        MessageBox.Show("Datos Imprimido en el QR")
        ButtonAgregar.Enabled = True
        ButtonNuevo.Enabled = False
        ButtonCrearqr.Enabled = True
        ButtonActualizar.Enabled = False
        ButtonEliminar.Enabled = False
        ButtonBuscar.Enabled = True
        ButtonMostrar.Enabled = True
        ButtonRegresar.Enabled = True
        ButtonImprimir.Enabled = True
    End Sub
End Class