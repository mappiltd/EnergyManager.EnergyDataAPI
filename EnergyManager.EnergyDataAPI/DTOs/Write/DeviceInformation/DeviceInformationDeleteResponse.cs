﻿namespace EnergyManager.EnergyDataAPI.DTOs.Write.DeviceInformation
{
    public class DeviceInformationDeleteResponse
    {
        public Guid DeviceDataId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceDescription { get; set; }
        public Guid? UnitsOfMeasurementId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid LocationId { get; set; }
        public Guid BuildingId { get; set; }
        public bool DeviceEnabled { get; set; }
        public DateTime DeviceDateCreated { get; set; }
    }
}
