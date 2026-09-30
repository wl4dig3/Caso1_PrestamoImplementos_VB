' Importa el atributo STAThread y tipos base del runtime.
Imports System
' Importa Application, que administra el ciclo de vida de Windows Forms.
Imports System.Windows.Forms

' Define un espacio de nombres único para este proyecto.
Namespace PRO205.Semana7.Caso1.PrestamoImplementos.VB
    ' Un Module permite declarar un punto de entrada sin crear una instancia de Program.
    Friend Module Program
        ' Windows Forms utiliza un hilo STA para interoperar correctamente con Windows.
        ' Método que se ejecuta al iniciar el proyecto.
        Public Sub Main()
            ' Habilita estilos visuales del sistema operativo.
            Application.EnableVisualStyles()
            ' Mantiene el comportamiento moderno de renderizado de texto.
            Application.SetCompatibleTextRenderingDefault(False)
            ' Crea el formulario principal e inicia el ciclo de mensajes.
            Application.Run(New FrmPrestamoImplementos())
        End Sub
    End Module
End Namespace
