using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.services;
using GamingSiteProject.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.SpilleListe
{
    public class SpilleListeModel : PageModel
    {
        public LoggedInUser loggedinuser { get; set; }

        public SpilleListeModel(LoggedInUser user)
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
