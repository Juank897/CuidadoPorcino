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
    public class IngresarVeterinarioModel : PageModel
    {
        private readonly INRepositorioVeterinario repositorioVeterinario;
        public IngresarVeterinarioModel()
        {
            this.repositorioVeterinario = new RepositorioVeterinario(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        [BindProperty] // enlace con la bd
        public Veterinario veterinario { set; get; }

        public IActionResult OnPost()// el clik del boton para almacenar los datos
        {
            repositorioVeterinario.AddVeterinario(veterinario);
            return RedirectToPage("./listaVeterinario");
        }
    }
}
