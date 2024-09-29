using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Entidades;

namespace TPPepas.Datos.Interfaz
{
    public interface ILotes
    {
        void Agregar(Pedidos pedido, SqlTransaction t);
        void ModificarStock(Pedidos pedido, SqlTransaction t);
    }
}
