using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kraskarf.Mobile.Models;
using NLog;

namespace Kraskarf.Mobile.Repositories
{
    public class DeliveryTypeRepository : BaseRepository, IDeliveryTypeRepository
    {
        public IEnumerable<DeliveryType> GetAllDeliveryTypes()
        {
            var fileName = HttpContext.Current.Server.MapPath(@"~/App_Data/DeliveryTypeData.js");

            return GetEntityFromFile<List<DeliveryType>>(fileName);
        }
    }
}