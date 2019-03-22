using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atividade_14_03_2019.Models
{
    public class Quadro
    {
        public int QuadroId { get; set; }
        public Autor Autor { get; set; }
        public int AnoLancamento { get; set; }
        public string Descricao { get; set; }


    }
}