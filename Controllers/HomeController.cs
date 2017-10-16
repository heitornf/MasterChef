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

        public ActionResult IndexListarReceita(string prCadastroReceita)
        {
            List<Receita> ReceitaCollection = new List<Receita>();

            return View(ReceitaCollection);
        }

        public ActionResult IndexListarCategoria(string prCadastroReceita)
        {
            List<Categoria> CategoriaCollection = new List<Categoria>();

            return View(CategoriaCollection);
        }
    }
}