using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Consultas
{
    public partial class ConsultasForm : Form
    {
        public ConsultasForm()
        { InitializeComponent(); }


        #region TS_Menu

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en la sección ''Consultas''.",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        { Alumnos.AlumnosForm Alumnos = new Alumnos.AlumnosForm(); Alumnos.Show(); this.Close(); }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        { Empleados.EmpleadosForm Emp = new Empleados.EmpleadosForm(); Emp.Show(); this.Close(); }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión actual: " + Procesos.SesionDeAdmin.SA + "\n\nHora de inicio de Sesión: " + Procesos.SesionDeAdmin.SH, 
                "Información de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        { Alumnos.AlumnosForm Alum = new Alumnos.AlumnosForm(); Alum.Show(); this.Close(); }

        private void verificarDatosDelAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { VerificarDatos Verif = new VerificarDatos(); Verif.Show(); this.Close(); }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        { Empleados.EmpleadosForm Emp = new Empleados.EmpleadosForm(); Emp.Show(); this.Close(); }

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
            {
                string AA = "Buen día, desde la sección Consultas puede consultar, y, en dado caso., eliminar tanto a alumnos como a empleados..."
                    + "En cada opción estaré para ayudar y especificar más sobre las características, siempre poniendo a su alcanze el Manual de Usuario...";
                SpeechSynthesizer SynthVoz = new SpeechSynthesizer(); SynthVoz.SetOutputToDefaultAudioDevice(); btnAA.Enabled = false; SynthVoz.Volume = 100;
                SynthVoz.SpeakAsync(AA); SynthVoz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SynthVoz_Completed);
            } catch { MessageBox.Show("Error al reproducir el recurso solicitado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SynthVoz_Completed(object sender, SpeakCompletedEventArgs e)
        { btnAA.Enabled = true; }

        private void btnRegresar_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void btnConsultarAlumnos_Click(object sender, EventArgs e)
        { Alumnos.AlumnosConsultar AlumCons = new Alumnos.AlumnosConsultar(); AlumCons.Show(); } 

        private void btnConsultarEmpleados_Click(object sender, EventArgs e)
        { Empleados.EmpleadosConsultar EmpCons = new Empleados.EmpleadosConsultar(); EmpCons.Show(); }

        private void ConsultasForm_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }

        private void ConsultasForm_MouseMove(object sender, MouseEventArgs e)
        { Procesos.VerficiarSesion(); }
    }
}
