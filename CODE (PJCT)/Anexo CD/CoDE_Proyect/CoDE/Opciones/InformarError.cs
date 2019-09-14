using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;


namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class InformarError : Form
    {
        public InformarError()
        { InitializeComponent(); }

        private void InformarError_Load(object sender, EventArgs e)
        { txtUsuarioErr.Text = Procesos.SesionDeAdmin.SA; }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { txtUsuarioErr.Text = "";txtCorreoErr.Text = ""; cbPosErr.SelectedIndex = -1; txtDesc.Text = ""; }

        private bool Errores()
        {
            try
            {
                if (txtUsuarioErr.Text.Trim() == String.Empty) return true;
                if (txtCorreoErr.Text.Trim() == String.Empty) return true;
                if ((cbPosErr.SelectedItem.ToString() != "Base de Datos") &&
                    (cbPosErr.SelectedItem.ToString() != "Errores lógicos") &&
                    (cbPosErr.SelectedItem.ToString() != "Fallas del sistema") &&
                    (cbPosErr.SelectedItem.ToString() != "Lector de huella") &&
                    (cbPosErr.SelectedItem.ToString() != "Programación") &&
                    (cbPosErr.SelectedItem.ToString() != "Otros") &&
                    (cbPosErr.SelectedItem.ToString() != "No creo saberlo..."))
                    return true;
                if (txtDesc.Text == String.Empty) return true;
            } 
            catch (Exception) { MessageBox.Show("Parámetro incorrecto.", "Error", MessageBoxButtons.OK); } return false;
        }

        private void btnEnviarInforme_Click(object sender, EventArgs e)
        {
            try
            {
               if (Errores())
                { MessageBox.Show("Faltan datos, su informe no pudo ser enviado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                else
                {
                    try
                    {
                        Procesos Correo = new Procesos();

                        MailMessage DestinoAdmin = new MailMessage();
                        DestinoAdmin.To.Add(new MailAddress(CODE.Default.Email_User));
                        DestinoAdmin.Subject = "De " + txtUsuarioErr.Text + ": Informe de error en la aplicación.";
                        DestinoAdmin.SubjectEncoding = Encoding.UTF8;
                        DestinoAdmin.From = new MailAddress(CODE.Default.Email_User, "CODE");
                        DestinoAdmin.BodyEncoding = Encoding.UTF8;
                        DestinoAdmin.IsBodyHtml = false;

                        MailMessage DestinoUsuario = new MailMessage();
                        DestinoUsuario.To.Add(new MailAddress(txtCorreoErr.Text));
                        DestinoUsuario.Subject = "Error en la aplicación.";
                        DestinoUsuario.SubjectEncoding = Encoding.UTF8;
                        DestinoUsuario.From = new MailAddress(CODE.Default.Email_User, "CODE - Informe de Errores");
                        DestinoUsuario.BodyEncoding = Encoding.UTF8;
                        DestinoUsuario.IsBodyHtml = false;

                        if (cbPosErr.SelectedItem.ToString() == "No creo saberlo...")
                        {
                            DestinoAdmin.Body = "Un error ha sido detectado mediante un informe en la aplicacón CODE."
                                + " El Usuario no sabe realmente de que tipo de error se trata. \n\nA continuación se muestra una descripción del error por parte del usuario: \n\n\n  - "
                                + txtDesc.Text + "\n\n\n\n\nError pendiente de revisión. \n\nEnviado: " + DateTime.Now + " por el usuario " + txtUsuarioErr.Text + ", desde " + txtCorreoErr.Text;

                            DestinoUsuario.Body = "¡Gracias por ayudarnos a mejorar!\nUn error ha sido detectado mediante un informe en la aplicacón CODE. \n\nSegún el informe, no sabe realmente de qué tipo de error se trata, aún así nos dedicaremos a revisarlo."
                                + " ¡Estamos para servirte " + txtUsuarioErr.Text + "!\n\n\nEl error está ahora pendiente de revisión. \n-Enviado: " + DateTime.Now;

                            Correo.MandarCorreo(DestinoAdmin);
                            Correo.MandarCorreo(DestinoUsuario);
                        }

                        if (cbPosErr.SelectedItem.ToString() == "Otros")
                        {
                            DestinoAdmin.Body = "Un error ha sido detectado mediante un informe en la aplicacón CODE. El Usuario ha catalogado el error como 'Otros'. \n\nA continuación se muestra una descripción del error por parte del usuario: \n\n\n  - "
                                + txtDesc.Text + "\n\n\n\n\nError pendiente de revisión. \n\nEnviado: " + DateTime.Now + " por el usuario " + txtUsuarioErr.Text + ", desde " + txtCorreoErr.Text;

                            DestinoUsuario.Body = "¡Gracias por ayudarnos a mejorar!\nUn error ha sido detectado mediante un informe en la aplicacón CODE. \n\nSegún el informe, el error fue catalogado como 'Otros'. ¡Estamos para servirte "
                                + txtUsuarioErr.Text + "!\n\n\nEl error está ahora pendiente de revisión. \n-Enviado: " + DateTime.Now;

                            Correo.MandarCorreo(DestinoAdmin);
                            Correo.MandarCorreo(DestinoUsuario);
                        }

                        if ((cbPosErr.SelectedItem.ToString() != "Otros") && (cbPosErr.SelectedItem.ToString() != "No creo saberlo..."))
                        {
                            DestinoAdmin.Body = "Un error ha sido detectado mediante un informe en la aplicacón CODE. Se cree que el error está relacionado a "
                                + cbPosErr.SelectedItem.ToString() + ". \n\nA continuación se muestra una descripción del error por parte del usuario: \n\n\n  - " + txtDesc.Text + "\n\n\n\n\nError pendiente de revisión. \n\nEnviado: "
                                + DateTime.Now + " por el usuario " + txtUsuarioErr.Text + ", desde " + txtCorreoErr.Text;

                            DestinoUsuario.Body = "¡Gracias por ayudarnos a mejorar!\nUn error ha sido detectado mediante un informe en la aplicacón CODE. \n\nSegún el informe, el error puede estar relacionado a "
                                + cbPosErr.SelectedItem.ToString() + ". ¡Estamos para servirte " + txtUsuarioErr.Text + "!\n\n\nEl error está ahora pendiente de revisión. \n-Enviado: " + DateTime.Now;

                            Correo.MandarCorreo(DestinoAdmin);
                            Correo.MandarCorreo(DestinoUsuario);
                        }
                        MessageBox.Show("Su informe ha sido enviado correctamente.", "Gracias por informarnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    { MessageBox.Show("Su informe no pudo ser enviado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            } catch { MessageBox.Show("Ocurrió un error inesperado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            int Escritos = Convert.ToInt32(txtDesc.TextLength);
            int Restantes = 450 - Escritos;
            lblCarRest.Text = "Caracteres restantes: " + Restantes;
            if (Restantes == 0)
            { MessageBox.Show("Se ha alcanzado el número máximo de caracteres permitidos.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbPosErr_KeyDown(object sender, KeyEventArgs e)  
        { e.SuppressKeyPress = true; } 

        public static bool Validarcorreo(string txtCorreoErr)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtCorreoErr, expresion))
            {
                if (Regex.Replace(txtCorreoErr, expresion, string.Empty).Length == 0) { return true; }
                else { return false; } 
            }  else { return false; }
        }

        private void txtCorreoErr_Leave(object sender, EventArgs e)
        {
            if (Validarcorreo(txtCorreoErr.Text)) { }
            else { MessageBox.Show("El formato de Email no es válido.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtCorreoErr.SelectAll(); }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        { AboutForm AcercaDe = new AboutForm(); AcercaDe.Show(); }

        private void Editar_Click(object sender, EventArgs e)
        { txtUsuarioErr.Enabled = !txtUsuarioErr.Enabled; }
    }
}


