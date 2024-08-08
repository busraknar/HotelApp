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
        public string RoomImage { get; set; }
        public string RoomDescription { get; set; }
        public Hotel? Hotel { get; set; }
        public RoomType? RoomType { get; set; }

    }
}
