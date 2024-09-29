using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface ITablasAuxiliares
    {
        List<object> ListarTiposProductos();
        List<object> ListarTiposPresentacion();
        List<object> ListarBarrios(int codCiudad);
        List<object> ListarCiudades();
        List<object> ListarMutuales();
        List<object> ListarTiposDocumento();
        List<object> ListarTiposRecetas();
        List<object> ListarFormasDePago();
        string ConsultarTipoProductos(int codProducto);
        string ConsultarMutual(int codCliente);
        string ConsultarFormaPago(int codFormaPago);
        int ConsultarCiudades(int codBarrio);
    }
}
