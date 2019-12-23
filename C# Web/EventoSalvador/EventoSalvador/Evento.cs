using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoSalvador
{
    class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public string DataHora { get; set; }
        public int Classificacao { get; set; }

        public virtual bool autorizar(int idade)// autoriza as classes filhas a sobrescrever o metódo
        {
            if (idade >= Classificacao)// como se tivesse pegando o getClassificacao
            {
                return true;
            }
            return false;
        }
    }
}
