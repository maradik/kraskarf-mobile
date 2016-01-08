using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kraskarf.Mobile.Models;
using Kraskarf.Mobile.Repositories;
using NLog;

namespace Kraskarf.Mobile.Accessors
{
    public class ProductGroupAccessor : BaseAccessor, IProductGroupAccessor
    {
        private readonly ILogger logger = LogManager.GetLogger("ProductGroupAccessor");

        private readonly IProductGroupRepository productGroupRepository;

        public ProductGroupAccessor(IProductGroupRepository productGroupRepository)
        {
            this.productGroupRepository = productGroupRepository;
        }

        public IEnumerable<ProductGroup> GetAllProductGroups()
        {
            var productGroups = new List<ProductGroup>();

            try
            {
                var cacheKey = typeof(List<ProductGroup>).ToString();
                productGroups = GetFromCache<List<ProductGroup>>(cacheKey);

                if (productGroups == null)
                {
                    productGroups = productGroupRepository.GetAllProductGroups().ToList();
                    PutToCache(cacheKey, productGroups);

                    logger.Info("Группы продуктов были прочитаны из источника, т.к. не найдены в кэше");
                }
            }
            catch (Exception)
            {
                logger.Error("Не удалось получить группы продуктов");
            }


            return productGroups;
        }
    }
}