using Factory.concreteCreator;
using Factory.creator;

namespace Factory
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            switch (local.ToUpper())
            {
                case "SP": return new PizzaFactorySP();
                case "RJ": return new PizzaFactoryRJ();
                default: return null;
            }
        }
    }
}