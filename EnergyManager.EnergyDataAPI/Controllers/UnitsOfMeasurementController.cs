using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    public class UnitsOfMeasurementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
