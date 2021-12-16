using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        public void OnGet()
        {
            
        }

        public LoggedInUser loggedinuser { get; set; }


        public StartsideModel(LoggedInUser user)
        {
            loggedinuser = user;
        }

    }
}
