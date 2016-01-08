using System.Collections.Generic;

namespace Kraskarf.Mobile.Models
{
    public class ProductGroup
    {
        public ProductGroup()
        {
            Name = string.Empty;
            DescriptionHtml = string.Empty;
            Products = new List<Product>();
        }

        public string Name { get; set; }
        public string DescriptionHtml { get; set; }
        public string ImageSrc { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}