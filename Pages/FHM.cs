using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HW2.Pages
{
    public class FHMModel : PageModel
    {
        private readonly ILogger<FHMModel> _logger;

        public FHMModel(ILogger<FHMModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // _logger.LogInformation((int)LoggingEvents.Networkking,"logwork memories", url);
        }
    }
}
