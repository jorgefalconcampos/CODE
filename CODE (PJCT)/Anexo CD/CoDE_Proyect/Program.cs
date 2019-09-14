using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoDE_Proyect
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }

        public static void ReiniciarApp()
        {
            try { Application.Restart(); }
            catch
            {
                DialogResult Reiniciar;
                Reiniciar = MessageBox.Show("La aplicación se reinició.", "Aplicación reiniciada.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Reiniciar == DialogResult.OK) { Application.Run(new Inicio()); }
            }
        }
    }
}
