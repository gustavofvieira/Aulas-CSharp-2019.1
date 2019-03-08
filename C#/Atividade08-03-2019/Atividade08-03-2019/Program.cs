using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08_03_2019
{
    /*1 - Criar um sistema para armezenar informações sobre clientes e funcionarios de uma loja.
     * Ambos serão cadastrados com nome, cpf, telefone. O funcionário terá alem destes atributos, o status de ocupado, q acontecerá assim que um Atendimento for registrado como aberto. Atendimento tem Status, data/hora e valor final. 
      O cliente consegue um desconto de 10%, caso o mês atual seja igual ao mês de aniversário dele (atributo extra do Cliente).*/
    class Program
    {
        static void Main(string[] args)
        {
            Atendimento atend = new Atendimento();
            Cliente cli = new Cliente();
            Funcionario func = new Funcionario();

            func.Nome = "Alfredo";
            //func.StatusOcupado = true;
            cli.Nome = "Eike";
            atend.Status = true;
            if (atend.Status)
            {
                func.StatusOcupado = true;
            }
            cli.DtNasc = "25/11/1996";
            atend.DataHora = "08/11/2019";
            atend.Valor = 10;
            atend.calcDesconto(cli);
            Console.WriteLine(atend.Valor);
            Console.WriteLine(atend.Status);

           // string mesAtend = atend.DataHora.Substring(3,2);
           // string mesNasc = cli.DtNasc.Substring(3,2);
           // Console.WriteLine(mesAtend+" "+mesNasc);










        }
    }
}
