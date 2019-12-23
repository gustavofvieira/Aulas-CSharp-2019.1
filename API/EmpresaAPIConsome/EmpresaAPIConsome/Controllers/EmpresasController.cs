using EmpresaAPIConsome.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace EmpresaAPIConsome.Controllers
{
    public class EmpresasController : Controller
    {
        string uri = "http://localhost:54256/api/Empresas1";
        public async Task<List<Empresa>> GetEmpresas()
        {
            List<Empresa> empresas;
            using (var client = new HttpClient())
            {
                using(var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var empresaJson = await response.Content.ReadAsStringAsync();
                        empresas = JsonConvert.DeserializeObject<Empresa[]>(empresaJson).ToList();
                        return empresas;
                    }
                }
            }
            return null;
        }
       
        public async Task<ActionResult> ListEmpresas()
        {
            List<Empresa> empresa =  await GetEmpresas();
            return View(empresa);
        }
        //
      
    }
}
