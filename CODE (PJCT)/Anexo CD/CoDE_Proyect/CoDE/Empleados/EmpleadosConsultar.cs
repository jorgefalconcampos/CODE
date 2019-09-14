using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Speech.Synthesis;

namespace CoDE_Proyect.CoDE.Empleados
{
    public partial class EmpleadosConsultar : Form
    {
        public EmpleadosConsultar()
        { InitializeComponent(); }

        private void EmpleadosConsultar_Load(object sender, EventArgs e)
        { txtNombres.AutoCompleteCustomSource = Procesos.ConsEmp_3_1(); MostrarDatos(); }

        private void MostrarDatos()
        { cboTurno.Items.Clear(); FormUtil.Set_Turno(cboTurno); }

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
                Procesos.VerficiacionAdmin.Verif = "";
                Verificacion.Close();
                EmpleadosConsultarHuella ConsHuella = new EmpleadosConsultarHuella();
                ConsHuella.txtEmpleadoConsultar.Text = txtEmpleadoConsultar.Text;
                ConsHuella.Show();
            }

            else
            { MessageBox.Show("No se pudo abrir la ventana porque la contraseña es incorrecta.",
                "La contraseña es incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

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
        {
            MessageBox.Show("Ya se encuentra en la sección ''Consultar Empleados''.",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya se encuentra en la sección ''Consultar Empleados''. Desde esta sección también se pueden eliminar los registros",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

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
            { string AA = "Buen día, esta ventana le ayuda a buscar empleados mediante distintos filtros..."
                    + "Introduzca el ide del usuario y visualice los datos, puede agregar filtros de búsqueda y puede actualizar o dar de baja al usuario..."
                    + "Trate esta información con cuidado y si lo desea, puede visitar el Manual de Usuario en línea para más detalles.";
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        { Limpiar(); }

        private void Limpiar()
        {
            txtEmpleadoConsultar.Text = ""; Visor.Visible = false;
            btnEliminar.Visible = false; btnActualizar.Visible = false;
            lblEncontrado.Visible = false; lblEncontrado.Text = "";
            ImgEmpleado.Image = null; ImgEmpleado.Visible = false;
            chkNumEmp.Checked = false; chkNumEmp.Enabled = true;
            lblNumEmp.Enabled = false; txtEmpleadoConsultar.Enabled = false;
            chkTurno.Checked = false; chkTurno.Enabled = true;
            lblTurno.Enabled = false; cboTurno.SelectedIndex = -1; cboTurno.Enabled = false;
            chkNombre.Checked = false; chkNombre.Enabled = true;
            lblNombre.Enabled = false; txtNombres.Text = ""; txtNombres.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkNumEmp.Checked == true) { BuscarX_NumEmp(txtEmpleadoConsultar.Text); }
            if (chkTurno.Checked == true) { BuscarX_Turno(cboTurno.SelectedItem.ToString()); TamañoVisorExpandido(); }
            if (chkNombre.Checked == true) { BuscarX_Nombres(txtNombres.Text); TamañoVisorEstandar(); }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void chkNumEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumEmp.Checked == true)
            {
                chkTurno.Checked = false; chkTurno.Enabled = false;
                chkNombre.Checked = false; chkNombre.Enabled = false;
                lblNumEmp.Enabled = true; txtEmpleadoConsultar.Enabled = true;
                TamañoVisorEstandar();
            }
            if (chkNumEmp.Checked == false) { Limpiar(); }
        }

        private void chkTurno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTurno.Checked == true)
            {
                chkNumEmp.Checked = false; chkNumEmp.Enabled = false;
                chkNombre.Checked = false; chkNombre.Enabled = false;
                lblTurno.Enabled = true; cboTurno.Enabled = true;
                TamañoVisorExpandido();
            }
            if (chkTurno.Checked == false) { Limpiar(); TamañoVisorEstandar(); }
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked == true)
            {
                chkNumEmp.Checked = false; chkNumEmp.Enabled = false;
                chkTurno.Checked = false; chkTurno.Enabled = false;
                lblNombre.Enabled = true; txtNombres.Enabled = true;
                TamañoVisorEstandar();
            }
            if (chkNombre.Checked == false) { Limpiar(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtEmpleadoConsultar.Enabled = false;
            DialogResult EliminarConfirmar;
            EliminarConfirmar = MessageBox.Show("¿Seguro que desea dar de baja a este empleado?\nEsta acción no se puede deshacer.", 
                "¿Eliminar empleado?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (EliminarConfirmar == DialogResult.OK)
            {
                try {
                    if (chkNombre.Checked == true) { EliminarEmpleado(Visor.CurrentRow.Cells[0].Value.ToString()); }
                    else { EliminarEmpleado(txtEmpleadoConsultar.Text); } Limpiar();
                    MessageBox.Show("El empleado fue dado de baja correctamente.", "Empleado eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    DialogResult ErrorEliminar;
                    ErrorEliminar = MessageBox.Show("Error al eliminar empleado. Si necesita ayuda, puede visitar nuestro Manual de Ayudas con información que puede ayudarle." 
                        + " \n¿Desea abrir el Manual de Ayudas?", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    if (ErrorEliminar == DialogResult.Yes) { System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76dkZJU2JpUWc5OXM/view"); } 
                    txtEmpleadoConsultar.Enabled = true;
                }
            } else { txtEmpleadoConsultar.Enabled = true; }
        }

        private void EliminarEmpleado(string EmpleadoBorrar)
        { Procesos.EliminarEmpleadoCLASE(EmpleadoBorrar); }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EmpleadosActualizar EA = new EmpleadosActualizar();
            EA.txtNumEmp.Text = Visor.CurrentRow.Cells[0].Value.ToString();
            EA.txtNombre.Text = Visor.CurrentRow.Cells[1].Value.ToString();
            EA.txtApP.Text = Visor.CurrentRow.Cells[2].Value.ToString();
            EA.txtApM.Text = Visor.CurrentRow.Cells[3].Value.ToString();
            EA.cboTurno.Text = Visor.CurrentRow.Cells[4].Value.ToString();
            EA.txtEmail.Text = Visor.CurrentRow.Cells[5].Value.ToString();
            EA.ImgEmpleado.Image = ImgEmpleado.Image; EA.Show();
        }


        #region Metodos busqueda empleados

        private void BuscarFoto()
        {
            string ID = Visor.CurrentRow.Cells[0].Value.ToString();

            try
            {
                string sConexion = Procesos.CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_Empleados WHERE NumeroEmpleado = @NumeroEmpleado", cnn);
                SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                DataSet AjusteDatos = new DataSet();
                AdaptadorDeDatos.SelectCommand.Parameters.Add("@NumeroEmpleado", SqlDbType.NVarChar, 30);
                AdaptadorDeDatos.SelectCommand.Parameters["@NumeroEmpleado"].Value = ID.Trim();

                AdaptadorDeDatos.Fill(AjusteDatos, "tb_Empleados");

                if (AjusteDatos.Tables["tb_Empleados"].Rows.Count != 0)
                {
                    byte[] imageBuffer = (byte[])AjusteDatos.Tables["tb_Empleados"].Rows[0]["Foto"];
                    MemoryStream ms = new MemoryStream(imageBuffer);
                    ImgEmpleado.Visible = true;
                    ImgEmpleado.Image = Image.FromStream(ms);
                }
                else { MessageBox.Show("No se pudo encontrar el empleado al momento de realizar la búsqueda de la imagen..."); }
            }
            catch { MessageBox.Show("No se pudo recuperar la imagen del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
        }

        private void BuscarX_NumEmp(string EmpleadoConsultado)
        {
            Visor.DataSource = Procesos.ConsEmp_1(EmpleadoConsultado);

            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; btnActualizar.Visible = true;
                btnEliminar.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "EMPLEADO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen; BuscarFoto();
            }

            else
            {
                MessageBox.Show("No se puede encontrar el empleado.\nCompruebe si el empleado existe o si escribió correctamente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; btnActualizar.Visible = false; btnEliminar.Visible = false;
                lblEncontrado.Visible = true; ImgEmpleado.Visible = false;
                lblEncontrado.Text = "EMPLEADO NO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        private void BuscarX_Turno(string Emp_Turno)
        {
            Visor.DataSource = Procesos.ConsEmp_2(Emp_Turno);

            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "TURNO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen;
            }

            else
            {
                MessageBox.Show("No se puede encontrar el turno. Compruebe si los parámetros son correctos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; lblEncontrado.Visible = true;
                lblEncontrado.Text = "TURNO NO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        private void BuscarX_Nombres(string NombreCompleto)
        {
            Visor.DataSource = Procesos.ConsEmp_4(NombreCompleto);

            if (Visor.Rows.Count > 0)
            {
                Visor.Visible = true; btnEliminar.Visible = true;
                lblEncontrado.Visible = true; lblEncontrado.Text = "EMPLEADO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen; BuscarFoto();
            }

            else
            {
                MessageBox.Show("No se pudo encontrar a este empleado. Compruebe si los parámetros son correctos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Visor.Visible = false; lblEncontrado.Visible = true;
                lblEncontrado.Text = "EMPLEADO NO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        #endregion


        private void txtEmpleadoConsultar_KeyPress(object sender, KeyPressEventArgs e)
        { Procesos.Num_Letras(e); }

        private void EmpleadosConsultar_MouseMove(object sender, MouseEventArgs e)
        { Procesos.VerficiarSesion(); }

        private void EmpleadosConsultar_FormClosing(object sender, FormClosingEventArgs e)
        { if (Procesos.CerrarSesionPress) { Procesos.CerrarSesion(e); } }
    }
}
