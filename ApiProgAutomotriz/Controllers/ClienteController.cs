using AutomotrizBackProg.Dominio;
using AutomotrizBackProg.Fachada;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProgAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IData data;
        public ClienteController()
        {
            data = new DataLib();
        }
        [HttpGet("/TipoCliente")]
        public IActionResult getTipoCliente()
        {
            List<TipoCliente> tipocliente = null;
            try
            {
                tipocliente = data.getTipoCliente();
                return Ok(tipocliente);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = tipocliente });

            }
        }

        [HttpGet("/TipoDoc")]
        public IActionResult getTipoDoc()
        {
            List<TipoDoc> tipodoc = null;
            try
            {
                tipodoc = data.getTipoDoc();
                return Ok(tipodoc);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = tipodoc });

            }
        }

        [HttpGet("/Barrios")]
        public IActionResult getBarrios()
        {
            List<Barrios> barrios = null;
            try
            {
                barrios = data.getBarrios();
                return Ok(barrios);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = "ERROR", Response = barrios });

            }
        }

        [HttpPost("/Cliente")]
        public IActionResult postCliente(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Datos de cliente incorrectos!");
                }

                return Ok(data.saveCliente(cliente));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpDelete("/EliminarCliente")]
        public IActionResult deleteCliente(int idCliente)
        {
            try
            {
                if (idCliente == 0)
                {
                    return BadRequest("Numero de cliente incorrecto!");
                }
                return Ok(data.deleteCliente(idCliente));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPut("/EditarCliente")]
        public IActionResult updateCliente(int idCliente, Cliente cliente)
        {
            try
            {
                if (idCliente == 0)
                {
                    return BadRequest("Numero de cliente incorrecto!");
                }
                return Ok(data.updateCliente(idCliente, cliente));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
