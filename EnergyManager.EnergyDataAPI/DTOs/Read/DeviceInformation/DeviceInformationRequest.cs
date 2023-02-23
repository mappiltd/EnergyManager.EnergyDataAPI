using EnergyManager.EnergyDataAPI.DTOs.Read.UnitsOfMeasurement;
using EnergyManager.EnergyDataAPI.DTOs.Write.UnitsOfMeasurement;
using EnergyManager.EnergyDataAPI.Models.Devices;

namespace EnergyManager.EnergyDataAPI.DTOs.Read.DeviceInformation
{
    public class DeviceInformationRequest
    {
        public Guid DeviceDataId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceDescription { get; set; }        
        public Guid CustomerId { get; set; }
        public Guid LocationId { get; set; }
        public Guid BuildingId { get; set; }
        public bool DeviceEnabled { get; set; }
        public DateTime DeviceDateCreated { get; set; }
        public UnitsOfMeasurementRequest? UnitsOfMeasurement { get; set; }
    }
}
