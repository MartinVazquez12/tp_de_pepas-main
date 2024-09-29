using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;
using System.Data;

namespace TPPepas.Datos.Implementacion
{
    public class FacturasDAO : IFacturas
    {
        IDetallesFactura daoDetalles;
        public bool Agregar(Facturas factura)
        {
            bool resultado = true;
            SqlConnection cnn = AccesoDatosDAO.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            List<SqlParameter> listParam = new List<SqlParameter>();
            daoDetalles = new DetallesFacturaDAO();

            try
            {
                cnn.Open();

                t = cnn.BeginTransaction();

                daoDetalles.StockSinVencer(factura, t);

                listParam.Clear();

                listParam.Add(new SqlParameter("@cod_empleado", factura.Empleado.CodEmpleado));
                listParam.Add(new SqlParameter("@cod_cliente", factura.Cliente.CodCliente));
                listParam.Add(new SqlParameter("@cod_sucursal", factura.Sucursal.CodSucursal));
                listParam.Add(new SqlParameter("@cod_tipo_pago", factura.TipoPago));
                SqlParameter paramOut = new SqlParameter("@nro_factura", SqlDbType.Int);
                paramOut.Direction = ParameterDirection.Output;
                listParam.Add(paramOut);

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_FACTURAS", listParam, t);

                factura.NroFactura = Convert.ToInt32(paramOut.Value);

                daoDetalles.Agregar(factura, t);

                daoDetalles.ModificarStock(factura, t);

                t?.Commit();
            }
            catch
            {
                t?.Rollback();
                resultado = false;
                throw;
            }
            finally
            {
                cnn.Close();
            }
            return resultado;
        }

        public List<object> ListarFiltros(DateTime fechaDesde, DateTime fechaHasta, string cliente, int nroFactura)
        {
            List<object> listFacturas = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@fecha_desde", fechaDesde));
            listParam.Add(new SqlParameter("@fecha_hasta", fechaHasta));
            listParam.Add(new SqlParameter("@cliente", cliente));
            if (nroFactura != 0)
            {
                listParam.Add(new SqlParameter("@nro_factura", nroFactura));
            }

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_FACTURAS_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Facturas f = new Facturas();

                f.NroFactura = Convert.ToInt32(row[0].ToString());
                f.Fecha = Convert.ToDateTime(row[1].ToString());
                f.Empleado.CodEmpleado = Convert.ToInt32(row[2].ToString());
                f.Cliente.CodCliente = Convert.ToInt32(row[3].ToString());
                f.Sucursal.CodSucursal = Convert.ToInt32(row[4].ToString());
                f.TipoPago = Convert.ToInt32(row[5].ToString());

                listFacturas.Add(f);
            }
            return listFacturas;
        }

        public bool DarDeBaja(int nroFactura)
        {
            SqlParameter param = new SqlParameter("@nro_factura", nroFactura);

            return AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_BAJAR_FACTURA", param);
        }

        public List<object> ListarDetalles(int nroFactura)
        {
            List<object> listDetalles = new List<object>();

            SqlParameter param = new SqlParameter("@nro_factura", nroFactura);

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_DETALLES_FACTURA", param);

            foreach (DataRow row in tabla.Rows) 
            {
                DetallesFactura df = new DetallesFactura();

                df.CodDetalle = Convert.ToInt32(row[0].ToString());
                df.NroFactura = Convert.ToInt32(row[1].ToString());
                df.Producto.CodProducto = Convert.ToInt32(row[2].ToString());
                df.Cantidad = Convert.ToInt32(row[3].ToString());
                df.Precio = Convert.ToDouble(row[4].ToString());
                if (int.TryParse(row[5].ToString(), out _))
                {
                    df.Receta.CodReceta = Convert.ToInt32(row[5].ToString());
                }
                df.Descuento = Convert.ToDouble(row[6].ToString());

                listDetalles.Add(df);
            }
            return listDetalles;
        }
    }
}
