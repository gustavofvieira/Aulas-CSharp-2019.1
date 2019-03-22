using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atividade_14_03_2019.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Aquarela { get; set; }


        public string PintaAquarela(bool Aquarela)
        {
            string result;
            if (Aquarela == true) result = "sim";
            else result = "não";
            return result;

        }

    }
}