using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class Contacto : Form
    {
        public Contacto()
        { InitializeComponent(); }

        private void Contacto_Load(object sender, EventArgs e)
        { txtNombre.Text = Procesos.SesionDeAdmin.SA; }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

        private void Editar_Click(object sender, EventArgs e)
        { txtNombre.Enabled = !txtNombre.Enabled; }

        private void chkAdjuntar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdjuntar.Checked == true) { txtDireccion.Enabled = true; btnArch.Enabled = true; }
            else { txtDireccion.Text = ""; txtDireccion.Enabled = false; btnArch.Enabled = false; }
        }

        private void btnArch_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog SubirArch = new OpenFileDialog();
                SubirArch.ShowDialog();
                FileInfo InfoArch = new FileInfo(SubirArch.FileName);

                if (SubirArch.FileName.Equals("") == false) { txtDireccion.Text = SubirArch.FileName; }

                if (InfoArch.Length > 5242880) 
                { txtDireccion.Text = ""; MessageBox.Show("El tamaño del archivo no puede ser mayor a 5 MB.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            { MessageBox.Show("La ruta de acceso tiene un formato no válido.",  
                "Seleccione una ruta para cargar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            int Escritos = Convert.ToInt32(txtComent.TextLength);
            int Restantes = 450 - Escritos;
            lblCarRest.Text = "Caracteres restantes: " + Restantes;

            if (Restantes == 0)
            { MessageBox.Show("Se ha alcanzado el número máximo de caracteres permitidos.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { txtNombre.Text = ""; txtEmail.Text = ""; txtDireccion.Text = ""; txtComent.Text = ""; }

        private bool Errores()
        {
            if (chkAdjuntar.Checked == true) 
            {
                if (txtNombre.Text.Trim() == String.Empty) return true;
                if (txtEmail.Text.Trim() == String.Empty) return true;
                if (Validarcorreo(txtEmail.Text) == false) return true;
                if (txtDireccion.Text.Trim() == String.Empty) return true;
                if (txtComent.Text.Trim() == String.Empty) return true;
            }

            if (chkAdjuntar.Checked == false) 
            {
                if (txtNombre.Text.Trim() == String.Empty) return true;
                if (txtEmail.Text.Trim() == String.Empty) return true;
                if (Validarcorreo(txtEmail.Text) == false) return true;
                if (txtComent.Text.Trim() == String.Empty) return true;
            }
            return false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Errores())
                { MessageBox.Show("Error en los datos, su comentario no pudo ser enviado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                else
                {
                    Procesos Correo = new Procesos();
                    MailMessage DestinoContacto = new MailMessage();
                    DestinoContacto.To.Add(new MailAddress(CODE.Default.Email_User));
                    DestinoContacto.Subject = "Nuevo comentario de " + txtNombre.Text + ".";
                    DestinoContacto.SubjectEncoding = Encoding.UTF8;
                    DestinoContacto.From = new MailAddress(CODE.Default.Email_User, "C O D E");
                    DestinoContacto.BodyEncoding = Encoding.UTF8;

                    if ((chkAdjuntar.Checked == true))
                    {
                        DestinoContacto.IsBodyHtml = true;
                        if (txtDireccion.Text.Equals("") == false)
                        {
                            try
                            {
                                DestinoContacto.Body = txtNombre.Text + " hizo un nuevo comentario acerca de la aplicación CoDE. <br> <br> - "
                                    + txtComent.Text + "<br> <br> <br> <br> Comentario pendiente de revisión. <br> <br> Enviado: " + DateTime.Now
                                    + "por el usuario " + txtNombre.Text + ", desde " + txtEmail.Text;
                                Attachment ArchivoSubido = new Attachment(txtDireccion.Text);
                                DestinoContacto.Attachments.Add(ArchivoSubido);
                                Correo.MandarCorreo(DestinoContacto);
                                MessageBox.Show("Su comentario ha sido enviado correctamente.", "Gracias por cooperar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } catch { MessageBox.Show("Su comentario no pudo ser enviado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        else
                        { MessageBox.Show("Usted marcó la casilla para adjuntar un archivo o documento, \npara continuar suba un archivo y después envie sus comentarios." 
                            + "\nDe lo contrario, desmarque la casilla e inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    if ((chkAdjuntar.Checked == false))
                    {
                        try
                        {
                            DestinoContacto.IsBodyHtml = false;
                            DestinoContacto.Body = txtNombre.Text + " hizo un nuevo comentario acerca de la aplicación CoDE. \n\n - " + txtComent.Text + "\n\n\n\n\nComentario pendiente de revisión."
                                + "\n\nEnviado: " + DateTime.Now + " por el usuario " + txtNombre.Text + ", desde " + txtEmail.Text;
                            Correo.MandarCorreo(DestinoContacto);
                            MessageBox.Show("Su comentario ha sido enviado correctamente.", "Gracias por cooperar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch { MessageBox.Show("Su comentario no pudo ser enviado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            } catch { MessageBox.Show("Ocurrió un error inesperado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static bool Validarcorreo(string txtEmail)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtEmail, expresion))
            {
                if (Regex.Replace(txtEmail, expresion, string.Empty).Length == 0) { return true; }
                else { return false; }
            }
            else { return false; }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Validarcorreo(txtEmail.Text)) { }
            else
            { MessageBox.Show("El formato de Email no es válido.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtEmail.SelectAll(); }
        }

        private void informarDeUnErrorToolStripMenuItem_Click(object sender, EventArgs e)
        { InformarError InformarError = new InformarError(); InformarError.Show(); }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        { _2AboutForm AcercaDe = new _2AboutForm(); AcercaDe.Show(); }

        private void novedadesToolStripMenuItem_Click(object sender, EventArgs e)
        { Novedades.Novedades Novedades = new Novedades.Novedades(); Novedades.Show(); }
    }
}
