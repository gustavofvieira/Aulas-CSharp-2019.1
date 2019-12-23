using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pbl4Novamente.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public bool Restricao { get; set; }

        public bool RestricaoMetodo(int idade)
        {
            bool ok;
            if (idade < 18)
            {
                ok = false;
            }
            else ok = true;
            return ok;
        }

    }
}