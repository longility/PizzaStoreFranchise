
using System.Collections.Generic;
namespace PizzaStoreFranchise.Pizzas.NyStyle
{
    class NyStyleCheesePizza : NyStylePizza
    {
        List<string> toppings = new List<string>();

        public NyStyleCheesePizza()
        {
            toppings.Add("Reggiano Cheese");
        }

        public override string Name
        {
            get { return "Chicago Style Cheese Pizza"; }
        }

        protected override string Sauce
        {
            get { return "Marinara Sauce"; }
        }

        protected override IEnumerable<string> Toppings
        {
            get { return toppings; }
        }
    }
}
