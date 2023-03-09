using AbstractFactory.Factory;
using AbstractFactory.Models;

//Criando as fabricas
var boloFactory = MassaAbstractFactory.CriarFabricaMassa(TipoMassa.BOLO);
var pizzaFactory = MassaAbstractFactory.CriarFabricaMassa(TipoMassa.PIZZA);

//Criando tipos de bolo
var boloLaranja = boloFactory.CriarMassa((TipoMassa)TipoBolo.LARANJA);
var boloChocolate = boloFactory.CriarMassa((TipoMassa)TipoBolo.CHOCOLATE);

//Criando tipos de pizza
var pizzaMussarela = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.MUSSARELA);
var pizzaCalabresa = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.CALABRESA);


Mostra(boloLaranja);
Mostra(boloChocolate);
Mostra(pizzaMussarela);
Mostra(pizzaCalabresa);

void Mostra(MassaBase massa) {
    Console.WriteLine($"Nome: {massa.Nome}");
    Console.WriteLine($"Tipo: {massa.TipoMassa}");
    Console.WriteLine($"Ingredientes: {massa.Ingredientes[0]}");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}