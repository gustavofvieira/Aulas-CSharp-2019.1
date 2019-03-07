using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Pessoa
    {
        private string nome;
        private int idade;
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public string getNome() { return nome; }
        //public string getIdade() { return idade; }

       
    }
}
