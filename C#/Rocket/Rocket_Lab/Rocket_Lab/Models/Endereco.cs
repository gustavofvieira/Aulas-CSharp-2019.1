using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rocket_Lab.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public int Cep { get; set; } 
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}