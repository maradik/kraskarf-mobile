namespace Kraskarf.Mobile.Models
{
    public class PaymentType
    {
        public PaymentType()
        {
            Name = string.Empty;
            DescriptionHtml = string.Empty;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionHtml { get; set; }
    }
}