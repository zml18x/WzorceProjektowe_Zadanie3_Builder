using BuilderZad3.Enums;
using BuilderZad3.Interfaces;

namespace BuilderZad3.Models
{
    public class Pizza : IPizza
    {
        public string? Name { get; set; }
        public DoughType Dough { get; set; }
        public IList<string> Meat { get; set; }
        public IList<string> Cheese { get; set; }
        public IList<string> Vegetables { get; set; }
        public IList<string> Spices { get; set; }



        public Pizza()
        {
            Meat = new List<string>();
            Cheese = new List<string>();
            Vegetables = new List<string>();
            Spices = new List<string>();
        }



        public override string ToString()
        {
            return $"NAME: {(Name != null ? Name : "Empty name")} | DOUGH: {Dough} | MEAT: {string.Join(", ", Meat)}" +
                $" | CHEESE: {string.Join(", ", Cheese)} | VEGETABLES: {string.Join(", ", Vegetables)} | SPICES: {string.Join(", ", Spices)}";
        }
    }
}