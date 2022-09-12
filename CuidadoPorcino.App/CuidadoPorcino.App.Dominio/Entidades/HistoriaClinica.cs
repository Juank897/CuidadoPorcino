using System;
using System.ComponentModel.DataAnnotations;
namespace   CuidadoPorcino.App.Dominio
{
    public class HistoriaClinica
    {    
        [Key] 
        public int IdHistoriaClinica{get; set;} 
        public string FechaApertura{get; set;} 
        public Cerdo cerdo{get; set;}             
        
    }
}