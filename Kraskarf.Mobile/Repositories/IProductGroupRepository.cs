using System.Collections.Generic;
using Kraskarf.Mobile.Models;

namespace Kraskarf.Mobile.Repositories
{
    public interface IProductGroupRepository
    {
        IEnumerable<ProductGroup> GetAllProductGroups();
    }
}