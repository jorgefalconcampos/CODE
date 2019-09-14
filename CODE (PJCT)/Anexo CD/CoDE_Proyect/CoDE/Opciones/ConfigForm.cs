using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        { InitializeComponent(); }

        private void MostrarDatos()
        {
            cboTurno.Items.Clear(); FormUtil.Set_Turno(cboTurno);
            cboCarrera.Items.Clear(); FormUtil.Set_Carrera(cboCarrera);
            cboGrupo.Items.Clear(); FormUtil.Set_Grupos(cboGrupo);
        }

        private void Verif()
        {
            if (CODE.Default.Verif_Escan == true) { chkVerif.Checked = true; }
            if (CODE.Default.Verif_Escan == false) { chkVerif.Checked = false; }
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        { MostrarDatos(); Verif(); ValorPaginaActual = "Pagina1"; }

        string ValorPaginaActual;


        #region Pagina1

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            DialogResult Restablecer;
            Restablecer = MessageBox.Show("Toda la configuración (cuentas de usuario, servicio de email, ajustes establecidos, turnos, carreras y grupos) será restablecida. "
                + "\n¿Seguro que desea continuar?", "¿Restablcer configuración?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Restablecer == DialogResult.Yes)
            {
                MessageBox.Show("Espere un momento...", "Conectando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerificacionForm Verificacion = new VerificacionForm();
                if ((Verificacion.ShowDialog() == DialogResult.OK) && (Procesos.VerficiacionAdmin.APVerif == "P.Correcto"))
                { Procesos.VerficiacionAdmin.APVerif = ""; CODE.Default.Reset(); MessageBox.Show("Toda la configuración fue restablecida.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Al parecer se intentó validar la contraseña de un Administrador, pero el procesó falló. "
                    + "\nSolo el Administrador principal puede ejecutar esta acción.", "Contraseña no válida", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void chkVerif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerif.Checked == true) { CODE.Default.Verif_Escan = true; }
            if (chkVerif.Checked == false) { CODE.Default.Verif_Escan = false; }
        }

        private void btnConexion_Click(object sender, EventArgs e)
        { ConexionConfig CC = new ConexionConfig(); CC.Show(); }

        #endregion


        #region Pagina2

        string TurnoEliminar; string CarreraEliminar; string GrupoEliminar;

        private bool Errores()
        {
            if (txtHost.Text.Trim() == String.Empty) return true;
            if (ValidarHost(txtHost.Text) == false) return true;
            if (txtPuerto.Text.Trim() == String.Empty) return true;
            if (txtUsuario.Text.Trim() == String.Empty) return true;
            if (ValidarEmail(txtUsuario.Text) == false) return true;
            if (txtPassword.Text.Trim() == String.Empty) return true;
            return false;
        }

        private void InfoP2_Click(object sender, EventArgs e)
        { MessageBox.Show("Considere que los valores recién añadidos pueden no aparecer en tiempo real cuando se consulten. "
            + "Para mostrar los valores actuales, presione el botón azul de actualizar para recargar los datos.",
            "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void Recargar_Click(object sender, EventArgs e)
        {
            ProgressBar(); try { MostrarDatos(); if (cboCarrera.Items.Count > 0) { MessageBox.Show("Información cargada correctamente.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Information); BarraProgreso.Value = 0; }
                else { DialogResult Error; Error = MessageBox.Show("Error al recuperar la información. ¿Intentar de nuevo?",
                    "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    if (Error == DialogResult.Retry) { ProgressBar(); MostrarDatos(); BarraProgreso.Value = 0; } }
            }
            catch (Exception)
            { MessageBox.Show("Ocurrió un error al tratar de recuperar la información.",
                "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); BarraProgreso.Value = 0; }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            ProgressBar(); if (txtNuevoTurno.Text == String.Empty) { MessageBox.Show("No puede dejar el campo ''Turno'' en blanco.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0; }
            else
            { DialogResult AgregarTurno; AgregarTurno = MessageBox.Show("¿Agregar el turno ''" + txtNuevoTurno.Text + "'' a la lista de turnos?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (AgregarTurno == DialogResult.Yes) { CODE.Default.Turnos.Add(txtNuevoTurno.Text); BarraProgreso.Value = 0;
                    MessageBox.Show("Turno agregado correctamente. Recuerde recargar los datos para verificar que sean correctos y guardar los cambios antes cambiar de pestaña o cerrar esta ventana.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNuevoTurno.Text = ""; }
            }
        }

        private void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
            ProgressBar(); if (txtNuevaCarrera.Text == String.Empty)
            { MessageBox.Show("No puede dejar el campo ''Carrera'' en blanco.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0; }
            else
            { DialogResult AgregarCarrera; AgregarCarrera = MessageBox.Show("¿Agregar la carrera ''" + txtNuevaCarrera.Text + "'' a la lista de carreras?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (AgregarCarrera == DialogResult.Yes) { CODE.Default.Carreras.Add(txtNuevaCarrera.Text); BarraProgreso.Value = 0;
                    MessageBox.Show("Carrera agregada correctamente. Recuerde recargar los datos para verificar que sean correctos y guardar los cambios antes cambiar de pestaña o cerrar esta ventana.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNuevaCarrera.Text = ""; }
            }
        }

        private void bntAgregarGrupo_Click(object sender, EventArgs e)
        {
            ProgressBar(); if (txtNuevoGrupo.Text == String.Empty) { MessageBox.Show("No puede dejar el campo ''Grupo'' en blanco.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0; }
            else
            { DialogResult AgregarGrupo; AgregarGrupo = MessageBox.Show("¿Agregar el grupo ''" + txtNuevoGrupo.Text + "'' a la lista de grupos?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (AgregarGrupo == DialogResult.Yes) { CODE.Default.Grupos.Add(txtNuevoGrupo.Text); BarraProgreso.Value = 0;
                    MessageBox.Show("Grupo agregado correctamente. Recuerde recargar los datos para verificar que sean correctos y guardar los cambios antes cambiar de pestaña o cerrar esta ventana.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information); txtNuevaCarrera.Text = ""; }
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            ProgressBar(); if (cboTurno.SelectedIndex.Equals(-1)) { MessageBox.Show("Primero seleccione un turno para dar de baja.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0; }
            else
            {
                TurnoEliminar = cboTurno.SelectedItem.ToString();
                DialogResult EliminarTurno; EliminarTurno = MessageBox.Show("¿Dar de baja el turno ''" + cboTurno.SelectedItem.ToString() + "'' de la lista de turnos?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
                if (EliminarTurno == DialogResult.Yes) { CODE.Default.Turnos.Remove(cboTurno.SelectedItem.ToString()); BarraProgreso.Value = 0;
                    MessageBox.Show("Turno eliminado correctamente. Recuerde recargar los datos para verificar que sean correctos y guardar los cambios antes cambiar de pestaña o cerrar esta ventana.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void btnEliminarCarrera_Click(object sender, EventArgs e)
        {
            ProgressBar(); if (cboCarrera.SelectedIndex.Equals(-1)) { MessageBox.Show("Primero seleccione una carrera para dar de baja.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0; }
            else
            {
                CarreraEliminar = cboCarrera.SelectedItem.ToString();
                DialogResult EliminarCarrera; EliminarCarrera = MessageBox.Show("¿Dar de baja la carrera ''" + cboCarrera.SelectedItem.ToString() + "'' de la lista de carreras?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
                if (EliminarCarrera == DialogResult.Yes) { CODE.Default.Carreras.Remove(cboCarrera.SelectedItem.ToString()); BarraProgreso.Value = 0;
                    MessageBox.Show("Carrera eliminada correctamente. Recuerde recargar los datos para verificar que sean correctos y guardar los cambios antes cambiar de pestaña o cerrar esta ventana.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            ProgressBar(); if (cboGrupo.SelectedIndex.Equals(-1))
            { MessageBox.Show("Primero seleccione un grupo para dar de baja.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BarraProgreso.Value = 0; }
            else
            {
                GrupoEliminar = cboGrupo.SelectedItem.ToString();
                DialogResult EliminarGrupo; EliminarGrupo = MessageBox.Show("¿Dar de baja el grupo ''" + cboGrupo.SelectedItem.ToString() + "'' de la lista de grupos?",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
                if (EliminarGrupo == DialogResult.Yes) { CODE.Default.Grupos.Remove(cboGrupo.SelectedItem.ToString()); BarraProgreso.Value = 0;
                    MessageBox.Show("Grupo eliminado correctamente. Recuerde recargar los datos para verificar que sean correctos y guardar los cambios antes cambiar de pestaña o cerrar esta ventana.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }


        #region Elimnar

        private void Eliminar()
        {
            if (TurnoEliminar != String.Empty) { BorrarTurno(TurnoEliminar); }
            if (CarreraEliminar != String.Empty) { BorrarCarrera(CarreraEliminar); }
            if (GrupoEliminar != String.Empty) { BorrarGrupo(GrupoEliminar); }
        }

        private void BorrarTurno(string Turno)
        { try { Procesos.EliminarTurnoCLASE(Turno); cboTurno.SelectedItem = -1; } catch { MessageBox.Show("Ocurrió un error al elimnar de la base de datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); } }

        private void BorrarCarrera(string Carrera)
        { try { Procesos.EliminarCarreraCLASE(Carrera); cboCarrera.SelectedItem = -1; } catch { MessageBox.Show("Ocurrió un error al elimnar de la base de datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); } }

        private void BorrarGrupo(string Grupo)
        { try { Procesos.EliminarGrupoCLASE(Grupo); cboGrupo.SelectedItem = -1; } catch { MessageBox.Show("Ocurrió un error al elimnar de la base de datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); } }

        #endregion

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCarrera.SelectedItem = -1; cboTurno.SelectedItem = -1;
            lblEstado.Text = "Turno seleccionado: " + cboTurno.SelectedItem;
        }

        private void cboCarrera_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboTurno.SelectedItem = -1; cboGrupo.SelectedItem = -1;
            lblEstado.Text = "Carrera seleccionada: " + cboCarrera.SelectedItem;
        }

        private void cboGrupo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboTurno.SelectedItem = -1; cboCarrera.SelectedItem = -1;
            lblEstado.Text = "Grupo seleccionado: " + cboGrupo.SelectedItem;
        }

        #endregion


        #region Pagina3
        private void QuestionIcono_Click(object sender, EventArgs e)
        { MessageBox.Show("Configure una dirección de correo electrónico para enviar mensajes y recibir informes. "
            + "Escriba el dominio del servicio SMTP, el puerto, su nombre de usuario y su contraseña.",
              "Configuración de Email", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void InfoHost_Click_1(object sender, EventArgs e)
        { MessageBox.Show("Escriba un nombre completo de dominio del servicio que se usará para las transacciones SMTP. "
            + "Por ejemplo: ''smtp.gmail.com'', ''smtp-mail.outlook.com'', ''smtp.mail.yahoo.com'' etc. (sin comillas).", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void InfoPuerto_Click(object sender, EventArgs e)
        { MessageBox.Show("Escriba el puerto de conexión. \n - Con SSL: 465\n - Sin SSL: 587, 2525, 8025 \nTenga en cuenta que el correcto funcionamiento de esta "
            + "función depende también de diversos factores externos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked == true)
            { txtPassword.UseSystemPasswordChar = false; }
            else { txtPassword.UseSystemPasswordChar = true; }
        }
        private void txtHost_Leave(object sender, EventArgs e)
        {
            if (ValidarHost(txtHost.Text)) { }
            else { MessageBox.Show("El formato del dominio no es válido.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtHost.SelectAll(); }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(txtUsuario.Text)) { }
            else { MessageBox.Show("El formato del email no es válido.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtUsuario.SelectAll(); }
        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        { Procesos.SoloNum(e); }

        public static bool ValidarEmail(string Email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(Email, expresion))
            {
                if (Regex.Replace(Email, expresion, string.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }

        public static bool ValidarHost(string Host)
        {
            string expresion = "^[a-zA-Z0-9_\\-\\.~]{2,}\\.[a-zA-Z0-9_\\-\\.~]{2,}\\.[a-zA-Z]{2,4}$";
            if (Regex.IsMatch(Host, expresion))
            {
                if (Regex.Replace(Host, expresion, string.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }
    
        #endregion


        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValorPaginaActual == "Pagina1")
                { MessageBox.Show("Los cambios fueron guardados.", "Listo", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information); CODE.Default.Save(); }

                if (ValorPaginaActual == "Pagina2")
                { MessageBox.Show("Los cambios fueron guardados.", "Listo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information); CODE.Default.Save(); Eliminar();}

                if (ValorPaginaActual == "Pagina3")
                {
                    if (Errores()) { MessageBox.Show("Error en los datos o en la configuración del Email.\nNo se aplicó ningún cambio.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        CODE.Default.Email_Host = txtHost.Text; CODE.Default.Email_Puerto = Convert.ToInt32(txtPuerto.Text);
                        CODE.Default.Email_User = txtUsuario.Text; CODE.Default.Email_Pass = txtPassword.Text;
                        CODE.Default.Save(); MessageBox.Show("Los cambios fueron guardados.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch { MessageBox.Show("Ocurrió un error inesperado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SeleccionConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionConfig.SelectedTab == Pagina1)
            { ValorPaginaActual = "Pagina1"; }
            if (SeleccionConfig.SelectedTab == Pagina2)
            { ValorPaginaActual = "Pagina2"; ProgressBar();
                if (cboCarrera.Items.Count > 0)
                { MessageBox.Show("Información cargada correctamente.", 
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information); BarraProgreso.Value = 0; }
                else
                { DialogResult Error; Error = MessageBox.Show("Error al recuperar la información. ¿Intentar de nuevo?", 
                    "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    if (Error == DialogResult.Retry)
                    { ProgressBar(); MostrarDatos(); BarraProgreso.Value = 0; } }
            }
            else { BarraProgreso.Value = 0; TurnoEliminar = String.Empty; CarreraEliminar = String.Empty; GrupoEliminar = String.Empty; }
            if (SeleccionConfig.SelectedTab == Pagina3)
            { ValorPaginaActual = "Pagina3"; }
        }

        private void ProgressBar()
        {
            Random rnd = new Random();
            int Progreso = rnd.Next(70, 80);
            for (int i = Progreso; i <= 150; i++)
            { BarraProgreso.Increment(i); }
        }

        private void btnVerActuales_Click(object sender, EventArgs e)
        {
            btnVerActuales.Visible = false; btnOcultarActuales.Visible = true;
            txtHost.Text = CODE.Default.Email_Host; int Puerto; Puerto = CODE.Default.Email_Puerto;
            txtPuerto.Text = Convert.ToString(Puerto); txtUsuario.Text = CODE.Default.Email_User;
            txtPassword.Text = CODE.Default.Email_Pass; txtCuerpo.Text = CODE.Default.Email_Body;
        }

        private void btnOcultarActuales_Click(object sender, EventArgs e)
        {
            btnOcultarActuales.Visible = false; 
            btnVerActuales.Visible = true; txtHost.Text = "";
            txtPuerto.Text = ""; txtUsuario.Text = "";
            txtPassword.Text = ""; txtCuerpo.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}

