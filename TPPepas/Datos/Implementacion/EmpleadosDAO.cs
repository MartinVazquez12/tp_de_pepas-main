using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Datos.Implementacion
{
    public class EmpleadosDAO : IEmpleados
    {
        public string ConsultarEmpleado(int idEmpleado)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_empleado", idEmpleado));
            SqlParameter paramOut = new SqlParameter("@empleado", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_EMPLEADO_FILTRO", listParam);

            return paramOut.Value.ToString();
        }
    }
}
