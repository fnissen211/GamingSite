using GamingSiteProject.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.Pages.Brugere
{
    public class OpretBrugerModel : PageModel
    {
        [BindProperty]
        public Bruger Bruger { get; set; }

        public void OnGet()
        {
            //Bruger = new Bruger();
        }

        public void OnPost()
        {
            string dummy = Bruger.Navn;
        }
    }
}
