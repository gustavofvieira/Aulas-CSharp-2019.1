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
        }
    }
}
