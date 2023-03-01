using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.Customers;
using EnergyManager.EnergyDataAPI.Models.Customers;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/Buildings")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingsRepo _buildingsDataRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<BuildingsRequest> _buildingDataValidator;

        public BuildingController(IBuildingsRepo buildingsDataRepo,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<BuildingsRequest> buildingDataValidator)
        {
            _buildingsDataRepo = buildingsDataRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _buildingDataValidator = buildingDataValidator;
        }

        public async Task<ActionResult<BuildingModel>> GetBuildingByBuildingIdAsync(Guid buildingId)
        {
            return Ok();
        }
    }
}
