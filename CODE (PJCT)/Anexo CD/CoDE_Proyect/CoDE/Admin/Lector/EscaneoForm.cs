using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Neurotec.Biometrics;
using Neurotec.Gui;
using System.Threading;
using System.Data.SqlClient;

namespace Escaneo
{
	public partial class EscaneoForm : Form
	{
        private void EscaneoForm_Load(object sender, EventArgs e)
        {
            foreach (NffvUser engineUser in Engine.Users)
            {
                string id = engineUser.Id.ToString();
                RegisUsuario userRec = BDD_UltimosReg.Lookup(engineUser.Id);
                if (userRec != null)
                { id = userRec.Name; }
                RegistrosBDD.Items.Add(new CData(engineUser, id));
            }
            if (RegistrosBDD.Items.Count > 0) { RegistrosBDD.SelectedIndex = 0; } Max();
        }

        public static Nffv Engine;
        string BDD_Usuario;
        UsuarioBDD BDD_UltimosReg;
        byte[] HuellaEnBytes;

        private void Max()
        {
            if (RegistrosBDD.Items.Count == 10)
            {
                MessageBox.Show("Los registros recientes se limpiarán, se alcanzó el límite de 10 items.",
                  "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Engine.Users.Clear(); RegistrosBDD.Items.Clear();
            }
        }

        public EscaneoForm(Nffv engine, string Usuario_BaseDD)
		{
            Engine = engine;
            BDD_Usuario = Usuario_BaseDD;
			try { BDD_UltimosReg = UsuarioBDD.ReadFromFile(Usuario_BaseDD); }
			catch { BDD_UltimosReg = new UsuarioBDD(); }
			InitializeComponent();
		}

		internal class EnrollmentResult
		{
			public NffvStatus engineStatus;
			public NffvUser engineUser;
		}

		private void doEnroll(object sender, DoWorkEventArgs args)
		{
			EnrollmentResult ResultRegistro = new EnrollmentResult(); 
            ResultRegistro.engineUser = Engine.Enroll(20000, out ResultRegistro.engineStatus);
			args.Result = ResultRegistro;
		}

		internal class VerificationResult
		{
			public NffvStatus EngineStatus;
			public int Puntos;
		}

        private void verÚltimosRegistrosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (verÚltimosRegistrosToolStripMenuItem.CheckState == CheckState.Checked)
            { RegistrosBDD.Visible = true; btnEliminarRegistro.Visible = true; }

            if (verÚltimosRegistrosToolStripMenuItem.CheckState == CheckState.Unchecked)
            { RegistrosBDD.Visible = false; btnEliminarRegistro.Visible = false; }
        }

        private void limpiarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar los registros recientes de la Base de Datos?\nEsta acción no se puede deshacer.", 
                "¿Eliminar los registros?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            { return; }

            Engine.Users.Clear(); RegistrosBDD.Items.Clear(); BDD_UltimosReg.Clear();
            try { BDD_UltimosReg.WriteToFile(BDD_Usuario); } catch { }
        }

