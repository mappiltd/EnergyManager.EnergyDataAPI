using EnergyManager.EnergyDataAPI.Models.Devices;

namespace EnergyManager.EnergyDataAPI.Repositories.Interfaces
{
    public interface IDeviceInformationRepo
    {
        Task<DeviceInformationModel> GetDeviceAsync(Guid deviceId);        
        Task<IEnumerable<DeviceInformationModel>> GetDevicesListByCustomerIdAsync(Guid customerId);
        Task<IEnumerable<DeviceInformationModel>> GetDevicesListByLocationIdAsync(Guid locationId);
        Task<IEnumerable<DeviceInformationModel>> GetDevicesListByBuildingIdAsync(Guid buildingId);

        Task<int> DeleteDeviceAsync(Guid deviceId);
        Task<int> CreateDevice(DeviceInformationModel device);
        Task<int> CreateDevices(IEnumerable<DeviceInformationModel> devices);
    }
}
