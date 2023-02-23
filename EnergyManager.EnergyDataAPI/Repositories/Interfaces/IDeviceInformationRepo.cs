using EnergyManager.EnergyDataAPI.Models.Devices;

namespace EnergyManager.EnergyDataAPI.Repositories.Interfaces
{
    public interface IDeviceInformationRepo
    {
        Task<DeviceInformationModel> GetDeviceAsync(Guid deviceId);  
        Task<IEnumerable<DeviceInformationModel>> GetDevicesAsync(IEnumerable<Guid> deviceId);
        Task<int> DeleteDeviceAsync(Guid deviceId);
        Task<int> CreateDevice(DeviceInformationModel device);
        Task<int> CreateDevices(IEnumerable<DeviceInformationModel> devices);
    }
}
