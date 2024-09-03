Imports System.Data
Imports System.Data.SqlClient
Public Class FormCentro
    Dim Hora_ini As DateTime
    Dim Tiempo As DateTime
    Dim Tiempo2 As DateTime
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMostrar.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim valor_Hora As Double = Val(50)
        Dim Hora_Fin As DateTime = Now.ToString("HH:mm:ss")

        Dim diferencia As TimeSpan = Hora_Fin.Subtract(Hora_ini)
        Dim horas As Double = Math.Ceiling(diferencia.TotalHours)
        Dim valor As Double = diferencia.TotalHours * valor_Hora

        Label2.Text = "Lps." & Math.Round(valor, 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormEmail.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button4.Enabled = True
        Button3.Enabled = False
        Hora_ini = Now.ToString("HH:mm:ss")
        Label_Inicio.Text = Hora_ini
        Timer1.Start()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button3.Enabled = True
        Button4.Enabled = False
        Timer1.Stop()
        Tiempo2 = Now.ToString("HH:mm:ss")
        Label_Final.Text = Tiempo2

        Me.Horario2TableAdapter.AgregarHrs(Label5.Text, Label1.Text, Label3.Text, Label_Inicio.Text, Label_Final.Text, Label2.Text)
        Me.Horario2TableAdapter.Fill(Me.ProyectBDDataSet2.Horario2)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = DateTime.Now.ToShortDateString
        Tiempo = Now.ToString("HH:mm:ss")
        Label4.Text = Tiempo
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Label2.Visible = False
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProyectBDDataSet2.Horario2' Puede moverla o quitarla según sea necesario.
        Me.Horario2TableAdapter.Fill(Me.ProyectBDDataSet2.Horario2)

    End Sub

    Private Sub Horario2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Horario2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Horario2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProyectBDDataSet2)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormEditar.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class