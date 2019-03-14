using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rocket_Lab.Models
{
    public class Pessoa
    {
        public string Nome { get; protected set; }
        public int Cpf { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }
        public int Telefone { get; protected set; }
        public Endereco Endereco { get; protected set; }

    }
}