using Microsoft.AspNetCore.Mvc;
using StaffPortal.Data;
using StaffPortal.Models;
using System.Linq;

namespace StaffPortal.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StaffController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var staffList = _context.Staff.ToList();
            return View(staffList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Staff.Add(staff);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staff);
        }

        public IActionResult Edit(string id)
        {
            var staff = _context.Staff.Find(id);
            if (staff == null)
            {
                return NotFound();
            }
            return View(staff);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Staff.Update(staff);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staff);
        }

        public IActionResult Delete(string id)
        {
            var staff = _context.Staff.Find(id);
            if (staff == null)
            {
                return NotFound();
            }
            return View(staff);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var staff = _context.Staff.Find(id);
            _context.Staff.Remove(staff);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
