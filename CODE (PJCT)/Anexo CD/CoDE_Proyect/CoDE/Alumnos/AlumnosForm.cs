using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Alumnos
{
    public partial class AlumnosForm : Form
    {
        public AlumnosForm()
        { InitializeComponent(); }


        #region TS_Menu

        private void verificarDatosDelAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { Consultas.VerificarDatos Verif = new Consultas.VerificarDatos(); Verif.Show(); this.Close(); }

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        { Consultas.ConsultasForm Consultas = new Consultas.ConsultasForm(); Consultas.Show(); this.Close(); }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en la sección ''Alumnos''.",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        { Empleados.EmpleadosForm Emp = new Empleados.EmpleadosForm(); Emp.Show(); this.Close(); }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión actual: " + Procesos.SesionDeAdmin.SA + "\n\nHora de inicio de Sesión: " + Procesos.SesionDeAdmin.SH,
               "Información de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { AlumnosAgregar AgAlum = new AlumnosAgregar(); AgAlum.Show(); }
            catch { MessageBox.Show("Ocurrió un error al abrir esta ventana. Verifique que el programa ''Digital Persona One Touch for Windows SDK 1.4.0.1'' esté instalado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void consultarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { AlumnosConsultar ConsAlum = new AlumnosConsultar(); ConsAlum.Show(); }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { AlumnosConsultar ElimAlum = new AlumnosConsultar(); ElimAlum.Show(); }

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
            { string AA = "Buen día, desde aquí puede acceder a las opciones de la sección Alumnos..."
                    + "En cada opción estaré para ayudar y especificar más sobre las características, siempre poniendo a su alcanze el Manual de Usuario..."
                    + "...En resumen, en esta opción usted puede agregar nuevos alumnos, actualizarlos, consultarlos, o dar de baja a los ya antiguos. Seleccione la opción que desee.";
                SpeechSynthesizer SynthVoz = new SpeechSynthesizer(); SynthVoz.SetOutputToDefaultAudioDevice(); btnAA.Enabled = false; SynthVoz.Volume = 100;
                SynthVoz.SpeakAsync(AA); SynthVoz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SynthVoz_Completed);
            } catch { MessageBox.Show("Error al reproducir el recurso solicitado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SynthVoz_Completed(object sender, SpeakCompletedEventArgs e)
        { btnAA.Enabled = true; }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { AlumnosAgregar AgAlum = new AlumnosAgregar(); AgAlum.Show(); }
            catch { MessageBox.Show("Ocurrió un error al abrir esta ventana. Verifique que el programa ''Digital Persona One Touch for Windows SDK 1.4.0.1'' esté instalado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        { AlumnosConsultar ConsAlum = new AlumnosConsultar(); ConsAlum.Show(); }

        private void btnRegresar_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }
      
        private void AlumnosForm_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }

        private void AlumnosForm_MouseMove(object sender, MouseEventArgs e)
        { Procesos.VerficiarSesion(); }
    }
}
