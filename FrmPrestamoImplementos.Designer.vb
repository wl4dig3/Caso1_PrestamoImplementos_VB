' Este archivo contiene la definición visual y normalmente es mantenido por Visual Studio.
Namespace PRO205.Semana7.Caso1.PrestamoImplementos.VB
    ' Marca esta parte de la clase como código asociado al diseñador.
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmPrestamoImplementos
        ' Contenedor de componentes no visuales.
        Private components As System.ComponentModel.IContainer

        ' Libera recursos administrados.
        Protected Overrides Sub Dispose(disposing As Boolean)
            ' Verifica si corresponde liberar componentes.
            If disposing AndAlso components IsNot Nothing Then
                ' Libera el contenedor.
                components.Dispose()
            End If
            ' Permite que Form libere sus recursos.
            MyBase.Dispose(disposing)
        End Sub

        ' Construye los controles, define propiedades y deja los objetos disponibles para la lógica.
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            layoutMain = New System.Windows.Forms.TableLayoutPanel()
            lblTitulo = New System.Windows.Forms.Label()
            lblNombre = New System.Windows.Forms.Label()
            txtNombre = New System.Windows.Forms.TextBox()
            lblImplemento = New System.Windows.Forms.Label()
            cboImplemento = New System.Windows.Forms.ComboBox()
            lblCantidad = New System.Windows.Forms.Label()
            nudCantidad = New System.Windows.Forms.NumericUpDown()
            lblDevolucion = New System.Windows.Forms.Label()
            dtpDevolucion = New System.Windows.Forms.DateTimePicker()
            chkAceptaResponsabilidad = New System.Windows.Forms.CheckBox()
            lblResumen = New System.Windows.Forms.Label()
            panelBotones = New System.Windows.Forms.FlowLayoutPanel()
            btnRegistrar = New System.Windows.Forms.Button()
            btnLimpiar = New System.Windows.Forms.Button()
            lblRegistros = New System.Windows.Forms.Label()
            lstPrestamos = New System.Windows.Forms.ListBox()
            lblEstado = New System.Windows.Forms.Label()
            errorProvider = New System.Windows.Forms.ErrorProvider(components)
            layoutMain.SuspendLayout()
            CType(nudCantidad, ComponentModel.ISupportInitialize).BeginInit()
            panelBotones.SuspendLayout()
            CType(errorProvider, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' layoutMain
            ' 
            layoutMain.ColumnCount = 2
            layoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F))
            layoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            layoutMain.Controls.Add(lblTitulo, 0, 0)
            layoutMain.Controls.Add(lblNombre, 0, 1)
            layoutMain.Controls.Add(txtNombre, 1, 1)
            layoutMain.Controls.Add(lblImplemento, 0, 2)
            layoutMain.Controls.Add(cboImplemento, 1, 2)
            layoutMain.Controls.Add(lblCantidad, 0, 3)
            layoutMain.Controls.Add(nudCantidad, 1, 3)
            layoutMain.Controls.Add(lblDevolucion, 0, 4)
            layoutMain.Controls.Add(dtpDevolucion, 1, 4)
            layoutMain.Controls.Add(chkAceptaResponsabilidad, 1, 5)
            layoutMain.Controls.Add(lblResumen, 0, 6)
            layoutMain.Controls.Add(panelBotones, 1, 7)
            layoutMain.Controls.Add(lblRegistros, 0, 8)
            layoutMain.Controls.Add(lstPrestamos, 0, 9)
            layoutMain.Dock = System.Windows.Forms.DockStyle.Fill
            layoutMain.Location = New System.Drawing.Point(0, 0)
            layoutMain.Name = "layoutMain"
            layoutMain.Padding = New System.Windows.Forms.Padding(18)
            layoutMain.RowCount = 10
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.Size = New System.Drawing.Size(760, 521)
            layoutMain.TabIndex = 0
            ' 
            ' lblTitulo
            ' 
            lblTitulo.AutoSize = True
            layoutMain.SetColumnSpan(lblTitulo, 2)
            lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16F, Drawing.FontStyle.Bold)
            lblTitulo.Location = New System.Drawing.Point(21, 21)
            lblTitulo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 14)
            lblTitulo.Name = "lblTitulo"
            lblTitulo.Size = New System.Drawing.Size(493, 30)
            lblTitulo.TabIndex = 0
            lblTitulo.Text = "Caso 1 - Préstamo de implementos deportivos"
            ' 
            ' lblNombre
            ' 
            lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblNombre.AutoSize = True
            lblNombre.Location = New System.Drawing.Point(21, 71)
            lblNombre.Name = "lblNombre"
            lblNombre.Size = New System.Drawing.Size(88, 19)
            lblNombre.TabIndex = 1
            lblNombre.Text = "Responsable:"
            ' 
            ' txtNombre
            ' 
            txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
            txtNombre.Location = New System.Drawing.Point(191, 68)
            txtNombre.MaxLength = 60
            txtNombre.Name = "txtNombre"
            txtNombre.Size = New System.Drawing.Size(548, 25)
            txtNombre.TabIndex = 2
            ' 
            ' lblImplemento
            ' 
            lblImplemento.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblImplemento.AutoSize = True
            lblImplemento.Location = New System.Drawing.Point(21, 102)
            lblImplemento.Name = "lblImplemento"
            lblImplemento.Size = New System.Drawing.Size(86, 19)
            lblImplemento.TabIndex = 3
            lblImplemento.Text = "Implemento:"
            ' 
            ' cboImplemento
            ' 
            cboImplemento.Dock = System.Windows.Forms.DockStyle.Fill
            cboImplemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboImplemento.Location = New System.Drawing.Point(191, 99)
            cboImplemento.Name = "cboImplemento"
            cboImplemento.Size = New System.Drawing.Size(548, 25)
            cboImplemento.TabIndex = 4
            ' 
            ' lblCantidad
            ' 
            lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblCantidad.AutoSize = True
            lblCantidad.Location = New System.Drawing.Point(21, 133)
            lblCantidad.Name = "lblCantidad"
            lblCantidad.Size = New System.Drawing.Size(67, 19)
            lblCantidad.TabIndex = 5
            lblCantidad.Text = "Cantidad:"
            ' 
            ' nudCantidad
            ' 
            nudCantidad.Location = New System.Drawing.Point(191, 130)
            nudCantidad.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            nudCantidad.Name = "nudCantidad"
            nudCantidad.Size = New System.Drawing.Size(100, 25)
            nudCantidad.TabIndex = 6
            nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
            ' 
            ' lblDevolucion
            ' 
            lblDevolucion.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblDevolucion.AutoSize = True
            lblDevolucion.Location = New System.Drawing.Point(21, 164)
            lblDevolucion.Name = "lblDevolucion"
            lblDevolucion.Size = New System.Drawing.Size(117, 19)
            lblDevolucion.TabIndex = 7
            lblDevolucion.Text = "Fecha devolución:"
            ' 
            ' dtpDevolucion
            ' 
            dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short
            dtpDevolucion.Location = New System.Drawing.Point(191, 161)
            dtpDevolucion.Name = "dtpDevolucion"
            dtpDevolucion.Size = New System.Drawing.Size(200, 25)
            dtpDevolucion.TabIndex = 8
            ' 
            ' chkAceptaResponsabilidad
            ' 
            chkAceptaResponsabilidad.AutoSize = True
            chkAceptaResponsabilidad.Location = New System.Drawing.Point(191, 192)
            chkAceptaResponsabilidad.Name = "chkAceptaResponsabilidad"
            chkAceptaResponsabilidad.Size = New System.Drawing.Size(381, 23)
            chkAceptaResponsabilidad.TabIndex = 9
            chkAceptaResponsabilidad.Text = "Declaro que devolveré el implemento en la fecha indicada."
            ' 
            ' lblResumen
            ' 
            lblResumen.AutoSize = True
            layoutMain.SetColumnSpan(lblResumen, 2)
            lblResumen.Location = New System.Drawing.Point(21, 218)
            lblResumen.Name = "lblResumen"
            lblResumen.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
            lblResumen.Size = New System.Drawing.Size(68, 35)
            lblResumen.TabIndex = 10
            lblResumen.Text = "Resumen:"
            ' 
            ' panelBotones
            ' 
            panelBotones.AutoSize = True
            panelBotones.Controls.Add(btnRegistrar)
            panelBotones.Controls.Add(btnLimpiar)
            panelBotones.Location = New System.Drawing.Point(191, 256)
            panelBotones.Name = "panelBotones"
            panelBotones.Size = New System.Drawing.Size(222, 35)
            panelBotones.TabIndex = 11
            ' 
            ' btnRegistrar
            ' 
            btnRegistrar.AutoSize = True
            btnRegistrar.Location = New System.Drawing.Point(3, 3)
            btnRegistrar.Name = "btnRegistrar"
            btnRegistrar.Size = New System.Drawing.Size(135, 29)
            btnRegistrar.TabIndex = 0
            btnRegistrar.Text = "Registrar préstamo"
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.AutoSize = True
            btnLimpiar.Location = New System.Drawing.Point(144, 3)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New System.Drawing.Size(75, 29)
            btnLimpiar.TabIndex = 1
            btnLimpiar.Text = "Limpiar"
            ' 
            ' lblRegistros
            ' 
            lblRegistros.AutoSize = True
            layoutMain.SetColumnSpan(lblRegistros, 2)
            lblRegistros.Location = New System.Drawing.Point(21, 294)
            lblRegistros.Name = "lblRegistros"
            lblRegistros.Size = New System.Drawing.Size(238, 19)
            lblRegistros.TabIndex = 12
            lblRegistros.Text = "Préstamos registrados en esta sesión:"
            ' 
            ' lstPrestamos
            ' 
            layoutMain.SetColumnSpan(lstPrestamos, 2)
            lstPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
            lstPrestamos.ItemHeight = 17
            lstPrestamos.Location = New System.Drawing.Point(21, 316)
            lstPrestamos.Name = "lstPrestamos"
            lstPrestamos.Size = New System.Drawing.Size(718, 186)
            lstPrestamos.TabIndex = 13
            ' 
            ' lblEstado
            ' 
            lblEstado.AutoSize = True
            lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom
            lblEstado.Location = New System.Drawing.Point(0, 521)
            lblEstado.Name = "lblEstado"
            lblEstado.Padding = New System.Windows.Forms.Padding(18, 8, 18, 12)
            lblEstado.Size = New System.Drawing.Size(86, 39)
            lblEstado.TabIndex = 1
            lblEstado.Text = "Estado"
            ' 
            ' errorProvider
            ' 
            errorProvider.ContainerControl = Me
            ' 
            ' FrmPrestamoImplementos
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(7F, 17F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(760, 560)
            Controls.Add(layoutMain)
            Controls.Add(lblEstado)
            Font = New System.Drawing.Font("Segoe UI", 10F)
            MinimumSize = New System.Drawing.Size(700, 520)
            Name = "FrmPrestamoImplementos"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "[PRO205] Caso 1: Préstamo de implementos"
            layoutMain.ResumeLayout(False)
            layoutMain.PerformLayout()
            CType(nudCantidad, ComponentModel.ISupportInitialize).EndInit()
            panelBotones.ResumeLayout(False)
            panelBotones.PerformLayout()
            CType(errorProvider, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        ' Declara los controles; WithEvents permite usar Handles en el archivo de lógica.
        Private layoutMain As System.Windows.Forms.TableLayoutPanel
        Private lblTitulo As System.Windows.Forms.Label
        Private lblNombre As System.Windows.Forms.Label
        Private WithEvents txtNombre As System.Windows.Forms.TextBox
        Private lblImplemento As System.Windows.Forms.Label
        Private WithEvents cboImplemento As System.Windows.Forms.ComboBox
        Private lblCantidad As System.Windows.Forms.Label
        Private WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
        Private lblDevolucion As System.Windows.Forms.Label
        Private WithEvents dtpDevolucion As System.Windows.Forms.DateTimePicker
        Private WithEvents chkAceptaResponsabilidad As System.Windows.Forms.CheckBox
        Private lblResumen As System.Windows.Forms.Label
        Private panelBotones As System.Windows.Forms.FlowLayoutPanel
        Private WithEvents btnRegistrar As System.Windows.Forms.Button
        Private WithEvents btnLimpiar As System.Windows.Forms.Button
        Private lblRegistros As System.Windows.Forms.Label
        Private lstPrestamos As System.Windows.Forms.ListBox
        Private lblEstado As System.Windows.Forms.Label
        Private errorProvider As System.Windows.Forms.ErrorProvider
    End Class
End Namespace
