
using System.Collections.Generic;
namespace PizzaStoreFranchise.Pizzas.NyStyle
{
    class NyStyleGreekPizza : NyStylePizza
    {
        List<string> toppings = new List<string>();

        public NyStyleGreekPizza()
        {
            toppings.Add("Reggiano Cheese");
            toppings.Add("Gyro");
        }

        public override string Name
        {
            get { return "Chicago Style Greek Pizza"; }
        }

        protected override string Sauce
        {
            get { return "White Sauce"; }
        }

        protected override IEnumerable<string> Toppings
        {
            get { return toppings; }
        }
    }

}
