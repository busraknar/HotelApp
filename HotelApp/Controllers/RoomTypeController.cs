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
            if (ModelState.IsValid)
            {
                _context.RoomTypes.Add(gelen);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]

        public IActionResult Edit(int id)
        {
            var tek = _context.RoomTypes.Find(id);
            return View(tek);
        }
    }
}
