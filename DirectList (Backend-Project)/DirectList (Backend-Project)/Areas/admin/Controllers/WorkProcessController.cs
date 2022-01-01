using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Areas.admin.Controllers
{
    [Area("admin")]
    public class WorkProcessController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public WorkProcessController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.WorkingProcesses.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WorkingProcess working)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.WorkingProcesses.Add(working);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(working);
        }
        public IActionResult Update(int? id)
        {
            WorkingProcess workingProcess = _appDbContext.WorkingProcesses.Find(id);
            return View(workingProcess);
        }
        [HttpPost]
        public IActionResult Update(WorkingProcess working)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.WorkingProcesses.Update(working);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(working);
        }
        public IActionResult Delete(int? id)
        {
            WorkingProcess working = null;


            if (id != null)
            {
                working = _appDbContext.WorkingProcesses.Find(id);
            }


            if (working != null)
            {
                _appDbContext.WorkingProcesses.Remove(working);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "about not found");
                return View();
            }

        }
    }
}
