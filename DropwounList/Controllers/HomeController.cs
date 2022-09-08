using DropwounList.Db;
using DropwounList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DropwounList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            mydbEntities obj = new mydbEntities();
            var res = obj.Drops.ToList();
            List<Class1> c = new List<Class1>();
            foreach (var item in res)
            {
                c.Add(new Class1
                {
                    id=item.id,
                    name=item.name,
                    roll=item.roll,
                    city=item.city
                });
            }
            return View(c);
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
        [HttpGet]
        public ActionResult form()
        {

            List<string> list = new List<string>()
            {
                "noida","delhi","Uk"
            };
            ViewBag.l = list;
            return View();
        }
        [HttpPost]
        public ActionResult form(Class1 cobj)
        {
            mydbEntities obj = new mydbEntities();
            Drop tbl = new Drop();
            tbl.id = cobj.id;
            tbl.name = cobj.name;
            tbl.roll = cobj.roll;
            tbl.city = cobj.city;

            obj.Drops.Add(tbl);
            obj.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}