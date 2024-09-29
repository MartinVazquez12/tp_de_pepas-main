using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPepas.Datos.Implementacion;
using TPPepas.Datos.Interfaz;

namespace TPPepas.Servicio
{
    public class Servicios : IServicios
    {
        public IClientes Clientes { get; }
        public IProductos Productos { get; }
        public IPedidos Pedidos { get; }
        public IFacturas Facturas { get; }
        public ITablasAuxiliares TablasAuxiliares { get; }
        public IMedicos Medicos { get; }
        public IProveedores Proveedores { get; }
        public ILaboratorios Laboratorios { get; }
        public ISucursales Sucursales { get; }
        public IEmpleados Empleados { get; }
        public ILotes Lotes { get; }
        public ILogin Login { get; }

        public Servicios()
        {
            Clientes = new ClientesDAO();
            Productos = new ProductosDAO();
            Pedidos = new PedidosDAO();
            Facturas = new FacturasDAO();
            TablasAuxiliares = new TablasAuxiliaresDAO();
            Medicos = new MedicosDAO();
            Proveedores = new ProveedoresDAO();
            Laboratorios = new LaboratoriosDAO();
            Sucursales = new SucursalesDAO();
            Empleados = new EmpleadosDAO();
            Lotes = new LotesDAO();
            Login = new LoginDAO();
        }
    }
}
