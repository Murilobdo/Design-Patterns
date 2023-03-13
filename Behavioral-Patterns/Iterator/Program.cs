using Iterator.Models;

ConcreteCollection collection = new();

collection.AddCliente(new Cliente(1, "Murilo"));
collection.AddCliente(new Cliente(2, "Isabel"));
collection.AddCliente(new Cliente(3, "Igor"));
collection.AddCliente(new Cliente(4, "Caio"));
collection.AddCliente(new Cliente(5, "Julia"));


IteratorCollection iterator = collection.CreateIterator();

Console.WriteLine("## Padrão Iterator criado");
Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();

for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
{
    Console.WriteLine($"Id: [{cliente.Id}]  Nome: [{cliente.Nome}]");
}
Console.ReadKey();