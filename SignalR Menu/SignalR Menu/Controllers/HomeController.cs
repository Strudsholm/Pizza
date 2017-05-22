using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalR_Menu.Models;
using SignalR_Menu.Models.ViewModels;

namespace SignalR_Menu.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Pizzas()
        {
            PizzaMenuContext dbcontext = new PizzaMenuContext();
            var PVM = new PizzaViewModel()
            {
                Ingredients = dbcontext.Ingredients.ToList(),
                Pizzas = dbcontext.Pizza.ToList(),
                PI = dbcontext.PizzaIngredients.ToList()
            };

           
            return View("Pizzas", PVM);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
