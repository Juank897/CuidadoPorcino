using System.Collections.Generic;// libreria donde se define la interface
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public interface INRepositorioHistoriaClinica
    {
        //metodos para hacer el crud, firma de los metodos
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica); //adiionar persona
        void DeleteHistoriaClinica(int IdHistoriaClinica); //borrar persona
        IEnumerable<HistoriaClinica> GetAllHistoriaClinica();//listar personas
        HistoriaClinica GetHistoriaClinica(int IdHistoriaClinica); //listar una persona
        HistoriaClinica UpdateHistoriaClinica (HistoriaClinica historiaClinica); //modificar persona
    }

}
