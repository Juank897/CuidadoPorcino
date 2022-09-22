using System.Collections.Generic;// libreria donde se define la interface
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public interface INRepositorioPersona
    {
        //metodos para hacer el crud, firma de los metodos
        Persona AddPersona(Persona persona); //adiionar persona
        void DeletePersona(int IdPersona); //borrar persona
        IEnumerable<Persona> GetAllPersonas();//listar personas
        Persona GetPersona(int IdPersona); //listar una persona
        Persona UpdatePersona (Persona persona); //modificar persona
        
    }

}
