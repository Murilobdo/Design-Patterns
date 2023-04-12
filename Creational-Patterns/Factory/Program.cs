


using Factory;
using Factory.creator;
using Factory.product;

PizzaFactoryMethod pizzariaSP = PizzaSimpleFactory.CriarPizzaria("SP");

Pizza pizzaMussarelaSP = pizzariaSP.MontaPizza("M");
Console.WriteLine(pizzaMussarelaSP.Preparar());

Console.WriteLine("----------------------------------------------------------------------");

PizzaFactoryMethod pizzariaRJ = PizzaSimpleFactory.CriarPizzaria("RJ");
Pizza pizzaCalabresalaSP = pizzariaRJ.MontaPizza("C");
Console.WriteLine(pizzaCalabresalaSP.Preparar());
