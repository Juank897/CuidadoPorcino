using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoPorcino.App.Persistencia;
using CuidadoPorcino.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CuidadoPorcino.App.Frontend.Pages
{

    public class IngresarModel : PageModel
    {
        private readonly INRepositorioCerdo repositorioCerdo;
        private readonly INRepositorioPropietario repositorioPropietario;

        public IngresarModel()
        {
            this.repositorioCerdo = new RepositorioCerdo(new CuidadoPorcino.App.Persistencia.AppContext());
            this.repositorioPropietario = new RepositorioPropietario(new CuidadoPorcino.App.Persistencia.AppContext());

        }

        [BindProperty] // enlace con la bd
        public Cerdo cerdo { set; get; }
        public IEnumerable<Propietario> listaPropietario;
        public SelectList lista { get; set; }

        public void OnGet()
        {
            /*

            lista = new SelectList(
        new List<SelectListItem>
        {
        new SelectListItem { Text = "Homeowner", Value = "okis"},
        new SelectListItem { Text = "Contractor", Value = "ok"},
        }, "Value", "Text");
        */

            listaPropietario = this.repositorioPropietario.GetAllPropietarios();
        }


        public IActionResult OnPost()// el clik del boton para almacenar los datos
        {
            repositorioCerdo.AddCerdo(cerdo);
            return RedirectToPage("./listaCerdo");
        }
    }
}
