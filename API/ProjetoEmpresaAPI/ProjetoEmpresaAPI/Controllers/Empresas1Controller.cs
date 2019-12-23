using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;
using Newtonsoft.Json.Linq;
using ProjetoEmpresaAPI.Models;

namespace ProjetoEmpresaAPI.Controllers
{
    public class Empresas1Controller : ApiController
    {
        private ProjetoEmpresaAPIContext db = new ProjetoEmpresaAPIContext();

        // GET: api/Empresas1
        public HttpResponseMessage GetEmpresas()
        {
            return
                new HttpResponseMessage() {
                    Content = new StringContent(JArray.FromObject(db.Empresas).ToString(),
                    Encoding.UTF8, "application/json")
                    
                };
        }

        // GET: api/Empresas1/5
        [ResponseType(typeof(Empresa))]
        public IHttpActionResult GetEmpresa(int id)
        {
            Empresa empresa = db.Empresas.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }

            return Ok(empresa);
        }

        // PUT: api/Empresas1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmpresa(int id, Empresa empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empresa.EmpresaId)
            {
                return BadRequest();
            }

            db.Entry(empresa).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpresaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Empresas1
        [ResponseType(typeof(Empresa))]
        public IHttpActionResult PostEmpresa(Empresa empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Empresas.Add(empresa);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empresa.EmpresaId }, empresa);
        }

        // DELETE: api/Empresas1/5
        [ResponseType(typeof(Empresa))]
        public IHttpActionResult DeleteEmpresa(int id)
        {
            Empresa empresa = db.Empresas.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }

            db.Empresas.Remove(empresa);
            db.SaveChanges();

            return Ok(empresa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmpresaExists(int id)
        {
            return db.Empresas.Count(e => e.EmpresaId == id) > 0;
        }
    }
}