using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: /Test/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: /Test/Create
        [HttpPost]
        public ActionResult Create(ResumeModels resume)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Test", "Home");
            }
            return View(resume);
        }

        // POST: /Test/Delete
        [HttpPost]
        public ActionResult Delete(int id)
        {

            return View();
        }

        // GET: /Test/Edit
        public ActionResult Edit()
        {
            ResumeModels model = new ResumeModels();
            model.Age = "12";
            model.Classid = "312";
            model.Score = "54";
            model.Uid = "1";
            model.Username = "zaolazi";
            model.Stuid = "32";
            return View(model);
        }
    }
}
