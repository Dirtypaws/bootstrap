using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestBootstrap.Controllers
{
    public class NavController : Controller
    {
        #region Main

        public ActionResult Index()
        {
            return View("../Main/Index");
        }

        #endregion

    }
}