using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kraskarf.Mobile.Models;
using NLog;

namespace Kraskarf.Mobile.Repositories
{
    public class ProductGroupRepository : BaseRepository, IProductGroupRepository
    {
        public IEnumerable<ProductGroup> GetAllProductGroups()
        {
            var fileName = HttpContext.Current.Server.MapPath(@"~/App_Data/ProductGroupData.js");

            return GetEntityFromFile<List<ProductGroup>>(fileName);
        }
    }
}