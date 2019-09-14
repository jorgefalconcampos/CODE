using System;
using System.Configuration;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class ConexionConfig : Form
    {
        public ConexionConfig()
        { InitializeComponent(); }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cadena de conexión es parecida a:\n-> ''Data source=DireccionServidor\\NombreDeInstancia; Initial Catalog=MiBaseDeDatos; Integrated Security=True;''" 
                + "\nEn esta configuración solo se cambia el nombre del servidor y/o la instancia y el nombre de la base de datos; las primeras dos opciones de la cadena de conexión." 
                + "\nTome en cuenta que para usar el servidor local puede usar un punto ''.'' o escribir ''(local)'' (ambas sin comillas) y que " + 
                "se requiere una barra diagonal entre el servidor y el nombre de la instancia.", "Configuración de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConexionConfig_Load(object sender, EventArgs e)
        { Conexiones(); }

        private void Conexiones()
        {
            cboServer.Items.Clear();
            foreach (string Servidores in CODE.Default.ServidoresConn)
            { cboServer.Items.Add(Servidores); }
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Guardar; Guardar = MessageBox.Show("¿Guardar esta nueva cadena de conexión?\nSe asignará como predeterminada.", "¿Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Guardar == DialogResult.Yes)
            {
                try
                {
                    string CadenaConexion = string.Format("Data source={0}; Initial Catalog={1};", cboServer.Text, txtBDD.Text);
                    try
                    {
                        SqlHelper Helper = new SqlHelper(CadenaConexion);
                        if (Helper.EstadoConexion)
                        {
                            ConfigConexion Config = new ConfigConexion(); Config.GuardarCadenaCon("cn", CadenaConexion);
                            CODE.Default.ServidoresConn.Add(cboServer.Text); CODE.Default.Save();

                            DialogResult Cambios; Cambios = MessageBox.Show("Conexión guardada correctamente. Los cambios se verán reflejados la próxima vez que se inicie la aplicación. " 
                                + "\n¿Desea reiniciar la aplicación ahora?", "Listo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (Cambios == DialogResult.Yes) { Program.ReiniciarApp(); }                         
                        }
                    } catch { MessageBox.Show("Ocurrió un error al guardar la conexión.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                } catch { MessageBox.Show("Ocurrió un error inesperado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            DialogResult Modificar; Modificar = MessageBox.Show("¿Desea modificar el nombre de la base de datos? Tenga en cuenta que esta opción NO se recomienda debido a que la base de datos ya fue creada al inicio con ese nombre.",
              "¿Modificar base de datos?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Modificar == DialogResult.Yes) { txtBDD.Enabled = true; }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            string CadenaConexion = string.Format("Data source={0}; Initial Catalog={1};", cboServer.Text, txtBDD.Text);
            try
            {
                SqlHelper Helper = new SqlHelper(CadenaConexion);
                if (Helper.EstadoConexion)
                    MessageBox.Show("Conexión exitosa a la base de datos.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            { MessageBox.Show("Ocurrió un error al probar la conexión.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnVerActuales_Click(object sender, EventArgs e)
        { MessageBox.Show((ConfigurationManager.ConnectionStrings["cn"].ToString())); }
    }
}
