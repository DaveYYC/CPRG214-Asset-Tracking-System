using System.ComponentModel.DataAnnotations;

namespace CPRG214.AssetTrackingSystem.App.Models
{
    public class AssetViewModel
    {
        // Properties of this View
        public int Id { get; set; }
        public string Description { get; set; }
        [Display(Name = "Asset Type")]
        public string AssetType { get; set; }
        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
    }
}
