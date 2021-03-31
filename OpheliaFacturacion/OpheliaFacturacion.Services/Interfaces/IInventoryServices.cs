using OpheliaFacturacion.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpheliaFacturacion.Services.interfaces
{
    public interface IInventoryServices
    {
        #region productos
        Task<List<Producto>> getProduct();
        Task<List<Producto>> createProduct(Producto prmProducto);
        Task<Producto> updateProduct(int key, Producto prmProducto);
        Task<Producto> deleteProduct(int key);
        #endregion

        #region inventario
        Task<List<Inventario>> getIntentario();
        Task<List<Inventario>> createIntentario(Inventario prmIntentario);
        Task<Inventario> updateInventario(int key, Inventario prmInventario);
        Task<Inventario> deleteInventario(int key);
        #endregion

    }
}
