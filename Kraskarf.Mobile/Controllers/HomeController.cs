using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kraskarf.Mobile.Accessors;
using Kraskarf.Mobile.Repositories;

namespace Kraskarf.Mobile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var a = new PaymentTypeAccessor(new PaymentTypeRepository()).GetAllPaymentTypes();
            var b = new DeliveryTypeAccessor(new DeliveryTypeRepository()).GetAllDeliveryTypes();
            var c = new ProductGroupAccessor(new ProductGroupRepository()).GetAllProductGroups();
            return View();
        }
    }
}