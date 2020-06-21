using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIMPLE_MEMBER_PROVIDER.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}