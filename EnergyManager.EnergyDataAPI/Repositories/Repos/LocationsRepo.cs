using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models.DeviceData;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class LocationsRepo : Repository<LocationsModel>, ILocationsRepo
    {
        public LocationsRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
        }
    }
}
