using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace CoDE_Proyect.CoDE.Alumnos
{
    public partial class AlumnosAgregar : Form, DPFP.Capture.EventHandler
    {
        public AlumnosAgregar()
        { InitializeComponent(); cp.EventHandler = this; }

        private void AlumnosAgregar_Load(object sender, EventArgs e)
        { CheckForIllegalCrossThreadCalls = false; cp.StartCapture(); MostrarDatos(); Verif(); }

        private void Verif()
        {
            if (CODE.Default.Verif_Escan == true)
            {
                btnVerif.Visible = true; ImgLogo.Visible = false;
                btnEscanearHuella.Enabled = false; btnDetenerEscaneo.Enabled = false;
                btnEscanearHuella.BackColor = SystemColors.ButtonShadow; btnEscanearHuella.ForeColor = SystemColors.MenuText;
                btnDetenerEscaneo.BackColor = SystemColors.ButtonShadow; btnDetenerEscaneo.ForeColor = SystemColors.MenuText;
            }
            else if (CODE.Default.Verif_Escan == false)
            {
                btnVerif.Visible = false; ImgLogo.Visible = true;
                btnEscanearHuella.Enabled = true; btnDetenerEscaneo.Enabled = true;
                btnEscanearHuella.BackColor = Color.FromArgb(65, 65, 65); btnEscanearHuella.ForeColor = Color.WhiteSmoke;
                btnDetenerEscaneo.BackColor = Color.FromArgb(65, 65, 65); btnDetenerEscaneo.ForeColor = Color.WhiteSmoke;
            }
        }

        private void MostrarDatos()
        {
            cboTurno.Items.Clear(); FormUtil.Set_Turno(cboTurno);
            cboCarrera.Items.Clear(); FormUtil.Set_Carrera(cboCarrera);
            cboGrupo.Items.Clear(); FormUtil.Set_Grupos(cboGrupo);
        }

        DPFP.Capture.Capture cp = new DPFP.Capture.Capture();
        string ValorLector; string ValorEscaneo;


        #region Validaciones1 (Campos vacíos, email incorrecto y boleta)

        private bool Errores()
        {
            try
            {
                if (txtNumBoleta.Text.Trim() == String.Empty) return true;
                if (txtNombre.Text.Trim() == String.Empty) return true;
                if (txtApP.Text.Trim() == String.Empty) return true;
                if (txtApM.Text.Trim() == String.Empty) return true;
                if (cboTurno.SelectedIndex.Equals(-1)) return true;
                if (cboCarrera.SelectedIndex.Equals(-1)) return true;
                if (cboGrupo.SelectedIndex.Equals(-1)) return true;
                if (txtNombreTutor.Text == String.Empty) return true;
                if (txtEmailTutor.Text == String.Empty) return true;
                if (ValidarCorreo(txtEmailTutor.Text) == false) return true;
                if (ImgAlumno.Image == null) return true;
            } catch (Exception) { MessageBox.Show("Parámetro incorrecto.", "Error", MessageBoxButtons.OK); } return false;
        }

        public static bool ValidarCorreo(string txtEmailTutor)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtEmailTutor, expresion))
            {
                if (Regex.Replace(txtEmailTutor, expresion, string.Empty).Length == 0) { return true; }
                else { return false; }
            }
            else { return false; }
        }

        private void txtEmailTutor_Leave(object sender, EventArgs e)
        {
            if (ValidarCorreo(txtEmailTutor.Text)) { }
            else { MessageBox.Show("El formato de Email no es válido.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtEmailTutor.SelectAll(); }
        }

        private void txtNumBoleta_KeyPress(object sender, KeyPressEventArgs e)
        { Procesos.SoloNum(e); }

        #endregion


        #region Manejadores de Eventos del formulario (Huella)

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) { }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample) { }

        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            ValorLector = "Conectado"; lblMensajeHuella.Text = "";
            lblMensajeHuella.Visible = true; lblMensajeHuella.ForeColor = Color.ForestGreen; lblMensajeHuella.Text = "El lector está conectado.";
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            ValorLector = "Desconectado"; lblMensajeHuella.Text = "";
            lblMensajeHuella.Visible = true; lblMensajeHuella.ForeColor = Color.FromArgb(225, 0, 0); lblMensajeHuella.Text = "El lector está desconectado.";
        }

        #endregion


        private void Limpiar()
        {
            txtNumBoleta.Text = ""; txtNombre.Text = ""; txtApP.Text = ""; txtApM.Text = "";
            cboTurno.SelectedIndex = -1; cboCarrera.SelectedIndex = -1; cboGrupo.SelectedIndex = -1;
            txtNombreTutor.Text = ""; txtEmailTutor.Text = ""; ImgAlumno.Image = null;
            ImgAlumno.BackgroundImage = Properties.Resources.AñadirAlumno;
            lblMensajeFoto.Text = ""; lblMensajeHuella.Text = "";
        }


        #region TS_Menu

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        { Consultas.ConsultasForm Consultas = new Consultas.ConsultasForm(); Consultas.Show(); this.Close(); }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        { AlumnosForm Alumnos = new AlumnosForm(); Alumnos.Show(); this.Close(); }

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
        { MessageBox.Show("Ya se encuentra en la sección ''Agregar Alumnos''.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void consultarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { AlumnosConsultar ConsAlum = new AlumnosConsultar(); ConsAlum.Show(); this.Close(); }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { AlumnosConsultar ElimAlum = new AlumnosConsultar(); ElimAlum.Show(); this.Close(); }

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
            { string AA = "Buen día, esta ventana le ayudará a agregar a los nuevos alumnos..."
                    + "Rellene el formulario con los datos pertinentes, haga clic en agregar alumno, añada la huella digital y haga clic en finalizar registro..."
                    + "Si lo desea, también puede visitar el Manual de Usuario en línea para más detalles.";
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

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            AlumnosAgregarVideoForm RecibirFoto = new AlumnosAgregarVideoForm();
            RecibirFoto.FotoPasada += new AlumnosAgregarVideoForm.FotoPasar(ExecuteRecibirFoto);
            RecibirFoto.ShowDialog();
        }

        public void ExecuteRecibirFoto(Image ImgRecibir)
        {
            ImgAlumno.Image = ImgRecibir;
            lblMensajeFoto.Visible = true;
            lblMensajeFoto.ForeColor = Color.ForestGreen;
            lblMensajeFoto.Text = "Archivo cargado correctamente.";
        }

        private void btnBorrarFoto_Click(object sender, EventArgs e)
        {
            if (ImgAlumno.Image == null)
            { MessageBox.Show("Para borrar un archivo primero debe subir uno.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                DialogResult BorrarImagen;
                BorrarImagen = MessageBox.Show("¿Eliminar el archivo actual? Si se elimina, tendrá que tomar una foto nueva o elegir una ya existente. ¿Desea continuar?",
                    "¿Borrar archivo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (BorrarImagen == DialogResult.OK)
                { ImgAlumno.Image = null; ImgAlumno.BackgroundImage = Properties.Resources.AñadirAlumno; lblMensajeFoto.Text = "Archivo eliminado correctamente."; }
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog SubirArch = new OpenFileDialog();
                SubirArch.Filter = "Archivos de imagen(*.BMP;*.PNG;*.JPG;*.GIF)|*.BMP;*.PNG;*.JPG;*.GIF|Todos los archivos (*.*)|*.*";
                SubirArch.ShowDialog();
                FileInfo InfoArch = new FileInfo(SubirArch.FileName);

                if (SubirArch.FileName.Equals("") == false)
                {
                    double MegaEnBytes = 1048576;

                    if (InfoArch.Length >= MegaEnBytes)
                    {
                        lblMensajeFoto.Visible = true; lblMensajeFoto.ForeColor = Color.ForestGreen;
                        lblMensajeFoto.Text = "Archivo cargado correctamente. Tamaño aprox. del archivo: " + InfoArch.Length / 1048576 + " MB.";
                        ImgAlumno.Image = Image.FromFile(SubirArch.FileName);
                    }

                    if (InfoArch.Length < MegaEnBytes)
                    {
                        lblMensajeFoto.Visible = true; lblMensajeFoto.ForeColor = Color.ForestGreen;
                        lblMensajeFoto.Text = "Archivo cargado correctamente. Tamaño del archivo: " + InfoArch.Length / 1024 + " KB.";
                        ImgAlumno.Image = Image.FromFile(SubirArch.FileName);
                    }
                }

                if (InfoArch.Length > 5242880)
                {
                    lblMensajeFoto.Visible = true; lblMensajeFoto.Text = "";
                    lblMensajeFoto.ForeColor = Color.FromArgb(225, 0, 0);
                    lblMensajeFoto.Text = "El archivo no fue cargado, excede el límite permitido.";
                    ImgAlumno.Image = null; ImgAlumno.BackgroundImage = Properties.Resources.AñadirAlumno;
                    MessageBox.Show("El tamaño del archivo no puede ser mayor a 5 MB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                ImgAlumno.BackgroundImage = Properties.Resources.AñadirAlumno;
                lblMensajeFoto.Text = ""; lblMensajeFoto.ForeColor = Color.FromArgb(225, 0, 0); lblMensajeFoto.Text = "Ningún archivo fue cargado.";
                MessageBox.Show("Seleccione una ruta de acceso con un formato válido.", "Ruta con formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { Limpiar(); }

        private void bntAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (Errores())
            { MessageBox.Show("Error en los datos, el alumno no pudo ser registrado.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    ImgAlumno.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] IMGENBYTES = ms.GetBuffer();
                    AgregarAlumno(txtNumBoleta.Text, txtNombre.Text, txtApP.Text, txtApM.Text, IMGENBYTES, Convert.ToString(cboTurno.SelectedItem), 
                        Convert.ToString(cboCarrera.SelectedItem), Convert.ToString(cboGrupo.SelectedItem), txtNombreTutor.Text, txtEmailTutor.Text);
                    MessageBox.Show("Alumno agregado correctamente.", "Alumno agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    DialogResult ErrorAgregar; 
                    ErrorAgregar = MessageBox.Show("Error al agregar alumno. Si necesita ayuda, puede visitar nuestro Manual de Ayudas con información que puede ayudarle." 
                        + "\n¿Desea abrir el Manual de Ayudas?", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    if (ErrorAgregar == DialogResult.Yes) { System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76dkZJU2JpUWc5OXM/view"); } 
                }
            }
        }

        private void AgregarAlumno(string Boleta, string Nombre, string AP, string AM, byte[] Imagen, string Turno, string Carrera, string Grupo, string NombreTutor, string EmailTutor)
        { Procesos.AñadirAlumno(Boleta, Nombre, AP, AM, Imagen, Turno, Carrera, Grupo, NombreTutor, EmailTutor); }


        private void btnVerif_Click(object sender, EventArgs e)
        {
            if ((ValorLector == "Conectado"))
            {
                MessageBox.Show("Espere un momento...", "Conectando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Opciones.VerificacionForm Verificacion = new Opciones.VerificacionForm();
                if ((Verificacion.ShowDialog() == DialogResult.OK) && (Procesos.VerficiacionAdmin.Verif == "Correcto"))
                {
                    Procesos.VerficiacionAdmin.Verif = "";
                    Verificacion.Close();
                    btnEscanearHuella.Enabled = true;
                    btnDetenerEscaneo.Enabled = true;
                    btnEscanearHuella.BackColor = Color.FromArgb(65, 65, 65);
                    btnEscanearHuella.ForeColor = Color.WhiteSmoke;
                    btnDetenerEscaneo.BackColor = Color.FromArgb(65, 65, 65);
                    btnDetenerEscaneo.ForeColor = Color.WhiteSmoke;
                }
                else { MessageBox.Show("No se inició el escaneo porque la contraseña es incorrecta.", "La contraseña es incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            } else { MessageBox.Show("No se inició la verificación porque el lector está desconectado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);  }
        }

        private void btnEscanearHuella_Click(object sender, EventArgs e)
        {
            if ((ValorLector == "Conectado"))
            {
                cp.StopCapture();
                MessageBox.Show("El escaneo se está iniciando...", "Iniciando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValorEscaneo = "Iniciado";
                Thread Hilo = new Thread(() => Escaneo.Program2.Second());
                Hilo.SetApartmentState(ApartmentState.STA);
                Hilo.IsBackground = true; Hilo.Start();
            }
            else { MessageBox.Show("No se inició el escaneo porque el lector está desconectado.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); } 
        }

        private void btnDetenerEscaneo_Click(object sender, EventArgs e)
        {
            if ((ValorLector == "Conectado") && (ValorEscaneo == "Iniciado"))
            {
                MessageBox.Show("Se detuvo el escaneo.", "Detenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMensajeHuella.Text = "";
                ValorEscaneo = "Detenido";
            }
            else if ((ValorLector != "Conectado") || (ValorEscaneo != "Iniciado"))
            { MessageBox.Show("Para detener el escaneo primero tiene que iniciarlo.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void AlumnosAgregar_FormClosed(object sender, FormClosedEventArgs e)
        { cp.StopCapture(); }

        private void txtNumBoleta_Leave(object sender, EventArgs e)
        { Procesos.Opciones.ID = txtNumBoleta.Text; }

        private void ImgLogo_Click(object sender, EventArgs e)
        { MessageBox.Show("Hola " + Procesos.SesionDeAdmin.SA + ", ten un buen día :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            ProgressBar();
            try
            {
                string sConexion = Procesos.CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Alumnos WHERE Boleta = @Boleta", cnn);
                SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                DataSet AjusteDatos = new DataSet();
                AdaptadorDeDatos.SelectCommand.Parameters.Add("@Boleta", SqlDbType.Int);
                AdaptadorDeDatos.SelectCommand.Parameters["@Boleta"].Value = int.Parse(txtNumBoleta.Text);
                AdaptadorDeDatos.Fill(AjusteDatos, "tb_Alumnos");

                if (AjusteDatos.Tables[0].Rows[0].IsNull("HuellaAlumno"))
                { MessageBox.Show("No se pudo finalizar el registro del alumno. Razón: No existe huella.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0; }
                else
                {
                    BarraProgreso.Value = 0; DialogResult Finalizado;
                    Finalizado = MessageBox.Show("El registro de " + txtNumBoleta.Text + 
                        " ha finalizado, puede cerrar esta ventana o seguir añadiendo a otros usuarios. El formulario se limpiará, ¿continuar?", 
                        "Listo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Finalizado == DialogResult.Yes) { Limpiar(); }                      
                }
            } catch { MessageBox.Show("Ocurrió un error: no se puede encontrar el alumno.\nCompruebe si el alumno existe o si escribió correctamente.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void AlumnosAgregar_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }

        private void AlumnosAgregar_MouseMove(object sender, MouseEventArgs e)
        { Procesos.VerficiarSesion(); }

        private void ProgressBar()
        {
            Random rnd = new Random();
            int Progreso = rnd.Next(70, 100);
            for (int i = Progreso; i <= 300; i++)
            { BarraProgreso.Increment(i); }
        }
    }
}

