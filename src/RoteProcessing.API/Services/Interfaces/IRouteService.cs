using RoteProcessing.API.ViewModels.Services;
using System.Threading.Tasks;

namespace RoteProcessing.API.Services.Interfaces
{
    public interface IRouteService
    {
        Task<DirectionsViewModel> GetAsync(string origin, string destination);
    }
}
