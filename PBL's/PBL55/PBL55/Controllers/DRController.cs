using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PBL55;

namespace PBL55.Controllers
{
    public class DRController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: DR
        public ActionResult Index()
        {
            var doencaRemedioSet = db.DoencaRemedioSet.Include(d => d.Doenca).Include(d => d.Remedio);
            return View(doencaRemedioSet.ToList());
        }

        public ActionResult ResultadoBusca(string pesquisa)
        {
            var nomeDoenca = db.DoencaSet.Include(d => d.Id).Where(d => d.Nome == pesquisa);

            var nomeRemedio = db.RemedioSet.Where(re => re.ReceitaId);
            var nomeMedico = db.ReceitaSet.Include(r => r.Medico);

            var acharNomeMedico = db.DoencaRemedioSet.Where(d => d.Remedio.ReceitaId == 1);
            ViewBag.RetornoNome = pesquisa;
            var doencaRemedioSet = db.DoencaRemedioSet.Include(d => d.Doenca).Include(d => d.Remedio);
        
            return View(doencaRemedioSet.ToList());
        }

        // GET: DR/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoencaRemedio doencaRemedio = db.DoencaRemedioSet.Find(id);
            if (doencaRemedio == null)
            {
                return HttpNotFound();
            }
            return View(doencaRemedio);
        }

        // GET: DR/Create
        public ActionResult Create()
        {
            ViewBag.DoencaId = new SelectList(db.DoencaSet, "Id", "Nome");
            ViewBag.RemedioId = new SelectList(db.RemedioSet, "Id", "Nome");
            return View();
        }

        // POST: DR/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RemedioId,DoencaId,Gravidade")] DoencaRemedio doencaRemedio)
        {
            Remedio r = db.RemedioSet.Find(doencaRemedio.Id);
            Doenca d = db.DoencaSet.Find(doencaRemedio.Id);
            

            if (ModelState.IsValid)
            {
                db.DoencaRemedioSet.Add(doencaRemedio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DoencaId = new SelectList(db.DoencaSet, "Id", "Nome", doencaRemedio.DoencaId);
            ViewBag.RemedioId = new SelectList(db.RemedioSet, "Id", "Nome", doencaRemedio.RemedioId);
            return View(doencaRemedio);
        }

        // GET: DR/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoencaRemedio doencaRemedio = db.DoencaRemedioSet.Find(id);
            if (doencaRemedio == null)
            {
                return HttpNotFound();
            }
            ViewBag.DoencaId = new SelectList(db.DoencaSet, "Id", "Nome", doencaRemedio.DoencaId);
            ViewBag.RemedioId = new SelectList(db.RemedioSet, "Id", "Nome", doencaRemedio.RemedioId);
            return View(doencaRemedio);
        }

        // POST: DR/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RemedioId,DoencaId,Gravidade")] DoencaRemedio doencaRemedio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doencaRemedio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DoencaId = new SelectList(db.DoencaSet, "Id", "Nome", doencaRemedio.DoencaId);
            ViewBag.RemedioId = new SelectList(db.RemedioSet, "Id", "Nome", doencaRemedio.RemedioId);
            return View(doencaRemedio);
        }

        // GET: DR/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoencaRemedio doencaRemedio = db.DoencaRemedioSet.Find(id);
            if (doencaRemedio == null)
            {
                return HttpNotFound();
            }
            return View(doencaRemedio);
        }

        // POST: DR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoencaRemedio doencaRemedio = db.DoencaRemedioSet.Find(id);
            db.DoencaRemedioSet.Remove(doencaRemedio);
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
