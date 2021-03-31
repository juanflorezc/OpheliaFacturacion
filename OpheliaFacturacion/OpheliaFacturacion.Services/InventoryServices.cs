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

        public async Task<Inventario> deleteInventario(int key)
        {
            var prmInventario = _context.Inventarios.Find(key);
            _context.Inventarios.Remove(prmInventario);
            _context.SaveChanges();
            return new Inventario();
        }

        public async Task<Producto> deleteProduct(int key)
        {
            var prmProducto = _context.Productos.Find(key);
            _context.Productos.Remove(prmProducto);
            _context.SaveChanges();
            return new Producto();
        }

        public async Task<List<Inventario>> getIntentario()
        {
            var response =_context.Inventarios.Include(x=>x.Producto).ToList();
            return response;
        }

        public async Task<List<Producto>> getProduct()
        {
            return _context.Productos.ToList();
        }

        public async Task<Inventario> updateInventario(int key,Inventario prmInventario)
        {
            var inventarioAntiguo = _context.Inventarios.Find(key);
            inventarioAntiguo.CantidadActual = prmInventario.CantidadActual == null ? inventarioAntiguo.CantidadActual : prmInventario.CantidadActual;
            inventarioAntiguo.ProductoId = prmInventario.ProductoId == null ? inventarioAntiguo.ProductoId : prmInventario.ProductoId;
            _context.Inventarios.Update(inventarioAntiguo);
            _context.SaveChanges();
            return prmInventario;
        }

        public async Task<Producto> updateProduct(int key, Producto prmProducto)
        {
            var productoAntiguo = _context.Productos.Find(key);
            productoAntiguo.Nombre = prmProducto.Nombre == null ? productoAntiguo.Nombre : prmProducto.Nombre;
            productoAntiguo.ValorUnitario = prmProducto.ValorUnitario == null ? productoAntiguo.ValorUnitario : prmProducto.ValorUnitario;
            _context.Productos.Update(productoAntiguo);
            _context.SaveChanges();
            return prmProducto;
        }
    }
}
