using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyManager.EnergyDataAPI.Models.Customers
{
    [Table("Addresses")]
    public class AddressModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AddressId { get; set; }
    }
}
