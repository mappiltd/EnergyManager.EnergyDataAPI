using EnergyManager.EnergyDataAPI.DTOs.Read.DeviceInformation;
using Microsoft.AspNetCore.Mvc;

namespace EnergyManager.EnergyDataAPI.Controllers
{
    [Route("api/MeterInformation")]
    [ApiController]
    public class DeviceInformationController : ControllerBase
    {
        [HttpGet("id", Name = "GetDeviceData")]
        public ActionResult<DeviceInformationReadDto> GetDeviceData(Guid deviceId)
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
        public ActionResult<IEnumerable<DeviceInformationReadDto>> GetAllDevices(Guid customerId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<IEnumerable<DeviceInformationReadDto>> CreateDevice(Guid customerId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<IEnumerable<DeviceInformationReadDto>> DeleteDevice(Guid deviceId)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<IEnumerable<DeviceInformationReadDto>> DisableDevice(Guid deviceId)
        {
            return Ok();
        }
    }
}
