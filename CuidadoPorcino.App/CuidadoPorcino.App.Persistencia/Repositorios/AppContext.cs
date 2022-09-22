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
    
    public DbSet<Veterinario> Veterinarios{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
       if(!optionsBuilder.IsConfigured)// configuracion de la base de datos
       {
        optionsBuilder
        .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CuidadoPorcino.V-1.6;Integrated Security=True");
       }
     }

  }

}