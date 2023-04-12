using Factory.concreteProduct;
using Factory.creator;
using Factory.product;

namespace Factory.concreteCreator
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CriaPizza(string tipo)
        {
            switch (tipo.ToUpper())
            {
                case "M": return new PizzaMussarelaRJ();
                case "C": return new PizzaCalabresaRJ();
                default : return null;
            }
        }
    }
}