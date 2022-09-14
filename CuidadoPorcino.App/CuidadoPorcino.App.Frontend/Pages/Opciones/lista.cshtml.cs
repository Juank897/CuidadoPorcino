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

    public class listaModel : PageModel
    {
        private readonly INRepositorioCerdo repositorioCerdo;
        public IEnumerable<Cerdo> cerdos {set;get;}
        public listaModel()
        {
            this.repositorioCerdo = new RepositorioCerdo(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            cerdos = repositorioCerdo.GetAllCerdos();            

        }
    }
}
