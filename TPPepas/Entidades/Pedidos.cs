using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPepas.Entidades
{
    public class Pedidos
    {
        private int codPedido;
        private DateTime fechaPedido;
        private Sucursales sucursal;
        private int tipoPago;
        private List<Lotes> lLotes;

        public int CodPedido { get => codPedido; set => codPedido = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public int TipoPago { get => tipoPago; set => tipoPago = value; }
        public Sucursales Sucursal { get => sucursal; set => sucursal = value; }
        public List<Lotes> LLotes { get => lLotes; set => lLotes = value; }

        public Pedidos()
        {
            this.CodPedido = 0;
            this.FechaPedido = DateTime.Now;
            this.TipoPago = 0;
            this.Sucursal = new Sucursales();
            this.lLotes = new List<Lotes>();
        }

        public Pedidos(int codPedido, DateTime fechaPedido, Sucursales sucursal, int tipoPago)
        {
            this.CodPedido = codPedido;
            this.FechaPedido = fechaPedido;
            this.TipoPago = tipoPago;
            this.Sucursal = sucursal;
            this.lLotes = new List<Lotes>();
        }

        public void AgregarLote(Lotes lote)
        {
            lLotes.Add(lote);
        }

        public void QuitarLote(int posicion)
        {
            lLotes.RemoveAt(posicion);
        }
    }
}
