using legenda.Models.View;
using legenda.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace legenda.Areas.Admin.Controllers
{
    public class StaticDataController : AdminBaseController
    {
        public StaticDataService staticDataService = new StaticDataService();
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            var about = staticDataService.GetAbout();
            ViewBag.About = about;
            return View(staticDataService.GetContact());
        }

        [HttpPost]
        public JsonResult Contact(ContactVM model)
        {
            if (ModelState.IsValid)
            {
                var message = staticDataService.UpdateContact(model);
                return Json(message);

            }
            return Json(false);
        }

        [HttpPost]
        public JsonResult About(AboutVM model)
        {
            if (ModelState.IsValid)
            {
                var message = staticDataService.UpdateAbout(model);
                return Json(message);

            }
            return Json(false);
        }
        
    }
}