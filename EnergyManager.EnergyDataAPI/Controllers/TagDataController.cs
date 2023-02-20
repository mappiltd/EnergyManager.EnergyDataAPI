using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    public class TagDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
