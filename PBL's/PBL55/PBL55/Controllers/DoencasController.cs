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
    public class DoencasController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: Doencas
        public ActionResult Index()
        {
            return View(db.DoencaSet.ToList());
        }

        // GET: Doencas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doenca doenca = db.DoencaSet.Find(id);
            if (doenca == null)
            {
                return HttpNotFound();
            }
            return View(doenca);
        }

        // GET: Doencas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doencas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Causa,Sintoma")] Doenca doenca)
        {
            if (ModelState.IsValid)
            {
                db.DoencaSet.Add(doenca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doenca);
        }

        // GET: Doencas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doenca doenca = db.DoencaSet.Find(id);
            if (doenca == null)
            {
                return HttpNotFound();
            }
            return View(doenca);
        }

        // POST: Doencas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Causa,Sintoma")] Doenca doenca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doenca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doenca);
        }

        // GET: Doencas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doenca doenca = db.DoencaSet.Find(id);
            if (doenca == null)
            {
                return HttpNotFound();
            }
            return View(doenca);
        }

        // POST: Doencas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doenca doenca = db.DoencaSet.Find(id);
            db.DoencaSet.Remove(doenca);
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
