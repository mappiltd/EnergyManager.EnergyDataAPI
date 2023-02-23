﻿using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.DTOs.Write.DeviceInformation;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class DeviceInformationRepo : Repository<DeviceInformationModel>, IDeviceInformationRepo
    {           

        public DeviceInformationRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {           
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
            DeviceInformationModel device = await GetAsync(deviceId);

            return device;
        }

        public async Task<IEnumerable<DeviceInformationModel>> GetDevicesAsync(IEnumerable<Guid> deviceIds)
        {
            IEnumerable<DeviceInformationModel> devices = await FindAsync(x => deviceIds.Contains(x.DeviceDataId));

            return devices;
        }         
    }    
}
