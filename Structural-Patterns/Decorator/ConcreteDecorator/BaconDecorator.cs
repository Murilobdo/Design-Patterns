using Decorator.Decorator;
using Decorator.Interfaces;

namespace Decorator.ConcreteDecorator
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\nAdicionando bacon";
            return pizza;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 2.00m;
            return preco;
        }        
    }
}