using System;
using System.Windows.Forms;

namespace Escaneo
{
	partial class RegistroForm : Form
	{
		public RegistroForm()
		{ InitializeComponent(); }

        private void RegistroForm_Load(object sender, EventArgs e)
        { txtUsuario.Text = CoDE_Proyect.Procesos.Opciones.ID; }

        public string UserName
		{
			get { return txtUsuario.Text; }
			set { txtUsuario.Text = value; }
		}

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Editar_Click(object sender, EventArgs e)
        { txtUsuario.Enabled =! txtUsuario.Enabled; }
    }
}
