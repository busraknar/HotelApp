using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }

        [Display(Name = "Oda Adı")]
        [Required(ErrorMessage = "Oda adını boş bırakamazsınız!")]
        public string RoomName { get; set; } = string.Empty;

        [Display(Name = "Oda Fiyatı")]
        [Required(ErrorMessage = "Oda fiyatını boş bırakamazsınız!")]
        public double RoomPrice { get; set; }
        public virtual List<Room>? Rooms { get; set; }

    }
}