using System;
using System.Collections.Generic;

namespace SignalR_Menu.Models
{
    public partial class PizzaIngredients
    {
        public int Pid { get; set; }
        public int Iid { get; set; }

        public virtual Ingredients I { get; set; }
        public virtual Pizza P { get; set; }
    }
}
