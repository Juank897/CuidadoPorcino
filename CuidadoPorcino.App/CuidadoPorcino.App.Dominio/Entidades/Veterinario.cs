using System;
using System.ComponentModel.DataAnnotations;
namespace CuidadoPorcino.App.Dominio
{
    public class Veterinario
    {
        [Key]
        public int IdVeterinario { get; set; }
        public string TarjetaProfesional { get; set; }
        public Persona persona { get; set; }
        public Cerdo cerdo { get; set; }
    }
}