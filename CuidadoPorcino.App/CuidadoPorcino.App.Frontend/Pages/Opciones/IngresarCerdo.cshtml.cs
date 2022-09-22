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
    
    public class IngresarModel : PageModel
    {
        private readonly INRepositorioCerdo repositorioCerdo;

        public IngresarModel()
        {
            this.repositorioCerdo = new RepositorioCerdo(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        
        [BindProperty] // enlace con la bd
        public Cerdo cerdo{set;get;}
        
        public IActionResult OnPost()// el clik del boton para almacenar los datos
        {
            repositorioCerdo.AddCerdo(cerdo); 
            return RedirectToPage("./listaCerdo");           
        }
    }
}
