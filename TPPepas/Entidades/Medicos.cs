using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Medicos : Personas
    {
        private int matricula;

        public int Matricula { get { return matricula; } set { matricula = value; } }

        public Medicos() : base() 
        {
            matricula = 0;
        }

        public Medicos(string nombre, string apellido, string calle, int altura, int codBarrio, int tipoDoc, int nroDoc, int matricula)
            : base(nombre, apellido, calle, altura, codBarrio, tipoDoc, nroDoc)
        {
            this.matricula = matricula;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
