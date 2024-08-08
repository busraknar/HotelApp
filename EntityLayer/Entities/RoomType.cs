using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public double RoomPrice { get; set; }
        public virtual List<Room>? Rooms { get; set; }

    }
}