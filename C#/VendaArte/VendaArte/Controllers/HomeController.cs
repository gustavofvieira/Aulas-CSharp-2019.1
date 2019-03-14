using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendaArte.Models;

namespace VendaArte.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ExpoQuadro()
        {
            ViewBag.Quadro = "Quadro Bonito!.";
            List<Quadro> quadros = new List<Quadro>();
            Quadro quadro1 = new Quadro();
            quadro1.Autor = "Gustavo";
            quadro1.AnoLancamento = 2019;
            quadro1.Descricao = "Quadro de rede";
            
            Quadro quadro2 = new Quadro();
            quadro2.Autor = "Bruno";
            quadro2.AnoLancamento = 2019;
            quadro2.Descricao = "Quadro de musica";

            Quadro quadro3 = new Quadro();
            quadro3.Autor = "Vacca";
            quadro3.AnoLancamento = 2019;
            quadro3.Descricao = "Quadro de pizza";

            quadros.Add(quadro1);
            quadros.Add(quadro2);
            quadros.Add(quadro3);

            ViewBag.Quadros = quadros;// passando o Array pra viewbag

            return View();
        }
    }
}