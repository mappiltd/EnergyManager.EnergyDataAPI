using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.UnitsOfMeasurement;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/UnitsOfMeasurement")]
    [ApiController]
    public class UnitsOfMeasurementController : ControllerBase
    {
        private readonly IUnitsOfMeasurementRepo _unitsOfMeasurementRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IValidator<UnitsOfMeasurementRequest> _deviceInformationValidator;          

        public UnitsOfMeasurementController(IUnitsOfMeasurementRepo unitsOfMeasurementRepo,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<UnitsOfMeasurementRequest> deviceInformationValidator)
        {
            _unitsOfMeasurementRepo = unitsOfMeasurementRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _deviceInformationValidator = deviceInformationValidator;
        }


        public ActionResult Index()
        {
            return Ok();
        }
    }
}
