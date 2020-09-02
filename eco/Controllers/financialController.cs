using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eco.Controllers
{
    public class financialController : Controller
    {
        // GET: financial
        public ActionResult managementFee()
        {
            return View();
        }
        public ActionResult gasData()
        {
            return View();
        }
        public ActionResult communityMoney()
        {
            return View();
        }
    }
}