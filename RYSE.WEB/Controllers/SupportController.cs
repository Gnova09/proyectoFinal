using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RYSE.WEB.Controllers
{
    public class SupportController : Controller
    {
        // GET: SupportController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: SupportController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupportController1/Create
        public ActionResult Create()
        {
            Models.Support model = new Models.Support();    
            return View();
        }

        // POST: SupportController1/Create
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

        // GET: SupportController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupportController1/Edit/5
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

        // GET: SupportController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupportController1/Delete/5
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
