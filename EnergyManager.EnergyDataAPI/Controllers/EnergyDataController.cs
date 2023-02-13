using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    public class EnergyDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
