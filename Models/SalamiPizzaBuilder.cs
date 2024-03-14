using BuilderZad3.Interfaces;

namespace BuilderZad3.Models
{
    public class SalamiPizzaBuilder : IPizzaBuilder
    {
        private IPizza _pizza { get; set; }



        public SalamiPizzaBuilder()
        {
            _pizza = new Pizza();
            _pizza.Name = "Salami";
        }



        public void AddDough()
        {
            _pizza.Dough = Enums.DoughType.ThickCrust;
        }

        public void AddMeat()
        {
            _pizza.Meat.Add("salami");
        }

        public void AddCheese()
        {
            _pizza.Cheese.Add("mozarella");
        }

        public void AddVegetables()
        {
            _pizza.Vegetables.Add("tomatoes");
        }

        public void AddSpices()
        {
            _pizza.Spices.Add("oregano");
        }

        public IPizza GetPizza()
            => _pizza;
    }
}
