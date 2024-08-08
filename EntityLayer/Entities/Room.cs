using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public string RoomImage { get; set; } = string.Empty;
        public string RoomDescription { get; set; } = string.Empty;
        public Hotel? Hotel { get; set; }
        public RoomType? RoomType { get; set; }

        [ValidateNever]
        public virtual List<Booking>? Bookings { get; set; }
    }
}
