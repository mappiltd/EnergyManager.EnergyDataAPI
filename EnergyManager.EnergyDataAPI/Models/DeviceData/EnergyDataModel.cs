using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EnergyManager.EnergyDataAPI.Models.DeviceData
{
    /// <summary>
    /// 
    /// </summary>
    [Table("EnergyData")]
    public class EnergyDataModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EnergyDataId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Guid DeviceDataId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime ReadingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public TimeSpan ReadingTime
        {
            get { return ReadingDate.TimeOfDay; }
            set { }
        }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public double ReadingValue { get; set; }
    }
}
