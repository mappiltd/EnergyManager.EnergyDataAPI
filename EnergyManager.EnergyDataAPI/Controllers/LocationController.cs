using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.Customers;
using EnergyManager.EnergyDataAPI.Models.Customers;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/Locations")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationsRepo _locationsDataRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<LocationsRequest> _locationDataValidator;

        public LocationController(ILocationsRepo locationsDataRepo,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<LocationsRequest> locationDataValidator)
        {
            _locationsDataRepo = locationsDataRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _locationDataValidator = locationDataValidator;
        }
        
        public async Task<ActionResult<LocationModel>> GetLocationByLocationIdAsync(Guid locationId)
        {
            return View();
        }
    }
}
