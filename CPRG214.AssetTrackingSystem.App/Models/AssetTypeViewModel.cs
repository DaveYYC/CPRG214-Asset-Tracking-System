using System.ComponentModel.DataAnnotations;

namespace CPRG214.AssetTrackingSystem.App.Models
{
    public class AssetTypeViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Asset Type")]
        [Required] 
        public string Name { get; set; }
    }
}

