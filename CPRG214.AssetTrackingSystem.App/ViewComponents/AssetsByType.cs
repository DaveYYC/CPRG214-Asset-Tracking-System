using CPRG214.AssetTrackingSystem.BLL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214.AssetTrackingSystem.Domain;
using CPRG214.AssetTrackingSystem.App.Models;

namespace CPRG214.AssetTrackingSystem.App.ViewComponents
{
    public class AssetsByTypeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            IList<Asset> assets = null;

            if (id == 0)
            {
                assets = AssetsManager.GetAll();
            }
            else
            {
                assets = AssetsManager.GetAllByAssetType(id);
            }

            var assetList = assets.Select(a => new AssetViewModel
            {
                Id = a.Id,
                TagNumber = a.TagNumber,
                AssetType = a.AssetType.Name,
                Description = a.Description,
                SerialNumber = a.SerialNumber
            }).ToList();

            return View(assetList);
        }
    }
}