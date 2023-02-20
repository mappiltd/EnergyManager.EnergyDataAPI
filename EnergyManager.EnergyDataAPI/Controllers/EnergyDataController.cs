using AutoMapper;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{     
    /// <summary>
    /// DDDDDDDDDDDDDDDDDDDDD
    /// </summary>
    [Route("api/EnergyData")]
    [ApiController]
    public class EnergyDataController : Controller
    {
        private readonly IEnergyDataRepo _energyDataRepo;
        private readonly IMapper _mapper;

        public EnergyDataController(IEnergyDataRepo energyDataRepo, IMapper mapper)
        {
            _energyDataRepo = energyDataRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
        }
    }
}
