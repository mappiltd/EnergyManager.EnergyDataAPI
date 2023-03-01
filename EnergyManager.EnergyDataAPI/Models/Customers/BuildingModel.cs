using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyManager.EnergyDataAPI.Models.Customers
{
    [Table("Buildings")]
    public class BuildingModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BuildingId { get; set; }

        [Required]
        public Guid BuildingDescription { get; set; }

        [Required]
        public DateTime BuildingCreated { get; set; }

        [Required]
        public Guid AddressesId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public bool Enabled { get; set; }
    }
}