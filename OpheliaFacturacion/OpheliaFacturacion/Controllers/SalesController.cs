using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpheliaFacturacion.Helpers;
using OpheliaFacturacion.Model.Models;
using OpheliaFacturacion.Services.interfaces;

namespace OpheliaFacturacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {


        public readonly ISalesServices salesServices;
        private readonly ILogger _logger;
        public SalesController(ISalesServices prmInventoryServices, ILogger<InventoryController> logger)
        {
            salesServices = prmInventoryServices;
            _logger = logger;
            
        }


        #region Cliente
        [HttpPost]
        [Route("Cliente")]
        public async Task<IActionResult> create(Cliente prmP)
        {
            try
            {
                var response = await salesServices.createCliente(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("Cliente")]
        public async Task<IActionResult> update(Cliente prmP)
        {
            try
            {
                var response = await salesServices.updateCliente(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("Cliente")]
        public async Task<IActionResult> delete(Cliente prmP)
        {
            try
            {
                var response = await salesServices.deleteCliente(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("Cliente")]
        public async Task<IActionResult> get()
        {
            try
            {
                var response = await salesServices.getCliente();
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }
        #endregion


        #region Factura
        [HttpPost]
        [Route("Factura")]
        public async Task<IActionResult> createFactura(Factura prmP)
        {
            try
            {
                var response = await salesServices.createFactura(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("Factura")]
        public async Task<IActionResult> updateFactura(Factura prmP)
        {
            try
            {
                var response = await salesServices.updateFactura(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("Factura")]
        public async Task<IActionResult> deleteFactura(Factura prmP)
        {
            try
            {
                var response = await salesServices.deleteFactura(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("Factura")]
        public async Task<IActionResult> getFactura()
        {
            try
            {
                var response = await salesServices.getFactura();
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region FacturaDetalle
        [HttpPost]
        [Route("FacturaDetalle")]
        public async Task<IActionResult> createFacturaDetalle(FacturaDetalle prmP)
        {
            try
            {
                var response = await salesServices.createFacturaDetalle(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("FacturaDetalle")]
        public async Task<IActionResult> updateFacturaDetalle(FacturaDetalle prmP)
        {
            try
            {
                var response = await salesServices.updateFacturaDetalle(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("FacturaDetalle")]
        public async Task<IActionResult> deleteFacturaDetalle(FacturaDetalle prmP)
        {
            try
            {
                var response = await salesServices.deleteFacturaDetalle(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("FacturaDetalle")]
        public async Task<IActionResult> getFacturaDetalle()
        {
            try
            {
                var response = await salesServices.getFacturaDetalle();
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
