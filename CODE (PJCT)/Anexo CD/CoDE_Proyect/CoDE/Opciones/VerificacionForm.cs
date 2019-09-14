using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class VerificacionForm : Form
    {
        public VerificacionForm()
        { InitializeComponent(); }

        private void VerificacionEscaneo_Load(object sender, EventArgs e)
        { txtAdministrador.Text = Procesos.SesionDeAdmin.SA; }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked == true) { txtPass.UseSystemPasswordChar = false; }
            else { txtPass.UseSystemPasswordChar = true; }
        }

        private void Editar_Click(object sender, EventArgs e)
        { txtAdministrador.Enabled =! txtAdministrador.Enabled;}

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                string sConexion = Procesos.CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand("SP_AdminVerificacion", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Administrador", SqlDbType.NVarChar, 50).Value = txtAdministrador.Text;
                cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 300).Value = txtPass.Text;
                SqlParameter Param_Resul = new SqlParameter("@Resultado", SqlDbType.Bit);
                Param_Resul.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(Param_Resul);
                cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close();

                bool LogVal = bool.Parse(cmd.Parameters["@Resultado"].Value.ToString());

                DialogResult Verificado;

                if ((LogVal == true) || ((txtAdministrador.Text == CODE.Default.Admin_User) && (txtPass.Text == CODE.Default.Admin_Pass)))
                {
                    Verificado = MessageBox.Show("Listo " + txtAdministrador.Text + ", contraseña validada.\nPuede cerrar este mensaje para comenzar.", 
                        "Administrador validado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Verificado == DialogResult.OK)
                    { Procesos.VerficiacionAdmin.Verif = "Correcto"; }
                    if ((Verificado == DialogResult.OK) && ((txtAdministrador.Text == CODE.Default.Admin_User) && (txtPass.Text == CODE.Default.Admin_Pass)))
                    { Procesos.VerficiacionAdmin.APVerif = "P.Correcto"; } this.Close(); 
                }

                else if ((LogVal == true) || ((txtAdministrador.Text != CODE.Default.Admin_User) && (txtPass.Text != CODE.Default.Admin_Pass)))
                {
                    Procesos.VerficiacionAdmin.Verif = "Incorrecto";
                    MessageBox.Show("La contraseña es incorrecta.", "Contraseña no reconocida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            { MessageBox.Show("Error al verficiar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
