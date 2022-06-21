using AALEKH_SOCIETY_COOP.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AALEKH_SOCIETY_COOP.Controllers
{
    [Authorize]
    public class ResidentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICommon _common;
        public ResidentsController(ICommon common,ApplicationDbContext context)
        {
            _common = common;
            _context = context; 
        }

        // GET: ResidentsController
        public async Task<IActionResult> Index()
        {
            var residents = await _common.GetAllResidents();
            return View(residents);
        }

        // GET: ResidentsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResidentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResidentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Owner_name", "Mobile_no", "Is_a_Streetmember", "has_Rentals", "Initals", "Number")] Residents residents)
        {
            residents.Block_no = residents.Initals + "/" + residents.Number;
            if (ModelState.IsValid)
            {

            }
            return View(nameof(Index));
        }

        // GET: ResidentsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResidentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ResidentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResidentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
