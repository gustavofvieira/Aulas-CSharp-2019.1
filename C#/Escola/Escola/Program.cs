using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbeiro barbeiro1 = new Barbeiro();
            barbeiro1.Nome = "Eliel";
            barbeiro1.Sexo = "M";
            barbeiro1.Idade = 25;
            barbeiro1.Especialidade = 0;
            // Console.WriteLine("_________ Barbearia do seu zé__________");
            // Console.WriteLine("Nome: "+barbeiro.Nome);
            // Console.WriteLine("Sexo: " + barbeiro.Sexo);
            // Console.WriteLine("Idade: " + barbeiro.Idade);
            // Console.WriteLine("Especialidade: " + barbeiro.Especialidade);
            /* barbeiros[0] = barbeiro1;
             barbeiros[1] = new Barbeiro();
             barbeiros[1].Nome = "Lia";
             barbeiros[1].Sexo = "F";
             barbeiros[1].Idade = 32;
             barbeiros[1].Especialidade = (Escola.funcao)2;*/

            Console.WriteLine("Quantos barbeiros quer cadastrar?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            Barbeiro[] barbeiros = new Barbeiro[n];
            for (int i = 0; i < n; i++)
            {
                barbeiros[i] = new Barbeiro();//estanciando a posição para que o vetor intere
                Console.WriteLine("Barbeiro "+(i+1));
                Console.WriteLine("Nome: ");
                barbeiros[i].Nome = Console.ReadLine();
                Console.WriteLine("Sexo: ");
                barbeiros[i].Sexo = Console.ReadLine();
                Console.WriteLine("Idade: ");
                barbeiros[i].Idade = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Especialidade - 0: design_somb - 1: tesoura - 2: maquina  ");
                int especialidade = int.Parse(Console.ReadLine());
                barbeiros[i].Especialidade = (Escola.funcao)especialidade;
               


            }
            foreach (var barbeiro in barbeiros)
            {
                Console.WriteLine("Nome: "+barbeiro.Nome);
                Console.WriteLine("Sexo: " + barbeiro.Sexo);
                Console.WriteLine("Idade: " + barbeiro.Idade);
                Console.WriteLine("Especialidade: " + barbeiro.Especialidade);
                Console.WriteLine("\n");
            }



        }
    }
}
