using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CPRG214.AssetTrackingSystem.Domain
{
    [Table("AssetType")]
    public class AssetType
    {
        // Properties
        public int Id { get; set; }

        [Display(Name = "Asset Type")]
        [Required] 
        public string Name { get; set; }

        // Navigation properties
        public ICollection<Asset> Assets { get; set; }

    }
}
