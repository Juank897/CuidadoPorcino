using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoPorcino.App.Frontend.Pages
{
    public class VeterinarioModel : PageModel
    {
        private string[] vectorOpciones = { "Opcion 1", "Opcion 2", "Opcion 3" };
        public List<string> myLista { get; set; }
        public void OnGet()
        {
            myLista = new List<string>();
            myLista.AddRange(vectorOpciones);
        }
    }
}