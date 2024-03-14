using BuilderZad3.Interfaces;

namespace BuilderZad3.Models
{
    public class PizzaDirector : IPizzaDirector
    {
        private readonly IPizzaBuilder _pizzaBuilder;



        public PizzaDirector(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }



        public void ConstructPizza()
        {
            _pizzaBuilder.AddDough();
            _pizzaBuilder.AddCheese();
            _pizzaBuilder.AddMeat();
            _pizzaBuilder.AddVegetables();
            _pizzaBuilder.AddSpices();
        }
    }
}