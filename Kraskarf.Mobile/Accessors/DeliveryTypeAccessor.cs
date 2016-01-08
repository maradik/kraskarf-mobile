using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kraskarf.Mobile.Models;
using Kraskarf.Mobile.Repositories;
using NLog;

namespace Kraskarf.Mobile.Accessors
{
    public class DeliveryTypeAccessor : BaseAccessor, IDeliveryTypeAccessor
    {
        private readonly ILogger logger = LogManager.GetLogger("DeliveryTypeAccessor");

        private readonly IDeliveryTypeRepository deliveryTypeRepository;

        public DeliveryTypeAccessor(IDeliveryTypeRepository deliveryTypeRepository)
        {
            this.deliveryTypeRepository = deliveryTypeRepository;
        }

        public IEnumerable<DeliveryType> GetAllDeliveryTypes()
        {
            var deliveryTypes = new List<DeliveryType>();

            try
            {
                var cacheKey = typeof(List<DeliveryType>).ToString();
                deliveryTypes = GetFromCache<List<DeliveryType>>(cacheKey);

                if (deliveryTypes == null)
                {
                    deliveryTypes = deliveryTypeRepository.GetAllDeliveryTypes().ToList();
                    PutToCache(cacheKey, deliveryTypes);

                    logger.Info("Способы доставки были прочитаны из источника, т.к. не найдены в кэше");
                }
            }
            catch (Exception)
            {
                logger.Error("Не удалось получить способы доставки");
            }


            return deliveryTypes;
        }
    }
}