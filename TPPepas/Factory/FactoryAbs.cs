using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Servicio;

namespace TPPepas.Factory
{
    public abstract class FactoryAbs
    {
        public abstract IServicios CrearServicio();
    }
}
