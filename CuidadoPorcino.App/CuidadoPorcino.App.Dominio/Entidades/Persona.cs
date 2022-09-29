using System;
using System.ComponentModel.DataAnnotations;

namespace CuidadoPorcino.App.Dominio
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }

        //[Required, StringLenght(50)]
        public string Nombres { get; set; }

        //[Required, StringLenght(50)]
        public string Apellidos { get; set; }
        
        //[Required, StringLenght(50)]
        public string Direccion { get; set; }

        //[Required, StringLenght(50)]
        public string Telefono { get; set; }

    }
}