using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoPorcino.App.Persistencia;
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Frontend.Pages
{

    public class ListaModel : PageModel
    {
        private readonly INRepositorioCerdo repositorioCerdo;
        public IEnumerable <Cerdo> cerdos{set;get;}
        public ListaModel()
        {
            this.repositorioCerdo = new RepositorioCerdo(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        public void OnGet(string busqueda)
        {
            cerdos=repositorioCerdo.GetAllCerdos();
        }
    }
}
