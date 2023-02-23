using EnergyManager.EnergyDataAPI.DTOs.Write.UnitsOfMeasurement;

namespace EnergyManager.EnergyDataAPI.DTOs.Write.DeviceInformation
{
    public class DeviceInformationResponse
    {
        public Guid DeviceDataId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceDescription { get; set; } 
        public bool DeviceEnabled { get; set; }                                                              
        public UnitsOfMeasurementResponse? UnitsOfMeasurement { get; set; }        
    }
}
