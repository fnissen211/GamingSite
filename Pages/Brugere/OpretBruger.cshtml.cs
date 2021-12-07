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

        [BindProperty]
        public Bruger Bruger { get; set; }

        public OpretBrugerModel(IBrugerListe brugerListe)
        {
            _brugerListe = brugerListe;
        }

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

            if (_brugerListe.Bruger.Count == 0)
            {
                Bruger.Id = 1;
            }
            else
            {
                Bruger.Id = _brugerListe.Bruger.Max(b => b.Id) + 1;
            }

            _brugerListe.AddBruger(Bruger);
            return RedirectToPage("/Index");
        }
    }
}
