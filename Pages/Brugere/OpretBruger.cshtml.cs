using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using GamingSiteProject.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.Pages.Brugere
{
    public class OpretBrugerModel : PageModel
    {
        [BindProperty]
        public Bruger Bruger { get; set; }

        public List<Bruger> BrugerListe { get; private set; }

        public IActionResult OnGet()
        {
            
            
            return Page();
        }

        public IActionResult OnPost()
        {
            
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            BrugerListe.Add(Bruger);
            


            return Redirect("/Startside");

        }
    }
}
