using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendaArte.Models
{
    public class Quadro
    {
        public int QuadroId { get; set; }
        public string Autor { get; set; }
        public int AnoLancamento { get; set; }
        public string Descricao { get; set; }
    }
}