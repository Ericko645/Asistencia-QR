<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQR))
        Me.TextBoxGENERAR = New System.Windows.Forms.TextBox()
        Me.ButtonCREAR = New System.Windows.Forms.Button()
        Me.PictureBoxGENERAR = New System.Windows.Forms.PictureBox()
        Me.ButtonGUARDAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton128 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonQR = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPDF417 = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBoxGENERAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxGENERAR
        '
        Me.TextBoxGENERAR.BackColor = System.Drawing.Color.Silver
        Me.TextBoxGENERAR.ForeColor = System.Drawing.Color.Black
        Me.TextBoxGENERAR.Location = New System.Drawing.Point(11, 66)
        Me.TextBoxGENERAR.Multiline = True
        Me.TextBoxGENERAR.Name = "TextBoxGENERAR"
        Me.TextBoxGENERAR.Size = New System.Drawing.Size(296, 229)
        Me.TextBoxGENERAR.TabIndex = 100
        Me.TextBoxGENERAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCREAR
        '
        Me.ButtonCREAR.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonCREAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCREAR.ForeColor = System.Drawing.Color.Black
        Me.ButtonCREAR.Location = New System.Drawing.Point(300, 327)
        Me.ButtonCREAR.Name = "ButtonCREAR"
        Me.ButtonCREAR.Size = New System.Drawing.Size(89, 38)
        Me.ButtonCREAR.TabIndex = 1
        Me.ButtonCREAR.Text = "Crear QR"
        Me.ButtonCREAR.UseVisualStyleBackColor = False
        '
        'PictureBoxGENERAR
        '
        Me.PictureBoxGENERAR.BackColor = System.Drawing.Color.Silver
        Me.PictureBoxGENERAR.Location = New System.Drawing.Point(362, 66)
        Me.PictureBoxGENERAR.Name = "PictureBoxGENERAR"
        Me.PictureBoxGENERAR.Size = New System.Drawing.Size(291, 229)
        Me.PictureBoxGENERAR.TabIndex = 2
        Me.PictureBoxGENERAR.TabStop = False
        '
        'ButtonGUARDAR
        '
        Me.ButtonGUARDAR.BackColor = System.Drawing.Color.DarkGray
        Me.ButtonGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGUARDAR.ForeColor = System.Drawing.Color.Black
        Me.ButtonGUARDAR.Location = New System.Drawing.Point(136, 327)
        Me.ButtonGUARDAR.Name = "ButtonGUARDAR"
        Me.ButtonGUARDAR.Size = New System.Drawing.Size(124, 38)
        Me.ButtonGUARDAR.TabIndex = 3
        Me.ButtonGUARDAR.Text = "Guardar"
        Me.ButtonGUARDAR.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton128)
        Me.GroupBox1.Controls.Add(Me.RadioButtonQR)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPDF417)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(386, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 43)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo:"
        '
        'RadioButton128
        '
        Me.RadioButton128.AutoSize = True
        Me.RadioButton128.Location = New System.Drawing.Point(95, 19)
        Me.RadioButton128.Name = "RadioButton128"
        Me.RadioButton128.Size = New System.Drawing.Size(49, 19)
        Me.RadioButton128.TabIndex = 2
        Me.RadioButton128.Text = "128"
        Me.RadioButton128.UseVisualStyleBackColor = True
        '
        'RadioButtonQR
        '
        Me.RadioButtonQR.AutoSize = True
        Me.RadioButtonQR.Checked = True
        Me.RadioButtonQR.Location = New System.Drawing.Point(185, 19)
        Me.RadioButtonQR.Name = "RadioButtonQR"
        Me.RadioButtonQR.Size = New System.Drawing.Size(44, 19)
        Me.RadioButtonQR.TabIndex = 1
        Me.RadioButtonQR.TabStop = True
        Me.RadioButtonQR.Text = "QR"
        Me.RadioButtonQR.UseVisualStyleBackColor = True
        '
        'RadioButtonPDF417
        '
        Me.RadioButtonPDF417.AutoSize = True
        Me.RadioButtonPDF417.Location = New System.Drawing.Point(5, 20)
        Me.RadioButtonPDF417.Name = "RadioButtonPDF417"
        Me.RadioButtonPDF417.Size = New System.Drawing.Size(76, 19)
        Me.RadioButtonPDF417.TabIndex = 0
        Me.RadioButtonPDF417.Text = "PDF417"
        Me.RadioButtonPDF417.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(85, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Datos Completo QR"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(427, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 38)
        Me.Button1.TabIndex = 107
        Me.Button1.Text = "Registro"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(672, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonGUARDAR)
        Me.Controls.Add(Me.ButtonCREAR)
        Me.Controls.Add(Me.TextBoxGENERAR)
        Me.Controls.Add(Me.PictureBoxGENERAR)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormQR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Empleados"
        CType(Me.PictureBoxGENERAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxGENERAR As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCREAR As System.Windows.Forms.Button
    Friend WithEvents PictureBoxGENERAR As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonPDF417 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton128 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonQR As System.Windows.Forms.RadioButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
