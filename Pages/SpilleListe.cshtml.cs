using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.services;
using GamingSiteProject.Pages.Brugere;

using GamingSiteProject.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.SpilleListe
{
    public class SpilleListeModel : PageModel
    {
        private LoggedInUser _loggedInUser;

        private Bruger _bruger;

        [BindProperty]
        public Bruger Bruger
        {
            get => _bruger;
            set => _bruger = value;
        }

 

        public LoggedInUser loggedinuser { get => _loggedInUser; }


        public SpilleListeModel(LoggedInUser loggedInUser)
        {
            _loggedInUser = loggedInUser;

        }

        public IActionResult OnGet()
        {
            if (!loggedinuser.LoggedIn)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
