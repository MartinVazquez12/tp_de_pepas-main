using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface IProveedores
    {
        List<object> Listar();
        List<object> ListarFiltro(string nomProv);
        bool Agregar(Proveedores proveedor);
        string ConsultarProveedor(int codProveedor);
    }
}
