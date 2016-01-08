using System;
using System.Runtime.Serialization;

namespace Kraskarf.Mobile.Models
{
    [Serializable]
    [DataContract]
    public class DeliveryType
    {
        public DeliveryType()
        {
            Id = String.Empty;
            Name = string.Empty;
            DescriptionHtml = string.Empty;
        }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string DescriptionHtml { get; set; }

        [DataMember]
        public double Price { get; set; }
    }
}