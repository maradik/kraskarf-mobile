using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using Kraskarf.Mobile.Models;
using NLog;

namespace Kraskarf.Mobile.Repositories
{
    public class PaymentTypeRepository : BaseRepository, IPaymentTypeRepository
    {
        public IEnumerable<PaymentType> GetAllPaymentTypes()
        {
            var fileName = HttpContext.Current.Server.MapPath(@"~/App_Data/PaymentTypeData.js");

            return GetEntityFromFile<List<PaymentType>>(fileName);
        }
    }
}