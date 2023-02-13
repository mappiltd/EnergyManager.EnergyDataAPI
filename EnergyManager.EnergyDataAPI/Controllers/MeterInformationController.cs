using EnergyManager.EnergyDataAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/MeterInformation")]
    [ApiController]
    public class MeterInformationController : ControllerBase
    {
        [HttpGet("id", Name = "GetDeviceData")]
        public ActionResult<DeviceDataReadDto> GetDeviceData(Guid deviceId)
        {
            return Ok();
        }

        [HttpGet("id", Name = "GetDeviceName")]
        public ActionResult<string> GetDeviceName(Guid deviceId)
        {
            return Ok();
        }

        [HttpGet("id", Name = "GetDeviceLocation")]
        public ActionResult<string> GetDeviceLocation(Guid deviceId)
        {
            return Ok();
        }

        [HttpGet("id", Name = "GetDeviceType")]
        public ActionResult<string> GetDeviceType(Guid deviceId)
        {
            return Ok();
        }

        [HttpGet("id", Name = "GetAllDevices")]
        public ActionResult<IEnumerable<DeviceDataReadDto>> GetAllDevices(Guid customerId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<IEnumerable<DeviceDataReadDto>> CreateDevice(Guid customerId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<IEnumerable<DeviceDataReadDto>> DeleteDevice(Guid deviceId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<IEnumerable<DeviceDataReadDto>> DisableDevice(Guid deviceId)
        {
            return Ok();
        }
    }
}
