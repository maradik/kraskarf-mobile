using System.Collections.Generic;
using Kraskarf.Mobile.Models;

namespace Kraskarf.Mobile.Repositories
{
    public interface IDeliveryTypeRepository
    {
        IEnumerable<DeliveryType> GetAllDeliveryTypes();
    }
}