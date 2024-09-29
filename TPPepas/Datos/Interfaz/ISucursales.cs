using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface ISucursales
    {
        List<object> Listar();
        Sucursales ConsultarObjetoSucursal(int idSucursal);
        string ConsultarSucursal(int idSucursal);
    }
}
