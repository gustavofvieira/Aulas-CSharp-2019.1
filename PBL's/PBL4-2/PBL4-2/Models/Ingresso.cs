using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBL4_2.Models
{
    public enum Tipo { Comum, VIP }
    public class Ingresso
    {
        public int IngressoId { get; set; }
        public double Valor { get; set; }
        public Tipo Tipo { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        public int BilheteriaId { get; set; }
        public Bilheteria Bilheteria { get; set; }

        public bool Free { get; set; } // propriedade de quem só é vip vai ser true


    }
}