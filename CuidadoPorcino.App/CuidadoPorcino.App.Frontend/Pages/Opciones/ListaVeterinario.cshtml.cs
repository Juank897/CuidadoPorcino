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
    public class ListaVeterinarioModel : PageModel
    {
        private readonly INRepositorioVeterinario repositorioVeterinario;
        public IEnumerable<Veterinario> veterinarios {set;get;}
        public ListaVeterinarioModel()
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
             veterinarios = repositorioVeterinario.GetAllVeterinarios();
        }
    }
}
