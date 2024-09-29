using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Facturas
    {
        private int nroFactura;
        private DateTime fecha;
        private Empleados empleado;
        private Clientes cliente;
        private Sucursales sucursal;
        private int tipoPago;
        private List<DetallesFactura> lDetalles;

        public int NroFactura { get { return nroFactura; } set { nroFactura = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public Empleados Empleado { get { return empleado; } set { empleado = value; } }
        public Clientes Cliente { get { return cliente; } set { cliente = value; } }
        public Sucursales Sucursal { get { return sucursal; } set { sucursal = value; } }
        public int TipoPago { get { return tipoPago; } set { tipoPago = value; } }
        public List<DetallesFactura> LDetalles { get { return lDetalles; } }


        public Facturas() 
        {
            this.nroFactura = 0;
            this.fecha = DateTime.Now;
            this.empleado = new Empleados();
            this.cliente = new Clientes();
            this.sucursal = new Sucursales();
            this.tipoPago = 0;
            lDetalles = new List<DetallesFactura>();
        }

        public Facturas(int nroFactura, DateTime fecha, Empleados empleado, Clientes cliente, Sucursales sucursal, int tipoPago)
        {
            this.nroFactura = nroFactura;
            this.fecha = fecha;
            this.empleado = empleado;
            this.cliente = cliente;
            this.sucursal = sucursal;
            this.tipoPago = tipoPago;
            lDetalles = new List<DetallesFactura>();
        }

        public void AgregarDetalle(DetallesFactura detalle)
        {
            lDetalles.Add(detalle);
        }

        public void QuitarDetalle(int posicion)
        {
            lDetalles.RemoveAt(posicion);
        }
    }
}
