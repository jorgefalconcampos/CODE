using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Admin
{
    public partial class AdminConsulta : Form
    {
        public AdminConsulta()
        { InitializeComponent(); }

        private void AdminConsulta_Load(object sender, EventArgs e)
        { VisorGV.RowTemplate.MinimumHeight = 40; }

        private void btnCerrar_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAdminConsultar.Text = ""; VisorGV.Visible = false; btnEliminar.Visible = false;
            lblEncontrado.Visible = false; lblEncontrado.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { BuscarAdmin(txtAdminConsultar.Text); }

        private void BuscarAdmin(string Admin)
        {
            VisorGV.DataSource = Procesos.ConsultarAdmin(Admin);

            if (VisorGV.Rows.Count > 0)
            {
                VisorGV.Visible = true; btnEliminar.Visible = true; lblEncontrado.Visible = true;
                lblEncontrado.Text = "ADMINISTRADOR ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.ForestGreen;
            }
            else
            {
                MessageBox.Show("No se puede encontrar el Administrador. Compruebe si el Administrador existe o si escribió correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                VisorGV.Visible = false; btnEliminar.Visible = false; lblEncontrado.Visible = true;
                lblEncontrado.Text = "ADMINISTRADOR NO ENCONTRADO EN LA BASE DE DATOS.";
                lblEncontrado.ForeColor = Color.FromArgb(225, 0, 0);
            }
        }   

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtAdminConsultar.Enabled = false; DialogResult EliminarConfirmar;
            EliminarConfirmar = MessageBox.Show("¿Seguro que desea eliminar a este administrador?\nEsta acción no se puede deshacer.", "¿Eliminar administrador?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (EliminarConfirmar == DialogResult.OK)
            {
                try
                {
                    if (txtAdminConsultar.Text == Procesos.SesionDeAdmin.SA)
                    {
                        txtAdminConsultar.Enabled = true;
                        MessageBox.Show("Un administrador no se puede eliminar a sí mismo.", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        EliminarAdmin(txtAdminConsultar.Text); txtAdminConsultar.Text = ""; 
                        VisorGV.Visible = false; btnEliminar.Visible = false;
                        MessageBox.Show("Administrador eliminado correctamente.", "Administrador eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdminConsultar.Enabled = true; lblEncontrado.Visible = false; lblEncontrado.Text = "";
                    }
                }
                catch (Exception)
                {
                    DialogResult ErrorEliminar;
                    ErrorEliminar = MessageBox.Show("Error al eliminar administrador. Si necesita ayuda, puede visitar nuestro Manual de Ayudas con información que puede ayudarle. \n¿Desea abrir el Manual de Ayudas?",
                        "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                    if (ErrorEliminar == DialogResult.Yes) { System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B6srNyj8bC76dkZJU2JpUWc5OXM/view"); } txtAdminConsultar.Enabled = true;
                }
            } else { txtAdminConsultar.Enabled = true; }
        }

        private void EliminarAdmin(string AdminBorrar)
        { Procesos.BajaAdmin(AdminBorrar); }
    }
}
