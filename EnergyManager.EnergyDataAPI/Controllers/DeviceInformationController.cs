using AutoMapper;
using EnergyManager.EnergyDataAPI.DTOs.Read.DeviceInformation;
using EnergyManager.EnergyDataAPI.DTOs.Write.DeviceInformation;
using EnergyManager.EnergyDataAPI.Models.Devices;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using EnergyManager.EnergyDataAPI.UnitsOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/DeviceInformation")]
    [ApiController]
    public class DeviceInformationController : ControllerBase
    {
        private readonly IDeviceInformationRepo _deviceInformationRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;         

        public DeviceInformationController(IDeviceInformationRepo deviceInformationRepo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _deviceInformationRepo = deviceInformationRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        private async Task<DeviceInformationResponse> GetDevice(Guid deviceId)
        {
            DeviceInformationModel device = await _deviceInformationRepo.GetDeviceAsync(deviceId);
            DeviceInformationResponse mappedDevice = _mapper.Map<DeviceInformationResponse>(device);

            return mappedDevice;
        }

        private async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevices(IEnumerable<Guid> deviceIds)
        {
            IEnumerable<DeviceInformationModel> devices = await _deviceInformationRepo.GetDevicesAsync(deviceIds);
            IEnumerable<DeviceInformationResponse> mappedDevices = _mapper.Map<IEnumerable<DeviceInformationResponse>>(devices);

            return Ok(mappedDevices);
        }

        [HttpGet, Route("GetDeviceName")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesList(IEnumerable<Guid> deviceIds)
        {
            var devices = await GetDevices(deviceIds);

            return Ok(devices);
        }

        [HttpGet, Route("GetDevicesByCustomerId")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesByCustomerId(Guid customerId)
        {
            // var devices = await GetDevices(deviceIds);

            return Ok();
        }

        [HttpGet, Route("GetDevicesByLocationId")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesByLocationId(IEnumerable<Guid> locationIds)
        {
            // var devices = await GetDevices(deviceIds);

            return Ok();
        } 

        [HttpGet, Route("GetDevicesByBuildingId")]
        public async Task<ActionResult<IEnumerable<DeviceInformationResponse>>> GetDevicesByBuildingId(IEnumerable<Guid> buildingIds)
        {
           // var devices = await GetDevices(deviceIds);

            return Ok();
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
