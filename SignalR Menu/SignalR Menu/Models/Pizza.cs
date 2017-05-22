using System;
using System.Collections.Generic;

namespace SignalR_Menu.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaIngredients = new HashSet<PizzaIngredients>();
        }

        public int Pid { get; set; }
        public string Title { get; set; }

        //public List<string> Fyld { get; set; }

        public virtual ICollection<PizzaIngredients> PizzaIngredients { get; set; }
    }
}
