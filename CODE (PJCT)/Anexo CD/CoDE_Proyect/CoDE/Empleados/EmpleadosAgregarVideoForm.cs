using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CoDE_Proyect.CoDE.Empleados
{
    public partial class EmpleadosAgregarVideoForm : Form
    {
        public EmpleadosAgregarVideoForm()
        { InitializeComponent(); }

        public delegate void FotoPasar(Image ImgEnviar);
        public event FotoPasar FotoPasada;
        private FilterInfoCollection DispositivosVideo;
        private VideoCaptureDevice FuenteVideo;
        string ValorCamara;

        private void EmpleadosAgregarVideoForm_Load(object sender, EventArgs e)
        {
            DispositivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in DispositivosVideo)
            { cboDispositivos.Items.Clear(); cboDispositivos.Items.Add(VideoCaptureDevice.Name); }
            cboDispositivos.SelectedIndex = -1;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                FuenteVideo = new VideoCaptureDevice(DispositivosVideo[cboDispositivos.SelectedIndex].MonikerString);
                FuenteVideo.NewFrame += new NewFrameEventHandler(VideoFinal); FuenteVideo.Start();
                ValorCamara = "Iniciada"; btnIniciar.BackColor = SystemColors.ButtonShadow;
                btnIniciar.ForeColor = SystemColors.MenuText; btnIniciar.Enabled = false;
            } catch (Exception) { MessageBox.Show("Tiene que elegir una fuente de video del menú desplegable.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        void VideoFinal(object sender, NewFrameEventArgs eventArgs)
        { Bitmap VideoLive = (Bitmap)eventArgs.Frame.Clone(); ImagenLive.Image = VideoLive; }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            try
            {
                FuenteVideo.SignalToStop(); btnIniciar.BackColor = Color.FromArgb(65, 65, 65);
                btnIniciar.ForeColor = Color.WhiteSmoke; btnIniciar.Enabled = true; ImagenLive.Image = null;

                if (FuenteVideo.IsRunning == false)
                { MessageBox.Show("Aún no se ha iniciado la cámara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception) { MessageBox.Show("Aún no se ha iniciado la cámara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                FuenteVideo.SignalToStop(); SaveFileDialog GuardarArch = new SaveFileDialog();

                if (ImagenLive.Image == null)
                { MessageBox.Show("No se puede tomar la foto, no existe una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    try
                    {
                        Image Imagen = ImagenLive.Image;
                        GuardarArch.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG|GIF(*.GIF)|*.GIF|BMP(*.BMP)|*.BMP";
                        GuardarArch.ShowDialog(); Imagen.Save(GuardarArch.FileName);
                        MessageBox.Show("La imagen fue guardada en la siguiente ruta: \n" + GuardarArch.FileName, 
                            "Imagen guardada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FuenteVideo.SignalToStop(); DialogResult UsarImagen;
                        UsarImagen = MessageBox.Show("¿Desea usar esta imagen para llenar el formulario?\nO si lo prefiere, puede cargar más adelante la imagen de manera manual" 
                            + "desde la ruta en la que fue guardada.", "¿Usar imagen?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (UsarImagen == DialogResult.OK) { FotoPasada(ImagenLive.Image); } FuenteVideo.Start();
                    } catch (Exception) { MessageBox.Show("Error al guardar la imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); FuenteVideo.Start();
                    }
                }
            }
            catch (Exception)
            { MessageBox.Show("Para tomar una foto, primero tiene que elegir una fuente de video del menú desplegable y después iniciar la cámara.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EmpleadosAgregarVideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValorCamara == "Iniciada") { FuenteVideo.SignalToStop(); }

            else
            {
                DialogResult ErrorCerrando; ErrorCerrando = MessageBox.Show("Se detectó que la cámara nunca fue iniciada...\n¿Desea continuar y cerrar esta ventana?", 
                    "¿Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (ErrorCerrando == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void cboDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDispositivos.SelectedItem.ToString() == "No se detectó ninguna cámara.")
            {
                MessageBox.Show("No es un parámetro válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboDispositivos.Items.Clear(); cboDispositivos.Items.Add("No se detectó ninguna cámara.");
            }
        }
    }
}

