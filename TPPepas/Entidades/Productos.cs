using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Productos
    {
        private int codProducto;
        private string descripcion;
        private double precio;
        private int stockMinimo;
        private int tipoProducto;
        private int tipoPresentacion;
        private bool ventaLibre;
        private bool activo;
        private Laboratorio laboratorio;

        public int CodProducto { get { return codProducto; } set { codProducto = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public int StockMinimo { get { return stockMinimo; } set { stockMinimo = value; } }
        public int TipoProducto { get { return tipoProducto; } set { tipoProducto = value; } }
        public int TipoPresentacion { get { return tipoPresentacion; } set { tipoPresentacion = value;} }
        public bool VentaLibre { get { return ventaLibre; } set { ventaLibre = value; } }
        public Laboratorio Laboratorio { get { return laboratorio; } set { laboratorio = value; } }

        public Productos() 
        {
            this.codProducto = 0;
            this.descripcion = String.Empty;
            this.precio = 0;
            this.activo = true;
            this.stockMinimo = 0;
            this.tipoProducto = 0;
            this.tipoPresentacion = 0;
            this.ventaLibre = false;
            laboratorio = new Laboratorio();
        }


        public Productos(int codProducto, string descripcion, double precio, int stockMinimo, int tipoProducto, int tipoPresentacion, bool ventaLibre, Laboratorio laboratorio)
        {
            this.codProducto = codProducto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.activo = true;
            this.stockMinimo = stockMinimo;
            this.tipoProducto = tipoProducto;
            this.tipoPresentacion = tipoPresentacion;
            this.ventaLibre = ventaLibre;
            this.laboratorio = laboratorio;
        }

        public override string ToString()
        {
            return $"{descripcion} | {precio} | :{stockMinimo}";
        }
    }
}
