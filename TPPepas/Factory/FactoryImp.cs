using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Servicio;

namespace TPPepas.Factory
{
    public class FactoryImp : FactoryAbs
    {
        public override IServicios CrearServicio()
        {
            return new Servicios();
        }
    }
}
