using System;
using System.ComponentModel.DataAnnotations;
namespace   CuidadoPorcino.App.Dominio
{
    public class Veterinario
    {    [Key]
        public int IdVeterinario {get; set;}
        public string TarjetaProfesional {get; set;}       
    }
}