using CPRG214.AssetTrackingSystem.Data;
using CPRG214.AssetTrackingSystem.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CPRG214.AssetTrackingSystem.BLL
{
    public class AssetsManager
    {
        public static IList<Asset> GetAll()
        {
            var context = new AssetContext();
            var assets = context.Assets.Include(a => a.AssetType).ToList();
            return assets;
        }

        public static void Add(Asset asset)
        {
            var context = new AssetContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }

        public static Asset Find(int id)
        {
            var context = new AssetContext();
            var asset = context.Assets.Find(id);
            return asset;
        }

        public static void Update(Asset asset)
        {
            var context = new AssetContext();
            var originalAsset = context.Assets.Find(asset.Id);
            originalAsset.TagNumber = asset.TagNumber;
            originalAsset.AssetTypeId = asset.AssetTypeId;
            originalAsset.Manufacturer = asset.Manufacturer;
            originalAsset.Model = asset.Model;
            originalAsset.Description = asset.Description;
            originalAsset.SerialNumber = asset.SerialNumber;
            context.SaveChanges();
        }

        public static IList<Asset> GetAllByAssetType(int id)
        {
            var context = new AssetContext();
            var assets = context.Assets.
                Where(a => a.AssetTypeId == id).
                Include(t => t.AssetType).ToList();
            return assets;
        }
    }
}
