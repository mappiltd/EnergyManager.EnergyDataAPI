using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyManager.EnergyDataAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Table("TagData")]
    public class TagDataModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TagDataId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string? TagDataName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string? TagDataDescription { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string? TagDataTextColor { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string? TagDataBackgroundColour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public bool TagDataDeleted { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime TagCreatedDate { get; set; }
    }
}
