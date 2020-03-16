using Core.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService StudentService;

        public HomeController(IStudentService studentService)
        {
            StudentService = studentService;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
           // var students = GetStudents();
            return View();
        }

        public JsonResult GetStudents()
        {
            var result = StudentService.GetStudents();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SendEmailTest() {
            StudentService.sendEmail();
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}
