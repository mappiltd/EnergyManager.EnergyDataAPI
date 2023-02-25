using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
