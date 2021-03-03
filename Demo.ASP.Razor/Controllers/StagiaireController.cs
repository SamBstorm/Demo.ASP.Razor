using Model.Client.Models;
using Model.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.ASP.Razor.Controllers
{
    public class StagiaireController : Controller
    {
        private StagiaireService _service;
        public StagiaireController()
        {
            _service = new StagiaireService();
        }

        // GET: Stagiaire
        public ActionResult Index()
        {
            
            List<Stagiaire> datas = _service.Get().ToList();
            return View(datas);
        }

        // GET: Stagiaire/Details/5
        public ActionResult Details(int id)
        {
            
            Stagiaire data = _service.Get(id);
            return View(data);
        }

        // GET: Stagiaire/Create
        public ActionResult Create()
        {
            Stagiaire data = new Stagiaire();
            return View(data);
        }

        // POST: Stagiaire/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Stagiaire data = new Stagiaire() {
                    LastName = collection["LastName"],
                    FirstName = collection["FirstName"],
                    Email = collection["Email"],
                    NationalRegistre = collection["NationalRegistre"]
                };
                
                _service.Insert(data);
                return RedirectToAction("Index");
            }
            catch
            {
                Stagiaire data = new Stagiaire();
                return View(data);
            }
        }

        // GET: Stagiaire/Edit/5
        public ActionResult Edit(int id)
        {
            
            Stagiaire data = _service.Get(id);
            return View(data);
        }

        // POST: Stagiaire/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Stagiaire data = new Stagiaire()
                {
                    Id = int.Parse(collection["Id"]),
                    LastName = collection["LastName"],
                    FirstName = collection["FirstName"],
                    Email = collection["Email"],
                    NationalRegistre = collection["NationalRegistre"]
                };
                
                _service.Update(id,data);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Stagiaire/Delete/5
        public ActionResult Delete(int id)
        {
            
            Stagiaire data = _service.Get(id);
            return View(data);
        }

        // POST: Stagiaire/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                
                _service.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
