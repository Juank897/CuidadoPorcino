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
    public class ListaPropietarioModel : PageModel
    {
        private readonly INRepositorioPropietario repositorioPropietario;
        public IEnumerable<Propietario> propietarios {set;get;}
        public ListaPropietarioModel ()
        {
            this.repositorioPropietario = new RepositorioPropietario(new CuidadoPorcino.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            propietarios = repositorioPropietario.GetAllPropietarios();
        }
    }
}
