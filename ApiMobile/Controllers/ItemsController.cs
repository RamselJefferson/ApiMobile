using ApiMobile.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiMobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : Controller
    {
        private readonly ApiContext _context;
        public ItemsController(ApiContext context)
        {
                _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = _context.Items.ToList();
            return Ok(items);
        }


        [HttpGet("SearchItemsFilter")]

        public async Task<IActionResult> SearchItemsFilter(string search)
        {
            var items = _context.Items.Where(x => x.Descripcion.Contains(search));
            if (items.Any())
            {
                return Ok(items);
            }
            return BadRequest();

        }
    }
}
