using Microsoft.AspNetCore.Mvc;
using CPRG214.AssetTrackingSystem.Domain;
using CPRG214.AssetTrackingSystem.BLL;


namespace CPRG214.AssetTrackingSystem.App.Controllers
{
    public class AssetTypesController : Controller
    {
        // GET: AssetTypes
        public ActionResult Index()
        {
            var assetType = AssetTypesManager.GetAssetTypes();
            return View(assetType);
        }

        // GET: AssetTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssetTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssetType type)
        {
            try
            {
                AssetTypesManager.Add(type);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AssetTypes/Edit/5
        public ActionResult Edit(int id)
        {
            var assetType = AssetTypesManager.Find(id);
            return View(assetType);
        }

        // POST: AssetTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AssetType assettype)
        {
            try
            {
                AssetTypesManager.Update(assettype);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}