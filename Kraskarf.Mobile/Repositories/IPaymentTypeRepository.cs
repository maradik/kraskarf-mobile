using System.Collections.Generic;
using Kraskarf.Mobile.Models;

namespace Kraskarf.Mobile.Repositories
{
    public interface IPaymentTypeRepository
    {
        IEnumerable<PaymentType> GetAllPaymentTypes();
    }
}