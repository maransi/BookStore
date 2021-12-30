using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("api")]
    public class TesteController : Controller
    {
        public string Index( int id)
        {
            return "Index -> " + id.ToString();
        }
/*        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }
*/
        public JsonResult Teste()
        {
            var autor = new Autor{
                Id = 1,
                Nome = "Marco Antonio"
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }

        public JsonResult UmaCoisa(int? id, string nome)
        {
            var autor = new Autor
            {
                Id = 0,
                Nome = nome
            };

            return Json(autor, JsonRequestBehavior.AllowGet);


        }


        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois( Autor autor)
        {
            return Json(autor);
        }


        public ViewResult Dados()
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "MARCO"
            };

            ViewBag.Categoria = "Produtos de Limpeza";
            ViewData["Categoria"] = "Produtos de Informática";
            TempData["Categoria"] = "Produtos de Escritória";
            Session["Categoria"] = "Móveis";

            return View( autor );
        }

        [Route("~/minharota/{id:int}")]
        public string MinhaAction(int? id)
        {
            return "MinhaAction";
        }

        [Route("rota/{categoria:alpha:minlength(3)}")]
        public string MinhaAction3( string categoria)
        {
            return "MinhaAction3 " + categoria;
        }

        [Route("rota/estacao/{estacao:Values(primavera|outono|verao|inverno)}")]
        public string MinhaAction4(string estacao)
        {
            return "Olá, estamos no " + estacao;
        }

    }
}