using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface IFacturas
    {
        bool Agregar(Facturas factura);
        List<object> ListarFiltros(DateTime fechaDesde, DateTime fechaHasta, string cliente, int nroFactura);
        bool DarDeBaja(int nroFactura);
        List<object> ListarDetalles(int nroFactura);
    }
}
