using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Empleados : Personas
    {
        private int codEmpleado;

        public int CodEmpleado { get { return codEmpleado; } set { codEmpleado = value; } }

        public Empleados() : base() 
        {
            codEmpleado = 0;
        }

        public Empleados(int codEmpleado) : base()
        {
            this.codEmpleado = codEmpleado;
        }

        public Empleados(string nombre, string apellido, string calle, int altura, int idBarrio, int tipoDoc, int nroDoc, int codEmpleado)
            : base(nombre, apellido, calle, altura, idBarrio, tipoDoc, nroDoc)
        {
            this.codEmpleado = codEmpleado;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
