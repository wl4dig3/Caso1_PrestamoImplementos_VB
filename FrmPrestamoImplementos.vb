' Importa DateTime, EventArgs y tipos base de .NET.
Imports System
' Importa Form, MessageBox y demás controles de Windows Forms.
Imports System.Windows.Forms

' Agrupa las clases del Caso 1.
Namespace PRO205.Semana7.Caso1.PrestamoImplementos.VB
    ' Define el formulario principal y hereda el comportamiento de Form.
    <System.ComponentModel.DesignerCategory("Form")>
    Public Partial Class FrmPrestamoImplementos
        Inherits Form

        ' Constructor: se ejecuta cuando se crea una instancia del formulario.
        Public Sub New()
            ' Construye y configura los controles definidos en el archivo Designer.
            InitializeComponent()
        End Sub

        ' Evento del sistema Load: ocurre cuando el formulario termina de cargarse.
        Private Sub FrmPrestamoImplementos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Carga alternativas simples en el ComboBox.
            cboImplemento.Items.AddRange(New Object() {"Balón de fútbol", "Raqueta de tenis", "Set de conos", "Petos deportivos"})
            ' Impide seleccionar una fecha anterior al día actual.
            dtpDevolucion.MinDate = DateTime.Today
            ' Sugiere inicialmente el día siguiente.
            dtpDevolucion.Value = DateTime.Today.AddDays(1)
            ' Establece una unidad como cantidad inicial.
            nudCantidad.Value = 1D
            ' Muestra una instrucción al usuario.
            lblEstado.Text = "Complete los datos del préstamo."
            ' Construye el primer resumen.
            ActualizarResumen()
        End Sub

        ' Evento de usuario: cambia cuando el usuario escribe el nombre.
        Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
            ' Refresca el resumen inmediatamente.
            ActualizarResumen()
        End Sub

        ' Evento de usuario: cambia al seleccionar otro implemento.
        Private Sub cboImplemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImplemento.SelectedIndexChanged
            ' Refresca el resumen con la nueva selección.
            ActualizarResumen()
        End Sub

        ' Evento de usuario: cambia al modificar la cantidad.
        Private Sub nudCantidad_ValueChanged(sender As Object, e As EventArgs) Handles nudCantidad.ValueChanged
            ' Refresca el resumen con la nueva cantidad.
            ActualizarResumen()
        End Sub

        ' Evento de usuario: cambia al modificar la fecha.
        Private Sub dtpDevolucion_ValueChanged(sender As Object, e As EventArgs) Handles dtpDevolucion.ValueChanged
            ' Refresca el resumen con la fecha seleccionada.
            ActualizarResumen()
        End Sub

        ' Evento de usuario: cambia al marcar o desmarcar la casilla.
        Private Sub chkAceptaResponsabilidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkAceptaResponsabilidad.CheckedChanged
            ' Refresca el resumen con el estado de aceptación.
            ActualizarResumen()
        End Sub

        ' Método auxiliar para construir el resumen en un solo lugar.
        Private Sub ActualizarResumen()
            ' Usa un texto alternativo cuando todavía no existe un nombre válido.
            Dim nombre As String = If(String.IsNullOrWhiteSpace(txtNombre.Text), "(sin nombre)", txtNombre.Text.Trim())
            ' Usa un texto alternativo cuando todavía no existe un implemento seleccionado.
            Dim implemento As String = If(cboImplemento.SelectedItem Is Nothing, "(sin implemento)", cboImplemento.SelectedItem.ToString())
            ' Convierte el valor Boolean del CheckBox a una palabra legible.
            Dim aceptacion As String = If(chkAceptaResponsabilidad.Checked, "sí", "no")
            ' Presenta la información capturada en una sola frase.
            lblResumen.Text = $"Resumen: {nombre} · {implemento} · Cantidad {nudCantidad.Value} · Devuelve {dtpDevolucion.Value:dd-MM-yyyy} · Responsabilidad: {aceptacion}."
        End Sub

        ' Evento de usuario: clic en Registrar préstamo.
        Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
            ' Ejecuta las reglas y detiene el proceso si existe alguna causa de error.
            If Not ValidarFormulario() Then
                ' Finaliza el manejador sin agregar un registro.
                Return
            End If

            ' Crea un texto con los datos que ya fueron validados.
            Dim registro As String = $"{DateTime.Now:HH:mm} | {txtNombre.Text.Trim()} | {cboImplemento.SelectedItem} | Cant.: {nudCantidad.Value} | Dev.: {dtpDevolucion.Value:dd-MM-yyyy}"
            ' Agrega el registro al ListBox.
            lstPrestamos.Items.Add(registro)
            ' Informa el resultado en la zona de estado.
            lblEstado.Text = "Préstamo registrado correctamente."
            ' Entrega retroalimentación mediante una ventana modal.
            MessageBox.Show("El préstamo fue registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Prepara el formulario para un nuevo registro.
            LimpiarFormulario()
        End Sub

        ' Método que identifica las causas que impiden registrar el préstamo.
        Private Function ValidarFormulario() As Boolean
            ' Elimina mensajes de una validación anterior.
            errorProvider.Clear()
            ' Parte suponiendo que el formulario es válido.
            Dim esValido As Boolean = True

            ' Verifica el requerimiento: responsable obligatorio.
            If String.IsNullOrWhiteSpace(txtNombre.Text) Then
                ' Asocia la causa directamente al TextBox.
                errorProvider.SetError(txtNombre, "Debe ingresar el nombre de quien solicita el préstamo.")
                ' Marca el resultado global como inválido.
                esValido = False
            End If

            ' Verifica el requerimiento: implemento obligatorio.
            If cboImplemento.SelectedIndex < 0 Then
                ' Asocia la causa al ComboBox.
                errorProvider.SetError(cboImplemento, "Seleccione un implemento.")
                ' Marca el resultado global como inválido.
                esValido = False
            End If
        // Verifica la cantidad máxima permitida de acuerso a la regla de negocio.
            If nudCantidad.Value > 5D Then
                Dim mensajeCantidad As String = "la cantidad máxima permitida es de 5 implementos"
                errorProvider.SetError(nudCantidad, mensajeCantidad)
                MessageBox.Show(mensajeCantidad, "Cantidad máxima excedida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                esValido = False
            End If

            ' Verifica que la fecha de devolución no quede en el pasado.
            If dtpDevolucion.Value.Date < DateTime.Today Then
                ' Explica la causa en el control de fecha.
                errorProvider.SetError(dtpDevolucion, "La fecha de devolución no puede ser anterior a hoy.")
                ' Marca el resultado global como inválido.
                esValido = False
            End If

            ' Verifica la aceptación de responsabilidad.
            If Not chkAceptaResponsabilidad.Checked Then
                ' Explica que la casilla es obligatoria.
                errorProvider.SetError(chkAceptaResponsabilidad, "Debe aceptar la responsabilidad por el implemento.")
                ' Marca el resultado global como inválido.
                esValido = False
            End If

            ' Evalúa si se detectó al menos un problema.
            If Not esValido Then
                ' Orienta al usuario a revisar los controles marcados.
                lblEstado.Text = "No se puede registrar: revise los campos marcados con error."
            End If

            ' Devuelve True solo cuando todas las reglas se cumplen.
            Return esValido
        End Function

        ' Evento de usuario: clic en Limpiar.
        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            ' Restablece los controles.
            LimpiarFormulario()
            ' Informa la acción realizada.
            lblEstado.Text = "Formulario limpio. Puede ingresar un nuevo préstamo."
        End Sub

        ' Método reutilizable que devuelve los controles al estado inicial.
        Private Sub LimpiarFormulario()
            ' Elimina mensajes de error visibles.
            errorProvider.Clear()
            ' Vacía el nombre.
            txtNombre.Clear()
            ' Quita la selección de implemento.
            cboImplemento.SelectedIndex = -1
            ' Restablece la cantidad.
            nudCantidad.Value = 1D
            ' Restablece la fecha sugerida.
            dtpDevolucion.Value = DateTime.Today.AddDays(1)
            ' Desmarca la aceptación.
            chkAceptaResponsabilidad.Checked = False
            ' Devuelve el foco al primer campo.
            txtNombre.Focus()
            ' Actualiza el resumen.
            ActualizarResumen()
        End Sub

        ' Evento del sistema FormClosing: ocurre cuando la ventana intenta cerrarse.
        Private Sub FrmPrestamoImplementos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ' Detecta si existe información que aún no fue registrada.
            Dim hayDatosPendientes As Boolean = Not String.IsNullOrWhiteSpace(txtNombre.Text) OrElse cboImplemento.SelectedIndex >= 0 OrElse chkAceptaResponsabilidad.Checked
            ' Solo pregunta cuando existe información potencialmente perdida.
            If hayDatosPendientes Then
                ' Solicita confirmación al usuario.
                Dim respuesta As DialogResult = MessageBox.Show("Hay datos sin registrar. ¿Desea cerrar de todas formas?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                ' Cancela el cierre cuando la respuesta es No.
                e.Cancel = respuesta = DialogResult.No
            End If
        End Sub
    End Class
End Namespace
