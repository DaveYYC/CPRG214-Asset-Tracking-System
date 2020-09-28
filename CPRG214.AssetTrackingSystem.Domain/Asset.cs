using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CPRG214.AssetTrackingSystem.Domain
{
    [Table("Asset")]
    public class Asset
    {
        // Properties
        public int Id { get; set; }
        [Display(Name = "Tag Number")] 
        [Required] 
        public string TagNumber { get; set; }
        [Display(Name = "Asset Type")] 
        [Required] 
        public int AssetTypeId { get; set; }
        [Required] 
        public string Manufacturer { get; set; }

       
        public string Model { get; set; }
        [Required] 
        public string Description { get; set; }
        [Display(Name = "Serial Number")] 
        [Required] 
        public string SerialNumber { get; set; }

        // Navigation Properties

        [Display(Name = "Asset Type")] 
        public AssetType AssetType { get; set; }
    }
}
