using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Interfaz;
using System.Windows.Forms;

namespace TPPepas.Datos.Implementacion
{
    public class ProductosDAO : IProductos
    {
        public List<object> Listar()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PRODUCTOS");

            foreach (DataRow row in tabla.Rows)
            {
                Productos p = new Productos();
                p.CodProducto = Convert.ToInt32(row[0].ToString());
                p.Descripcion = row[1].ToString();
                p.Precio = Convert.ToDouble(row[2].ToString());
                p.StockMinimo = Convert.ToInt32(row[3].ToString());
                p.VentaLibre = row[4].ToString() == "True" ? true : false;
                p.TipoProducto = Convert.ToInt32(row[6].ToString());
                p.TipoPresentacion = Convert.ToInt32(row[7].ToString());
                p.Laboratorio.CodLaboratorio = Convert.ToInt32(row[8].ToString());


                lista.Add(p);
            }

            return lista;
        }

        public bool Agregar(Productos producto) // Revisar pq no va andar bien. Por los true y false.
        {
            List<SqlParameter> listParam = new List<SqlParameter>(); 

            listParam.Add(new SqlParameter("@descripcion", producto.Descripcion));
            listParam.Add(new SqlParameter("@pre_unitario", producto.Precio));
            listParam.Add(new SqlParameter("@cod_laboratorio", producto.Laboratorio.CodLaboratorio));
            listParam.Add(new SqlParameter("@stock_minimo", producto.StockMinimo));
            listParam.Add(new SqlParameter("@venta_libre", producto.VentaLibre ? 1 : 0));
            listParam.Add(new SqlParameter("@cod_tipo_prod", producto.TipoProducto));
            listParam.Add(new SqlParameter("@cod_tipo_presentacion", producto.TipoPresentacion));

            return AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_PRODUCTOS", listParam);
        }

        public List<object> ListarFiltro(int tipoProducto)
        {
            List<object> lista = new List<object>();

            SqlParameter param = new SqlParameter("@cod_tipo_producto", tipoProducto);

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PRODUCTOS_TIPOPROD", param);

            foreach (DataRow row in tabla.Rows)
            {
                Productos p = new Productos();
                p.CodProducto = Convert.ToInt32(row[0].ToString());
                p.Descripcion = row[1].ToString();
                p.Precio = Convert.ToDouble(row[2].ToString());
                p.StockMinimo = Convert.ToInt32(row[3].ToString());
                p.VentaLibre = row[4].ToString() == "True" ? true : false;
                p.Activo = row[5].ToString() == "True" ? true : false;
                p.TipoProducto = Convert.ToInt32(row[6].ToString());
                p.TipoPresentacion = Convert.ToInt32(row[7].ToString());
                p.Laboratorio.CodLaboratorio = Convert.ToInt32(row[8].ToString());

                lista.Add(p);
            }

            return lista;
        }

        public List<object> ListarFiltro(string descripcion, int tipoProducto)
        {
            List<object> lista = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_tipo_producto", tipoProducto));
            listParam.Add(new SqlParameter("@descripcion", descripcion));

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_PRODUCTOS_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Productos p = new Productos();
                p.CodProducto = Convert.ToInt32(row[0].ToString());
                p.Descripcion = row[1].ToString();
                p.Precio = Convert.ToDouble(row[2].ToString());
                p.StockMinimo = Convert.ToInt32(row[3].ToString());
                p.VentaLibre = row[4].ToString() == "True" ? true : false;
                p.Activo = row[5].ToString() == "True" ? true : false;
                p.TipoProducto = Convert.ToInt32(row[6].ToString());
                p.TipoPresentacion = Convert.ToInt32(row[7].ToString());
                p.Laboratorio.CodLaboratorio = Convert.ToInt32(row[8].ToString());

                lista.Add(p);
            }

            return lista;
        }

        public double ConsultarDescuento(Productos producto, Clientes cliente)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_mutual", cliente.CodMutual));
            listParam.Add(new SqlParameter("@cod_producto", producto.CodProducto));
            SqlParameter outParam = new SqlParameter("@descuento", SqlDbType.Decimal);
            outParam.Direction = ParameterDirection.Output;
            listParam.Add(outParam);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_DESCUENTOS", listParam);

            return Convert.ToDouble(outParam.Value);
        }

        public bool DeshabilitarProducto(Productos producto)
        {
            SqlParameter param = new SqlParameter("@id", producto.CodProducto);

            return AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_DESHABILITAR_PRODUCTO", param);
        }

        public string ConsultarProducto(int codProducto)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_producto", codProducto));
            SqlParameter outParam = new SqlParameter("@producto", SqlDbType.VarChar, 100);
            outParam.Direction = ParameterDirection.Output;
            listParam.Add(outParam);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_PRODUCTO_FILTRO", listParam);

            return outParam.Value.ToString();
        }

        public int ConsultarStock(int codProducto, int codSucursal)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_producto", codProducto));
            listParam.Add(new SqlParameter("@cod_sucursal", codSucursal));
            SqlParameter outParam = new SqlParameter("@stock", SqlDbType.VarChar, 100);
            outParam.Direction = ParameterDirection.Output;
            listParam.Add(outParam);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_STOCK", listParam);

            return Convert.ToInt32(outParam.Value);
        }
    }
}
