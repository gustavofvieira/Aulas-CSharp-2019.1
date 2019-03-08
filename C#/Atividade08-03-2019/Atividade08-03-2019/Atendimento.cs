using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08_03_2019
{
    class Atendimento
    {
        public bool Status { get; set; }
        public string DataHora { get; set; }
        public double Valor { get; set; }

        public double calcDesconto(Cliente cliente)
        {
            string mesAtend = DataHora.Substring(3,2);//o primeiro parametro é o indice o segundo é quantas casas quer pergar depois do indice
            string mesNasc = cliente.DtNasc.Substring(3,2);

            if (mesNasc == mesAtend)
            {
                double desconto;
                desconto = Valor * 0.1;
                Valor = Valor - desconto;
                return Valor;
            }
            return Valor;
        }

       
    }
}
