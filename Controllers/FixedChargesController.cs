using AALEKH_SOCIETY_COOP.Areas.Identity.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AALEKH_SOCIETY_COOP.Controllers
{
    public class FixedChargesController : Controller
    {
        private readonly ICommon _common;
        private readonly ApplicationDbContext _context;
        public FixedChargesController(ICommon common, ApplicationDbContext context)
        {
            _common = common;
            _context = context;
        }

        // GET: FixedChargesController

        public async Task<IActionResult> Index()
        {
            var charges = await _common.GetFixedCharges();
            return View(charges);
        }

        // GET: FixedChargesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FixedChargesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FixedChargesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Type,FixedCharge,Status")] FixedCharges charges)
        {   
            charges.Updatedon = DateTime.Now;
            if (ModelState.IsValid)
            {
                await _common.AddFixedCharges(charges);
                return RedirectToAction(nameof(Index));
            }
            return View(charges);
        }

        // GET: FixedChargesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FixedChargesController/Edit/5
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

        // GET: FixedChargesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FixedChargesController/Delete/5
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
