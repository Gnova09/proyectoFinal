using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RYSE.WEB.Controllers
{
    public class EmployerController : Controller
    {
        // GET: EmployerController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmployerController1/Details/5
        public ActionResult Details(int id)
        {
            Models.Employer employer = new Models.Employer();
            
           
            return View();
        }

        // GET: EmployerController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployerController1/Create
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

        // GET: EmployerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployerController1/Edit/5
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

        // GET: EmployerController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployerController1/Delete/5
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
