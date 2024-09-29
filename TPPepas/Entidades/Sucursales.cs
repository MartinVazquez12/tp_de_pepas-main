using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Sucursales
    {
        private int codSucursal;
        private string calle;
        private int altura;
        private int codBarrio;

        public int CodSucursal { get { return codSucursal; } set { codSucursal = value; } }
        public string Calle { get { return calle; } set { calle = value; } }
        public int Altura { get { return altura; } set { altura = value; } }
        public int CodBarrio { get { return codBarrio; } set { codBarrio = value; } }

        public Sucursales() 
        {
            codSucursal = 0;
            calle = String.Empty;
            altura = 0;
            codBarrio = 0;
        }

        public Sucursales(int codSucursal)
        {
            this.codSucursal = codSucursal;
            calle = String.Empty;
            altura = 0;
            codBarrio = 0;
        }

        public Sucursales(int codSucursal, string calle, int altura, int codBarrio)
        {
            this.codSucursal = codSucursal;
            this.calle = calle;
            this.altura = altura;
            this.codBarrio = codBarrio;
        }
    }
}
