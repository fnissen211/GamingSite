using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using GamingSiteProject.data;
using GamingSiteProject.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace GamingSiteProject.Startside
{
    public class StartsideModel : PageModel
    {
        private Bruger Bruger;


        public void OnGet()
        {
            if (ModelState.IsValid)
            {
                // do something
                RedirectToPage("/Startside");
            }
            else
            {
                RedirectToPage("/Index");
            }
        }

    }
}
