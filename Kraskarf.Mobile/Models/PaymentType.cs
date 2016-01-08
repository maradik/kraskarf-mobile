﻿using System.Runtime.Serialization;

namespace Kraskarf.Mobile.Models
{
    [DataContract]
    public class PaymentType
    {
        public PaymentType()
        {
            Id = string.Empty;
            Name = string.Empty;
        }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}