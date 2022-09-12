using System;
using System.ComponentModel.DataAnnotations;
namespace   CuidadoPorcino.App.Dominio
{
    public class Cerdo
    {
        [Key]
        public int IdCerdos {get; set;}
        public string Nombre {get; set;}   
        public string Color {get; set;} 
        public string Especie {get; set;} 
        public string Raza {get; set;} 

        public Propietario propietario {get; set;} 
        public Veterinario veterinario {get; set;} 
             
    }
}