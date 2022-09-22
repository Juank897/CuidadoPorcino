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
    public class DetallesPersonaModel : PageModel
    {
        private readonly INRepositorioPersona repositorioPersona;
        public Persona persona{set;get;}

        public DetallesPersonaModel()
        {
            this.repositorioPersona = new RepositorioPersona(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int IdPersona)
        {
            persona = repositorioPersona.GetPersona(IdPersona);
            if(persona==null)
            {
                return RedirectToPage("./No_encontrado");
            }else
            {
                return Page();
            }
        }
    }
}
