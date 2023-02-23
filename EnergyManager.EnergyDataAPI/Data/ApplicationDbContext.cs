using EnergyManager.EnergyDataAPI.Models.DeviceData;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Models.Tags;
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
