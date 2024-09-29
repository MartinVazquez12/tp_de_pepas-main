using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Recetas
    {
        private int codReceta;
        private int cantidad;
        private int tipoReceta;
        private Medicos medico;
        private Productos producto;

        public int CodReceta { get { return codReceta; } set { codReceta = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public int TipoReceta { get { return tipoReceta; } set { tipoReceta = value; } }
        public Medicos Medico { get { return medico; } set { medico = value; } }

        public Productos Producto { get { return producto; } set { producto = value; } }

        public Recetas() 
        {
            codReceta = 0;
            cantidad = 0;
            tipoReceta = 0;
            medico = new Medicos();
            producto = new Productos();
        }

        public Recetas(int codReceta, int cantidad, int tipoReceta, Medicos medico, Productos producto)
        {
            this.codReceta = codReceta;
            this.cantidad = cantidad;
            this.tipoReceta = tipoReceta;
            this.medico = medico;
            this.producto = producto;
        }

        public override string ToString()
        {
            return $"Receta | {Producto.Descripcion}";
        }
    }
}
