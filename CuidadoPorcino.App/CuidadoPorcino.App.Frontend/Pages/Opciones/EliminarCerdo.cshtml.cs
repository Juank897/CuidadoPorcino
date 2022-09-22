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
    public class EliminarCerdoModel : PageModel
    {
        private readonly INRepositorioCerdo repositorioCerdo;

        public EliminarCerdoModel()
        {
            this.repositorioCerdo = new RepositorioCerdo(new CuidadoPorcino.App.Persistencia.AppContext());
        }

        [BindProperty] // enlace con la bd
        public Cerdo cerdo {set;get;}
       
        public IActionResult OnGet(int IdCerdos)
        {
            cerdo = repositorioCerdo.GetCerdo(IdCerdos);
            if(cerdo==null)
            {
                return RedirectToPage("./NoFound");
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            repositorioCerdo.DeleteCerdo(cerdo.IdCerdos);
            return RedirectToPage("./listaCerdo");
        }
    }
}
