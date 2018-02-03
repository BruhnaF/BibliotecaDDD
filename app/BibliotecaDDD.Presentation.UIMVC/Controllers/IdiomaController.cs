using BibliotecaDDD.Domain.Contracts.Application;
using BibliotecaDDD.Domain.Entities;
using BibliotecaDDD.Presentation.UIMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaDDD.Presentation.UIMVC.Controllers
{
    public class IdiomaController : Controller
    {
        private readonly IdiomaAppContrato _idiomaApp;

        public IdiomaController(IdiomaAppContrato idiomaApp)
        {
            _idiomaApp = idiomaApp;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var listaIdioma = _idiomaApp.BuscarTodos();
            return View();
        }

        [HttpGet]
        public ActionResult Salvar()
        {
            var idiomaView = new IdiomaViewModel();
            return View(idiomaView);
        }

        [HttpPost]
        public ActionResult Salvar(IdiomaViewModel idiomaView)
        {
            var idioma = new Idioma();

            idioma = new Idioma
            {
                IdiomaId = idiomaView.idiomaId,
                Nome = idiomaView.nome
            };

            return View();
        }
    }
}