using Newtonsoft.Json;

namespace RoteProcessing.API.ViewModels.Services
{
    public partial class DirectionsViewModel
    {
        [JsonProperty("geocoded_waypoints")]
        public GeocodedWaypointViewModel[] GeocodedWaypoints { get; set; }

        [JsonProperty("routes")]
        public RouteViewModel[] Routes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class GeocodedWaypointViewModel
    {
        [JsonProperty("geocoder_status")]
        public string GeocoderStatus { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }
    }

    public partial class RouteViewModel
    {
        [JsonProperty("bounds")]
        public BoundsViewModel Bounds { get; set; }

        [JsonProperty("copyrights")]
        public string Copyrights { get; set; }

        [JsonProperty("legs")]
        public LegViewModel[] Legs { get; set; }

        [JsonProperty("overview_polyline")]
        public PolylineViewModel OverviewPolyline { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("warnings")]
        public object[] Warnings { get; set; }

        [JsonProperty("waypoint_order")]
        public object[] WaypointOrder { get; set; }
    }

    public partial class BoundsViewModel
    {
        [JsonProperty("northeast")]
        public NortheastViewModel Northeast { get; set; }

        [JsonProperty("southwest")]
        public NortheastViewModel Southwest { get; set; }
    }

    public partial class NortheastViewModel
    {
        [JsonProperty("lat")]
        public decimal Lat { get; set; }

        [JsonProperty("lng")]
        public decimal Lng { get; set; }
    }

    public partial class LegViewModel
    {
        [JsonProperty("distance")]
        public DistanceViewModel Distance { get; set; }

        [JsonProperty("duration")]
        public DistanceViewModel Duration { get; set; }

        [JsonProperty("end_address")]
        public string EndAddress { get; set; }

        [JsonProperty("end_location")]
        public NortheastViewModel EndLocation { get; set; }

        [JsonProperty("start_address")]
        public string StartAddress { get; set; }

        [JsonProperty("start_location")]
        public NortheastViewModel StartLocation { get; set; }

        [JsonProperty("steps")]
        public StepViewModel[] Steps { get; set; }

        [JsonProperty("traffic_speed_entry")]
        public object[] TrafficSpeedEntry { get; set; }

        [JsonProperty("via_waypoint")]
        public object[] ViaWaypoint { get; set; }
    }

    public partial class DistanceViewModel
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public partial class StepViewModel
    {
        [JsonProperty("distance")]
        public DistanceViewModel Distance { get; set; }

        [JsonProperty("duration")]
        public DistanceViewModel Duration { get; set; }

        [JsonProperty("end_location")]
        public NortheastViewModel EndLocation { get; set; }

        [JsonProperty("html_instructions")]
        public string HtmlInstructions { get; set; }

        [JsonProperty("polyline")]
        public PolylineViewModel Polyline { get; set; }

        [JsonProperty("start_location")]
        public NortheastViewModel StartLocation { get; set; }

        [JsonProperty("travel_mode")]
        public TravelMode TravelMode { get; set; }

        [JsonProperty("maneuver", NullValueHandling = NullValueHandling.Ignore)]
        public string Maneuver { get; set; }
    }

    public partial class PolylineViewModel
    {
        [JsonProperty("points")]
        public string Points { get; set; }
    }

    public enum TravelMode { Driving };
}
