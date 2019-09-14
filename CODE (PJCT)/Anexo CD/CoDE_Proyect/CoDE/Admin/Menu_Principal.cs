using System;
using System.Speech.Synthesis;
using System.Windows.Forms;


namespace CoDE_Proyect
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        { InitializeComponent(); }

        private void Menu_Principal_Load(object sender, EventArgs e)
        { lblNombreSesion.Text = Procesos.SesionDeAdmin.SA; lblHora.Text = Procesos.SesionDeAdmin.SH; }


        #region TS_Menu

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en el Menú Principal.",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Consultas.ConsultasForm Cons = new CoDE.Consultas.ConsultasForm(); Cons.Show(); this.Close(); }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        { CoDE.Alumnos.AlumnosForm Alum = new CoDE.Alumnos.AlumnosForm(); Alum.Show(); this.Close(); }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        { CoDE.Empleados.EmpleadosForm Emp = new CoDE.Empleados.EmpleadosForm(); Emp.Show(); this.Close(); }

        private void contraseñaToolStripMenuItem1_Click(object sender, EventArgs e)
        { CoDE.Opciones.OpcionesContra Pass = new CoDE.Opciones.OpcionesContra(); Pass.Show(); }

        private void configuraciónDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Opciones.ConfigForm Config = new CoDE.Opciones.ConfigForm(); Config.Show(); }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Sesión actual: " + Procesos.SesionDeAdmin.SA + "\n\nHora de inicio de Sesión: " + Procesos.SesionDeAdmin.SH,  
            "Información de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Admin.AdminAgregar NuevoAdmin = new CoDE.Admin.AdminAgregar(); NuevoAdmin.Show(); }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Admin.AdminConsulta ConsultarAdmin = new CoDE.Admin.AdminConsulta(); ConsultarAdmin.Show(); }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Admin.AdminConsulta EliminarAdminCons = new CoDE.Admin.AdminConsulta(); EliminarAdminCons.Show(); }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Alumnos.AlumnosForm Alum = new CoDE.Alumnos.AlumnosForm(); Alum.Show(); this.Close(); }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Empleados.EmpleadosForm Emp = new CoDE.Empleados.EmpleadosForm(); Emp.Show(); this.Close(); }

        private void informarDeUnErrorToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Opciones.InformarError InformarError = new CoDE.Opciones.InformarError(); InformarError.Show(); }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Opciones.AboutForm AcercaDe = new CoDE.Opciones.AboutForm(); AcercaDe.Show(); }

        private void ayudaAuditivaAAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ayudaAuditivaAAToolStripMenuItem.CheckState == CheckState.Unchecked) { btnAA.Visible = false; }
            if (ayudaAuditivaAAToolStripMenuItem.CheckState == CheckState.Checked) { btnAA.Visible = true; }
        }

        #endregion


        private void btnAA_Click(object sender, EventArgs e)
        {
            try
            { string AA = "Buen día, este es el Menú Principal, el punto de encuentro de las principales funciones de la aplicación."
                    + "..Puede explorar las opciones de Administrador en el menú superior... o puede ir directamente al apartado de consultas, alumnos o empleados..."
                    + "..También puede ir a la sección de contacto y enviarnos un Email que con gusto leeremos..."
                    + "..Seleccione la opción que desee, en cada una de ellas estaré para ayudar, siempre poniendo a su alcanze el Manual de Usuario...";
                              SpeechSynthesizer SynthVoz = new SpeechSynthesizer();
                SynthVoz.SetOutputToDefaultAudioDevice(); btnAA.Enabled = false; SynthVoz.Volume = 100;
                SynthVoz.SpeakAsync(AA); SynthVoz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SynthVoz_Completed);
            } catch { MessageBox.Show("Error al reproducir el recurso solicitado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SynthVoz_Completed(object sender, SpeakCompletedEventArgs e)
        {
            btnAA.Enabled = true; DialogResult AbrirManual;
            AbrirManual = MessageBox.Show("¿Desea abrir el navegador y consultar el Manual de Usuario?",
                "¿Abrir el Manual de Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AbrirManual == DialogResult.Yes)
            { System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76U0VzSE03V1lYMUE/view?usp=sharing"); }  
        }


        #region IMG

        private void ImgEngrane_Click(object sender, EventArgs e)
        { CoDE.Opciones.AboutForm AcercaDe = new CoDE.Opciones.AboutForm(); AcercaDe.Show(); }

        private void ImgInicio_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en el Menú Principal.",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void ContHome_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en el Menú Principal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void ImgCons_Click(object sender, EventArgs e)
        { CoDE.Consultas.ConsultasForm Cons = new CoDE.Consultas.ConsultasForm(); Cons.Show(); this.Close(); }

        private void ContCons_Click(object sender, EventArgs e)
        { CoDE.Consultas.ConsultasForm Cons = new CoDE.Consultas.ConsultasForm(); Cons.Show(); this.Close(); }

        private void ImgAlum_Click(object sender, EventArgs e)
        { CoDE.Alumnos.AlumnosForm Alum = new CoDE.Alumnos.AlumnosForm(); Alum.Show(); this.Close(); }

        private void ContAlum_Click(object sender, EventArgs e)
        { CoDE.Alumnos.AlumnosForm Alum = new CoDE.Alumnos.AlumnosForm(); Alum.Show(); this.Close(); }

        private void ImgEmp_Click(object sender, EventArgs e)
        { CoDE.Empleados.EmpleadosForm Emp = new CoDE.Empleados.EmpleadosForm(); Emp.Show(); this.Close(); }

        private void ContEmp_Click(object sender, EventArgs e)
        { CoDE.Empleados.EmpleadosForm Emp = new CoDE.Empleados.EmpleadosForm(); Emp.Show(); this.Close(); }

        private void ImgContac_Click(object sender, EventArgs e)
        { CoDE.Opciones.Contacto Cont = new CoDE.Opciones.Contacto(); Cont.Show(); }

        private void ContContac_Click(object sender, EventArgs e)
        { CoDE.Opciones.Contacto Cont = new CoDE.Opciones.Contacto(); Cont.Show(); }

        #endregion


        private void ImgLogout_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void Menu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }

        private void Menu_Principal_MouseMove(object sender, MouseEventArgs e)
        { Procesos.VerficiarSesion(); }
    }
}
