using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class DeviceInformationRepo : Repository<DeviceInformationModel>, IDeviceInformationRepo
    {
        public DeviceInformationRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
        }

        public async Task<DeviceInformationModel> GetDeviceByIdAsync(Guid deviceId)
        {               
           return await GetAsync(deviceId);
        }
    }    
}
