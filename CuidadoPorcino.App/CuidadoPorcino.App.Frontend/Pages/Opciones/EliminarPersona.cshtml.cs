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
    public class EliminarPersonaModel : PageModel
    {
        private readonly INRepositorioPersona repositorioPersona;
         public EliminarPersonaModel()
        {
            this.repositorioPersona = new RepositorioPersona(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        [BindProperty] // enlace con la bd
        public Persona persona{set;get;}
        public IActionResult OnGet(int IdPersona)
        {
           persona = repositorioPersona.GetPersona(IdPersona);
            
            if (persona == null)
            {
                return RedirectToPage("./No_encontrado");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            repositorioPersona.DeletePersona(persona.IdPersona);
            return RedirectToPage("./listaPersona");
        }
    }
}
