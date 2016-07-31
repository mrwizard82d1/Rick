using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RickWeb.Models;

namespace RickWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(ResistorViewModel model = null)
        {
            if (model == null)
            {
                model = new ResistorViewModel();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection formValues)
        {
            var updatedModel = new ResistorViewModel();

            UpdateModel(updatedModel, formValues);

            return View(updatedModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
