using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    public class MeterInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
