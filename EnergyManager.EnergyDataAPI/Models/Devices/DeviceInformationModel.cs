using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyManager.EnergyDataAPI.Models.Devices
{
    [Table("DeviceData")]
    public class DeviceInformationModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DeviceDataId { get; set; }

        [Required]
        public string? DeviceName { get; set; }

        [Required]
        public string? DeviceDescription { get; set; }       

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public Guid BuildingId { get; set; }

        [Required]
        public Guid LocationId { get; set; }        

        [Required]
        public Guid? UnitsOfMeasurementId { get; set; }        

        [Required]
        public bool DeviceEnabled { get; set; }

        [Required]
        public DateTime DeviceDateCreated { get; set; }
    }
}
