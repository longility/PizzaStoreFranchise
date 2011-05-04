using System.Collections.Generic;
using PizzaStoreFranchise.Ingredients.Cheeses;
using PizzaStoreFranchise.Ingredients.Doughs;
using PizzaStoreFranchise.Ingredients.Sauces;
using PizzaStoreFranchise.Ingredients.Toppings.Clams;
using PizzaStoreFranchise.Ingredients.Toppings.Veggies;

namespace PizzaStoreFranchise.Ingredients
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IEnumerable<ICheese> CreateCheeses()
        {
            IList<ICheese> cheeses = new List<ICheese>() { new MozzarellaCheese(), new ParmesanCheese() };
            return cheeses;
        }

        public IEnumerable<IVeggie> CreateVeggies()
        {
            IList<IVeggie> veggies = new List<IVeggie>() { new Eggplant(), new Spinach(), new BlackOlives() };
            return veggies;
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
