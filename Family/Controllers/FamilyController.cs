using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Family.Models.Services.Application;
using Family.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Family.Controllers
{
    public class FamilyController : Controller
    {
        private readonly IFamilyService familyService;

        public FamilyController(IFamilyService _familyService)
        {
            familyService = _familyService;
        }
        // GET: FamilyController
        public ActionResult Index()
        {
            //var familyServices = new FamilyService();
            List<FamilyVieWModel> family = familyService.GetFamily();
            return View(family);
        }

        // GET: FamilyController/Details/5
        public ActionResult Details(int id)
        {
            ViewData["Title"] = "Member Details";
           // var familyServices = new FamilyService();
            DetailsViewModel memberDetails = familyService.GetDetails(id);
            return View(memberDetails);
        }

        // GET: FamilyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamilyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FamilyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamilyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FamilyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
