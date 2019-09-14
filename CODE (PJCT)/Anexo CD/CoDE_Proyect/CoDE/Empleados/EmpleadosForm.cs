using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Empleados
{
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        { InitializeComponent(); }


        #region TS_Menu

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        { Consultas.ConsultasForm Consultas = new Consultas.ConsultasForm(); Consultas.Show(); this.Close(); }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        { Alumnos.AlumnosForm Alumnos = new Alumnos.AlumnosForm(); Alumnos.Show(); this.Close(); }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en la sección ''Empleados''", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión actual: " + Procesos.SesionDeAdmin.SA + "\n\nHora de inicio de Sesión: " + Procesos.SesionDeAdmin.SH, 
                "Información de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { EmpleadosAgregar AgEmp = new EmpleadosAgregar(); AgEmp.Show(); }
            catch { MessageBox.Show("Ocurrió un error al abrir esta ventana. Verifique que el programa ''Digital Persona One Touch for Windows SDK 1.4.0.1'' esté instalado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void consultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        { EmpleadosConsultar ConsEmp = new EmpleadosConsultar(); ConsEmp.Show(); }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        { EmpleadosConsultar ElimEmp = new EmpleadosConsultar(); ElimEmp.Show(); }

        private void informarDeUnErrorToolStripMenuItem_Click(object sender, EventArgs e)
        { Opciones.InformarError InformarError = new Opciones.InformarError(); InformarError.Show(); }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        { Opciones.AboutForm AcercaDe = new Opciones.AboutForm(); AcercaDe.Show(); }

        private void ayudaAuditivaAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ayudaAuditivaAAToolStripMenuItem.CheckState == CheckState.Unchecked) { btnAA.Visible = false; }
            if (ayudaAuditivaAAToolStripMenuItem.CheckState == CheckState.Checked) { btnAA.Visible = true; }
        }

        #endregion


        private void btnAA_Click(object sender, EventArgs e)
        {
            try
            { string AA = "Buen día, desde aquí puede acceder a las opciones de la sección Empleados..."
                    + "En cada opción estaré para ayudar y especificar más sobre las características, siempre poniendo a su alcanze el Manual de Usuario..."
                    + "...En resumen, en esta opción usted puede agregar nuevos empleados, actualizarlos, consultarlos, o dar de baja a los ya antiguos. Seleccione la opción que desee.";
                SpeechSynthesizer SynthVoz = new SpeechSynthesizer(); SynthVoz.SetOutputToDefaultAudioDevice(); btnAA.Enabled = false; SynthVoz.Volume = 100;
                SynthVoz.SpeakAsync(AA); SynthVoz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SynthVoz_Completed);
            } catch { MessageBox.Show("Error al reproducir el recurso solicitado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SynthVoz_Completed(object sender, SpeakCompletedEventArgs e)
        { btnAA.Enabled = true; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { EmpleadosAgregar AgEmp = new EmpleadosAgregar(); AgEmp.Show(); }
            catch { MessageBox.Show("Ocurrió un error al abrir esta ventana. Verifique que el programa ''Digital Persona One Touch for Windows SDK 1.4.0.1'' esté instalado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        { EmpleadosConsultar ConsEmp = new EmpleadosConsultar(); ConsEmp.Show(); }

        private void btnRegresar_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void EmpleadosForm_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }

        private void EmpleadosForm_MouseMove(object sender, MouseEventArgs e)
        { Procesos.VerficiarSesion(); }
    }
}
