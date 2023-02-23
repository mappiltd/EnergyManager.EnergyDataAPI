using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Read.DeviceInformation;
using EnergyManager.EnergyDataAPI.DTOs.Write.DeviceInformation;
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
