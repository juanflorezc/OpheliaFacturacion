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
    public class InventoryServices : IInventoryServices
    {
        private readonly OpheliaFacturacionContext _context;

        public InventoryServices(OpheliaFacturacionContext context)
        {
            _context = context;
        }

        public async Task<List<Inventario>> createIntentario(Inventario prmIntentario)
        {
            _context.Inventarios.Add(prmIntentario);
            _context.SaveChanges();
            return _context.Inventarios.ToList();
        }

        public async Task<List<Producto>> createProduct(Producto prmProducto)
        {
            _context.Productos.Add(prmProducto);
            _context.SaveChanges();
            return _context.Productos.ToList();
        }

        public async Task<Inventario> deleteInventario(Inventario prmInventario)
        {
            _context.Inventarios.Remove(prmInventario);
            _context.SaveChanges();
            return new Inventario();
        }

        public async Task<Producto> deleteProduct(Producto prmProducto)
        {
            _context.Productos.Remove(prmProducto);
            _context.SaveChanges();
            return new Producto();
        }

        public async Task<List<Inventario>> getIntentario()
        {
            return _context.Inventarios.ToList();
        }

        public async Task<List<Producto>> getProduct()
        {
            return _context.Productos.ToList();
        }

        public async Task<Inventario> updateInventario(Inventario prmInventario)
        {
            _context.Inventarios.Update(prmInventario);
            _context.SaveChanges();
            return prmInventario;
        }

        public async Task<Producto> updateProduct(Producto prmProducto)
        {
            _context.Productos.Update(prmProducto);
            _context.SaveChanges();
            return prmProducto;
        }
    }
}
