using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using System.Collections.Generic;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class DeviceInformationRepo : Repository<DeviceInformationModel>, IDeviceInformationRepo
    {
        private readonly IDbContextFactory<ApplicationDbContext> _applicationContext;

        public DeviceInformationRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<int> CreateDevice(DeviceInformationModel device)
        {
            int result = await AddAsync(device);           

            return result;              
        }

        public async Task<int> CreateDevices(IEnumerable<DeviceInformationModel> devices)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteDeviceAsync(Guid deviceId)
        {
            throw new NotImplementedException();
        }

        public async Task<DeviceInformationModel> GetDeviceAsync(Guid deviceId)
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();

            DeviceInformationModel devices = await (from device in context.DeviceInformation 
                                                     join location in context.Locations on device.LocationId equals location.LocationId
                                                     join building in context.Buildings on device.BuildingId equals building.BuildingId
                                                     join uom in context.UnitsOfMeasurement on device.UnitsOfMeasurementId equals uom.UnitsOfMeasurementId
                                                     where device.DeviceDataId == deviceId
                                                     select new DeviceInformationModel
                                                     {
                                                         DeviceDataId = device.DeviceDataId,
                                                         DeviceName = device.DeviceName,
                                                         DeviceDescription = device.DeviceDescription,
                                                         CustomerId = device.CustomerId,
                                                         BuildingId = device.BuildingId,
                                                         LocationId = device.LocationId,
                                                         UnitsOfMeasurementId = device.UnitsOfMeasurementId,
                                                         DeviceEnabled = device.DeviceEnabled,
                                                         DeviceDateCreated = device.DeviceDateCreated
                                                     })
                                                     .FirstOrDefaultAsync() ?? new DeviceInformationModel();

            return devices;
        }       

        public async Task<IEnumerable<DeviceInformationModel>> GetDevicesListByCustomerIdAsync(Guid customerId)
        {
            IEnumerable<DeviceInformationModel> devices = await FindAsync(x => x.CustomerId == customerId);

            return devices;
        }

        public async Task<IEnumerable<DeviceInformationModel>> GetDevicesListByBuildingIdAsync(Guid buildingId)
        {
            IEnumerable<DeviceInformationModel> devices = await FindAsync(x => x.BuildingId == buildingId);

            return devices;
        }      

        public async Task<IEnumerable<DeviceInformationModel>> GetDevicesListByLocationIdAsync(Guid locationId)
        {
            IEnumerable<DeviceInformationModel> devices = await FindAsync(x => x.LocationId == locationId);

            return devices;
        }
    }    
}
