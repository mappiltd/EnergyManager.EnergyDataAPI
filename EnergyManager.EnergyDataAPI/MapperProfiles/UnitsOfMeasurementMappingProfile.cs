using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.UnitsOfMeasurement;
using EnergyManager.EnergyDataAPI.DTOs.Responses.UnitsOfMeasurement;
using EnergyManager.EnergyDataAPI.Models.Devices;

namespace EnergyManager.EnergyDataAPI.MapperProfiles
{
    public class UnitsOfMeasurementMappingProfile : Profile
    {
        public UnitsOfMeasurementMappingProfile()
        {
            CreateMap<UnitsOfMeasurementModel, UnitsOfMeasurementResponse>();
            CreateMap<UnitsOfMeasurementRequest, UnitsOfMeasurementModel>();
        }
    }
}
