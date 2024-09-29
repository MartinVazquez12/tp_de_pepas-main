using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Datos.Implementacion
{
    public class LaboratoriosDAO : ILaboratorios
    {
        public List<object> Listar()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_LABORATORIOS");

            foreach (DataRow row in tabla.Rows)
            {
                Laboratorio l = new Laboratorio();

                l.CodLaboratorio = Convert.ToInt32(row[0].ToString());
                l.NomLaboratorio = row[1].ToString();
                l.Telefono = row[2].ToString();
                l.Email = row[3].ToString();

                lista.Add(l);
            }
            return lista;
        }

        public string Consultar(int codLaboratorio)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_laboratorio", codLaboratorio));
            SqlParameter paramOut = new SqlParameter("@laboratorio", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_LABORATORIOS_FILTROS", listParam);

            return paramOut.Value.ToString();
        }
    }
}
