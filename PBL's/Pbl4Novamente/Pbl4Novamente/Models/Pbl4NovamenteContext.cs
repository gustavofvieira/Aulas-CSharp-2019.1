using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pbl4Novamente.Models
{
    public class Pbl4NovamenteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Pbl4NovamenteContext() : base("name=Pbl4NovamenteContext")
        {
        }

        public System.Data.Entity.DbSet<Pbl4Novamente.Models.Bilheteria> Bilheterias { get; set; }

        public System.Data.Entity.DbSet<Pbl4Novamente.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Pbl4Novamente.Models.Evento> Eventoes { get; set; }

        public System.Data.Entity.DbSet<Pbl4Novamente.Models.Ingresso> Ingressoes { get; set; }
    }
}
