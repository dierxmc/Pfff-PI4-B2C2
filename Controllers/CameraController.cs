using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using Pfff_PI4_B2C2.Areas.Identity.Data;
using Pfff_PI4_B2C2.Models;

namespace Pfff_PI4_B2C2.Controllers
{
    public class CameraController : Controller
    {
        private readonly AppDbContext db;

        private UserManager<ApplicationUser> userManager;

        public CameraController(AppDbContext db,UserManager<ApplicationUser> usrMgr)
        {
            this.db = db;
            userManager = usrMgr;
        }

        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Camera> objCameraList = db.Camera;
            return View(objCameraList);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE view
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Create(Camera camera)
        {
            if (ModelState.IsValid)
            {
                db.Camera.Add(camera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET - DELETE view
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var camera = db.Camera.FirstOrDefault(f => f.Id == id);
            if (camera == null)
            {
                return NotFound();
            }
            return View(camera);
        }

        //POST - DELETE view
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult DeletePOST(int? id)
        {
            var camera = db.Camera.Find(id);
            if (camera == null)
            {
                return NotFound();
            }
            db.Camera.Remove(camera);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
