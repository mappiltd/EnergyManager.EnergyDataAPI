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
    public class TagDataController : ControllerBase
    {
        private readonly ITagDataRepo _tagDataRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<TagDataRequest> _tagDataValidator;

        public TagDataController(ITagDataRepo tagDataRepo, 
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IValidator<TagDataRequest> tagDataValidator)
        {
            _tagDataRepo = tagDataRepo;
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
