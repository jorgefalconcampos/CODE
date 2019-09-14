using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Empleados
{
    public partial class EmpleadosConsultarHuella : Form
    {
        public EmpleadosConsultarHuella()
        { InitializeComponent(); }

        private void EmpleadosConsultarHuella_Load(object sender, EventArgs e)
        {
            Visor.RowTemplate.Resizable = DataGridViewTriState.True; Visor.RowTemplate.MinimumHeight = 55;
            Visor.RowTemplate.Height = 55; Visor.Height = 75;
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
        {
            try { EmpleadosAgregar AgEmp = new EmpleadosAgregar(); AgEmp.Show(); this.Close(); }
            catch { MessageBox.Show("Ocurrió un error al abrir esta ventana. Verifique que el programa ''Digital Persona One Touch for Windows SDK 1.4.0.1'' esté instalado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void consultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Esta ventana forma parte de ''Consultar Empleados''.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Vaya a la parte de ''Consultar Empleados'' desde donde se pueden eliminar los registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

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
            { string AA = "Buen día, esta ventana le ayuda a conocer la huella digital de un empleado en específico..."
                    + "Introduzca el ide del usuario y visualice los datos, la huella por su parte se puede actualizar pero se recomienda hacerlo solo si es necesario..."
                    + "Trate esta información con cuidado y si lo desea puede visitar el Manual de Usuario en línea para más detalles.";
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

        private void btnActualizarHuella_Click(object sender, EventArgs e)
        {
            Procesos.Opciones.ID = txtEmpleadoConsultar.Text;
            Thread Hilo = new Thread(() => Escaneo.Program2.Second());
            Hilo.SetApartmentState(ApartmentState.STA);
            Hilo.IsBackground = true; Hilo.Start();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            EmpleadosConsultarPreview VerHuella = new EmpleadosConsultarPreview();
            VerHuella.ID_Empleado = txtEmpleadoConsultar.Text;
            VerHuella.ImgHuellaPreview.Image = ImgHuella.Image;
            VerHuella.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Contraer(); this.Size = new Size(875, 333);
            btnCerrar.Location = new Point(128, 236);
            btnLimpiar.Location = new Point(350, 236);
            btnBuscar.Location = new Point(572, 236);
            GrupoMasDatos.Visible = false; btnVerMas.Visible = false;
            ImgEmpleado.Image = null; ImgEmpleado.Visible = false;
            ImgHuella.Image = null; ImgHuella.Visible = false;
            btnActualizarHuella.Visible = false; btnVerHuella.Visible = false;
            lblEncontrado.Visible = false; lblEncontrado.Text = ""; txtEmpleadoConsultar.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { Contraer(); Consulta(); BuscarEmpleado(txtEmpleadoConsultar.Text); }

        private void Consulta()
        {
            try
            {
                string sConexion = Procesos.CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Empleados WHERE NumeroEmpleado = @NumeroEmpleado", cnn);
                SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                DataSet AjusteDatos = new DataSet();
                AdaptadorDeDatos.SelectCommand.Parameters.Add("@NumeroEmpleado", SqlDbType.NVarChar, 30);
                AdaptadorDeDatos.SelectCommand.Parameters["@NumeroEmpleado"].Value = txtEmpleadoConsultar.Text;
                AdaptadorDeDatos.Fill(AjusteDatos, "tb_Empleados");

                if (AjusteDatos.Tables["tb_Empleados"].Rows.Count != 0)
                {
                    byte[] ImgBuffer = (byte[])AjusteDatos.Tables["tb_Empleados"].Rows[0]["Foto"];
                    MemoryStream ms = new MemoryStream(ImgBuffer);
                    ImgEmpleado.Visible = true;
                    ImgEmpleado.Image = Image.FromStream(ms);
                    /////////////////////////////////////////////////////////
                    byte[] ImgBuffer2 = (byte[])AjusteDatos.Tables["tb_Empleados"].Rows[0]["HuellaEmpleado"];
                    MemoryStream ms2 = new MemoryStream(ImgBuffer2);
                    ImgHuella.Visible = true;
                    ImgHuella.Image = Image.FromStream(ms2);
                    btnActualizarHuella.Visible = true;
                    btnVerHuella.Visible = true;
                }
                else { MessageBox.Show("No se pudo encontrar el empleado o uno o más de sus registros...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            } catch { MessageBox.Show("No se puede encontrar el empleado o uno o más de sus registros. Compruebe si el empleado existe o si fue registrado correctamente.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void BuscarEmpleado(string NumeroEmpleado)
        {
            Visor.DataSource = Procesos.ConsEmp_1(NumeroEmpleado);
            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "EMPLEADO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen;
                this.Size = new Size(875, 353); btnCerrar.Location = new Point(128, 260);
                btnLimpiar.Location = new Point(350, 260); btnBuscar.Location = new Point(572, 260);
                GrupoMasDatos.Visible = true; btnVerMas.Visible = true;
            }
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        { Expandir(); }

        private void btnVerMenos_Click(object sender, EventArgs e)
        { Contraer(); }

        private void Expandir()
        {
            btnVerMas.Visible = false; btnVerMenos.Visible = true;
            this.Size = new Size(875, 458); GrupoMasDatos.Size = new Size(835,128);
            btnCerrar.Location = new Point(128, 365); btnLimpiar.Location = new Point(350, 365); btnBuscar.Location = new Point(572, 365);
        }

        private void Contraer()
        {
            btnVerMenos.Visible = false; btnVerMas.Visible = true;
            this.Size = new Size(875, 353); GrupoMasDatos.Size = new Size(835, 27);
            btnCerrar.Location = new Point(128, 260); btnLimpiar.Location = new Point(350, 260); btnBuscar.Location = new Point(572, 260);
        }

        private void EmpleadosConsultarHuella_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }
    }
}
