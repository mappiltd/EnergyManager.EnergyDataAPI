using EnergyManager.EnergyDataAPI.Data;
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
            EnergyDataRepo = new EnergyDataRepo(_applicationContext);
            TagDataRepo = new TagDataRepo(_applicationContext); 
        } 
        
        public IDeviceInformationRepo DeviceInformation { get; private set; }
        public ITagDataRepo TagDataRepo { get; private set; }
        public IEnergyDataRepo EnergyDataRepo { get; private set; } 

        public async Task<int> Complete()
        {
            using ApplicationDbContext context = _applicationContext.CreateDbContext();
            return await context.SaveChangesAsync();
        }
    }
}
