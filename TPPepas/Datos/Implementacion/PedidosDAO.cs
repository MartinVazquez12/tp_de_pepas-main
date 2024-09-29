using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Entidades;
using System.Data;
using TPPepas.Datos.Interfaz;
using System.Security.Cryptography;
using System.Security.Policy;

namespace TPPepas.Datos.Implementacion
{
    public class PedidosDAO : IPedidos
    {
        ILotes daoLotes;

        public bool Agregar(Pedidos pedido)
        {
            bool resultado = true;
            SqlConnection cnn = AccesoDatosDAO.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            List<SqlParameter> listParam = new List<SqlParameter>();
            daoLotes = new LotesDAO();

            try
            {
                cnn.Open();

                t = cnn.BeginTransaction();

                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_tipo_pago", pedido.TipoPago));
                listParam.Add(new SqlParameter("@cod_sucursal", pedido.Sucursal.CodSucursal));
                SqlParameter paramOut = new SqlParameter("@cod_pedido", SqlDbType.Int);
                paramOut.Direction = ParameterDirection.Output;
                listParam.Add(paramOut);

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_PEDIDOS", listParam, t);

                pedido.CodPedido = Convert.ToInt32(paramOut.Value);

                daoLotes.Agregar(pedido, t);

                daoLotes.ModificarStock(pedido, t);

                t?.Commit();
            }

            catch
            {
                t?.Rollback();
                resultado = false;
            }

            finally
            {
                cnn.Close();
            }

            return resultado;
        }

        public List<object> Listar()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PEDIDOS");

            foreach (DataRow row in tabla.Rows)
            {
                Pedidos p = new Pedidos();
                p.CodPedido = Convert.ToInt32(row[0].ToString());
                p.FechaPedido = Convert.ToDateTime(row[1].ToString());
                p.Sucursal.CodSucursal = Convert.ToInt32(row[2].ToString());
                // p.LLotes como manejar los lotes


                lista.Add(p);
            }

            return lista;
        }
        public List<object> ListarFiltro(DateTime desde, DateTime hasta)
        {
            List<object> lista = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter("@fecha_desde", desde));
            listParam.Add(new SqlParameter("@fecha_hasta", hasta));

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PEDIDOS_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Pedidos p = new Pedidos();
                p.CodPedido = Convert.ToInt32(row[0].ToString());
                p.FechaPedido = Convert.ToDateTime(row[1].ToString());
                p.Sucursal.CodSucursal = Convert.ToInt32(row[2].ToString());
                // p.LLotes como manejar los lotes


                lista.Add(p);
            }

            return lista;
        }
        public List<object> ListarFiltro(DateTime desde, DateTime hasta, int sucursal)
        {
            List<object> lista = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter("@fecha_desde", desde));
            listParam.Add(new SqlParameter("@fecha_hasta", hasta));
            listParam.Add(new SqlParameter("@sucursal", sucursal));

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PEDIDOS_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Pedidos p = new Pedidos();
                p.CodPedido = Convert.ToInt32(row[0].ToString());
                p.FechaPedido = Convert.ToDateTime(row[1].ToString());
                p.Sucursal.CodSucursal = Convert.ToInt32(row[2].ToString());
                // p.LLotes como manejar los lotes


                lista.Add(p);
            }

            return lista;
        }
        public List<object> ListarFiltro(DateTime desde, DateTime hasta, int sucursal, int codPedido)
        {
            List<object> lista = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter("@fecha_desde", desde));
            listParam.Add(new SqlParameter("@fecha_hasta", hasta));
            listParam.Add(new SqlParameter("@sucursal", sucursal));
            listParam.Add(new SqlParameter("@nro_pedido", codPedido));

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PEDIDOS_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Pedidos p = new Pedidos();
                p.CodPedido = Convert.ToInt32(row[0].ToString());
                p.FechaPedido = Convert.ToDateTime(row[1].ToString());
                p.Sucursal.CodSucursal = Convert.ToInt32(row[2].ToString());

                lista.Add(p);
            }

            return lista;
        }

        public List<object> ListarLotes(int nroPedido)
        {
            List<object> lista = new List<object>();

            SqlParameter param = new SqlParameter("@cod_pedido", nroPedido);

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_LOTES", param);

            foreach (DataRow row in tabla.Rows)
            {
                Lotes l = new Lotes();

                l.CodLote = Convert.ToInt32(row[0].ToString());
                l.FechaVencimiento = Convert.ToDateTime(row[1].ToString());
                l.Cantidad = Convert.ToInt32(row[2].ToString());
                l.Precio = Convert.ToDouble(row[3].ToString());
                l.NroPedido = Convert.ToInt32(row[4].ToString());
                l.Producto.CodProducto = Convert.ToInt32(row[5].ToString());
                l.Proveedor.CodProveedor = Convert.ToInt32(row[6].ToString());

                lista.Add(l);
            }

            return lista;
        }
    }
}
