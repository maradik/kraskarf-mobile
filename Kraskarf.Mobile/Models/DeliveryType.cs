using System;

namespace Kraskarf.Mobile.Models
{
    public class DeliveryType
    {
        public DeliveryType()
        {
            Id = String.Empty;
            Name = string.Empty;
            DescriptionHtml = string.Empty;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string DescriptionHtml { get; set; }
        public double Price { get; set; }
    }
}