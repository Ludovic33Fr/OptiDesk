using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OptiDesk.User.Bll;
using OptiDesk.User.Dto.Pivot;

namespace OptiDesk.Front.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (UserService svc = new UserService())
            {
                var model = svc.GetAllClients();
                return View(model);
            }
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            using (UserService svc = new UserService())
            {
                var model = svc.GetClient(id);
                return View(model);
            }
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
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

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            using (UserService svc = new UserService())
            {
                var model = svc.GetClient(id);
                return View(model);
            }
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Client model)
        {
            try
            {
                using (UserService svc = new UserService())
                {
                    bool isValid = svc.UpdateClient(id, model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            using (UserService svc = new UserService())
            {
                var model = svc.GetClient(id);
                return View(model);
            }
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                using (UserService svc = new UserService())
                {
                    bool isValid = svc.DeleteClient(id);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
