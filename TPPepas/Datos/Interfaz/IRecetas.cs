using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Datos.Interfaz
{
    public interface IRecetas
    {
        int Agregar(Recetas receta, SqlTransaction t);
    }
}
