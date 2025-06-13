using BTON2.Data;
using Microsoft.AspNetCore.Mvc;
using BTON2.Models;

namespace BTON2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViewStatsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ViewStatsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("service")]
        public IActionResult GetServiceStats()
        {
            var result = _context.ViewServiceAssignStats.ToList();
            return Ok(result);
        }

        [HttpGet("used")]
        public IActionResult GetUsedStats()
        {
            var result = _context.ViewAssignUsedStats.FirstOrDefault();
            return Ok(result);
        }

        [HttpGet("device")]
        public IActionResult GetDeviceStats()
        {
            var result = _context.ViewDeviceAssignStats.ToList();
            return Ok(result);
        }
    }
}
