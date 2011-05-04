
using System.Collections.Generic;
using PizzaStoreFranchise.Ingredients.Cheeses;
using PizzaStoreFranchise.Ingredients.Doughs;
using PizzaStoreFranchise.Ingredients.Sauces;
using PizzaStoreFranchise.Ingredients.Toppings.Clams;
using PizzaStoreFranchise.Ingredients.Toppings.Veggies;
namespace PizzaStoreFranchise.Ingredients
{
    class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IEnumerable<ICheese> CreateCheeses()
        {
            IList<ICheese> cheeses = new List<ICheese>() { new ReggianoCheese() };
            return cheeses;
        }

        public IEnumerable<IVeggie> CreateVeggies()
        {
            IList<IVeggie> veggies = new List<IVeggie>() { new Mushrooms(), new Onions() };
            return veggies;
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}
