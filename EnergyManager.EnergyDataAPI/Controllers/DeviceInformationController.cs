using AutoMapper;
using EnergyManager.EnergyDataAPI.Data;
using EnergyManager.EnergyDataAPI.DTOs.Read.DeviceInformation;
using EnergyManager.EnergyDataAPI.Models;
using EnergyManager.EnergyDataAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/DeviceInformation")]
    [ApiController]
    public class DeviceInformationController : ControllerBase
    {
        private readonly IDeviceInformationRepo _deviceInformationRepo;
        private readonly IMapper _mapper;

        public DeviceInformationController(IDeviceInformationRepo deviceInformationRepo, IMapper mapper)
        {
            _deviceInformationRepo = deviceInformationRepo;
            _mapper = mapper;
        }


        /// <summary>
        /// Gets the complete row for a given device.
        /// </summary>
        /// <param name="deviceId">Guid</param>
        /// <returns>DeviceInformationReadDto</returns>
        [HttpGet, Route("GetDeviceData")]
        public async Task<ActionResult<DeviceDataEnabledReadDto>> GetDeviceData(Guid deviceId)
        {
            DeviceInformationModel result = await _deviceInformationRepo.GetDeviceByIdAsync(deviceId);

            return Ok(result);
        }

        [HttpGet, Route("GetDeviceName")]
        public ActionResult<string> GetDeviceName(Guid deviceId)
        {
            return Ok();
        }

        [HttpGet, Route("GetDeviceLocation")]
        public ActionResult<string> GetDeviceLocation(Guid deviceId)
        {
            return Ok();
        }

        [HttpGet, Route("GetDeviceType")]
        public ActionResult<string> GetDeviceType(Guid deviceId)
        {
            return Ok();
        }

        [HttpGet, Route("GetAllDevices")]
        public ActionResult<IEnumerable<DeviceDataEnabledReadDto>> GetAllDevices(Guid customerId)
        {
            return Ok();
        }

        [HttpPost, Route("CreateDevice")]
        public ActionResult<IEnumerable<DeviceDataEnabledReadDto>> CreateDevice(Guid customerId)
        {
            return Ok();
        }

        [HttpPost, Route("DeleteDevice")]
        public ActionResult<IEnumerable<DeviceDataEnabledReadDto>> DeleteDevice(Guid deviceId)
        {
            return Ok();
        }

        [HttpPost, Route("DisableDevice")]
        public ActionResult<IEnumerable<DeviceDataEnabledReadDto>> DisableDevice(Guid deviceId)
        {
            return Ok();
        }
    }
}
