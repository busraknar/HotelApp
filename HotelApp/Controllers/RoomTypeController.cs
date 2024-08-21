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
            RoomType corrected = _context.RoomTypes.Where
               (u => u.RoomTypeId == id).FirstOrDefault();

            // var tek = _context.RoomTypes.Find(id);

            if (corrected == null)
            {
                return NotFound();
            }
            return View(corrected);
        }

        [HttpPost]

        public IActionResult Edit(RoomType gelen)
        {
            if (ModelState.IsValid && gelen.RoomTypeId > 0)
            {
                _context.RoomTypes.Update(gelen);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            RoomType? corrected = _context.RoomTypes.Where
               (u => u.RoomTypeId == id).FirstOrDefault();

            if (corrected == null)
            {
                return NotFound();
            }
            return View(corrected);
        }

        [HttpPost]

        public IActionResult Delete(RoomType gelen)
        {
            RoomType? deleted = _context.RoomTypes.Where
            (u => u.RoomTypeId == gelen.RoomTypeId).FirstOrDefault();

            if (deleted != null)
            {
                _context.RoomTypes.Remove(deleted);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
