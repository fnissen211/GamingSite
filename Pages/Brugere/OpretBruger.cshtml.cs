using System.Collections.Generic;
using System.Linq;
using GamingSiteProject.data;
using GamingSiteProject.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.Pages.Brugere
{
    public class OpretBrugerModel : PageModel
    {
        private IBrugerListe _brugerListe;

        private LoggedInUser _loggedInUser;

        [BindProperty]
        public Bruger Bruger { get; set; }

        public OpretBrugerModel(IBrugerListe brugerListe, LoggedInUser loggedInUser)
        {
            _brugerListe = brugerListe;
            _loggedInUser = loggedInUser;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(Bruger bruger)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (_brugerListe.Bruger.Count == 0)
            {
                Bruger.Id = 1;
                
            }
            else
            {
                Bruger.Id = _brugerListe.Bruger.Max(b => b.Id) + 1;
            }

            
            _brugerListe.AddBruger(Bruger);
            _loggedInUser.GamesList = bruger.GamesList;



            return RedirectToPage("/Startside");
        }
    }
}
