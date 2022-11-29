using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorldCupTeamsGraphQL.DTOS;
using WorldCupTeamsGraphQL.Services;

namespace WorldCupTeamsGraphQL.Controllers
{
    [ApiController]
    [Route("api/v1/teams")]
    public class TeamsController : Controller
    {
        private readonly ILogger<TeamsController> logger;
        private readonly IWorldCupService worldCupService;

        public TeamsController(ILogger<TeamsController> logger, IWorldCupService worldCupService)
        {
            this.logger = logger;
            this.worldCupService = worldCupService;
        }


        [HttpGet]
        [Route("{name}")]
        public ActionResult<TeamDTO[]> FindTeamsBy(string name)
        {
            var result = worldCupService.FindTeamBy(name);
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet]
        [Route("team/{key}")]
        public ActionResult<TeamDTO> FindTeamBy(int key)
        {
            var result = worldCupService.FindTeamBy(key);
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpGet]
        public ActionResult<TeamDTO[]> FindAll()
        {
            var result = worldCupService.FindAll();
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
