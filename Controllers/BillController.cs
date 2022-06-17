﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AALEKH_SOCIETY_COOP.Controllers
{
    public class BillController : Controller
    {
        // GET: BillController
        public ActionResult Index()
        {
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

            Residents details = new Residents();
            details.fromMonth = Convert.ToDateTime(id.Split(",")[0]).ToString("Y");
            details.toMonth = Convert.ToDateTime(id.Split(",")[1]).ToString("Y");
            details.recievedDate = Convert.ToDateTime(id.Split(",")[2]).ToString("dd/MM/yyyy");
            details.Bank = id.Split(",")[3];
            details.Branch = id.Split(",")[4];
            details.chequeOnlineNum = id.Split(",")[5];

            return View("Views/Bill/Print.cshtml", details);
        }

    }
    public class Residents
    {
        public string? Bank { get; set; }
        public string? Branch { get; set; }

        public string? fromMonth { get; set; }  
        public string? toMonth { get; set; }

        public string? recievedDate { get; set; }

        public string? chequeOnlineNum { get; set; }
       
    }
}
