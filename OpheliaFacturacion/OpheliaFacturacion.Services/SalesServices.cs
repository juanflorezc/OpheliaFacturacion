using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpheliaFacturacion.Model.Models;
using OpheliaFacturacion.Services.interfaces;

namespace OpheliaFacturacion.Services
{
    public class SalesServices : ISalesServices
    {
        private readonly OpheliaFacturacionContext _context;

        public SalesServices(OpheliaFacturacionContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> createCliente(Cliente prmCliente)
        {
            _context.Clientes.Add(prmCliente);
            _context.SaveChanges();
            return _context.Clientes.ToList();
        }

        public async Task<List<Factura>> createFactura(Factura prmFactura)
        {
            _context.Facturas.Add(prmFactura);
            _context.SaveChanges();
            return _context.Facturas.ToList();
        }

        public async Task<List<FacturaDetalle>> createFacturaDetalle(FacturaDetalle prmFactura)
        {
            _context.FacturaDetalles.Add(prmFactura);
            _context.SaveChanges();
            return _context.FacturaDetalles.ToList();
        }
    

        public async Task<Factura> deleteFactura(int key)
        {
            var prmFactura = _context.Facturas.Find(key);
            _context.Facturas.Remove(prmFactura);
            _context.SaveChanges();
            return new Factura();
        }

        public async Task<FacturaDetalle> deleteFacturaDetalle(int key)
        {
            var prmFactura = _context.FacturaDetalles.Find(key);
            _context.FacturaDetalles.Remove(prmFactura);
            _context.SaveChanges();
            return new FacturaDetalle();
        }

        public async Task<Cliente> deleteCliente(int key)
        {
            var prmCliente = _context.Clientes.Find(key);
            _context.Clientes.Remove(prmCliente);
            _context.SaveChanges();
            return new Cliente();
        }

        public async Task<List<Cliente>> getCliente()
        {
            return _context.Clientes.ToList();
        }

        public async Task<List<Factura>> getFactura()
        {
            return _context.Facturas.ToList();
        }

        public async Task<List<FacturaDetalle>> getFacturaDetalle()
        {
            return _context.FacturaDetalles.ToList();
        }

        public async Task<Factura> updateFactura(int key,Factura prmFactura)
        {
            var facturaAntiguo = _context.Facturas.Find(key);
            facturaAntiguo.ClienteId = prmFactura.ClienteId == null ? facturaAntiguo.ClienteId : prmFactura.ClienteId;
            facturaAntiguo.FechaCompra = prmFactura.FechaCompra == null ? facturaAntiguo.FechaCompra : prmFactura.FechaCompra;
            facturaAntiguo.FacturaDetalles = prmFactura.FacturaDetalles == null ? facturaAntiguo.FacturaDetalles : prmFactura.FacturaDetalles;
            _context.Facturas.Update(facturaAntiguo);
            _context.SaveChanges();
            return prmFactura;
        }

        public async Task<FacturaDetalle> updateFacturaDetalle(int key, FacturaDetalle prmFactura)
        {
            var facturaAntiguo = _context.FacturaDetalles.Find(key);
            facturaAntiguo.ProductoId = prmFactura.ProductoId == null ? facturaAntiguo.ProductoId : prmFactura.ProductoId;
            facturaAntiguo.Cantidad = prmFactura.Cantidad == null ? facturaAntiguo.Cantidad : prmFactura.Cantidad;

            _context.FacturaDetalles.Update(facturaAntiguo);
            _context.SaveChanges();
            return prmFactura;
        }

        public async Task<Cliente> updateCliente(int key, Cliente prmCliente)
        {
            var ClienteAntiguo = _context.Clientes.Find(key);
            ClienteAntiguo.Nombres = prmCliente.Nombres == null ? ClienteAntiguo.Nombres : prmCliente.Nombres;
            ClienteAntiguo.FechaNacimiento = prmCliente.FechaNacimiento == null ? ClienteAntiguo.FechaNacimiento : prmCliente.FechaNacimiento;
            _context.Clientes.Update(ClienteAntiguo);
            _context.SaveChanges();
            return prmCliente;
        }
    }
}
