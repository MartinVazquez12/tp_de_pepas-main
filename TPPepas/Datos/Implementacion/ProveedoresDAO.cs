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
    public class ProveedoresDAO : IProveedores
    {
        public List<object> Listar()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PROVEEDORES");

            foreach (DataRow row in tabla.Rows)
            {
                Proveedores p = new Proveedores();

                p.CodProveedor = Convert.ToInt32(row[0].ToString());
                p.NombreProveedor = row[1].ToString();
                p.Calle = row[2].ToString();
                p.Altura = Convert.ToInt32(row[3].ToString());
                p.Telefono = row[4].ToString();
                p.Email = row[5].ToString();
                p.CodBarrio = Convert.ToInt32(row[6].ToString());

                lista.Add(p);
            }

            return lista;
        }
        public List<object> ListarFiltro(string nomProv)
        {
            List<object> lista = new List<object>();

            SqlParameter param = new SqlParameter("@nom_prov", nomProv);

            // aca iria el SP_CONSULTAR_PROVEEDORES_FILTRO
            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PROVEEDORES_FILTRO", param);

            foreach (DataRow row in tabla.Rows)
            {
                Proveedores p = new Proveedores();

                p.CodProveedor = Convert.ToInt32(row[0].ToString());
                p.NombreProveedor = row[1].ToString();
                p.Calle = row[2].ToString();
                p.Altura = Convert.ToInt32(row[3].ToString());
                p.Telefono = row[4].ToString();
                p.Email = row[5].ToString();
                p.CodBarrio = Convert.ToInt32(row[6].ToString());

                lista.Add(p);
            }

            return lista;
        }

        public bool Agregar(Proveedores proveedor)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@nombre", proveedor.NombreProveedor));
            listParam.Add(new SqlParameter("@calle", proveedor.Calle));
            listParam.Add(new SqlParameter("@altura", proveedor.Altura));
            listParam.Add(new SqlParameter("@telefono", proveedor.Telefono));
            listParam.Add(new SqlParameter("@email", proveedor.Email));
            listParam.Add(new SqlParameter("@cod_barrio", proveedor.CodBarrio));

            return AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_PROVEEDORES", listParam);
        }

        public string ConsultarProveedor(int codProveedor)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_proveedor", codProveedor));
            SqlParameter paramOut = new SqlParameter("@proveedor", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PROVEEDOR_FILTROS", listParam);

            return paramOut.Value.ToString();
        }
    }
}
