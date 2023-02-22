namespace EnergyManager.EnergyDataAPI.UnitsOfWork
{
    public interface IUnitOfWork
    {
        Task<int> Complete();
    }
}
