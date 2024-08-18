using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class RoomTypeController : Controller
    {
        private readonly HotelDbContext _context;

        public RoomTypeController(HotelDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var RoomTypeList = _context.RoomTypes.ToList();
            return View(RoomTypeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(RoomType gelen)
        {
            _context.RoomTypes.Add(gelen);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
