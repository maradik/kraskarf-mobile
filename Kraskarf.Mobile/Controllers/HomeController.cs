using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kraskarf.Mobile.Accessors;
using Kraskarf.Mobile.Repositories;
using Kraskarf.Mobile.ViewModels;

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
            var viewModel = new HomeIndexViewModel
            {
                PaymentTypes = paymentTypeAccessor.GetAllPaymentTypes(),
                DeliveryTypes = deliveryTypeAccessor.GetAllDeliveryTypes(),
                ProductGroups = productGroupAccessor.GetAllProductGroups()
            };

            return View(viewModel);
        }
    }
}