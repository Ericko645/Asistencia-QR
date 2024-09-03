Public Class FormHorario
    Private Sub Horario2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Horario2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Horario2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectBDDataSet2)

    End Sub

    Private Sub FormHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectBDDataSet2.Horario2' Puede moverla o quitarla según sea necesario.
        Me.Horario2TableAdapter.Fill(Me.ProyectBDDataSet2.Horario2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Horario2TableAdapter.BuscarHrs(ProyectBDDataSet2.Horario2, UsuarioTextBox.Text, AreaComboBox.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Horario2TableAdapter.Fill(Me.ProyectBDDataSet2.Horario2)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormCentro.Show()
        Me.Hide()
    End Sub
End Class