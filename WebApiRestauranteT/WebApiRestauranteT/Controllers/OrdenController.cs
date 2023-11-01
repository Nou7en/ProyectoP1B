using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiRestauranteT.Datos;
using WebApiRestauranteT.Models;

namespace WebApiRestauranteT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public OrdenController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public async Task<IActionResult> CrearOrden([FromBody] Orden nOrden, int idMesa)
        {
            try
            {
                var mesa = await _db.Mesas.FirstOrDefaultAsync(m => m.idMesa == idMesa);
                if (mesa == null)
                {
                    return NotFound();
                }
                if (mesa.estado == true)
                {
                    return BadRequest("La mesa esta ocupada");
                }
                await _db.Ordenes.AddAsync(nOrden);
                await _db.SaveChangesAsync();
                return Ok(nOrden);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            } 
        }
        [HttpGet]
        public async Task<IActionResult> GetOrdenes()
        {
            try
            {
                List<Orden> ordenes = _db.Ordenes.ToList();
                return Ok(ordenes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("idOrden/{idOrden}")]
        public async Task<IActionResult> GetOrden(int idOrden)
        {
            try
            {
                Orden orden = await _db.Ordenes.FirstOrDefaultAsync(o => o.idOrden == idOrden);
                if (orden == null)
                {
                    return NoContent();
                }
                return Ok(orden);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
