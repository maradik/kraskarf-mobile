using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Web;
using Kraskarf.Mobile.Models;

namespace Kraskarf.Mobile.ViewModels
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            PaymentTypes = new List<PaymentType>();
            DeliveryTypes = new List<DeliveryType>();
            ProductGroups = new List<ProductGroup>();
        }

        public IEnumerable<PaymentType> PaymentTypes { get; set; }
        public IEnumerable<DeliveryType> DeliveryTypes { get; set; }
        public IEnumerable<ProductGroup> ProductGroups { get; set; }
    }
}