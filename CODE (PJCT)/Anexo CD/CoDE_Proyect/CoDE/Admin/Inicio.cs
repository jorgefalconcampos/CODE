using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CoDE_Proyect
{
    public partial class Inicio : Form
    {
        public Inicio()
        { InitializeComponent(); }


        #region TS_Menu

        private void iniciarSesónToolStripMenuItem_Click(object sender, EventArgs e)
        { Login Logueo = new Login(); Logueo.Show(); this.Hide(); }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Salir;
            Salir = MessageBox.Show("¿Cerrar la aplicación?", "¿Desea salir?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Salir == DialogResult.OK)
            { Application.Exit(); }
        }

        private void verificarConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerificarBDD())
            {
                DialogResult Conexion;
                Conexion = MessageBox.Show("No se pudo conectar con la base de datos. ¿Abrir configuración?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                { if (Conexion == DialogResult.Yes) { CoDE.Opciones.ConexionConfig CC = new CoDE.Opciones.ConexionConfig(); CC.Show(); } }
            } else { MessageBox.Show("Conexión exitosa a la base de datos.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

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
            { string AA = "Buen día, le damos la bienvenida a la aplicación de Control De Estudiantes. Para explorar todas las opciones, inicie sesión..."
                    + ",Puede hacerlo como Administrador y posteriormente añadir a otros administradores quienes gozarán de los privilegios de Administrador..."
                    + ",Si tiene dudas, presione el botón de la Ayuda Auditiva y estaré ahí para ayudar, o si lo prefiere, también puede visitar el Manual de Usuario en línea.";
                SpeechSynthesizer SynthVoz = new SpeechSynthesizer(); SynthVoz.SetOutputToDefaultAudioDevice(); btnAA.Enabled = false; SynthVoz.Volume = 100;
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        { Login Logueo = new Login(); Logueo.Show(); this.Hide(); }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        { Application.Exit(); }

        private void Inicio_Load(object sender, EventArgs e) { }

        private bool VerificarBDD()
        {
            try
            { using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                    try { cnn.Open(); return true; } catch { return false; }
            }
            catch { DialogResult Error; Error = MessageBox.Show("Error al verificar con la base de datos. ¿Abrir configuración?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (Error == DialogResult.Yes) { CoDE.Opciones.ConexionConfig CC = new CoDE.Opciones.ConexionConfig(); CC.Show(); } } return false;
        }
    }
}
