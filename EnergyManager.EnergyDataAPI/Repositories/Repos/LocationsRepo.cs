using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models.Customers;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class LocationsRepo : Repository<LocationModel>, ILocationsRepo
    {
        public LocationsRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
        }
    }
}
