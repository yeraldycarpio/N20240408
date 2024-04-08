using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N20240408.EntidadesDeNegocio;
using N20240408.AccesoADatos;
using N20240408.LogicaDeNegocio;



namespace N20240408.UI.AppWebMVC.Controllers
{
    public class PersonasNController : Controller
    {
        // GET: PersonasNController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonasNController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonasNController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonasNController/Create
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

        // GET: PersonasNController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonasNController/Edit/5
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

        // GET: PersonasNController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonasNController/Delete/5
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
