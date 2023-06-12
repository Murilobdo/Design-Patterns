using Decorator.Decorator;
using Decorator.Interfaces;

namespace Decorator.ConcreteDecorator
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string Opcionais()
        {
            var pizza = base.Opcionais();
            pizza += "\nAdicionando borda recheada";
            return pizza;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 5.00m;
            return preco;
        }
    }
}