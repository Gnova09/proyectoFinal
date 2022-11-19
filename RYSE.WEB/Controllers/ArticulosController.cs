using Microsoft.AspNetCore.Mvc;
using RYSE.STOREONLINE.DAL.Interfaces;
using RYSE.WEB.Models;

namespace RYSE.WEB.Controllers
{
    public class ArticulosController : Controller
    {
        private readonly IItemRepository? ItemRepository;
        // GET: ArticulosController1
        public ActionResult Index()
        {
            var Articulo = this.ItemRepository?.GetAll().ToList().Select(st => new Models.Articulos()
            {
                Id = st.Id,
                Name = st.Name,
                Descripcion= st.Description,
                Cant= st.Cant,
                Tamano= st.Tamano             
            });

            /*IEnumerable<Articulos> Articulos = new List<Articulos>()
            {
                new Articulos
                {
                    Id=1,
                    Name="monitor",
                    Marca="LG",
                    Modelo="15sd",
                    Color="blue",
                    Tamaño=3,
                    Precio="15,000",
                    Peso=3
                }
            };*/

            return View(Articulo);
        }

        // GET: ArticulosController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArticulosController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticulosController1/Create
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

        // GET: ArticulosController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArticulosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Models.Articulos articulos = new Models.Articulos();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticulosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArticulosController1/Delete/5
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
