using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.EnergyData;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/EnergyData")]
    [ApiController]
    public class EnergyDataController : ControllerBase
    {
        private readonly IEnergyDataRepo _energyDataRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<EnergyDataRequest> _energyDataValidator;

        public EnergyDataController(IEnergyDataRepo energyDataRepo,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<EnergyDataRequest> energyDataValidator)
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
