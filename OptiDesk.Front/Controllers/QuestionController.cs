using Microsoft.AspNetCore.Mvc;
using OptiDesk.Front.Models;

namespace OptiDesk.Front.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuestionModel model)
        {
            try
            {
                // Traitement pour enregistrer la question
                Random random = new Random(100);
                model.Id = random.Next().ToString();
                model.CreationDate = DateTime.Now;

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
