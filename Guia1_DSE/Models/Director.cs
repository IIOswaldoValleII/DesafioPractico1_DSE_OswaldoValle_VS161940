using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDirector.Models
{
    public class Director
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }
    }

    
    public class DirectorDBContext : DbContext
    {
        public DbSet<Director> Directores { get; set; }
    }

}