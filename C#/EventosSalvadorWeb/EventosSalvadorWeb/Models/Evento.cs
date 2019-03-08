using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosSalvadorWeb.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        public int Classificacao { get; set; }
    }
}