using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoPorcino.App.Persistencia;
using CuidadoPorcino.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CuidadoPorcino.App.Frontend.Pages
{
    public class ListaPersonaModel : PageModel
    {
        private readonly INRepositorioPersona repositorioPersona;
        public IEnumerable<Persona> personas {set;get;}
        public ListaPersonaModel()
        {
            this.repositorioPersona = new RepositorioPersona(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            personas = repositorioPersona.GetAllPersonas();
        }
    }
}
