using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.data;
using GamingSiteProject.Pages.Brugere;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSiteProject.Pages
{
    public class ProfileModel : PageModel
    {
        private Bruger _bruger;


        public Bruger Bruger
        {
            get => _bruger;
            set => _bruger = value;
        }

        public ProfileModel()
        {
            
        }

        public void OnGet()
        {
        }
    }
}
