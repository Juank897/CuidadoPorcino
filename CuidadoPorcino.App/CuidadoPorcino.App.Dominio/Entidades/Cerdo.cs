using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CuidadoPorcino.App.Dominio
{
    public class Cerdo
    {
        [Key]
        public int IdCerdos {get; set;}
        public string Nombre {get; set;}   
        public string Color {get; set;} 
        public string Especie {get; set;} 
        public string Raza {get; set;} 

        public int IdPropietario{get;set;}

        [ForeignKey("IdPropietario")]
        public virtual Propietario propietario {set;get;}        
        //public Propietario propietario {set;get;}
        //public Veterinario veterinario {set;get;}
        //public Veterinario veterinario {set;get;}

             
    }
}