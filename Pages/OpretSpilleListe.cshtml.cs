using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.services;
using GamingSiteProject.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.Pages
{
    public class OpretSpilleListeModel : PageModel
    {

        public LoggedInUser loggedinuser { get; set; }
        private IBrugerListe _brugerListe;

        [BindProperty]
        public Bruger Bruger { get; set; }

        public OpretSpilleListeModel(LoggedInUser user, IBrugerListe brugerListe)
        {
            loggedinuser = user;
            _brugerListe = brugerListe;
        }

        public IActionResult OnGet()
        {
            if (!loggedinuser.LoggedIn)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (loggedinuser.LoggedIn)
            {
                

                return RedirectToPage("/Profile");
            }


            return Page();
        }
    }
}
