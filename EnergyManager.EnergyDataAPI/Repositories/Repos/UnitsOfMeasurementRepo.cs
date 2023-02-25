using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Models.Tags;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class UnitsOfMeasurementRepo : Repository<UnitsOfMeasurementModel>, IUnitsOfMeasurementRepo
    {
        public UnitsOfMeasurementRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
        }    
    }
}
