using EnergyManager.EnergyDataAPI.Models;

namespace EnergyManager.EnergyDataAPI.Repositories.Interfaces
{
    public interface IDeviceInformationRepo
    {
        Task<DeviceInformationModel> GetDeviceByIdAsync(Guid deviceId);        
    }
}
