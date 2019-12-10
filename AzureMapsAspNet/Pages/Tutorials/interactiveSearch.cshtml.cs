using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AzureMapsAspNet.Data;
using Microsoft.Extensions.Configuration;

namespace AzureMapsAspNet.Tutorials
{
    public class interactiveSearchModel : PageModel
    {
        private readonly IConfiguration _config;
        public string _subscriptionKey = null;

        public interactiveSearchModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            var azureMapsConfig = _config.GetSection("AzureMapsSubKey")
                .Get<AzureMapsSubKey>();
            _subscriptionKey = azureMapsConfig.subscriptionKey;
            ViewData["Message"] = $"My Azure Map Sub Key ={_subscriptionKey}";

            ViewData["subKey"] = _subscriptionKey;
        }
    }
}
