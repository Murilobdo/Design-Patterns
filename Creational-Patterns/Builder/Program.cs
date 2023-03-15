
using Builder.ConcreteBuilder;
using Builder.Director;

var pizzaria = new PizzariaDirector(new PizzaCalabresa());
pizzaria.MontarPizza();
var pizzaCalabresa = pizzaria.GetPizza();
pizzaCalabresa.ExibirConteudo();

Console.WriteLine(" ");

pizzaria = new PizzariaDirector(new PizzaMussarela());
pizzaria.MontarPizza();
var pizzaMussarela = pizzaria.GetPizza();
pizzaMussarela.ExibirConteudo();

Console.ReadKey();