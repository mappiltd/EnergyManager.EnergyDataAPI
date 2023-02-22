using AutoMapper;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/TagData")]
    [ApiController]
    public class TagDataController : Controller
    {
        private readonly IEnergyDataRepo _energyDataRepo;
        private readonly IMapper _mapper;

        public TagDataController(IEnergyDataRepo energyDataRepo, IMapper mapper)
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
