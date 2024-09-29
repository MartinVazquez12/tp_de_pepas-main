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
    public class ClientesDAO : IClientes
    {
        public List<object> Listar()
        {
            List<object> lista = new List<object>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_CLIENTES");

            foreach (DataRow row in tabla.Rows)
            {
                Clientes c = new Clientes();
                c.CodCliente = Convert.ToInt32(row[0].ToString());
                c.Nombre = row[1].ToString();
                c.Apellido = row[2].ToString();
                c.Calle = row[3].ToString();
                c.Altura = Convert.ToInt32(row[4].ToString());
                c.CodBarrio = Convert.ToInt32(row[5].ToString());
                c.NroDoc = Convert.ToInt32(row[6].ToString());
                c.TipoDoc = Convert.ToInt32(row[7].ToString());
                c.CodMutual = Convert.ToInt32(row[8].ToString());
                c.NroAfliliado = Convert.ToInt32(row[9].ToString());

                lista.Add(c);
            }

            return lista;
        }

        public bool Agregar(Clientes cliente)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@nombre", cliente.Nombre));
            listParam.Add(new SqlParameter("@apellido", cliente.Apellido));
            listParam.Add(new SqlParameter("@calle", cliente.Calle));
            listParam.Add(new SqlParameter("@altura", cliente.Altura));
            listParam.Add(new SqlParameter("@nro_afiliado", cliente.NroAfliliado));
            listParam.Add(new SqlParameter("@nro_doc", cliente.NroDoc));
            listParam.Add(new SqlParameter("@cod_tipo_doc", cliente.TipoDoc));
            listParam.Add(new SqlParameter("@cod_barrio", cliente.CodBarrio));
            listParam.Add(new SqlParameter("@cod_mutual", cliente.CodMutual));

            return AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_CLIENTES", listParam);
        }

        public bool Modificar(Clientes cliente)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@id", cliente.CodCliente));
            listParam.Add(new SqlParameter("@nombre", cliente.Nombre));
            listParam.Add(new SqlParameter("@apellido", cliente.Apellido));
            listParam.Add(new SqlParameter("@calle", cliente.Calle));
            listParam.Add(new SqlParameter("@altura", cliente.Altura));
            listParam.Add(new SqlParameter("@nro_afiliado", cliente.NroAfliliado));
            listParam.Add(new SqlParameter("@nro_doc", cliente.NroDoc));
            listParam.Add(new SqlParameter("@cod_tipo_doc", cliente.TipoDoc));
            listParam.Add(new SqlParameter("@cod_barrio", cliente.CodBarrio));
            listParam.Add(new SqlParameter("@cod_mutual", cliente.CodMutual));

            return AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_MODIFICAR_CLIENTES", listParam);
        }

        public List<object> ListarFiltro(string cliente)
        {
            List<object> lista = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();
            listParam.Add(new SqlParameter("@cliente", cliente));

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_CLIENTES_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Clientes c = new Clientes();
                c.CodCliente = Convert.ToInt32(row[0].ToString());
                c.Nombre = row[1].ToString();
                c.Apellido = row[2].ToString();
                c.Calle = row[3].ToString();
                c.Altura = Convert.ToInt32(row[4].ToString());
                c.CodBarrio = Convert.ToInt32(row[5].ToString());
                c.NroDoc = Convert.ToInt32(row[6].ToString());
                c.TipoDoc = Convert.ToInt32(row[7].ToString());
                c.CodMutual = Convert.ToInt32(row[8].ToString());
                c.NroAfliliado = Convert.ToInt32(row[9].ToString());

                lista.Add(c);
            }

            return lista;
        }

        public List<object> ListarFiltro(string cliente, int nroDoc)
        {
            List<object> lista = new List<object>();

            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cliente", cliente));
            listParam.Add(new SqlParameter("@nro_doc", nroDoc));

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_CLIENTES_FILTROS", listParam);

            foreach (DataRow row in tabla.Rows)
            {
                Clientes c = new Clientes();
                c.CodCliente = Convert.ToInt32(row[0].ToString());
                c.Nombre = row[1].ToString();
                c.Apellido = row[2].ToString();
                c.Calle = row[3].ToString();
                c.Altura = Convert.ToInt32(row[4].ToString());
                c.CodBarrio = Convert.ToInt32(row[5].ToString());
                c.NroDoc = Convert.ToInt32(row[6].ToString());
                c.TipoDoc = Convert.ToInt32(row[7].ToString());
                c.CodMutual = Convert.ToInt32(row[8].ToString());
                c.NroAfliliado = Convert.ToInt32(row[9].ToString());

                lista.Add(c);
            }

            return lista;
        }

        public string ConsultarCliente(int idCliente)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();

            listParam.Add(new SqlParameter("@cod_cliente", idCliente));
            SqlParameter paramOut = new SqlParameter("@cliente", SqlDbType.VarChar, 100);
            paramOut.Direction = ParameterDirection.Output;
            listParam.Add(paramOut);

            AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_CONSULTAR_CLIENTE_FILTRO", listParam);

            return paramOut.Value.ToString();
        }
    }
}
