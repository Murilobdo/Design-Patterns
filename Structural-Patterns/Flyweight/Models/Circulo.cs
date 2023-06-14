using Flyweight.Interfaces;

namespace Flyweight.Models
{
    public class Circulo : IForma
    {
        //Estrado Extrinseco (Externo)
        public string Cor { get; set; } = string.Empty;

        //Estrado Intrinseco (Interno - Cache)
        public int Raio { get; set; } = 30;
        public int X { get; set; } = 10;
        public int Y { get; set; } = 20;

        public void SetCor(string cor) => Cor = cor;

        public void Desenhar()
        {
            Console.WriteLine($"Circulo: Desenhar() [Cor: {Cor}, Raio: {Raio}, X: {X}, Y: {Y}]");
        }
    }
}