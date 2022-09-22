using System.Collections.Generic;// libreria donde se define la interface
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public interface INRepositorioControlSignos
    {
        //metodos para hacer el crud, firma de los metodos
        ControlSignos AddControlSignos(ControlSignos controlSignos); //adiionar persona
        void DeleteControlSignos(int IdControlSigno); //borrar persona
        IEnumerable<ControlSignos> GetAllControlSignos();//listar personas
        ControlSignos GetControlSignos(int IdPersona); //listar una persona
        ControlSignos UpdateControlSignos (ControlSignos controlSignos); //modificar persona
    }

}
