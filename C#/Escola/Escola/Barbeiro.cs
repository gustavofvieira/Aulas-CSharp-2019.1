using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public enum funcao { design_somb, tesoura, maquina}
    public class Barbeiro
    {
        public string Nome { get; set; }//metódo do atribunto, já contém o atributo nome
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public funcao Especialidade { get; set; }
    }
}
