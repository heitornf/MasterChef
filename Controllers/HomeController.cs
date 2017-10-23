using MasterChef.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterChef.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexCadastroReceita(string prCadastroReceita)
        {
            return View();
        }

        public ActionResult IndexCadastroCategoria(string prCadastroCategoria)
        {
            return View();
        }
        [HttpPost]
        public ActionResult IndexCadastroReceita(FormCollection collection)
        {
            var receita = new Receita();
            TryUpdateModel(receita);
            var recrep = new Repository.ReceitaRepository();
            recrep.Incluir(receita);
            return RedirectToAction("IndexListarReceita");
        }
        [HttpPost]
        public ActionResult IndexCadastroCategoria(FormCollection collection)
        {
            var categ = new Categoria();
            TryUpdateModel(categ);
            var catrep = new Repository.CategoriaRepository();
            catrep.Incluir(categ);
            return RedirectToAction("IndexListarCategoria");
        }

        public ActionResult IndexListarReceita(string prCadastroReceita)
        {
            List<Receita> ReceitaCollection = new List<Receita>();
            var recrep = new Repository.ReceitaRepository();
            ReceitaCollection = recrep.Listar().ToList();
            return View(ReceitaCollection);
        }

        public ActionResult IndexListarCategoria(string prCadastroReceita)
        {
            List<Categoria> CategoriaCollection = new List<Categoria>();
            var catrep = new Repository.CategoriaRepository();
            CategoriaCollection = catrep.Listar().ToList();
            return View(CategoriaCollection);
        }
    }
}