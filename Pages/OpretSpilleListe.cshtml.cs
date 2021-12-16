using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.services;
using GamingSiteProject.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GamingSiteProject.Pages
{
    public class OpretSpilleListeModel : PageModel
    {
        

        public LoggedInUser loggedInUser { get; set; }


        private IBrugerListe _brugerListe;

        [BindProperty]
        public Bruger Bruger { get; set; }


        public OpretSpilleListeModel(LoggedInUser user, IBrugerListe brugerListe)
        {
            loggedInUser = user;
            _brugerListe = brugerListe;


        }

        public IActionResult OnGet()
        {
            if (!loggedInUser.LoggedIn)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }

        
        public IActionResult OnPost()
        {

            if (loggedInUser.LoggedIn)
            {

                _brugerListe.AddGame(loggedInUser.Navn,Bruger.GamesList);
                loggedInUser.GamesList.AddRange(Bruger.GamesList);

                return RedirectToPage("/Profile");
            }


            return Page();
        }


    }
}
