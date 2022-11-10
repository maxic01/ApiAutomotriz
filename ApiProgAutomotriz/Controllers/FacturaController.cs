using AutomotrizBackProg.Dominio;
using AutomotrizBackProg.Fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProgAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private IData data;
        public FacturaController()
        {
            data = new DataLib();
        }

        [HttpGet("/Facturas")]
        public IActionResult getFacturas()
        {
            List<Factura> facturas = null;
            try
            {
                facturas = data.getFacturas();
                return Ok(facturas);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = facturas });

            }
        }
        
        [HttpGet("/FacturaIndividual")]
        public IActionResult getFactura(int numero)
        {
            Factura factura = null;
            try
            {
                factura = data.getFactura(numero);
                return Ok(factura);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = factura });

            }
        }
        
        [HttpGet("/Productos")]
        public IActionResult getProductos()
        {
            List<Producto> products = null;
            try
            {
                products = data.getProductos();
                return Ok(products);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = products });

            }
        }

        [HttpGet("/Clientes")]
        public IActionResult getCliente()
        {
            List<Cliente> clientes = null;
            try
            {
                clientes = data.getCliente();
                return Ok(clientes);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = clientes });

            }
        }

        [HttpGet("/Vendedores")]
        public IActionResult getVendedor()
        {
            List<Vendedor> vendedores = null;
            try
            {
                vendedores = data.getVendedor();
                return Ok(vendedores);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = vendedores });

            }
        }

        [HttpGet("/FormaEntrega")]
        public IActionResult getFormaEntrega()
        {
            List<FormaEntrega> entregas = null;
            try
            {
                entregas = data.getFormaEntrega();
                return Ok(entregas);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = entregas });

            }
        }

        [HttpGet("/FormaPago")]
        public IActionResult getFormaPago()
        {
            List<FormaPago> pagos = null;
            try
            {
                pagos = data.getFormaPago();
                return Ok(pagos);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = pagos });

            }
        }

        [HttpGet("/MedioPedido")]
        public IActionResult getMedioPedido()
        {
            List<MedioPedido> medios = null;
            try
            {
                medios = data.getMedioPedido();
                return Ok(medios);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = medios });

            }
        }

        [HttpPost("/Factura")]
        public IActionResult PostFactura(Factura factura)
        {
            try
            {
                if (factura == null)
                {
                    return BadRequest("Datos de factura incorrectos!");
                }

                return Ok(data.saveFactura(factura));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/EliminarFactura")]
        public IActionResult deleteFactura(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("Numero de factura incorrecto!");
                }
                return Ok(data.deleteFactura(id));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPut("/EditarFactura")]
        public IActionResult updateFactura(int numero, Factura factura)
        {
            try
            {
                if (factura == null)
                {
                    return BadRequest("Numero de factura incorrecto!");
                }
                return Ok(data.updateFactura(numero,factura));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
