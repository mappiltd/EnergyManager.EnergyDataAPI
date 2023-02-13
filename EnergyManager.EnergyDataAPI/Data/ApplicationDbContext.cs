using EnergyManager.EnergyDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DeviceDataModel> DeviceData { get; set; }
        public DbSet<EnergyDataModel> EnergyData { get; set; }
    }
}
