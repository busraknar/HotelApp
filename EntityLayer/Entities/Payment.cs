using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Booking")]
        public int BookingId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public int CreditCardNo { get; set; }
        public string ExpireDate { get; } = string.Empty;
        public virtual Customer? Customer { get; set; }
        public virtual Booking? Booking { get; set; }
    }
}
