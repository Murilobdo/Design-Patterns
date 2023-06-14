

using Flyweight.Models;

for (int i = 0; i < 3; i++)
{
    var circulo = (Circulo)FormaFactory.GetForma("Circulo");
    circulo.SetCor("Verde");
    circulo.Desenhar();
}