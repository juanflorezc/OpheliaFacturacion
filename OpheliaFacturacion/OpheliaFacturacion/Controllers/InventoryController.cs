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
    public class InventoryController : ControllerBase
    {


        public readonly IInventoryServices invenotryServices;
        private readonly ILogger _logger;
        public InventoryController(IInventoryServices prmInventoryServices, ILogger<InventoryController> logger)
        {
            invenotryServices = prmInventoryServices;
            _logger = logger;
            
        }


        #region producto
        [HttpPost]
        [Route("Producto")]
        public async Task<IActionResult> create(Producto prmP)
        {
            try
            {
                var response = await invenotryServices.createProduct(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("Producto")]
        public async Task<IActionResult> update(Producto prmP)
        {
            try
            {
                var response = await invenotryServices.updateProduct(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("Producto")]
        public async Task<IActionResult> delete(Producto prmP)
        {
            try
            {
                var response = await invenotryServices.deleteProduct(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("Producto")]
        public async Task<IActionResult> get()
        {
            try
            {
                var response = await invenotryServices.getProduct();
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }
        #endregion

        #region Inventario
        [HttpPost]
        [Route("Inventario")]
        public async Task<IActionResult> createInventario(Inventario prmP)
        {
            try
            {
                var response = await invenotryServices.createIntentario(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("Inventario")]
        public async Task<IActionResult> updateInventario(Inventario prmP)
        {
            try
            {
                var response = await invenotryServices.updateInventario(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("Inventario")]
        public async Task<IActionResult> deleteInventario(Inventario prmP)
        {
            try
            {
                var response = await invenotryServices.deleteInventario(prmP);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(LogEvents.ExeptionError, ex, "Error Exception");
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("Inventario")]
        public async Task<IActionResult> getInventario()
        {
            try
            {
                var response = await invenotryServices.getIntentario();
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
