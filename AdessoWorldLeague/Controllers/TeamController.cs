using Business.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoWorldLeagueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService ?? throw new ArgumentNullException(nameof(teamService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeams()
        {
            var teams = await _teamService.GetAllAsync();
            return Ok(teams);
        }

        // Diğer CRUD metotları buraya eklenir
    }

}
