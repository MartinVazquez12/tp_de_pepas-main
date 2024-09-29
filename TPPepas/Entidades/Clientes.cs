using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Clientes : Personas
    {
        private int codCliente;
        private int codMutual;
        private int nroAfiliado;

        public int CodCliente { get { return codCliente; } set { codCliente = value; } }
        public int CodMutual { get { return codMutual; } set { codMutual = value; } }
        public int NroAfliliado { get { return nroAfiliado; } set { nroAfiliado = value; } }

        public Clientes() : base() 
        {
            codCliente = 0;
            codMutual = 0;
            nroAfiliado = 0;
        }

        public Clientes(int codCliente) : base()
        {
            this.codCliente = codCliente;
            codMutual = 0;
            nroAfiliado = 0;
        }

        public Clientes(string nombre, string apellido, string calle, int altura, int codBarrio, int tipoDoc, int nroDoc, int codCliente, int codMutual, int nroAfiliado) 
            : base(nombre, apellido, calle, altura, codBarrio, tipoDoc, nroDoc)
        {
            this.codCliente = codCliente;
            this.codMutual = codMutual;
            this.nroAfiliado = nroAfiliado;
        }

        public override string ToString()
        {
            return $"{Apellido.ToUpper()}, {Nombre}";
        }

    }
}
