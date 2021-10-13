using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeo_sPizza.Models
{
    public class PizzaBO
    {
        public static List<Pizza> PizzaList = new List<Pizza>
            {
                new Pizza{Id=1001,PizzaType="Capsicum", cost=50,ExtraToppings=false,Quantity=20},
                new Pizza{Id=1002,PizzaType="Onion", cost=60,ExtraToppings=false,Quantity=26},
                new Pizza{Id=1003,PizzaType="Tamato", cost=70,ExtraToppings=false,Quantity=80},
                new Pizza{Id=1004,PizzaType="Veg loaded", cost=150,ExtraToppings=false,Quantity=56},
            };
        public PizzaBO()
        {
           
        }
        public List<Pizza> getAllPizza()
        {
            return PizzaList;
        }
        public Pizza getPizzaById(int id)
        {
            return PizzaList.Single(x => x.Id == id);
        }
        public void order(Pizza p)
        {
            Pizza indPizza = PizzaList.Single(x => x.Id == p.Id);
            int index = PizzaList.IndexOf(indPizza);
            PizzaList[index]=p;
            
        }
    }
}
