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
    
    public class DetallesModel : PageModel
    {
        private readonly INRepositorioCerdo repositorioCerdo;
        public Cerdo cerdo {set;get;}
        public DetallesModel()
        {
            this.repositorioCerdo = new RepositorioCerdo(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int IdCerdos)
        {
            cerdo = repositorioCerdo.GetCerdo(IdCerdos);
            if(cerdo==null)
            {
                return RedirectToPage("./No_encontrado");
            }else
            {
                return Page();
            }
        }
    }
}
