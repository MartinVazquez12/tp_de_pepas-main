using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Entidades
{
     public class Lotes
    {
        private int codLote;
        private int cantidad;
        private double precio;
        private Proveedores proveedor;
        private Productos producto;
        private DateTime fechaVencimiento;
        private int nroPedido;

        public Lotes(int codLote, int cantidad, double precio, Proveedores proveedor, Productos producto, DateTime fechaVencimiento, int nroPedido = 0)
        {
            this.codLote = codLote;
            this.cantidad = cantidad;
            this.precio = precio;
            this.proveedor = proveedor;
            this.producto = producto;
            this.fechaVencimiento = fechaVencimiento;
            this.nroPedido = nroPedido;
        }

        public Lotes()
        {
            this.codLote = 0;
            this.cantidad = 0;
            this.precio = 0;
            this.proveedor = new Proveedores();
            this.producto = new Productos();
            this.fechaVencimiento = DateTime.Now;
            this.nroPedido = 0;
        }

        public int CodLote { get => codLote; set => codLote = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public Proveedores Proveedor { get => proveedor; set => proveedor = value; }
        public Productos Producto { get => producto; set => producto = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public int NroPedido { get => nroPedido; set => nroPedido = value; }

        public double CalcularSubTotal()
        {
            return cantidad * precio;
        }
    }
}
