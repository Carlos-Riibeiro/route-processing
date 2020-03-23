using AutoMapper;
using RoteProcessing.API.Services.Interfaces;
using RoteProcessing.API.ViewModels.Services;
using RoteProcessing.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace RoteProcessing.API.Services
{
    public class RouteService : IRouteService
    {
        private readonly IDirectionService _directionService;
        private readonly IMapper _mapper;

        public RouteService(IDirectionService directionService, IMapper mapper)
        {
            _directionService = directionService;
            _mapper = mapper;
        }

        public async Task<DirectionsViewModel> GetAsync(string origin, string destination)
        {
            var directionModel = await _directionService.GetAsync(origin, destination);

            return _mapper.Map<DirectionsViewModel>(directionModel);
        }
    }
}
