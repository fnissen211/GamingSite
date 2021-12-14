using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.data;
using GamingSiteProject.Pages.Brugere;
using GamingSiteProject.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.Pages
{
    public class ProfileModel : PageModel
    {
        private Bruger _bruger;

        public LoggedInUser loggedinuser { get; set; }

        [BindProperty]
        public Bruger Bruger
        {
            get => _bruger;
            set => _bruger = value;
        }

        public ProfileModel(LoggedInUser user)
        {
            loggedinuser = user;
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
