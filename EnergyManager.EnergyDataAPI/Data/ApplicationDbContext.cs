using EnergyManager.EnergyDataAPI.Models.Customers;
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

        public DbSet<DeviceInformationModel> DeviceInformation { get; set; }
        public DbSet<EnergyDataModel> EnergyData { get; set; }
        public DbSet<TagDataModel> TagData { get; set; }
        public DbSet<UnitsOfMeasurementModel> UnitsOfMeasurement { get; set; }
        public DbSet<BuildingModel> Buildings { get; set; }
        public DbSet<LocationModel> Locations { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
    }
}
