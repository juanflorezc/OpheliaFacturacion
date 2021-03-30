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
    

        public async Task<Factura> deleteFactura(Factura prmFactura)
        {
            
            _context.Facturas.Remove(prmFactura);
            _context.SaveChanges();
            return new Factura();
        }

        public async Task<FacturaDetalle> deleteFacturaDetalle(FacturaDetalle prmFactura)
        {
            _context.FacturaDetalles.Remove(prmFactura);
            _context.SaveChanges();
            return new FacturaDetalle();
        }

        public async Task<Cliente> deleteCliente(Cliente prmFactura)
        {
            _context.Clientes.Remove(prmFactura);
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

        public async Task<Factura> updateFactura(Factura prmFactura)
        {
            _context.Facturas.Update(prmFactura);
            _context.SaveChanges();
            return prmFactura;
        }

        public async Task<FacturaDetalle> updateFacturaDetalle(FacturaDetalle prmFactura)
        {
            _context.FacturaDetalles.Update(prmFactura);
            _context.SaveChanges();
            return prmFactura;
        }

        public async Task<Cliente> updateCliente(Cliente prmCliente)
        {
            _context.Clientes.Add(prmCliente);
            _context.SaveChanges();
            return prmCliente;
        }
    }
}
