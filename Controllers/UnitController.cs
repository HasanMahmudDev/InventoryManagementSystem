using IMS.Data;
using IMS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Controllers
{
    public class UnitController : Controller
    {

        public readonly InventoryContext db;
        public UnitController(InventoryContext context)
        {
            db = context;
        }
        //view data unit
        public IActionResult Index()
        {
            List<Unit> units = db.Units.ToList();
            return View(units);
        }
        //create data Unit
        [HttpGet]
        public IActionResult Create()
        {
            Unit unit = new Unit();
            return View(unit);
        }
        [HttpPost]
        public IActionResult Create(Unit unit)
        {
            try
            {
                db.Units.Add(unit);
                db.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }

        // Details 
        public IActionResult Details(int id)
        {
            Unit unit = GetUnit(id);
            return View(unit);
        }

        // Edit
        public IActionResult Edit(int id)
        {
            Unit unit = GetUnit(id);
            return View(unit);
        }
        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                db.Units.Attach(unit);
                db.Entry(unit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));

        }

        // Delete
        public IActionResult Delete(int id)
        {
            Unit unit = GetUnit(id);
            return View(unit);
        }
        [HttpPost]
        public IActionResult Delete(Unit unit)
        {
            try
            {
                db.Units.Attach(unit);
                db.Entry(unit).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                db.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));

        }

        private Unit GetUnit(int id)
        {
            Unit unit = db.Units.Where(u => u.Id == id).FirstOrDefault();
            return unit;
        }

    }//Controller
}
