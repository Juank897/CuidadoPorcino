using System;
namespace   CuidadoPorcino.App.Dominio
{
    public class ControlSignos
    {
        public int IdControlSigno {get; set;}
        public double Temperatura {get; set;}   
        public double Peso {get; set;} 
        public int FrecuenciaRespiratoria {get; set;} 
        public int FrecuenciaCardiaca {get; set;} 
        public string EstadoDeAnimo {get; set;}       
    }
}