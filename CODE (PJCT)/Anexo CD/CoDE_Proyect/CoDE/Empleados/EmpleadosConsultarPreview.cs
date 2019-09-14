using System;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Empleados
{
    public partial class EmpleadosConsultarPreview : Form
    {
        public EmpleadosConsultarPreview()
        { InitializeComponent(); }

        public string ID_Empleado;

        private void AlumHuellaPreview_Load(object sender, EventArgs e)
        {
            this.Text = "Huella de " + ID_Empleado;
            if (ImgHuellaPreview.Image == null) { MessageBox.Show("No se puede mostrar ninguna huella.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
