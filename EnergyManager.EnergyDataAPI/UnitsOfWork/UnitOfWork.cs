using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.Repositories.Repos;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.UnitsOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContextFactory<ApplicationDbContext> _applicationContext;

        public UnitOfWork(IDbContextFactory<ApplicationDbContext> applicationContext)
        {
            _applicationContext = applicationContext;

            DeviceInformation = new DeviceInformationRepo(_applicationContext);
            EnergyData = new EnergyDataRepo(_applicationContext);
            TagData = new TagDataRepo(_applicationContext); 
            UnitsOfMeasurement = new UnitsOfMeasurementRepo(_applicationContext);
            Buildings = new BuildingsRepo(_applicationContext);
            Locations = new LocationsRepo(_applicationContext);
        } 
        
        public IDeviceInformationRepo DeviceInformation { get; private set; }
        public ITagDataRepo TagData { get; private set; }
        public IEnergyDataRepo EnergyData { get; private set; }
        public IUnitsOfMeasurementRepo UnitsOfMeasurement { get; private set; }
        public IBuildingsRepo Buildings { get; private set; }
        public ILocationsRepo Locations { get; private set; } 

        public async Task<int> Complete()
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            return await context.SaveChangesAsync();
        }
    }
}
