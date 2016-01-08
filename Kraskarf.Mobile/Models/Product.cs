﻿namespace Kraskarf.Mobile.Models
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
            DescriptionHtml = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionHtml { get; set; }
        public double Price { get; set; }
    }
}