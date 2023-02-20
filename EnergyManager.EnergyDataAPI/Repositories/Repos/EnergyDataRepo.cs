using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class EnergyDataRepo : Repository<EnergyDataModel>, IEnergyDataRepo 
    {
        public EnergyDataRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {

        }
    }

    public interface IEnergyDataRepo
    {

    }
}
