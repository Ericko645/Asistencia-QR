Imports ZXing

Public Class FormQR

    Private Sub ButtonCREAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCREAR.Click

        Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIALIZA EL GENERADOR

        'ELIGE EL CODIGO 
        If RadioButtonPDF417.Checked Then
            GENERADOR.Format = BarcodeFormat.PDF_417
        ElseIf RadioButton128.Checked Then
            GENERADOR.Format = BarcodeFormat.CODE_128
        ElseIf RadioButtonQR.Checked Then
            GENERADOR.Format = BarcodeFormat.QR_CODE

            'ElseIf RadioButton.....Checked Then
            'GENERADOR.Format = BarcodeFormat....
        End If

        Try 'GENERA UN BITMAP Y LO PRESENTA EN EL PICTUREBOX
            Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(TextBoxGENERAR.Text), PictureBoxGENERAR.Width, PictureBoxGENERAR.Height)
            PictureBoxGENERAR.Image = IMAGEN
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawImage(PictureBoxGENERAR.Image, 0, 0) 'CREA UN DOCUMENTO IMPRIMIBLE CON LA IMAGEN SITUADA EN EL ORIGEN (0,0) DEL DOCUMENTO

    End Sub

    Private Sub ButtonIMPRIMIR_Click(sender As System.Object, e As System.EventArgs)

        PrintPreviewDialog1.Document = PrintDocument1 ' ASIGNA EL CONTROL PRINTDOCUMENT AL PRINTPREVIEW
        PrintPreviewDialog1.ShowDialog() 'MUESTRA EL DIALOGO

    End Sub

    Private Sub ButtonGUARDAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGUARDAR.Click

        SaveFileDialog1.DefaultExt = ".jpg" 'PARA NO TENER QUE ESCRIBIR LA EXTENSION
        SaveFileDialog1.FileName = TextBoxGENERAR.Text 'POR SI QUEREMOS USAR EL TEXTO DEL TEXTBOX COMO NOMBRE DE LA IMAGEN

        If SaveFileDialog1.ShowDialog Then
            Try 'GUARDA LA IMAGEN DEL PICTUREBOX EN LA CARPETA DEBUG DEL PROYECTO
                PictureBoxGENERAR.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
                MsgBox("GUARDADO")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub


    'GENERA UN INTERVALO DE ESPERA
    Public Sub ESPERA(ByVal INTERVALO As Integer)

        Dim PARADA As New Stopwatch
        PARADA.Start()
        Do While PARADA.ElapsedMilliseconds < INTERVALO
            Application.DoEvents()
        Loop
        PARADA.Stop()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormRegistro.Show()
        Me.Hide()

    End Sub

End Class
