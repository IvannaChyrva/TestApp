using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FacilityContext _db;

        public HomeController(ILogger<HomeController> logger, FacilityContext context)
        {
            _logger = logger;
            _db = context;
        }

        public IActionResult Index()
        {
            return View(_db.Facilities.ToList());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Facility = _db.Facilities.Where(f => f.FacilityId == id).FirstOrDefault();

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Facility facility)
        {
            var facilityToEdit = _db.Facilities.Where(f => f.FacilityId == facility.FacilityId).FirstOrDefault();

            facilityToEdit.Name = facility.Name;
            facilityToEdit.Address = facility.Address;
            facilityToEdit.PhoneNumber = facility.PhoneNumber;
            facilityToEdit.Email = facility.Email;
            facilityToEdit.FacilityStatusId = facility.FacilityStatusId;

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var facilityToRemove = _db.Facilities.Where(f => f.FacilityId == id).FirstOrDefault();

            _db.Facilities.Remove(facilityToRemove);

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Facility facility)
        {
            var newFacility = new Facility
            {
                Name = facility.Name,
                Address = facility.Address,
                PhoneNumber = facility.PhoneNumber,
                Email = facility.Email,
                FacilityStatusId = facility.FacilityStatusId != 0 ? facility.FacilityStatusId : 2
            };

            _db.Facilities.Add(newFacility);

            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
