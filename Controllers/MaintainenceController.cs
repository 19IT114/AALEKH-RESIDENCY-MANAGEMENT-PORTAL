using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AALEKH_SOCIETY_COOP.Controllers
{
    public class MaintainenceController : Controller
    {
        // GET: MaintainenceController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: MaintainenceController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MaintainenceController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MaintainenceController1/Create
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

        // GET: MaintainenceController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MaintainenceController1/Edit/5
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

        // GET: MaintainenceController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MaintainenceController1/Delete/5
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
