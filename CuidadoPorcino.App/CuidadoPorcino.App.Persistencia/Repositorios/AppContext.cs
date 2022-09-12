using Microsoft.EntityFrameworkCore;
using CuidadoPorcino.App.Dominio;
namespace CuidadoPorcino.App.Persistencia
{
  public class AppContext:DbContext
  {
    public DbSet<Cerdo> Cerdos{get; set;}
    public DbSet<ControlSignos> ControlSignos{get; set;}
    public DbSet<HistoriaClinica> HistoriaClinicas{get; set;}
    public DbSet<Persona> Personas{get; set;}
    public DbSet<Propietario> Propietarios{get; set;}
    public DbSet<Recomendacion> Recomendaciones{get; set;}
    public DbSet<Veterinario> Veterinarios{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
       if(!optionsBuilder.IsConfigured)// configuracion de la base de datos
       {
        optionsBuilder
<<<<<<< HEAD
        .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CuidadoPorcino.V-1.0;Integrated Security=True");
=======
        //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=CuidadoPorcinoMejorada");
        .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CuidadoPorcinoMejorada;Integrated Security=True");
>>>>>>> Rama-Juank
       }
     }

  }

}