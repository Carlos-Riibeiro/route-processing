using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RoteProcessing.Domain.Interfaces.Services;
using RoteProcessing.Domain.Models.ResponseServices;
using RoteProcessing.Domain.Models.Services;
using System.Net.Http;
using System.Threading.Tasks;
using Wiz.RoteProcessing.Domain.Interfaces.Notifications;

namespace RoteProcessing.Infra.Services
{
    public class DirectionService : IDirectionService
    {
        private readonly HttpClient _httpClient;
        private readonly IDomainNotification _domainNotification;

        public DirectionService(HttpClient httpClient, IDomainNotification domainNotification, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _domainNotification = domainNotification;
        }

        public async Task<Directions> GetAsync(string origin, string destination)
        {
            var response = await _httpClient.GetAsync($"json?origin={origin}&destination={destination}&key=AIzaSyAyq8C_C4xcgdHkxo-0KdovF5X0yVnKtz4");
            var stringResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Directions>(stringResponse);
            }
            else
            {
                _domainNotification.AddNotification(JsonConvert.DeserializeObject<ResponseService>(stringResponse));
                return null;
            }
        }
    }
}
