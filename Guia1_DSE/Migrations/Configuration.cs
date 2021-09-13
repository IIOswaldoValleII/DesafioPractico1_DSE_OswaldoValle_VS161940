namespace Guia1_DSE.Migrations
{
    using MvcPelicula.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPelicula.Models.PeliculaDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcPelicula.Models.PeliculaDBContext context)
        {
            context.Peliculas.AddOrUpdate(i => i.Titulo,
  new Pelicula
  {
      Titulo = "John Wick",
      FechaLanzamiento = DateTime.Parse("2014-10-24"),
      Genero = "Accion",
      Calificacion = "D",
      Precio = 6.99M,
      productor = "Keanu Rives"
  },
  new Pelicula
  {
      Titulo = "John Wick II",
      FechaLanzamiento = DateTime.Parse("2015-10-26"),
      Genero = "Accion",
      Calificacion = "D",
      Precio = 6.99M,
      productor = "Keanu Rives"
  },
  new Pelicula
  {
      Titulo = "John Wick III",
      FechaLanzamiento = DateTime.Parse("2019-05-17"),
      Genero = "Accion",
      Calificacion = "D",
      Precio = 6.99M,
      productor = "Keanu Rives"
  },
  new Pelicula
  {
      Titulo = "Votos de Amor",
      FechaLanzamiento = DateTime.Parse("2012-02-06"),
      Genero = "Romance",
      Calificacion = "D",
      Precio = 6.99M,
      productor = "Esteban turcios"
  }
 /* new Director
  {
      Nombre = "Luis Flores",
      Edad = 56
  }*/
  );

            context.Directors.AddOrUpdate(i => i.ID, 
                new MvcPelicula.Models.Director
                {
                    Nombre = "Luis Flores",
                    Edad = 60
                }
            
            
            
            );

          

        }
       


    }
}
