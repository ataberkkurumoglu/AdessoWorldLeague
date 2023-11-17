using AdessoWorldLeague.Entities;
using Business.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoWorldLeagueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawResultController : ControllerBase
    {
        private readonly IDrawResultService _drawResultService;

        public DrawResultController(IDrawResultService drawResultService)
        {
            _drawResultService = drawResultService ?? throw new ArgumentNullException(nameof(drawResultService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDrawResults(int id, string drawerName)
        {
            var drawResults = await _drawResultService.Draw(id,drawerName);
            return Ok(drawResults);
        }

        // Diğer CRUD metotları buraya eklenir
    }
}
