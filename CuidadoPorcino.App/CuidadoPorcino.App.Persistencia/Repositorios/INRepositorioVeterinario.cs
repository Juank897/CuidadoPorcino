using System.Collections.Generic;// libreria donde se define la interface
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public interface INRepositorioVeterinario
    {
        //metodos para hacer el crud, firma de los metodos
        Veterinario AddVeterinario(Veterinario veterinario); //adiionar persona
        void DeleteVeterinario(int IdVeterinario); //borrar persona
        IEnumerable<Veterinario> GetAllVeterinarios();//listar personas
        Veterinario GetVeterinario(int IdVeterinario); //listar una persona
        Veterinario UpdateVeterinario (Veterinario veterinario); //modificar persona
        
        
    }

}
