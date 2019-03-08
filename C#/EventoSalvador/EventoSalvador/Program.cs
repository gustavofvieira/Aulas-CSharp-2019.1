using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoSalvador
{
    class Program
    {
        static void Main(string[] args)
        {
            Publico eventoPublico = new Publico();
            eventoPublico.Classificacao = 18;
            bool x = eventoPublico.autorizar(18);
            if (x)
            {
                Console.WriteLine("Liberado!");
            }
            else {
                Console.WriteLine("Negado!");
            }

            Privado eventoPrivado = new Privado();
            eventoPrivado.Classificacao = 16;
            eventoPrivado.Valor = 100;
            bool y = eventoPrivado.autorizar(17);
            if (y)
            {
                Console.WriteLine("Liberado");
            }
            else
            {
                Console.WriteLine("Negado");
            }
            Console.WriteLine("O valor do ingresso é: "+eventoPrivado.Valor);
            //System.Diagnostics.Process.Start("shutdown", "/s /t 6"); shutown
        }
    }
}
