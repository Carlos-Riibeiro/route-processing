using AutoMapper;
using RoteProcessing.API.ViewModels.Services;
using RoteProcessing.Domain.Models.Services;
using System.Diagnostics.CodeAnalysis;

namespace Wiz.RoteProcessing.API.AutoMapper
{
    [ExcludeFromCodeCoverage]
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Directions, DirectionsViewModel>();
            CreateMap<GeocodedWaypoint, GeocodedWaypointViewModel>();
            CreateMap<Route, RouteViewModel>();
            CreateMap<Bounds, BoundsViewModel>();
            CreateMap<Northeast, NortheastViewModel>();
            CreateMap<Leg, LegViewModel>();
            CreateMap<Distance, DistanceViewModel>();
            CreateMap<Step, StepViewModel>();
            CreateMap<Polyline, PolylineViewModel>();
        }
    }
}
