using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HW2.Pages
{
    public class AThingModel : PageModel
    {
        private readonly ILogger<AThingModel> _logger;

        public AThingModel(ILogger<AThingModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation($"I don't want to miss a thing");
            // _logger.LogInformation((int)LoggingEvents.Networkking,"logwork memories", url);
        }
    }
}
