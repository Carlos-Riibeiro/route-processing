using Microsoft.AspNetCore.Mvc;
using RoteProcessing.API.Services.Interfaces;
using RoteProcessing.API.ViewModels.Services;
using System.Threading.Tasks;

namespace RoteProcessing.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/route")]
    public class RouteController : ControllerBase
    {
        private readonly IRouteService _routeService;

        public RouteController(IRouteService routeService)
        {
            _routeService = routeService;
        }

        [HttpGet("origin/{origin}/destination/{destination}")]
        public async Task<ActionResult<DirectionsViewModel>> Get(string origin, string destination)
        {
            if (string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination))
            {
                return NotFound();
            }

            return await _routeService.GetAsync(origin, destination);
        }
    }
}
