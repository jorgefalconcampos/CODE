using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace CoDE_Proyect.CoDE.Alumnos
{
    public partial class AlumnosConsultar : Form
    {
        public AlumnosConsultar()
        { InitializeComponent(); }

        private void AlumnosConsultar_Load(object sender, EventArgs e)
        { MostrarDatos(); }

        private void MostrarDatos()
        {
            cboTurno.Items.Clear(); FormUtil.Set_Turno(cboTurno);
            cboCarrera.Items.Clear(); FormUtil.Set_Carrera(cboCarrera);
            cboGrupo.Items.Clear(); FormUtil.Set_Grupos(cboGrupo);
        }

        public void TamañoVisorEstandar()
        {
            Visor.RowTemplate.Resizable = DataGridViewTriState.True; Visor.RowTemplate.MinimumHeight = 55;
            Visor.RowTemplate.Height = 55; Visor.Height = 75;
        }

        public void TamañoVisorExpandido()
        {
            Visor.RowTemplate.Resizable = DataGridViewTriState.True; Visor.RowTemplate.MinimumHeight = 28;
            Visor.RowTemplate.Height = 28; Visor.Height = 165;
        }

        #region TS_Menu

        private void consultarHuellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Espere un momento...", "Conectando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Opciones.VerificacionForm Verificacion = new Opciones.VerificacionForm();
            if ((Verificacion.ShowDialog() == DialogResult.OK) && (Procesos.VerficiacionAdmin.Verif == "Correcto"))
            {
                Procesos.VerficiacionAdmin.Verif = ""; Verificacion.Close();
                AlumnosConsultarHuella ConsHuella = new AlumnosConsultarHuella();
                ConsHuella.txtAlumnoConsultar.Text = txtAlumnoConsultar.Text; ConsHuella.Show();
            } else { MessageBox.Show("No se pudo abrir la ventana porque la contraseña es incorrecta.", 
                "La contraseña es incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

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
        {
            try { AlumnosAgregar AgAlum = new AlumnosAgregar(); AgAlum.Show(); this.Close(); }
            catch { MessageBox.Show("Ocurrió un error al abrir esta ventana. Verifique que el programa ''Digital Persona One Touch for Windows SDK 1.4.0.1'' esté instalado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void consultarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en la sección ''Consultar Alumnos''.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        { MessageBox.Show("Ya se encuentra en la sección ''Consultar Alumnos''. Desde esta sección también se pueden eliminar los registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}

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
            { string AA = "Buen día, esta ventana le ayuda a buscar alumnos mediante distintos filtros..."
                    + "Introduzca el ide del usuario y visualice los datos, puede usar hasta 3 filtros de búsqueda diferentes y puede actualizar o dar de baja al usuario..."
                    + "Trate esta información con cuidado y si lo desea, puede visitar el Manual de Usuario en línea para más detalles.";
                SpeechSynthesizer SynthVoz = new SpeechSynthesizer(); SynthVoz.SetOutputToDefaultAudioDevice(); btnAA.Enabled = false;
                SynthVoz.Volume = 100; SynthVoz.SpeakAsync(AA); SynthVoz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(SynthVoz_Completed);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        { Limpiar(); }

        private void Limpiar()
        {
            txtAlumnoConsultar.Text = ""; chkBoleta.Checked = false; 
            chkBoleta.Enabled = true; lblNumBoleta.Enabled = false;
            txtAlumnoConsultar.Enabled = false;
            chkTurno.Checked = false; chkTurno.Enabled = true;
            lblTurno.Enabled = false; cboTurno.Enabled = false;
            cboTurno.SelectedIndex = -1;
            chkCarrera.Checked = false; chkCarrera.Enabled = true;
            lblCarrera.Enabled = false; cboCarrera.Enabled = false;
            cboCarrera.SelectedIndex = -1;
            chkGrupo.Checked = false; chkGrupo.Enabled = true;
            lblGrupo.Enabled = false; cboGrupo.Enabled = false;
            cboGrupo.SelectedIndex = -1;
            Visor.Visible = false; btnEliminar.Visible = false;
            btnActualizar.Visible = false; lblEncontrado.Visible = false;
            lblEncontrado.Text = "";
            ImgAlumno.Image = null; ImgAlumno.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkBoleta.Checked == true) { BuscarX_Boleta(txtAlumnoConsultar.Text); TamañoVisorEstandar(); }
            if (chkTurno.Checked == true) { BuscarX_Turno(cboTurno.SelectedItem.ToString()); }
            if (chkCarrera.Checked == true) { BuscarX_Carrera(cboCarrera.SelectedItem.ToString()); }
            if (chkGrupo.Checked == true) { BuscarX_Grupo(cboGrupo.SelectedItem.ToString()); }   
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void chkBoleta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoleta.Checked == true)
            {
                lblNumBoleta.Enabled = true; txtAlumnoConsultar.Enabled = true; TamañoVisorEstandar();
                chkTurno.Checked = false; chkTurno.Enabled = false;
                cboTurno.SelectedIndex = -1; lblTurno.Enabled = false;
                chkCarrera.Checked = false; chkCarrera.Enabled = false;
                cboCarrera.SelectedIndex = -1; lblCarrera.Enabled = false;
                chkGrupo.Checked = false; chkGrupo.Enabled = false;
                cboGrupo.SelectedIndex = -1;lblGrupo.Enabled = false;
            } else { Limpiar(); }
        }

        private void chkTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTurno.Checked == true)
            {
                lblTurno.Enabled = true; cboTurno.Enabled = true; TamañoVisorExpandido();
                chkBoleta.Checked = false; chkBoleta.Enabled = false;
                lblNumBoleta.Enabled = false; txtAlumnoConsultar.Text = String.Empty;
                txtAlumnoConsultar.Enabled = false;
                chkCarrera.Checked = false; chkCarrera.Enabled = false;
                cboCarrera.SelectedIndex = -1; lblCarrera.Enabled = false;
                chkGrupo.Checked = false; chkGrupo.Enabled = false;
                cboGrupo.SelectedIndex = -1; lblGrupo.Enabled = false;
            } else { Limpiar(); }
        }

        private void chkCarrera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarrera.Checked == true)
            {
                lblCarrera.Enabled = true; cboCarrera.Enabled = true; TamañoVisorExpandido();
                chkBoleta.Checked = false; chkBoleta.Enabled = false;
                lblNumBoleta.Enabled = false; txtAlumnoConsultar.Text = String.Empty;
                txtAlumnoConsultar.Enabled = false;
                chkTurno.Checked = false; chkTurno.Enabled = false;
                cboTurno.SelectedIndex = -1; lblTurno.Enabled = false;
                chkGrupo.Checked = false; chkGrupo.Enabled = false;
                cboGrupo.SelectedIndex = -1; lblGrupo.Enabled = false;
            } else { Limpiar(); }
        }

        private void chkGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrupo.Checked == true)
            {
                lblGrupo.Enabled = true; cboGrupo.Enabled = true; TamañoVisorExpandido();
                chkBoleta.Checked = false; chkBoleta.Enabled = false;
                lblNumBoleta.Enabled = false; txtAlumnoConsultar.Text = String.Empty;
                txtAlumnoConsultar.Enabled = false;
                chkTurno.Checked = false; chkTurno.Enabled = false;
                cboTurno.SelectedIndex = -1; lblTurno.Enabled = false;
                chkCarrera.Checked = false; chkCarrera.Enabled = false;
                cboCarrera.SelectedIndex = -1; lblCarrera.Enabled = false;
            } else { Limpiar(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtAlumnoConsultar.Enabled = false; DialogResult EliminarConfirmar;
            EliminarConfirmar = MessageBox.Show("¿Seguro que desea dar de baja este alumno?\nEsta acción no se puede deshacer.", "¿Eliminar alumno?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (EliminarConfirmar == DialogResult.OK)
            {
                try
                {
                    EliminarAlumno(txtAlumnoConsultar.Text); Limpiar(); chkBoleta.Checked = true;
                    MessageBox.Show("El alumno fue dado de baja correctamente.", "Alumno eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                catch (Exception)
                {
                    DialogResult ErrorEliminar;
                    ErrorEliminar = MessageBox.Show("Error al eliminar alumno. Si necesita ayuda, puede visitar nuestro Manual de Ayudas con información que puede ayudarle. \n¿Desea abrir el Manual de Ayudas?", 
                        "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    if (ErrorEliminar == DialogResult.Yes) { System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76dkZJU2JpUWc5OXM/view"); }  txtAlumnoConsultar.Enabled = true;
                }
            } else { txtAlumnoConsultar.Enabled = true; }
        }

        private void EliminarAlumno(string AlumnoBorrar)
        { Procesos.BajaAlumno(AlumnoBorrar); }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnosActualizar AA = new AlumnosActualizar();
                AA.txtNumBoleta.Text = Visor.CurrentRow.Cells[0].Value.ToString();
                AA.txtNombre.Text = Visor.CurrentRow.Cells[1].Value.ToString();
                AA.txtApP.Text = Visor.CurrentRow.Cells[2].Value.ToString();
                AA.txtApM.Text = Visor.CurrentRow.Cells[3].Value.ToString();
                AA.cboTurno.Text = Visor.CurrentRow.Cells[4].Value.ToString();
                AA.cboCarrera.Text = Visor.CurrentRow.Cells[5].Value.ToString();
                AA.cboGrupo.Text = Visor.CurrentRow.Cells[6].Value.ToString();
                AA.txtNombreTutor.Text = Visor.CurrentRow.Cells[7].Value.ToString();
                AA.txtEmailTutor.Text = Visor.CurrentRow.Cells[8].Value.ToString();
                AA.ImgAlumno.Image = ImgAlumno.Image; AA.Show();
            }
            catch { MessageBox.Show("Ocurrió un error al abrir esta ventana. Verifique que el programa ''Digital Persona One Touch for Windows SDK 1.4.0.1'' esté instalado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        #region Metodos busqueda alumnos

        private void BuscarFoto()
        {
            string ID = Visor.CurrentRow.Cells[0].Value.ToString();

            try
            {
                string sConexion = Procesos.CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Alumnos WHERE Boleta = @Boleta", cnn);
                SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                DataSet AjusteDatos = new DataSet();
                AdaptadorDeDatos.SelectCommand.Parameters.Add("@Boleta", SqlDbType.Int);
                AdaptadorDeDatos.SelectCommand.Parameters["@Boleta"].Value = ID.Trim();

                AdaptadorDeDatos.Fill(AjusteDatos, "tb_Alumnos");

                if (AjusteDatos.Tables["tb_Alumnos"].Rows.Count != 0)
                {
                    byte[] imageBuffer = (byte[])AjusteDatos.Tables["tb_Alumnos"].Rows[0]["Foto"];
                    MemoryStream ms = new MemoryStream(imageBuffer);
                    ImgAlumno.Visible = true; ImgAlumno.Image = Image.FromStream(ms);
                } else { MessageBox.Show("No se pudo encontrar el alumno al momento de realizar la búsqueda de la imagen..."); }
            }
            catch { MessageBox.Show("No se pudo recuperar la imagen del alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void BuscarX_Boleta(string Alumn_Boleta)
        {
            Visor.DataSource = Procesos.ConsAlum_1(Alumn_Boleta);

            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; btnActualizar.Visible = true;
                btnEliminar.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "ALUMNO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen; BuscarFoto();
            }

            else
            {
                MessageBox.Show("No se puede encontrar el alumno.\nCompruebe si el alumno existe o si escribió correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; btnActualizar.Visible = false; btnEliminar.Visible = false;
                lblEncontrado.Visible = true; ImgAlumno.Visible = false;
                lblEncontrado.Text = "ALUMNO NO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        private void BuscarX_Turno(string Alumno_Turno)
        {
            Visor.DataSource = Procesos.ConsAlum_2(Alumno_Turno);

            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "TURNO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen;
            }

            else
            {
                MessageBox.Show("No se puede encontrar el turno, compruebe si los parámetros son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; lblEncontrado.Visible = true;
                lblEncontrado.Text = "TURNO NO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        private void BuscarX_Carrera(string Alum_ID)
        {
            Visor.DataSource = Procesos.ConsAlum_3(Alum_ID);

            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "CARRERA ENCONTRADA EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen;
            }

            else
            {
                MessageBox.Show("No se puede encontrar la carrera, compruebe si los parámetros son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; lblEncontrado.Visible = true;
                lblEncontrado.Text = "CARRERA NO ENCONTRADA EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        private void BuscarX_Grupo(string Alum_Grupo)
        {
            Visor.DataSource = Procesos.ConsAlum_4(Alum_Grupo);

            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "GRUPO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen;
            }

            else
            {
                MessageBox.Show("No se puede encontrar el grupo, compruebe si los parámetros son correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; lblEncontrado.Visible = true;
                lblEncontrado.Text = "GRUPO NO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        #endregion


        private void txtAlumnoConsultar_KeyPress(object sender, KeyPressEventArgs e)
        { Procesos.SoloNum(e); }

        private void AlumnosConsultar_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }

        private void AlumnosConsultar_MouseMove(object sender, MouseEventArgs e)
        { Procesos.VerficiarSesion(); }     
    }
}
