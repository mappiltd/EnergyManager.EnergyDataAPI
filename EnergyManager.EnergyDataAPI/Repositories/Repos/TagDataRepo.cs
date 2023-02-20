using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.Models;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Repositories.Repos
{
    public class TagDataRepo : Repository<TagDataModel>, ITagDataRepo
    {
        public TagDataRepo(IDbContextFactory<ApplicationDbContext> applicationContext) : base(applicationContext)
        {
        }
    }
}
