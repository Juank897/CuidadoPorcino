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
    public class IngresarPersonaModel : PageModel
    {
        private readonly INRepositorioPersona repositorioPersona;

        public IngresarPersonaModel()
        {
            this.repositorioPersona = new RepositorioPersona(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        
        [BindProperty] // enlace con la bd
        public Persona persona{set;get;}
        
        public IActionResult OnPost()// el clik del boton para almacenar los datos
        {
            repositorioPersona.AddPersona(persona);
            return RedirectToPage("./listaPersona");            
        }
    }
}
