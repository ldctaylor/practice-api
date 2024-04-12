using Microsoft.AspNetCore.Mvc;
using practice_api.Data;
using practice_api.Mappers;
using practice_api.Dtos.Stock;

namespace practice_api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext applicationDBContext)
        {
            _context = applicationDBContext;
        }

        [HttpGet] 
        public IActionResult GetAll()
        {
            var stocks = _context.Stock.ToList()
            .Select(s => s.ToStockDto());
            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stock.Find(id);

            if(stock == null)
                {
                    return NotFound();
                }
            return Ok(stock.ToStockDto());
            
        }
    }
}
