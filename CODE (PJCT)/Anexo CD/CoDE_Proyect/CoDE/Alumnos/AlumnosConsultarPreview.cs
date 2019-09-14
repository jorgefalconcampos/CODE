using System;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Alumnos
{
    public partial class AlumnosConsultarPreview : Form
    {
        public AlumnosConsultarPreview()
        { InitializeComponent(); }

        public string ID_Alumno;

        private void AlumHuellaPreview_Load(object sender, EventArgs e)
        {
            this.Text = "Huella de " + ID_Alumno;
            if (ImgHuellaPreview.Image == null) { MessageBox.Show("No se puede mostrar ninguna huella.", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnOK_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
