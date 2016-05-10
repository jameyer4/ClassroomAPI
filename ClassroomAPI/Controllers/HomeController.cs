using ClassroomAPI.Models;
using ClassroomAPI.Models.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassroomAPI.Controllers
{
    public class HomeController : Controller
    {
        private ClassroomContext db = new ClassroomContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            List<Notes> list = new List<Notes>();
            try
            {
                list = db.Notes.ToList();
               // ViewBag.TeacherId = new GetTeachers().GetTeacherIdByUsername(User.Identity.Name);
            }
            catch (Exception ex) { }

            return View(list);
        }
    }
}
