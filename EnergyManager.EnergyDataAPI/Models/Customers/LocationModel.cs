using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyManager.EnergyDataAPI.Models.Customers
{
    [Table("Locations")]
    public class LocationModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LocationId { get; set; }

        [Required]
        public Guid LocationDescription { get; set; }

        [Required]
        public DateTime LocationCreated { get; set; }

        [Required]
        public Guid BuildingId { get; set; }

        [Required]
        public Guid AddressesId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public bool Enabled { get; set; }
    }
}
