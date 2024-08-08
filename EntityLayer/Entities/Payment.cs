using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int BookingId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public int CreditCardNo { get; set; }
        public string ExpireDate { get; }
    }
}
