using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Entidades;

namespace TPPepas.Datos.Interfaz
{
    public interface IPedidos
    {
        bool Agregar(Pedidos pedido);
        List<object> Listar();
        List<object> ListarFiltro(DateTime desde, DateTime hasta);
        List<object> ListarFiltro(DateTime desde, DateTime hasta, int sucursal);
        List<object> ListarFiltro(DateTime desde, DateTime hasta, int sucursal, int codPedido);
        List<object> ListarLotes(int nroPedido);
    }
}
