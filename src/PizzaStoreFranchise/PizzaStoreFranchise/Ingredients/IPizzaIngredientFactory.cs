
using PizzaStoreFranchise.Ingredients.Cheeses;
using PizzaStoreFranchise.Ingredients.Doughs;
using PizzaStoreFranchise.Ingredients.Sauces;
using PizzaStoreFranchise.Ingredients.Toppings.Veggies;
using PizzaStoreFranchise.Ingredients.Toppings.Clams;
using System.Collections.Generic;
namespace PizzaStoreFranchise.Ingredients
{
    interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        IEnumerable<ICheese> CreateCheeses();
        IEnumerable<IVeggie> CreateVeggies();
        IClams CreateClams();
    }
}
