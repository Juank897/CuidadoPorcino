using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoPorcino.App.Frontend.Pages
{
    public class ControlSignosModel : PageModel
    {

        private string [] vectorOpciones={"E1","E2","E3","E4","E5","E6","E7","E8","E9","E10"};

        public List<string> myLista { get; set; }
        public void OnGet()
        {
            myLista = new List<string>();
            myLista.AddRange(vectorOpciones);
        }
    }
}
