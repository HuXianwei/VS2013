using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();   
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            ViewBag.Message = "Your contact page.";
            ResumeModels model = new ResumeModels();
            model.Age = "12";
            model.Classid = "312";
            model.Score = "54";
            model.Uid = "1";
            model.Username = "zaolazi";
            model.Stuid = "32";
            List<ResumeModels> models = new List<ResumeModels>();
            models.Add(model);
            return View(models);
        }
    }
}