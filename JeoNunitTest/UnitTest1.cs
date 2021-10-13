using NUnit.Framework;
using Jeo_sPizza;
using Jeo_sPizza.Models;
using System.Collections.Generic;

namespace JeoNunitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        PizzaBO _context = new PizzaBO();
        [Test]
        public void GetAllPizzas()
        {
            List<Pizza> ExpectedPizzaList = new List<Pizza>
            {
                new Pizza{Id=1001,PizzaType="Capsicum", cost=50,ExtraToppings=false,Quantity=20},
                new Pizza{Id=1002,PizzaType="Onion", cost=60,ExtraToppings=false,Quantity=26},
                new Pizza{Id=1003,PizzaType="Tamato", cost=70,ExtraToppings=false,Quantity=80},
                new Pizza{Id=1004,PizzaType="Veg loaded", cost=150,ExtraToppings=false,Quantity=56},
            };
            List<Pizza> acutalPizzaList = _context.getAllPizza();
            Assert.AreEqual(acutalPizzaList, ExpectedPizzaList);
        }
        [Test]
        public void GetPizzaById()
        {
            Pizza ExpectedPizza = new Pizza { Id = 1001, PizzaType = "Capsicum", cost = 50, ExtraToppings = false, Quantity = 20 };
            Pizza acutalPizza = _context.getPizzaById(1001);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
        }
        [Test]
        public void Order()
        {
            Pizza ExpectedPizza = new Pizza { Id = 1001, PizzaType = "Capsicum Pizza", cost = 50, ExtraToppings = false, Quantity = 20 };
            _context.order(ExpectedPizza);
            Pizza acutalPizza = _context.getPizzaById(1001);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
        }
    }
}