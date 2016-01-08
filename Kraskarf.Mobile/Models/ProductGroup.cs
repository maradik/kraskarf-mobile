using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Kraskarf.Mobile.Models
{
    [Serializable]
    [DataContract]
    public class ProductGroup
    {
        public ProductGroup()
        {
            Name = string.Empty;
            DescriptionHtml = string.Empty;
            Products = new List<Product>();
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string DescriptionHtml { get; set; }

        [DataMember]
        public string ImageSrc { get; set; }

        [DataMember]
        public IEnumerable<Product> Products { get; set; }
    }
}