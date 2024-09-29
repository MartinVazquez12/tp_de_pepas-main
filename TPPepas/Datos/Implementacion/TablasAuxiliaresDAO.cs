using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;
using TPPepas.Entidades;

namespace TPPepas.Datos.Implementacion
{
    public class TablasAuxiliaresDAO : ITablasAuxiliares
    {
        #region Listar
        public List<object> ListarTiposProductos()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_PRODUCTOS");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarTiposPresentacion()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_PRESENTACIONES");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarTiposRecetas()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_RECETAS");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }
        
        public List<object> ListarBarrios(int codCiudad)
        {
            List<object> lista = new List<object>();

            SqlParameter param = new SqlParameter("@cod_ciudad", codCiudad);

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_BARRIOS", param);

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarCiudades()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_CIUDADES");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarMutuales()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_MUTUALES");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarTiposDocumento()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_DOCUMENTOS");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }

        public List<object> ListarFormasDePago()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_FORMAS_DE_PAGO");

            foreach (DataRow row in tabla.Rows)
            {
                TablasAuxiliares elemento = new TablasAuxiliares();
                elemento.Valor = Convert.ToInt32(row[0].ToString());
                elemento.Display = row[1].ToString();

                lista.Add(elemento);
            }

            return lista;
        }
        #endregion

        #region Consultar

        public string ConsultarTipoProductos(int codProducto)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@id_tipo_prod", codProducto));
            SqlParameter paramOut = new SqlParameter("@tipo_prod", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_TIPOS_PRODUCTOS_FILTROS", listParam);

            return paramOut.Value.ToString();
        }

        public string ConsultarMutual(int codCliente)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_cliente", codCliente));
            SqlParameter paramOut = new SqlParameter("@mutual", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_CLIENTE_MUTUAL", listParam);

            return paramOut.Value.ToString();
        }

        public string ConsultarFormaPago(int codFormaPago)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_forma_pago", codFormaPago));
            SqlParameter paramOut = new SqlParameter("@forma_pago", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_FORMA_PAGO_FILTRO", listParam);

            return paramOut.Value.ToString();
        }

        public int ConsultarCiudades(int codBarrio)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_barrio", codBarrio));
            SqlParameter paramOut = new SqlParameter("@ciudad", SqlDbType.Int);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_BARRIOS_FILTROS", listParam);

            return (int)paramOut.Value;
        }
        #endregion
    }
}
