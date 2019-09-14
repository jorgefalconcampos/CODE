using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace CoDE_Proyect.CoDE.Admin
{
    public partial class AdminAgregar : Form
    {
        public AdminAgregar()
        { InitializeComponent(); }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked == true)
            { txtPass.UseSystemPasswordChar = false; txtRepPass.UseSystemPasswordChar = false; }
            else
            { txtPass.UseSystemPasswordChar = true; txtRepPass.UseSystemPasswordChar = true; }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { txtAmin.Text = ""; txtPass.Text = ""; txtRepPass.Text = ""; }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtAmin.Text.Length.Equals(0) || txtPass.Text.Length.Equals(0) || txtRepPass.Text.Length.Equals(0))
            { MessageBox.Show("No puede dejar campos en blanco.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtPass.Text != txtRepPass.Text)
            { MessageBox.Show("Las contraseñas tienen que ser iguales.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            else
                try
                {
                    AgregarAdmin(txtAmin.Text, txtPass.Text);
                    MessageBox.Show("Administrador agregado correctamente. Recuerde bien la contraseña.", "Administrador agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmin.Text = ""; txtPass.Text = ""; txtRepPass.Text = "";
                }

                catch (Exception)
                {
                    DialogResult ErrorAgregar;
                    ErrorAgregar = MessageBox.Show("Error al agregar administrador. Si necesita ayuda, puede visitar nuestro Manual de Ayudas con información que puede ayudarle. \n¿Desea abrir el Manual de Ayudas?", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    if (ErrorAgregar == DialogResult.Yes) { Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76dkZJU2JpUWc5OXM/view"); } 
                }
        }

        private void AgregarAdmin(string Admin, string Pass)
        { Procesos.AñadirAdmin(Admin, Pass); }
        
    }
}
