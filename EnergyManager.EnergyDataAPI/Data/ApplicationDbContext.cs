using EnergyManager.EnergyDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DeviceInformationModel> DeviceData { get; set; }
        public DbSet<EnergyDataModel> EnergyData { get; set; }
        public DbSet<TagDataModel> TagData { get; set; }
        public DbSet<UnitsOfMeasurementModel> UnitsOfMeasurement { get; set; }
    }
}
