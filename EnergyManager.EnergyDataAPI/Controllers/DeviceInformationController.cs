using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation;
using EnergyManager.EnergyDataAPI.DTOs.Responses.DeviceInformation;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/DeviceInformation")]
    [ApiController]
    public class DeviceInformationController : ControllerBase
    {
        private readonly IDeviceInformationRepo _deviceInformationRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<DeviceInformationRequest> _deviceInformationValidator;
        private readonly IMapper _mapper;         

        public DeviceInformationController(IDeviceInformationRepo deviceInformationRepo, 
            IMapper mapper, 
            IUnitOfWork unitOfWork,
            IValidator<DeviceInformationRequest> deviceInformationValidator)
        {
            _deviceInformationRepo = deviceInformationRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _deviceInformationValidator = deviceInformationValidator;
        }

        private async Task<DeviceInformationResponse> GetDevice(Guid deviceId)
        {
            DeviceInformationModel device = await _deviceInformationRepo.GetDeviceAsync(deviceId);
            DeviceInformationResponse mappedDevice = _mapper.Map<DeviceInformationResponse>(device);

            return mappedDevice;
        }

        /// <summary>
        /// Get's all devices for a given customer.
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>IEnumerable<DeviceInformationResponse>></returns>
        [HttpGet, Route("GetDevices")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesList(Guid customerId)
        {
          

            IEnumerable<DeviceInformationModel> devices = await _deviceInformationRepo.GetDevicesAsync(deviceIds);           

            if (devices.Count() < 1) 
            {
                return NotFound("No devices were found with those Id's");              
            } 

            return Ok(_mapper.Map<IEnumerable<DeviceInformationResponse>>(devices));
        }

        [HttpGet, Route("GetDevicesByCustomerId")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesByCustomerId(Guid customerId)
        {
            if(customerId == Guid.Empty)
            {
                return BadRequest("The id provided has no value.");
            }

            IEnumerable<DeviceInformationModel> devices = await _deviceInformationRepo.GetDevicesListByCustomerIdAsync(customerId);
            if (devices.Count() < 1)
            {
                return NotFound("No devices were found for that customer.");
            }

            return Ok(_mapper.Map<DeviceInformationResponse>(devices));
        }

        [HttpGet, Route("GetDevicesByLocationId")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesByLocationId(Guid locationId)
        {
            if (locationId == Guid.Empty)
            {
                return BadRequest("The id provided has no value.");
            }

            IEnumerable<DeviceInformationModel> devices = await _deviceInformationRepo.GetDevicesListByLocationIdAsync(locationId);
            
            if (devices.Count() < 1)
            {
                return NotFound("No devices were found for that location.");
            }
            
            return Ok(_mapper.Map<DeviceInformationResponse>(devices));
        } 

        [HttpGet, Route("GetDevicesByBuildingId")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesByBuildingId(Guid buildingId)
        {
            if (buildingId == Guid.Empty)
            {
                return BadRequest("The id provided has no value.");
            }

            IEnumerable<DeviceInformationModel> devices = await _deviceInformationRepo.GetDevicesListByCustomerIdAsync(buildingId);
            if (devices.Count() < 1)
            {
                return NotFound("No devices were found for that building.");
            }

            return Ok(devices);
        }

        [HttpGet, Route("GetDeviceLocation")]
        public async Task<ActionResult<Guid>> GetDeviceLocation(Guid deviceId)
        {
            DeviceInformationResponse device = await GetDevice(deviceId);            

            return Ok();
        } 

        [HttpPost, Route("CreateDevice")]
        public async Task<ActionResult<DeviceInformationResponse>> CreateDevice(DeviceInformationRequest device)
        {
            DeviceInformationModel mappedDevice = _mapper.Map<DeviceInformationModel>(device);

            int result = await _deviceInformationRepo.CreateDevice(mappedDevice);
            await _unitOfWork.Complete();

            if(result > 0)
            {
                DeviceInformationResponse response = _mapper.Map<DeviceInformationResponse>(mappedDevice);

                return CreatedAtRoute(nameof(GetDevice), new { deviceId = response.DeviceDataId }, response);
            }
            else
            {
              return BadRequest("The device object could not be saved.");
            }
        }

        [HttpPost, Route("DeleteDevice")]
        public ActionResult<IEnumerable<DeviceInformationResponse>> DeleteDevice(Guid deviceId)
        {



            return Ok();
        }

        [HttpPost, Route("DisableDevice")]
        public ActionResult<IEnumerable<DeviceInformationResponse>> DisableDevice(Guid deviceId)
        {
            return Ok();
        }
    }
}
