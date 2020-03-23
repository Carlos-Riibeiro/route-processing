using RoteProcessing.Domain.Models.Services;
using System.Threading.Tasks;

namespace RoteProcessing.Domain.Interfaces.Services
{
    public interface IDirectionService
    {
        Task<Directions> GetAsync(string origin, string destination);
    }
}
