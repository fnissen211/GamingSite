using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamingSiteProject.data;

namespace GamingSiteProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Bruger _bruger;

        public Bruger Bruger
        {
            get => _bruger;
            set => _bruger = value;
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

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
