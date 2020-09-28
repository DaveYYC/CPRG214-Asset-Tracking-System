using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CPRG214.AssetTrackingSystem.Domain;
using CPRG214.AssetTrackingSystem.BLL;
using System.Collections;
using CPRG214.AssetTrackingSystem.App.Models;

namespace CPRG214.AssetTrackingSystem.App.Controllers
{
    public class AssetController : Controller
    {
        // get assets
        public ActionResult Index()
        {
            var assets = AssetsManager.GetAll();
            var viewModels = assets.Select(a => new AssetViewModel
            {
                Id = a.Id,
                Description = a.Description,
                AssetType = a.AssetType.Name,
                TagNumber = a.TagNumber,
                SerialNumber = a.SerialNumber
            }).ToList();
            return View(viewModels);
        }

        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetsByType", id);
        }

        public ActionResult Create()
        {
            ViewBag.AssetTypeId = GetAssetTypes();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Asset asset)
        {
            try
            {
                AssetsManager.Add(asset);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Assets/Edit/5
        public ActionResult Edit(int id)
        {
            var asset = AssetsManager.Find(id);
            ViewBag.AssetTypeId = GetAssetTypes();
            return View(asset);
        }

        // POST: Assets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Asset asset)
        {
            try
            {
                AssetsManager.Update(asset);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IEnumerable GetAssetTypes()
        {
            var assetTypes = AssetTypesManager.GetAsKeyValuePairs();
            var types = new SelectList(assetTypes, "Value", "Text");

            var list = types.ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "All Types",
                Value = "0"
            });

            return list;
        }

        public IActionResult Search()
        {
            ViewBag.AssetTypeId = GetAssetTypes();
            return View();
        }

        public IActionResult Assets(int id)
        {
            var filteredAssets = AssetsManager.GetAllByAssetType(id);
            var result = $"Asset count: {filteredAssets.Count}";
            return Content(result);
        }
    }
}