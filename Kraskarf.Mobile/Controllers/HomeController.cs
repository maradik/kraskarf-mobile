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
        private IPaymentTypeAccessor paymentTypeAccessor;
        private IDeliveryTypeAccessor deliveryTypeAccessor;
        private IProductGroupAccessor productGroupAccessor;

        public HomeController(IPaymentTypeAccessor paymentTypeAccessor, IDeliveryTypeAccessor deliveryTypeAccessor, IProductGroupAccessor productGroupAccessor)
        {
            this.paymentTypeAccessor = paymentTypeAccessor;
            this.deliveryTypeAccessor = deliveryTypeAccessor;
            this.productGroupAccessor = productGroupAccessor;
        }

        public ActionResult Index()
        {
            var a = paymentTypeAccessor.GetAllPaymentTypes();
            var b = deliveryTypeAccessor.GetAllDeliveryTypes();
            var c = productGroupAccessor.GetAllProductGroups();
            return View();
        }
    }
}