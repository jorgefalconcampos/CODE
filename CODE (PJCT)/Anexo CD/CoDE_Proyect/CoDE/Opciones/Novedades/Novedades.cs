using System;
using System.Windows.Forms;

namespace CoDE_Proyect.CoDE.Opciones.Novedades
{
    public partial class Novedades : Form
    {
        public Novedades()
        { InitializeComponent(); }

        private void Novedades_Load(object sender, EventArgs e)
        { this.MaximizeBox = false; }

        private void btnCarac1_Click(object sender, EventArgs e)
        { Prox1 ProxCarac1 = new Prox1(); ProxCarac1.Show(); }       
    }
}
