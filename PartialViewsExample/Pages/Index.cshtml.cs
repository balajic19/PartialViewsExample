using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PartialViewsExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewsExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Movies> Movies = new List<Movies>
        {
            new Movies { Title = "Eternals", Description = "Super hero", Duration = TimeSpan.FromMinutes(23) },
            new Movies { Title = "No way home", Description = "Friendly neighbourhood", Duration = TimeSpan.FromMinutes(22) },
            new Movies { Title = "Venom", Description = "Villain", Duration = TimeSpan.FromMinutes(21) }
        };

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnGetPartial() =>
                Partial("ProductPartial");
    }
}
