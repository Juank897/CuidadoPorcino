using System.Collections.Generic;
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public interface INRepositorioCerdo
    {
        //metodos para hacer el crud
        Cerdo AddCerdo(Cerdo cerdo); //adiionar cerdo
        void DeleteCerdo(int IdCerdos); //borrar cerdo
        IEnumerable<Cerdo> GetAllCerdos();//listar cerdos
        Cerdo GetCerdo(int IdCerdos); //listar un cerdo
        Cerdo UpdateCerdo (Cerdo cerdo); //modificar cerdo
    }

}
