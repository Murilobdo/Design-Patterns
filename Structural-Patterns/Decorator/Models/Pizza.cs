using Decorator.Interfaces;

namespace Decorator.Models
{
    public class Pizza : IPizza
    {
        public string Opcionais()
        {
            var pizza = "Pizza padrão ou normal";
            return pizza;
        }

        public decimal Preco()
        {
            var preco = 10.00m;
            return preco;
        }
    }
}