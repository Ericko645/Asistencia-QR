Public Class FormEditar
    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ProyectBDDataSet1)

    End Sub

    Private Sub FormEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectBDDataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter1.Fill(Me.ProyectBDDataSet1.Empleados)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EmpleadosTableAdapter1.Buscar(ProyectBDDataSet1.Empleados, Id_EmpleadoTextBox.Text)
        Button1.Enabled = False
        Id_EmpleadoTextBox.Enabled = False
        Button2.Enabled = True
        NombreTextBox.Enabled = True
        ApellidoTextBox.Enabled = True
        DireccionTextBox.Enabled = True
        CorreoTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        GeneroComboBox.Enabled = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Button2.Enabled = False
        NombreTextBox.Enabled = False
        ApellidoTextBox.Enabled = False
        DireccionTextBox.Enabled = False
        CorreoTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        GeneroComboBox.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormCentro.Show()
        Me.Hide()
    End Sub
End Class