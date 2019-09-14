using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Consultas
{
    public partial class VerificarDatos : Form
    {
        public VerificarDatos()
        { InitializeComponent(); }

        public void TamañoVisorEstandar()
        {
            Visor.RowTemplate.Resizable = DataGridViewTriState.True; Visor.RowTemplate.MinimumHeight = 55;
            Visor.RowTemplate.Height = 55; Visor.Height = 75;
        }


        #region TS_Menu

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        { ConsultasForm Consultas = new ConsultasForm(); Consultas.Show(); this.Close(); }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        { Alumnos.AlumnosForm Alumnos = new Alumnos.AlumnosForm(); Alumnos.Show(); this.Close(); }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        { Empleados.EmpleadosForm Empleados = new Empleados.EmpleadosForm(); Empleados.Show(); this.Close(); }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión actual: " + Procesos.SesionDeAdmin.SA + "\n\nHora de inicio de Sesión: " + Procesos.SesionDeAdmin.SH,
               "Información de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        { Alumnos.AlumnosAgregar AgAlum = new Alumnos.AlumnosAgregar(); AgAlum.Show(); this.Close(); }

        private void consultarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Esta ventana forma parte de ''Consultar Alumnos''.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Vaya a la parte de ''Consultar Alumnos'' desde donde se pueden eliminar los registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void informarDeUnErrorToolStripMenuItem_Click(object sender, EventArgs e)
        { Opciones.InformarError InformarError = new Opciones.InformarError(); InformarError.Show(); }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        { Opciones.AboutForm AcercaDe = new Opciones.AboutForm(); AcercaDe.Show(); }

        #endregion


        private void btnAA_Click(object sender, EventArgs e)
        {
            try
            { string AA = "Buen día, esta ventana le ayuda a verificar la identidad del alumno mediante el i mail del padre o tutor proporcionado..."
                    + "Introduzca el ide del usuario y visualice los datos, posteriormente haga clic en verificar datos y se enviará un imail"
                    + "al padre o tutor para que revise la información y la verifique. Si lo desea, siempre puede visitar el Manual de Usuario en línea para más detalles.";
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

        private void btnCerrar_Click(object sender, EventArgs e)
        { ConsultasForm Cons = new ConsultasForm(); Cons.Show(); this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoBol.Text = ""; Visor.Visible = false;
            lblEncontrado.Visible = false; lblEncontrado.Text = "";
            btnVerificar.Visible = false; ImgAlumno.Image = null; ImgAlumno.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { TamañoVisorEstandar(); BuscarAlumno(txtAlumnoBol.Text); }

        private void BuscarAlumno(string Alumn_Boleta)
        {
            Visor.DataSource = Procesos.ConsAlum_1(Alumn_Boleta);

            if (Visor.Rows.Count > 0)
            {
                btnVerificar.Visible = true; Visor.Visible = true;
                lblEncontrado.Visible = true;lblEncontrado.Text = "ALUMNO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen;
                try
                {
                    string sConexion = Procesos.CadenaConexion;
                    SqlConnection cnn = new SqlConnection(sConexion);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Alumnos WHERE Boleta = @Boleta", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    DataSet AjusteDatos = new DataSet();
                    AdaptadorDeDatos.SelectCommand.Parameters.Add("@Boleta", SqlDbType.Int);
                    AdaptadorDeDatos.SelectCommand.Parameters["@Boleta"].Value = int.Parse(txtAlumnoBol.Text);
                    AdaptadorDeDatos.Fill(AjusteDatos, "tb_Alumnos");

                    if (AjusteDatos.Tables["tb_Alumnos"].Rows.Count != 0)
                    {
                        byte[] imageBuffer = (byte[])AjusteDatos.Tables["tb_Alumnos"].Rows[0]["Foto"];
                        MemoryStream ms = new MemoryStream(imageBuffer); ImgAlumno.Visible = true;
                        ImgAlumno.Image = Image.FromStream(ms);
                    } else { MessageBox.Show("No pudo encontrar el alumno..."); }
                }
                catch { MessageBox.Show("No se pudo recuperar la imagen del alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }

            else
            { MessageBox.Show("No se puede encontrar el alumno.\nCompruebe si el alumno existe o si escribió correctamente.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; lblEncontrado.Visible = true;
                ImgAlumno.Visible = false; lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
                lblEncontrado.Text = "ALUMNO NO ENCONTRADO EN LA BASE DE DATOS.";
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            DialogResult EnviarMensaje;
            EnviarMensaje = MessageBox.Show("¿Enviar la verificación de datos del alumno?\nLa verificación se enviará al siguiente email: " + Visor.CurrentRow.Cells[8].Value.ToString(),
                "¿Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EnviarMensaje == DialogResult.Yes)
            {
                Procesos Correo = new Procesos(); MailMessage DestinoContacto = new MailMessage();
                string EmailTutor = Visor.CurrentRow.Cells[8].Value.ToString();
                DestinoContacto.To.Add(new MailAddress(EmailTutor)); DestinoContacto.Subject = "Verificación de datos del alumno.";
                DestinoContacto.SubjectEncoding = Encoding.UTF8;  DestinoContacto.From = new MailAddress(CODE.Default.Email_User, "C O D E");
                DestinoContacto.BodyEncoding = Encoding.UTF8; DestinoContacto.IsBodyHtml = true;
                try
                {
                    DestinoContacto.Body = CODE.Default.Email_Body + "<br> <br> <br> DATOS DEL ALUMNO: <br> <br> "
                        + " - Numero de boleta: " + Visor.CurrentRow.Cells[0].Value.ToString() + "<br>"
                        + " - Nombre: " + Visor.CurrentRow.Cells[1].Value.ToString() + "<br>"
                        + " - Apellido Paterno: " + Visor.CurrentRow.Cells[2].Value.ToString() + "<br>"
                        + " - Apellido Materno: " + Visor.CurrentRow.Cells[3].Value.ToString() + "<br>"
                        + " - Turno: " + Visor.CurrentRow.Cells[4].Value.ToString() + "<br>"
                        + " - Carrera: " + Visor.CurrentRow.Cells[5].Value.ToString() + "<br>"
                        + " - Grupo: " + Visor.CurrentRow.Cells[6].Value.ToString() + "<br>"
                        + " - Nombre del padre o tutor: " + Visor.CurrentRow.Cells[7].Value.ToString() + "<br>"
                        + " - Email del padre o tutor: " + Visor.CurrentRow.Cells[8].Value.ToString() + "<br>"
                        + "<br> <br> Póngase en contacto con el centro de estudios si algún dato es erróneo, de lo contrario, simplemente ignore este email. <br> <br> "
                        + "Enviado: " + DateTime.Now + " por el administrador " + Procesos.SesionDeAdmin.SA + ".";
                    Image ImagenAdjunta = ImgAlumno.Image; MemoryStream ms = new MemoryStream();
                    ImagenAdjunta.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); ms.Position = 0;
                    Attachment Archivo = new Attachment(ms, Visor.CurrentRow.Cells[0].Value.ToString() + ".jpg");
                    DestinoContacto.Attachments.Add(Archivo); Correo.MandarCorreo(DestinoContacto);
                    MessageBox.Show("La verificación de datos ha sido enviada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { MessageBox.Show("La verificación de datos no pudo ser enviada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void txtAlumnoBol_KeyPress(object sender, KeyPressEventArgs e)
        { Procesos.SoloNum(e); }

        private void VerificarDatos_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }
    }
}
