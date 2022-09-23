using System.Collections.Generic;// libreria donde se define la interface
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public interface INRepositorioPropietario
    {
        //metodos para hacer el crud, firma de los metodos
        Propietario AddPropietario(Propietario propietario); //adiionar persona
        void DeletePropietario(int IdPropietario); //borrar persona
        IEnumerable<Propietario> GetAllPropietarios();//listar personas
        Propietario GetPropietario(int IdPropietario); //listar una persona
        Propietario UpdatePropietario (Propietario propietario); //modificar persona
        
        //public Persona AsignarPersona(int idPersona, Propietario propietario);
    }

}
