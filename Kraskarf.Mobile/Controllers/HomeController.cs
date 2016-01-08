using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kraskarf.Mobile.Accessors;

namespace Kraskarf.Mobile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var a = new PaymentTypeAccessor().GetAllPaymentTypes();
            return View();
        }
    }
}