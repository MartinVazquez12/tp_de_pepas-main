using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Entidades
{
    public class Reembolsos
    {
        private int codReembolso;
        private double importe;
        private bool cobrado;
        private DateTime fecha;
        private DetallesFactura detalleFactura;

        public int CodReembolso { get { return codReembolso; } set { codReembolso = value; } }
        public double Importe { get { return importe; } set { importe = value; } }
        public bool Cobrado { get { return cobrado; } set { cobrado = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public DetallesFactura DetalleFactura { get => detalleFactura; set => detalleFactura = value; }

        public Reembolsos() 
        {
            codReembolso = 0;
            importe = 0;
            cobrado = false;
            fecha = DateTime.Now;
            detalleFactura = new DetallesFactura();
        }

        public Reembolsos(int codReembolso, double importe, bool cobrado, DateTime fecha, DetallesFactura detalleFactura)
        {
            this.codReembolso = codReembolso;
            this.importe = importe;
            this.cobrado = cobrado;
            this.fecha = fecha;
            this.detalleFactura = detalleFactura;
        }
    }
}
