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
        public async Task<ActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var charge = await _common.GetFixedChargesbyId(id);
            return View(charge);
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
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var charge = await _common.GetFixedChargesbyId(id);
            return View(charge);
        }

        // POST: FixedChargesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Type,FixedCharge,Status")] FixedCharges charges)
        {

            if(id != charges.id)
            {
                return NotFound();
            }
            charges.Updatedon = DateTime.Now;
            if(ModelState.IsValid)
            {
                try
                {
                    await _common.UpdateFixedCharges(charges);
                }
                catch(Exception)
                {
                    if (!(await _common.CheckFixedChargesExists(charges.id)))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(charges);
            
        }

        // GET: FixedChargesController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var charge = await _common.GetFixedChargesbyId(id);
            return View(charge);
           
        }

        // POST: FixedChargesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var charges = await _common.GetFixedChargesbyId(id);
            if(charges != null)
            {
                await _common.RemoveFixedCharge(charges);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
