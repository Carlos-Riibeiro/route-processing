using Newtonsoft.Json;

namespace RoteProcessing.Domain.Models.ResponseServices
{
    public class ResponseService
    {
        public ResponseService(string errorMessage, object[] routes, string status)
        {
            ErrorMessage = errorMessage;
            Routes = routes;
            Status = status;
        }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
        public object[] Routes { get; set; }
        public string Status { get; set; }
    }
}



