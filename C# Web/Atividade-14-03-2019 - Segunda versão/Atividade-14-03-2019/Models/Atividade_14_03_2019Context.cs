using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Atividade_14_03_2019.Models
{
    public class Atividade_14_03_2019Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Atividade_14_03_2019Context() : base("name=Atividade_14_03_2019Context")
        {
        }

        public System.Data.Entity.DbSet<Atividade_14_03_2019.Models.Autor> Autors { get; set; }
    }
}
