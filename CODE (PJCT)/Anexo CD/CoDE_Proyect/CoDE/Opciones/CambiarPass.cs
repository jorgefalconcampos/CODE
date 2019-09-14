using System;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class CambiarPass : Form
    {
        public CambiarPass()
        { InitializeComponent(); }
        private void CambiarPass_Load(object sender, EventArgs e)
        { txtUsuario.Text = CODE.Default.Admin_User; }

        private void Mensaje()
        {
            if (lblRazon.Text == "Razon: La contraseña fue olvidada.")
            {
                MessageBox.Show("Al parecer se olvidó la contraseña de el Administrador principal. Puede acceder con la ayuda y autenticación de otro Administrador, lo cuál es válido. "
                  + "Comience a cambiar su información con algo que recuerde y nadie más sepa. El otro Administrador se autenticará por usted.",
                  "Modifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Mensaje();
            MessageBox.Show("Espere un momento...", "Conectando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerificacionForm Verificacion = new VerificacionForm();

            if ((lblRazon.Text == "Razon: La contraseña fue olvidada.") && (Verificacion.ShowDialog() == DialogResult.OK) && (Procesos.VerficiacionAdmin.Verif == "Correcto"))
            {
                Procesos.VerficiacionAdmin.Verif = ""; btnNueva.Visible = false; lblUsuario.Visible = true;
                txtUsuario.Visible = true; Editar.Visible = true; lblPass.Visible = true; txtPass.Visible = true;
                lblRepPass.Visible = true; txtRepPass.Visible = true; chkMostrarPass.Visible = true; btnOK.Visible = true;
            }
            else
            { if ((Verificacion.ShowDialog() == DialogResult.OK) && (Procesos.VerficiacionAdmin.APVerif == "P.Correcto"))
                { Procesos.VerficiacionAdmin.APVerif = ""; btnNueva.Visible = false; lblUsuario.Visible = true;
                    txtUsuario.Visible = true; Editar.Visible = true; lblPass.Visible = true; txtPass.Visible = true;
                    lblRepPass.Visible = true; txtRepPass.Visible = true; chkMostrarPass.Visible = true; btnOK.Visible = true; }
                else
                { MessageBox.Show("Al parecer se intentó validar la contraseña de un Administrador, pero el procesó falló. " 
                    + " Cabe mencionar que esta función solo está disponible para el Administrador principal por el momento, disculpe las molestias.", 
                    "Contraseña no válida", MessageBoxButtons.OK, MessageBoxIcon.Error); Procesos.VerficiacionAdmin.Verif = ""; }
            }
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked == true) { txtPass.UseSystemPasswordChar = false; txtRepPass.UseSystemPasswordChar = false; }
            else { txtPass.UseSystemPasswordChar = true; txtRepPass.UseSystemPasswordChar = true; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtRepPass.Text)
            {
                try
                {
                    CODE.Default.Admin_User = txtUsuario.Text; CODE.Default.Admin_Pass = txtPass.Text;
                    CODE.Default.Save(); DialogResult Cambios;
                    Cambios = MessageBox.Show("Las información fue actualizada correctamente. Los cambios se verán reflejados la próxima vez que se inicie la aplicación. " 
                        + "\n¿Desea reiniciar la aplicación ahora?", 
                        "Cambios guardados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Cambios == DialogResult.Yes)
                    { Program.ReiniciarApp(); }
                } catch { MessageBox.Show("Ocurrió un error al actualizar la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            } else { MessageBox.Show("Las contraseñas tienen que ser iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            DialogResult Modificar; Modificar = MessageBox.Show("¿Además de la contraseña, modificar también el nombre de usuario?", 
                "¿Modificar usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Modificar == DialogResult.Yes) { txtUsuario.Enabled = true; }
        }
    }
}
