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
        Task<Producto> updateProduct(Producto prmProducto);
        Task<Producto> deleteProduct(Producto prmProducto);
        #endregion

        #region inventario
        Task<List<Inventario>> getIntentario();
        Task<List<Inventario>> createIntentario(Inventario prmIntentario);
        Task<Inventario> updateInventario(Inventario prmInventario);
        Task<Inventario> deleteInventario(Inventario prmInventario);
        #endregion

    }
}
