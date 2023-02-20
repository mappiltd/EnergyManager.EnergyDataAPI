using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class DeviceInformationRepo : Repository<DeviceInformationModel>, IDeviceInformationRepo
    {
        public DeviceInformationRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {

        } 
    }

    public interface IDeviceInformationRepo 
    {

    }    
}
