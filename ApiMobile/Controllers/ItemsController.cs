using ApiMobile.Interfaces;
using ApiMobile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiMobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : Controller
    {


        private readonly IvwItemsCategoria _vwItemsCategoria;
        public ItemsController(ApiContext context, IvwItemsCategoria vwItemsCategoria)
        {

             
            _vwItemsCategoria = vwItemsCategoria;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        
        {
            var items =   _vwItemsCategoria.GetAll();
            return Ok(items);
        }


        [HttpGet("SearchItemsFilter")]

        public async Task<IActionResult> SearchItemsFilter(string search)
        {
            var items = _vwItemsCategoria.Where(x => x.ItemDescripcion.ToLower().Contains(search.ToLower()) || x.CatDescripcion.ToLower().Contains(search.ToLower()));
            if (items.Any())
            {
                return Ok(items);
            }
            return BadRequest();

        }

    }
}
