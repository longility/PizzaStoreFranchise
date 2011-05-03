
using System.Collections.Generic;
namespace PizzaStoreFranchise.Pizzas.NyStyle
{
    class NyStylePepperoniPizza : NyStylePizza
    {
        List<string> toppings = new List<string>();

        public NyStylePepperoniPizza()
        {
            toppings.Add("Reggiano Cheese");
            toppings.Add("Pepperoni");
        }

        public override string Name
        {
            get { return "Chicago Style Pepperoni Pizza"; }
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
