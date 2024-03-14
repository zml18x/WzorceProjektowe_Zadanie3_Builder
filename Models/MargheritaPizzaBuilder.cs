using BuilderZad3.Interfaces;

namespace BuilderZad3.Models
{
    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private IPizza _pizza {  get; set; }



        public MargheritaPizzaBuilder()
        {
            _pizza = new Pizza();
            _pizza.Name = "Margherita";
        }



        public void AddDough()
        {
            _pizza.Dough = Enums.DoughType.ThinCrust;
        }

        public void AddMeat()
        {
            _pizza.Meat.Add("No meat");
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
            _pizza.Spices.Add("basil");
        }

        public IPizza GetPizza()
            => _pizza;
    }
}