<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnguardar.Location = New System.Drawing.Point(75, 378)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(109, 41)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnactualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnactualizar.Location = New System.Drawing.Point(215, 378)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(122, 41)
        Me.btnactualizar.TabIndex = 1
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btneliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btneliminar.Location = New System.Drawing.Point(376, 378)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(124, 41)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnmostrar
        '
        Me.btnmostrar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnmostrar.Location = New System.Drawing.Point(376, 173)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(262, 32)
        Me.btnmostrar.TabIndex = 3
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtid.ForeColor = System.Drawing.Color.Black
        Me.txtid.Location = New System.Drawing.Point(75, 182)
        Me.txtid.Name = "txtid"
        Me.txtid.PlaceholderText = "ID CLIENTE"
        Me.txtid.Size = New System.Drawing.Size(262, 23)
        Me.txtid.TabIndex = 4
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtdireccion.ForeColor = System.Drawing.Color.Black
        Me.txtdireccion.Location = New System.Drawing.Point(75, 277)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.PlaceholderText = "DIRECCION"
        Me.txtdireccion.Size = New System.Drawing.Size(262, 23)
        Me.txtdireccion.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(376, 330)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PlaceholderText = "EMAIL"
        Me.txtemail.Size = New System.Drawing.Size(262, 23)
        Me.txtemail.TabIndex = 8
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(75, 231)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PlaceholderText = "NOMBRE CLIENTE"
        Me.txtnombre.Size = New System.Drawing.Size(262, 23)
        Me.txtnombre.TabIndex = 9
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txttelefono.ForeColor = System.Drawing.Color.Black
        Me.txttelefono.Location = New System.Drawing.Point(75, 330)
        Me.txttelefono.Mask = "0000-0000"
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(262, 23)
        Me.txttelefono.TabIndex = 10
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtapellido.ForeColor = System.Drawing.Color.Black
        Me.txtapellido.Location = New System.Drawing.Point(376, 231)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.PlaceholderText = "APELLIDO CLIENTE"
        Me.txtapellido.Size = New System.Drawing.Size(262, 23)
        Me.txtapellido.TabIndex = 11
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnlimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlimpiar.Location = New System.Drawing.Point(522, 378)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(116, 41)
        Me.btnlimpiar.TabIndex = 12
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(300, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 134)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(75, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "NOMBRE CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(376, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "APELLIDO  CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(75, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "DIRECCION CLIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(376, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "FECHA NACIMIENTO CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(376, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "EMAIL CLIENTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(75, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "TELEFONO CLIENTE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(75, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ID CLIENTE"
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txtfecha.Location = New System.Drawing.Point(376, 284)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(262, 23)
        Me.txtfecha.TabIndex = 21
        Me.txtfecha.ValidatingType = GetType(Date)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(714, 457)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TiendaRony"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnguardar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttelefono As MaskedTextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfecha As MaskedTextBox
End Class
