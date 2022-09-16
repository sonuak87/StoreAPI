using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using Store.Data;
using Store.Entity;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContaxt _context;
        public ProductController(DataContaxt coontext)
        {
            _context = coontext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            try
            {
                return await _context.Products.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet("id")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            try
            {
                return await _context.Products.FindAsync(id);

            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost]
        public async Task<ActionResult> AddProduct(Product obj)
        {
            try
            {
                _context.Products.Add(obj);
                await _context.SaveChangesAsync();
                return Ok(true);
            }
            catch (Exception)
            {

                return BadRequest(false);
            }

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var data = await _context.Products.FindAsync(id);
                if (data != null)
                    _context.Products.Remove(data);
                await _context.SaveChangesAsync();

                return Ok(true);
            }
            catch (Exception)
            {

                return BadRequest(false);
            }

        }
    }
}
