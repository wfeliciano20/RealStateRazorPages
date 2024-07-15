using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RealEstateWebApp.Models;
using RealEstateWebApp.services;

namespace RealEstateWebApp.Pages
{
    public class AddHomeModel : PageModel
    {
        private readonly HomeService _homeService;

        public AddHomeModel(HomeService homeService)
        {
            _homeService = homeService;

        }

        [BindProperty]
        public Home NewHome { get; set; }

        public IActionResult OnPost()
        {
            _homeService.AddHome(NewHome);
            return RedirectToPage("Index");
        }
    }
}