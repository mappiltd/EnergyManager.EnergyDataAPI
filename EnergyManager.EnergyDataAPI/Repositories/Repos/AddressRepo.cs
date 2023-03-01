using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models.Customers;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class AddressRepo : Repository<AddressModel>, IAddressRepo
    {
        public AddressRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
        }
    }
}
