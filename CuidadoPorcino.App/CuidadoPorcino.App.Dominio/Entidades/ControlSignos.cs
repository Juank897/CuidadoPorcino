using System;
using System.ComponentModel.DataAnnotations;
namespace CuidadoPorcino.App.Dominio
{
    public class ControlSignos
    {
        [Key]
        public int IdControlSigno { get; set; }
        public double Temperatura { get; set; }
        public double Peso { get; set; }
        public int FrecuenciaRespiratoria { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public string EstadoDeAnimo { get; set; }
        public string DescripcionRecomendacion { get; set; }
        public string FormulaMedicamentos { get; set; }
        public DateTime FechaVisita { get; set; }
        public HistoriaClinica historiaClinica { get; set; }
    }
}