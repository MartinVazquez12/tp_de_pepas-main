using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface IDetallesFactura
    {
        void Agregar(Facturas factura, SqlTransaction t);
        void ModificarStock(Facturas factura, SqlTransaction t);
        void StockSinVencer(Facturas factura, SqlTransaction t);
    }
}
