using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pbl4Novamente.Models;

namespace Pbl4Novamente.Controllers
{
    public class IngressosController : Controller
    {
        private Pbl4NovamenteContext db = new Pbl4NovamenteContext();

        // GET: Ingressos
        public ActionResult Index()
        {
            int cont = db.Ingressoes.Count();
            ViewBag.Contador = cont;

            var ingressoes = db.Ingressoes.Include(i => i.Bilheteria).Include(i => i.Cliente).Include(i => i.Evento);
            return View(ingressoes.ToList());
        }

        public ActionResult ResultadoBusca(string pesquisa)
        {


            ViewBag.RetornoNome = pesquisa;
            var ingressoes = db.Ingressoes.Include(i => i.Bilheteria).Where(i => i.Cliente.Nome == pesquisa).Include(i => i.Evento);
            int cont = ingressoes.Count();
            ViewBag.Contador = cont;
            
            return View(ingressoes.ToList());
        }

        // GET: Ingressos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingresso ingresso = db.Ingressoes.Find(id);
            if (ingresso == null)
            {
                return HttpNotFound();
            }
            return View(ingresso);
        }

        // GET: Ingressos/Create
        public ActionResult Create()
        {
            ViewBag.BilheteriaId = new SelectList(db.Bilheterias, "BilheteriaId", "Nome");
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome");
            ViewBag.EventoId = new SelectList(db.Eventoes, "EventoId", "Nome");
            return View();
        }

        // POST: Ingressos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IngressoId,Valor,Tipo,ClienteId,EventoId,BilheteriaId,Free")] Ingresso ingresso)
        {
            if (ModelState.IsValid)
            {
                Cliente c = db.Clientes.Find(ingresso.ClienteId);
                Evento e = db.Eventoes.Find(ingresso.EventoId);
                //  Ingresso i = db.Ingressoes.Find(ingresso.IngressoId);
                if (e.Restricao == true && c.Idade > 18 || e.Restricao == false && c.Idade > 18 || e.Restricao == false && c.Idade < 18) {
                    if (ingresso.Tipo.ToString() == "VIP")
                    {
                        ingresso.Free = true;
                        db.Ingressoes.Add(ingresso);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ingresso.Free = false;
                        db.Ingressoes.Add(ingresso);
                        db.SaveChanges();
                        return RedirectToAction("Index");

                    }
                }

               
               if (e.Restricao == true && c.Idade < 18)
                {
                   ViewBag.AvisoIdade = "Evento restrito para menor de idade, COMPRA NÃO EFETUADA";
               }

            }


            ViewBag.BilheteriaId = new SelectList(db.Bilheterias, "BilheteriaId", "Nome", ingresso.BilheteriaId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome", ingresso.ClienteId);
            ViewBag.EventoId = new SelectList(db.Eventoes, "EventoId", "Nome", ingresso.EventoId);
            return View(ingresso);
        }

        // GET: Ingressos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingresso ingresso = db.Ingressoes.Find(id);
            if (ingresso == null)
            {
                return HttpNotFound();
            }
            ViewBag.BilheteriaId = new SelectList(db.Bilheterias, "BilheteriaId", "Nome", ingresso.BilheteriaId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome", ingresso.ClienteId);
            ViewBag.EventoId = new SelectList(db.Eventoes, "EventoId", "Nome", ingresso.EventoId);
            return View(ingresso);
        }

        // POST: Ingressos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IngressoId,Valor,Tipo,ClienteId,EventoId,BilheteriaId,Free")] Ingresso ingresso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingresso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BilheteriaId = new SelectList(db.Bilheterias, "BilheteriaId", "Nome", ingresso.BilheteriaId);
            ViewBag.ClienteId = new SelectList(db.Clientes, "ClienteId", "Nome", ingresso.ClienteId);
            ViewBag.EventoId = new SelectList(db.Eventoes, "EventoId", "Nome", ingresso.EventoId);
            return View(ingresso);
        }

        // GET: Ingressos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingresso ingresso = db.Ingressoes.Find(id);
            if (ingresso == null)
            {
                return HttpNotFound();
            }
            return View(ingresso);
        }

        // POST: Ingressos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ingresso ingresso = db.Ingressoes.Find(id);
            db.Ingressoes.Remove(ingresso);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
