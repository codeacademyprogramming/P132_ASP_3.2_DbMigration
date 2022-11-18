using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaDbContext _context;

        public HomeController(EternaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Services = Data.Services,
                Features = _context.Features.ToList(),
                Sliders = Data.Sliders
        };
            return View(vm);
        }
    }
}
