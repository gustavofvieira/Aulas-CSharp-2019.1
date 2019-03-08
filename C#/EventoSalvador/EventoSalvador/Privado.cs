using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoSalvador
{
    class Privado:Evento
    {
        public int QuantidadeMaxPessoas { get; set; }
        public double Valor { get; set; }

        public override bool autorizar(int idade)
        {
            if (base.autorizar(idade))//base é o super do java, chama o metódo da classe mãe
            {
                if (idade < 18 )
                {
                    Valor = Valor / 2;
                    return true;
                }
            }
            return false;
            //return base.autorizar(idade);
        }
    }
}
