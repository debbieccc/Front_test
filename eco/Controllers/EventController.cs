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
            IQueryable<tEventSet> events = null;
            TestForEventRegisterEntities db = new TestForEventRegisterEntities();
            events = from t in (new TestForEventRegisterEntities()).tEventSet
                     select t;
            return View(events);
        }

        public ActionResult Event2()
        {
            IQueryable<tEventSet> events = null;
            TestForEventRegisterEntities db = new TestForEventRegisterEntities();
            events = from t in (new TestForEventRegisterEntities()).tEventSet
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