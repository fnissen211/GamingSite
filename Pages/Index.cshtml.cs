using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.data;
using GamingSiteProject.services;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GamingSiteProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Bruger _bruger;
        private IBrugerListe _brugerListe;
        private LoggedInUser _loggedInUser;
        
        public string FejlTekst;

        public LoggedInUser loggedinuser { get => _loggedInUser; }

        [BindProperty]
        public Bruger Bruger
        {
            get => _bruger;
            set => _bruger = value;
        }

        public IBrugerListe BrugerListe
        {
            get => _brugerListe;
            set => _brugerListe = value;
        }

        public IndexModel(ILogger<IndexModel> logger, IBrugerListe brugerListe, LoggedInUser loggedInUser)
        {
            _logger = logger;
            _brugerListe = brugerListe;
            _loggedInUser = loggedInUser;
        }

        public IActionResult OnGet()
        {
            // _brugerListe = new BrugerListe();
            
                return Page();
        }

        public IActionResult OnPost(Bruger bruger)
        {
            var result = _brugerListe.CheckBruger(bruger);
            if (result)
            {
                _loggedInUser.LoggedIn = true;
                _loggedInUser.Navn = bruger.Navn;
                return RedirectToPage("/Startside");
            }
            else
            {
                FejlTekst = "Du findes ikke i systemet. Prøv igen.";
                return Page();
            }
        }
    }
}


/*
 * @{
    var xx = "light";
}

@section Scripts
{
    <script>
        function RazorFunction() {
            if ('@xx' == 'dark') {
                $("#yy").addClass('light');
                @xx = "light";
            } else {
                $("#yy").addClass('dark');
                @xx = "dark";
            }


        }

    </script>
}

<div class="text-center" + @xx id="yy">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://docs.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
    <button  type="button" style="border-color: red" onclick="RazorFunction()">Skift Farve</button>
</div>



 */
