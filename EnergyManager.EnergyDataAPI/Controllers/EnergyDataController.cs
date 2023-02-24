using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Responses.EnergyData;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{  
    [Route("api/EnergyData")]
    [ApiController]
    public class EnergyDataController : Controller
    {
        private readonly IEnergyDataRepo _energyDataRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<EnergyDataResponse> _energyDataValidator;

        public EnergyDataController(IEnergyDataRepo energyDataRepo,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<EnergyDataResponse> energyDataValidator)
        {
            _energyDataRepo = energyDataRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _energyDataValidator = energyDataValidator;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
        }
    }
}
