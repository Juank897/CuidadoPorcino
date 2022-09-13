using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace holaweb.App.Frontend.Pages
{
    public class listasModel : PageModel
    {
        private string[] vectorLista={"id persona","nombre","apellidos","dirrecion","telefono"};
        public List<string>mylista{get;set;}
        

        public void OnGet()
        {
            mylista=new List<string>();
            mylista.AddRange(vectorLista);
           
        }
    }
}
