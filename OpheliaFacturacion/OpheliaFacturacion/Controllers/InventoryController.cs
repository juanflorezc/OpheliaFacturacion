using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
        public async Task<IActionResult> create([FromForm]string values)
        {
            try
            {
                //var values = form.Get("values");
                Producto prmP = new Producto();
                JsonConvert.PopulateObject(values, prmP);
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
        public async Task<IActionResult> update([FromForm]int key, [FromForm]string values)
        {
            try
            {
                Producto prmP = new Producto();
                JsonConvert.PopulateObject(values, prmP);
                var response = await invenotryServices.updateProduct(key,prmP);
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
        public async Task<IActionResult> delete([FromBody]int key)
        {
            try
            {
                var response = await invenotryServices.deleteProduct(key);
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

        

        [HttpGet]
        [Route("ProductoList")]
        public async Task<IActionResult> getList()
        {
            try
            {
                var response = await invenotryServices.getProduct();
                var returnList= from i in response
                                select new
                                {
                                    Value = i.ProductoId,
                                    Text = i.Nombre
                                };
                return Ok(returnList);
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
        public async Task<IActionResult> createInventario([FromForm]string values)
        {
            try
            {                
                Inventario prmP = new Inventario();
                JsonConvert.PopulateObject(values, prmP);
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
        public async Task<IActionResult> updateInventario([FromForm]int key, [FromForm]string values)
        {
            try
            {
                Inventario prmP = new Inventario();
                JsonConvert.PopulateObject(values, prmP);
                prmP.IntentarioId = key;
                var response = await invenotryServices.updateInventario(key,prmP);
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
        public async Task<IActionResult> deleteInventario([FromBody] int key)
        {
            try
            {
                var response = await invenotryServices.deleteInventario(key);
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
