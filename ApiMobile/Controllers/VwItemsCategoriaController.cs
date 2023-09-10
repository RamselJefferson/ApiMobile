using ApiMobile.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiMobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VwItemsCategoriaController : Controller
    {
        private readonly ApiContext _context;
        public VwItemsCategoriaController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var VwItemsCategoria = _context.VwItemsCategoria.ToList();
            return Ok(VwItemsCategoria);
        }


        [HttpGet("SearchVwItemsCategoriaFilter")]

        public async Task<IActionResult> SearchVwItemsCategoriaFilter(string search)
        {
            var VwItemsCategoria = _context.VwItemsCategoria.Where(x => x.Descripcion.Contains(search));
            if (VwItemsCategoria.Any())
            {
                return Ok(VwItemsCategoria);
            }
            return BadRequest();

        }
    }
}
