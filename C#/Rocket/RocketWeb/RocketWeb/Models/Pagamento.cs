using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rocket_Lab.Models
 {
    //public enum tipo_pagamento { dinheiro, cartao, boleto, cheque }
    public class Pagamento
    {
        public int PagamentoId { get; set; }
      //  public tipo_pagamento Tipo_Pagamento { get; set; }
        public string Cartao { get; set; }
        public string Dinheiro  { get; set; }
        public string Boleto { get; set; }
        public string Cheque { get; set; }

    }
}