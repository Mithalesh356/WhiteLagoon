using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Domain.Entity;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _Db;
        public VillaController(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult Index()
        {
            var villas=_Db.Villas.ToList();
            return View(villas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Villa obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("Description", "Description cannot exatly match the name");
            }
            if (ModelState.IsValid)
            {
                _Db.Villas.Add(obj);
                _Db.SaveChanges();
                TempData["success"] = "The Villa Has Been Created Successfully";
                return RedirectToAction("Index", "Villa");
            }
            TempData["error"] = "The Villa Could Not Be Created ";
            return View(obj);
           
            
        }

        public IActionResult Edit(int villaId)
        {
            Villa? obj = _Db.Villas.FirstOrDefault(u => u.Id == villaId);
            if (obj == null)
            {
                return RedirectToAction("Error","Home");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Villa obj)
        
        
     {
            if(ModelState.IsValid && obj.Id > 0)
            {
                _Db.Villas.Update(obj);
                _Db.SaveChanges();
                TempData["success"] = "The Villa Has Been Updated Successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = "The Villa Could Not Be Updated";
            return View();
            
        }

        public IActionResult Remove(int villaId)
        {
            Villa? obj = _Db.Villas.FirstOrDefault(u => u.Id == villaId);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Remove(Villa obj)
        {
            if(ModelState.IsValid && obj.Id > 0)
            {
                _Db.Villas.Remove(obj);
                _Db.SaveChanges();
                TempData["success"] = "The Villa Has Been  Deleted Successfully";
                return RedirectToAction("Index");
            }
            TempData["error"] = "The Villa Could Not Be Deleted";
            return View();
        }
    }
}
