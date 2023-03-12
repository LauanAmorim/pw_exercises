﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeLauElisI.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuRedirect()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Aluno()
        {
            ViewBag.MelhoresAlunos = "Os melhores alunos são aqueles que estudam mais!";
            return View();
        }
    }
}