using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;
using TPPepas.Entidades;
using Farmacia.Entidades;

namespace TPPepas.Datos.Implementacion
{
    public class SucursalesDAO : ISucursales
    {
        public string ConsultarSucursal(int idSucursal)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_sucursal", idSucursal));
            SqlParameter paramOut = new SqlParameter("@sucursal", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_SUCURSAL_FILTRO", listParam);

            return paramOut.Value.ToString();
        }

        public Sucursales ConsultarObjetoSucursal(int idSucursal)
        {

            SqlParameter param = new SqlParameter("@cod_sucursal", idSucursal);
            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_SUCURSAL", param);
                
            Sucursales sucursal = new Sucursales();

            foreach (DataRow row in tabla.Rows)
            {
                sucursal.CodSucursal = Convert.ToInt32(row[0].ToString());
                sucursal.Calle = row[1].ToString();
                sucursal.Altura = Convert.ToInt32(row[2].ToString());
                sucursal.CodBarrio = Convert.ToInt32(row[3].ToString());
            }
            return sucursal;
        }

        public List<object> Listar()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_SUCURSALES");

            foreach (DataRow row in tabla.Rows)
            {
                Sucursales sucursal = new Sucursales();

                sucursal.CodSucursal = Convert.ToInt32(row[0].ToString());
                sucursal.Calle = row[1].ToString();
                sucursal.Altura = Convert.ToInt32(row[2].ToString());
                sucursal.CodBarrio = Convert.ToInt32(row[3].ToString());

                lista.Add(sucursal);
            }

            return lista;
        }
    }
}
