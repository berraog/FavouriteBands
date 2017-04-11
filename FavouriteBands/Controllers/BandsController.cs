using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FavouriteBands.Models;
using static FavouriteBands.Models.DataManager;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FavouriteBands.Controllers
{
    public class BandsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Bands = GetAllBands(); 
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.Band = GetBandById(id); 
            return View();
        }
    }
}
