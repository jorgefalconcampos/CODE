using MetroFramework.Forms;
using System;
using System.Drawing;


namespace CoDE_Proyect.CoDE.Opciones.Novedades
{
    public partial class Prox1 : MetroForm
    {
        public Prox1()
        { InitializeComponent(); }

        private void Prox1_Load(object sender, EventArgs e) { }

        public void TemaOscuro()
        {
            label1.ForeColor = Color.White; label2.ForeColor = Color.White;
            label3.ForeColor = Color.White; Indicador1.ForeColor = Color.White;
            Indicador2.ForeColor = Color.White; Indicador3.ForeColor = Color.White;
            GrupoTema.ForeColor = Color.White; chkTemaOscuro.ForeColor = Color.White;
        }

        public void TemaNormal()
        {
            label1.ForeColor = Color.Black; label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black; Indicador1.ForeColor = Color.Black;
            Indicador2.ForeColor = Color.Black; Indicador3.ForeColor = Color.Black;
            GrupoTema.ForeColor = Color.Black; chkTemaOscuro.ForeColor = Color.Black;
        }

        private void chkTemaOscuro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTemaOscuro.Checked == true)
            { TemaOscuro(); Theme = MetroFramework.MetroThemeStyle.Dark; }
            else
            { TemaNormal(); Theme = MetroFramework.MetroThemeStyle.Light; }
        }
    }
}
