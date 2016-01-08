using System.Collections.Generic;
using Kraskarf.Mobile.Models;

namespace Kraskarf.Mobile.Accessors
{
    public interface IProductGroupAccessor
    {
        IEnumerable<ProductGroup> GetAllProductGroups();
    }
}