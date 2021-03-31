using OpheliaFacturacion.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpheliaFacturacion.Services.interfaces
{
    public interface ISalesServices
    {
        #region clientes
        Task<List<Cliente>> getCliente();
        Task<List<Cliente>> createCliente(Cliente prmCliente);
        Task<Cliente> updateCliente(int key, Cliente prmFactura);
        Task<Cliente> deleteCliente(int prmFactura);
        #endregion

        #region Factura
        Task<List<Factura>> getFactura();
        Task<List<Factura>> createFactura(Factura prmFactura);
        Task<Factura> updateFactura(int key, Factura prmFactura);
        Task<Factura> deleteFactura(int prmFactura);
        #endregion

        #region FacturaDEtalle
        Task<List<FacturaDetalle>> getFacturaDetalle();
        Task<List<FacturaDetalle>> createFacturaDetalle(FacturaDetalle prmFactura);
        Task<FacturaDetalle> updateFacturaDetalle(int key,FacturaDetalle prmFactura);
        Task<FacturaDetalle> deleteFacturaDetalle(int prmFactura);
        #endregion
    }
}
