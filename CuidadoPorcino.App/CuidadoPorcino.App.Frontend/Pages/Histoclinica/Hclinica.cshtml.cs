using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace holaweb.App.Frontend.Pages
{
    public class Hclinica : PageModel
    {
        private string[] vectorLista2 = { "id Historia", "Fecha de apertura","id cerdo" };
        public List<string> mylista2 { get; set; }
        public void OnGet()
        {
            mylista2 = new List<string>();
            mylista2.AddRange(vectorLista2);
        }
    }
}
