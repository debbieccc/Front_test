using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eco.Controllers
{
    public class EventController : Controller
    {
        
        public ActionResult Event()
        {
            return View();
        }

        public ActionResult Event2()
        {
            TestForEventRegisterEntities db = new TestForEventRegisterEntities();
            var events = from t in (new TestForEventRegisterEntities()).tEventSet
                        select t;
            return View(events);
        }

        public ActionResult Event_yoga()
        {
            return View();
        }

        public ActionResult Event_signup()
        {
            return View();
        }
    }
}