using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR_Menu.Models;

namespace SignalR_Menu.Models.ViewModels
{
    public class PizzaViewModel
    {
        public List<Ingredients> Ingredients { get; set; }

        public List<Pizza> Pizzas { get; set; }

        public List<PizzaIngredients> PI { get; set; }


    }
}
