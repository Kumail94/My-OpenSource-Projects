using Indus_Pencil_Industries.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indus_Pencil_Industries.Controllers
{
    public class HomeController : Controller
    {
        Indus_DBEntities db = new Indus_DBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllRecords());
        }
        IEnumerable<Deer> GetAllRecords()
        {
            using ( db = new Indus_DBEntities())
            {
                return (db.Deer.ToList<Deer>());
            }
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            Deer deer = new Deer();
            return View(deer);
        }
        [HttpPost]
        public ActionResult AddOrEdit(Deer deer)
        {
            if (deer.ImageUpload != null)
            {
                string FileName = Path.GetFileNameWithoutExtension(deer.ImageUpload.FileName);
                string Extension = Path.GetFileName(deer.ImageUpload.FileName);
                FileName = FileName + DateTime.Now.ToString("yymmssff") + Extension;
                deer.Image_Path = "~/Images/Kumayl.jpg";
                deer.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Images/Kumayl.jpg"), FileName));
            }
            using (db = new Indus_DBEntities())
            {
                db.Deer.Add(deer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}