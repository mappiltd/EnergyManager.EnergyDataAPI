using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation;
using EnergyManager.EnergyDataAPI.DTOs.Responses.DeviceInformation;
using EnergyManager.EnergyDataAPI.Models.Devices;

namespace EnergyManager.EnergyDataAPI.MapperProfiles
{
    public class DeviceInformationMappingProfile : Profile
    {
        public DeviceInformationMappingProfile()
        {
            CreateMap<DeviceInformationModel, DeviceInformationRequest>();
            CreateMap<DeviceInformationResponse, DeviceInformationModel>();            
        }
    }
}
