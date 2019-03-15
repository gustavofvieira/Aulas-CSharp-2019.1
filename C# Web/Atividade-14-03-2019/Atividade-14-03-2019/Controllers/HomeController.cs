using Atividade_14_03_2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atividade_14_03_2019.Controllers
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
        public ActionResult Autor()
        {
            List<Autor> autores = new List<Autor>();

            Autor a1 = new Autor();
            a1.Nome = "Gustavo";
            a1.Cpf = "000";
            a1.Aquarela = true;
            a1.PintaAquarela(true);
            Autor a2 = new Autor();
            a2.Nome = "Gildete";
            a2.Cpf = "111";
            a2.Aquarela = false;
            a2.PintaAquarela(false);
            Autor a3 = new Autor();
            a3.Nome = "Thiago";
            a3.Cpf = "222";
            a3.Aquarela = true;
            a3.PintaAquarela(true);

            autores.Add(a1);
            autores.Add(a2);
            autores.Add(a3);
            ViewBag.Autores = autores;

            return View();
        }

        public ActionResult ExpoQuadro()
        {
            ViewBag.Quadro = "Quadro Bonito!.";
            List<Quadro> quadros = new List<Quadro>();
            Quadro quadro1 = new Quadro();
            //quadro1.Autor
            quadro1.AnoLancamento = 2019;
            quadro1.Descricao = "Quadro de rede";

            Quadro quadro2 = new Quadro();
            //quadro2.Autor = "Bruno";
            quadro2.AnoLancamento = 2019;
            quadro2.Descricao = "Quadro de musica";

            Quadro quadro3 = new Quadro();
            //quadro3.Autor = "Vacca";
            quadro3.AnoLancamento = 2019;
            quadro3.Descricao = "Quadro de pizza";

            quadros.Add(quadro1);
            quadros.Add(quadro2);
            quadros.Add(quadro3);

            
            List<Autor> autores = new List<Autor>();

            Autor a1 = new Autor();
            a1.Nome = "Gustavo";
            a1.Cpf = "000";
            a1.Aquarela = true;
            //a1.PintaAquarela(true);
            Autor a2 = new Autor();
            a2.Nome = "Gildete";
            a2.Cpf = "111";
            a2.Aquarela = false;
            //a2.PintaAquarela(false);
            Autor a3 = new Autor();
            a3.Nome = "Thiago";
            a3.Cpf = "222";
            a3.Aquarela = true;
            //a3.PintaAquarela(true);

            autores.Add(a1);
            autores.Add(a2);
            autores.Add(a3);

            quadro1.Autor = a1;
            quadro2.Autor = a2;
            quadro3.Autor = a3;

            ViewBag.Autores = autores;
            ViewBag.Quadros = quadros;// passando o Array pra viewbag
            return View();
        }
    }
}