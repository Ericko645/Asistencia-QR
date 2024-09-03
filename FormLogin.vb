Imports System.Data.SqlClient

Public Class FormLogin
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("server = DESKTOP-3V9HG71; database = Inventario_CEDIS; user id= sa; password = 123456")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Empleados WHERE Area='" & AreaComboBox.Text & "' AND Usuario='" & UsuarioTextBox.Text & "' AND Contraseña='" & ContraseñaTextBox.Text & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Bienvenido " + dt.Rows(0)(7))
            If (AreaComboBox.SelectedIndex = 0) Then
                Call Administrador()
            Else
                Call Usuario()
            End If
        Else
            MessageBox.Show("Sus Datos Son Incorrecto")
        End If
    End Sub


    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectBDDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Administrador()
        FormCentro.Show()
        Me.Hide()

        FormCentro.Text = "Administrador"
        FormCentro.Label1.Text = "" & AreaComboBox.Text & ""
        FormCentro.Label5.Text = "" & UsuarioTextBox.Text & ""
        FormCentro.Button5.Visible = False
    End Sub

    Private Sub Usuario()
        FormCentro.Show()
        Me.Hide()

        FormCentro.Text = "Usuario"
        FormCentro.Label1.Text = "" & AreaComboBox.Text & ""
        FormCentro.Label5.Text = "" & UsuarioTextBox.Text & ""
        FormCentro.Button1.Visible = False
        FormCentro.Button2.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class