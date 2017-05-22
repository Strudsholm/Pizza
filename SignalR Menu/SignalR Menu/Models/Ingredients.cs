using System;
using System.Collections.Generic;

namespace SignalR_Menu.Models
{
    public partial class Ingredients
    {
        public Ingredients()
        {
            PizzaIngredients = new HashSet<PizzaIngredients>();
        }

        public int Iid { get; set; }
        public int? Pepperoni { get; set; }
        public int? Ham { get; set; }
        public int? Tomato { get; set; }
        public int? Cheese { get; set; }

        public string Topping { get; set; }

        public virtual ICollection<PizzaIngredients> PizzaIngredients { get; set; }
    }
}
