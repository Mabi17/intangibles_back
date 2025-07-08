using Intangibles.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intangibles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly BdProductContext _baseDatos;

        public ProductoController(BdProductContext baseDatos)
        {
            _baseDatos = baseDatos;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> Lista()
        {
            var listaProductos = await _baseDatos.Productos.ToListAsync();
            return Ok(listaProductos);
        }


    }
}
