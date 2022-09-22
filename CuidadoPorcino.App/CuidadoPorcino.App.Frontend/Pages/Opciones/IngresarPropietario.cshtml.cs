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
    public class IngresarPropietarioModel : PageModel
    {
        private readonly INRepositorioPropietario repositorioPropietario;

        public IngresarPropietarioModel()
        {
            this.repositorioPropietario = new RepositorioPropietario(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        
        [BindProperty] // enlace con la bd
        public Propietario propietario{set;get;}

        public IActionResult OnPost()// el clik del boton para almacenar los datos
        {
            repositorioPropietario.AddPropietario(propietario);
            return RedirectToPage("./listaPropietario");            
        }
    }
}
