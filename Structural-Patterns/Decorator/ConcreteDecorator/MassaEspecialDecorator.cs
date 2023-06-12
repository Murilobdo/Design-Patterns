using Decorator.Decorator;
using Decorator.Interfaces;

namespace Decorator.ConcreteDecorator
{
    public class MassaEspecialDecorator : PizzaDecorator
    {
        public MassaEspecialDecorator(IPizza pizza) : base(pizza)
        {

        }

        override public string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\nAdicionando massa especial";
            return pizza;
        }

        override public decimal Preco()
        {
            var preco = base.Preco();
            preco += 3.00m;
            return preco;
        }
    }
}