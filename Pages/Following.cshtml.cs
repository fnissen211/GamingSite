using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.Pages
{
    public class FollowingModel : PageModel
    {

        public LoggedInUser loggedinuser { get; set; }

        public FollowingModel(LoggedInUser user)
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
