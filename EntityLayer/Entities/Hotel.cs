using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelIName { get; set; } = string.Empty;
        public string HotelDescription { get; set; } = string.Empty;
        public string HotelAddress { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public int PostCode { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;

        public virtual List<Room>? Rooms { get; set; }
        public virtual List<Employee>? Employees { get; set; }



    }
}
