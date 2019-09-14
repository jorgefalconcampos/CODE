using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoDE_Proyect
{
    class FormUtil
    {
        
        
        #region Datos

        public static void Set_Turno(ComboBox Turnos)
        {
            foreach (string TurnosActuales in CODE.Default.Turnos)
            { Turnos.Items.Add(TurnosActuales); }
        }

        public static void Set_Carrera(ComboBox Carreras)
        {
            foreach (string CarrerasActuales in CODE.Default.Carreras)
            { Carreras.Items.Add(CarrerasActuales); }
        }

        public static void Set_Grupos(ComboBox Grupos)
        {
            foreach (string GruposActuales in CODE.Default.Grupos)
            { Grupos.Items.Add(GruposActuales); }
        }

        #endregion


    }
}
