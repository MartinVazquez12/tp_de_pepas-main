using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Laboratorio
    {
        private int codLaboratorio;
        private string nomLaboratorio;
        private string telefono;
        private string email;

        public int CodLaboratorio { get { return codLaboratorio; } set { codLaboratorio = value; } }
        public string NomLaboratorio { get { return nomLaboratorio; } set { nomLaboratorio = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Laboratorio() 
        {
            codLaboratorio = 0;
            nomLaboratorio = String.Empty;
            telefono = String.Empty;
            email = String.Empty;
        }

        public Laboratorio(int codLaboratorio, string nomLaboratorio, string telefono, string email)
        {
            this.codLaboratorio = codLaboratorio;
            this.nomLaboratorio = nomLaboratorio;
            this.telefono = telefono;
            this.email = email;
        }

        public override string ToString()
        {
            return $"{nomLaboratorio}";
        }
    }
}
