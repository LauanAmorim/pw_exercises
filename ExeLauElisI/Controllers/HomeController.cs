using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeLauElisI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult RedirectTempAluno()
        {
            TempData["MVCPattern"] = "O MVC é um padrão de desenvolvimento muito utilizado no mundo web é conhecido por 'forçar' o programador a separar as responsabilidades.";
            return RedirectToAction("Aluno", "Aula");
        }
    }
}