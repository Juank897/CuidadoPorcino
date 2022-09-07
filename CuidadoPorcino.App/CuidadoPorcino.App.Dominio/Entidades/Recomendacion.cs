using System;
using System.ComponentModel.DataAnnotations;
namespace   CuidadoPorcino.App.Dominio
{
    public class Recomendacion
    {   
        [Key]  
        public int IdRecomendacion{get; set;}  
        public string DescripcionRecomendacion{get; set;} 
        public string FormulaMedicamentos{get; set;}      
        
    }
}