using AutomotrizBackProg.Dominio;
using AutomotrizBackProg.Fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProgAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private IData data;
        public ProductoController()
        {
            data = new DataLib();
        }
        
        [HttpPost("/Producto")]
        public IActionResult PostProducto(Producto producto)
        {
            try
            {
                if (producto == null)
                {
                    return BadRequest("Datos de producto incorrectos!");
                }

                return Ok(data.saveProducto(producto));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        
        [HttpDelete("/EliminarProducto")]
        public IActionResult DeleteProducto(int idProducto)
        {
            try
            {
                if (idProducto == 0)
                {
                    return BadRequest("Numero de producto incorrecto!");
                }
                return Ok(data.deleteProducto(idProducto));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        
        [HttpPut("/EditarProducto")]
        public IActionResult updateProducto(int idProducto, Producto producto)
        {
            try
            {
                if (idProducto == 0)
                {
                    return BadRequest("Numero de cliente incorrecto!");
                }
                return Ok(data.updateProducto(idProducto, producto));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
