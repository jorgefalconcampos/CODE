using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Speech.Synthesis;
using System.Data.SqlClient;

namespace CoDE_Proyect.CoDE.Empleados
{
    public partial class EmpleadosAgregar : Form, DPFP.Capture.EventHandler
    {
        public EmpleadosAgregar()
        { InitializeComponent(); cp.EventHandler = this; }

        private void EmpleadosAgregar_Load(object sender, EventArgs e)
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
        { cboTurno.Items.Clear(); FormUtil.Set_Turno(cboTurno); }

        DPFP.Capture.Capture cp = new DPFP.Capture.Capture();
        string ValorLector; string ValorEscaneo;


        #region Validaciones1 (Campos vacíos, email incorrecto y num. empleado)

        private bool Errores()
        {
            try
            {
                if (txtNumEmpleado.Text.Trim() == String.Empty) return true;
                if (txtNombre.Text.Trim() == String.Empty) return true;
                if (txtApP.Text.Trim() == String.Empty) return true;
                if (txtApM.Text.Trim() == String.Empty) return true;
                if (cboTurno.SelectedIndex.Equals(-1)) return true;
                if (txtEmail.Text == String.Empty) return true;
                if (Validarcorreo(txtEmail.Text) == false) return true;
                if (ImgEmpleado.Image == null) return true;
            } catch (Exception) { MessageBox.Show("Parámetro incorrecto.", "Error", MessageBoxButtons.OK); } return false;
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
            else { MessageBox.Show("El formato de Email no es válido.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtEmail.SelectAll(); }
        }

        private void txtNumEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        { Procesos.Num_Letras(e); }
       
        #endregion


        #region Manejadores de Eventos del formulario (Huella)

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) { }

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample) { }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }

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
            txtNumEmpleado.Text = ""; txtNombre.Text = ""; txtApP.Text = "";
            txtApM.Text = ""; txtEmail.Text = ""; lblMensajeFoto.Text = "";
            lblMensajeHuella.Text = ""; cboTurno.SelectedIndex = -1; ImgEmpleado.Image = null;
            ImgEmpleado.BackgroundImage = Properties.Resources.AñadirEmpleado;
        }


        #region TS_Menu

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        { Menu_Principal MenuP = new Menu_Principal(); MenuP.Show(); this.Close(); }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        { Consultas.ConsultasForm Consultas = new Consultas.ConsultasForm(); Consultas.Show(); this.Close(); }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        { Alumnos.AlumnosForm Alumnos = new Alumnos.AlumnosForm(); Alumnos.Show(); this.Close(); }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        { EmpleadosForm Empleados = new EmpleadosForm(); Empleados.Show(); this.Close(); }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión actual: " + Procesos.SesionDeAdmin.SA + "\n\nHora de inicio de Sesión: " + Procesos.SesionDeAdmin.SH,
               "Información de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        { Procesos.CerrarSesionPress = true; this.Close(); }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en la sección ''Agregar Empleados''.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void consultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        { EmpleadosConsultar ConsEmp = new EmpleadosConsultar(); ConsEmp.Show(); this.Close(); }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        { EmpleadosConsultar ElimEmp = new EmpleadosConsultar(); ElimEmp.Show(); this.Close(); }

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
            { string AA = "Buen día, esta ventana le ayudará a agregar a los nuevos empleados..."
                    + "Rellene el formulario con los datos pertinentes, haga clic en agregar empleado, añada la huella digital y haga clic en finalizar registro..."
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
            EmpleadosAgregarVideoForm RecibirFoto = new EmpleadosAgregarVideoForm();
            RecibirFoto.FotoPasada += new EmpleadosAgregarVideoForm.FotoPasar(ExecuteRecibirFoto);
            RecibirFoto.ShowDialog();
        }

        public void ExecuteRecibirFoto(Image ImgRecibir)
        {
            ImgEmpleado.Image = ImgRecibir;
            lblMensajeFoto.Visible = true;
            lblMensajeFoto.ForeColor = Color.ForestGreen;
            lblMensajeFoto.Text = "Archivo cargado correctamente.";
        }

        private void btnBorrarFoto_Click(object sender, EventArgs e)
        {
            if (ImgEmpleado.Image == null)
            { MessageBox.Show("Para borrar un archivo primero debe subir uno.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                DialogResult BorrarImagen;
                BorrarImagen = MessageBox.Show("¿Eliminar el archivo actual? Si se elimina, tendrá que tomar una foto nueva o elegir una ya existente. ¿Desea continuar?",
                    "¿Borrar archivo?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (BorrarImagen == DialogResult.OK)
                { ImgEmpleado.Image = null; ImgEmpleado.BackgroundImage = Properties.Resources.AñadirEmpleado; lblMensajeFoto.Text = "Archivo eliminado correctamente."; }
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
                        ImgEmpleado.Image = Image.FromFile(SubirArch.FileName);
                    }

                    if (InfoArch.Length < MegaEnBytes)
                    {
                        lblMensajeFoto.Visible = true; lblMensajeFoto.ForeColor = Color.ForestGreen;
                        lblMensajeFoto.Text = "Archivo cargado correctamente. Tamaño del archivo: " + InfoArch.Length / 1024 + " KB.";
                        ImgEmpleado.Image = Image.FromFile(SubirArch.FileName);
                    }
                }

                if (InfoArch.Length > 5242880)
                {
                    lblMensajeFoto.Visible = true; lblMensajeFoto.Text = "";
                    lblMensajeFoto.ForeColor = Color.FromArgb(225, 0, 0);
                    lblMensajeFoto.Text = "El archivo no fue cargado, excede el límite permitido.";
                    ImgEmpleado.Image = null; ImgEmpleado.BackgroundImage = Properties.Resources.AñadirEmpleado;
                    MessageBox.Show("El tamaño del archivo no puede ser mayor a 5 MB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                ImgEmpleado.BackgroundImage = Properties.Resources.AñadirEmpleado;
                lblMensajeFoto.Text = ""; lblMensajeFoto.ForeColor = Color.FromArgb(225, 0, 0); lblMensajeFoto.Text = "Ningún archivo fue cargado.";
                MessageBox.Show("Seleccione una ruta de acceso con un formato válido.", "Ruta con formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { Limpiar(); }

        private void bntAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (Errores())
            { MessageBox.Show("Error en los datos, el empleado no pudo ser registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    ImgEmpleado.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] IMGENBYTES = ms.GetBuffer();
                    AgregarEmpleado(txtNumEmpleado.Text, txtNombre.Text, txtApP.Text, txtApM.Text, IMGENBYTES, Convert.ToString(cboTurno.SelectedItem), txtEmail.Text);
                    MessageBox.Show("Empleado agregado correctamente.", "Empleado agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    DialogResult ErrorAgregar;
                    ErrorAgregar = MessageBox.Show("Error al agregar empleado. Si necesita ayuda, puede visitar nuestro Manual de Ayudas con información que puede ayudarle." 
                        + "\n¿Desea abrir el Manual de Ayudas?", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    if (ErrorAgregar == DialogResult.Yes) { System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76dkZJU2JpUWc5OXM/view"); } 
                }
            }
        }

        private void AgregarEmpleado(string NumEmp, string Nombre, string AP, string AM, byte[] Imagen, string Turno, string Email)
        { Procesos.AñadirEmpleado(NumEmp, Nombre, AP, AM, Imagen, Turno, Email); }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            if ((ValorLector == "Conectado"))
            {
                MessageBox.Show("Espere un momento...", "Conectando", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Opciones.VerificacionForm Verificacion = new Opciones.VerificacionForm();

                if ((Verificacion.ShowDialog() == DialogResult.OK) && (Procesos.VerficiacionAdmin.Verif == "Correcto"))
                {
                    Procesos.VerficiacionAdmin.Verif = ""; Verificacion.Close();
                    btnEscanearHuella.Enabled = true; btnDetenerEscaneo.Enabled = true;
                    btnEscanearHuella.BackColor = Color.FromArgb(65, 65, 65); btnEscanearHuella.ForeColor = Color.WhiteSmoke;
                    btnDetenerEscaneo.BackColor = Color.FromArgb(65, 65, 65); btnDetenerEscaneo.ForeColor = Color.WhiteSmoke;
                } else { MessageBox.Show("No se inició el escaneo porque la contraseña es incorrecta.", "La contraseña es incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            } else { MessageBox.Show("No se inició el escaneo porque el lector está desconectado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnEscanearHuella_Click(object sender, EventArgs e)
        {
            if ((ValorLector == "Conectado"))
            {
                cp.StopCapture();
                MessageBox.Show("El escaneo se está iniciando...", 
                    "Iniciando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ValorEscaneo = "Iniciado";
                Thread Hilo = new Thread(() => Escaneo.Program2.Second());
                Hilo.SetApartmentState(ApartmentState.STA);
                Hilo.IsBackground = true; Hilo.Start();
            } else { MessageBox.Show("No se inició el escaneo porque el lector está desconectado.",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnDetenerEscaneo_Click(object sender, EventArgs e)
        {
            if ((ValorLector == "Conectado") && (ValorEscaneo == "Iniciado"))
            {
                MessageBox.Show("Se detuvo el escaneo.", "Detenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMensajeHuella.Text = ""; ValorEscaneo = "Detenido";
            }
            else if ((ValorLector != "Conectado") || (ValorEscaneo != "Iniciado"))
            { MessageBox.Show("Para detener el escaneo primero tiene que iniciarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void EmpleadosAgregar_FormClosed(object sender, FormClosedEventArgs e)
        { cp.StopCapture(); }      

        private void txtNumEmpleado_Leave(object sender, EventArgs e)
        { Procesos.Opciones.ID = txtNumEmpleado.Text; }

        private void ImgLogo_Click(object sender, EventArgs e)
        { MessageBox.Show("Hola " + Procesos.SesionDeAdmin.SA + ", ten un buen día :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            ProgressBar();
            try
            {
                string sConexion = Procesos.CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Empleados WHERE NumeroEmpleado = @NumeroEmpleado", cnn);
                SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                DataSet AjusteDatos = new DataSet();
                AdaptadorDeDatos.SelectCommand.Parameters.Add("@NumeroEmpleado", SqlDbType.NVarChar, 30);
                AdaptadorDeDatos.SelectCommand.Parameters["@NumeroEmpleado"].Value = txtNumEmpleado.Text;
                AdaptadorDeDatos.Fill(AjusteDatos, "tb_Empleados");

                if (AjusteDatos.Tables[0].Rows[0].IsNull("HuellaEmpleado"))
                { MessageBox.Show("No se pudo finalizar el registro del empleado. Razón: No existe huella.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0;
                }
                else
                {
                    BarraProgreso.Value = 0; DialogResult Finalizado;
                    Finalizado = MessageBox.Show("El registro de " + txtNumEmpleado.Text +
                        " ha finalizado, puede cerrar esta ventana o seguir añadiendo a otros usuarios. El formulario se limpiará, ¿continuar?",
                        "Listo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Finalizado == DialogResult.Yes) { Limpiar(); }
                }
            }
            catch { MessageBox.Show("Ocurrió un error: no se puede encontrar el empleado.\nCompruebe si el empleado existe o si escribió correctamente.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void EmpleadosAgregar_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }

        private void EmpleadosAgregar_MouseMove(object sender, MouseEventArgs e)
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

