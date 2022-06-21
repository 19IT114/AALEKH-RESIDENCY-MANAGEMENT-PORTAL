using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AALEKH_SOCIETY_COOP.Controllers
{
    [Authorize]
    public class BillController : Controller
    {
        private readonly ICommon _common;
        public BillController(ICommon common)
        {
            _common = common;
        }
        // GET: BillController
        public async Task<IActionResult> Index(int id)
        {
            var resident = await _common.GetResidentsById(id);
            ViewBag.blockno = resident.Block_no;
            ViewBag.Resident_name = resident.Owner_name;
            var maintainence = await _common.GetFixedChargesbyId(1);
            ViewBag.Maintainence = (maintainence.Status == true)?maintainence.FixedCharge:0;
            maintainence = await _common.GetFixedChargesbyId(2);
            ViewBag.Cleaning = (maintainence.Status == true)?maintainence.FixedCharge:0;
           
            return View();
        }

        // GET: BillController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BillController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: BillController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillController/Edit/5
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

        // GET: BillController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillController/Delete/5
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
        
        public async Task<IActionResult> PrintBill(string id)
        {

            BillDetails details = new BillDetails();
            details.fromMonth = Convert.ToDateTime(id.Split(",")[0]).ToString("Y");
            details.toMonth = Convert.ToDateTime(id.Split(",")[1]).ToString("Y");
            details.recievedDate = Convert.ToDateTime(id.Split(",")[2]).ToString("dd/MM/yyyy");
            details.maintainence = Convert.ToInt32(id.Split(",")[3]);
            details.cleaning = Convert.ToInt32(id.Split(",")[4]);
            details.Bank = id.Split(",")[5];
            details.Branch = id.Split(",")[6];
            details.chequeOnlineNum = id.Split(",")[7];

            return View("Views/Bill/Print.cshtml", details);
        }

    }
    public class BillDetails
    {
        public string? Bank { get; set; }
        public string? Branch { get; set; }
        public string? fromMonth { get; set; }  
        public string? toMonth { get; set; }
        public string? recievedDate { get; set; }
        public string? chequeOnlineNum { get; set; }
        public int? maintainence { get; set; }
        public int? cleaning { get; set; }
       
    }
}
