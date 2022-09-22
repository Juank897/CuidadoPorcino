using System.Collections.Generic;// libreria donde se define la interface
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public interface INRepositorioCerdo
    {
        //metodos para hacer el crud, firma de losmetodos
        Cerdo AddCerdo(Cerdo cerdo); //adiionar cerdo
        void DeleteCerdo(int IdCerdos); //borrar cerdo
        IEnumerable<Cerdo> GetAllCerdos();//listar cerdos
        Cerdo GetCerdo(int IdCerdos); //listar un cerdo
        Cerdo UpdateCerdo (Cerdo cerdo); //modificar cerdo       
    }

}
