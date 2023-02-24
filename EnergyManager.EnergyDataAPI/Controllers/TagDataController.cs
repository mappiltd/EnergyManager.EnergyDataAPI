using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.TagData;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/TagData")]
    [ApiController]
    public class TagDataController : Controller
    {
        private readonly IEnergyDataRepo _energyDataRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<TagDataRequest> _tagDataValidator;

        public TagDataController(IEnergyDataRepo energyDataRepo, 
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<TagDataRequest> tagDataValidator)
        {
            _energyDataRepo = energyDataRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _tagDataValidator = tagDataValidator;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
        }
    }
}
