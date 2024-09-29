using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Respaldos
    {
        // Revisar pq en receta estan la mayoria de atributos.
        private Recetas receta;
        private string descripcion;
        private int tipoReceta;
        private int matricula;
        private bool estado;

        public Recetas CodReceta { get { return receta; } set { receta = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public int TipoReceta { get { return tipoReceta; } set { tipoReceta = value; } }
        public int Matricula { get { return matricula; } set { matricula = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }

        public Respaldos() 
        {
            receta = new Recetas();
            descripcion = String.Empty;
            tipoReceta = 0;
            matricula = 0;
            estado = false;
        }

        public Respaldos(Recetas receta, string descripcion, int tipoReceta, int matricula, bool estado)
        {
            this.receta = receta;
            this.descripcion = descripcion;
            this.tipoReceta = tipoReceta;
            this.matricula = matricula;
            this.estado = estado;
        }
    }
}
