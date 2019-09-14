using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace CoDE_Proyect
{
    public partial class Login : Form
    {
        public Login()
        { InitializeComponent(); }

        int intentos = 3;

        private void Login_Load(object sender, EventArgs e)
        { lblNombreSesion.Text = txtAdministrador.Text; lblHora.Text = DateTime.Now.ToShortTimeString(); }


        #region TS_Menu

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { Inicio FormInicio = new Inicio(); FormInicio.Show(); this.Close(); }

        private void informarDeUnErrorToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Opciones.InformarError InformarError = new CoDE.Opciones.InformarError(); InformarError.Show(); }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Opciones.AboutForm AcercaDe = new CoDE.Opciones.AboutForm(); AcercaDe.Show(); }

        private void olvidéMiContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        { CoDE.Opciones.OpcionesContra Pass = new CoDE.Opciones.OpcionesContra(); Pass.Show(); }

        private void ayudaAuditivaAAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ayudaAuditivaAAToolStripMenuItem.CheckState == CheckState.Unchecked) { btnAA.Visible = false; }
            if (ayudaAuditivaAAToolStripMenuItem.CheckState == CheckState.Checked) { btnAA.Visible = true; }
        }

        private void btnAA_Click(object sender, EventArgs e)
        {
            try
            { string AA = "Buen día, acceda a la aplicación y haga uso de sus funciones. Para comenzar inicie sesión..."
                    + "..Puede hacerlo con sus credenciales de Administrador. Si aún no está registrado, comuníquese con algún otro Administrador..."
                    + ",Si necesita ayuda conforme usa la aplicación, presione el botón de la Ayuda Auditiva y estaré ahí para ayudar, o si lo prefiere, puede visitar el Manual de Usuario en línea.";
                SpeechSynthesizer SynthVoz = new SpeechSynthesizer(); SynthVoz.SetOutputToDefaultAudioDevice(); btnAA.Enabled = false; SynthVoz.Volume = 100;
                SynthVoz.SpeakAsync(AA); SynthVoz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SynthVoz_Completed);
            } catch { MessageBox.Show("Error al reproducir el recurso solicitado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion


        private void SynthVoz_Completed(object sender, SpeakCompletedEventArgs e)
        {
            btnAA.Enabled = true;  DialogResult AbrirManual;
            AbrirManual = MessageBox.Show("¿Desea abrir el navegador y consultar el Manual de Usuario?",
                "¿Abrir el Manual de Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AbrirManual == DialogResult.Yes)
            { System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76U0VzSE03V1lYMUE/view?usp=sharing"); } 
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        { Inicio FormInicio = new Inicio(); FormInicio.Show(); this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { txtAdministrador.Text = ""; txtPass.Text = ""; }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                string sConexion = Procesos.CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand("SP_AdminLoguear", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Administrador", SqlDbType.NVarChar, 50).Value = txtAdministrador.Text;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 300).Value = txtPass.Text;
                SqlParameter Param_Resul = new SqlParameter("@Resultado", SqlDbType.Bit);
                Param_Resul.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(Param_Resul);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                bool LogVal = bool.Parse(cmd.Parameters["@Resultado"].Value.ToString());

                if ((LogVal == true) || ((txtAdministrador.Text == CODE.Default.Admin_User) && (txtPass.Text == CODE.Default.Admin_Pass)))
                {
                    MessageBox.Show("Bienvenido " + txtAdministrador.Text + ".", "Inicio de sesión validado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procesos.SesionDeAdmin.SA = txtAdministrador.Text; Procesos.SesionDeAdmin.SH = DateTime.Now.ToShortTimeString();
                    Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close();
                }
                else if ((LogVal == false) || ((txtAdministrador.Text != CODE.Default.Admin_User) && (txtPass.Text != CODE.Default.Admin_Pass)))
                {
                    intentos--; lblIntentos.Text = intentos.ToString("Intentos restantes: " + intentos);
                    MessageBox.Show("Usuario y/o Password incorrectos.", "Usuario no reconocido", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (intentos == 0) { MessageBox.Show("Ha superado la cantidad máxima de intentos.\nLa aplicación se cerrará.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }
            } catch (Exception) { MessageBox.Show("Error al inicar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked == true) { txtPass.UseSystemPasswordChar = false; }
            else { txtPass.UseSystemPasswordChar = true; }
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { CoDE.Opciones.OpcionesContra Pass = new CoDE.Opciones.OpcionesContra(); Pass.Show(); }

        private void iniciarSesiónSinConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Continuar;  Continuar = MessageBox.Show("ATENCIÓN: Esta característica solo está disponible para el Administrador principal. " 
                + "Tenga en cuenta que la mayoría de las características pueden presentar problemas al usarse.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((Continuar == DialogResult.Yes)  && ((txtAdministrador.Text == CODE.Default.Admin_User) && (txtPass.Text == CODE.Default.Admin_Pass)))
            { MessageBox.Show("Bienvenido " + txtAdministrador.Text + ".", "Inicio de sesión validado (sin conexión)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Procesos.SesionDeAdmin.SA = txtAdministrador.Text + " (sin conexión)"; Procesos.SesionDeAdmin.SH = DateTime.Now.ToShortTimeString();
                Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }
            else
            { intentos--; lblIntentos.Text = intentos.ToString("Intentos restantes: " + intentos);
                MessageBox.Show("Usuario y/o Password incorrectos.", "Usuario no reconocido", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            if (intentos == 0)
            { MessageBox.Show("Ha superado la cantidad máxima de intentos.\nLa aplicación se cerrará.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }
        }
    }
}
