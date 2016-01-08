using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Helpers;
using Kraskarf.Mobile.Models;
using NLog;

namespace Kraskarf.Mobile.Accessors
{
    public class PaymentTypeAccessor
    {
        private readonly ILogger logger = LogManager.GetLogger("PaymentTypeAccessor");

        public IEnumerable<PaymentType> GetAllPaymentTypes()
        {
            var paymentTypes = new List<PaymentType>();

            try
            {
                var fileName = HttpContext.Current.Server.MapPath(@"~/App_Data/PaymentTypeData.js");
                
                using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(File.ReadAllText(fileName))))
                {
                    paymentTypes = (List<PaymentType>)new DataContractJsonSerializer(typeof(List<PaymentType>)).ReadObject(memoryStream);
                }
            }
            catch (Exception e)
            {
                logger.Log(LogLevel.Error, e, "Не удалось получить перечень способов оплаты");    
            }

            return paymentTypes;
        }
    }
}