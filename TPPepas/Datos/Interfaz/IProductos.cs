using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface IProductos
    {
        List<object> Listar();
        bool Agregar(Productos producto);
        List<object> ListarFiltro(int tipoProducto);
        List<object> ListarFiltro(string descripcion, int tipoProducto);
        double ConsultarDescuento(Productos producto, Clientes cliente);
        bool DeshabilitarProducto(Productos producto);
        string ConsultarProducto(int codProducto);
        int ConsultarStock(int codProducto, int codSucursal);
    }
}
