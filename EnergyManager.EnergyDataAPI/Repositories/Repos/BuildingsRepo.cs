using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class BuildingsRepo : Repository<BuildingsModel>, IBuildingsRepo
    {
        public BuildingsRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
        }
    }
}
