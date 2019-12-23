using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpresaAPIConsome.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ramo { get; set; }
        public string Cnpj { get; set; }
        public string Slogan { get; set; }
        public string Foto { get; set; }
        public enum Portes { Pequeno, Medio, Grande }
        public Portes Porte { get; set; } 
    }
}