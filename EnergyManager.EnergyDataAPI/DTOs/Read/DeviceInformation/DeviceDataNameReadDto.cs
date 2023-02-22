using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EnergyManager.EnergyDataAPI.Models;

namespace EnergyManager.EnergyDataAPI.DTOs.Read.DeviceInformation
{
    public class DeviceMetaDataReadDto
    {
        public string? DeviceName { get; set; }
        public string? DeviceDescription { get; set; }
        public UnitsOfMeasurementModel? UnitsOfMeasurement { get; set; }         
    }
}
