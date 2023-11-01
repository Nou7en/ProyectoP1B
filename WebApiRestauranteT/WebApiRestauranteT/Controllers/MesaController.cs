using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRestauranteT.Datos;
using WebApiRestauranteT.Models;

namespace WebApiRestauranteT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public MesaController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetMesas()
        {
            try
            {
                List<Mesa> mesas = _db.Mesas.ToList();
                return Ok(mesas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
