using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    public class UnitsOfMeasurementController : Controller
    {
        private readonly IDeviceInformationRepo _deviceInformationRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<DeviceInformationRequest> _deviceInformationValidator;
        private readonly IMapper _mapper;

        public UnitsOfMeasurementController(IDeviceInformationRepo deviceInformationRepo,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<DeviceInformationRequest> deviceInformationValidator)
        {
            _deviceInformationRepo = deviceInformationRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _deviceInformationValidator = deviceInformationValidator;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
