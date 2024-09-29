using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public abstract class Personas
    {
        private string nombre;
        private string apellido;
        private string calle;
        private int altura;
        private int codBarrio;
        private int tipoDoc;
        private int nroDoc;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Calle { get { return calle; } set { calle = value; } }
        public int Altura { get { return altura; } set { altura = value; } }
        public int CodBarrio { get { return codBarrio; } set { codBarrio = value; } }
        public int TipoDoc { get { return tipoDoc; } set { tipoDoc = value; } }
        public int NroDoc { get { return nroDoc; } set { nroDoc = value; } }

        public Personas() 
        {
            nombre = String.Empty;
            apellido = String.Empty;
            calle = String.Empty;
            altura = 0;
            codBarrio = 0;
            tipoDoc = 0;
            nroDoc = 0;
        }

        public Personas(string nombre, string apellido, string calle, int altura, int codBarrio, int tipoDoc, int nroDoc)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.calle = calle;
            this.altura = altura;
            this.codBarrio = codBarrio;
            this.tipoDoc = tipoDoc;
            this.nroDoc = nroDoc;
        }

        public override string ToString()
        {
            return $"{apellido.ToUpper()}, {nombre} | {nroDoc}";
        }
    }
}
