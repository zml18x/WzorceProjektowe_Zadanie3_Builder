using BuilderZad3.Models;

var pizzaBuilder = new MargheritaPizzaBuilder();
var salamiPizzaBuilder = new SalamiPizzaBuilder();

var client = new PizzaClient();

var margheritaPizza = client.MakePizza(pizzaBuilder);
var salamiPizza = client.MakePizza(salamiPizzaBuilder);


Console.WriteLine(margheritaPizza.ToString());
Console.WriteLine(salamiPizza.ToString());
