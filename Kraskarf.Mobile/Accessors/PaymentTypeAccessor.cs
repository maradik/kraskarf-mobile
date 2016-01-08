using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Helpers;
using Kraskarf.Mobile.Models;
using Kraskarf.Mobile.Repositories;
using NLog;
using Sider;

namespace Kraskarf.Mobile.Accessors
{
    public class PaymentTypeAccessor : BaseAccessor, IPaymentTypeAccessor
    {
        private readonly ILogger logger = LogManager.GetLogger("PaymentTypeAccessor");

        private readonly IPaymentTypeRepository paymentTypeRepository;

        public PaymentTypeAccessor(IPaymentTypeRepository paymentTypeRepository)
        {
            this.paymentTypeRepository = paymentTypeRepository;
        }

        public IEnumerable<PaymentType> GetAllPaymentTypes()
        {
            var paymentTypes = new List<PaymentType>();

            try
            {
                var cacheKey = typeof(List<PaymentType>).ToString();
                paymentTypes = GetFromCache<List<PaymentType>>(cacheKey);

                if (paymentTypes == null)
                {
                    paymentTypes = paymentTypeRepository.GetAllPaymentTypes().ToList();
                    PutToCache(cacheKey, paymentTypes);

                    logger.Info("Типы оплат были прочитаны из источника, т.к. не найдены в кэше");
                }
            }
            catch (Exception)
            {
                logger.Error("Не удалось получить способы оплат");
            }


            return paymentTypes;
        }
    }
}