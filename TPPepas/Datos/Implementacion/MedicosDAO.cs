using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Datos.Implementacion
{
    public class MedicosDAO : IMedicos
    {
        public bool ConfirmarMedico(int matricula)
        {
            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_MEDICOS");

            foreach (DataRow row in tabla.Rows)
            {
                if (Convert.ToInt32(row[0].ToString()) == matricula)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