        private void regresarYSeleccionarLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread Hilo = new Thread(() => Escaneo.Program2.Second());
            Hilo.SetApartmentState(ApartmentState.STA);
            Hilo.Start();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión actual: " + CoDE_Proyect.Procesos.SesionDeAdmin.SA + "\n\nHora de inicio de Sesión: " + CoDE_Proyect.Procesos.SesionDeAdmin.SH,
               "Información de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void informarDeUnErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoDE_Proyect.CoDE.Opciones.InformarError InformarError = new CoDE_Proyect.CoDE.Opciones.InformarError();
            InformarError.Show();
        }

        private void btnEscanearHuella_Click(object sender, EventArgs e)
        {
            RegistroForm RegistroDialog = new RegistroForm();
            if (RegistroDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    RunWorkerCompletedEventArgs taskResult = CargaForm.RunLongTask_3("Esperando una huella...", new DoWorkEventHandler(doEnroll), false, null, new EventHandler(CancelScanningHandler));

                    EnrollmentResult ResultRegistro = (EnrollmentResult)taskResult.Result;

                    if (ResultRegistro.engineStatus == NffvStatus.TemplateCreated)
                    {
                        NffvUser EngineUser = ResultRegistro.engineUser;
                        string userName = RegistroDialog.UserName;
                        if (userName.Length <= 0)
                        { userName = EngineUser.Id.ToString(); }

                        BDD_UltimosReg.Add(new RegisUsuario(EngineUser.Id, userName));
                        try { BDD_UltimosReg.WriteToFile(BDD_Usuario); } catch { }
                        RegistrosBDD.Items.Add(new CData(EngineUser, userName));
                        RegistrosBDD.SelectedIndex = RegistrosBDD.Items.Count - 1;

                        ImagenHuellaEx.Image = EngineUser.GetBitmap();
                        Image img = EngineUser.GetBitmap();
                        byte[] arr;
                        ImageConverter converter = new ImageConverter();
                        arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                        HuellaEnBytes = arr;
                    }
                    else
                    {
                        NffvStatus EstadoEnginge = ResultRegistro.engineStatus;
                        MessageBox.Show(string.Format("El registro no fue finalizado. Razón: {0}", EstadoEnginge), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnGuardarHuella_Click(object sender, EventArgs e)
        {
            ProgressBar();
            try { BuscarAlumno(RegistrosBDD.SelectedItem.ToString()); }
            catch (Exception)
            { MessageBox.Show("Seleccione un usuario del registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void BuscarAlumno(string HuellaAlum_Cons)
        {
            Visor.DataSource = CoDE_Proyect.Procesos.ConsAlum_1(HuellaAlum_Cons);

            if (Visor.Rows.Count > 0)
            {
                lblMensajeHuella.Visible = true;
                lblMensajeHuella.Text = "Alumno encontrado.";
                lblMensajeHuella.ForeColor = Color.ForestGreen;

                try
                {
                    string sConexion = CoDE_Proyect.Procesos.CadenaConexion;
                    SqlConnection cnn = new SqlConnection(sConexion);
                    SqlCommand cmd = new SqlCommand("SP_AlumnoInsertarHUELLA", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BoletaID", SqlDbType.Int).Value = RegistrosBDD.SelectedItem.ToString();
                    cmd.Parameters.Add("@HuellaINS", SqlDbType.VarBinary).Value = HuellaEnBytes;
                    cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close();
                    lblMensajeHuella.Visible = true;
                    lblMensajeHuella.Text = "Listo, puede cerrar esta ventana.";
                    lblMensajeHuella.ForeColor = Color.ForestGreen;
                     MessageBox.Show("La huella de " + RegistrosBDD.SelectedItem.ToString() + " fue creada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     BarraProgreso.Value = 0; 
                }
                catch
                {
                   MessageBox.Show("Parece que el usuario " + RegistrosBDD.SelectedItem.ToString() +
                    " existe en la Base de Datos, pero hubo un problema al guardar la huella digitalizada. Pruebe eliminando el registro y escaneando la huella otra vez.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BarraProgreso.Value = 0; 
                }
            }
            else
            {
                MessageBox.Show("No se puede encontrar el usuario " + RegistrosBDD.SelectedItem.ToString()
                    + ". Para asociar una huella digital a este registro, primero el usuario debe de ser registrado correctamente en la ventana de registro.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BarraProgreso.Value = 0; 
                lblMensajeHuella.Visible = true;
                lblMensajeHuella.Text = "Alumno no ncontrado.";
                lblMensajeHuella.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        private void btnVerificarHuella_Click(object sender, EventArgs e)
        {
            if (RegistrosBDD.SelectedIndex < 0)
            { MessageBox.Show("Seleccione un registro de la Base de Datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                try
                {
                    RunWorkerCompletedEventArgs taskResult = CargaForm.RunLongTask_3("Esperando una huella...", new DoWorkEventHandler(doVerify),
                        false, ((CData)RegistrosBDD.SelectedItem).EngineUser, new EventHandler(CancelScanningHandler));

                    VerificationResult verificationResult = (VerificationResult)taskResult.Result;

                    if (verificationResult.EngineStatus == NffvStatus.TemplateCreated)
                    {
                        if (verificationResult.Puntos > 0)
                        { MessageBox.Show(string.Format("Usaurio {0} verificado, las huellas coinciden.\r\nPuntos que coinciden: {1}", 
                            ((CData)RegistrosBDD.SelectedItem).Nombre, verificationResult.Puntos), "Usuario verificado", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        else
                        { MessageBox.Show(string.Format("Usuario {0} no verficiado, las huellas no coinciden.\r\nPuntos que coinciden: {1}", 
                            ((CData)RegistrosBDD.SelectedItem).Nombre, verificationResult.Puntos), "Usuario no verificado", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }

                    else
                    { MessageBox.Show(string.Format("La verificación no pudo ser finalizada. Razón: {0}", 
                        verificationResult.EngineStatus), "Verficiación incompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnEscanearHuellaE_Click(object sender, EventArgs e)
        {
            RegistroForm RegistroDialog = new RegistroForm();
            if (RegistroDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    RunWorkerCompletedEventArgs taskResult = CargaForm.RunLongTask_3("Esperando una huella...", new DoWorkEventHandler(doEnroll), false, null, new EventHandler(CancelScanningHandler));

                    EnrollmentResult ResultRegistro = (EnrollmentResult)taskResult.Result;

                    if (ResultRegistro.engineStatus == NffvStatus.TemplateCreated)
                    {
                        NffvUser EngineUser = ResultRegistro.engineUser;
                        string userName = RegistroDialog.UserName;
                        if (userName.Length <= 0)
                        { userName = EngineUser.Id.ToString(); }

                        BDD_UltimosReg.Add(new RegisUsuario(EngineUser.Id, userName));
                        try { BDD_UltimosReg.WriteToFile(BDD_Usuario); } catch { }
                        RegistrosBDD.Items.Add(new CData(EngineUser, userName));
                        RegistrosBDD.SelectedIndex = RegistrosBDD.Items.Count - 1;

                        ImagenHuellaEx.Image = EngineUser.GetBitmap();
                        Image img = EngineUser.GetBitmap();
                        byte[] arr;
                        ImageConverter converter = new ImageConverter();
                        arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                        HuellaEnBytes = arr;
                    }
                    else
                    {
                        NffvStatus EstadoEnginge = ResultRegistro.engineStatus;
                        MessageBox.Show(string.Format("El registro no fue finalizado. Razón: {0}", EstadoEnginge), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnGuardarHuellaE_Click(object sender, EventArgs e)
        {
            ProgressBar();
            try { EmpGV(RegistrosBDD.SelectedItem.ToString()); }
            catch (Exception)
            { MessageBox.Show("Seleccione un usuario del registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void EmpGV(string HuellaEmp_Cons)
        {
            Visor.DataSource = CoDE_Proyect.Procesos.ConsEmp_1(HuellaEmp_Cons);

            if (Visor.Rows.Count > 0)
            {
                lblMensajeHuella.Visible = true;
                lblMensajeHuella.Text = "Empleado encontrado.";
                lblMensajeHuella.ForeColor = Color.ForestGreen;

                try
                {
                    string sConexion = CoDE_Proyect.Procesos.CadenaConexion;
                    SqlConnection cnn = new SqlConnection(sConexion);
                    SqlCommand cmd = new SqlCommand("SP_EmpleadoInsertarHuella", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NumEmpID", SqlDbType.NVarChar, 30).Value = RegistrosBDD.SelectedItem.ToString();
                    cmd.Parameters.Add("@HuellaINS", SqlDbType.VarBinary).Value = HuellaEnBytes;
                    cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close();
                    lblMensajeHuella.Visible = true;
                    lblMensajeHuella.Text = "Listo, puede cerrar esta ventana.";
                    lblMensajeHuella.ForeColor = Color.ForestGreen;
                    MessageBox.Show("La huella de " + RegistrosBDD.SelectedItem.ToString() + " fue creada.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BarraProgreso.Value = 0;
                }
                catch
                {
                    MessageBox.Show("Parece que el usuario " + RegistrosBDD.SelectedItem.ToString() +
                     " existe en la Base de Datos, pero hubo un problema al guardar la huella digitalizada. Pruebe eliminando el registro y escaneando la huella otra vez.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BarraProgreso.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("No se puede encontrar el usuario " + RegistrosBDD.SelectedItem.ToString()
                    + ". Para asociar una huella digital a este registro, primero el usuario debe de ser registrado correctamente en la ventana de registro.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BarraProgreso.Value = 0;
                lblMensajeHuella.Visible = true;
                lblMensajeHuella.Text = "Empleado no encontrado.";
                lblMensajeHuella.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }

        private void btnVerificarHuellaE_Click(object sender, EventArgs e)
        {
            if (RegistrosBDD.SelectedIndex < 0)
            { MessageBox.Show("Seleccione un registro de la Base de Datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                try
                {
                    RunWorkerCompletedEventArgs taskResult = CargaForm.RunLongTask_3("Esperando una huella...", new DoWorkEventHandler(doVerify),
                        false, ((CData)RegistrosBDD.SelectedItem).EngineUser, new EventHandler(CancelScanningHandler));

                    VerificationResult verificationResult = (VerificationResult)taskResult.Result;

                    if (verificationResult.EngineStatus == NffvStatus.TemplateCreated)
                    {
                        if (verificationResult.Puntos > 0)
                        {
                            MessageBox.Show(string.Format("Usaurio {0} verificado, las huellas coinciden.\r\nPuntos que coinciden: {1}",
                              ((CData)RegistrosBDD.SelectedItem).Nombre, verificationResult.Puntos), "Usuario verificado",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Usuario {0} no verficiado, las huellas no coinciden.\r\nPuntos que coinciden: {1}",
                              ((CData)RegistrosBDD.SelectedItem).Nombre, verificationResult.Puntos), "Usuario no verificado",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show(string.Format("La verificación no pudo ser finalizada. Razón: {0}",
                          verificationResult.EngineStatus), "Verficiación incompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void doVerify(object sender, DoWorkEventArgs args)
		{
			VerificationResult verificationResult = new VerificationResult();
			verificationResult.Puntos = Engine.Verify((NffvUser)args.Argument, 20000, out verificationResult.EngineStatus);
			args.Result = verificationResult;
		}

		public static void CancelScanningHandler(object sender, EventArgs e)
		{ Engine.Cancel(); }

        private void lbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RegistrosBDD.SelectedItem != null) { btnEliminarRegistro.Visible = true; }
            if (RegistrosBDD.SelectedItem == null) { btnEliminarRegistro.Visible = false; }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegistrosBDD.SelectedIndex < 0)
                { MessageBox.Show("Para borrar un registro primero seleccione uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    BDD_UltimosReg.Remove(BDD_UltimosReg.Lookup(((CData)RegistrosBDD.SelectedItem).ID));
                    try { BDD_UltimosReg.WriteToFile(BDD_Usuario); } catch { }

                    DialogResult ConfirmarBorrar;
                    ConfirmarBorrar = MessageBox.Show("¿Borrar el registro " + RegistrosBDD.SelectedItem +
                        "? \r\nEsta acción no se puede deshacer.", "¿Borrar este registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (ConfirmarBorrar == DialogResult.Yes)
                    { Engine.Users.RemoveAt(RegistrosBDD.SelectedIndex); RegistrosBDD.Items.RemoveAt(RegistrosBDD.SelectedIndex); }
                    if (RegistrosBDD.Items.Count > 0) { RegistrosBDD.SelectedIndex = 0; }
                }
            }
            catch { MessageBox.Show("Ocurrió un error inesperado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        private void ProgressBar()
        {
            Random rnd = new Random();
            int Progreso = rnd.Next(70, 100);
            for (int i = Progreso; i <= 300; i++)
            { BarraProgreso.Increment(i); }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alumnoToolStripMenuItem.CheckState == CheckState.Checked)
            {
                empleadoToolStripMenuItem.Checked = false;
                btnEscanearHuellaA.Visible = true; btnGuardarHuellaA.Visible = true;
                btnVerificarHuellaA.Visible = true; btnEscanearHuellaE.Visible = false;
                btnGuardarHuellaE.Visible = false; btnVerificarHuellaE.Visible = false;
                GrupoLabel.Visible = false; lblTexto.Visible = false;
            }

            if (alumnoToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                btnEscanearHuellaA.Visible = false; btnGuardarHuellaA.Visible = false;
                btnVerificarHuellaA.Visible = false; GrupoLabel.Visible = true; lblTexto.Visible = true;
            }
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empleadoToolStripMenuItem.CheckState == CheckState.Checked)
            {
                alumnoToolStripMenuItem.Checked = false;
                btnEscanearHuellaE.Visible = true; btnGuardarHuellaE.Visible = true;
                btnVerificarHuellaE.Visible = true; btnEscanearHuellaA.Visible = false;
                btnGuardarHuellaA.Visible = false; btnVerificarHuellaA.Visible = false;
                GrupoLabel.Visible = false; lblTexto.Visible = false;
            }

            if (empleadoToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                btnEscanearHuellaE.Visible = false; btnGuardarHuellaE.Visible = false;
                btnVerificarHuellaE.Visible = false; GrupoLabel.Visible = true; lblTexto.Visible = true;
            }
        }
    }

    #region Miembros IDisposable

    class CData : IDisposable
	{
		private static NffvUser _EngineUser;
		private Bitmap _Imagen;
		private string _Nombre;

		public CData(NffvUser Engine_User, string nombr)
		{
            _EngineUser = Engine_User;
            _Imagen = Engine_User.GetBitmap();
            _Nombre = nombr;
		}

		public NffvUser EngineUser
		{ get { return _EngineUser; } }

		public Bitmap Image
		{ get { return _Imagen; } }

		public int ID
		{ get { return _EngineUser.Id; } }

		public string Nombre
		{ get { return _Nombre; }
			set { _Nombre = value; } }

		public override string ToString()
		{ return Nombre; }

		public void Dispose()
		{
			if (_Imagen != null)
			{ _Imagen.Dispose(); _Imagen = null; }
		}

		#endregion
	}
}
