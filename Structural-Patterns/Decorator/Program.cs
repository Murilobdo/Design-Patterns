
using Decorator.ConcreteDecorator;
using Decorator.Interfaces;
using Decorator.Models;

IPizza pizza = new Pizza();

Console.WriteLine(pizza.Opcionais());
Console.WriteLine($"Preço: {pizza.Preco()}");
Console.WriteLine("Tecle algo para aplicar o padrão Decorator\n\n");
Console.ReadKey();

int escolha = 0;

do
{
    Console.WriteLine("-----------------------------------------------\n");
    Console.WriteLine($"\tPizza: {pizza.Opcionais()}");
    Console.WriteLine($"\tPreço: {pizza.Preco()}\n");

    Console.WriteLine("\tEscolha uma opção para adicionar na pizza:");
    Console.WriteLine("\t1 - Borda recheada");
    Console.WriteLine("\t2 - Massa especial");
    Console.WriteLine("\t3 - Bacon");
    Console.WriteLine("\t0 - Finalizar pedido");
    escolha = Convert.ToInt32(Console.ReadLine());

    pizza = AdicionandoIngredientes(escolha, pizza);
} while (escolha != 0);

Console.WriteLine(pizza.Opcionais());
Console.WriteLine($"Preço: {pizza.Preco()}");

IPizza AdicionandoIngredientes(int escolha, IPizza pizza)
{
    switch (escolha)
    {
        case 1:
            pizza = new BordaRecheadaDecorator(pizza);
            break;
        case 2:
            pizza = new MassaEspecialDecorator(pizza);
            break;
        case 3:
            pizza = new BaconDecorator(pizza);
            break;
        default:
            break;
    }

    return pizza;
}