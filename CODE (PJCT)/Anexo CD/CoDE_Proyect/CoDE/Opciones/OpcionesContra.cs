using System;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class OpcionesContra : Form
    {
        public OpcionesContra()
        { InitializeComponent(); }

        private void chkOlvidada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlvidada.Checked == true)
            {
                chkNueva.Checked = false; lbl1.Visible = true;
                chkOlvAdmin.Visible = true; chkOlvAdminP.Visible = true;
            } else { LimpiarSub(); }
        }

        private void chkNueva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNueva.Checked == true)
            {
                chkOlvidada.Checked = false; lbl2.Visible = true;
                chkNuevaAdmin.Visible = true; chkNuevaAdminP.Visible = true;
            } else { LimpiarSub(); }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void LimpiarSub()
        {
            lbl1.Visible = false; lbl2.Visible = false;
            chkOlvAdmin.Visible= false; chkOlvAdmin.Checked = false;
            chkOlvAdminP.Visible = false; chkOlvAdminP.Checked = false;
            chkNuevaAdmin.Checked = false; chkNuevaAdmin.Visible = false;
            chkNuevaAdminP.Checked = false; chkNuevaAdminP.Visible = false;
        }

        private void chkOlvAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlvAdmin.Checked == true)
            { chkOlvAdminP.Checked = false; chkNuevaAdmin.Checked = false; chkNuevaAdminP.Checked = false; }
        }

        private void chkOlvAdminP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlvAdminP.Checked == true)
            { chkOlvAdmin.Checked = false; chkNuevaAdmin.Checked = false; chkNuevaAdminP.Checked = false; }
        }

        private void chkNuevaAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevaAdmin.Checked == true)
            { chkOlvAdmin.Checked = false; chkOlvAdminP.Checked = false; chkNuevaAdminP.Checked = false; }
        }

        private void chkNuevaAdminP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevaAdminP.Checked == true)
            { chkOlvAdmin.Checked = false; chkOlvAdminP.Checked = false; chkNuevaAdmin.Checked = false; }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if ((chkOlvidada.Checked == true) && (chkOlvAdmin.Checked == true))
            {
                MessageBox.Show("Disculpe las molestias, pero esta función aún no está disponible. " 
                    + "\nSi olvidó su contraseña, su usuario se tiene que dar de baja y añadirse otra vez con una nueva contraseña.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Admin.AdminConsulta ConsultarAdmin = new Admin.AdminConsulta(); ConsultarAdmin.Show(); }

            if ((chkOlvidada.Checked == true) && (chkOlvAdminP.Checked == true))
            { CambiarPass CambiarP = new CambiarPass(); CambiarP.Show(); CambiarP.lblRazon.Text = "Razon: La contraseña fue olvidada.";}

            if ((chkNueva.Checked == true) && (chkNuevaAdmin.Checked == true))
            { MessageBox.Show("Disculpe las molestias, pero esta función aún no está disponible.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            if ((chkNueva.Checked == true) && (chkNuevaAdminP.Checked == true))
            { CambiarPass CambiarP = new CambiarPass();
                CambiarP.Show(); CambiarP.lblRazon.Text = "Razon: Una nueva contraseña fue solicitada."; }
        }
    }
}
