using System;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace CoDE_Proyect.CoDE.Opciones
{
    public partial class _2AboutForm : Form
    {
        public _2AboutForm()
        { InitializeComponent(); }

        private void _2AboutForm_Load(object sender, EventArgs e)
        {
            Version Version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVer.Text = " Versión: " + Version.Major.ToString() + "." + Version.Minor + "." + Version.Build;
        }

        private void ImgCopiarPP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos copiados al portapapeles.", "Información del producto", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetDataObject(lblVer.Text);
        }

        private void btnEntendido_Click(object sender, EventArgs e)
        { this.Close(); }

        private void lblPagina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://codeproyect.wixsite.com/inicio"); }
    }
}
