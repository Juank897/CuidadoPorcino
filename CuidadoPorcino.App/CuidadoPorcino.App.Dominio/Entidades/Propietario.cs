using System;
using System.ComponentModel.DataAnnotations;
namespace CuidadoPorcino.App.Dominio
{
    public class Propietario
    {
        [Key]
        public int IdPropietario { get; set; }
        public string Email{get; set;} 


        public Persona persona { get; set; }
       

    }
}
