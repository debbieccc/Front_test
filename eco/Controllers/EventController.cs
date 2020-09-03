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

        public ActionResult Event_page(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Event");
            }
            TestForEventRegisterEntities db = new TestForEventRegisterEntities();
            tEventSet x = db.tEventSet.FirstOrDefault(m => m.fEventId == id);
            return View(x);
        }


        public ActionResult Event_signup(int? id)
        {            
            TestForEventRegisterEntities db = new TestForEventRegisterEntities();
            if (id == null)
            {
                return RedirectToAction("Event");
            }
            tEventSet set = db.tEventSet.FirstOrDefault(m => m.fEventId == id);
            tEventRegister x = new tEventRegister();           
            x.fEventId = id;

            if (set.ferEmail == 1)
            {
                ViewBag.ferEmail = 1;
            }
            if (set.ferGender == 1)
            {
                ViewBag.ferGender = 1;
            }
            if (set.ferBirthday == 1)
            {
                ViewBag.ferBirthday = 1;
            }
            if (set.ferIdentity == 1)
            {
                ViewBag.ferIdentity = 1;
            }
            if (set.ferOccupation == 1)
            {
                ViewBag.ferOccupation = 1;
            }
            if (set.ferVeganOrNot == 1)
            {
                ViewBag.ferVeganOrNot = 1;
            }
            if (set.ferGender == 1)
            {
                ViewBag.ferGender = 1;
            }
            if (set.ferOtherColumn1 !=null)
            {
                ViewBag.ferOtherColumn1 = set.ferOtherColumn1;
            }
            if (set.ferOtherColumn2 != null)
            {
                ViewBag.ferOtherColumn2 = set.ferOtherColumn2;
            }
            if (set.ferOtherColumn3 != null)
            {
                ViewBag.ferOtherColumn3 = set.ferOtherColumn3;
            }
            if (set.ferOtherColumn4 != null)
            {
                ViewBag.ferOtherColumn4 = set.ferOtherColumn4;
            }
            if (set.ferOtherColumn5 != null)
            {
                ViewBag.ferOtherColumn5 = set.ferOtherColumn5;
            }


            return View(x);
        }     

        [HttpPost]
        public ActionResult Event_signup(tEventRegister p)
        {
            TestForEventRegisterEntities db = new TestForEventRegisterEntities();     
            
            db.tEventRegister.Add(p);
            db.SaveChanges();
            return RedirectToAction("Event");

        }
    }
}